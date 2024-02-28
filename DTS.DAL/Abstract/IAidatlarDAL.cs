using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTS.Entities.Concrete;

namespace DTS.DAL.Abstract
{
    public interface IAidatlarDAL
    {
        List<Aidatlar> GetAll();
        Aidatlar GetById(int AidatlarID);
        void Add(Aidatlar aidatlar);
        void Update(Aidatlar aidatlar);
        void Delete(Aidatlar aidatlar);
        
    }
}
