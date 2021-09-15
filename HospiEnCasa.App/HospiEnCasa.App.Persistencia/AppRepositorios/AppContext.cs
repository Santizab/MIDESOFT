using Microsoft.EntityFrameworkCore;
using HospiEnCasa.App.Dominio;

namespace HospiEnCasa.App.Persistencia
{

    public class AppContext:DbContext
    {

        public DbSet <Persona> Personas {get;set;}



        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {

            if (!optionsBuilder.IsConfigured){

                optionsBuilder.UseSqlServer("DataSource=(localdb)\\MSSQLLocalDB; Initial Catalog=HospiEnCasa.Data");

            }

        }

    }
}