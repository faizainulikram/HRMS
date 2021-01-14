using BIA.Dashboard.Template.Models;
using BIA.Dashboard.Template.Models.Identity;
using Microsoft.AspNetCore.DataProtection.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using System;
using System.Linq;

namespace BIA.Dashboard.Template.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IDataProtectionKeyContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<DataProtectionKey> DataProtectionKeys { get; set; }
        public DbSet<PersonnelInformation> PersonnelInformation { get; set; }
        public DbSet<PersonnelInformationUser> PersonnelInformationUser { get; set; }
        public DbSet<EducationDetail> EducationDetail { get; set; }
        public DbSet<ProfessionalQualification> ProfessionalQualification { get; set; }
        public DbSet<FamilyInformation> FamilyInformation { get; set; }
        public DbSet<EmergencyContact> EmergencyContact { get; set; }
        public DbSet<EducationDetailUser> EducationDetailUser { get; set; }
        public DbSet<ProfessionalQualificationUser> ProfessionalQualificationUser { get; set; }
        public DbSet<FamilyInformationUser> FamilyInformationUser { get; set; }
        public DbSet<EmergencyContactUser> EmergencyContactUser { get; set; }
        public DbSet<HealthDeclaration> HealthDeclaration { get; set; }
        public DbSet<FileOnDatabaseModel> FilesOnDatabase { get; set; }
        public DbSet<FileOnFileSystemModel> FilesOnFileSystem { get; set; }
        public DbSet<PersonnelInformationAuditLog> PersonnelInformationAuditLog { get; set; }
        public DbSet<PayrollAdvice> PayrollAdvice { get; set; }
        public DbSet<PayrollLedger> PayrollLedger { get; set; }
        public DbSet<PayrollBankBranch> PayrollBankBranch { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PersonnelInformation>().ToTable("PersonnelInformation");
            modelBuilder.Entity<EducationDetail>().ToTable("EducationDetail");
            modelBuilder.Entity<ProfessionalQualification>().ToTable("ProfessionalQualification");
            modelBuilder.Entity<FamilyInformation>().ToTable("FamilyInformation");
            modelBuilder.Entity<EmergencyContact>().ToTable("EmergencyContact");
            modelBuilder.Entity<EducationDetailUser>().ToTable("EducationDetailUser");
            modelBuilder.Entity<ProfessionalQualificationUser>().ToTable("ProfessionalQualificationUser");
            modelBuilder.Entity<FamilyInformationUser>().ToTable("FamilyInformationUser");
            modelBuilder.Entity<EmergencyContactUser>().ToTable("EmergencyContactUser");
            modelBuilder.Entity<HealthDeclaration>().ToTable("HealthDeclaration");
            modelBuilder.Entity<FileOnDatabaseModel>().ToTable("FileOnDatabaseModel");
            modelBuilder.Entity<FileOnFileSystemModel>().ToTable("FileOnFileSystemModel");
            modelBuilder.Entity<PersonnelInformationAuditLog>().ToTable("PersonnelInformationAuditLog");
            modelBuilder.Entity<PayrollAdvice>().ToTable("PayrollAdvice");
            modelBuilder.Entity<PayrollLedger>().ToTable("PayrollLedger");
            modelBuilder.Entity<PayrollBankBranch>().ToTable("PayrollBankBranch");

            modelBuilder.Entity<ApplicationUser>()
                .HasOne(e => e.PersonnelInformation)
                .WithOne(e => e.ApplicationUser)
                .HasForeignKey<PersonnelInformation>(e => e.ApplicationUserId);

            modelBuilder.Entity<ApplicationUser>() 
                .HasOne(e => e.PersonnelInformationUser)
                .WithOne(e => e.ApplicationUser)
                .HasForeignKey<PersonnelInformationUser>(e => e.ApplicationUserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PersonnelInformation>()
                .HasOne(e => e.HealthDeclaration)
                .WithOne(e => e.PersonnelInformation)
                .HasForeignKey<HealthDeclaration>(e => e.PersonnelInformationId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<PersonnelInformation>()
                .HasMany(e => e.EducationDetail)
                .WithOne(e => e.PersonnelInformation)
                .HasForeignKey(e => e.PersonnelInformationId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<PersonnelInformation>()
                .HasMany(e => e.ProfessionalQualification)
                .WithOne(e => e.PersonnelInformation)
                .HasForeignKey(e => e.PersonnelInformationId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<PersonnelInformation>()
                .HasMany(e => e.FamilyInformation)
                .WithOne(e => e.PersonnelInformation)
                .HasForeignKey(e => e.PersonnelInformationId)
                .OnDelete(DeleteBehavior.Cascade); 

            modelBuilder.Entity<PersonnelInformation>()
                .HasMany(e => e.EmergencyContact)
                .WithOne(e => e.PersonnelInformation)
                .HasForeignKey(e => e.PersonnelInformationId)
                .OnDelete(DeleteBehavior.Cascade);

            // payroll rules
            //modelBuilder.Entity<PersonnelInformation>()
            //    .HasMany(e => e.EmergencyContact)
            //    .WithOne(e => e.PersonnelInformation)
            //    .HasForeignKey(e => e.PersonnelInformationId);

            modelBuilder.Entity<PersonnelInformationUser>()
                .HasMany(e => e.EducationDetailUser)
                .WithOne(e => e.PersonnelInformationUser)
                .HasForeignKey(e => e.PersonnelInformationUserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PersonnelInformationUser>()
                .HasMany(e => e.ProfessionalQualificationUser)
                .WithOne(e => e.PersonnelInformationUser)
                .HasForeignKey(e => e.PersonnelInformationUserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PersonnelInformationUser>()
                .HasMany(e => e.FamilyInformationUser)
                .WithOne(e => e.PersonnelInformationUser)
                .HasForeignKey(e => e.PersonnelInformationUserId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<PersonnelInformationUser>()
                .HasMany(e => e.EmergencyContactUser)
                .WithOne(e => e.PersonnelInformationUser)
                .HasForeignKey(e => e.PersonnelInformationUserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
