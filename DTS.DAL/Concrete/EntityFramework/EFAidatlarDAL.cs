using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTS.DAL.Abstract;
using DTS.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DTS.DAL.Concrete.EntityFramework
{
    public class EFAidatlarDAL : IAidatlarDAL
    {
        private AppDBContext _context = new AppDBContext();
        public void Add(Aidatlar aidatlar)
        {
            _context.Aidatlars.Add(aidatlar);
            _context.SaveChanges();
        }

        public void Delete(Aidatlar aidatlar)
        {
            _context.Aidatlars.Remove(aidatlar);
            _context.SaveChanges();
        }

        public List<Aidatlar> GetAll()
        {
            return _context.Aidatlars.Where(x=>x.IsDelete!= true).ToList();
        }

        public Aidatlar GetById(int id)
        {
            return _context.Aidatlars.Find(id);
        }

        public void Update(Aidatlar aidatlar)
        {
            var result = _context.Aidatlars.Find(aidatlar.AidatlarID);
            if (result != null)
            {
                //result.Adi = aidatlar.Adi;
                _context.SaveChanges();
            }
        }
    }
}
