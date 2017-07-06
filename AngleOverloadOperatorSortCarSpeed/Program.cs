using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace AngleOverloadOperatorSortCarSpeed
{
    class Program
    {
        static void Main(string[] args)
        {

            Angle ang1 = new Angle(5,45,23);
            Angle ang2 = new Angle(-2,52,38);
            WriteLine(ang1.ToString());
            WriteLine(ang2.ToString());
            Angle ang3 = ang1 + ang2;
            WriteLine();
            WriteLine(ang3.ToString());
            WriteLine();
            WriteLine(8%60);

            ReadLine();


        }
    }
}
