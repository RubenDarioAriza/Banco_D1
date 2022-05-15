using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Presentacion
{
    public class PresentacionCliente
    {
        public void MenuClientes()
        {
            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("******************************* BANCO - MENU CLIENTES********************************");
                Console.WriteLine("*                                                                     *");
                Console.WriteLine("*        1. Agregar Cliente                                                  *");
                Console.WriteLine("*        2. Consultar Cliente                                                 *");
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
            Cliente cliente = new Cliente();
            Logica.ServicioClientes servico = new Logica.ServicioClientes();
            Console.Clear();
            Console.Write("id Cliente : "); cliente.IdCliente = Console.ReadLine();
            Console.Write("nombre cliente : "); cliente.Nombre = Console.ReadLine();
            Console.WriteLine(servico.Guardar(cliente));
            Console.ReadKey();
        }
        void MenuConsultar()
        {
            Cliente cliente = new Cliente();
            Logica.ServicioClientes servico = new Logica.ServicioClientes();

            Console.Clear();
            Console.WriteLine("id Cliente - nombre cliente  ");
            foreach (var item in servico.Consultar())
            {
                Console.WriteLine(item.IdCliente + " --> " + item.Nombre);
            }

            Console.ReadKey();
        }
    }
}
