using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public sealed class Repositorio
    {

        public static Repositorio Instancia { get; } = new Repositorio();

        public int CantidadPersonasMesa = new int();

        public List<Mesa> Mesa1 = new List<Mesa>();
        List<Mesa> Mesa2 = new List<Mesa>();
        List<Mesa> Mesa3 = new List<Mesa>();
        List<Mesa> Mesa4 = new List<Mesa>();
        List<Mesa> Mesa5 = new List<Mesa>();
        List<Mesa> Mesa6 = new List<Mesa>();

        public List<Pedidos> Ordenes = new List<Pedidos>();



        private Repositorio()
        { }

    }
}
