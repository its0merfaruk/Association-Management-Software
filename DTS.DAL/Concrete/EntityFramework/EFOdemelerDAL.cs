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
    public class EFOdemelerDAL : IOdemelerDAL
    {
        private AppDBContext _context = new AppDBContext();
        public void Add(Odemeler odemeler)
        {
            _context.Odemelers.Add(odemeler);
            _context.SaveChanges();
        }

        public void Delete(Odemeler odemeler)
        {
            odemeler.IsDelete = true;
            Update(odemeler);
        }

        public List<Odemeler> GetAll()
        {
            return _context.Odemelers.Where(x => x.IsDelete != true).ToList();
        }

        public Odemeler GetById(int id)
        {
            return _context.Odemelers.Find(id);
        }

        public void Update(Odemeler odemeler)
        {
            var result = _context.Odemelers.Find(odemeler.OdemelerID);
            if (result != null)
            {
                result.TC_Kimlik = odemeler.TC_Kimlik;
                _context.SaveChanges();
            }
            
        }
    }
}
