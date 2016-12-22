using SnmpSharpNet;
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
    public partial class TrapSender : Form
    {
        TrapAgent trapAgent;
        public TrapSender()
        {
            InitializeComponent();

            trapAgent = new TrapAgent();

            comboBoxGeneric.Items.Add("ColdStart");
            comboBoxGeneric.Items.Add("WarmStart");
            comboBoxGeneric.Items.Add("LinkDown");
            comboBoxGeneric.Items.Add("LinkUp");
            comboBoxGeneric.Items.Add("AuthenticationFailure");
            comboBoxGeneric.Items.Add("EGPNeithbourLoss");

            

            textBoxIPAddress.Text = "127.0.0.1";
            textBoxPort.Text = "162";
            textBoxCommunity.Text = "public";
            comboBoxGeneric.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool isSent = AgentSNMP.SendTrap(trapAgent,
                            textBoxIPAddress.Text,
                            int.Parse(textBoxPort.Text),
                            textBoxCommunity.Text,
                            "",
                            "",
                            comboBoxGeneric.SelectedIndex,
                            0,
                            0,
                            AgentSNMP.CreateVbCol(textBoxValue.Text,
                                            textBoxName.Text
                                            )
                          );
            if (isSent)
                labelMessage.Text = "Trap Sent";
            else labelMessage.Text = "Error";                
        }
    }
}
