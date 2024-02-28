using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTS.Bussiness.Abstract;
using DTS.DAL.Abstract;
using DTS.DAL.Concrete.EntityFramework;
using DTS.Entities.Concrete;

namespace DTS.Bussiness.Concrete
{
    public class UyelerManager : IUyelerService
    {
        EFUyelerDAL _uyelerDal = new EFUyelerDAL();
        public void Add(Uyeler uyeler)
        {
            _uyelerDal.Add(uyeler);
        }

        public void Delete(Uyeler uyeler)
        {
            _uyelerDal.Delete(uyeler);
        }

        public List<Uyeler> GetAll()
        {
            return _uyelerDal.GetAll();
        }

        public Uyeler GetById(int uyelerId)
        {
            return _uyelerDal.GetById(uyelerId);
        }

        public void Update(Uyeler uyeler)
        {
            _uyelerDal.Update(uyeler);
        }

    }
}
