using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTS.Entities.Concrete;

namespace DTS.DAL.Abstract
{
    public interface IUyelerDAL
    {
        List<Uyeler> GetAll();
        Uyeler GetById(int id);
        void Add(Uyeler uyeler);
        void Update(Uyeler uyeler);
        void Delete(Uyeler uyeler);

    }
}
