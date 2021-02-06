using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Database
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<TechnicalInspection> TechnicalInspections { get; set; }
        public DbSet<Certificate> Certificates { get; set; }
        public DbSet<Certificate_Request> Certificate_Requests { get; set; }
        public DbSet<Instructor_Category> Instructors_Categories { get; set; }
        public DbSet<Instructor_Category_Candidate> Instructors_Categories_Candidates { get; set; }
        public DbSet<TheoryTestApplications> TheoryTestApplications { get; set; }
        public DbSet<DrivingLesson> DrivingLessons { get; set; }
        public DbSet<DrivingTestApplications> DrivingTestApplications { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<User>().HasIndex(u => u.Username).IsUnique();

            modelBuilder.Entity<Instructor_Category>()
       .HasKey(bc => new { bc.InstructorId, bc.CategoryId });
            modelBuilder.Entity<Instructor_Category>()
                .HasOne(bc => bc.Instructor)
                .WithMany(b => b.Instructor_Categories)
                .HasForeignKey(bc => bc.InstructorId);
            modelBuilder.Entity<Instructor_Category>()
                .HasOne(bc => bc.Category)
                .WithMany(c => c.Instructor_Categories)
                .HasForeignKey(bc => bc.CategoryId);


            modelBuilder.Entity<Instructor_Category_Candidate>().HasKey(p => new { p.InstructorId, p.CategoryId, p.CandidateId });
            modelBuilder.Entity<Instructor_Category>()
    .HasMany(p => p.Instructor_Category_Candidates).WithOne(c => c.Instructor_Category).HasForeignKey(c => new { c.InstructorId, c.CategoryId });
            modelBuilder.Entity<User>().HasMany(m => m.Instructor_Category_Candidates).WithOne(w => w.Candidate).HasForeignKey(f => new { f.CandidateId });

            modelBuilder.Entity<DrivingTestApplications>().HasKey(p => new { p.Id });
            modelBuilder.Entity<Instructor_Category_Candidate>()
    .HasMany(p => p.DrivingTestApplications).WithOne(c => c.Instructor_Category_Candidate).HasForeignKey(c => new { c.InstructorId, c.CategoryId, c.CandidateId });

            modelBuilder.Entity<TheoryTestApplications>().HasKey(p => new { p.Id });
            modelBuilder.Entity<Instructor_Category_Candidate>()
    .HasMany(p => p.TheoryTestApplications).WithOne(c => c.Instructor_Category_Candidate).HasForeignKey(c => new { c.InstructorId, c.CategoryId, c.CandidateId });

            modelBuilder.Entity<Payment>().HasKey(p => new { p.Id });

            modelBuilder.Entity<Instructor_Category_Candidate>()
            .HasMany(s => s.Payments)
            .WithOne(g => g.Instructor_Category_Candidate)
            .HasForeignKey(g => new { g.InstructorId, g.CategoryId, g.CandidateId });

            modelBuilder.Entity<DrivingLesson>()
           .HasOne<Vehicle>(s => s.Vehicle)
           .WithMany(g => g.DrivingLessons)
           .HasForeignKey(s => s.VehicleId);

            modelBuilder.Entity<Instructor_Category_Candidate>()
           .HasMany(s => s.DrivingLessons)
           .WithOne(g => g.Instructor_Category_Candidate)
           .HasForeignKey(g => new { g.InstructorId, g.CategoryId, g.CandidateId });

        }
    }
}
