using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicLayer;

namespace Restaurant_CRUD
{
    public sealed partial class FRMLoadMesas : Form
    {
        FRMCantidadPersonas CantidadPersonas;
        FRMListarOrdenes listarOrdenes;       

        private FRMLoadMesas()
        {
            InitializeComponent();
        }

        public static FRMLoadMesas Instancia { get; } = new FRMLoadMesas();

        public void CantidadOrdernes()
        {
           
            CantidadPersonas = new FRMCantidadPersonas();
            CantidadPersonas.Show();
            this.Hide();
            
            
        }

        private void BTMesa1_Click(object sender, EventArgs e)
        {
            Repositorio.Instancia.NumeroMesa = 1;
            CantidadOrdernes();
        }

        private void BTMMesa2_Click(object sender, EventArgs e)
        {
            Repositorio.Instancia.NumeroMesa = 2;
            CantidadOrdernes();
        }

        private void BTMMesa3_Click(object sender, EventArgs e)
        {
            Repositorio.Instancia.NumeroMesa = 3;
            CantidadOrdernes();
        }

        private void BTMMesa4_Click(object sender, EventArgs e)
        {
            Repositorio.Instancia.NumeroMesa = 4;
            CantidadOrdernes();
        }

        private void BTMMesa5_Click(object sender, EventArgs e)
        {
            Repositorio.Instancia.NumeroMesa = 5;
            CantidadOrdernes();
        }

        private void BTMMesa6_Click(object sender, EventArgs e)
        {
            Repositorio.Instancia.NumeroMesa = 6;
            CantidadOrdernes();
        }

        private void BTMListarOrdenes_Click(object sender, EventArgs e)
        {

            if (Repositorio.Instancia.Mesa.Count == 0)
            {
                DialogResult result = MessageBox.Show("No ha introducido ninguna orden, por introuduzca alguna" +
                    " para poder visualizarlas", "Advertecia", MessageBoxButtons.OK);
            
            }
            else
            {
                listarOrdenes = new FRMListarOrdenes();
                this.Hide();
                listarOrdenes.Show();
            }
            
        }
    }
}
