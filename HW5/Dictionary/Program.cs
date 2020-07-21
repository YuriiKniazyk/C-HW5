using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<uint, string> dictionary = new Dictionary<uint, string>();
            dictionary.Add(1, "Yurii");
            dictionary.Add(2, "Sasha");
            dictionary.Add(3, "Masha");
            dictionary.Add(4, "Nastya");
            dictionary.Add(5, "Sasha");
            dictionary.Add(6, "Svyat");
            dictionary.Add(7, "Artem");

            foreach (var item in dictionary)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Please enter ID: ");
            var id = int.Parse(Console.ReadLine());

            foreach (var item in dictionary)
            {
                if (id == item.Key)
                {
                    Console.WriteLine(item.Value);
                }
                else
                {
                    Console.WriteLine("I can't find this ID");
                }
            }
        }
    }
}
