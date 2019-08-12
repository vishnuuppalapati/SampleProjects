using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    public class DeleteDuplicate
    {
        public static void Run()
        {
            Console.WriteLine("Enter Your String:");
            string str = Console.ReadLine();
            Console.WriteLine("Deleting the duplicate values:");
            var unique = new HashSet<char>(str);
            foreach (var characters in unique)
            {
                Console.Write(characters + " ");
            }
            Console.ReadLine();
        }
    }
}
