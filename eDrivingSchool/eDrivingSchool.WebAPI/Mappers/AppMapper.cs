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
            CreateMap<Database.DrivingSchool, Model.DrivingSchool>().ReverseMap();
            CreateMap<Model.DrivingSchool, Model.Requests.DrivingSchoolInsertRequest>().ReverseMap();
            CreateMap<Database.DrivingSchool, Model.Requests.DrivingSchoolInsertRequest>().ReverseMap();
            CreateMap<Database.Vehicle, Model.Vehicle>().ReverseMap();
            CreateMap<Model.Vehicle, Model.Requests.VehicleInsertRequest>().ReverseMap();
            CreateMap<Database.Vehicle, Model.Requests.VehicleInsertRequest>().ReverseMap();
            CreateMap<Database.Category, Model.Category>().ReverseMap();
            CreateMap<Model.Category, Model.Requests.CategoryInsertRequest>().ReverseMap();
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
            CreateMap<Database.Comment,CommentInsertRequest>().ReverseMap();
        }
    }
}
