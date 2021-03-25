using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33.modelo
{
    public enum TipoSolicitud
    {
        Reclamo=0
        ,Garantia=1
        ,Devolucion=2
    }


    class Solicitud
    {
        public string Solicitante {set; get;}
        public string Descripcion {set; get;}
        public TipoSolicitud Tipo {set; get;}

        // no regresa valores
        // tiene el nombre de la clase
        public Solicitud()
        {

        }
        public Solicitud(string soli,string desc,TipoSolicitud tipo)
        {
            Solicitante=soli;
            Descripcion=desc;
            Tipo=tipo;
        }


        public void Funcion1()
        {

        }
        public void Funcion1(string at)
        {

        }
        public void Funcion1(string at,string at2)
        {

        }



    }
}
