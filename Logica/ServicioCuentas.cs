using System;
using System.Collections.Generic;
using System.Text;
using Entidades;
namespace Logica
{
    public class ServicioCuentas
    {
        Datos.RepositorioCuenta repositorio = new Datos.RepositorioCuenta();
        List<Cuenta> ListaCuentas;
        public ServicioCuentas()
        {
            ListaCuentas = repositorio.Consultar();
        }
        void Actualizar()
        {
            ListaCuentas = repositorio.Consultar();
        }
        public string Guardar(Cuenta cuenta)
        {
            //validar
            return repositorio.Guardar(cuenta);

        }
        public List<Cuenta> Consultar()
        {
            Actualizar();
            return ListaCuentas;
        }
    }
}
