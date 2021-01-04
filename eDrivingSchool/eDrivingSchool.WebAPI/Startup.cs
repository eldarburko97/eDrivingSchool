using AutoMapper;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Database;
using eDrivingSchool.WebAPI.Security;
using eDrivingSchool.WebAPI.Services;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace eDrivingSchool.WebAPI
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddAutoMapper(typeof(Startup));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "My API", Version = "v1" });
            });
            services.AddAuthentication("BasicAuthentication")
               .AddScheme<AuthenticationSchemeOptions, BasicAuthenticationHandler>("BasicAuthentication", null);

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<ICRUDService<Model.DrivingSchool, object, Model.Requests.DrivingSchoolInsertRequest, Model.Requests.DrivingSchoolInsertRequest>, DrivingSchoolService>();
            services.AddScoped<ICRUDService<Model.Vehicle, Model.Requests.VehicleSearchRequest, Model.Requests.VehicleInsertRequest, Model.Requests.VehicleInsertRequest>, VehicleService>();
            services.AddScoped<ICRUDService<Model.Category, object, Model.Requests.CategoryInsertRequest, Model.Requests.CategoryInsertRequest>, CRUDService<Model.Category, object, Database.Category, Model.Requests.CategoryInsertRequest, Model.Requests.CategoryInsertRequest>>();
            services.AddScoped<ICRUDService<Model.TechnicalInspection, Model.Requests.TechnicalInspectionSearchRequest, Model.Requests.TechnicalInspectionInsertRequest, Model.Requests.TechnicalInspectionInsertRequest>, TechnicalInspectionService>();



            services.AddScoped<ICRUDService<Model.Instructor, InstructorSearchRequest, Model.Requests.InstructorInsertRequest, Model.Requests.InstructorInsertRequest>, InstructorService>();
            services.AddScoped<ICRUDService<Model.Candidate, CandidateSearchRequest, CandidateInsertRequest, CandidateInsertRequest>, CandidateService>();
            services.AddScoped<ICRUDService<Model.Payment, PaymentSearchRequest, PaymentInsertRequest, PaymentInsertRequest>, PaymentService>();
            services.AddScoped<ICRUDService<Model.Topic, object, TopicInsertRequest, TopicInsertRequest>, TopicService>();
            services.AddScoped<ICRUDService<Model.Comment, CommentSearchRequest, CommentInsertRequest, CommentInsertRequest>, CommentService>();
            services.AddScoped<ICRUDService<Model.Certificate, CertificateSearchRequest, CertificateInsertRequest, CertificateInsertRequest>, CertificateService>();
            services.AddScoped<ICRUDService<Model.Certificate_Request, Certificate_RequestSearch, Certificate_RequestInsert, Certificate_RequestInsert>, Certificate_RequestService>();
            services.AddScoped<ICRUDService<Model.Instructor_Category, InstructorCategorySearchRequest, InstructorCategoryInsertRequest, InstructorCategoryInsertRequest>, Instructor_CategoryService>();
            services.AddScoped<ICRUDService<Model.Instructor_Category_Candidate, InstructorCategoryCandidateSearchRequest, InstructorCategoryCandidateInsertRequest, InstructorCategoryCandidateInsertRequest>, Instructor_Category_CandidateService>();
            services.AddScoped<ICRUDService<Model.TheoryTestApplications, TheoryTestApplicationsSearchRequest, TheoryTestApplicationsInsertRequest, TheoryTestApplicationsInsertRequest>, TheoryTestApplicationsService>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseAuthentication();
            //  app.UseHttpsRedirection();
            app.UseMvc();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "My API V1");
            });
        }
    }
}
