using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BIA.Dashboard.Template.Data;
using BIA.Dashboard.Template.Models;
using BIA.Dashboard.Template.Models.Identity;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using FileUpload.MVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using BIA.Dashboard.Template.Services;
using BIA.Dashboard.Template.DTOS;

namespace BIA.Dashboard.Template.Controllers
{
    [Authorize]
    public class PersonnelInformationsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IAuthorizationService authorizationService;
        private readonly IWebHostEnvironment hostingEnvironment;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly IEmailSender _emailSender;


        public PersonnelInformationsController(ApplicationDbContext context, IAuthorizationService AuthorizationService, IWebHostEnvironment environment, UserManager<ApplicationUser> userManager, IEmailSender emailSender)
        {
            _context = context;
            authorizationService = AuthorizationService;
            hostingEnvironment = environment;
            this.userManager = userManager;
            _emailSender = emailSender;
        }

        // GET: PersonnelInformations
        public IActionResult Index()
        {
           
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> GetDirectoryData()
        {

            var draw = int.Parse(HttpContext.Request.Query["draw"]);
            var start = int.Parse(HttpContext.Request.Query["start"]);
            var length = int.Parse(Request.Query["length"].ToString());
            string sortColumnDirection = Request.Query["order[0][dir]"].ToString();
            var searchValue = Request.Query["search[value]"].ToString();
            searchValue = string.IsNullOrEmpty(searchValue) ? null : searchValue;
            string columnNum = Request.Query["order[0][column]"].ToString();
            string sortColumn = Request.Query["columns[" + columnNum + "][name]"].ToString();

            var query = _context.PersonnelInformation.Where(s => searchValue == null || s.Name.Contains(searchValue)
            || s.IdentityCardNumber.Contains(searchValue)
            || s.CurrentPosition.Contains(searchValue)
            || s.Division.Contains(searchValue)
            );
            
            var dataQuery = query.Select(x => new DirectoryDataDto
            {
                 Division=x.Division,
                  ExtensionNumber=x.ExtensionNumber,
                   Position=x.CurrentPosition,
                    Name=x.Name,
                     PersonnelId=x.PersonnelId
            });
            if (sortColumnDirection == "desc")
            {
                switch (sortColumn)
                {
                    case "division":
                        dataQuery = dataQuery.OrderByDescending(x => x.Division);
                        break;
                    case "extensionNumber":
                        dataQuery = dataQuery.OrderByDescending(x => x.ExtensionNumber);
                        break;
                    case "position":
                        dataQuery = dataQuery.OrderByDescending(x => x.Position);
                        break;
                    case "name":
                        dataQuery = dataQuery.OrderByDescending(x => x.Name);
                        break;
                    default:
                        dataQuery = dataQuery.OrderByDescending(x => x.PersonnelId);
                        break;
                }
            }
            else
            {
                switch (sortColumn)
                {
                    case "division":
                        dataQuery = dataQuery.OrderBy(x => x.Division);
                        break;
                    case "extensionNumber":
                        dataQuery = dataQuery.OrderBy(x => x.ExtensionNumber);
                        break;
                    case "position":
                        dataQuery = dataQuery.OrderBy(x => x.Position);
                        break;
                    case "name":
                        dataQuery = dataQuery.OrderBy(x => x.Name);
                        break;
                    default:
                        dataQuery = dataQuery.OrderBy(x => x.PersonnelId);
                        break;
                }
            }

            var totalRecords = dataQuery.Count();
            var data = await dataQuery.Skip(start).Take(length).ToListAsync();
            foreach (var item in data)
            {

                if ((await authorizationService.AuthorizeAsync(User, "PersonnelInformationHR")).Succeeded || (await authorizationService.AuthorizeAsync(User, "PersonnelInformationHOD")).Succeeded)
                {
                    item.Action += @"<a class='btn btn-sm btn-secondary' href='/PersonnelInformations/Details/"+ item.PersonnelId + "'>Details</a>";
                }
                if ((await authorizationService.AuthorizeAsync(User, "PersonnelInformationHR")).Succeeded)
                {
                    item.Action += @"<a href='#' onclick='ConfirmDelete("+ item.PersonnelId + ")' class='btn btn-sm btn-warning'>Delete</a>";
                }

            }
            return Json(new { draw = draw, recordsFiltered = data.Count, recordsTotal = totalRecords, data = data });
        }


        private void PopulateUserDropDownList(object selectedUser = null)
        {
            if (selectedUser == null)
            {
                var applicationUserQuery = from u in userManager.Users
                                           where u.PersonnelInformation == null
                                           orderby u.Email
                                           select u;
                ViewBag.ApplicationUserId = new SelectList(applicationUserQuery.AsNoTracking(), "Id", "Email", selectedUser);
            }

            if (selectedUser != null)
            {
                var applicationUserQuery = from u in userManager.Users
                                           where u.PersonnelInformation == null || u.Id == selectedUser.ToString()
                                           orderby u.Email
                                           select u;
                ViewBag.ApplicationUserId = new SelectList(applicationUserQuery.AsNoTracking(), "Id", "Email", selectedUser);
            }

        }

        private void PopulateAssignedData(PersonnelInformation personnelInformation)
        {
            var allEducationDetail = _context.EducationDetail;
            var allProfessionalQualification = _context.ProfessionalQualification;
            var allFamilyInformation = _context.FamilyInformation;
            var allEmergencyContact = _context.EmergencyContact;

            var educationDetailViewModel = new List<EducationDetailViewModel>();
            var professionalQualificationViewModel = new List<ProfessionalQualificationViewModel>();
            var familyInformationViewModel = new List<FamilyInformationViewModel>();
            var emergencyContactViewModel = new List<EmergencyContactViewModel>();

            foreach (var educationDetail in allEducationDetail)
            {
                if (educationDetail.PersonnelInformation != null)
                {
                    if (educationDetail.PersonnelInformation.PersonnelId == personnelInformation.PersonnelId)
                    {
                        educationDetailViewModel.Add(new EducationDetailViewModel
                        {
                            EducationDetailId = educationDetail.EducationDetailId,
                            Education = educationDetail.Education,
                            Institution = educationDetail.Institution,
                            Year = educationDetail.Year,
                        });
                    }
                }
            }

            foreach (var professionalQualification in allProfessionalQualification)
            {
                if (professionalQualification.PersonnelInformation != null)
                {
                    if (professionalQualification.PersonnelInformation.PersonnelId == personnelInformation.PersonnelId)
                    {
                        professionalQualificationViewModel.Add(new ProfessionalQualificationViewModel
                        {
                            ProfessionalQualificationId = professionalQualification.ProfessionalQualificationId,
                            Name = professionalQualification.Name,
                            Status = professionalQualification.Status,
                        });
                    }
                }
            }

            foreach (var familyInformation in allFamilyInformation)
            {
                if (familyInformation.PersonnelInformation != null)
                {
                    if (familyInformation.PersonnelInformation.PersonnelId == personnelInformation.PersonnelId)
                    {
                        familyInformationViewModel.Add(new FamilyInformationViewModel
                        {
                            FamilyInformationId = familyInformation.FamilyInformationId,
                            Name = familyInformation.Name,
                            IdentityCardNumber = familyInformation.IdentityCardNumber,
                            BirthDate = familyInformation.BirthDate,
                            Position = familyInformation.Position,
                            Employer = familyInformation.Employer,
                            Relationship = familyInformation.Relationship,
                        });
                    }
                }
            }

            foreach (var emergencyContact in allEmergencyContact)
            {
                if (emergencyContact.PersonnelInformation != null)
                {
                    if (emergencyContact.PersonnelInformation.PersonnelId == personnelInformation.PersonnelId)
                    {
                        emergencyContactViewModel.Add(new EmergencyContactViewModel
                        {
                            EmergencyContactId = emergencyContact.EmergencyContactId,
                            Name = emergencyContact.Name,
                            Relationship = emergencyContact.Relationship,
                            ContactNumber = emergencyContact.ContactNumber,
                        });
                    }
                }
            }

            ViewData["EducationDetails"] = educationDetailViewModel;
            ViewData["ProfessionalQualifications"] = professionalQualificationViewModel;
            ViewData["FamilyInformations"] = familyInformationViewModel;
            ViewData["EmergencyContacts"] = emergencyContactViewModel;
        }

        private void PopulateAssignedDataUser(PersonnelInformationUser personnelInformationUser)
        {
            var allEducationDetail = _context.EducationDetailUser;
            var allProfessionalQualification = _context.ProfessionalQualificationUser;
            var allFamilyInformation = _context.FamilyInformationUser;
            var allEmergencyContact = _context.EmergencyContactUser;

            var educationDetailViewModel = new List<EducationDetailViewModel>();
            var professionalQualificationViewModel = new List<ProfessionalQualificationViewModel>();
            var familyInformationViewModel = new List<FamilyInformationViewModel>();
            var emergencyContactViewModel = new List<EmergencyContactViewModel>();

            foreach (var educationDetail in allEducationDetail)
            {
                if (educationDetail.PersonnelInformationUser != null)
                {
                    if (educationDetail.PersonnelInformationUser.PersonnelId == personnelInformationUser.PersonnelId)
                    {
                        educationDetailViewModel.Add(new EducationDetailViewModel
                        {
                            EducationDetailId = educationDetail.EducationDetailUserId,
                            Education = educationDetail.Education,
                            Institution = educationDetail.Institution,
                            Year = educationDetail.Year,
                        });
                    }
                }
            }

            foreach (var professionalQualification in allProfessionalQualification)
            {
                if (professionalQualification.PersonnelInformationUser != null)
                {
                    if (professionalQualification.PersonnelInformationUser.PersonnelId == personnelInformationUser.PersonnelId)
                    {
                        professionalQualificationViewModel.Add(new ProfessionalQualificationViewModel
                        {
                            ProfessionalQualificationId = professionalQualification.ProfessionalQualificationUserId,
                            Name = professionalQualification.Name,
                            Status = professionalQualification.Status,
                        });
                    }
                }
            }

            foreach (var familyInformation in allFamilyInformation)
            {
                if (familyInformation.PersonnelInformationUser != null)
                {
                    if (familyInformation.PersonnelInformationUser.PersonnelId == personnelInformationUser.PersonnelId)
                    {
                        familyInformationViewModel.Add(new FamilyInformationViewModel
                        {
                            FamilyInformationId = familyInformation.FamilyInformationUserId,
                            Name = familyInformation.Name,
                            IdentityCardNumber = familyInformation.IdentityCardNumber,
                            BirthDate = familyInformation.BirthDate,
                            Position = familyInformation.Position,
                            Employer = familyInformation.Employer,
                            Relationship = familyInformation.Relationship,
                        });
                    }
                }
            }

            foreach (var emergencyContact in allEmergencyContact)
            {
                if (emergencyContact.PersonnelInformationUser != null)
                {
                    if (emergencyContact.PersonnelInformationUser.PersonnelId == personnelInformationUser.PersonnelId)
                    {
                        emergencyContactViewModel.Add(new EmergencyContactViewModel
                        {
                            EmergencyContactId = emergencyContact.EmergencyContactUserId,
                            Name = emergencyContact.Name,
                            Relationship = emergencyContact.Relationship,
                            ContactNumber = emergencyContact.ContactNumber,
                        });
                    }
                }
            }

            ViewData["EducationDetails"] = educationDetailViewModel;
            ViewData["ProfessionalQualifications"] = professionalQualificationViewModel;
            ViewData["FamilyInformations"] = familyInformationViewModel;
            ViewData["EmergencyContacts"] = emergencyContactViewModel;
        }

        private string GetUniqueFileName(string fileName)
        {
            fileName = Path.GetFileName(fileName);
            return Path.GetFileNameWithoutExtension(fileName)
                      + "_" + Guid.NewGuid().ToString().Substring(0, 4)
                      + Path.GetExtension(fileName);
        }

        private async Task<FileUploadViewModel> LoadAllFiles(int personnelId)
        {
            var viewModel = new FileUploadViewModel();
            viewModel.FilesOnDatabase = await _context.FilesOnDatabase.
                Where(i => i.PersonnelInformationId == personnelId).ToListAsync();
            viewModel.FilesOnFileSystem = await _context.FilesOnFileSystem.
                Where(i => i.PersonnelInformationId == personnelId).ToListAsync();
            return viewModel;
        }

        private async Task<FileUploadViewModel> LoadUserFiles(int personnelId)
        {
            var viewModel = new FileUploadViewModel();
            viewModel.FilesOnDatabase = await _context.FilesOnDatabase.
                Where(i => i.PersonnelInformationUserId == personnelId).ToListAsync();
            viewModel.FilesOnFileSystem = await _context.FilesOnFileSystem.
                Where(i => i.PersonnelInformationUserId == personnelId).ToListAsync();
            return viewModel;
        }

        [HttpPost]
        public async Task<IActionResult> UploadToDatabase(List<IFormFile> files, int personnelId)
        {
            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var extension = Path.GetExtension(file.FileName);
                var fileModel = new FileOnDatabaseModel
                {
                    CreatedOn = DateTime.Now,
                    FileType = file.ContentType,
                    Extension = extension,
                    Name = fileName,
                    PersonnelInformationId = personnelId,
                };
                using (var dataStream = new MemoryStream())
                {
                    await file.CopyToAsync(dataStream);
                    fileModel.Data = dataStream.ToArray();
                }
                _context.FilesOnDatabase.Add(fileModel);
                _context.SaveChanges();
            }
            TempData["Message"] = "File successfully uploaded to Database";
            return RedirectToAction(nameof(Details), new { id = personnelId.ToString() });
        }

