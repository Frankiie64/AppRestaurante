using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using LogicLayer;

namespace Restaurant_CRUD
{
    public partial class FRMListarOrdenes : Form
    {         
        public FRMListarOrdenes()
        {
            InitializeComponent();
        }
        
        private void FRMListarOrdenes_FormClosed(object sender, FormClosedEventArgs e)
        {
            FRMLoadMesas.Instancia.Show();
        }

        private void FRMListarOrdenes_Load(object sender, EventArgs e)
        {
            LBoxListarPedios.BeginUpdate();

            LBoxListarPedios.Items.Clear();

            foreach (Pedidos ordenes in Repositorio.Instancia.Mesa)
            {

                LBoxListarPedios.Items.Add(ordenes.GetMsj()); ; 
            }

            LBoxListarPedios.EndUpdate();

        }

        private void BTMVolverAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            FRMLoadMesas.Instancia.Show();
        }
    }
}
