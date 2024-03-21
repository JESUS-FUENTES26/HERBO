namespace HERBOYUCA.GUI
{
    partial class frm_menuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_menuAdmin));
            this.pnl_cabezera = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.btn_menu = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_minimizar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_maximizar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.btn_cerrar = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnl_menus = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2GradientButton6 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton5 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton4 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton3 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pnl_subForms = new System.Windows.Forms.Panel();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.elp_menuAdmin = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.tmr_horaFecha = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.drg_panelCabezara = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.pnl_cabezera.SuspendLayout();
            this.pnl_menus.SuspendLayout();
            this.pnl_subForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_cabezera
            // 
            this.pnl_cabezera.Controls.Add(this.btn_menu);
            this.pnl_cabezera.Controls.Add(this.btn_minimizar);
            this.pnl_cabezera.Controls.Add(this.btn_maximizar);
            this.pnl_cabezera.Controls.Add(this.btn_cerrar);
            this.pnl_cabezera.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_cabezera.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnl_cabezera.FillColor2 = System.Drawing.Color.Green;
            this.pnl_cabezera.Location = new System.Drawing.Point(0, 0);
            this.pnl_cabezera.Name = "pnl_cabezera";
            this.pnl_cabezera.Size = new System.Drawing.Size(916, 33);
            this.pnl_cabezera.TabIndex = 0;
            // 
            // btn_menu
            // 
            this.btn_menu.BackColor = System.Drawing.Color.Transparent;
            this.btn_menu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_menu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_menu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_menu.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_menu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_menu.FillColor = System.Drawing.Color.Empty;
            this.btn_menu.FillColor2 = System.Drawing.Color.Empty;
            this.btn_menu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_menu.ForeColor = System.Drawing.Color.White;
            this.btn_menu.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btn_menu.HoverState.FillColor2 = System.Drawing.Color.Cyan;
            this.btn_menu.Image = ((System.Drawing.Image)(resources.GetObject("btn_menu.Image")));
            this.btn_menu.ImageSize = new System.Drawing.Size(30, 30);
            this.btn_menu.Location = new System.Drawing.Point(0, 0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(48, 33);
            this.btn_menu.TabIndex = 7;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_minimizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_minimizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_minimizar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_minimizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_minimizar.FillColor = System.Drawing.Color.Empty;
            this.btn_minimizar.FillColor2 = System.Drawing.Color.Empty;
            this.btn_minimizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_minimizar.ForeColor = System.Drawing.Color.White;
            this.btn_minimizar.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btn_minimizar.HoverState.FillColor2 = System.Drawing.Color.Cyan;
            this.btn_minimizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_minimizar.Image")));
            this.btn_minimizar.Location = new System.Drawing.Point(817, 0);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(33, 33);
            this.btn_minimizar.TabIndex = 6;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_maximizar
            // 
            this.btn_maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximizar.BackColor = System.Drawing.Color.Transparent;
            this.btn_maximizar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_maximizar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_maximizar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_maximizar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_maximizar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_maximizar.FillColor = System.Drawing.Color.Empty;
            this.btn_maximizar.FillColor2 = System.Drawing.Color.Empty;
            this.btn_maximizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_maximizar.ForeColor = System.Drawing.Color.White;
            this.btn_maximizar.HoverState.FillColor = System.Drawing.Color.Blue;
            this.btn_maximizar.HoverState.FillColor2 = System.Drawing.Color.Cyan;
            this.btn_maximizar.Image = ((System.Drawing.Image)(resources.GetObject("btn_maximizar.Image")));
            this.btn_maximizar.Location = new System.Drawing.Point(850, 0);
            this.btn_maximizar.Name = "btn_maximizar";
            this.btn_maximizar.Size = new System.Drawing.Size(33, 33);
            this.btn_maximizar.TabIndex = 5;
            this.btn_maximizar.Click += new System.EventHandler(this.btn_maximizar_Click);
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.BackColor = System.Drawing.Color.Transparent;
            this.btn_cerrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btn_cerrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btn_cerrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cerrar.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btn_cerrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btn_cerrar.FillColor = System.Drawing.Color.Empty;
            this.btn_cerrar.FillColor2 = System.Drawing.Color.Empty;
            this.btn_cerrar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.HoverState.FillColor = System.Drawing.Color.Red;
            this.btn_cerrar.HoverState.FillColor2 = System.Drawing.Color.Orange;
            this.btn_cerrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_cerrar.Image")));
            this.btn_cerrar.Location = new System.Drawing.Point(883, 0);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(33, 33);
            this.btn_cerrar.TabIndex = 4;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click);
            // 
            // pnl_menus
            // 
            this.pnl_menus.BackColor = System.Drawing.SystemColors.Desktop;
            this.pnl_menus.Controls.Add(this.pictureBox1);
            this.pnl_menus.Controls.Add(this.guna2GradientButton6);
            this.pnl_menus.Controls.Add(this.guna2GradientButton5);
            this.pnl_menus.Controls.Add(this.guna2GradientButton4);
            this.pnl_menus.Controls.Add(this.guna2GradientButton3);
            this.pnl_menus.Controls.Add(this.guna2GradientButton2);
            this.pnl_menus.Controls.Add(this.guna2GradientButton1);
            this.pnl_menus.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menus.Location = new System.Drawing.Point(0, 33);
            this.pnl_menus.Name = "pnl_menus";
            this.pnl_menus.Size = new System.Drawing.Size(200, 512);
            this.pnl_menus.TabIndex = 1;
            this.pnl_menus.Visible = false;
            // 
            // guna2GradientButton6
            // 
            this.guna2GradientButton6.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton6.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton6.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton6.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton6.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2GradientButton6.FillColor = System.Drawing.Color.Empty;
            this.guna2GradientButton6.FillColor2 = System.Drawing.Color.DarkTurquoise;
            this.guna2GradientButton6.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton6.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton6.HoverState.FillColor = System.Drawing.Color.Gray;
            this.guna2GradientButton6.Image = ((System.Drawing.Image)(resources.GetObject("guna2GradientButton6.Image")));
            this.guna2GradientButton6.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2GradientButton6.Location = new System.Drawing.Point(0, 467);
            this.guna2GradientButton6.Name = "guna2GradientButton6";
            this.guna2GradientButton6.Size = new System.Drawing.Size(200, 45);
            this.guna2GradientButton6.TabIndex = 5;
            this.guna2GradientButton6.Text = "Cerrar sesion";
            // 
            // guna2GradientButton5
            // 
            this.guna2GradientButton5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientButton5.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton5.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton5.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton5.FillColor = System.Drawing.Color.DarkTurquoise;
            this.guna2GradientButton5.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton5.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton5.HoverState.FillColor2 = System.Drawing.Color.Gray;
            this.guna2GradientButton5.Location = new System.Drawing.Point(10, 333);
            this.guna2GradientButton5.Name = "guna2GradientButton5";
            this.guna2GradientButton5.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton5.TabIndex = 4;
            this.guna2GradientButton5.Text = "Registro Usuarios";
            // 
            // guna2GradientButton4
            // 
            this.guna2GradientButton4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientButton4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton4.FillColor = System.Drawing.Color.DarkTurquoise;
            this.guna2GradientButton4.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton4.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton4.HoverState.FillColor2 = System.Drawing.Color.Gray;
            this.guna2GradientButton4.Location = new System.Drawing.Point(10, 395);
            this.guna2GradientButton4.Name = "guna2GradientButton4";
            this.guna2GradientButton4.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton4.TabIndex = 3;
            this.guna2GradientButton4.Text = "Vista Usuario";
            // 
            // guna2GradientButton3
            // 
            this.guna2GradientButton3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientButton3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton3.FillColor = System.Drawing.Color.DarkTurquoise;
            this.guna2GradientButton3.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton3.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton3.HoverState.FillColor2 = System.Drawing.Color.Gray;
            this.guna2GradientButton3.Location = new System.Drawing.Point(10, 272);
            this.guna2GradientButton3.Name = "guna2GradientButton3";
            this.guna2GradientButton3.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton3.TabIndex = 2;
            this.guna2GradientButton3.Text = "Registro Planta (2)";
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientButton2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton2.FillColor = System.Drawing.Color.DarkTurquoise;
            this.guna2GradientButton2.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.FillColor2 = System.Drawing.Color.Gray;
            this.guna2GradientButton2.Location = new System.Drawing.Point(10, 211);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton2.TabIndex = 1;
            this.guna2GradientButton2.Text = "Registro Receta";
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.guna2GradientButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2GradientButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2GradientButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2GradientButton1.FillColor = System.Drawing.Color.DarkTurquoise;
            this.guna2GradientButton1.FillColor2 = System.Drawing.Color.Empty;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.FillColor2 = System.Drawing.Color.Gray;
            this.guna2GradientButton1.Location = new System.Drawing.Point(10, 151);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.Size = new System.Drawing.Size(180, 45);
            this.guna2GradientButton1.TabIndex = 0;
            this.guna2GradientButton1.Text = "Registro Planta";
            // 
            // pnl_subForms
            // 
            this.pnl_subForms.BackColor = System.Drawing.Color.Gray;
            this.pnl_subForms.Controls.Add(this.lbl_fecha);
            this.pnl_subForms.Controls.Add(this.lbl_hora);
            this.pnl_subForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_subForms.Location = new System.Drawing.Point(200, 33);
            this.pnl_subForms.Name = "pnl_subForms";
            this.pnl_subForms.Size = new System.Drawing.Size(716, 512);
            this.pnl_subForms.TabIndex = 2;
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.ForeColor = System.Drawing.Color.White;
            this.lbl_fecha.Location = new System.Drawing.Point(101, 258);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(247, 37);
            this.lbl_fecha.TabIndex = 1;
            this.lbl_fecha.Text = "aca va la fecha";
            // 
            // lbl_hora
            // 
            this.lbl_hora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.ForeColor = System.Drawing.Color.White;
            this.lbl_hora.Location = new System.Drawing.Point(246, 184);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(340, 55);
            this.lbl_hora.TabIndex = 0;
            this.lbl_hora.Text = "aca va la hora";
            // 
            // elp_menuAdmin
            // 
            this.elp_menuAdmin.BorderRadius = 7;
            this.elp_menuAdmin.TargetControl = this;
            // 
            // tmr_horaFecha
            // 
            this.tmr_horaFecha.Enabled = true;
            this.tmr_horaFecha.Tick += new System.EventHandler(this.tmr_horaFecha_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 18);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(180, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // drg_panelCabezara
            // 
            this.drg_panelCabezara.DockIndicatorTransparencyValue = 0.6D;
            this.drg_panelCabezara.TargetControl = this.pnl_cabezera;
            this.drg_panelCabezara.UseTransparentDrag = true;
            // 
            // frm_menuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 545);
            this.Controls.Add(this.pnl_subForms);
            this.Controls.Add(this.pnl_menus);
            this.Controls.Add(this.pnl_cabezera);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_menuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_menuAdmin";
            this.pnl_cabezera.ResumeLayout(false);
            this.pnl_menus.ResumeLayout(false);
            this.pnl_subForms.ResumeLayout(false);
            this.pnl_subForms.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel pnl_cabezera;
        private Guna.UI2.WinForms.Guna2Panel pnl_menus;
        private System.Windows.Forms.Panel pnl_subForms;
        private Guna.UI2.WinForms.Guna2GradientButton btn_minimizar;
        private Guna.UI2.WinForms.Guna2GradientButton btn_maximizar;
        private Guna.UI2.WinForms.Guna2GradientButton btn_cerrar;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private Guna.UI2.WinForms.Guna2GradientButton btn_menu;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton6;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton5;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton4;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton3;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2Elipse elp_menuAdmin;
        private System.Windows.Forms.Timer tmr_horaFecha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2DragControl drg_panelCabezara;
    }
}