using ConsoleApp33.modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33.servicio
{
    // Servicio, Srv, BL (Business Logic)
    class SolicitudSrv
    {
        public static void Mostrar(List<Solicitud> listado)
        {
            foreach(var soli in listado)
            {
                Debug.WriteLine(soli.Solicitante+" "+soli.Descripcion+" "+soli.Tipo);
            }
        }
        public static List<Solicitud> Filtrar(List<Solicitud> listado,TipoSolicitud tipo)
        {
            var resultado=new List<Solicitud>();

            // lista de valores.   listado.funcion(aa=>aaa.aa).funcion().funcion();
            // Lista,First,Last

            resultado=listado.Where(s => s.Tipo==tipo).ToList(); // lista

            var valor=listado.Where(s => s.Tipo==tipo).First(); // primero


            return resultado;
        }
    }
}
