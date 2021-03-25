using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33.modelo
{
    class Libro
    {
        public string Nombre {set;get;}
        public string Autor {set; get;}

        public Libro(string nombre, string autor)
        {
            Nombre = nombre;
            Autor = autor;
        }

        public Libro()
        {
        }
    }
}
