using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33.modelo
{
    class Empleado : Persona
    {
        public int Salario {set; get;}

        public override void FuncionEjemplo()
        {
            Debug.WriteLine("mostrando un empleado");
        }
    }

}
