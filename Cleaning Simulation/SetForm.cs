using Cleaning_Simulation_Lib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cleaning_Simulation
{
    public partial class SetForm : Form
    {
        WaferLine wl = null;
        public SetForm(WaferLine wl)
        {
            InitializeComponent();
            this.wl = wl;
        }

        private void tbr_sethf_Scroll(object sender, EventArgs e)
        {
            if (wl == null)
            {
                return;
            }
            lb_sethf.Text = tbr_sethf.Value.ToString();
        }

        private void tbr_setsc1_Scroll(object sender, EventArgs e)
        {
            if (wl == null)
            {
                return;
            }
            lb_setsc1.Text = tbr_setsc1.Value.ToString();
        }

        private void tbr_setsc2_Scroll(object sender, EventArgs e)
        {
            if (wl == null)
            {
                return;
            }
            lb_setsc2.Text = tbr_setsc2.Value.ToString();
        }

        private void tbr_setwafer_Scroll(object sender, EventArgs e)
        {
            if (wl == null)
            {
                return;
            }
            lb_setwafer.Text = tbr_setwafer.Value.ToString();
        }

        private void tbr_setspin_Scroll(object sender, EventArgs e)
        {
            if (wl == null)
            {
                return;
            }
            lb_setspin.Text = tbr_setspin.Value.ToString();
        }

        private void tbr_setdrop_Scroll(object sender, EventArgs e)
        {
            if (wl == null)
            {
                return;
            }
            lb_setdrop.Text = tbr_setdrop.Value.ToString();
        }
    }
}
