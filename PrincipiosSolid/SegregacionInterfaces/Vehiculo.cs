using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ResponsabilidadUnica
{
    public interface iVehiculo
    {
        void PintarVehiculo();
      
    }

    public interface iMoto
    {
        void DefinirCilindradas();

    }
    public interface iAvion
    {
      
        void AlturaMaxima();
        void AlturaMinima();
       

    }
    public abstract class Vehiculo
    {
        protected string marca;
        protected int velocidad;

        public string Marca { get { return marca; } set { marca = value; } }
        public int Velocidad { get { return velocidad; } set { velocidad = value; } }

        public abstract void Acelerar(int aceleracion);
        public abstract void Frenar();


    }


    public abstract class VehiculoAereo : Vehiculo
    {
        public abstract void Volar(int aceleracion);

    }

    public class Auto : Vehiculo, iVehiculo
    {
        public void PintarVehiculo()
        {
            Console.WriteLine("Proceso pinta Auto");
        }


        public override void Acelerar(int aceleracion)
        {
            velocidad += aceleracion;
        }

        public override void Frenar()
        {
            velocidad = 0;
        }

        
    }

    public class Moto : Vehiculo, iVehiculo, iMoto
    {
        private int cantidadCilindradas;


        public void PintarVehiculo()
        {
            Console.WriteLine("Proceso pinta Moto");
        }
        public override void Acelerar(int aceleracion)
        {
            velocidad += aceleracion;
        }

        public override void Frenar()
        {
            velocidad = 0;
        }

      

        public void DefinirCilindradas()
        {
            cantidadCilindradas=100;
        }
    }

    public class Avion : VehiculoAereo, iVehiculo,iAvion
    {
        private int alturaMaxima;
        private int alturaMinima;

        public void PintarVehiculo()
        {
            Console.WriteLine("Proceso pinta Avion");
        }
        public override void Acelerar(int aceleracion)
        {
            velocidad += aceleracion;
        }

        public override void Frenar()
        {
            velocidad = 0;
        }

        public override void Volar(int aceleracion)
        {
            velocidad += aceleracion * 1000;
        }

        public void AlturaMaxima()
        {
            alturaMaxima=10000;
        }

        public void AlturaMinima()
        {
            alturaMinima = 200;
        }

    }


}
