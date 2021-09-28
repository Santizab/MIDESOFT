using System.Collections.Generic;
using SeguimientoEnCasa.App.Dominio;
using System;
using SeguimientoEnCasa.App.Persistencia;
using System.Linq;


namespace SeguimientoEnCasa.App.Persistencia
{

    public class RepositorioAcudiente : IRepositorioAcudiente
    {
        private readonly SeguimientoEnCasa.App.Persistencia.AppContext _appContext;
        public RepositorioAcudiente(SeguimientoEnCasa.App.Persistencia.AppContext appContext)
        {
            _appContext=appContext;
        }
        Acudiente IRepositorioAcudiente.AddAcudiente(Acudiente acudiente)
        {
            var acudienteAdicionado=_appContext.Acudientes.Add(acudiente);
            _appContext.SaveChanges();
            return acudienteAdicionado.Entity;
        }

        Acudiente IRepositorioAcudiente.UpdateAcudiente(Acudiente acudiente)
        {
            var acudienteEncontrado=_appContext.Acudientes.FirstOrDefault(p => p.Id ==acudiente.Id);
            if(acudienteEncontrado!=null)
            {
                 acudienteEncontrado.Nombre= acudiente.Nombre;
                 acudienteEncontrado.Apellidos= acudiente.Apellidos;
                 acudienteEncontrado.NumeroTelefono= acudiente.NumeroTelefono;
                 acudienteEncontrado.Genero= acudiente.Genero;
                 acudienteEncontrado.Parentesco= acudiente.Parentesco;
                 acudienteEncontrado.Correo= acudiente.Correo;

                 _appContext.SaveChanges();
            }
            return acudienteEncontrado;
        }

        void IRepositorioAcudiente.DeleteAcudiente(int IdAcudiente)
        {
            var acudienteEncontrado=_appContext.Acudientes.FirstOrDefault(p => p.Id ==IdAcudiente);
            if(acudienteEncontrado==null)
            return;
            _appContext.Acudientes.Remove(acudienteEncontrado);
            _appContext.SaveChanges();
        }

        Acudiente IRepositorioAcudiente.GetAcudiente(int IdAcudiente)
        {
            var acudienteEncontrado=_appContext.Acudientes.FirstOrDefault(p => p.Id ==IdAcudiente);
            return acudienteEncontrado;
        }

        IEnumerable<Acudiente> IRepositorioAcudiente.GetAllAcudientes()
        {
            return _appContext.Acudientes;
        }
        
    }

}