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
    public class OdemelerManager : IOdemelerService
    {
        EFOdemelerDAL _odemelerDal = new EFOdemelerDAL();
        public void Add(Odemeler odemeler)
        {
            _odemelerDal.Add(odemeler);
        }

        public void Delete(Odemeler odemeler)
        {
            _odemelerDal.Delete(odemeler);
        }

        public List<Odemeler> GetAll()
        {
            return _odemelerDal.GetAll();
        }

        public Odemeler GetById(int odemelerId)
        {
            return _odemelerDal.GetById(odemelerId);
        }

        public void Update(Odemeler odemeler)
        {
            _odemelerDal.Update(odemeler);
        }

    }
}
