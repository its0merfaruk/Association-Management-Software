using DTS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTS.Bussiness.Abstract
{
    internal interface IOdemelerService
    {
        List<Odemeler> GetAll();
        Odemeler GetById(int odemelerId);
        void Add(Odemeler odemeler);
        void Update(Odemeler odemeler);
        void Delete(Odemeler odemeler);
    }
}