        public async Task<IActionResult> DownloadFileFromDatabase(int id)
        {
            var file = await _context.FilesOnDatabase.Where(x => x.FileAttachmentId == id).FirstOrDefaultAsync();
            if (file == null) return null;
            return File(file.Data, file.FileType, file.Name + file.Extension);
        }

        public async Task<IActionResult> DeleteFileFromDatabase(int id)
        {
            var file = await _context.FilesOnDatabase.Where(x => x.FileAttachmentId == id).FirstOrDefaultAsync();
            _context.FilesOnDatabase.Remove(file);
            _context.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully from Database.";
            return RedirectToAction(nameof(Details), new { id = file.PersonnelInformationId.ToString() });
        }

        [HttpPost]
        public async Task<IActionResult> UploadUserFileToDatabase(List<IFormFile> files, int personnelId)
        {
            foreach (var file in files)
            {
                var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                var extension = Path.GetExtension(file.FileName);
                var fileModel = new FileOnDatabaseModel
                {
                    CreatedOn = DateTime.Now,
                    FileType = file.ContentType,
                    Extension = extension,
                    Name = fileName,
                    PersonnelInformationUserId = personnelId,
                };
                using (var dataStream = new MemoryStream())
                {
                    await file.CopyToAsync(dataStream);
                    fileModel.Data = dataStream.ToArray();
                }
                _context.FilesOnDatabase.Add(fileModel);
                _context.SaveChanges();
            }
            TempData["Message"] = "File successfully uploaded to Database";
            return RedirectToAction(nameof(Profile), new { id = userManager.GetUserId(User) });
        }

