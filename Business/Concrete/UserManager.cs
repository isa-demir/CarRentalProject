using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public IResult AddUser(User user)
        {
            if (user.FirstName.Length > 2)
            {
                _userDal.Add(user);
                return new SuccessResult("User addded.");
            }
            return new ErrorResult("Error occured!");
        }

        public IDataResult<List<User>> GetAllUsers()
        {
            return new SuccessDataResult<List<User>>(_userDal.GetAll());
        }

        public IDataResult<User> GetUserById(int id)
        {
            try
            {
                return new SuccessDataResult<User>(_userDal.Get(p => p.UserId == id));
            }
            catch (Exception e)
            {
                return new ErrorDataResult<User>(e.Message);
            }
        }

        public IResult RemoveUser(User user)
        {
            try
            {
                _userDal.Delete(user);
                return new SuccessResult();
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }

        public IResult UpdateUser(User user)
        {
            try
            {
                _userDal.Update(user);
                return new SuccessResult();
            }
            catch (Exception e)
            {
                return new ErrorResult(e.Message);
            }
        }
    }
}
