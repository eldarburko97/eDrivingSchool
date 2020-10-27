using AutoMapper;
using eDrivingSchool.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
    public class CRUDService<T, TSearch, TDatabase, TInsert, TUpdate> : ICRUDService<T, TSearch, TInsert, TUpdate> where TDatabase : class
    {
        private readonly ApplicationDbContext _context = null;
        private readonly IMapper _mapper = null;

        public CRUDService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public T Delete(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            _context.Set<TDatabase>().Remove(entity);
            _context.SaveChanges();
            return _mapper.Map<T>(entity);
        }

        public virtual List<T> GetAll(TSearch searchRequest)
        {
            var list = _context.Set<TDatabase>().ToList();
            return _mapper.Map<List<T>>(list);
        }

        public T GetById(int id)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            return _mapper.Map<T>(entity);
        }

        public virtual T Insert(TInsert model)
        {
            var entity = _mapper.Map<TDatabase>(model);
            _context.Set<TDatabase>().Add(entity);
            _context.SaveChanges();
            return _mapper.Map<T>(entity);
        }

        public virtual T Update(int id, TUpdate model)
        {
            var entity = _context.Set<TDatabase>().Find(id);
            _mapper.Map(model, entity);
            _context.Set<TDatabase>().Attach(entity);
            _context.Set<TDatabase>().Update(entity);
          //  _mapper.Map(model, entity);
            _context.SaveChanges();
            return _mapper.Map<T>(entity);
        }
    }
}
