using AutoMapper;
using eDrivingSchool.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
    public class CategoryService : CRUDService<Model.Category, Model.Requests.CategorySearchRequest, Database.Category, Model.Requests.CategoryInsertRequest, Model.Requests.CategoryInsertRequest>
    {
        public CategoryService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
