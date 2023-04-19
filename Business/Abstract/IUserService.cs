using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUserService
    {
        IResult AddUser(User user);
        IResult RemoveUser(User user);
        IDataResult<User> GetUserById(int id);
        IDataResult<List<User>> GetAllUsers();
        IResult UpdateUser(User user);

    }
}
