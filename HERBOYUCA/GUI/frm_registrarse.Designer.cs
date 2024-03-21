namespace HERBOYUCA.GUI
{
    partial class frm_registrarse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_registrarse));
            this.btn_mostrar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btn_ocultar = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pnl_cabezera = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btn_minimizar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_cerrar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2GradientPanel2 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btn_iniciarsesion = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txt_contraseña = new Guna.UI2.WinForms.Guna2TextBox();
            this.txt_usuario = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientPanel4 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.txt_correo = new Guna.UI2.WinForms.Guna2TextBox();
            this.elp_registro = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btn_regresar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnl_cabezera.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_mostrar.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_mostrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_mostrar.Image")));
            this.btn_mostrar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_mostrar.ImageRotate = 0F;
            this.btn_mostrar.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_mostrar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.btn_mostrar.Location = new System.Drawing.Point(269, 353);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.PressedState.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_mostrar.Size = new System.Drawing.Size(40, 40);
            this.btn_mostrar.TabIndex = 19;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btn_ocultar
            // 
            this.btn_ocultar.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_ocultar.HoverState.ImageSize = new System.Drawing.Size(35, 35);
            this.btn_ocultar.Image = ((System.Drawing.Image)(resources.GetObject("btn_ocultar.Image")));
            this.btn_ocultar.ImageOffset = new System.Drawing.Point(0, 0);
            this.btn_ocultar.ImageRotate = 0F;
            this.btn_ocultar.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_ocultar.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.btn_ocultar.Location = new System.Drawing.Point(269, 353);
            this.btn_ocultar.Name = "btn_ocultar";
            this.btn_ocultar.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btn_ocultar.Size = new System.Drawing.Size(40, 40);
            this.btn_ocultar.TabIndex = 18;
            this.btn_ocultar.Click += new System.EventHandler(this.btn_ocultar_Click);
            // 
            // pnl_cabezera
            // 
            this.pnl_cabezera.Controls.Add(this.btn_regresar);
            this.pnl_cabezera.Controls.Add(this.btn_minimizar);
            this.pnl_cabezera.Controls.Add(this.btn_cerrar);
            this.pnl_cabezera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_cabezera.FillColor = System.Drawing.Color.Green;
            this.pnl_cabezera.FillColor2 = System.Drawing.Color.YellowGreen;
            this.pnl_cabezera.Location = new System.Drawing.Point(0, 0);
            this.pnl_cabezera.Name = "pnl_cabezera";
            this.pnl_cabezera.Size = new System.Drawing.Size(362, 33);
            this.pnl_cabezera.TabIndex = 17;
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
            this.btn_minimizar.Location = new System.Drawing.Point(296, 0);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(33, 33);
            this.btn_minimizar.TabIndex = 3;
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
            this.btn_cerrar.Location = new System.Drawing.Point(329, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 33);
            this.btn_cerrar.TabIndex = 2;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HERBOYUCA.Properties.Resources.Iso_logo;
            this.pictureBox1.Location = new System.Drawing.Point(94, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 126);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // guna2GradientPanel2
            // 
            this.guna2GradientPanel2.FillColor = System.Drawing.Color.Green;
            this.guna2GradientPanel2.FillColor2 = System.Drawing.Color.YellowGreen;
            this.guna2GradientPanel2.Location = new System.Drawing.Point(52, 393);
            this.guna2GradientPanel2.Name = "guna2GradientPanel2";
            this.guna2GradientPanel2.Size = new System.Drawing.Size(257, 2);
            this.guna2GradientPanel2.TabIndex = 15;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.Green;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.YellowGreen;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(52, 247);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(257, 2);
            this.guna2GradientPanel1.TabIndex = 14;
            // 
            // btn_iniciarsesion
            // 
            this.btn_iniciarsesion.BackColor = System.Drawing.Color.Transparent;
            this.btn_iniciarsesion.BorderRadius = 7;
            this.btn_iniciarsesion.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_iniciarsesion.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_iniciarsesion.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_iniciarsesion.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_iniciarsesion.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_iniciarsesion.FillColor = System.Drawing.Color.Green;
            this.btn_iniciarsesion.FillColor2 = System.Drawing.Color.YellowGreen;
            this.btn_iniciarsesion.Font = new System.Drawing.Font("Baskerville Old Face", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_iniciarsesion.ForeColor = System.Drawing.Color.White;
            this.btn_iniciarsesion.Location = new System.Drawing.Point(106, 438);
            this.btn_iniciarsesion.Name = "btn_iniciarsesion";
            this.btn_iniciarsesion.Size = new System.Drawing.Size(152, 45);
            this.btn_iniciarsesion.TabIndex = 13;
            this.btn_iniciarsesion.Text = "registrarse";
            // 
            // txt_contraseña
            // 
            this.txt_contraseña.BackColor = System.Drawing.Color.Transparent;
            this.txt_contraseña.BorderThickness = 0;
            this.txt_contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_contraseña.DefaultText = "";
            this.txt_contraseña.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_contraseña.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_contraseña.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_contraseña.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_contraseña.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_contraseña.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_contraseña.ForeColor = System.Drawing.Color.Black;
            this.txt_contraseña.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_contraseña.Location = new System.Drawing.Point(52, 354);
            this.txt_contraseña.Name = "txt_contraseña";
            this.txt_contraseña.PasswordChar = '\0';
            this.txt_contraseña.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_contraseña.PlaceholderText = "Contraseña";
            this.txt_contraseña.SelectedText = "";
            this.txt_contraseña.Size = new System.Drawing.Size(257, 41);
            this.txt_contraseña.TabIndex = 12;
            this.txt_contraseña.TextChanged += new System.EventHandler(this.txt_contraseña_TextChanged);
            // 
            // txt_usuario
            // 
            this.txt_usuario.BackColor = System.Drawing.Color.Transparent;
            this.txt_usuario.BorderThickness = 0;
            this.txt_usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_usuario.DefaultText = "";
            this.txt_usuario.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_usuario.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_usuario.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_usuario.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_usuario.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_usuario.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_usuario.ForeColor = System.Drawing.Color.Black;
            this.txt_usuario.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_usuario.Location = new System.Drawing.Point(52, 213);
            this.txt_usuario.Name = "txt_usuario";
            this.txt_usuario.PasswordChar = '\0';
            this.txt_usuario.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_usuario.PlaceholderText = "Usuario";
            this.txt_usuario.SelectedText = "";
            this.txt_usuario.Size = new System.Drawing.Size(257, 36);
            this.txt_usuario.TabIndex = 11;
            // 
            // guna2GradientPanel4
            // 
            this.guna2GradientPanel4.FillColor = System.Drawing.Color.Green;
            this.guna2GradientPanel4.FillColor2 = System.Drawing.Color.YellowGreen;
            this.guna2GradientPanel4.Location = new System.Drawing.Point(52, 321);
            this.guna2GradientPanel4.Name = "guna2GradientPanel4";
            this.guna2GradientPanel4.Size = new System.Drawing.Size(257, 2);
            this.guna2GradientPanel4.TabIndex = 21;
            // 
            // txt_correo
            // 
            this.txt_correo.BackColor = System.Drawing.Color.Transparent;
            this.txt_correo.BorderThickness = 0;
            this.txt_correo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_correo.DefaultText = "";
            this.txt_correo.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt_correo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt_correo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_correo.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt_correo.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_correo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_correo.ForeColor = System.Drawing.Color.Black;
            this.txt_correo.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt_correo.Location = new System.Drawing.Point(52, 287);
            this.txt_correo.Name = "txt_correo";
            this.txt_correo.PasswordChar = '\0';
            this.txt_correo.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txt_correo.PlaceholderText = "herboyuca@gmail.com";
            this.txt_correo.SelectedText = "";
            this.txt_correo.Size = new System.Drawing.Size(257, 36);
            this.txt_correo.TabIndex = 20;
            // 
            // elp_registro
            // 
            this.elp_registro.BorderRadius = 7;
            this.elp_registro.TargetControl = this;
            // 
            // btn_regresar
            // 
            this.btn_regresar.BackColor = System.Drawing.Color.Transparent;
            this.btn_regresar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_regresar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_regresar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_regresar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_regresar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_regresar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_regresar.FillColor = System.Drawing.Color.Empty;
            this.btn_regresar.FillColor2 = System.Drawing.Color.Empty;
            this.btn_regresar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_regresar.ForeColor = System.Drawing.Color.White;
            this.btn_regresar.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btn_regresar.HoverState.FillColor2 = System.Drawing.Color.Cyan;
            this.btn_regresar.Image = ((System.Drawing.Image)(resources.GetObject("btn_regresar.Image")));
            this.btn_regresar.Location = new System.Drawing.Point(0, 0);
            this.btn_regresar.Name = "btn_regresar";
            this.btn_regresar.Size = new System.Drawing.Size(33, 33);
            this.btn_regresar.TabIndex = 4;
            this.btn_regresar.Click += new System.EventHandler(this.btn_regresar_Click);
            // 
            // frm_registrarse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(362, 540);
            this.Controls.Add(this.guna2GradientPanel4);
            this.Controls.Add(this.txt_correo);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_ocultar);
            this.Controls.Add(this.pnl_cabezera);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2GradientPanel2);
            this.Controls.Add(this.guna2GradientPanel1);
            this.Controls.Add(this.btn_iniciarsesion);
            this.Controls.Add(this.txt_contraseña);
            this.Controls.Add(this.txt_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_registrarse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_registrarse";
            this.pnl_cabezera.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ImageButton btn_mostrar;
        private Guna.UI2.WinForms.Guna2ImageButton btn_ocultar;
        private Guna.UI2.WinForms.Guna2GradientPanel pnl_cabezera;
        private Guna.UI2.WinForms.Guna2GradientButton btn_minimizar;
        private Guna.UI2.WinForms.Guna2GradientButton btn_cerrar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel2;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private Guna.UI2.WinForms.Guna2GradientButton btn_iniciarsesion;
        private Guna.UI2.WinForms.Guna2TextBox txt_contraseña;
        private Guna.UI2.WinForms.Guna2TextBox txt_usuario;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel4;
        private Guna.UI2.WinForms.Guna2TextBox txt_correo;
        private Guna.UI2.WinForms.Guna2Elipse elp_registro;
        private Guna.UI2.WinForms.Guna2GradientButton btn_regresar;
    }
}