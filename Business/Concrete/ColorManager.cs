using Business.Abstract;
using Core.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        public IResult Add(Color entity)
        {
            throw new NotImplementedException();
        }

        public IResult Delete(Color entity)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Color>> GetAllById(int id)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Color>> GetAllByName(string name)
        {
            throw new NotImplementedException();
        }

        public IDataResult<List<Color>> GetAllColors()
        {
            throw new NotImplementedException();
        }

        public IResult Update(Color entity)
        {
            throw new NotImplementedException();
        }
    }
}
