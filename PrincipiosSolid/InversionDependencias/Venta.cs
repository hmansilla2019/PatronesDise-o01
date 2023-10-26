using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InversionDependencias
{
    public class Venta
    {
        public int Id { get;set; }
        public double Monto { get; set; }
    }


    public interface iRepositorio
    {
        void Guardar(Venta venta);
    }

    public interface iFormaPago
    {
        void Pagar(Venta venta);
    }

    public class VentaAuto
    {

        iFormaPago fp;
        iRepositorio rep;
        public VentaAuto(iFormaPago fp, iRepositorio rep)
        {
            this.fp = fp;
            this.rep = rep;
        }

        public void VenderAuto(Venta venta)
        {
            // grabar la venta
            this.rep.Guardar(venta);

            // Registrar el pago
            this.fp.Pagar(venta);
        }
    }

    public class SqlDataBase : iRepositorio
    {
        public void Guardar(Venta venta)
        {
            // logica para grabar la venta
        }
    }
    public class OracleDatabase : iRepositorio
    {
        public void Guardar(Venta venta)
        {
            // logica para grabar la venta
        }
    }
    public class Contado : iFormaPago
    {
        public void Pagar(Venta venta)
        {
            // logica para registrar pago
        }
    }

    public class TarjetaCredito : iFormaPago
    {
        public void Pagar(Venta venta)
        {
            // logica para registrar pago
        }
    }
}
