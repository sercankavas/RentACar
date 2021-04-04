using Business.Abstract;
using Core.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        public IResult Add(User user)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(User user)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<User>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<User> GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public IResult Update(User user)
        {
            throw new NotImplementedException();
        }
    }
}
