using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERBOYUCA.GUI
{
    public partial class frm_seleccionInicio : Form
    {
        public frm_seleccionInicio()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void Releasecapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void sendmessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnl_cabezera_MouseDown(object sender, MouseEventArgs e)
        {
            Releasecapture();
            sendmessage(this.Handle, 0x112, 0xf012, 0);
        }

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

        private void btn_iniciarSesion_Click(object sender, EventArgs e)
        {
            frm_login obj = new frm_login();
            obj.Show();
            this.Close();
        }
    }
}
