﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTS.Entities.Concrete;

namespace DTS.DAL.Concrete.EntityFramework
{
    public class AppDBContext:DbContext
    {
        public DbSet<Uyeler> Uyelers { get; set; }
        public DbSet<Odemeler> Odemelers { get; set; }
        public DbSet<Aidatlar> Aidatlars { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseJet("Provider = Microsoft.ACE.OLEDB.12.0;Data Source ="
                                  +Directory.GetCurrentDirectory().ToString()+
                                  "/Dernek Takip Programı Veri Tabanı v.0.01.accdb");

        }

    }
}
