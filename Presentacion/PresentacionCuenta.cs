using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Logica;
namespace Presentacion
{
    public class PresentacionCuenta
    {
        public void MenuCuentas()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("******************************* BANCO - MENU CUENTAS********************************");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*        1. Agregar Cuenta                                                  *");
                Console.WriteLine("*        2. Consultar Cuenta                                                 *");
                Console.WriteLine("*        3. Modificar                                                   *");
                Console.WriteLine("*        4. Eliminar                                                 *");
                Console.WriteLine("*        5. volver ...                                                     *");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("***********************************************************************");
                Console.Write("Digite una opcion:  ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1: // agregar
                        MenuAgregar();
                        break;
                    case 2:
                        MenuConsultar();
                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                }
            } while (opcion != 5);
        }
        void MenuAgregar()
        {
            Cliente cliente;
            double numCuenta, saldo;
            string id;
            Logica.ServicioCuentas servico = new Logica.ServicioCuentas();

            Console.Clear();
            Console.Write("id Cliente : "); id= Console.ReadLine();

            cliente = new ServicioClientes().BuscarId(id);  
            
            if (cliente==null)
            {
                Console.Clear();
                Console.WriteLine("cliente no existe ... debe crearlo primero");
                Console.ReadKey();
                return;
            }
            Console.Write("Numero de cuenta : "); numCuenta = double.Parse(Console.ReadLine());
            Console.Write("saldo inicial : "); saldo= double.Parse(Console.ReadLine());
            Cuenta cuenta = new Cuenta(numCuenta, cliente, saldo);

            Console.WriteLine(servico.Guardar(cuenta));
            Console.ReadKey();
        }
        void MenuConsultar()
        {
            
            Logica.ServicioCuentas servico = new Logica.ServicioCuentas();

            Console.Clear();
            Console.WriteLine("numero - nombre cliente - saldo  ");
            foreach (var item in servico.Consultar())
            {
                Console.WriteLine(item.NumeroCuenta + " --> " + item.Cliente.Nombre + " --> " + item.getSaldo());
            }

            Console.ReadKey();
        }
    }
}
