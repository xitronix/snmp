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
        Dictionary<string, string> mibElementsDictionaryOid;
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

            mibElementsDictionary = new Dictionary<string, string>();
            mibElementsDictionaryOid = new Dictionary<string, string>();
            loadMibTreeElements();

            stopReceivingTrapToolStripMenuItem.Enabled = false;
            StopWatchingMenuItem1.Enabled = false;
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
        }

        private void getNext(string OID) {
            string[] valuesTable = snmpAgent.getNext(OID);
            if (valuesTable != null)
                addRowToResultsTable(valuesTable[0], valuesTable[2], valuesTable[1]);
        }

        private void tableView(string OID) {
            try {
                var listOfRows = new List<List<string>>();
                //var listOfRows1 = snmpAgent.getTable(OID);
                listOfRows = ParseToList(snmpAgent.GetTableList(OID));
                List<string> columns = new List<string>();
                for (int i = 0; i < listOfRows[0].Count; i++) {
                    string oid = OID + ".1." + (i + 1);
                    string name = null;
                    try {
                        name = mibElementsDictionaryOid[oid];
                    }
                    catch (KeyNotFoundException e) {
                    }
                    if (name != null)
                        columns.Add(name);
                    else columns.Add(oid);
                }
                addNewTableView(columns);
                foreach (List<string> row in listOfRows) {
                    addNewRowToTableView(row);
                }
            }
            catch {
                Console.WriteLine("Not inspected argument of method");
            }
        }

        public List<List<string>> ParseToList(List<List<string>> inputList) {
            var outputList = new List<List<string>>();
            var row = new List<string>();

            for (int i = 0; i < inputList[0].Count; i++) {
                row = new List<string>();
                for (int j = 0; j < inputList.Count; j++) {
                    row.Add(inputList[j][i]);
                }
                outputList.Add(row);
            }

            return outputList;
        }

        /* Dodaje wiersz w tablicy ResultsTable. Wywoływane po wciśnięciu przycisku GO */

        public void addRowToResultsTable(string OID, string value, string type) {
            dataGridViewResultTable.Rows.Add(OID, value, type);
            textBoxOID.Text = OID;
            dataGridViewResultTable.SelectedRows[0].Selected = false;
            dataGridViewResultTable.Rows[dataGridViewResultTable.Rows.Count - 1].Selected = true;
        }

        public void addRowToWatchedElementsTable(string OID, string value, string type) {
            MethodInvoker mi = delegate { dataGridViewWatchedElements.Rows.Add(OID, value, type); };
            if (InvokeRequired)
                this.Invoke(mi);
        }

        public void addRowToTrapTable(string source, string name, string value, DateTime time, int generic) {
            MethodInvoker mi = delegate {
                string genericName = "";
                switch (generic) {
                    case 0:
                        genericName = "ColdStart";
                        break;
                    case 1:
                        genericName = "WarmStart";
                        break;
                    case 2:
                        genericName = "LinkDown";
                        break;
                    case 3:
                        genericName = "LinkUp";
                        break;
                    case 4:
                        genericName = "AuthenticationFailure";
                        break;
                    case 5:
                        genericName = "EGPNeithbourLoss";
                        break;
                }
                dataGridViewTrapTable.Rows.Add(source, name, value, time, genericName);
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
            var array = new string[list.Count];
            for (int i = 0; i < array.Length; i++) {
                array[i] = list[i];
            }
            return array;
        }

        /* Wywoływane gdy użytkownik chce wyświetlić tabelę. Tworzy tabelę o określonej liczbie kolumn*/

        public void addNewTableView(List<string> columnNames) {
            dataGridViewTableView.Rows.Clear();
            dataGridViewTableView.Columns.Clear();

            foreach (string columnName in columnNames) {
                var column = new DataGridViewTextBoxColumn();
                column.HeaderText = columnName;

                dataGridViewTableView.Columns.Add(column);
            }
            tabControlResult.SelectedIndex = 1;
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


                length = value.Split('.').Length - 7; //value.Length/2 - 6;
                if (length == 2 && (lineSplit[0] == "L" || lineSplit[0] == "P"))
                    value = value + ".0";

                mibElementsDictionary.Add(key, value);
                mibElementsDictionaryOid.Add(value, key);

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

        private void watchToolStripMenuItem_Click(object sender, EventArgs e) {
            startWatcingToolStripMenuItem.Enabled = false;
            StopWatchingMenuItem1.Enabled = true;
            tabControlResult.SelectedIndex = 2;
            var form = new WatchElementWindow(this);
            form.Visible = true;
        }

        public void watch(string OID_number, string SNMP_operation) {
            if (!snmpAgent.activeWatching)
                snmpAgent.StartWatching(OID_number, SNMP_operation);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e) {
            snmpAgent.stopWatching();
            startWatcingToolStripMenuItem.Enabled = true;
            StopWatchingMenuItem1.Enabled = false;
        }

        void f_FormClosed(object sender, FormClosedEventArgs e) {
            snmpAgent.stopWatching();
            snmpAgent.stopTrap();
        }

        private void sendTrapToolStripMenuItem_Click(object sender, EventArgs e) {
            var trapSender = new TrapSender();
            trapSender.Visible = true;
        }

        private void startReceivingTrapToolStripMenuItem_Click(object sender, EventArgs e) {
            snmpAgent.startTrap();
            tabControlResult.SelectedIndex = 3;
            startReceivingTrapToolStripMenuItem.Enabled = false;
            stopReceivingTrapToolStripMenuItem.Enabled = true;
        }

        private void stopReceivingTrapToolStripMenuItem_Click(object sender, EventArgs e) {
            snmpAgent.stopTrap();
            startReceivingTrapToolStripMenuItem.Enabled = true;
            stopReceivingTrapToolStripMenuItem.Enabled = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e) {
        }
    }
}