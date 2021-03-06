﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using eDrivingSchool.WebAPI.Database;

namespace eDrivingSchool.WebAPI.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20210121173123_DateType2")]
    partial class DateType2
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.Certificate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Price");

                    b.Property<string>("Type");

                    b.HasKey("Id");

                    b.ToTable("Certificates");
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.Certificate_Request", b =>
                {
                    b.Property<int>("CertificateRequestId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CertificateId");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Purpose");

                    b.Property<string>("Status");

                    b.Property<int>("UserId");

                    b.HasKey("CertificateRequestId");

                    b.HasIndex("CertificateId");

                    b.HasIndex("UserId");

                    b.ToTable("Certificate_Requests");
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Message");

                    b.Property<int>("TopicId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("TopicId");

                    b.HasIndex("UserId");

                    b.ToTable("Comments");
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.DrivingLesson", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AverageFuelConsumption");

                    b.Property<string>("Damage");

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<int>("InstructorId");

                    b.Property<float>("Mileage");

                    b.Property<int>("UserId");

                    b.Property<int>("VehicleId");

                    b.HasKey("Id");

                    b.HasIndex("InstructorId");

                    b.HasIndex("UserId");

                    b.HasIndex("VehicleId");

                    b.ToTable("DrivingLessons");
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.DrivingSchool", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<byte[]>("Logo");

                    b.Property<string>("Name");

                    b.Property<string>("Phone");

                    b.HasKey("Id");

                    b.ToTable("DrivingSchool");
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.DrivingTestApplications", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<int>("Instructor_Category_CandidateId");

                    b.Property<bool>("Passed");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("Instructor_Category_CandidateId");

                    b.ToTable("DrivingTestApplications");
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.Instructor_Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Instructors_Categories");
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.Instructor_Category_Candidate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("Date")
                        .HasColumnType("date");

                    b.Property<int>("Instructor_CategoryId");

                    b.Property<int>("NumberOfLessons");

                    b.Property<bool>("Paid");

                    b.Property<bool>("PolozenPrakticniTest");

                    b.Property<bool>("PolozenTeorijskiTest");

                    b.Property<bool>("PolozenTestPrvePomoci");

                    b.Property<bool>("Prijavljen");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("Instructor_CategoryId");

                    b.HasIndex("UserId");

                    b.ToTable("Instructors_Categories_Candidates");
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("Amount");

                    b.Property<string>("Category");

                    b.Property<DateTime>("DateOfPayment")
                        .HasColumnType("date");

                    b.Property<string>("Note");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.TechnicalInspection", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("Email");

                    b.Property<string>("Name");

                    b.Property<string>("PhoneNumber");

                    b.HasKey("Id");

                    b.ToTable("TechnicalInspections");
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.TheoryTestApplications", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<bool>("FirstAid");

                    b.Property<int>("Instructor_Category_CandidateId");

                    b.Property<int>("Status");

                    b.Property<bool>("TheoryTest");

                    b.HasKey("Id");

                    b.HasIndex("Instructor_Category_CandidateId");

                    b.ToTable("TheoryTestApplications");
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("date");

                    b.Property<string>("Description");

                    b.Property<string>("Message");

                    b.Property<string>("Subject");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<DateTime>("Birthdate")
                        .HasColumnType("date");

                    b.Property<DateTime>("DateOfHiring")
                        .HasColumnType("date");

                    b.Property<int>("DrivingSchoolId");

                    b.Property<string>("Email")
                        .HasMaxLength(100);

                    b.Property<string>("FirstName")
                        .HasMaxLength(50);

                    b.Property<byte[]>("Image");

                    b.Property<string>("JMBG")
                        .HasMaxLength(13);

                    b.Property<string>("LastName")
                        .HasMaxLength(50);

                    b.Property<string>("LicenseNumber");

                    b.Property<string>("PasswordHash")
                        .HasMaxLength(50);

                    b.Property<string>("PasswordSalt")
                        .HasMaxLength(50);

                    b.Property<string>("Phone")
                        .HasMaxLength(20);

                    b.Property<int>("RoleId");

                    b.Property<string>("Salary");

                    b.Property<string>("Username")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("DrivingSchoolId");

                    b.HasIndex("RoleId");

                    b.HasIndex("Username")
                        .IsUnique()
                        .HasFilter("[Username] IS NOT NULL");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("Image");

                    b.Property<float>("Mileage");

                    b.Property<string>("Model");

                    b.Property<string>("Name");

                    b.Property<int>("Power");

                    b.Property<string>("RegistrationNumber");

                    b.Property<int>("TechnicalInspectionId");

                    b.Property<int>("Year");

                    b.HasKey("Id");

                    b.HasIndex("TechnicalInspectionId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.Certificate_Request", b =>
                {
                    b.HasOne("eDrivingSchool.WebAPI.Database.Certificate", "Certificate")
                        .WithMany()
                        .HasForeignKey("CertificateId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eDrivingSchool.WebAPI.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.Comment", b =>
                {
                    b.HasOne("eDrivingSchool.WebAPI.Database.Topic", "Topic")
                        .WithMany()
                        .HasForeignKey("TopicId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eDrivingSchool.WebAPI.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.DrivingLesson", b =>
                {
                    b.HasOne("eDrivingSchool.WebAPI.Database.User", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eDrivingSchool.WebAPI.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eDrivingSchool.WebAPI.Database.Vehicle", "Vehicle")
                        .WithMany()
                        .HasForeignKey("VehicleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.DrivingTestApplications", b =>
                {
                    b.HasOne("eDrivingSchool.WebAPI.Database.Instructor_Category_Candidate", "Instructor_Category_Candidate")
                        .WithMany()
                        .HasForeignKey("Instructor_Category_CandidateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.Instructor_Category", b =>
                {
                    b.HasOne("eDrivingSchool.WebAPI.Database.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eDrivingSchool.WebAPI.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.Instructor_Category_Candidate", b =>
                {
                    b.HasOne("eDrivingSchool.WebAPI.Database.Instructor_Category", "Instructor_Category")
                        .WithMany()
                        .HasForeignKey("Instructor_CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eDrivingSchool.WebAPI.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.Payment", b =>
                {
                    b.HasOne("eDrivingSchool.WebAPI.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.TheoryTestApplications", b =>
                {
                    b.HasOne("eDrivingSchool.WebAPI.Database.Instructor_Category_Candidate", "Instructor_Category_Candidate")
                        .WithMany()
                        .HasForeignKey("Instructor_Category_CandidateId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.Topic", b =>
                {
                    b.HasOne("eDrivingSchool.WebAPI.Database.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.User", b =>
                {
                    b.HasOne("eDrivingSchool.WebAPI.Database.DrivingSchool", "DrivingSchool")
                        .WithMany()
                        .HasForeignKey("DrivingSchoolId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("eDrivingSchool.WebAPI.Database.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("eDrivingSchool.WebAPI.Database.Vehicle", b =>
                {
                    b.HasOne("eDrivingSchool.WebAPI.Database.TechnicalInspection", "TechnicalInspection")
                        .WithMany()
                        .HasForeignKey("TechnicalInspectionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
