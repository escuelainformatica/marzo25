using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33.modelo
{
    // es un contrato
    // para generalizar.
    // no tengo campos. pero si propiedades
    // no puedo definir el cuerpo de los metodos.
    // no puedo ocupar public/private
    // no tengo constructor.

    interface Animal
    {
        string Especie {set; get;}

        void FuncionEjemplo();
    }
}
