using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Clases
{
    internal class CuatroPorCuatro : VehiculoBase
    {
        public bool Levantado { get; set; }

        public void ConducirTerrenosDificiles()
        {
            Console.WriteLine("Conduciendo en terrenos difíciles con la 4x4");
        }
    }
}
