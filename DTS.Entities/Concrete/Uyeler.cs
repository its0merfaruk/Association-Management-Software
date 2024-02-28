using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTS.Entities.Abstract;

namespace DTS.Entities.Concrete
{
    public class Uyeler : IEntity
    {
        public int Id { get; set; }
        public string TC_Kimlik { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sehir { get; set; }
        public string Kan_Grubu { get; set; }
        public bool Aktif { get; set; }
        public DateTime Dogum_Tarihi { get; set; }
        public bool IsDelete { get; set; }
        public int AidatlarID { get; set; }
        public Aidatlar Aidatlar { get; set; }

        public int OdemelerID { get; set; }
        public Odemeler Odemeler { get; set; }
    }
}
