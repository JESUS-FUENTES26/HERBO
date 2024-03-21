namespace HERBOYUCA.GUI
{
    partial class frm_seleccionInicio
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_seleccionInicio));
            this.btn_iniciarSesion = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_registrarse = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pct_imaLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.pnl_cabezera = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btn_minimizar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_cerrar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.elp_seleccionInicio = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pct_imaLogo)).BeginInit();
            this.pnl_cabezera.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_iniciarSesion
            // 
            this.btn_iniciarSesion.BackColor = System.Drawing.Color.Transparent;
            this.btn_iniciarSesion.BorderRadius = 7;
            this.btn_iniciarSesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_iniciarSesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_iniciarSesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_iniciarSesion.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_iniciarSesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_iniciarSesion.FillColor = System.Drawing.Color.Green;
            this.btn_iniciarSesion.FillColor2 = System.Drawing.Color.YellowGreen;
            this.btn_iniciarSesion.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciarSesion.ForeColor = System.Drawing.Color.White;
            this.btn_iniciarSesion.Location = new System.Drawing.Point(71, 363);
            this.btn_iniciarSesion.Name = "btn_iniciarSesion";
            this.btn_iniciarSesion.Size = new System.Drawing.Size(224, 45);
            this.btn_iniciarSesion.TabIndex = 2;
            this.btn_iniciarSesion.Text = "Iniciar sesion";
            this.btn_iniciarSesion.Click += new System.EventHandler(this.btn_iniciarSesion_Click);
            // 
            // btn_registrarse
            // 
            this.btn_registrarse.BackColor = System.Drawing.Color.Transparent;
            this.btn_registrarse.BorderRadius = 7;
            this.btn_registrarse.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_registrarse.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_registrarse.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_registrarse.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_registrarse.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_registrarse.FillColor = System.Drawing.Color.Green;
            this.btn_registrarse.FillColor2 = System.Drawing.Color.YellowGreen;
            this.btn_registrarse.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrarse.ForeColor = System.Drawing.Color.White;
            this.btn_registrarse.Location = new System.Drawing.Point(71, 423);
            this.btn_registrarse.Name = "btn_registrarse";
            this.btn_registrarse.Size = new System.Drawing.Size(224, 45);
            this.btn_registrarse.TabIndex = 3;
            this.btn_registrarse.Text = "registrarse";
            // 
            // pct_imaLogo
            // 
            this.pct_imaLogo.BackColor = System.Drawing.Color.Transparent;
            this.pct_imaLogo.FillColor = System.Drawing.Color.Transparent;
            this.pct_imaLogo.Image = global::HERBOYUCA.Properties.Resources.ima_logo;
            this.pct_imaLogo.ImageRotate = 0F;
            this.pct_imaLogo.Location = new System.Drawing.Point(71, 104);
            this.pct_imaLogo.Name = "pct_imaLogo";
            this.pct_imaLogo.Size = new System.Drawing.Size(237, 185);
            this.pct_imaLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pct_imaLogo.TabIndex = 4;
            this.pct_imaLogo.TabStop = false;
            // 
            // pnl_cabezera
            // 
            this.pnl_cabezera.Controls.Add(this.btn_minimizar);
            this.pnl_cabezera.Controls.Add(this.btn_cerrar);
            this.pnl_cabezera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_cabezera.FillColor = System.Drawing.Color.Green;
            this.pnl_cabezera.FillColor2 = System.Drawing.Color.YellowGreen;
            this.pnl_cabezera.Location = new System.Drawing.Point(0, 0);
            this.pnl_cabezera.Name = "pnl_cabezera";
            this.pnl_cabezera.Size = new System.Drawing.Size(353, 33);
            this.pnl_cabezera.TabIndex = 5;
            this.pnl_cabezera.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnl_cabezera_MouseDown);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_minimizar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_minimizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_minimizar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_minimizar.FillColor = System.Drawing.Color.Empty;
            this.btn_minimizar.FillColor2 = System.Drawing.Color.Empty;
            this.btn_minimizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_minimizar.ForeColor = System.Drawing.Color.White;
            this.btn_minimizar.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btn_minimizar.HoverState.FillColor2 = System.Drawing.Color.Cyan;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(287, 0);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(33, 33);
            this.btn_minimizar.TabIndex = 1;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cerrar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_cerrar.FillColor = System.Drawing.Color.Empty;
            this.btn_cerrar.FillColor2 = System.Drawing.Color.Empty;
            this.btn_cerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.HoverState.FillColor = System.Drawing.Color.Red;
            this.btn_cerrar.HoverState.FillColor2 = System.Drawing.Color.Orange;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(320, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 33);
            this.btn_cerrar.TabIndex = 0;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // elp_seleccionInicio
            // 
            this.elp_seleccionInicio.BorderRadius = 7;
            this.elp_seleccionInicio.TargetControl = this;
            // 
            // frm_seleccionInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(353, 535);
            this.Controls.Add(this.pnl_cabezera);
            this.Controls.Add(this.pct_imaLogo);
            this.Controls.Add(this.btn_registrarse);
            this.Controls.Add(this.btn_iniciarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_seleccionInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.pct_imaLogo)).EndInit();
            this.pnl_cabezera.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btn_iniciarSesion;
        private Guna.UI2.WinForms.Guna2GradientButton btn_registrarse;
        private Guna.UI2.WinForms.Guna2PictureBox pct_imaLogo;
        private Guna.UI2.WinForms.Guna2GradientPanel pnl_cabezera;
        private Guna.UI2.WinForms.Guna2GradientButton btn_minimizar;
        private Guna.UI2.WinForms.Guna2GradientButton btn_cerrar;
        private Guna.UI2.WinForms.Guna2Elipse elp_seleccionInicio;
    }
}