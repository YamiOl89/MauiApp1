﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Clases
{
    internal class Sedan : VehiculoBase
    {
        public int NumeroPuertas { get; set; }

        public void Estacionar()
        {
            Console.WriteLine("Estacionando el sedán");
        }
    }
}
