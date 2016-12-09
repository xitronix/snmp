using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNMP_agent
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBoxOperations.Items.Add("Get");
            comboBoxOperations.Items.Add("Get Next");
            textBoxAddress.Text = "localhost";
            
            
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            String address = textBoxAddress.Text;
            String OID = textBoxOID.Text;
            String option = comboBoxOperations.Text;

            switch (option)
            {
                case "Get":
                    addRowToResultsTable(address, OID, option, "Get");
                    break;
                case "Get Next":
                    addRowToResultsTable(address, OID, option, "GetNext");
                    break;
            }
            // Operacja GET lub GET NEXT
            
        }

        public void addRowToResultsTable(String OID, String value, String type, String IP)
        {
            dataGridViewResultTable.Rows.Add(OID, value, type, IP);           
        }
    }
}
