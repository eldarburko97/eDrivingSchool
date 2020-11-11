using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using eDrivingSchool.Model;
using eDrivingSchool.Model.Requests;
using eDrivingSchool.WebAPI.Database;
using eDrivingSchool.WebAPI.Filters;
using Microsoft.EntityFrameworkCore;

namespace eDrivingSchool.WebAPI.Services
{
    public class UserService : IUserService
    {
        private ApplicationDbContext _context;
        private IMapper _mapper;

        public UserService(ApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public Model.User Authenticate(string username, string password)
        {
            var user = _context.Users.FirstOrDefault(x => x.Username == username);
            if (user != null)
            {
                var newHash = GenerateHash(user.PasswordSalt, password);
                if (newHash == user.PasswordHash)
                {
                    return _mapper.Map<Model.User>(user);
                }
            }
            return null;
        }

        public List<Model.User> GetAll(UserSearchRequest search)
        {
            var query = _context.Users.AsQueryable();

            if (!string.IsNullOrWhiteSpace(search?.Username))
            {
                query = query.Where(x => x.Username == search.Username);
            }

            if (!string.IsNullOrWhiteSpace(search?.FirstName))
            {
                query = query.Where(x => x.FirstName == search.FirstName);
            }

            if (!string.IsNullOrWhiteSpace(search?.LastName))
            {
                query = query.Where(x => x.LastName == search.LastName);
            }

            // var entities = query.Where(x => x.RoleId == 1).ToList();
            var entities = query.Where(x => x.RoleId == 2).ToList();
            var result = _mapper.Map<List<Model.User>>(entities);
            return result;
        }

        public Model.User GetById(int id)
        {
            var entity = _context.Users.Find(id);
            return _mapper.Map<Model.User>(entity);
        }

        public Model.User Insert(UserInsertRequest request)
        {
            var entity = _mapper.Map<Database.User>(request);
            _context.Add(entity);

            if (request.Password != request.PasswordConfirm)
            {
                throw new Exception("Password i potvrda se ne slažu");
            }

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            _context.SaveChanges();
            return _mapper.Map<Model.User>(entity);
        }

        public Model.User Login(UserLoginRequest request)
        {
            var entity = _context.Users.Include(i => i.Role).FirstOrDefault(x => x.Username == request.Username);

            if (entity == null)
            {
                throw new UserException("Pogrešan username ili password");
            }

            var hash = GenerateHash(entity.PasswordSalt, request.Password);

            if (hash != entity.PasswordHash)
            {
                throw new UserException("Pogrešan username ili password");
            }

            return _mapper.Map<Model.User>(entity);
        }

        public Model.User Register(UserInsertRequest request)
        {
            var entity = _mapper.Map<Database.User>(request);
            _context.Add(entity);

            if (request.Password != request.PasswordConfirm)
            {
                throw new Exception("Password i potvrda se ne slažu");
            }

            entity.PasswordSalt = GenerateSalt();
            entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);

            _context.SaveChanges();
            return _mapper.Map<Model.User>(entity);
        }

        public Model.User Update(int id, UserInsertRequest request)
        {
            var entity = _context.Users.Find(id);
            if (!string.IsNullOrEmpty(request.Password))
            {
                entity.PasswordHash = GenerateHash(entity.PasswordSalt, request.Password);
            }

            _mapper.Map(request, entity);

            _context.SaveChanges();

            return _mapper.Map<Model.User>(entity);
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

        public Model.User GetUserByUsername(string username)
        {
            var entity = _context.Users.Where(w => w.Username == username).FirstOrDefault();
            return _mapper.Map<Model.User>(entity);
        }
    }
}
