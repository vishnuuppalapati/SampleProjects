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
            string[] array = { "vishnu", "anil", "rajesh", "anji", "rajashekar", "madam", "anil", "ajay", "teja", "santosh", "malayalam" };
            
            foreach (var words in array)
            {
                string revstring = "";
                char[] ch = words.ToCharArray();
                for (int i=ch.Length-1;i>=0;i--)
                {
                    revstring += words[i];
                }
                if(revstring==words)
                {
                    Console.WriteLine("Palindrome is:{0}", revstring);
                }
                
            }
            Console.ReadLine();
    }
}
