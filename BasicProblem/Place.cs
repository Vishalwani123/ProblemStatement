using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicproblem
{
    internal class thirdproblem
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the place where you want to visit most : ");
            string place = Console.ReadLine();

            Console.WriteLine("the place in uppercase : " + place.ToUpper());
            Console.WriteLine("the place in lowercase : " + place.ToLower());

        }
    }
}
