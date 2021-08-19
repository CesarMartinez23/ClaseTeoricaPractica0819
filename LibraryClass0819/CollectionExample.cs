using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//César Jacob Martinez Alvarenga.   Código: SMIS055621

namespace LibraryClass0819
{
    public class CollectionExample
    {
        public static void SortedListCollection()
        {
            //Definir el tamaño de la lista.
            Console.WriteLine("¿Cuantos elementos agregara a la lista?: ");
            var elements = Convert.ToInt32(Console.ReadLine());

            //Declarar arrays vacios
            object[] key = new object[elements];
            object[] value = new object[elements];


            //Declarar la lista
            SortedList<object, object> srtList = new SortedList<object, object>();

            int i = 0;

            while (i < elements)
            {
                Console.WriteLine("Escriba el elemento a agregar {0}", i);


                //Llenar los arrays
                Console.WriteLine("Key:");
                key[i] = Console.ReadLine();
                Console.WriteLine("Value:");
                value[i] = Console.ReadLine();


                //Llenar la lista vacia
                srtList.Add(key[i], value[i]);

                i++;
            }

            //Mostrar elementos en la lista

            Console.WriteLine("****Elementos en la Lista**** ");
            foreach (KeyValuePair<object, object> element in srtList)
            {
                Console.WriteLine("{0}: {1}", element.Key, element.Value);
            }
        }
    }
}