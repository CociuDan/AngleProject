using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AngleProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Angle u1 = new Angle(30, 30, 30);
            Angle u2 = new Angle(45, 45, 45);
            Angle u3 = u1 + u2;
            Console.WriteLine(u3.Degrees + " degrees " + u3.Minutes + " minutes " + u3.Seconds + " seconds");
            Console.ReadKey();
        }
    }
}
