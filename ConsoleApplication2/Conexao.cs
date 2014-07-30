using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using MySql.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ConsoleApplication2
{
    public class Conexao : DbContext
    {
        public Conexao()
        {

        }

        public DbSet<Pessoa> Pessoa { get; set; }
        public DbSet<TipoDeDados> TipoDeDados { get; set; }
        public DbSet<Person> Person { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            modelBuilder.Entity<Pessoa>().Property(x => x.Nome).HasMaxLength(100);

            base.OnModelCreating(modelBuilder);
        }
    }
}
