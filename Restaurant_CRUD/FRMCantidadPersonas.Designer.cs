
namespace Restaurant_CRUD
{
    partial class FRMCantidadPersonas
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
            this.LBLCantidadPersonas = new System.Windows.Forms.Label();
            this.CbxCantidadPersonas = new System.Windows.Forms.ComboBox();
            this.TLPPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPPedidos
            // 
            this.TLPPedidos.ColumnCount = 2;
            this.TLPPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.00001F));
            this.TLPPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPPedidos.Controls.Add(this.LBLCantidadPersonas, 0, 1);
            this.TLPPedidos.Controls.Add(this.CbxCantidadPersonas, 1, 1);
            this.TLPPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPPedidos.Location = new System.Drawing.Point(0, 0);
            this.TLPPedidos.Name = "TLPPedidos";
            this.TLPPedidos.RowCount = 3;
            this.TLPPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.45455F));
            this.TLPPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.72727F));
            this.TLPPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.36364F));
            this.TLPPedidos.Size = new System.Drawing.Size(557, 133);
            this.TLPPedidos.TabIndex = 0;
            // 
            // LBLCantidadPersonas
            // 
            this.LBLCantidadPersonas.AutoSize = true;
            this.LBLCantidadPersonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.LBLCantidadPersonas.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLCantidadPersonas.Location = new System.Drawing.Point(3, 34);
            this.LBLCantidadPersonas.Name = "LBLCantidadPersonas";
            this.LBLCantidadPersonas.Size = new System.Drawing.Size(272, 56);
            this.LBLCantidadPersonas.TabIndex = 0;
            this.LBLCantidadPersonas.Text = "Cuantas personas van a ordenar";
            this.LBLCantidadPersonas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CbxCantidadPersonas
            // 
            this.CbxCantidadPersonas.Dock = System.Windows.Forms.DockStyle.Top;
            this.CbxCantidadPersonas.FormattingEnabled = true;
            this.CbxCantidadPersonas.Location = new System.Drawing.Point(281, 37);
            this.CbxCantidadPersonas.Name = "CbxCantidadPersonas";
            this.CbxCantidadPersonas.Size = new System.Drawing.Size(273, 33);
            this.CbxCantidadPersonas.TabIndex = 1;
            // 
            // FRMCantidadPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 133);
            this.Controls.Add(this.TLPPedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FRMCantidadPersonas";
            this.Text = "Pedidos";
            this.TLPPedidos.ResumeLayout(false);
            this.TLPPedidos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPPedidos;
        private System.Windows.Forms.Label LBLCantidadPersonas;
        private System.Windows.Forms.ComboBox CbxCantidadPersonas;
    }
}