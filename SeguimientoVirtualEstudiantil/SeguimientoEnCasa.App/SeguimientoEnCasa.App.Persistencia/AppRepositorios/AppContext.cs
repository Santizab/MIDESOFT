

using Microsoft.EntityFrameworkCore;
using SeguimientoEnCasa.App.Dominio;

namespace SeguimientoEnCasa.App.Persistencia
{
    public class AppContext : DbContext
    {
        public DbSet <Persona> Personas {get;set;}
        public DbSet <Acudiente> Acudientes {get;set;}
        public DbSet <Estudiante> Estudiantes {get;set;}
        public DbSet <Historico> Historicos {get;set;}
        public DbSet <Maestro> Maestros {get;set;}
        public DbSet <SugerenciaEstudio> SugerenciaEstudios {get;set;}
        public DbSet <Tutor> Tutores {get;set;}
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog =SeguimientoEnCasaA.Data");
            }

        }

    }



    
}