using DTS.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTS.Bussiness.Abstract
{
    internal interface IAidatlarService
    {
        List<Aidatlar> GetAll();
        Aidatlar GetById(int AidatlarID);
        void Add(Aidatlar uyeler);
        void Update(Aidatlar uyeler);
        void Delete(Aidatlar uyeler);
    }
}
