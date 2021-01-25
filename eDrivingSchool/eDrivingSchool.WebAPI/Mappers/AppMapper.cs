using AutoMapper;
using eDrivingSchool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Mappers
{
    public class AppMapper : Profile
    {
        public AppMapper()
        {
            CreateMap<Database.Vehicle, Model.Vehicle>().ReverseMap();
            CreateMap<Model.Vehicle, Model.Requests.VehicleInsertRequest>().ReverseMap();
            CreateMap<Database.Vehicle, Model.Requests.VehicleInsertRequest>().ReverseMap();
            CreateMap<Database.Category, Model.Category>().ReverseMap();
            CreateMap<Model.Category, Model.Requests.CategoryInsertRequest>().ReverseMap();
            CreateMap<Database.TechnicalInspection, Model.TechnicalInspection>().ReverseMap();
            CreateMap<Model.TechnicalInspection, Model.Requests.TechnicalInspectionInsertRequest>().ReverseMap();
            CreateMap<Database.TechnicalInspection, Model.Requests.TechnicalInspectionInsertRequest>().ReverseMap();
            CreateMap<Database.Category, Model.Requests.CategoryInsertRequest>().ReverseMap();
            CreateMap<Database.User, Model.User>().ReverseMap();
            CreateMap<Model.User, Model.Requests.UserInsertRequest>().ReverseMap();
            CreateMap<Database.User, Model.Requests.UserInsertRequest>().ReverseMap();
            CreateMap<Database.User, Model.Instructor>().ReverseMap();
            CreateMap<Database.User, Model.Requests.InstructorInsertRequest>().ReverseMap();
            CreateMap<Database.User, Model.Requests.CandidateInsertRequest>().ReverseMap();
            CreateMap<Database.User, Model.Candidate>().ReverseMap();
            CreateMap<Database.Payment, Model.Requests.PaymentInsertRequest>().ReverseMap();
            CreateMap<Database.Payment, Model.Payment>().ReverseMap();
            CreateMap<Database.Topic, Model.Requests.TopicInsertRequest>().ReverseMap();
            CreateMap<Database.Topic, Model.Topic>().ReverseMap();
            CreateMap<Database.Comment, Model.Comment>().ReverseMap();
            CreateMap<Database.Comment, CommentInsertRequest>().ReverseMap();
            CreateMap<Database.Certificate, Model.Certificate>().ReverseMap();
            CreateMap<Database.Certificate, CertificateInsertRequest>().ReverseMap();
            CreateMap<Database.Certificate_Request, Certificate_RequestInsert>().ReverseMap();
            CreateMap<Database.Certificate_Request, Model.Certificate_Request>().ReverseMap();
            CreateMap<Database.Instructor_Category, Model.Instructor_Category>().ReverseMap();
            CreateMap<Database.Instructor_Category, InstructorCategoryInsertRequest>().ReverseMap();
            CreateMap<Database.Instructor_Category_Candidate, Model.Instructor_Category_Candidate>().ReverseMap();
            CreateMap<Database.Instructor_Category_Candidate, InstructorCategoryCandidateInsertRequest>().ReverseMap();
            CreateMap<Database.TheoryTestApplications, Model.TheoryTestApplications>().ReverseMap();
            CreateMap<Database.TheoryTestApplications, TheoryTestApplicationsInsertRequest>().ReverseMap();
            CreateMap<Database.DrivingLesson, Model.DrivingLesson>().ReverseMap();
            CreateMap<Database.DrivingLesson, DrivingLessonInsertRequest>().ReverseMap();
            CreateMap<Database.DrivingTestApplications, Model.DrivingTestApplications>().ReverseMap();
            CreateMap<Database.DrivingTestApplications, DrivingTestApplicationsInsertRequest>().ReverseMap();
        }
    }
}
