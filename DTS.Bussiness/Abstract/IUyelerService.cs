using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTS.Entities.Concrete;

namespace DTS.Bussiness.Abstract
{
    public interface IUyelerService
    {
        List<Uyeler> GetAll();
        Uyeler GetById(int uyelerId);
        void Add(Uyeler uyeler);
        void Update(Uyeler uyeler);
        void Delete(Uyeler uyeler);

    }
}
