
namespace Restaurant_CRUD
{
    partial class FRMConfirmacion
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
            this.TLPMensaje = new System.Windows.Forms.TableLayoutPanel();
            this.LBLMensaje = new System.Windows.Forms.Label();
            this.LBLMensajeCancelar = new System.Windows.Forms.Label();
            this.LBLMensajeGuardar = new System.Windows.Forms.Label();
            this.TLPConfirmacion = new System.Windows.Forms.TableLayoutPanel();
            this.TLPBotones = new System.Windows.Forms.TableLayoutPanel();
            this.BTMCancelar = new System.Windows.Forms.Button();
            this.BTMEnviar = new System.Windows.Forms.Button();
            this.TLPMensaje.SuspendLayout();
            this.TLPConfirmacion.SuspendLayout();
            this.TLPBotones.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLPMensaje
            // 
            this.TLPMensaje.ColumnCount = 2;
            this.TLPMensaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPMensaje.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPMensaje.Controls.Add(this.LBLMensaje, 0, 0);
            this.TLPMensaje.Controls.Add(this.LBLMensajeCancelar, 0, 1);
            this.TLPMensaje.Controls.Add(this.LBLMensajeGuardar, 1, 1);
            this.TLPMensaje.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPMensaje.Location = new System.Drawing.Point(39, 25);
            this.TLPMensaje.Name = "TLPMensaje";
            this.TLPMensaje.RowCount = 2;
            this.TLPMensaje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPMensaje.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPMensaje.Size = new System.Drawing.Size(534, 151);
            this.TLPMensaje.TabIndex = 0;
            // 
            // LBLMensaje
            // 
            this.LBLMensaje.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLMensaje.AutoSize = true;
            this.TLPMensaje.SetColumnSpan(this.LBLMensaje, 2);
            this.LBLMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLMensaje.Location = new System.Drawing.Point(3, 25);
            this.LBLMensaje.Name = "LBLMensaje";
            this.LBLMensaje.Size = new System.Drawing.Size(528, 25);
            this.LBLMensaje.TabIndex = 0;
            this.LBLMensaje.Text = "Esta seguro que desea guardar las ordenes registradas ?";
            // 
            // LBLMensajeCancelar
            // 
            this.LBLMensajeCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LBLMensajeCancelar.AutoSize = true;
            this.LBLMensajeCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLMensajeCancelar.Location = new System.Drawing.Point(3, 88);
            this.LBLMensajeCancelar.Name = "LBLMensajeCancelar";
            this.LBLMensajeCancelar.Size = new System.Drawing.Size(261, 50);
            this.LBLMensajeCancelar.TabIndex = 1;
            this.LBLMensajeCancelar.Text = "Presione cancelar para anular el proceso.";
            this.LBLMensajeCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LBLMensajeGuardar
            // 
            this.LBLMensajeGuardar.AutoSize = true;
            this.LBLMensajeGuardar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBLMensajeGuardar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LBLMensajeGuardar.Location = new System.Drawing.Point(270, 75);
            this.LBLMensajeGuardar.Name = "LBLMensajeGuardar";
            this.LBLMensajeGuardar.Size = new System.Drawing.Size(261, 76);
            this.LBLMensajeGuardar.TabIndex = 2;
            this.LBLMensajeGuardar.Text = "Pulse Guardar para enviar estos pedidos a la cocina";
            this.LBLMensajeGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TLPConfirmacion
            // 
            this.TLPConfirmacion.ColumnCount = 3;
            this.TLPConfirmacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.TLPConfirmacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.TLPConfirmacion.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6F));
            this.TLPConfirmacion.Controls.Add(this.TLPMensaje, 1, 1);
            this.TLPConfirmacion.Controls.Add(this.TLPBotones, 1, 2);
            this.TLPConfirmacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPConfirmacion.Location = new System.Drawing.Point(0, 0);
            this.TLPConfirmacion.Name = "TLPConfirmacion";
            this.TLPConfirmacion.RowCount = 3;
            this.TLPConfirmacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.TLPConfirmacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.TLPConfirmacion.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TLPConfirmacion.Size = new System.Drawing.Size(614, 225);
            this.TLPConfirmacion.TabIndex = 0;
            // 
            // TLPBotones
            // 
            this.TLPBotones.ColumnCount = 2;
            this.TLPBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPBotones.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLPBotones.Controls.Add(this.BTMCancelar, 0, 0);
            this.TLPBotones.Controls.Add(this.BTMEnviar, 1, 0);
            this.TLPBotones.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLPBotones.Location = new System.Drawing.Point(39, 182);
            this.TLPBotones.Name = "TLPBotones";
            this.TLPBotones.RowCount = 1;
            this.TLPBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLPBotones.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLPBotones.Size = new System.Drawing.Size(534, 40);
            this.TLPBotones.TabIndex = 1;
            // 
            // BTMCancelar
            // 
            this.BTMCancelar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTMCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTMCancelar.Location = new System.Drawing.Point(3, 3);
            this.BTMCancelar.Name = "BTMCancelar";
            this.BTMCancelar.Size = new System.Drawing.Size(261, 34);
            this.BTMCancelar.TabIndex = 0;
            this.BTMCancelar.Text = "Cancelar";
            this.BTMCancelar.UseVisualStyleBackColor = true;
            this.BTMCancelar.Click += new System.EventHandler(this.BTMCancelar_Click);
            // 
            // BTMEnviar
            // 
            this.BTMEnviar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BTMEnviar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.BTMEnviar.Location = new System.Drawing.Point(270, 3);
            this.BTMEnviar.Name = "BTMEnviar";
            this.BTMEnviar.Size = new System.Drawing.Size(261, 34);
            this.BTMEnviar.TabIndex = 1;
            this.BTMEnviar.Text = "Guardar";
            this.BTMEnviar.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BTMEnviar.UseVisualStyleBackColor = true;
            this.BTMEnviar.Click += new System.EventHandler(this.BTMEnviar_Click);
            // 
            // FRMConfirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 225);
            this.Controls.Add(this.TLPConfirmacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FRMConfirmacion";
            this.Text = "Confirmacion";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FRMConfirmacion_FormClosing);
            this.TLPMensaje.ResumeLayout(false);
            this.TLPMensaje.PerformLayout();
            this.TLPConfirmacion.ResumeLayout(false);
            this.TLPBotones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLPMensaje;
        private System.Windows.Forms.Label LBLMensaje;
        private System.Windows.Forms.Label LBLMensajeCancelar;
        private System.Windows.Forms.Label LBLMensajeGuardar;
        private System.Windows.Forms.TableLayoutPanel TLPConfirmacion;
        private System.Windows.Forms.TableLayoutPanel TLPBotones;
        private System.Windows.Forms.Button BTMCancelar;
        private System.Windows.Forms.Button BTMEnviar;
    }
}