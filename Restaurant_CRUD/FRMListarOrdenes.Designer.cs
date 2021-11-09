
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
            this.LViewPedidos = new System.Windows.Forms.ListView();
            this.BTMVolverAtras = new System.Windows.Forms.Button();
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
            this.TLPPedidos.Controls.Add(this.LViewPedidos, 0, 0);
            this.TLPPedidos.Controls.Add(this.BTMVolverAtras, 2, 2);
            this.TLPPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPPedidos.Location = new System.Drawing.Point(0, 0);
            this.TLPPedidos.Name = "TLPPedidos";
            this.TLPPedidos.RowCount = 3;
            this.TLPPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPPedidos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLPPedidos.Size = new System.Drawing.Size(800, 450);
            this.TLPPedidos.TabIndex = 0;
            // 
            // LViewPedidos
            // 
            this.TLPPedidos.SetColumnSpan(this.LViewPedidos, 3);
            this.LViewPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LViewPedidos.HideSelection = false;
            this.LViewPedidos.Location = new System.Drawing.Point(3, 3);
            this.LViewPedidos.Name = "LViewPedidos";
            this.TLPPedidos.SetRowSpan(this.LViewPedidos, 2);
            this.LViewPedidos.Size = new System.Drawing.Size(794, 292);
            this.LViewPedidos.TabIndex = 0;
            this.LViewPedidos.UseCompatibleStateImageBehavior = false;
            // 
            // BTMVolverAtras
            // 
            this.BTMVolverAtras.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTMVolverAtras.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTMVolverAtras.Location = new System.Drawing.Point(535, 301);
            this.BTMVolverAtras.Name = "BTMVolverAtras";
            this.BTMVolverAtras.Size = new System.Drawing.Size(262, 146);
            this.BTMVolverAtras.TabIndex = 1;
            this.BTMVolverAtras.Text = "Volver Atras";
            this.BTMVolverAtras.UseVisualStyleBackColor = true;
            // 
            // FRMListarOrdenes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TLPPedidos);
            this.Name = "FRMListarOrdenes";
            this.Text = "Ver pedidos";
            this.TLPPedidos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPPedidos;
        private System.Windows.Forms.ListView LViewPedidos;
        private System.Windows.Forms.Button BTMVolverAtras;
    }
}