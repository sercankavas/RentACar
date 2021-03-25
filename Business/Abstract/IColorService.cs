using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public class IColorService
    {
        //C
        void Add(Color entity);
        //R
        List<Color> GetAll();
        List<Color> GetAllById(int id);
        List<Color> GetAllByName(string name);
        //U
        void Update(Color entity);
        //D
        void Delete(Color entity);
    }
}
