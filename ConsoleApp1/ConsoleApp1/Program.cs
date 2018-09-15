using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Empleado o = new Empleado();
            string n="";
            double sueldo = 0;
            double  bono = 0;
            Console.WriteLine("inggere nomnbre");
            n = Console.ReadLine();
            Console.WriteLine("sueldo");
            sueldo = Convert.ToDouble(Console.ReadLine());

            Console.ReadKey();
        }
    }
}
