using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaClases
{
    public class CollectionExample
    {
        public static void SortedListCollection()
        {
            //Definir el tamaño de la lista 
            Console.Write("Cueatos elementos agregara a la lista");
            var elements = Convert.ToInt32(Console.ReadLine());

            //declara arrays vacios
            object[] key = new object[elements];
            object[] value = new object[elements];

            //declarar la lista
            SortedList<object, object> srtList = new SortedList<object, object>();
            int i = 0;

            while (i < elements)
                {
                Console.WriteLine("Escriba el elemento a agregar {0}", i);

                //Llenar los arrays
                Console.Write("Key: ");
                key[i] = Console.ReadLine();
                Console.WriteLine("Value: ");
                value[i] = Console.ReadLine();

                //Llenar la lista
                srtList.Add(key[i], value[i]);

                i++;
                }

            //Mostrar elementos en la lista
            Console.WriteLine("Elementos en la lista");
            foreach (KeyValuePair<object, object> element in srtList)
            {
                Console.WriteLine("{0} : {1}", element.Key, element.Value);
            }


        }
    }
}
