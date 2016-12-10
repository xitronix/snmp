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

            imageList.Images.Add(Properties.Resources.Folder);
            imageList.Images.Add(Properties.Resources.key);
            imageList.Images.Add(Properties.Resources.entry);
            imageList.Images.Add(Properties.Resources.listek);
            imageList.Images.Add(Properties.Resources.paper);
            imageList.Images.Add(Properties.Resources.table);

            //textBoxtest.AppendText("count" + imageList.Images.Count);

            mibElementsDictionary = new Dictionary<string, string>();
            loadMibTreeElements();
            string[] dd = { "pp", "dd", "ll" };
            addNewTableView(dd);
            string[] ss = { "bbb", "aaa", "ll" , "lala"};
            addNewTableView(ss);
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
                    get();
                    break;
                case "Get Next":
                    addRowToResultsTable(address, OID, option, "GetNext");
                    getNext();
                  /*  string[] pp = new string[4];
                    pp[0] = address;
                    pp[1] = OID;
                    pp[2] = option;
                    pp[3] = "GetNext";
                    addNewRowToTableView(pp); */
                    break;
            }
            
          
            // Operacja GET lub GET NEXT
            
        }

        private void get()
        {
            // TODO Auto-generated method stub
            addRowToResultsTable("TEST1", "TEST2", "TEST3", "TEST4");
            // Tutaj napewno do wykrozystania zmienna conf w ktorej sa parametry polaczenia SNMP
        }

        private void getNext()
        {
            // TODO Auto-generated method stub

        }

        /* Dodaje wiersz w tablicy ResultsTable. Wywoływane po wciśnięciu przycisku GO */
        public void addRowToResultsTable(string OID, string value, string type, string IP)
        {
            dataGridViewResultTable.Rows.Add(OID, value, type, IP);           
        }

        /* Dodaje wiersz do TableView. Metoda wywoływana do wyświetlenia calej tabeli */
        public bool addNewRowToTableView(string[] cellNames)
        {
            if (cellNames.Length == dataGridViewResultTable.Columns.Count)
            {
                dataGridViewTableView.Rows.Add(cellNames);
                return true;
            }
            else
                return false;
        }

        /* Wywoływane gdy użytkownik chce wyświetlić tabelę. Tworzy tabelę o określonej liczbie kolumn*/
        public void addNewTableView(string[] columnNames)
        {
            for (int i = 0; i < dataGridViewTableView.Columns.Count; i++) 
            {
                dataGridViewTableView.Columns.Remove(dataGridViewTableView.Columns[0]);
            }

            foreach (string columnName in columnNames)
            {
                var column = new DataGridViewTextBoxColumn();
                column.HeaderText = columnName;
                
                dataGridViewTableView.Columns.Add(column);
            }
            
            dataGridViewTableView.Columns.Remove(dataGridViewTableView.Columns[0]);
        }

        /* Metoda wczytująca z pliku MIBTree*/
        private void loadMibTreeElements()
        {
            treeView.Nodes.Add("iso.org.dod.internet.mgmt.mib-2");

            var input_path = Properties.Resources.mibTreeElements;
            string[] lineSplit;
            List<TreeNode> treeNodeList = new List<TreeNode>();
            treeNodeList.Add(treeView.Nodes[0]);
            string value; // OID
            string key; // nazwa 

            string[] dd = input_path.Split('\n');
            string line;

            int length;

            for (int i = 0; i < dd.Length; i++) 
            {
                line = dd[i];
                lineSplit = line.Split(' ');
                value = "." + lineSplit[1];
                key = lineSplit[3];
                mibElementsDictionary.Add(key, value);

                length = value.Length / 2 - 6; 
                if (treeNodeList.Count > length)
                {
                    treeNodeList[length - 1].Nodes.Add(key);
                    treeNodeList[length] = treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1];
                    treeNodeList[length].ImageIndex = 1;
                }
                else
                {
                    treeNodeList[length - 1].Nodes.Add(key);
                    treeNodeList.Add(treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1]);
                }
                
                // Dodanie obrazków
                switch (lineSplit[0])
                {
                    case "F":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 0;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 0;
                        break;
                    case "L":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 3;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 3;
                        break;
                    case "P":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 4;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 4;
                        break;
                    case "E":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 2;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 2;
                        break;
                    case "T":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 5;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 5;
                        break;
                    case "K":
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].ImageIndex = 1;
                        treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1].SelectedImageIndex = 1;
                        break;
                }
            }           
        }

        /* Po kliknięciu na element MIBTree, odpowiednie OID pojawia się w textBoxOID*/
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
