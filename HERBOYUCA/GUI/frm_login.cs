using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERBOYUCA.GUI
{
    public partial class frm_login : Form
    {
        public frm_login()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void Releasecapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void sendmessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void minform()
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Minimized;
            }
            else if (WindowState == FormWindowState.Minimized)
            {
                WindowState = FormWindowState.Normal;
            }
        }
        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            minform();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txt_contraseña_TextChanged(object sender, EventArgs e)
        {
            txt_contraseña.UseSystemPasswordChar = true;
        }

        private void guna2GradientPanel3_MouseDown(object sender, MouseEventArgs e)
        {
            Releasecapture();
            sendmessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_mostrar_Click(object sender, EventArgs e)
        {
            btn_ocultar.BringToFront();
            txt_contraseña.UseSystemPasswordChar = false;
        }

        private void btn_ocultar_Click(object sender, EventArgs e)
        {
            btn_mostrar.BringToFront();
            txt_contraseña.UseSystemPasswordChar = true;
        }
    }
}
