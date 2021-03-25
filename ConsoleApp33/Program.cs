using ConsoleApp33.modelo;
using ConsoleApp33.servicio;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33
{
    class Program
    {
        static void Main(string[] args)
        {
            var emp=new Empleado();
            emp.FuncionEjemplo();
            var cli=new Cliente();
            cli.FuncionEjemplo();

            // funcion no estatica
            var cliServicio=new ClienteServicio();
            cliServicio.ProcesarCliente(cli);

            // funcion estatica
            ClienteServicio.ProcesarClienteEstatica(cli);

            ClienteServicio.ProcesarClienteEstatica(emp);

            var perro=new Perro();
            var gato=new Gato();

            AnimalServicio.MostrarAnimal(perro);
            AnimalServicio.MostrarAnimal(gato);


            // Animal animalGenerico=new Perro();
            //animalGenerico=new Gato();

            var generico=new ClaseGenerica<Gato,Perro>();
            var generico2=new ClaseGenerica<Perro,Animal>();

            var listado=new List<string>();

            var solicitudes=new List<Solicitud>();

            var soli=new Solicitud();
            soli.Solicitante="John";
            soli.Descripcion="problemas con el producto";
            soli.Tipo=TipoSolicitud.Garantia;
            solicitudes.Add(soli);

            var soli2=new Solicitud()
            {
                Solicitante="Anna",Descripcion="problemas",Tipo=TipoSolicitud.Garantia
            };
            solicitudes.Add(soli2);

            var soli3=new Solicitud("Peter","problemas",TipoSolicitud.Garantia);
            solicitudes.Add(soli3);
            Debug.WriteLine("todas las solicitudes: ---------------------");
            SolicitudSrv.Mostrar(solicitudes);

            Debug.WriteLine("solicitudes filtradas: ---------------------");
            var filtrar=SolicitudSrv.Filtrar(solicitudes,TipoSolicitud.Garantia);
            SolicitudSrv.Mostrar(filtrar);

            // ejercicio libro
            var libro=new Libro("Harry Potter","autora");
            var libro2=new Libro();

            Debug.WriteLine(TipoSolicitud.Garantia);
        }

    }
}
