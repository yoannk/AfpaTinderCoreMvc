using AfpaTinderCoreMvc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AfpaTinderCoreMvc
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }


        public DbSet<Personne> Personnes { get; set; }
        public DbSet<Loisir> Loisirs { get; set; }
        public DbSet<PersonneLoisir> PersonneLoisirs { get; set; }

        


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonneLoisir>().HasKey(pl => new { pl.PersonneId, pl.LoisirId });
        }
    }
}
