using ConsoleApp33.modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33.servicio
{
    class ClienteServicio
    {
        public void ProcesarCliente(Cliente cli)
        {
            Debug.WriteLine(cli.Nombre);
        }
        public static void ProcesarClienteEstatica(Persona cli)
        {
            Debug.WriteLine(cli.Nombre);
        }
    }
}
