﻿using DAW2.Models;
using DAW2.Models.Many_to_Many;
using DAW2.Models.One_to_Many;
using DAW2.Models.One_to_One;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DAW2.Data
{
    public class DatabaseContext: DbContext
    {
        public DbSet<DataBaseModel> DataBaseModels { get; set; }

        // O - M

        public DbSet<Model1> Models1 { get; set; }

        public DbSet<Model2> Models2 { get; set; }

        // O - O

        public DbSet<Model5> Models5 { get; set; }

        public DbSet<Model6> Models6 { get; set; }

        //M - M

        public DbSet<Model3> Models3 { get; set; }
        public DbSet<Model4> Models4 { get; set; }
        public DbSet<ModelsRelation> ModelsRelations { get; set; }

        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {

        }

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            // O - M
            modelBuilder.Entity<Model1>()
                .HasMany(m1 => m1.Models2)
                .WithOne(m2 => m2.Model1);

            // O - O
            modelBuilder.Entity<Model5>()
                .HasOne(m5 => m5.Model6)
                .WithOne(m6 => m6.Model5)
                .HasForeignKey<Model6>(m6 => m6.Model5Id);

            // M - M

            modelBuilder.Entity<ModelsRelation>()
                .HasKey(mr => new { mr.Model3Id, mr.Model4Id });

            modelBuilder.Entity<ModelsRelation>()
                .HasOne<Model3>(mr => mr.Model3)
                .WithMany(m3 => m3.ModelsRelations)
                .HasForeignKey(mr => mr.Model3Id);

            modelBuilder.Entity<ModelsRelation>()
                .HasOne<Model4>(mr => mr.Model4)
                .WithMany(m4 => m4.ModelsRelations)
                .HasForeignKey(mr => mr.Model4Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}