        public async Task<IActionResult> DeleteUserFileFromDatabase(int id)
        {
            var file = await _context.FilesOnDatabase.Where(x => x.FileAttachmentId == id).FirstOrDefaultAsync();
            _context.FilesOnDatabase.Remove(file);
            _context.SaveChanges();
            TempData["Message"] = $"Removed {file.Name + file.Extension} successfully from Database.";
            return RedirectToAction(nameof(Profile), new { id = userManager.GetUserId(User) });
        }

        // GET: PersonnelInformations/Details/5
        [Authorize(Policy = "PersonnelInformationDetails")]
        public async Task<IActionResult> Details(int id)
        {
            var personnelInformation = await _context.PersonnelInformation
                .FirstOrDefaultAsync(m => m.PersonnelId == id);

            if (personnelInformation == null)
            {
                return NotFound();
            }

            var fileUploadViewModel = await LoadAllFiles(id);
            ViewBag.Message = TempData["Message"];
            ViewData["FileUploadViewModel"] = fileUploadViewModel.FilesOnDatabase;

            PopulateAssignedData(personnelInformation);
            return View(personnelInformation);
        }

        // GET: PersonnelInformations/Profile
        public async Task<IActionResult> Profile(string id)
        {
            var personnelInformationUser = await _context.PersonnelInformationUser
                .FirstOrDefaultAsync(m => m.ApplicationUserId == id);
            if (personnelInformationUser == null)
            {
                return NotFound();
            }
            var fileUploadViewModel = await LoadUserFiles(personnelInformationUser.PersonnelId);
            ViewBag.Message = TempData["Message"];
            ViewData["FileUploadViewModel"] = fileUploadViewModel.FilesOnDatabase;

            PopulateAssignedDataUser(personnelInformationUser);
            return View(personnelInformationUser);
        }

        // GET: PersonnelInformations/EditProfile
        public async Task<IActionResult> EditProfile(string id)
        {
            var personnelInformationUser = await _context.PersonnelInformationUser
                .FirstOrDefaultAsync(m => m.ApplicationUserId == id);
            if (personnelInformationUser == null)
            {
                return NotFound();
            }
            var fileUploadViewModel = await LoadUserFiles(personnelInformationUser.PersonnelId);
            ViewBag.Message = TempData["Message"];
            ViewData["FileUploadViewModel"] = fileUploadViewModel.FilesOnDatabase;

            PopulateAssignedDataUser(personnelInformationUser);
            return View(personnelInformationUser);
        }

