using System.Diagnostics;
using System.Threading.Tasks;
using BIA.Dashboard.Template.Infrastructure;
using BIA.Dashboard.Template.Infrastructure.ErrorHandling;
using Microsoft.AspNetCore.Mvc;
using BIA.Dashboard.Template.Models;
using BIA.Dashboard.Template.Models.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Logging;
using BIA.Dashboard.Template.Data;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace BIA.Dashboard.Template.Controllers
{
    [Authorize]
    public class UserAccessController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment hostingEnvironment;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly ILogger<RegisterViewModel> _logger;
        private readonly SignInManager<ApplicationUser> signInManager;

        public UserAccessController(ApplicationDbContext context, IWebHostEnvironment environment, UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, ILogger<RegisterViewModel> logger)
        {
            _context = context;
            hostingEnvironment = environment;
            this.userManager = userManager;
            _logger = logger;
            this.signInManager = signInManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index(string searchString, string currentFilter, int? pageNumber)
        {
            if (searchString != null)
            {
                pageNumber = 1;
            }
            else
            {
                searchString = currentFilter;
            }

            ViewData["CurrentFilter"] = searchString;
            var users = userManager.Users;

            if (!String.IsNullOrEmpty(searchString))
            {
                users = users.Where(s => (s.Email.Contains(searchString)));
            }
            int pageSize = 10;
            return View(await PaginatedList<ApplicationUser>.CreateAsync(users.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        // GET: UserAccess/AddNewUser
        [HttpGet]
        public IActionResult AddNewUser()
        {
            return View();
        }

        // POST: UserAccess/AddNewUser
        [HttpPost]
        public async Task<IActionResult> AddNewUser(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {

                var userEmail = _context.Users.FirstOrDefault(u => u.Email == model.Email);

                if (userEmail != null)
                {
                    ModelState.AddModelError("Email", "Email is already in use.");
                    return View();
                }

                // Copy data from RegisterViewModel to IdentityUser
                var user = new ApplicationUser
                {
                    UserName = model.Email,
                    Email = model.Email,
                    EmailConfirmed = true
                };

                // Store user data in AspNetUsers database table
                var result = await userManager.CreateAsync(user, model.Password);

                // If user is successfully created, sign-in the user using
                // SignInManager and redirect to index action of HomeController
                //if (result.Succeeded)
                //{
                //    await signInManager.SignInAsync(user, isPersistent: false);
                //    return RedirectToAction("index", "home");
                //}

                // If there are any errors, add them to the ModelState object
                // which will be displayed by the validation summary tag helper
                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }

                if (result.Errors.ToList().Count() != 0)
                {
                    return View();
                }

                var newPersonnelInformationUser = new PersonnelInformationUser
                {
                    ApplicationUserId = user.Id
                };
                _context.PersonnelInformationUser.Add(newPersonnelInformationUser);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }

            //return View(model);
             return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> ManageUserDetails(string Id) 
        {
            var user = await userManager.FindByNameAsync(Id);

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userManager.GetUserId(User)}'.");
            }
            return View(user);
        }

        //[HttpPost]
        //public async Task<IActionResult> ManageUserDetails(string Id)
        //{
        //    var user = await userManager.GetUserAsync(User);
        //    if (user == null)
        //    {
        //        return NotFound($"Unable to load user with ID '{userManager.GetUserId(User)}'.");
        //    }
            
        //    return RedirectToAction("Index");
        //}

        [HttpGet]
        public IActionResult ChangePassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangePassword(ChangePasswordViewModel model)
        {
            var user = await userManager.GetUserAsync(User);
            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userManager.GetUserId(User)}'.");
            }

            var token = await userManager.GeneratePasswordResetTokenAsync(user);
            var result = await userManager.ResetPasswordAsync(user, token, model.ConfirmPassword);

            return RedirectToAction(nameof(Index));

        }


        /// <summary>
        /// Method to update the user enable disabled status
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isenable"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult> ChangeUserStatus(string id, int isenable)
        {
            var user= await _context.Users.FirstOrDefaultAsync(x => x.Id == id);
            if (user!=null)
            {
                user.IsEnabled = isenable == 1 ? false : true;
                await _context.SaveChangesAsync();
            }


            return RedirectToAction(nameof(Index));
        }



        [HttpGet]
        public async Task<IActionResult> ManageUserClaims(string Id)
        {
            var user = await userManager.FindByIdAsync(Id);

            if (user == null)
            {
                return NotFound($"Unable to load user with ID '{userManager.GetUserId(User)}'.");
            }

            var existingUserClaims = await userManager.GetClaimsAsync(user);
            var model = new UserClaimsViewModel
            {
                Id = Id
            };

            // Loop through each claim we have in our application
            foreach (Claim claim in ClaimsStore.AllClaims)
            {
                UserClaimViewModel userClaim = new UserClaimViewModel
                {
                    ClaimType = claim.Type
                };

                // If the user has the claim, set IsSelected property to true, so the checkbox
                // next to the claim is checked on the UI
                if (existingUserClaims.Any(c => c.Type == claim.Type))
                {
                    userClaim.IsSelected = true;
                }

                model.Claims.Add(userClaim);
            }

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> ManageUserClaims(UserClaimsViewModel model)
        {
            var user = await userManager.FindByIdAsync(model.Id);

            if (user == null)
            {
                ViewBag.ErrorMessage = $"User with Id = {model.Id} cannot be found";
                return View("NotFound");
            }

            // Get all the user existing claims and delete them
            var claims = await userManager.GetClaimsAsync(user);
            var result = await userManager.RemoveClaimsAsync(user, claims);

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot remove user existing claims");
                return View(model);
            }

            // Add all the claims that are selected on the UI
            result = await userManager.AddClaimsAsync(user,
                model.Claims.Where(c => c.IsSelected).Select(c => new Claim(c.ClaimType, c.ClaimType)));

            if (!result.Succeeded)
            {
                ModelState.AddModelError("", "Cannot add selected claims to user");
                return View(model);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> EnableUser(string id)
        {
            var user = await userManager.FindByIdAsync(id); 
            var lockoutEndDate = new DateTime(2999, 01, 01);
            await userManager.SetLockoutEnabledAsync(user, true);
            await userManager.SetLockoutEndDateAsync(user, lockoutEndDate);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> DisableUser(string id)
        {
            var user = await userManager.FindByIdAsync(id);
            await userManager.SetLockoutEnabledAsync(user, false);

            return RedirectToAction("Index");

        }
    }
}
