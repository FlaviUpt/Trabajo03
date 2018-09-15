using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class Empleado
    {
        public string Nombre { get; set; }
        public double Suelo { get; set; }
        public double Bono { get; set; }


        public abstract void CalacularBono();


    }

}
