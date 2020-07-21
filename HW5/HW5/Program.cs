using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW5
{
    class Program
    {
        static void Main(string[] args)
        {
            IDeveloper[] developers = new IDeveloper[]
            {
                new Programmer() {Language = "C#"}, 
                new Programmer() {Language = "JS"}, 
                new Programmer() {Language = "C++"},
                new Builder() {tool = "molotok"}, 
                new Builder() {tool = "asdfg"},
            };

            foreach (var item in developers)
            {
                Console.WriteLine(item.Create());
                Console.WriteLine(item.Destroy());
            }

            Array.Sort(developers);
            foreach (var developer in developers)
            {
                Console.WriteLine(developer.Tool);
            }
        }
    }
}
