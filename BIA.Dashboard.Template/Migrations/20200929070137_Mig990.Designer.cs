﻿// <auto-generated />
using System;
using BIA.Dashboard.Template.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BIA.Dashboard.Template.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20200929070137_Mig990")]
    partial class Mig990
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BIA.Dashboard.Template.Models.EducationDetail", b =>
                {
                    b.Property<int>("EducationDetailId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Institution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonnelInformationId")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EducationDetailId");

                    b.HasIndex("PersonnelInformationId");

                    b.ToTable("EducationDetail");
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.EducationDetailUser", b =>
                {
                    b.Property<int>("EducationDetailUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Institution")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonnelInformationUserId")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EducationDetailUserId");

                    b.HasIndex("PersonnelInformationUserId");

                    b.ToTable("EducationDetailUser");
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.EmergencyContact", b =>
                {
                    b.Property<int>("EmergencyContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonnelInformationId")
                        .HasColumnType("int");

                    b.Property<string>("Relationship")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmergencyContactId");

                    b.HasIndex("PersonnelInformationId");

                    b.ToTable("EmergencyContact");
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.EmergencyContactUser", b =>
                {
                    b.Property<int>("EmergencyContactUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ContactNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonnelInformationUserId")
                        .HasColumnType("int");

                    b.Property<string>("Relationship")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("EmergencyContactUserId");

                    b.HasIndex("PersonnelInformationUserId");

                    b.ToTable("EmergencyContactUser");
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.FamilyInformation", b =>
                {
                    b.Property<int>("FamilyInformationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Employer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonnelInformationId")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Relationship")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FamilyInformationId");

                    b.HasIndex("PersonnelInformationId");

                    b.ToTable("FamilyInformation");
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.FamilyInformationUser", b =>
                {
                    b.Property<int>("FamilyInformationUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Employer")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonnelInformationUserId")
                        .HasColumnType("int");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Relationship")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FamilyInformationUserId");

                    b.HasIndex("PersonnelInformationUserId");

                    b.ToTable("FamilyInformationUser");
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.FileOnDatabaseModel", b =>
                {
                    b.Property<int>("FileAttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Data")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Extension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonnelInformationId")
                        .HasColumnType("int");

                    b.Property<int>("PersonnelInformationUserId")
                        .HasColumnType("int");

                    b.HasKey("FileAttachmentId");

                    b.ToTable("FileOnDatabaseModel");
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.FileOnFileSystemModel", b =>
                {
                    b.Property<int>("FileAttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Extension")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FileType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonnelInformationId")
                        .HasColumnType("int");

                    b.Property<int>("PersonnelInformationUserId")
                        .HasColumnType("int");

                    b.HasKey("FileAttachmentId");

                    b.ToTable("FileOnFileSystemModel");
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.HealthDeclaration", b =>
                {
                    b.Property<int>("HealthDeclarationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ComplexHealthProblem")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ComplexHealthProblemDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Declaration")
                        .HasColumnType("bit");

                    b.Property<bool>("Disease")
                        .HasColumnType("bit");

                    b.Property<string>("DiseaseDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MedicalConditionDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Medication")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OtherMedicalCondition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PersonnelInformationId")
                        .HasColumnType("int");

                    b.HasKey("HealthDeclarationId");

                    b.HasIndex("PersonnelInformationId")
                        .IsUnique();

                    b.ToTable("HealthDeclaration");
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.Identity.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.PayrollAdvice", b =>
                {
                    b.Property<int>("PayrollAdviceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccountName")
                        .HasColumnType("char(50)");

                    b.Property<string>("AccountNumber")
                        .HasColumnType("char(17)");

                    b.Property<string>("AdviceNumber")
                        .HasColumnType("char(6)");

                    b.Property<string>("BankAccountType")
                        .HasColumnType("char(1)");

                    b.Property<string>("BankCode")
                        .HasColumnType("char(3)");

                    b.Property<string>("BranchCode")
                        .HasColumnType("char(3)");

                    b.Property<int>("DDEA")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("DeductionAmount")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal>("Earning")
                        .HasColumnType("decimal(10,2)");

                    b.Property<string>("ICNumber")
                        .HasColumnType("char(10)");

                    b.Property<string>("Ledger")
                        .HasColumnType("char(10)");

                    b.Property<decimal>("LoanBalance")
                        .HasColumnType("decimal(12,2)");

                    b.Property<decimal>("LoanEntitlement")
                        .HasColumnType("decimal(12,2)");

                    b.Property<string>("Remarks")
                        .HasColumnType("char(30)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("char(1)");

                    b.Property<DateTime>("StatusDate")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("TransactionEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("TransactionStartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("PayrollAdviceId");

                    b.ToTable("PayrollAdvice");
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.PersonnelInformation", b =>
                {
                    b.Property<int>("PersonnelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ConfirmedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CurrentPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DepartmentReportingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Division")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmploymentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtensionNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlobalGrade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Group")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HomeNumber")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("IdentityCardColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("MandatoryRetirementDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonnelNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PositionReportingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Prefix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Race")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReportingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ServiceDuration")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonnelId");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique()
                        .HasFilter("[ApplicationUserId] IS NOT NULL");

                    b.ToTable("PersonnelInformation");
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.PersonnelInformationUser", b =>
                {
                    b.Property<int>("PersonnelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ApplicationUserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("ConfirmedDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CurrentPosition")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DepartmentReportingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Division")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmploymentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExtensionNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GlobalGrade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Group")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HealthDeclarationId")
                        .HasColumnType("int");

                    b.Property<string>("HomeNumber")
                        .HasColumnType("nvarchar(15)")
                        .HasMaxLength(15);

                    b.Property<string>("IdentityCardColor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdentityCardNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("MandatoryRetirementDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("MaritalStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PersonnelNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("PositionReportingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Prefix")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProfileImageName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Race")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Religion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ReportingDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ServiceDuration")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PersonnelId");

                    b.HasIndex("ApplicationUserId")
                        .IsUnique()
                        .HasFilter("[ApplicationUserId] IS NOT NULL");

                    b.HasIndex("HealthDeclarationId");

                    b.ToTable("PersonnelInformationUser");
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.ProfessionalQualification", b =>
                {
                    b.Property<int>("ProfessionalQualificationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonnelInformationId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfessionalQualificationId");

                    b.HasIndex("PersonnelInformationId");

                    b.ToTable("ProfessionalQualification");
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.ProfessionalQualificationUser", b =>
                {
                    b.Property<int>("ProfessionalQualificationUserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonnelInformationUserId")
                        .HasColumnType("int");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ProfessionalQualificationUserId");

                    b.HasIndex("PersonnelInformationUserId");

                    b.ToTable("ProfessionalQualificationUser");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.DataProtection.EntityFrameworkCore.DataProtectionKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("FriendlyName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Xml")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("DataProtectionKeys");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasColumnType("nvarchar(256)")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.EducationDetail", b =>
                {
                    b.HasOne("BIA.Dashboard.Template.Models.PersonnelInformation", "PersonnelInformation")
                        .WithMany("EducationDetail")
                        .HasForeignKey("PersonnelInformationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.EducationDetailUser", b =>
                {
                    b.HasOne("BIA.Dashboard.Template.Models.PersonnelInformationUser", "PersonnelInformationUser")
                        .WithMany("EducationDetailUser")
                        .HasForeignKey("PersonnelInformationUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.EmergencyContact", b =>
                {
                    b.HasOne("BIA.Dashboard.Template.Models.PersonnelInformation", "PersonnelInformation")
                        .WithMany("EmergencyContact")
                        .HasForeignKey("PersonnelInformationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.EmergencyContactUser", b =>
                {
                    b.HasOne("BIA.Dashboard.Template.Models.PersonnelInformationUser", "PersonnelInformationUser")
                        .WithMany("EmergencyContactUser")
                        .HasForeignKey("PersonnelInformationUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.FamilyInformation", b =>
                {
                    b.HasOne("BIA.Dashboard.Template.Models.PersonnelInformation", "PersonnelInformation")
                        .WithMany("FamilyInformation")
                        .HasForeignKey("PersonnelInformationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.FamilyInformationUser", b =>
                {
                    b.HasOne("BIA.Dashboard.Template.Models.PersonnelInformationUser", "PersonnelInformationUser")
                        .WithMany("FamilyInformationUser")
                        .HasForeignKey("PersonnelInformationUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.HealthDeclaration", b =>
                {
                    b.HasOne("BIA.Dashboard.Template.Models.PersonnelInformation", "PersonnelInformation")
                        .WithOne("HealthDeclaration")
                        .HasForeignKey("BIA.Dashboard.Template.Models.HealthDeclaration", "PersonnelInformationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.PersonnelInformation", b =>
                {
                    b.HasOne("BIA.Dashboard.Template.Models.Identity.ApplicationUser", "ApplicationUser")
                        .WithOne("PersonnelInformation")
                        .HasForeignKey("BIA.Dashboard.Template.Models.PersonnelInformation", "ApplicationUserId");
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.PersonnelInformationUser", b =>
                {
                    b.HasOne("BIA.Dashboard.Template.Models.Identity.ApplicationUser", "ApplicationUser")
                        .WithOne("PersonnelInformationUser")
                        .HasForeignKey("BIA.Dashboard.Template.Models.PersonnelInformationUser", "ApplicationUserId");

                    b.HasOne("BIA.Dashboard.Template.Models.HealthDeclaration", "HealthDeclaration")
                        .WithMany()
                        .HasForeignKey("HealthDeclarationId");
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.ProfessionalQualification", b =>
                {
                    b.HasOne("BIA.Dashboard.Template.Models.PersonnelInformation", "PersonnelInformation")
                        .WithMany("ProfessionalQualification")
                        .HasForeignKey("PersonnelInformationId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("BIA.Dashboard.Template.Models.ProfessionalQualificationUser", b =>
                {
                    b.HasOne("BIA.Dashboard.Template.Models.PersonnelInformationUser", "PersonnelInformationUser")
                        .WithMany("ProfessionalQualificationUser")
                        .HasForeignKey("PersonnelInformationUserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("BIA.Dashboard.Template.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("BIA.Dashboard.Template.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BIA.Dashboard.Template.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("BIA.Dashboard.Template.Models.Identity.ApplicationUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
