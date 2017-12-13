using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace WebAppProva2Lab2_MauroSergioSantos.Models
{
    public class ContextoEF: DbContext
    {
        //Metodo Construtor (ctor tab tab)

        public ContextoEF():base("name=DefaultConnection")
        {

        }
        public DbSet<Animal> Animais { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Especie> Especies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}