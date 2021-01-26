using AutoMapper;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
    public class VehicleService : CRUDService<Model.Vehicle, Model.Requests.VehicleSearchRequest, Database.Vehicle, Model.Requests.VehicleInsertRequest, Model.Requests.VehicleInsertRequest>
    {
        private readonly ApplicationDbContext _context = null;
        private readonly IMapper _mapper = null;

        public VehicleService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public override List<Model.Vehicle> GetAll(VehicleSearchRequest request)
        {
            var query = _context.Set<Database.Vehicle>().AsQueryable();

          /*  if (!string.IsNullOrEmpty(request.Name))
            {
                query = query.Where(x => x.Name.Contains(request.Name));
            }*/
            var list = query.ToList();
            var vehicles = _mapper.Map<List<Model.Vehicle>>(list);
         /*   foreach (var vehicle in vehicles)
            {
                vehicle.vehicle = vehicle.Name + " " + vehicle.RegistrationNumber;
            }*/
            return vehicles;
        }
    }
}
