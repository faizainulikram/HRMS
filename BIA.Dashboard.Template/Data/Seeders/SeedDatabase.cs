using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
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
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace BIA.Dashboard.Template.Data.Seeders
{
    public class ApplicationDbContextSeedData
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment hostingEnvironment;
        private readonly UserManager<ApplicationUser> userManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public ApplicationDbContextSeedData(ApplicationDbContext context, IWebHostEnvironment environment, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _context = context;
            hostingEnvironment = environment;
            this.userManager = userManager;
            this.roleManager = roleManager;
        }

        public async void SeedAdminUser()
        {
            if (!_context.Roles.Any(r => r.Name == "Administrator"))
            {
                var role = new IdentityRole
                {
                    Name = "Administrator"
                };
                await roleManager.CreateAsync(role);
            }

            //create user UserName:Owner Role:Admin
            if (!_context.Users.Any(u => u.Email == "admin@bia.com.bn"))
            {
                var user = new ApplicationUser
                {
                    UserName = "admin@bia.com.bn",
                    NormalizedUserName = "admin@bia.com.bn",
                    Email = "admin@bia.com.bn",
                    NormalizedEmail = "admin@bia.com.bn",
                    EmailConfirmed = true,
                    LockoutEnabled = false,
                    SecurityStamp = Guid.NewGuid().ToString()
                };
                await userManager.CreateAsync(user, "Abcde12345..");
                await userManager.AddToRoleAsync(user, "Administrator");
            }

            await _context.SaveChangesAsync();
        }
    }
}
