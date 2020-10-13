using AutoMapper;
using eDrivingSchool.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
    public class DrivingSchoolService : CRUDService<Model.DrivingSchool, object, Database.DrivingSchool, Model.Requests.DrivingSchoolInsertRequest, Model.Requests.DrivingSchoolInsertRequest>
    {
        public DrivingSchoolService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
