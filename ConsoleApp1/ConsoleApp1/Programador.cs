﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Programador : Empleado
    {
        public override void CalacularBono()
        {
            Bono = Suelo * 2;
        }
    }
}
