using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
    public interface ICRUDService<T, TSearch, TInsert, TUpdate>
    {
        List<T> GetAll(TSearch searchRequest);
        T GetById(int id);
        T Insert(TInsert model);
        T Update(int id, TUpdate model);
        T Delete(int id);
    }
}
