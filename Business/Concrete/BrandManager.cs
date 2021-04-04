using Core.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public class BrandManager : IBrandService
    {
        public IResult Add(Brand entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Brand entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Brand>> GetAll()
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Brand>> GetAllById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Brand>> GetAllByName(string name)
        {
            throw new NotImplementedException();
        }

        public IResult Update(Brand entity)
        {
            throw new NotImplementedException();
        }
    }
}
