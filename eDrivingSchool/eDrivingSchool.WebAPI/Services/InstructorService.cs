using AutoMapper;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
    public class InstructorService : CRUDService<Model.Instructor, InstructorSearchRequest, Database.User, Model.Requests.InstructorInsertRequest, Model.Requests.InstructorInsertRequest>
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;
        public InstructorService(ApplicationDbContext context, IMapper mapper) : base(context, mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public override Model.Instructor Insert(InstructorInsertRequest model)
        {
            var entity = _mapper.Map<Database.User>(model);
            _context.Add(entity);
            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, model.Password);

            _context.SaveChanges();
            return _mapper.Map<Model.Instructor>(entity);
        }

        public override Model.Instructor Update(int id,InstructorInsertRequest model)
        {
            var entity = _context.Users.Find(id);
            if (!string.IsNullOrEmpty(model.Password))
            {
                entity.PasswordHash = GenerateHash(entity.PasswordSalt, model.Password);
            }
            _mapper.Map(model, entity);
            _context.Attach(entity);
            _context.Update(entity);
            _context.SaveChanges();
            return _mapper.Map<Model.Instructor>(entity);
        }

        public override List<Model.Instructor> GetAll(InstructorSearchRequest request)
        {
            var query = _context.Set<Database.User>().AsQueryable();

            if (!string.IsNullOrEmpty(request.Username))
            {
                query = query.Where(w => w.Username == request.Username);
            }

            if (!string.IsNullOrEmpty(request.FirstName))
            {
                query = query.Where(x => x.FirstName == request.FirstName);
            }
            var list = query.Where(w => w.RoleId == 2).ToList();
            return _mapper.Map<List<Model.Instructor>>(list);
        }

        public static string GenerateSalt()
        {
            var buf = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buf);
            return Convert.ToBase64String(buf);
        }
        public static string GenerateHash(string salt, string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length + bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);
        }
    }
}
