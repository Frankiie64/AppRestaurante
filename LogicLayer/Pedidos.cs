using System;
using System.Collections.Generic;
using System.Text;

namespace LogicLayer
{
    public class Pedidos
    {
        public string Nombre { get; set; }
        public string Entrada { get; set; }
        public string Platofuerte { get; set; }
        public string Bebida { get; set; }
        public string Postre { get; set; }
        public int NumeroMesa { get; set; }

        public string GetMsj()
        {
            return $"Nombre: {Nombre}, Entrada: {Entrada}, Plato fuerte: {Platofuerte}, Bebida: {Bebida}" +
                $", Postre: {Postre}, Numero de la mesa :{NumeroMesa}";
        
        }

    }
}
