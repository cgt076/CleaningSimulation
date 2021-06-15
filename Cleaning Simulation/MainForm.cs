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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        int next_lineno = 1;
        Dictionary<int, SetupForm> wdic = new Dictionary<int, SetupForm>();
        private void btn_AddLine_Click(object sender, EventArgs e)
        {
            int no = next_lineno;
            next_lineno++;

            WaferLine wl = new WaferLine(no);

            string[] sitems = new string[] { no.ToString(), "0", "대기중", "00:00" };
            ListViewItem lvi = new ListViewItem(sitems);
            lv_list.Items.Add(lvi);
            lvi.Tag = wl;

            cbox_line.Items.Add(wl);
        }

        private void btn_set_Click(object sender, EventArgs e)
        {
            if (cbox_line.SelectedIndex == -1)
            {
                return;
            }
            WaferLine wl = cbox_line.SelectedItem as WaferLine;
            if (wdic[wl.No].Visible == false)
            {
                wdic[wl.No].Show();
            }
        }
    }
}
