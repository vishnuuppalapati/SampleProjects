using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    public class DelegateSample
    {
        public delegate void DelMethod(int a);
        public static void Run()
        {
            Console.WriteLine("Enter the Delegate value:");
            int b = int.Parse(Console.ReadLine());
            DelMethod delobj = new DelMethod(DelFunction);
            delobj(b);
            Console.ReadLine();
        }
        public static void DelFunction(int val)
        {
            val *= val;
            Console.WriteLine("Multliplication Value is:{0}", val);
        }
    }
}
