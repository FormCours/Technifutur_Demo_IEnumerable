using Demo_IEnumerable.Enumerator;
using Demo_IEnumerable.Models;
using Demo_IEnumerable.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_IEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Collection IEnumerable");
            DemoLinkedList<int> linkedList = new DemoLinkedList<int>();

            linkedList.Add(5);
            linkedList.Add(42);
            linkedList.Add(13);
            linkedList.Add(2);

            // Parcours de la liste (via algorithmie)
            /*
            DemoLinkedItem<int> current = linkedList.FirstElement;
            while (current != null)
            {
                Console.WriteLine(current.Content);
                current = current.NextElement;
            }
            */

            // Parcours de la liste (via algorithmie)
            Console.WriteLine(" - P1");
            foreach(int element in linkedList)
            {
                Console.WriteLine(element);
            }

            Console.WriteLine(" - P2");
            foreach (int element in linkedList)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();



            Console.WriteLine("Generateur via IEnumerator");
            IEnumerator<int> generator = new EvenEnumerator();

            while(generator.MoveNext())
            {
                int value = generator.Current;

                // Logique 
                Console.WriteLine(value);
            }
            Console.WriteLine();



            Console.WriteLine("Generateur via yield return");
            Console.WriteLine(" - Values ");
            foreach(int value in NumberUtils.GetValues())
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();
            Console.WriteLine(" - Even ");
            foreach (int value in NumberUtils.GetEven())
            {
                Console.WriteLine(value);
            }
            Console.WriteLine();


            Console.ReadLine();

        }
    }
}
