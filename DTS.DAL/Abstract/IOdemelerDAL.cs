using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTS.Entities.Concrete;

namespace DTS.DAL.Abstract
{
    public interface IOdemelerDAL
    {
        List<Odemeler> GetAll();
        Odemeler GetById(int OdemelerID);
        void Add(Odemeler odemeler);
        void Update(Odemeler odemeler);
        void Delete(Odemeler odemeler);
        
    }
}
