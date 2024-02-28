using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTS.Entities.Abstract;

namespace DTS.Entities.Concrete
{
    public class Odemeler : IEntity
    {
        public int OdemelerID { get; set; }
        public string TC_Kimlik { get; set; }
        public string AidatlarID { get; set; }
        public string Odenen_Tutar { get; set; }
        public DateTime Odeme_Tarihi { get; set; }
        public bool IsDelete { get; set; }
        public IEnumerable<Uyeler> Uyelers { get; set; }
    }
}
