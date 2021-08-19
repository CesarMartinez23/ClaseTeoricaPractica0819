using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryMonth
{
    public class NumberMonth
    {
        public static void Month()
        {
            Console.WriteLine("Ingrese un numero del 1 al 12, el cual representara el mes que correspone al numero");
            var numberMonth = Convert.ToInt32(Console.ReadLine());

            switch (numberMonth)
            {
                case 1:
                    Console.WriteLine("El numero {0}, corresponde al mes de: Enero.", numberMonth);
                    break;
                case 2:
                    Console.WriteLine("El numero {0}, corresponde al mes de: Febrero.", numberMonth);
                    break;
                case 3:
                    Console.WriteLine("El numero {0}, corresponde al mes de: Marzo.", numberMonth);
                    break;
                case 4:
                    Console.WriteLine("El numero {0}, corresponde al mes de: Abril.", numberMonth);
                    break;
                case 5:
                    Console.WriteLine("El numero {0}, corresponde al mes de: Mayo.", numberMonth);
                    break;
                case 6:
                    Console.WriteLine("El numero {0}, corresponde al mes de: Junio.", numberMonth);
                    break;
                case 7:
                    Console.WriteLine("El numero {0}, corresponde al mes de: Julio.", numberMonth);
                    break;
                case 8:
                    Console.WriteLine("El numero {0}, corresponde al mes de: Agosto.", numberMonth);
                    break;
                case 9:
                    Console.WriteLine("El numero {0}, corresponde al mes de: Septiembre.", numberMonth);
                    break;
                case 10:
                    Console.WriteLine("El numero {0}, corresponde al mes de: Octubre.", numberMonth);
                    break;
                case 11:
                    Console.WriteLine("El numero {0}, corresponde al mes de: Noviembre.", numberMonth);
                    break;
                case 12:
                    Console.WriteLine("El numero {0}, corresponde al mes de: Diciembre.", numberMonth);
                    break;
                default:
                    Console.WriteLine("El numero ingresado, no corresponde a uno de los 12 meses del año.");
                    break;
            }

        }
    }
}