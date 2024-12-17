//using System;
//using System.Collections.Generic;
//using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicProblem
{
    internal class SecProblem
    {

        static int Sum(int l, int m)
        {
            int sum = l + m;
            return sum * sum;

        }
        static int Diff(int l, int m)
        {
            int diff = l - m;
            return diff * diff;

        }

        static void Main(String[] args)
        {
            Console.WriteLine("Enter the Two Decimal Number : ");

            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            int result1 = Sum(a, b);
            int result2 = Diff(a, b);


            Console.WriteLine("The Square of Sum is : " + result1);
            Console.WriteLine("The Square of Diff is : " + result2);








        }

    }
}
