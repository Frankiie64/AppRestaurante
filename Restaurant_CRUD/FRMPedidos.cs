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
    public partial class FRMPedidos : Form
    {        
        public FRMPedidos()
        {
            InitializeComponent();
        }
        private void BTMEnviarPedidos_Click(object sender, EventArgs e)
        {
            Validation();           
        }

        private void FRMPedidos_Load(object sender, EventArgs e)
        {
            ComboboxItemEntrada();
            LoadPlatoFuerte();
            LoadBebida();
            LoadPostre();            
        }

        private void FRMPedidos_FormClosed(object sender, FormClosedEventArgs e)
        {
            DroppOrdenes();
            FRMLoadMesas.Instancia.Show();
        }


        public void ComboboxItemEntrada()
        {
            ComboBoxItem DefaultOpc = new ComboBoxItem();
            {
                DefaultOpc.Texto = "Seleccione una opcion";
                DefaultOpc.Value = null;

            }

            ComboBoxItem Croqueta = new ComboBoxItem();
            {
                Croqueta.Texto = "Croqueta";
                Croqueta.Value = 1;

            }
            ComboBoxItem Sopa = new ComboBoxItem();
            {
                Sopa.Texto = "Sopa";
                Sopa.Value = 2;

            }
            ComboBoxItem Cardo = new ComboBoxItem();
            {
                Cardo.Texto = "Seleccione una opcion";
                Cardo.Value = 3;

            }
            ComboBoxItem MariscoAlAjo = new ComboBoxItem();
            {
                MariscoAlAjo.Texto = "Marisco al ajo";
                MariscoAlAjo.Value = 4;

            }
            ComboBoxItem Tequeños = new ComboBoxItem();
            {
                Tequeños.Texto = "Tequéños";
                Tequeños.Value = 5;

            }

            CBXEntrada.Items.Add(DefaultOpc);
            CBXEntrada.Items.Add(Croqueta);
            CBXEntrada.Items.Add(Sopa);
            CBXEntrada.Items.Add(Cardo);
            CBXEntrada.Items.Add(MariscoAlAjo);
            CBXEntrada.Items.Add(Tequeños);

            CBXEntrada.SelectedItem = DefaultOpc;


        }

        public void LoadPlatoFuerte()
        {
            ComboBoxItem DefaultOpc = new ComboBoxItem();
            {
                DefaultOpc.Texto = "Seleccione una opcion";
                DefaultOpc.Value = null;
            }
            ComboBoxItem SopaMarisco = new ComboBoxItem();
            {
                SopaMarisco.Texto = "Sopa de marisco";
                SopaMarisco.Value = 1;

            }

            ComboBoxItem PescadoFrito = new ComboBoxItem();
            {
                PescadoFrito.Texto = "Pescado Frito";
                PescadoFrito.Value = 2;

            }
            ComboBoxItem FiletePescado = new ComboBoxItem();
            {
                FiletePescado.Texto = "Filete de pescado";
                FiletePescado.Value = 3;

            }
            ComboBoxItem AtunPlancha = new ComboBoxItem();
            {
                AtunPlancha.Texto = "Atun a la plancha";
                AtunPlancha.Value = 4;

            }
            ComboBoxItem ArrozPollo = new ComboBoxItem();
            {
                ArrozPollo.Texto = "Arroz con pollo";
                ArrozPollo.Value = 5;

            }
            ComboBoxItem ArrozCamaronez = new ComboBoxItem();
            {
                ArrozCamaronez.Texto = "Arroz con camarones";
                ArrozCamaronez.Value = 6;

            }
            ComboBoxItem CamaronesJumbo = new ComboBoxItem();
            {
                CamaronesJumbo.Texto = "Camarones Jumbo";
                CamaronesJumbo.Value = 7;

            }
            ComboBoxItem PolloPalzana = new ComboBoxItem();
            {
                PolloPalzana.Texto = "Pollo a la palmezana";
                PolloPalzana.Value = 8;

            }
            ComboBoxItem LinguiniCamorones = new ComboBoxItem();
            {
                LinguiniCamorones.Texto = "Linguini con camarones";
                LinguiniCamorones.Value = 9;

            }
            ComboBoxItem Espaguetis = new ComboBoxItem();
            {
                Espaguetis.Texto = "Espaguetis de la casa";
                Espaguetis.Value = 1;

            }


            CBXPlatoFuerte.Items.Add(DefaultOpc);
            CBXPlatoFuerte.Items.Add(SopaMarisco);
            CBXPlatoFuerte.Items.Add(PescadoFrito);
            CBXPlatoFuerte.Items.Add(FiletePescado);
            CBXPlatoFuerte.Items.Add(AtunPlancha);
            CBXPlatoFuerte.Items.Add(ArrozPollo);
            CBXPlatoFuerte.Items.Add(ArrozCamaronez);
            CBXPlatoFuerte.Items.Add(CamaronesJumbo);
            CBXPlatoFuerte.Items.Add(PolloPalzana);
            CBXPlatoFuerte.Items.Add(LinguiniCamorones);
            CBXPlatoFuerte.Items.Add(Espaguetis);

            CBXPlatoFuerte.SelectedItem = DefaultOpc;
        }

        public void LoadBebida()
        {
            ComboBoxItem DefaultOpc = new ComboBoxItem();
            {
                DefaultOpc.Texto = "Seleccione una opcion";
                DefaultOpc.Value = null;
            }
            ComboBoxItem Agua = new ComboBoxItem();
            {
                Agua.Texto = "Agua";
                Agua.Value = 1;

            }
            ComboBoxItem CocaCola = new ComboBoxItem();
            {
                CocaCola.Texto = "Coca Cola";
                CocaCola.Value = 2;

            }
            ComboBoxItem JugoNaranja = new ComboBoxItem();
            {
                JugoNaranja.Texto = "Jugo de naranja ";
                JugoNaranja.Value = 3;
            }

            ComboBoxItem JugoPera = new ComboBoxItem();
            {
                JugoPera.Texto = "Jugo de pera ";
                JugoPera.Value = 4;
            }
            ComboBoxItem JugoManzana = new ComboBoxItem();
            {
                JugoManzana.Texto = "Jugo de Manzana";
                JugoManzana.Value = 5;

            }

            CBXBebidas.Items.Add(DefaultOpc);
            CBXBebidas.Items.Add(Agua);
            CBXBebidas.Items.Add(CocaCola);
            CBXBebidas.Items.Add(JugoNaranja);
            CBXBebidas.Items.Add(JugoPera);
            CBXBebidas.Items.Add(JugoManzana);

            CBXBebidas.SelectedItem = DefaultOpc;


        }

        public void LoadPostre()
        {
            ComboBoxItem DefaultOpc = new ComboBoxItem();
            {
                DefaultOpc.Texto = "Seleccione una opcion";
                DefaultOpc.Value = null;
            }
            ComboBoxItem TresLeches = new ComboBoxItem();
            {
                TresLeches.Texto = "Tres leche";
                TresLeches.Value = 1;
            }
            ComboBoxItem Quesillo = new ComboBoxItem();
            {
                Quesillo.Texto = "Quesiilo";
                Quesillo.Value = 2;
            }
            ComboBoxItem Chocolate = new ComboBoxItem();
            {
                Chocolate.Texto = "Chocolate";
                Chocolate.Value = 3;
            }

            CBXPostre.Items.Add(DefaultOpc);
            CBXPostre.Items.Add(TresLeches);
            CBXPostre.Items.Add(Quesillo);
            CBXPostre.Items.Add(Chocolate);

            CBXPostre.SelectedItem = DefaultOpc;

        }
        public void Validation()
        {
            Pedidos Orden;

            if (string.IsNullOrEmpty(TXTNombre.Text))
            {
                MessageBox.Show($"Introduzca el nombre del cliente.");
            }
            else if (CBXEntrada.SelectedItem == null)
            {
                MessageBox.Show($"Introduzca la entrada del cliente.");
            }
            else if (CBXPlatoFuerte.SelectedItem == null)
            {
                MessageBox.Show($"Introduzca el plato fuerte del cliente.");
            }
            else if (CBXBebidas.SelectedItem == null)
            {
                MessageBox.Show($"Introduzca la bebida del cliente.");
            }
            else if (CBXPostre.SelectedItem == null)
            {
                MessageBox.Show($"Introduzca el postre del cliente.");
            }
            else
            {
                MessageBox.Show($"its okey", "Notificacion");

                Orden = new Pedidos();
                {
                    Orden.Nombre = TXTNombre.Text;
                    Orden.Entrada = CBXEntrada.Text;
                    Orden.Bebida = CBXBebidas.Text;
                    Orden.Postre = CBXPostre.Text;
                    Orden.Platofuerte = CBXPlatoFuerte.Text;

                }

                Repositorio.Instancia.Ordenes.Add(Orden);
                this.Close();
            }

        }

       
        public void DroppOrdenes()
        {
            int I = 0;
         
            for (I = 0; I <= Repositorio.Instancia.Ordenes.Count - 1; I++)
            {
                Repositorio.Instancia.Ordenes.RemoveAt(I);
            }

        }
    }
}
