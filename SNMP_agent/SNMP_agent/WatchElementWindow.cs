using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNMP_agent
{
    public partial class WatchElementWindow : Form
    {
        Form1 form1;

        public WatchElementWindow(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

    

        private void OK_button_Click(object sender, EventArgs e)
        {
            Visible = false;
            form1.watch(OID.Text, SNMPOperation.Text);
        }
    }
}
