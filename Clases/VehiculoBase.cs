using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp1.Clases
{

    internal class VehiculoBase : IVehiculo
    {
        //Propiedades 
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Color { get; set; }
        public int Anio { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public int VelocidadMaxima { get; }
        public int VelocidadActual { get; }

        public void Bocina()// Metodos 
        {
            Console.WriteLine("Bocina del vehículo");
        }

        public void Acelerar(int cuanto)
        {
            Console.WriteLine("Acelerando el vehículo en {0} unidades", cuanto);
        }

        public void Encender()
        {
            Console.WriteLine("Encendiendo el vehículo");
        }

        public void Apagar()
        {
            Console.WriteLine("Apagando el vehículo");
        }

        public void Frenar(int cuanto)
        {
            Console.WriteLine("Frenando el vehículo en {0} unidades", cuanto);
        }
    }
}