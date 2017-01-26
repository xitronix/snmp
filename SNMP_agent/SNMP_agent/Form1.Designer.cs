namespace ServerSNMP
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startWatcingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StopWatchingMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendTrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startReceivingTrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopReceivingTrapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelOID = new System.Windows.Forms.Label();
            this.textBoxOID = new System.Windows.Forms.TextBox();
            this.labelOperations = new System.Windows.Forms.Label();
            this.comboBoxOperations = new System.Windows.Forms.ComboBox();
            this.buttonGo = new System.Windows.Forms.Button();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.treeView = new System.Windows.Forms.TreeView();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.tabControlResult = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewResultTable = new System.Windows.Forms.DataGridView();
            this.OIDColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValueColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewTableView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewWatchedElements = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewTrapTable = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Generic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControlResult.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWatchedElements)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrapTable)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            resources.ApplyResources(this.tableLayoutPanel1, "tableLayoutPanel1");
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem,
            this.menu2ToolStripMenuItem});
            resources.ApplyResources(this.menuStrip1, "menuStrip1");
            this.menuStrip1.Name = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startWatcingToolStripMenuItem,
            this.StopWatchingMenuItem1});
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            resources.ApplyResources(this.menu1ToolStripMenuItem, "menu1ToolStripMenuItem");
            // 
            // startWatcingToolStripMenuItem
            // 
            this.startWatcingToolStripMenuItem.Name = "startWatcingToolStripMenuItem";
            resources.ApplyResources(this.startWatcingToolStripMenuItem, "startWatcingToolStripMenuItem");
            this.startWatcingToolStripMenuItem.Click += new System.EventHandler(this.watchToolStripMenuItem_Click);
            // 
            // StopWatchingMenuItem1
            // 
            this.StopWatchingMenuItem1.Name = "StopWatchingMenuItem1";
            resources.ApplyResources(this.StopWatchingMenuItem1, "StopWatchingMenuItem1");
            this.StopWatchingMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menu2ToolStripMenuItem
            // 
            this.menu2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sendTrapToolStripMenuItem,
            this.startReceivingTrapToolStripMenuItem,
            this.stopReceivingTrapToolStripMenuItem});
            this.menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            resources.ApplyResources(this.menu2ToolStripMenuItem, "menu2ToolStripMenuItem");
            // 
            // sendTrapToolStripMenuItem
            // 
            this.sendTrapToolStripMenuItem.Name = "sendTrapToolStripMenuItem";
            resources.ApplyResources(this.sendTrapToolStripMenuItem, "sendTrapToolStripMenuItem");
            this.sendTrapToolStripMenuItem.Click += new System.EventHandler(this.sendTrapToolStripMenuItem_Click);
            // 
            // startReceivingTrapToolStripMenuItem
            // 
            this.startReceivingTrapToolStripMenuItem.Name = "startReceivingTrapToolStripMenuItem";
            resources.ApplyResources(this.startReceivingTrapToolStripMenuItem, "startReceivingTrapToolStripMenuItem");
            this.startReceivingTrapToolStripMenuItem.Click += new System.EventHandler(this.startReceivingTrapToolStripMenuItem_Click);
            // 
            // stopReceivingTrapToolStripMenuItem
            // 
            this.stopReceivingTrapToolStripMenuItem.Name = "stopReceivingTrapToolStripMenuItem";
            resources.ApplyResources(this.stopReceivingTrapToolStripMenuItem, "stopReceivingTrapToolStripMenuItem");
            this.stopReceivingTrapToolStripMenuItem.Click += new System.EventHandler(this.stopReceivingTrapToolStripMenuItem_Click);
            // 
            // tableLayoutPanel2
            // 
            resources.ApplyResources(this.tableLayoutPanel2, "tableLayoutPanel2");
            this.tableLayoutPanel2.Controls.Add(this.labelOID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxOID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelOperations, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxOperations, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonGo, 4, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            // 
            // labelOID
            // 
            resources.ApplyResources(this.labelOID, "labelOID");
            this.labelOID.Name = "labelOID";
            // 
            // textBoxOID
            // 
            resources.ApplyResources(this.textBoxOID, "textBoxOID");
            this.textBoxOID.Name = "textBoxOID";
            // 
            // labelOperations
            // 
            resources.ApplyResources(this.labelOperations, "labelOperations");
            this.labelOperations.Name = "labelOperations";
            // 
            // comboBoxOperations
            // 
            resources.ApplyResources(this.comboBoxOperations, "comboBoxOperations");
            this.comboBoxOperations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperations.FormattingEnabled = true;
            this.comboBoxOperations.Name = "comboBoxOperations";
            // 
            // buttonGo
            // 
            resources.ApplyResources(this.buttonGo, "buttonGo");
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // tableLayoutPanel3
            // 
            resources.ApplyResources(this.tableLayoutPanel3, "tableLayoutPanel3");
            this.tableLayoutPanel3.Controls.Add(this.treeView, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tabControlResult, 1, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            // 
            // treeView
            // 
            resources.ApplyResources(this.treeView, "treeView");
            this.treeView.ImageList = this.imageList;
            this.treeView.Name = "treeView";
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            resources.ApplyResources(this.imageList, "imageList");
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabControlResult
            // 
            this.tabControlResult.Controls.Add(this.tabPage1);
            this.tabControlResult.Controls.Add(this.tabPage2);
            this.tabControlResult.Controls.Add(this.tabPage3);
            this.tabControlResult.Controls.Add(this.tabPage4);
            resources.ApplyResources(this.tabControlResult, "tabControlResult");
            this.tabControlResult.Name = "tabControlResult";
            this.tabControlResult.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewResultTable);
            resources.ApplyResources(this.tabPage1, "tabPage1");
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResultTable
            // 
            this.dataGridViewResultTable.AllowUserToAddRows = false;
            this.dataGridViewResultTable.AllowUserToDeleteRows = false;
            this.dataGridViewResultTable.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridViewResultTable, "dataGridViewResultTable");
            this.dataGridViewResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OIDColumn,
            this.ValueColumn,
            this.TypeColumn});
            this.dataGridViewResultTable.Name = "dataGridViewResultTable";
            this.dataGridViewResultTable.RowHeadersVisible = false;
            this.dataGridViewResultTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // OIDColumn
            // 
            resources.ApplyResources(this.OIDColumn, "OIDColumn");
            this.OIDColumn.Name = "OIDColumn";
            this.OIDColumn.ReadOnly = true;
            // 
            // ValueColumn
            // 
            resources.ApplyResources(this.ValueColumn, "ValueColumn");
            this.ValueColumn.Name = "ValueColumn";
            this.ValueColumn.ReadOnly = true;
            // 
            // TypeColumn
            // 
            resources.ApplyResources(this.TypeColumn, "TypeColumn");
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridViewTableView);
            resources.ApplyResources(this.tabPage2, "tabPage2");
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTableView
            // 
            this.dataGridViewTableView.AllowUserToAddRows = false;
            this.dataGridViewTableView.AllowUserToDeleteRows = false;
            this.dataGridViewTableView.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridViewTableView, "dataGridViewTableView");
            this.dataGridViewTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTableView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn8});
            this.dataGridViewTableView.Name = "dataGridViewTableView";
            this.dataGridViewTableView.RowHeadersVisible = false;
            this.dataGridViewTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dataGridViewTextBoxColumn4
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn4, "dataGridViewTextBoxColumn4");
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn5, "dataGridViewTextBoxColumn5");
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn8, "dataGridViewTextBoxColumn8");
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewWatchedElements);
            resources.ApplyResources(this.tabPage3, "tabPage3");
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWatchedElements
            // 
            this.dataGridViewWatchedElements.AllowUserToAddRows = false;
            this.dataGridViewWatchedElements.AllowUserToDeleteRows = false;
            this.dataGridViewWatchedElements.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridViewWatchedElements, "dataGridViewWatchedElements");
            this.dataGridViewWatchedElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWatchedElements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewWatchedElements.Name = "dataGridViewWatchedElements";
            this.dataGridViewWatchedElements.RowHeadersVisible = false;
            this.dataGridViewWatchedElements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dataGridViewTextBoxColumn1
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn1, "dataGridViewTextBoxColumn1");
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn2, "dataGridViewTextBoxColumn2");
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn3, "dataGridViewTextBoxColumn3");
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewTrapTable);
            resources.ApplyResources(this.tabPage4, "tabPage4");
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTrapTable
            // 
            this.dataGridViewTrapTable.AllowUserToAddRows = false;
            this.dataGridViewTrapTable.AllowUserToDeleteRows = false;
            this.dataGridViewTrapTable.AllowUserToResizeRows = false;
            resources.ApplyResources(this.dataGridViewTrapTable, "dataGridViewTrapTable");
            this.dataGridViewTrapTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTrapTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn6,
            this.ColumnName,
            this.Value,
            this.dataGridViewTextBoxColumn7,
            this.Generic});
            this.dataGridViewTrapTable.Name = "dataGridViewTrapTable";
            this.dataGridViewTrapTable.RowHeadersVisible = false;
            this.dataGridViewTrapTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // dataGridViewTextBoxColumn6
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn6, "dataGridViewTextBoxColumn6");
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // ColumnName
            // 
            resources.ApplyResources(this.ColumnName, "ColumnName");
            this.ColumnName.Name = "ColumnName";
            // 
            // Value
            // 
            resources.ApplyResources(this.Value, "Value");
            this.Value.Name = "Value";
            // 
            // dataGridViewTextBoxColumn7
            // 
            resources.ApplyResources(this.dataGridViewTextBoxColumn7, "dataGridViewTextBoxColumn7");
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // Generic
            // 
            resources.ApplyResources(this.Generic, "Generic");
            this.Generic.Name = "Generic";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabControlResult.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWatchedElements)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTrapTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu2ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelOID;
        private System.Windows.Forms.TextBox textBoxOID;
        private System.Windows.Forms.Label labelOperations;
        private System.Windows.Forms.ComboBox comboBoxOperations;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.ToolStripMenuItem startWatcingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StopWatchingMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem sendTrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startReceivingTrapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopReceivingTrapToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TabControl tabControlResult;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridViewResultTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewWatchedElements;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewTrapTable;
        private System.Windows.Forms.DataGridView dataGridViewTableView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Value;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Generic;
    }
}

