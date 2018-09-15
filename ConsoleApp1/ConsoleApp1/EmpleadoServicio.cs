using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EmpleadoServicio
    {
        public List<Empleado> Empleados { get; set; }

        public void CalcularBonos()
        {
            foreach (var item in Empleados)
            {
                item.CalacularBono();

            }

        }
    }
}
