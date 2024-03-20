using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HERBOYUCA
{
    public partial class frm_principal : Form
    {
        public frm_principal()
        {
            InitializeComponent();
        }
        private void barprogres()
        {
            pnl_secundario.Width += 3;
            if(pnl_secundario.Width >= 800)
            {
                tmr_barraprogreso.Stop();
            }
        }
        private void tmr_barraprogreso_Tick(object sender, EventArgs e)
        {
            barprogres();
        }
    }
}
