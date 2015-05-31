using Partiu.Eventos.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partiu.Eventos.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
        public DbSet<Evento> Evento { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {   
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Evento>().ToTable("Eventos");
        }
    }
}
