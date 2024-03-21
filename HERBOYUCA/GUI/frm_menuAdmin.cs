using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERBOYUCA.GUI
{
    public partial class frm_menuAdmin : Form
    {
        public frm_menuAdmin()
        {
            InitializeComponent();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void tmr_horaFecha_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToString("hh:mm:ss");
            lbl_fecha.Text = DateTime.Now.ToLongDateString();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void maxform()
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else if (WindowState == FormWindowState.Maximized)
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            minform();
        }

        private void btn_maximizar_Click(object sender, EventArgs e)
        {
            maxform();
        }

        private void mostrarPanel()
        {
            if (!pnl_menus.Visible)
            {
                pnl_menus.Visible = true;
            }
            else
            {
                pnl_menus.Visible = false;
            }
        }

        private void btn_menu_Click(object sender, EventArgs e)
        {
            mostrarPanel();
            
            
        }
    }
}
