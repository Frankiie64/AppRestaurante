using System;

namespace LogicLayer
{
    public class Mesa
    {
        object CantidadMesa { get; set; }
        int CantidadPersona { get; set; }
        int CantidadOrdenes { get; set; }

        public Mesa(object Mesas, int Personas)
        {
            CantidadMesa = Mesas;
            CantidadPersona = Personas;
            CantidadOrdenes = Personas;

        }

    }
}
