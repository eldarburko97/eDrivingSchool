using eDrivingSchool.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eDrivingSchool.WebAPI.Services
{
    public interface IUserService
    {
        List<Model.User> GetAll(UserSearchRequest search);

        Model.User GetById(int id);

        Model.User Insert(UserInsertRequest request);

        Model.User Update(int id, UserInsertRequest request);


        Model.User Login(UserLoginRequest request);
        Model.User Register(UserInsertRequest request);
        Model.User Authenticate(string username, string password);
        Model.User GetUserByUsername(string username);
    }
}
