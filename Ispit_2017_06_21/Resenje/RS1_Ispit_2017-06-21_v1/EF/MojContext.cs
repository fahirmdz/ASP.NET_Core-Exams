﻿using Microsoft.EntityFrameworkCore;
using RS1_Ispit_2017_06_21_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RS1_Ispit_2017_06_21_v1.EF
{
    public class MojContext: DbContext
    {
        public MojContext(DbContextOptions<MojContext> options): base(options)
        {

        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MaturskiIspitStavka>()
                .HasOne(x => x.MaturskiIspit)
                .WithMany(x => x.MaturskiIspitStavke)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Ucenik> Ucenik { get; set; }
        public DbSet<UpisUOdjeljenje> UpisUOdjeljenje { get; set; }
        public DbSet<Odjeljenje> Odjeljenje { get; set; }
        public DbSet<Nastavnik> Nastavnik { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AuthorizationToken> AuthorizationTokens { get; set; }
        public DbSet<MaturskiIspit> MaturskiIspiti { get; set; }
        public DbSet<MaturskiIspitStavka> MaturskiIspitStavke { get; set; }


    }
}
