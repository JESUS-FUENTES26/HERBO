namespace HERBOYUCA
{
    partial class frm_principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_principal));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnl_principal = new System.Windows.Forms.Panel();
            this.pnl_secundario = new System.Windows.Forms.Panel();
            this.tmr_barraprogreso = new System.Windows.Forms.Timer(this.components);
            this.lbl_cargando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.pnl_principal.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(240, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 241);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnl_principal
            // 
            this.pnl_principal.Controls.Add(this.pnl_secundario);
            this.pnl_principal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnl_principal.Location = new System.Drawing.Point(0, 439);
            this.pnl_principal.Name = "pnl_principal";
            this.pnl_principal.Size = new System.Drawing.Size(800, 11);
            this.pnl_principal.TabIndex = 1;
            // 
            // pnl_secundario
            // 
            this.pnl_secundario.BackColor = System.Drawing.Color.Cyan;
            this.pnl_secundario.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_secundario.Location = new System.Drawing.Point(0, 0);
            this.pnl_secundario.Name = "pnl_secundario";
            this.pnl_secundario.Size = new System.Drawing.Size(10, 11);
            this.pnl_secundario.TabIndex = 0;
            // 
            // tmr_barraprogreso
            // 
            this.tmr_barraprogreso.Enabled = true;
            this.tmr_barraprogreso.Interval = 15;
            this.tmr_barraprogreso.Tick += new System.EventHandler(this.tmr_barraprogreso_Tick);
            // 
            // lbl_cargando
            // 
            this.lbl_cargando.AutoSize = true;
            this.lbl_cargando.BackColor = System.Drawing.Color.Transparent;
            this.lbl_cargando.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargando.ForeColor = System.Drawing.Color.White;
            this.lbl_cargando.Location = new System.Drawing.Point(12, 422);
            this.lbl_cargando.Name = "lbl_cargando";
            this.lbl_cargando.Size = new System.Drawing.Size(79, 14);
            this.lbl_cargando.TabIndex = 2;
            this.lbl_cargando.Text = "Cargando...";
            // 
            // frm_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_cargando);
            this.Controls.Add(this.pnl_principal);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HERBOYUCA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.pnl_principal.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnl_principal;
        private System.Windows.Forms.Panel pnl_secundario;
        private System.Windows.Forms.Timer tmr_barraprogreso;
        private System.Windows.Forms.Label lbl_cargando;
    }
}

