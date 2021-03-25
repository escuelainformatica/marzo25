using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33.modelo
{
    class Persona
    {
        public string Rut {set; get;}
        public string Nombre {set; get;}
        public string Telefono {set; get;}

        public virtual void FuncionEjemplo()
        {
            Debug.WriteLine("mostrando una persona");
        }
        //public abstract void FuncionDebeDefinirse(); // <-- los hijos deben escribir el codigo
    
    }
}
