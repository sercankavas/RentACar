using Core.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBrandService
    {
        //C
        IResult Add(Brand entity);
        //R
        IDataResult<List<Brand>> GetAll();
        IDataResult<List<Brand>> GetAllById(int id);
        IDataResult<List<Brand>> GetAllByName(string name);
        //U
        IResult Update(Brand entity);
        //D
        IResult Delete(Brand entity);
    }
}