        // POST: PersonnelInformations/EditProfile
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProfile([FromForm] PersonnelInformationUser personnelInformationUser)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var educationDetails = _context.EducationDetailUser.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId);
                    foreach (var item in educationDetails)
                    {
                        if (!personnelInformationUser.EducationDetailUser.Contains(item))
                        {
                            _context.EducationDetailUser.Remove(item);
                        }
                    }

                    var professionalQualifications = _context.ProfessionalQualificationUser.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId);
                    foreach (var item in professionalQualifications)
                    {
                        if (!personnelInformationUser.ProfessionalQualificationUser.Contains(item))
                        {
                            _context.ProfessionalQualificationUser.Remove(item);
                        }
                    }

                    var familyInformations = _context.FamilyInformationUser.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId);
                    foreach (var item in familyInformations)
                    {
                        if (!personnelInformationUser.FamilyInformationUser.Contains(item))
                        {
                            _context.FamilyInformationUser.Remove(item);
                        }
                    }

                    var emergencyContacts = _context.EmergencyContactUser.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId);
                    foreach (var item in emergencyContacts)
                    {
                        if (!personnelInformationUser.EmergencyContactUser.Contains(item))
                        {
                            _context.EmergencyContactUser.Remove(item);
                        }
                    }

                    if (personnelInformationUser.ProfileImage != null)
                    {
                        var images = Path.Combine(hostingEnvironment.WebRootPath, "images");
                        var uniqueFileName = GetUniqueFileName(personnelInformationUser.ProfileImage.FileName);
                        var imagesFilePath = Path.Combine(images, uniqueFileName);
                        using (var fileStream = new FileStream(imagesFilePath, FileMode.Create))
                        {
                            await personnelInformationUser.ProfileImage.CopyToAsync(fileStream);
                        }
                        personnelInformationUser.ProfileImageName = uniqueFileName;
                    }

                    _context.Update(personnelInformationUser);

                    if (personnelInformationUser.ProfileImage == null)
                    {
                        _context.Entry(personnelInformationUser).Property(x => x.ProfileImageName).IsModified = false;
                    }
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonnelInformationExists(personnelInformationUser.PersonnelId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return RedirectToAction(nameof(Profile), new { id = personnelInformationUser.ApplicationUserId.ToString() });
        }

        // GET: PersonnelInformations/Create
        [Authorize(Policy = "PersonnelInformationHR")]
        public IActionResult Create()
        {
            PopulateUserDropDownList();
            return View();
        }

        // POST: PersonnelInformations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Policy = "PersonnelInformationHR")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([FromForm] PersonnelInformation personnelInformation)
        //, [FromForm] EducationDetail[] listOfEducationDetail, [FromForm] ProfessionalQualification[] listOfProfessionalQualification, [FromForm] EmergencyContact[] listOfEmergencyContact, [FromForm] FamilyInformation[] listOfFamilyInformation)
        {

            if (ModelState.IsValid)
            {
                if (personnelInformation.ProfileImage != null)
                {
                    var images = Path.Combine(hostingEnvironment.WebRootPath, "images");
                    var uniqueImageName = GetUniqueFileName(personnelInformation.ProfileImage.FileName);
                    var imagesFilePath = Path.Combine(images, uniqueImageName);
                    using (var fileStream = new FileStream(imagesFilePath, FileMode.Create))
                    {
                        await personnelInformation.ProfileImage.CopyToAsync(fileStream);
                    }
                    personnelInformation.ProfileImageName = uniqueImageName;
                }

                _context.PersonnelInformation.Add(personnelInformation);
                await _context.SaveChangesAsync();

                if (personnelInformation.FileAttachments != null)
                {
                    foreach (var file in personnelInformation.FileAttachments)
                    {
                        var fileName = Path.GetFileNameWithoutExtension(file.FileName);
                        var extension = Path.GetExtension(file.FileName);
                        var fileModel = new FileOnDatabaseModel
                        {
                            CreatedOn = DateTime.Now,
                            FileType = file.ContentType,
                            Extension = extension,
                            Name = fileName,
                            PersonnelInformationId = personnelInformation.PersonnelId,
                        };
                        using (var dataStream = new MemoryStream())
                        {
                            await file.CopyToAsync(dataStream);
                            fileModel.Data = dataStream.ToArray();
                        }
                        _context.FilesOnDatabase.Add(fileModel);
                        _context.SaveChanges();
                    }
                }

                //return RedirectToAction(nameof(Index));
                //return RedirectToAction(nameof(Details), new { id = personnelInformation.PersonnelId.ToString() });
                return Json(new { redirectToUrl = Url.Action(nameof(Details), new { id = personnelInformation.PersonnelId.ToString() }) });
            }

            PopulateUserDropDownList(personnelInformation.ApplicationUserId);
            //return View(personnelInformation);
            //return RedirectToAction(nameof(Details), new { id = personnelInformation.PersonnelId.ToString() });
            return Json
                (new { redirectToUrl = Url.Action(nameof(Details), new { id = personnelInformation.PersonnelId.ToString() }) });
        }

        [Authorize(Policy = "PersonnelInformationHr")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UpdateUser(int? id)
        {
            var personnelInformation = _context.PersonnelInformation.FirstOrDefault(c => c.PersonnelId == id);
            var personnelInformationUser = _context.PersonnelInformationUser.FirstOrDefault(c => c.ApplicationUserId == personnelInformation.ApplicationUserId);

            var filesOnDirectoryDatabase = _context.FilesOnDatabase.Where(c => c.PersonnelInformationId == personnelInformation.PersonnelId).ToArray();
            var filesOnUserDatabase = _context.FilesOnDatabase.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId).ToArray();

            if (personnelInformationUser != null)
            {
                personnelInformationUser.ApplicationUserId = personnelInformation.ApplicationUserId;
                personnelInformationUser.ProfileImageName = personnelInformation.ProfileImageName;
                personnelInformationUser.PersonnelNumber = personnelInformation.PersonnelNumber;
                personnelInformationUser.Prefix = personnelInformation.Prefix;
                personnelInformationUser.Name = personnelInformation.Name;
                personnelInformationUser.IdentityCardNumber = personnelInformation.IdentityCardNumber;
                personnelInformationUser.IdentityCardColor = personnelInformation.IdentityCardColor;
                personnelInformationUser.Race = personnelInformation.Race;
                personnelInformationUser.Religion = personnelInformation.Religion;
                personnelInformationUser.MaritalStatus = personnelInformation.MaritalStatus;
                personnelInformationUser.BirthDate = personnelInformation.BirthDate;
                personnelInformationUser.Address = personnelInformation.Address;
                personnelInformationUser.HomeNumber = personnelInformation.HomeNumber;
                personnelInformationUser.MobileNumber = personnelInformation.MobileNumber;
                personnelInformationUser.EmploymentStatus = personnelInformation.EmploymentStatus;
                personnelInformationUser.ReportingDate = personnelInformation.ReportingDate;
                personnelInformationUser.ConfirmedDate = personnelInformation.ConfirmedDate;
                personnelInformationUser.ServiceDuration = personnelInformation.ServiceDuration;
                personnelInformationUser.PositionReportingDate = personnelInformation.PositionReportingDate;
                personnelInformationUser.DepartmentReportingDate = personnelInformation.DepartmentReportingDate;
                personnelInformationUser.MandatoryRetirementDate = personnelInformation.MandatoryRetirementDate;
                personnelInformationUser.CurrentPosition = personnelInformation.CurrentPosition;
                personnelInformationUser.GlobalGrade = personnelInformation.GlobalGrade;
                personnelInformationUser.Group = personnelInformation.Group;
                personnelInformationUser.Division = personnelInformation.Division;
                personnelInformationUser.ExtensionNumber = personnelInformation.ExtensionNumber;
                personnelInformationUser.Email = personnelInformation.Email;

                var educationDetailUser = _context.EducationDetailUser.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId);
                if (educationDetailUser != null)
                {
                    foreach (var child in educationDetailUser)
                    {
                        _context.Remove(child);
                    }
                }

                var professionalQualificationUser = _context.ProfessionalQualificationUser.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId);
                if (professionalQualificationUser != null)
                {
                    foreach (var child in professionalQualificationUser)
                    {
                        _context.Remove(child);
                    }
                }

                var familyInformationUser = _context.FamilyInformationUser.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId);
                if (familyInformationUser != null)
                {
                    foreach (var child in familyInformationUser)
                    {
                        _context.Remove(child);
                    }
                }

                var emergencyContactUser = _context.EmergencyContactUser.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId);
                if (emergencyContactUser != null)
                {
                    foreach (var child in emergencyContactUser)
                    {
                        _context.Remove(child);
                    }
                }

                var educationDetails = _context.EducationDetail.Where(c => c.PersonnelInformationId == personnelInformation.PersonnelId);
                if (educationDetails != null)
                {
                    foreach (var item in educationDetails)
                    {
                        var addEducationDetail = new EducationDetailUser
                        {
                            Education = item.Education,
                            Institution = item.Institution,
                            Year = item.Year,
                            PersonnelInformationUserId = personnelInformationUser.PersonnelId,
                        };
                        personnelInformationUser.EducationDetailUser.Add(addEducationDetail);
                    }
                }

                var professionalQualifications = _context.ProfessionalQualification.Where(c => c.PersonnelInformationId == personnelInformation.PersonnelId);
                if (professionalQualifications != null)
                {
                    foreach (var item in professionalQualifications)
                    {
                        var addProfessionalQualification = new ProfessionalQualificationUser
                        {
                            Name = item.Name,
                            Status = item.Status,
                            PersonnelInformationUserId = personnelInformationUser.PersonnelId,
                        };
                        personnelInformationUser.ProfessionalQualificationUser.Add(addProfessionalQualification);
                    }
                }

                var familyInformations = _context.FamilyInformation.Where(c => c.PersonnelInformationId == personnelInformation.PersonnelId);
                if (familyInformations != null)
                {
                    foreach (var item in familyInformations)
                    {
                        var addFamilyInformation = new FamilyInformationUser
                        {
                            Name = item.Name,
                            IdentityCardNumber = item.IdentityCardNumber,
                            BirthDate = item.BirthDate,
                            Position = item.Position,
                            Employer = item.Employer,
                            Relationship = item.Relationship,
                            PersonnelInformationUserId = personnelInformationUser.PersonnelId,
                        };
                        personnelInformationUser.FamilyInformationUser.Add(addFamilyInformation);
                    }
                }

                var emergencyContacts = _context.EmergencyContact.Where(c => c.PersonnelInformationId == personnelInformation.PersonnelId);
                if (emergencyContacts != null)
                {
                    foreach (var item in emergencyContacts)
                    {
                        var addEmergencyContact = new EmergencyContactUser
                        {
                            Name = item.Name,
                            Relationship = item.Relationship,
                            ContactNumber = item.ContactNumber,
                            PersonnelInformationUserId = personnelInformationUser.PersonnelId,
                        };
                        personnelInformationUser.EmergencyContactUser.Add(addEmergencyContact);
                    }
                }

                if (filesOnUserDatabase != null)
                {
                    foreach (var file in filesOnUserDatabase)
                    {
                        _context.FilesOnDatabase.Remove(file);
                    }

                }

                if (filesOnDirectoryDatabase != null)
                {
                    foreach (var file in filesOnDirectoryDatabase)
                    {
                        var fileModel = new FileOnDatabaseModel
                        {
                            CreatedOn = DateTime.Now,
                            Name = file.Name,
                            FileType = file.FileType,
                            Extension = file.Extension,
                            PersonnelInformationUserId = personnelInformationUser.PersonnelId,
                            Data = file.Data,
                        };
                        _context.FilesOnDatabase.Add(fileModel);
                        _context.SaveChanges();
                    }
                }

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return NotFound();
            }
        }

        // GET: PersonnelInformations/Edit/5
        [Authorize(Policy = "PersonnelInformationHR")]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personnelInformation = await _context.PersonnelInformation.FindAsync(id);
            if (personnelInformation == null)
            {
                return NotFound();
            }
            PopulateAssignedData(personnelInformation);
            PopulateUserDropDownList(personnelInformation.ApplicationUserId);
            return View(personnelInformation);
        }

        // POST: PersonnelInformations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [Authorize(Policy = "PersonnelInformationHR")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit([FromForm] PersonnelInformation personnelInformation)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    var educationDetails = _context.EducationDetail.Where(c => c.PersonnelInformationId == personnelInformation.PersonnelId);
                    foreach (var item in educationDetails)
                    {
                        if (!personnelInformation.EducationDetail.Contains(item))
                        {
                            _context.EducationDetail.Remove(item);
                        }
                    }

                    var professionalQualifications = _context.ProfessionalQualification.Where(c => c.PersonnelInformationId == personnelInformation.PersonnelId);
                    foreach (var item in professionalQualifications)
                    {
                        if (!personnelInformation.ProfessionalQualification.Contains(item))
                        {
                            _context.ProfessionalQualification.Remove(item);
                        }
                    }

                    var familyInformations = _context.FamilyInformation.Where(c => c.PersonnelInformationId == personnelInformation.PersonnelId);
                    foreach (var item in familyInformations)
                    {
                        if (!personnelInformation.FamilyInformation.Contains(item))
                        {
                            _context.FamilyInformation.Remove(item);
                        }
                    }

                    var emergencyContacts = _context.EmergencyContact.Where(c => c.PersonnelInformationId == personnelInformation.PersonnelId);
                    foreach (var item in emergencyContacts)
                    {
                        if (!personnelInformation.EmergencyContact.Contains(item))
                        {
                            _context.EmergencyContact.Remove(item);
                        }
                    }

                    if (personnelInformation.ProfileImage != null)
                    {
                        var images = Path.Combine(hostingEnvironment.WebRootPath, "images");
                        var uniqueFileName = GetUniqueFileName(personnelInformation.ProfileImage.FileName);
                        var imagesFilePath = Path.Combine(images, uniqueFileName);
                        using (var fileStream = new FileStream(imagesFilePath, FileMode.Create))
                        {
                            await personnelInformation.ProfileImage.CopyToAsync(fileStream);
                        }
                        personnelInformation.ProfileImageName = uniqueFileName;
                    }

                    _context.Update(personnelInformation);

                    if (personnelInformation.ProfileImage == null)
                    {
                        _context.Entry(personnelInformation).Property(x => x.ProfileImageName).IsModified = false;
                    }
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PersonnelInformationExists(personnelInformation.PersonnelId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            PopulateUserDropDownList(personnelInformation.ApplicationUserId);
            return RedirectToAction(nameof(Details), new { id = personnelInformation.PersonnelId.ToString() });
        }

        // GET: PersonnelInformations/Delete/5
        [Authorize(Policy = "PersonnelInformationHR")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var personnelInformation = await _context.PersonnelInformation
                .FirstOrDefaultAsync(m => m.PersonnelId == id);
            if (personnelInformation == null)
            {
                return NotFound();
            }

            return View(personnelInformation);
        }

        // POST: PersonnelInformations/Delete/5
        [Authorize(Policy = "PersonnelInformationHR")]
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var personnelInformation = await _context.PersonnelInformation.FindAsync(id);
            _context.PersonnelInformation.Remove(personnelInformation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PersonnelInformationExists(int id)
        {
            return _context.PersonnelInformation.Any(e => e.PersonnelId == id);
        }

        // GET: PersonnelInformations/Verify
        [Authorize(Policy = "PersonnelInformationHR")]
        public async Task<IActionResult> Verify(string searchString, string currentFilter, int? pageNumber)
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

            var personnels = from s in _context.PersonnelInformationUser
                             where s.Status == "Awaiting Verification"
                             select s;

            if (!String.IsNullOrEmpty(searchString))
            {
                personnels = personnels.Where(s => (s.Name.Contains(searchString)
                ));
            }

            int pageSize = 10;
            return View(await PaginatedList<PersonnelInformationUser>.CreateAsync(personnels.AsNoTracking(), pageNumber ?? 1, pageSize));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SubmitVerification(int id)
        {
            var personnelInformationUser = await _context.PersonnelInformationUser
                .FirstOrDefaultAsync(m => m.PersonnelId == id);

            var personnelInformation = await _context.PersonnelInformation
                .FirstOrDefaultAsync(m => m.ApplicationUserId == personnelInformationUser.ApplicationUserId);

            if (personnelInformationUser == null)
            {
                return NotFound();
            }

            personnelInformationUser.Status = "Awaiting Verification";

            var currentUser = await userManager.GetUserAsync(User);
            var auditLog = new PersonnelInformationAuditLog
            {
                Status = "Submitted For Verification",
                StatusDate = DateTime.Now,
                PersonnelInformation = personnelInformation,
                ApplicationUser = currentUser,
            };

            _context.PersonnelInformationAuditLog.Add(auditLog);
            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Profile), new { id = personnelInformationUser.ApplicationUserId });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Reject(int id, string remarks)
        {
            var personnelInformationUser = await _context.PersonnelInformationUser
                .FirstOrDefaultAsync(m => m.PersonnelId == id);

            var personnelInformation = await _context.PersonnelInformation
                .FirstOrDefaultAsync(m => m.ApplicationUserId == personnelInformationUser.ApplicationUserId);

            if (personnelInformationUser == null)
            {
                return NotFound();
            }

            personnelInformationUser.Status = "Rejected";
            personnelInformationUser.Remarks = remarks;

            var currentUser = await userManager.GetUserAsync(User);

            var auditLog = new PersonnelInformationAuditLog
            {
                Status = "Rejected",
                StatusDate = DateTime.Now,
                PersonnelInformation = personnelInformation,
                ApplicationUser = currentUser,
            };

            _context.PersonnelInformationAuditLog.Add(auditLog);
            await _context.SaveChangesAsync();

            var applicationUser = await userManager.FindByIdAsync(personnelInformationUser.ApplicationUserId);
            var userEmail = applicationUser.Email;

            if (userEmail != null)
            {
                await _emailSender.SendEmailAsync(
                    userEmail,
                    "Update To Personnel Information Has Been Rejected",
                    $"Update to personnel information has been rejected. <br><br> Reason: { remarks }");

                return RedirectToAction(nameof(Verify));
            }

            return RedirectToAction(nameof(Verify));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Approve(int id)
        {
            var personnelInformationUser = await _context.PersonnelInformationUser
                .FirstOrDefaultAsync(m => m.PersonnelId == id);

            var filesOnUserDatabase = _context.FilesOnDatabase.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId).ToArray();

            var personnelInformation = await _context.PersonnelInformation
                .FirstOrDefaultAsync(m => m.ApplicationUserId == personnelInformationUser.ApplicationUserId);

            if (personnelInformation == null)
            {
                personnelInformation = new PersonnelInformation
                {
                    ApplicationUserId = personnelInformationUser.ApplicationUserId,
                    ProfileImageName = personnelInformationUser.ProfileImageName,
                    PersonnelNumber = personnelInformationUser.PersonnelNumber,
                    Prefix = personnelInformationUser.Prefix,
                    Name = personnelInformationUser.Name,
                    IdentityCardNumber = personnelInformationUser.IdentityCardNumber,
                    IdentityCardColor = personnelInformationUser.IdentityCardColor,
                    Race = personnelInformationUser.Race,
                    Religion = personnelInformationUser.Religion,
                    MaritalStatus = personnelInformationUser.MaritalStatus,
                    BirthDate = personnelInformationUser.BirthDate,
                    Address = personnelInformationUser.Address,
                    HomeNumber = personnelInformationUser.HomeNumber,
                    MobileNumber = personnelInformationUser.MobileNumber,
                    EmploymentStatus = personnelInformationUser.EmploymentStatus,
                    ReportingDate = personnelInformationUser.ReportingDate,
                    ConfirmedDate = personnelInformationUser.ConfirmedDate,
                    ServiceDuration = personnelInformationUser.ServiceDuration,
                    PositionReportingDate = personnelInformationUser.PositionReportingDate,
                    DepartmentReportingDate = personnelInformationUser.DepartmentReportingDate,
                    MandatoryRetirementDate = personnelInformationUser.MandatoryRetirementDate,
                    CurrentPosition = personnelInformationUser.CurrentPosition,
                    GlobalGrade = personnelInformationUser.GlobalGrade,
                    Group = personnelInformationUser.Group,
                    Division = personnelInformationUser.Division,
                    ExtensionNumber = personnelInformationUser.ExtensionNumber,
                    Email = personnelInformationUser.Email,
                };

                _context.PersonnelInformation.Add(personnelInformation);
                _context.SaveChanges();

                var educationDetailsUser = _context.EducationDetailUser.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId);
                foreach (var item in educationDetailsUser)
                {
                    var addEducationDetail = new EducationDetail
                    {
                        Education = item.Education,
                        Institution = item.Institution,
                        Year = item.Year,
                        PersonnelInformationId = personnelInformation.PersonnelId,
                    };
                    personnelInformation.EducationDetail.Add(addEducationDetail);
                }

                var professionalQualificationsUser = _context.ProfessionalQualificationUser.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId);
                foreach (var item in professionalQualificationsUser)
                {
                    var addProfessionalQualification = new ProfessionalQualification
                    {
                        Name = item.Name,
                        Status = item.Status,
                        PersonnelInformationId = personnelInformation.PersonnelId,
                    };
                    personnelInformation.ProfessionalQualification.Add(addProfessionalQualification);
                }

                var familyInformationsUser = _context.FamilyInformationUser.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId);
                foreach (var item in familyInformationsUser)
                {
                    var addFamilyInformation = new FamilyInformation
                    {
                        Name = item.Name,
                        IdentityCardNumber = item.IdentityCardNumber,
                        BirthDate = item.BirthDate,
                        Position = item.Position,
                        Employer = item.Employer,
                        Relationship = item.Relationship,
                        PersonnelInformationId = personnelInformation.PersonnelId,
                    };
                    personnelInformation.FamilyInformation.Add(addFamilyInformation);
                }

                var emergencyContactsUser = _context.EmergencyContactUser.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId);
                foreach (var item in emergencyContactsUser)
                {
                    var addEmergencyContact = new EmergencyContact
                    {
                        Name = item.Name,
                        Relationship = item.Relationship,
                        ContactNumber = item.ContactNumber,
                        PersonnelInformationId = personnelInformation.PersonnelId,
                    };
                    personnelInformation.EmergencyContact.Add(addEmergencyContact);
                }

                foreach (var file in filesOnUserDatabase)
                {
                    var fileModel = new FileOnDatabaseModel
                    {
                        CreatedOn = DateTime.Now,
                        Name = file.Name,
                        FileType = file.FileType,
                        Extension = file.Extension,
                        PersonnelInformationId = personnelInformation.PersonnelId,
                        Data = file.Data,
                    };
                    _context.FilesOnDatabase.Add(fileModel);
                    _context.SaveChanges();
                }

                _context.SaveChanges();
            };

            if (personnelInformation != null)
            {

                var filesOnDirectoryDatabase = _context.FilesOnDatabase.Where(c => c.PersonnelInformationId == personnelInformation.PersonnelId).ToArray();

                personnelInformation.ApplicationUserId = personnelInformationUser.ApplicationUserId;
                personnelInformation.ProfileImageName = personnelInformationUser.ProfileImageName;
                personnelInformation.PersonnelNumber = personnelInformationUser.PersonnelNumber;
                personnelInformation.Prefix = personnelInformationUser.Prefix;
                personnelInformation.Name = personnelInformationUser.Name;
                personnelInformation.IdentityCardNumber = personnelInformationUser.IdentityCardNumber;
                personnelInformation.IdentityCardColor = personnelInformationUser.IdentityCardColor;
                personnelInformation.Race = personnelInformationUser.Race;
                personnelInformation.Religion = personnelInformationUser.Religion;
                personnelInformation.MaritalStatus = personnelInformationUser.MaritalStatus;
                personnelInformation.BirthDate = personnelInformationUser.BirthDate;
                personnelInformation.Address = personnelInformationUser.Address;
                personnelInformation.HomeNumber = personnelInformationUser.HomeNumber;
                personnelInformation.MobileNumber = personnelInformationUser.MobileNumber;
                personnelInformation.EmploymentStatus = personnelInformationUser.EmploymentStatus;
                personnelInformation.ReportingDate = personnelInformationUser.ReportingDate;
                personnelInformation.ConfirmedDate = personnelInformationUser.ConfirmedDate;
                personnelInformation.ServiceDuration = personnelInformationUser.ServiceDuration;
                personnelInformation.PositionReportingDate = personnelInformationUser.PositionReportingDate;
                personnelInformation.DepartmentReportingDate = personnelInformationUser.DepartmentReportingDate;
                personnelInformation.MandatoryRetirementDate = personnelInformationUser.MandatoryRetirementDate;
                personnelInformation.CurrentPosition = personnelInformationUser.CurrentPosition;
                personnelInformation.GlobalGrade = personnelInformationUser.GlobalGrade;
                personnelInformation.Group = personnelInformationUser.Group;
                personnelInformation.Division = personnelInformationUser.Division;
                personnelInformation.ExtensionNumber = personnelInformationUser.ExtensionNumber;
                personnelInformation.Email = personnelInformationUser.Email;

                var educationDetail = _context.EducationDetail.Where(c => c.PersonnelInformationId == personnelInformation.PersonnelId);
                foreach (var child in educationDetail)
                {
                    _context.Remove(child);
                }

                var professionalQualification = _context.ProfessionalQualification.Where(c => c.PersonnelInformationId == personnelInformation.PersonnelId);
                foreach (var child in professionalQualification)
                {
                    _context.Remove(child);
                }

                var familyInformation = _context.FamilyInformation.Where(c => c.PersonnelInformationId == personnelInformation.PersonnelId);
                foreach (var child in familyInformation)
                {
                    _context.Remove(child);
                }

                var emergencyContact = _context.EmergencyContact.Where(c => c.PersonnelInformationId == personnelInformation.PersonnelId);
                foreach (var child in emergencyContact)
                {
                    _context.Remove(child);
                }

                var educationDetailsUser = _context.EducationDetailUser.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId);
                foreach (var item in educationDetailsUser)
                {
                    var addEducationDetail = new EducationDetail
                    {
                        Education = item.Education,
                        Institution = item.Institution,
                        Year = item.Year,
                        PersonnelInformationId = personnelInformation.PersonnelId,
                    };
                    personnelInformation.EducationDetail.Add(addEducationDetail);
                }

                var professionalQualificationsUser = _context.ProfessionalQualificationUser.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId);
                foreach (var item in professionalQualificationsUser)
                {
                    var addProfessionalQualification = new ProfessionalQualification
                    {
                        Name = item.Name,
                        Status = item.Status,
                        PersonnelInformationId = personnelInformation.PersonnelId,
                    };
                    personnelInformation.ProfessionalQualification.Add(addProfessionalQualification);
                }

                var familyInformationsUser = _context.FamilyInformationUser.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId);
                foreach (var item in familyInformationsUser)
                {
                    var addFamilyInformation = new FamilyInformation
                    {
                        Name = item.Name,
                        IdentityCardNumber = item.IdentityCardNumber,
                        BirthDate = item.BirthDate,
                        Position = item.Position,
                        Employer = item.Employer,
                        Relationship = item.Relationship,
                        PersonnelInformationId = personnelInformation.PersonnelId,
                    };
                    personnelInformation.FamilyInformation.Add(addFamilyInformation);
                }

                var emergencyContactsUser = _context.EmergencyContactUser.Where(c => c.PersonnelInformationUserId == personnelInformationUser.PersonnelId);
                foreach (var item in emergencyContactsUser)
                {
                    var addEmergencyContact = new EmergencyContact
                    {
                        Name = item.Name,
                        Relationship = item.Relationship,
                        ContactNumber = item.ContactNumber,
                        PersonnelInformationId = personnelInformation.PersonnelId,
                    };
                    personnelInformation.EmergencyContact.Add(addEmergencyContact);
                }

                foreach (var file in filesOnDirectoryDatabase)
                {
                    _context.FilesOnDatabase.Remove(file);
                }

                foreach (var file in filesOnUserDatabase)
                {
                    var fileModel = new FileOnDatabaseModel
                    {
                        CreatedOn = DateTime.Now,
                        Name = file.Name,
                        FileType = file.FileType,
                        Extension = file.Extension,
                        PersonnelInformationId = personnelInformation.PersonnelId,
                        Data = file.Data,
                    };
                    _context.FilesOnDatabase.Add(fileModel);
                    _context.SaveChanges();
                }
            }

            personnelInformationUser.Status = "Approved";
            personnelInformationUser.Remarks = "";
            personnelInformationUser.Locked = true;

            var currentUser = await userManager.GetUserAsync(User);

            var auditLog = new PersonnelInformationAuditLog
            {
                Status = "Approved",
                StatusDate = DateTime.Now,
                PersonnelInformation = personnelInformation,
                ApplicationUser = currentUser,
            };

            _context.PersonnelInformationAuditLog.Add(auditLog);
            await _context.SaveChangesAsync();

            var applicationUser = await userManager.FindByIdAsync(personnelInformationUser.ApplicationUserId);
            var userEmail = applicationUser.Email;
            if (userEmail != null)
            {
                await _emailSender.SendEmailAsync(
                    userEmail,
                    "Update To Personnel Information Has Been Approved",
                    "Update to personnel information has been approved.");
            }

            return RedirectToAction(nameof(Verify));
        }

        // GET: PersonnelInformationsAuditLog
        public IActionResult AuditLog()
        {
            
            return View();
        }



        [HttpGet]
        public async Task<IActionResult> GetAuditLogData()
        {

            var draw = int.Parse(HttpContext.Request.Query["draw"]);
            var start = int.Parse(HttpContext.Request.Query["start"]);
            var length = int.Parse(Request.Query["length"].ToString());
            string sortColumnDirection = Request.Query["order[0][dir]"].ToString();
            var searchValue = Request.Query["search[value]"].ToString();
            searchValue = string.IsNullOrEmpty(searchValue) ? null : searchValue;
            string columnNum = Request.Query["order[0][column]"].ToString();
            string sortColumn = Request.Query["columns[" + columnNum + "][name]"].ToString();

            var query = _context.PersonnelInformationAuditLog.Include(b => b.PersonnelInformation).Include(c => c.ApplicationUser)
                .Where(s => searchValue == null|| s.Status.Contains(searchValue)
                    || s.PersonnelInformation.Name.Contains(searchValue)
                    || s.ApplicationUser.Email.Contains(searchValue)
                    || s.FormattedStatusDate.Contains(searchValue)
                );
            var dataQuery = query.Select(x => new
            {
                Status = x.Status,
                Personnel = x.PersonnelInformation.Name,
                UpdatedBy = x.ApplicationUser.Email,
                FormattedStatusDate = x.FormattedStatusDate
            });
            if (sortColumnDirection=="desc")
            {
                switch (sortColumn)
                {
                    case "status":
                        dataQuery=dataQuery.OrderByDescending(x => x.Status);
                        break;
                    case "personnel":
                        dataQuery = dataQuery.OrderByDescending(x => x.Personnel);
                        break;
                    case "updatedBy":
                        dataQuery = dataQuery.OrderByDescending(x => x.UpdatedBy);
                        break;
                    case "formattedStatusDate":
                        dataQuery = dataQuery.OrderByDescending(x => x.FormattedStatusDate);
                        break;
                    default:
                        dataQuery = dataQuery.OrderByDescending(x => x.Status);
                        break;
                }
            }
            else
            {
                switch (sortColumn)
                {
                    case "status":
                        dataQuery = dataQuery.OrderBy(x => x.Status);
                        break;
                    case "personnel":
                        dataQuery = dataQuery.OrderBy(x => x.Personnel);
                        break;
                    case "updatedBy":
                        dataQuery = dataQuery.OrderBy(x => x.UpdatedBy);
                        break;
                    case "formattedStatusDate":
                        dataQuery = dataQuery.OrderBy(x => x.FormattedStatusDate);
                        break;
                    default:
                        dataQuery = dataQuery.OrderBy(x => x.Status);
                        break;
                }
            }

            var totalRecords = dataQuery.Count();
            var data = await dataQuery.Skip(start).Take(length).ToListAsync();
          
            return Json(new { draw = draw, recordsFiltered = data.Count, recordsTotal = totalRecords, data = data });
        }
    }
}
