using System;
using System.Collections.Generic;
using System.Text;
using LogicLayer;

namespace Restaurant_CRUD
{
    public class GestionPedido
    {
        FRMPedidos pedidos;
        public void Gestion()
        {
            int CantidadPersonas = Repositorio.Instancia.CantidadPersonasMesa;

            int X = 1;

            for (X = 1; X <= CantidadPersonas; X++)
            {
                pedidos = new FRMPedidos();
                pedidos.ShowDialog();
                FRMLoadMesas.Instancia.Hide();
            }

            pedidos.Close();
            FRMLoadMesas.Instancia.Show();


        }
    }
}
