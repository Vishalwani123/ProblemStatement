using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    internal class FirstProgram
    {
        static void Friends(String[] st)
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("The 5 Friends Name are: ");
            foreach (String i in st)
            {
                Console.WriteLine(i);
            }

        }
        static void Main(string[] args)
        {
            String[] st = new string[5];
            Console.WriteLine("Enter your 5 Friends Name : ");
            for (int i = 0; i < 5; i++)
            {
                st[i] = Console.ReadLine();

            }
            Friends(st);


        }
    }
}
