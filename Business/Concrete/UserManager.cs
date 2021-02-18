using Business.Abstract;
using Business.Constants;
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
        IUserDal userDal;
        public UserManager(IUserDal userDal)
        {
            this.userDal = userDal;
        }
        public IResult Add(User user)
        {
            userDal.Add(user);
            return new SuccessResult(Messages.UserAdded);
        }

        public IResult Delete(User user)
        {
            userDal.Delete(user);
            return new SuccessResult(Messages.UserDeleted);
        }

        public IDataResult<List<User>> Get()
        {
            return new SuccessDataResult<List<User>>(Messages.UsersListed);
        }

        public IResult Update(User user)
        {
            userDal.Update(user);
            return new SuccessResult(Messages.UserUpdated);
        }
    }
}
