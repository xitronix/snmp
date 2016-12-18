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

namespace SNMP_agent {
    public partial class Form1 : Form {
        Dictionary<string, string> mibElementsDictionary;
        //private List<string[]> valuesTable;
        private AgentSNMP snmpAgent;

        public Form1() {
            InitializeComponent();
            FormClosed += new FormClosedEventHandler(f_FormClosed);
            snmpAgent = new AgentSNMP(this);

            comboBoxOperations.Items.Add("Get");
            comboBoxOperations.Items.Add("Get Next");
            comboBoxOperations.Items.Add("Table View");
          

            imageList.Images.Add(Properties.Resources.Folder);
            imageList.Images.Add(Properties.Resources.key);
            imageList.Images.Add(Properties.Resources.entry);
            imageList.Images.Add(Properties.Resources.listek);
            imageList.Images.Add(Properties.Resources.paper);
            imageList.Images.Add(Properties.Resources.table);

            //textBoxtest.AppendText("count" + imageList.Images.Count);

            mibElementsDictionary = new Dictionary<string, string>();
            loadMibTreeElements();

       /*     string[] dd = {"pp", "dd", "ll"};
            addNewTableView(dd);
            string[] ss = {"bbb", "aaa", "ll", "lala"};
            addNewTableView(ss); */
        }

        private void buttonGo_Click(object sender, EventArgs e) {
           
            string OID = textBoxOID.Text;
            string option = comboBoxOperations.Text;

            switch (option) {
                case "Get":
                    get(OID);
                    break;
                case "Get Next":                 
                    getNext(OID);                   
                    break;
                case "Table View":
                    tableView(OID);
                    break;
            }

        }


        private void get(string OID) {
            
            string[] valuesTable = snmpAgent.get(OID);
            if (valuesTable != null)
                addRowToResultsTable(valuesTable[0], valuesTable[2], valuesTable[1]);
            // Jesli null to okienko wyswietlic
        }


        private void getNext(string OID) {           
            string[] valuesTable = snmpAgent.getNext(OID);
            if (valuesTable != null)
                addRowToResultsTable(valuesTable[0], valuesTable[2], valuesTable[1]);
        }

        private void tableView(string OID) {
            var listOfRows =new List<List<string>>();
            listOfRows =snmpAgent.getTable(OID);
            List<string> columns = listOfRows[0];
            for (int i=0; i < columns.Count; i++) {
                columns[i] = (i+1).ToString();
            }
            addNewTableView(columns);
            foreach (List<string> row in listOfRows) {
                addNewRowToTableView(row);
            }

        }


        /* Dodaje wiersz w tablicy ResultsTable. Wywoływane po wciśnięciu przycisku GO */
        public void addRowToResultsTable(string OID, string value, string type) {
            dataGridViewResultTable.Rows.Add(OID, value, type);
            textBoxOID.Text = OID;
            dataGridViewResultTable.SelectedRows[0].Selected = false;
            dataGridViewResultTable.Rows[dataGridViewResultTable.Rows.Count - 1].Selected = true;

        }

        public void addRowToWatchedElementsTable(string OID, string value, string type)
        {
            MethodInvoker mi = delegate
            {
                dataGridViewWatchedElements.Rows.Add(OID, value, type);
            };
            if (InvokeRequired)
                this.Invoke(mi);
        }

        public void addRowToTrapTable(string description, string source, string time)
        {
            MethodInvoker mi = delegate
            {
                dataGridViewTrapTable.Rows.Add(description, source, time);
            };
            if (InvokeRequired)
                this.Invoke(mi);       
        }


        /* Dodaje wiersz do TableView. Metoda wywoływana do wyświetlenia calej tabeli */
        public bool addNewRowToTableView(List<string> cellNames) {
            if (cellNames.Count == dataGridViewTableView.ColumnCount) {
                dataGridViewTableView.Rows.Add(listToArray(cellNames));
                return true;
            }
            else
                return false;
        }

        private string[] listToArray(List<string> list) {
            var array= new string[list.Count];
            for (int i = 0; i < array.Length; i++) {
                array[i] = list[i];
            }
            return array;
        }

        /* Wywoływane gdy użytkownik chce wyświetlić tabelę. Tworzy tabelę o określonej liczbie kolumn*/
        public void addNewTableView(List<string> columnNames) {
            for (int i = 0; i < dataGridViewTableView.Columns.Count; i++) {
                dataGridViewTableView.Columns.Remove(dataGridViewTableView.Columns[0]);
            }

            foreach (string columnName in columnNames) {
                var column = new DataGridViewTextBoxColumn();
                column.HeaderText = columnName;

                dataGridViewTableView.Columns.Add(column);
            }

            //dataGridViewTableView.Columns.Remove(dataGridViewTableView.Columns[0]);
        }

        /* Metoda wczytująca z pliku MIBTree*/
        private void loadMibTreeElements() {
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

            for (int i = 0; i < dd.Length; i++) {
                line = dd[i];
                lineSplit = line.Split(' ');
                value = "." + lineSplit[1];
                key = lineSplit[3];
                

                length = value.Length/2 - 6;
                if (length == 2 && (lineSplit[0] == "L" || lineSplit[0] == "P"))
                    value = value + ".0";

                mibElementsDictionary.Add(key, value);

                if (treeNodeList.Count > length) {
                    treeNodeList[length - 1].Nodes.Add(key);
                    treeNodeList[length] = treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1];
                    treeNodeList[length].ImageIndex = 1;
                }
                else {
                    treeNodeList[length - 1].Nodes.Add(key);
                    treeNodeList.Add(treeNodeList[length - 1].Nodes[treeNodeList[length - 1].Nodes.Count - 1]);
                }

                // Dodanie obrazków
                switch (lineSplit[0]) {
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
        private void treeView_AfterSelect(object sender, TreeViewEventArgs e) {
            string value;
            if (mibElementsDictionary.TryGetValue(treeView.SelectedNode.Text, out value))
                textBoxOID.Text = value;
        }

        private void watchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form  = new WatchElementWindow(this);
            form.Visible = true;                     
        }

        public void watch(string OID_number, string SNMP_operation)
        {
            if (!snmpAgent.active)               
                snmpAgent.StartWatching(OID_number, SNMP_operation);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            snmpAgent.stopWatching();
        }

        private void trapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            snmpAgent.ReceiveTrap();
        }
        void f_FormClosed(object sender, FormClosedEventArgs e)
        {
            snmpAgent.stopWatching();
        }

    }
}