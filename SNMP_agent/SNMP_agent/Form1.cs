using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SNMP_agent
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> mibElementsDictionary;

        public Form1()
        {
            InitializeComponent();

            comboBoxOperations.Items.Add("Get");
            comboBoxOperations.Items.Add("Get Next");
            textBoxAddress.Text = "localhost";

            mibElementsDictionary = new Dictionary<string, string>();
            loadMibTreeElements();
            
            
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            string address = textBoxAddress.Text;
            string OID = textBoxOID.Text;
            string option = comboBoxOperations.Text;

            
            
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

        private void loadMibTreeElements()
        {
            treeView.Nodes.Add("iso.org.dod.internet.mgmt.mib-2");

            // string input_path = "snmpElements.txt";
            var input_path = Properties.Resources.mibTreeElements;
            //string input_path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"snmpElements.txt");
            string[] lineSplit;
            List<TreeNode> treeNodeList = new List<TreeNode>();
            treeNodeList.Add(treeView.Nodes[0]);
            string value; // OIDC:\Users\Piotrek\Documents\Git\snmpAgent\SNMP_agent\SNMP_agent\cos.txt
            string key; // nazwa 


            string[] dd = input_path.Split('\n');
            string line;


            int length;

            for (int i = 0; i < dd.Length; i++) 
            {
                line = dd[i];
                lineSplit = line.Split(' ');
                value = "." + lineSplit[0];
                key = lineSplit[2];
                mibElementsDictionary.Add(key, value);

                length = value.Length / 2 - 6; // System = 1
                if (treeNodeList.Count > length)
                {
                    treeNodeList[length - 1].Nodes.Add(key);
                    treeNodeList[length] = treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1];
                }
                else
                {
                    treeNodeList[length - 1].Nodes.Add(key);
                    treeNodeList.Add(treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1]);
                }
            }
            

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string value;
            if (mibElementsDictionary.TryGetValue(treeView.SelectedNode.Text, out value))
                textBoxOID.Text = value;
               
        }


        /*
        private void loadMibTreeElements()
        {
            treeView.Nodes.Add("iso.org.dod.internet.mgmt.mib-2");

            string input_path = "snmpElements.txt";
            //var input_path = Properties.Resources.cos;
            //string input_path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"snmpElements.txt");
            string[] lineSplit;
            List<TreeNode> treeNodeList = new List<TreeNode>();
            treeNodeList.Add(treeView.Nodes[0]);
            string value; // OIDC:\Users\Piotrek\Documents\Git\snmpAgent\SNMP_agent\SNMP_agent\cos.txt
            string key; // nazwa 

            StreamReader sr;
            sr = new StreamReader(input_path);
            string line = sr.ReadLine();

            
            int length;

            while (line != null)
            {                              
                lineSplit = line.Split(' ');
                value = "." + lineSplit[0];
                key = lineSplit[2];        
                mibElementsDictionary.Add(key,value);

                length = value.Length / 2 - 6; // System = 1
                if (treeNodeList.Count > length)
                {
                    treeNodeList[length - 1].Nodes.Add(key);
                    treeNodeList[length] = treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1];
                }
                else
                {
                    treeNodeList[length - 1].Nodes.Add(key);
                    treeNodeList.Add(treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1]);
                }

                line = sr.ReadLine();
             
            }
            sr.Close();
                     
        } 
        */
    }
}
