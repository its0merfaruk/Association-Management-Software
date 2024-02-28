using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTS.Bussiness.Abstract;
using DTS.DAL.Concrete.EntityFramework;
using DTS.Entities.Concrete;

namespace DTS.Bussiness.Concrete
{
    public class AidatlarManager : IAidatlarService
    {
        EFAidatlarDAL _aidatlarDal = new EFAidatlarDAL();
        public void Add(Aidatlar aidatlar)
        {
            _aidatlarDal.Add(aidatlar);
        }

        public void Delete(Aidatlar aidatlar)
        {
            _aidatlarDal.Delete(aidatlar);
        }

        public List<Aidatlar> GetAll()
        {
            return _aidatlarDal.GetAll();
        }

        public Aidatlar GetById(int aidatlarId)
        {
            return _aidatlarDal.GetById(aidatlarId);
        }

        public void Update(Aidatlar aidatlar)
        {
            _aidatlarDal.Update(aidatlar);
        }
    }
}
