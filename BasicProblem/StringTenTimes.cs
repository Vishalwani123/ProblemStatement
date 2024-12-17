using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    internal class StringTenTimes
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number : ");
            String num = Console.ReadLine();

            Console.WriteLine("Number printed in 10 times.");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(num+ " ");
            }
            }
        }
    }
