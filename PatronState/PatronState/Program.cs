using System;

namespace PatronState
{
    class Program
    {
        public static void Main(string[] args)
        {
            var context = new Factura(new ConcreteStateEmitida());
            context.Emitir();
            context.Aprobar();
            context.Pagar();

        }
     
    
    }
    public abstract class State
    {
        protected Factura _context;

        public void SetContext(Factura context)
        {
            this._context = context;
        }

        public abstract void Emitir();

        public abstract void Aprobar();

        public abstract void Pagar();
    }

    // Aplicando State esta clase pasa ser la clase contexto
    public class Factura
    {
        private State _state = null;

        public Factura(State state)
        {
            this.Facturar(state);
        }

        public void Facturar(State estado)
        {
            Console.WriteLine($"Factura: Cambia a estado {estado.GetType().Name}.");
            this._state = estado;
            this._state.SetContext(this);
        }
        public void Emitir()
        {
            this._state.Emitir();
        }

        public void Aprobar()
        {
            this._state.Aprobar();
        }
        public void Pagar()
        {
            this._state.Pagar();
        }




    }
    public class ConcreteStateEmitida : State
    {
        public override void Aprobar()
        {
            Console.WriteLine("ConcreteStateEmitida maneja Emitir.");
            Console.WriteLine("ConcreteStateEmitida cambia de estado la factura.");
            this._context.Facturar(new ConcreteStateAprobada());
        }

        public override void Emitir()
        {
            Console.WriteLine("ConcreteStateEmitida maneja Aprobar.");
        }

        public override void Pagar()
        {
            Console.WriteLine("ConcreteStateEmitida maneja Pagar.");
        }
    }

    public class ConcreteStateAprobada : State
    {
        public override void Emitir()
        {
            Console.Write("ConcreteStateAprobada maneja Emitir.");
        }

        public override void Aprobar()
        {
            Console.WriteLine("ConcreteStateAprobada maneja Aprobar.");
            Console.WriteLine("ConcreteStateAprobada cambia de estado la factura.");
            //        this._context.CambiarEstado(new ConcreteStateEmitida());
        }
        public override void Pagar()
        {
            Console.Write("ConcreteStateAprobada maneja Pagar.");
            this._context.Facturar(new ConcreteStatePagada());
        }
    }

    public class ConcreteStatePagada : State
    {
        public override void Emitir()
        {
            Console.Write("ConcreteStatePagada no maneja Emitir.");
        }

        public override void Aprobar()
        {
            Console.WriteLine("ConcreteStatePagada no maneja Aprobar.");
        }
        public override void Pagar()
        {
            Console.WriteLine("ConcreteStatePagada maneja Pagar.");
            Console.WriteLine("ConcreteStatePagada cambia de estado la factura.");

        }
    }
}
