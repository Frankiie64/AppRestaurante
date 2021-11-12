
namespace Restaurant_CRUD
{
    partial class FRMListarOrdenes
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
            this.BTMVolverAtras = new System.Windows.Forms.Button();
            this.LBoxListarPedios = new System.Windows.Forms.ListBox();
            this.TLPPedidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPPedidos
            // 
            this.TLPPedidos.ColumnCount = 3;
            this.TLPPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TLPPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPPedidos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPPedidos.Controls.Add(this.BTMVolverAtras, 2, 2);
            this.TLPPedidos.Controls.Add(this.LBoxListarPedios, 0, 0);
            this.TLPPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPPedidos.Location = new System.Drawing.Point(0, 0);
            this.TLPPedidos.Name = "TLPPedidos";
            this.TLPPedidos.RowCount = 3;
            this.TLPPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPPedidos.Size = new System.Drawing.Size(1296, 450);
            this.TLPPedidos.TabIndex = 0;
            // 
            // BTMVolverAtras
            // 
            this.BTMVolverAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTMVolverAtras.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTMVolverAtras.Location = new System.Drawing.Point(866, 303);
            this.BTMVolverAtras.Name = "BTMVolverAtras";
            this.BTMVolverAtras.Size = new System.Drawing.Size(427, 144);
            this.BTMVolverAtras.TabIndex = 1;
            this.BTMVolverAtras.Text = "Volver Atras";
            this.BTMVolverAtras.UseVisualStyleBackColor = true;
            this.BTMVolverAtras.Click += new System.EventHandler(this.BTMVolverAtras_Click);
            // 
            // LBoxListarPedios
            // 
            this.TLPPedidos.SetColumnSpan(this.LBoxListarPedios, 3);
            this.LBoxListarPedios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBoxListarPedios.FormattingEnabled = true;
            this.LBoxListarPedios.ItemHeight = 25;
            this.LBoxListarPedios.Location = new System.Drawing.Point(3, 3);
            this.LBoxListarPedios.Name = "LBoxListarPedios";
            this.TLPPedidos.SetRowSpan(this.LBoxListarPedios, 2);
            this.LBoxListarPedios.Size = new System.Drawing.Size(1290, 294);
            this.LBoxListarPedios.TabIndex = 2;
            // 
            // FRMListarOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 450);
            this.Controls.Add(this.TLPPedidos);
            this.Name = "FRMListarOrdenes";
            this.Text = "Ver pedidos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRMListarOrdenes_FormClosed);
            this.Load += new System.EventHandler(this.FRMListarOrdenes_Load);
            this.TLPPedidos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPPedidos;
        private System.Windows.Forms.Button BTMVolverAtras;
        private System.Windows.Forms.ListBox LBoxListarPedios;
    }
}