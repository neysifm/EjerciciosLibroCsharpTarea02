using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea02.Capitulo05
{
    class Ejercicio_5
    {
        public static String Ejercicio05(int numero)

        {
            switch (numero)
            {
                case 0:
                    return "cero";
                case 1:
                    return "uno";
                case 2:
                    return "dos";
                case 3:
                    return "tres";
                case 4:
                    return "cuatro";
                case 5:
                    return "cinco";
                case 6:
                    return "seis";
                case 7:
                    return "siete";
                case 8:
                    return "ocho";
                case 9:
                    return "nueve";
                default:
                    return "Numero incorrecto";
            }
        }
    }
}
