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
    public  partial class FRMCantidadPersonas : Form
    {
        GestionPedido Pedidos = new GestionPedido();
        public FRMCantidadPersonas()
        {
            InitializeComponent();      
            
        }

        private void FRMCantidadPersonas_FormClosed(object sender, FormClosedEventArgs e)
        {            
            FRMLoadMesas.Instancia.Show();            
        }
        private void FRMCantidadPersonas_Load(object sender, EventArgs e)
        {
            ComboBox_LoadItem();
        }
        private void BTMEnviarCantidadPerosnas_Click(object sender, EventArgs e)
        {

            if (CbxCantidadPersonas.SelectedIndex == 0)
            {
                MessageBox.Show("Por favor introduzca la cantidad de personas que van a ordenar.", "Notificacion");
            }
            else
            { 
               Repositorio.Instancia.CantidadPersonasMesa = CbxCantidadPersonas.SelectedIndex;
                this.Close();
                FRMLoadMesas.Instancia.Hide();
                Pedidos.Gestion();
            }
        }
              

        public void ComboBox_LoadItem()
        {
            ComboBoxItem DefaultOpc = new ComboBoxItem();
            {
                DefaultOpc.Texto = "Seleccione una de las opciones";
                DefaultOpc.Value = null;

                CbxCantidadPersonas.Items.Add(DefaultOpc);
                CbxCantidadPersonas.SelectedItem = DefaultOpc;
            };

            
            for (int x = 1; x <= 4; x++)
            {
                ComboBoxItem XPersona = new ComboBoxItem();
                {               
                    XPersona.Texto = $"{x} persona";
                    XPersona.Value = x;
                }
                CbxCantidadPersonas.Items.Add(XPersona);

            }


        }

       
    }
}
