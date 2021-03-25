using ConsoleApp33.modelo;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp33.servicio
{
    class AnimalServicio
    {
        //                             
        public static void MostrarAnimal(Animal animal)
        {
            Debug.WriteLine(animal.Especie);
        }
    }
}
