using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTS.Entities.Abstract;

namespace DTS.Entities.Concrete
{
    public class Aidatlar : IEntity
    {
        public int AidatlarID { get; set; }
        public string TC_Kimlik { get; set; }
        public string Ay { get; set; }
        public string Yil { get; set; }
        public string Aidat_Tutari { get; set; }
        public bool IsDelete { get; set; }

        public IEnumerable<Uyeler> Uyelers { get; set; }

    }
}
