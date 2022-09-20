using System;
using Dominio;
using Microsoft.EntityFrameworkCore;

namespace persistencia
{
    public class ApplicationContext: DbContext
    {
        //private const string connectionString = "Data Source=localhost\\SQLEXPRESS;Initial Catalog=Ejemplo23;Integrated Security=True;";

        private const string connectionString = "Data Source=DESKTOP-GAVVF7U;Initial Catalog=Ejemplo23;Integrated Security=True;";

        public DbSet<Persona> personas {get; set;}

        public DbSet<Carro> carros {get; set;}

        public DbSet<Cliente> clientes {get; set;}

        public DbSet<Tecnico> tecnicos {get; set;}

        public ApplicationContext(){}

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
        :base(options)
    {
    }

     protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(connectionString);
    }

    }
}
