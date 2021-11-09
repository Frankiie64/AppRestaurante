using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant_CRUD
{
    public sealed partial class FRMLoadMesas : Form
    {
        FRMCantidadPersonas CantidadPersonas;
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
            CantidadOrdernes();
        }

        private void BTMMesa2_Click(object sender, EventArgs e)
        {
            CantidadOrdernes();
        }

        private void BTMMesa3_Click(object sender, EventArgs e)
        {
            CantidadOrdernes();
        }

        private void BTMMesa4_Click(object sender, EventArgs e)
        {
            CantidadOrdernes();
        }

        private void BTMMesa5_Click(object sender, EventArgs e)
        {
            CantidadOrdernes();
        }

        private void BTMMesa6_Click(object sender, EventArgs e)
        {
            CantidadOrdernes();
        }
    }
}
