
namespace Restaurant_CRUD
{
    partial class FRMPedidos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TLPPedidos = new System.Windows.Forms.TableLayoutPanel();
            this.LBLEntrada = new System.Windows.Forms.Label();
            this.LBLPlatoFuerte = new System.Windows.Forms.Label();
            this.LBLBebida = new System.Windows.Forms.Label();
            this.LBLPostre = new System.Windows.Forms.Label();
            this.LBLNombreCliente = new System.Windows.Forms.Label();
            this.CBXEntrada = new System.Windows.Forms.ComboBox();
            this.CBXPlatoFuerte = new System.Windows.Forms.ComboBox();
            this.CBXBebidas = new System.Windows.Forms.ComboBox();
            this.CBXPostre = new System.Windows.Forms.ComboBox();
            this.LBLTituloOrdenes = new System.Windows.Forms.Label();
            this.BTMEnviarPedidos = new System.Windows.Forms.Button();
            this.TXTNombre = new System.Windows.Forms.TextBox();
            this.TLPPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPPedidos
            // 
            this.TLPPedidos.ColumnCount = 4;
            this.TLPPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.75F));
            this.TLPPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.125F));
            this.TLPPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TLPPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.125F));
            this.TLPPedidos.Controls.Add(this.LBLEntrada, 1, 2);
            this.TLPPedidos.Controls.Add(this.LBLPlatoFuerte, 1, 3);
            this.TLPPedidos.Controls.Add(this.LBLBebida, 1, 4);
            this.TLPPedidos.Controls.Add(this.LBLPostre, 1, 5);
            this.TLPPedidos.Controls.Add(this.LBLNombreCliente, 1, 1);
            this.TLPPedidos.Controls.Add(this.CBXEntrada, 2, 2);
            this.TLPPedidos.Controls.Add(this.CBXPlatoFuerte, 2, 3);
            this.TLPPedidos.Controls.Add(this.CBXBebidas, 2, 4);
            this.TLPPedidos.Controls.Add(this.CBXPostre, 2, 5);
            this.TLPPedidos.Controls.Add(this.LBLTituloOrdenes, 1, 0);
            this.TLPPedidos.Controls.Add(this.BTMEnviarPedidos, 2, 6);
            this.TLPPedidos.Controls.Add(this.TXTNombre, 2, 1);
            this.TLPPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPPedidos.Location = new System.Drawing.Point(0, 0);
            this.TLPPedidos.Name = "TLPPedidos";
            this.TLPPedidos.RowCount = 7;
            this.TLPPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111F));
            this.TLPPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.16162F));
            this.TLPPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.16162F));
            this.TLPPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.16162F));
            this.TLPPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.16162F));
            this.TLPPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.16162F));
            this.TLPPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.080808F));
            this.TLPPedidos.Size = new System.Drawing.Size(800, 450);
            this.TLPPedidos.TabIndex = 0;
            // 
            // LBLEntrada
            // 
            this.LBLEntrada.AutoSize = true;
            this.LBLEntrada.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBLEntrada.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLEntrada.Location = new System.Drawing.Point(81, 121);
            this.LBLEntrada.Name = "LBLEntrada";
            this.LBLEntrada.Size = new System.Drawing.Size(315, 72);
            this.LBLEntrada.TabIndex = 1;
            this.LBLEntrada.Text = "Entrada:";
            this.LBLEntrada.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLPlatoFuerte
            // 
            this.LBLPlatoFuerte.AutoSize = true;
            this.LBLPlatoFuerte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBLPlatoFuerte.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLPlatoFuerte.Location = new System.Drawing.Point(81, 193);
            this.LBLPlatoFuerte.Name = "LBLPlatoFuerte";
            this.LBLPlatoFuerte.Size = new System.Drawing.Size(315, 72);
            this.LBLPlatoFuerte.TabIndex = 2;
            this.LBLPlatoFuerte.Text = "Plato fuerte:";
            this.LBLPlatoFuerte.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLBebida
            // 
            this.LBLBebida.AutoSize = true;
            this.LBLBebida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBLBebida.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLBebida.Location = new System.Drawing.Point(81, 265);
            this.LBLBebida.Name = "LBLBebida";
            this.LBLBebida.Size = new System.Drawing.Size(315, 72);
            this.LBLBebida.TabIndex = 3;
            this.LBLBebida.Text = "Bebida:";
            this.LBLBebida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLPostre
            // 
            this.LBLPostre.AutoSize = true;
            this.LBLPostre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBLPostre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLPostre.Location = new System.Drawing.Point(81, 337);
            this.LBLPostre.Name = "LBLPostre";
            this.LBLPostre.Size = new System.Drawing.Size(315, 72);
            this.LBLPostre.TabIndex = 4;
            this.LBLPostre.Text = "Postre:";
            this.LBLPostre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLNombreCliente
            // 
            this.LBLNombreCliente.AutoSize = true;
            this.LBLNombreCliente.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBLNombreCliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLNombreCliente.Location = new System.Drawing.Point(81, 49);
            this.LBLNombreCliente.Name = "LBLNombreCliente";
            this.LBLNombreCliente.Size = new System.Drawing.Size(315, 72);
            this.LBLNombreCliente.TabIndex = 0;
            this.LBLNombreCliente.Text = "Nombre:";
            this.LBLNombreCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CBXEntrada
            // 
            this.CBXEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CBXEntrada.FormattingEnabled = true;
            this.CBXEntrada.Location = new System.Drawing.Point(402, 140);
            this.CBXEntrada.Name = "CBXEntrada";
            this.CBXEntrada.Size = new System.Drawing.Size(314, 33);
            this.CBXEntrada.TabIndex = 6;
            // 
            // CBXPlatoFuerte
            // 
            this.CBXPlatoFuerte.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CBXPlatoFuerte.FormattingEnabled = true;
            this.CBXPlatoFuerte.Location = new System.Drawing.Point(402, 212);
            this.CBXPlatoFuerte.Name = "CBXPlatoFuerte";
            this.CBXPlatoFuerte.Size = new System.Drawing.Size(314, 33);
            this.CBXPlatoFuerte.TabIndex = 7;
            // 
            // CBXBebidas
            // 
            this.CBXBebidas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CBXBebidas.FormattingEnabled = true;
            this.CBXBebidas.Location = new System.Drawing.Point(402, 284);
            this.CBXBebidas.Name = "CBXBebidas";
            this.CBXBebidas.Size = new System.Drawing.Size(314, 33);
            this.CBXBebidas.TabIndex = 8;
            // 
            // CBXPostre
            // 
            this.CBXPostre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CBXPostre.FormattingEnabled = true;
            this.CBXPostre.Location = new System.Drawing.Point(402, 356);
            this.CBXPostre.Name = "CBXPostre";
            this.CBXPostre.Size = new System.Drawing.Size(314, 33);
            this.CBXPostre.TabIndex = 9;
            // 
            // LBLTituloOrdenes
            // 
            this.LBLTituloOrdenes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLTituloOrdenes.AutoSize = true;
            this.TLPPedidos.SetColumnSpan(this.LBLTituloOrdenes, 2);
            this.LBLTituloOrdenes.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLTituloOrdenes.Location = new System.Drawing.Point(81, 10);
            this.LBLTituloOrdenes.Name = "LBLTituloOrdenes";
            this.LBLTituloOrdenes.Size = new System.Drawing.Size(635, 28);
            this.LBLTituloOrdenes.TabIndex = 10;
            this.LBLTituloOrdenes.Text = "Llene los renglones y presione enviar para seguir con el proceso.";
            // 
            // BTMEnviarPedidos
            // 
            this.BTMEnviarPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTMEnviarPedidos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTMEnviarPedidos.Location = new System.Drawing.Point(402, 412);
            this.BTMEnviarPedidos.Name = "BTMEnviarPedidos";
            this.BTMEnviarPedidos.Size = new System.Drawing.Size(314, 35);
            this.BTMEnviarPedidos.TabIndex = 11;
            this.BTMEnviarPedidos.Text = "Enviar";
            this.BTMEnviarPedidos.UseVisualStyleBackColor = true;
            this.BTMEnviarPedidos.Click += new System.EventHandler(this.BTMEnviarPedidos_Click);
            // 
            // TXTNombre
            // 
            this.TXTNombre.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TXTNombre.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TXTNombre.Location = new System.Drawing.Point(402, 68);
            this.TXTNombre.Name = "TXTNombre";
            this.TXTNombre.Size = new System.Drawing.Size(314, 34);
            this.TXTNombre.TabIndex = 12;
            // 
            // FRMPedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TLPPedidos);
            this.Name = "FRMPedidos";
            this.Text = "Ordenes";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRMPedidos_FormClosed);
            this.Load += new System.EventHandler(this.FRMPedidos_Load);
            this.TLPPedidos.ResumeLayout(false);
            this.TLPPedidos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPPedidos;
        private System.Windows.Forms.Label LBLEntrada;
        private System.Windows.Forms.Label LBLPlatoFuerte;
        private System.Windows.Forms.Label LBLBebida;
        private System.Windows.Forms.Label LBLPostre;
        private System.Windows.Forms.Label LBLNombreCliente;
        private System.Windows.Forms.ComboBox CBXEntrada;
        private System.Windows.Forms.ComboBox CBXPlatoFuerte;
        private System.Windows.Forms.ComboBox CBXBebidas;
        private System.Windows.Forms.ComboBox CBXPostre;
        private System.Windows.Forms.Label LBLTituloOrdenes;
        private System.Windows.Forms.Button BTMEnviarPedidos;
        private System.Windows.Forms.TextBox TXTNombre;
    }
}