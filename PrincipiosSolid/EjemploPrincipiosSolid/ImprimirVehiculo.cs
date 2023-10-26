using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPrincipiosSolid
{
    public class ImprimirVehiculo : Vehiculo
    {
         public void ImprimirDatos()
        {
            Console.WriteLine($"Marca {marca} Velocidad {velocidad}");
        }
    }
}
