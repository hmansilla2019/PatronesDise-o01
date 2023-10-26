using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ResponsabilidadUnica
{
    public class Vehiculo
    {
        protected string marca;
        protected int velocidad;

        public string Marca { get { return marca; } set { marca = value; } }
        public int Velocidad { get { return velocidad; } set { velocidad = value; } }

      

        public void Acelerar(int aceleracion)
        {
            velocidad += aceleracion;
        }

       

    }

    public class ImprimirVehiculo : Vehiculo
    {
        public void ImprimirDatos()
        {
            Console.WriteLine($"Marca {marca} velocidad {velocidad}");
        }
    }


}
