using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33.modelo
{
    class Gato : Animal,InterfaceEjemplo
    {
        public string Especie { get ; set; }
        public int Edad {set; get;}
        public void FuncionEjemplo()
        {           

        }
    }
}
