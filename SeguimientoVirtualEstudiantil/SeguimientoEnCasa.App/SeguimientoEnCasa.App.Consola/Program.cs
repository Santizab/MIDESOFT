using System;
using SeguimientoEnCasa.App.Dominio;
using SeguimientoEnCasa.App.Persistencia;

namespace SeguimientoEnCasa.App.Consola
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("CRUDed");
            // AddEstudiante();
            // FindEstudiante(1);
        }

        // private static void AddEstudiante()
        // {
        //     var estudiante = new Estudiante
        //     {

        //         Nombre="EstudianteA",
        //         Apellidos="AAA",
        //         NumeroTelefono="1234",
        //         Genero=Genero.Masculino,
        //         Direccion="CllFk",
        //         Latitud=29.236F,
        //         Longitud=-90.658F,
        //         Ciudad="NoWr",
        //         FechaDeNacimiento=new DateTime(2001,01,01)
                
        //     };
        //     _repoEstudiante.AddEstudiante(estudiante);
        // }

        // private static void FindEstudiante(int idEstudiante)
        // {
        //     var estudiante =_repoEstudiante.GetEstudiante(idEstudiante);
        //     Console.WriteLine(estudiante.Nombre+ " "+ estudiante.Apellidos);

        // }

    }
}
