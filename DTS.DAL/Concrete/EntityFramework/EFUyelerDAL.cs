using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using DTS.DAL.Abstract;
using DTS.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DTS.DAL.Concrete.EntityFramework
{
    public class EFUyelerDAL : IUyelerDAL
    {
        
        private AppDBContext _context = new AppDBContext();
        public void Add(Uyeler uyeler)
        {
            _context.Uyelers.Add(uyeler);
            _context.SaveChanges();
        }

        public void Delete(Uyeler uyeler)
        {
            uyeler.IsDelete = true;
            Update(uyeler);
        }

        public List<Uyeler> GetAll()
        {
            return _context.Uyelers.Where(x=>x.IsDelete!= true).ToList();
        }

        public Uyeler GetById(int id)
        {
            return _context.Uyelers.Find(id);
        }

        public void Update(Uyeler uyeler)
        {
            var result = _context.Uyelers.Find(uyeler.Id);
            if (result != null)
            {
                result.Adi = uyeler.Adi;
                _context.SaveChanges();
            }
        }

        
    }
}
