using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleProject
{
    public class PalindromeSample
    {
        public static void Run()
        {
            string[] arr = { "vishnu", "anil", "rajesh", "anji", "rajashekar", "madam", "anil", "ajay", "teja", "santosh", "malayalam" };
            
            foreach (var words in arr)
            {
                string rev = "";
                char[] ch = words.ToCharArray();
                for (int i=ch.Length-1;i>=0;i--)
                {
                    rev += words[i];
                }
                if(rev==words)
                {
                    Console.WriteLine("Palindrome is:{0}", rev);
                }
                
            }
            Console.ReadLine();
    }
}
