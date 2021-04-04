using Core.Result;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IColorService
    {
        
        IResult Add(Color entity);

        IDataResult<List<Color>> GetAllColors();
        IDataResult<List<Color>> GetAllById(int id);
        IDataResult<List<Color>> GetAllByName(string name);
        
        IResult Update(Color entity);
        
        IResult Delete(Color entity);
    }
}
