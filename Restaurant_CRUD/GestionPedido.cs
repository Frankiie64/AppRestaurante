using System;
using System.Collections.Generic;
using System.Text;
using LogicLayer;

namespace Restaurant_CRUD
{
    public class GestionPedido
    {
        FRMPedidos pedidos;
        FRMConfirmacion Confirmacion = new FRMConfirmacion();
        public void Gestion()
        {
            
            int CantidadPersonas = Repositorio.Instancia.CantidadPersonasMesa;

            for (Repositorio.Instancia.CantidadOrdenes = 1; Repositorio.Instancia.CantidadOrdenes <= CantidadPersonas; Repositorio.Instancia.CantidadOrdenes++)
            {
                FRMLoadMesas.Instancia.Hide();
                pedidos = new FRMPedidos();
                pedidos.ShowDialog();
                
            }

            if (Repositorio.Instancia.Ordenes.Count != 0)
            {
                pedidos.Close();
                Confirmacion.Show();
            }
            else
            {
                FRMLoadMesas.Instancia.Show();
            }

        }
    }
}
