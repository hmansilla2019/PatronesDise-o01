using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace OpenClosed
{

    public interface iVehiculo
    {       
        void PintarVehiculo();
    
    }
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


    public class Auto : Vehiculo, iVehiculo
    {
        public void PintarVehiculo()
        {
            Console.WriteLine("Proceso pinta Auto");
        }
    }

    public class Moto : Vehiculo, iVehiculo
    {
        public void PintarVehiculo()
        {
            Console.WriteLine("Proceso pinta Moto");
        }
    }

    public class Avion : Vehiculo, iVehiculo
    {
        public void PintarVehiculo()
        {
            Console.WriteLine("Proceso pinta Avion");
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
