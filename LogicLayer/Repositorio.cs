using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public sealed class Repositorio
    {

        public static Repositorio Instancia { get; } = new Repositorio();

        public int CantidadPersonasMesa = new int();
        public int CantidadOrdenes = new int();
        public int NumeroMesa = new int();

        public List<Pedidos> Mesa = new List<Pedidos>();
        
        public List<Pedidos> Ordenes = new List<Pedidos>();



        private Repositorio()
        { }

    }
}
