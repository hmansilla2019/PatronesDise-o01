using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPrincipiosSolid
{

    public interface IVehiculo
    {
        void PintarVehiculo();
    }
    public interface IMoto
    {
      void DefinirCilindradas();
    }

    public interface IAvion
    {
        void AlturaMaxima();
        void AlturaMinima();
    }
    public abstract class Vehiculo
    {
        // Se cambia visibilidad del atributo para que sus hijos puedan imprimirlos
        // Y implementar geter y seter de ser necesario
        protected string marca;
        protected int velocidad;


        public abstract void Acelerar(int aceleracion);
        public abstract void Frenar();
      

    }

    public abstract class VehiculoAereo : Vehiculo
    {
        public abstract void Volar(int aceleracion);

    }


    public class Auto : Vehiculo, IVehiculo
    {
       public override void Acelerar(int aceleracion)
        {
            velocidad += aceleracion;
        }

 
        public override void Frenar()
        {
            velocidad = 0; ;
        }
     

        public void PintarVehiculo()
        {
            Console.WriteLine("Pinto Auto");
        }
    }

    public class Avion : VehiculoAereo, IAvion
    {
        private int altura;

        public override void Acelerar(int aceleracion)
        {
            velocidad += aceleracion;
        }

        public void AlturaMaxima()
        {
            altura = 100000;
        }

        public void AlturaMinima()
        {
            altura = 1000;        
        }


        public override void Frenar()
        {
            velocidad = 0; ;
        }
     

        public void PintarVehiculo()
        {
            Console.WriteLine("Pinto Avion");
        }

        public override void Volar(int aceleracion)
        {
            velocidad += aceleracion*1000;
        }
    }



    public class Moto : Vehiculo, IMoto
    {
        private int cilindradas;

        public override void Acelerar(int aceleracion)
        {
            velocidad += aceleracion;
        }

        public void DefinirCilindradas()
        {
            cilindradas = 500;
        }


        public override void Frenar()
        {
            velocidad = 0; ;
        }
     
        public void PintarVehiculo()
        {
            Console.WriteLine("Pinto Moto");
        }
    }

}
