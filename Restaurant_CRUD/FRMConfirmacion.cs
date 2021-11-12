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
    public partial class FRMConfirmacion : Form
    {
        bool mostrar = false;       
        FRMPedidos Cancel = new FRMPedidos();
        bool Value;
        public FRMConfirmacion()
        {
            InitializeComponent();
        }

        private void FRMConfirmacion_FormClosing(object sender, FormClosingEventArgs e)
        {

            e.Cancel = Cancelar(); ;
        }

        private void BTMEnviar_Click(object sender, EventArgs e)
        {

            Guardar();
        }
        private void BTMCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private bool Guardar()
        {
             mostrar = true;
            
            foreach (Pedidos Ordenes in Repositorio.Instancia.Ordenes)
            {
                Repositorio.Instancia.Mesa.Add(Ordenes);

            }
            Cancel.DroppOrdenes();
            this.Close();
            FRMLoadMesas.Instancia.Show();

            return mostrar;

        }

        private bool Cancelar()
        {
            Value = false;

            if (mostrar == false)
            {
                DialogResult Avanzar = MessageBox.Show("Si cancela ahora la operacion, las ordenes seran" +
                    " descartadas y no se enviaran a la cocina, estas seguro de querar cerrar el proceso ?"
                    , "Noticacion",
                   MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (Avanzar == DialogResult.Yes)
                {                    
                    Cancel.DroppOrdenes();                    
                    FRMLoadMesas.Instancia.Show();
                }
                else
                {
                    Value = true;
                }
                
            }
            return Value;
        }

       
    }
}
