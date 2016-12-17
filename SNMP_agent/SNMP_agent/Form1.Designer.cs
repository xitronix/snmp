namespace SNMP_agent
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.watchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menu2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelAddress = new System.Windows.Forms.Label();
            this.textBoxAddress = new System.Windows.Forms.TextBox();
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
            this.IPPortColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.dataGridViewTableView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridViewWatchedElements = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxtest = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabControlResult.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewResultTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWatchedElements)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.textBoxtest, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 42.62295F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 57.37705F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 353F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(867, 429);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem,
            this.menu2ToolStripMenuItem,
            this.menu3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(867, 23);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.watchToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.menu1ToolStripMenuItem.Text = "Menu1";
            // 
            // watchToolStripMenuItem
            // 
            this.watchToolStripMenuItem.Name = "watchToolStripMenuItem";
            this.watchToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.watchToolStripMenuItem.Text = "Watch";
            this.watchToolStripMenuItem.Click += new System.EventHandler(this.watchToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem1.Text = "StopWatching";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // menu2ToolStripMenuItem
            // 
            this.menu2ToolStripMenuItem.Name = "menu2ToolStripMenuItem";
            this.menu2ToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.menu2ToolStripMenuItem.Text = "Menu2";
            // 
            // menu3ToolStripMenuItem
            // 
            this.menu3ToolStripMenuItem.Name = "menu3ToolStripMenuItem";
            this.menu3ToolStripMenuItem.Size = new System.Drawing.Size(56, 19);
            this.menu3ToolStripMenuItem.Text = "Menu3";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.68085F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75.31915F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 299F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 69F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tableLayoutPanel2.Controls.Add(this.labelAddress, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxAddress, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelOID, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxOID, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelOperations, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.comboBoxOperations, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonGo, 6, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 26);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(861, 26);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelAddress
            // 
            this.labelAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(4, 6);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(48, 13);
            this.labelAddress.TabIndex = 0;
            this.labelAddress.Text = "Address:";
            // 
            // textBoxAddress
            // 
            this.textBoxAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxAddress.Location = new System.Drawing.Point(60, 3);
            this.textBoxAddress.Name = "textBoxAddress";
            this.textBoxAddress.Size = new System.Drawing.Size(170, 20);
            this.textBoxAddress.TabIndex = 1;
            // 
            // labelOID
            // 
            this.labelOID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOID.AutoSize = true;
            this.labelOID.Location = new System.Drawing.Point(238, 6);
            this.labelOID.Name = "labelOID";
            this.labelOID.Size = new System.Drawing.Size(29, 13);
            this.labelOID.TabIndex = 2;
            this.labelOID.Text = "OID:";
            // 
            // textBoxOID
            // 
            this.textBoxOID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxOID.Location = new System.Drawing.Point(276, 3);
            this.textBoxOID.Name = "textBoxOID";
            this.textBoxOID.Size = new System.Drawing.Size(293, 20);
            this.textBoxOID.TabIndex = 3;
            // 
            // labelOperations
            // 
            this.labelOperations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelOperations.AutoSize = true;
            this.labelOperations.Location = new System.Drawing.Point(576, 6);
            this.labelOperations.Name = "labelOperations";
            this.labelOperations.Size = new System.Drawing.Size(61, 13);
            this.labelOperations.TabIndex = 4;
            this.labelOperations.Text = "Operations:";
            // 
            // comboBoxOperations
            // 
            this.comboBoxOperations.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.comboBoxOperations.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperations.FormattingEnabled = true;
            this.comboBoxOperations.Location = new System.Drawing.Point(646, 3);
            this.comboBoxOperations.Name = "comboBoxOperations";
            this.comboBoxOperations.Size = new System.Drawing.Size(121, 21);
            this.comboBoxOperations.TabIndex = 5;
            // 
            // buttonGo
            // 
            this.buttonGo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonGo.Location = new System.Drawing.Point(781, 3);
            this.buttonGo.Name = "buttonGo";
            this.buttonGo.Size = new System.Drawing.Size(71, 20);
            this.buttonGo.TabIndex = 6;
            this.buttonGo.Text = "Go";
            this.buttonGo.UseVisualStyleBackColor = true;
            this.buttonGo.Click += new System.EventHandler(this.buttonGo_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.91986F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.08014F));
            this.tableLayoutPanel3.Controls.Add(this.treeView, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.tabControlResult, 1, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 58);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(861, 347);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // treeView
            // 
            this.treeView.ImageIndex = 0;
            this.treeView.ImageList = this.imageList;
            this.treeView.Location = new System.Drawing.Point(3, 3);
            this.treeView.Name = "treeView";
            this.treeView.SelectedImageIndex = 0;
            this.treeView.Size = new System.Drawing.Size(243, 341);
            this.treeView.TabIndex = 0;
            this.treeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView_AfterSelect);
            // 
            // imageList
            // 
            this.imageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tabControlResult
            // 
            this.tabControlResult.Controls.Add(this.tabPage1);
            this.tabControlResult.Controls.Add(this.tabPage2);
            this.tabControlResult.Controls.Add(this.tabPage3);
            this.tabControlResult.Location = new System.Drawing.Point(252, 3);
            this.tabControlResult.Name = "tabControlResult";
            this.tabControlResult.SelectedIndex = 0;
            this.tabControlResult.Size = new System.Drawing.Size(606, 341);
            this.tabControlResult.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewResultTable);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(598, 315);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Result Table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewResultTable
            // 
            this.dataGridViewResultTable.AllowUserToAddRows = false;
            this.dataGridViewResultTable.AllowUserToDeleteRows = false;
            this.dataGridViewResultTable.AllowUserToResizeRows = false;
            this.dataGridViewResultTable.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewResultTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewResultTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.OIDColumn,
            this.ValueColumn,
            this.TypeColumn,
            this.IPPortColumn});
            this.dataGridViewResultTable.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewResultTable.Name = "dataGridViewResultTable";
            this.dataGridViewResultTable.RowHeadersVisible = false;
            this.dataGridViewResultTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewResultTable.Size = new System.Drawing.Size(598, 315);
            this.dataGridViewResultTable.TabIndex = 0;
            // 
            // OIDColumn
            // 
            this.OIDColumn.HeaderText = "Name/OID";
            this.OIDColumn.Name = "OIDColumn";
            this.OIDColumn.ReadOnly = true;
            this.OIDColumn.Width = 200;
            // 
            // ValueColumn
            // 
            this.ValueColumn.HeaderText = "Value";
            this.ValueColumn.Name = "ValueColumn";
            this.ValueColumn.ReadOnly = true;
            this.ValueColumn.Width = 224;
            // 
            // TypeColumn
            // 
            this.TypeColumn.HeaderText = "Type";
            this.TypeColumn.Name = "TypeColumn";
            this.TypeColumn.ReadOnly = true;
            // 
            // IPPortColumn
            // 
            this.IPPortColumn.HeaderText = "IP:Port";
            this.IPPortColumn.Name = "IPPortColumn";
            this.IPPortColumn.ReadOnly = true;
            this.IPPortColumn.Width = 70;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(598, 315);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Table View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Controls.Add(this.buttonRefresh, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.dataGridViewTableView, 0, 1);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 6);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 280F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(592, 309);
            this.tableLayoutPanel4.TabIndex = 0;
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.Location = new System.Drawing.Point(3, 3);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(75, 23);
            this.buttonRefresh.TabIndex = 0;
            this.buttonRefresh.Text = "Refresh";
            this.buttonRefresh.UseVisualStyleBackColor = true;
            // 
            // dataGridViewTableView
            // 
            this.dataGridViewTableView.AllowUserToAddRows = false;
            this.dataGridViewTableView.AllowUserToDeleteRows = false;
            this.dataGridViewTableView.AllowUserToResizeColumns = false;
            this.dataGridViewTableView.AllowUserToResizeRows = false;
            this.dataGridViewTableView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTableView.Location = new System.Drawing.Point(3, 32);
            this.dataGridViewTableView.Name = "dataGridViewTableView";
            this.dataGridViewTableView.RowHeadersVisible = false;
            this.dataGridViewTableView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewTableView.Size = new System.Drawing.Size(586, 274);
            this.dataGridViewTableView.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridViewWatchedElements);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(598, 315);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridViewWatchedElements
            // 
            this.dataGridViewWatchedElements.AllowUserToAddRows = false;
            this.dataGridViewWatchedElements.AllowUserToDeleteRows = false;
            this.dataGridViewWatchedElements.AllowUserToResizeRows = false;
            this.dataGridViewWatchedElements.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridViewWatchedElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWatchedElements.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.dataGridViewWatchedElements.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewWatchedElements.Name = "dataGridViewWatchedElements";
            this.dataGridViewWatchedElements.RowHeadersVisible = false;
            this.dataGridViewWatchedElements.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewWatchedElements.Size = new System.Drawing.Size(598, 315);
            this.dataGridViewWatchedElements.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Name/OID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Value";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 224;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Type";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "IP:Port";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 70;
            // 
            // textBoxtest
            // 
            this.textBoxtest.Location = new System.Drawing.Point(3, 411);
            this.textBoxtest.Name = "textBoxtest";
            this.textBoxtest.Size = new System.Drawing.Size(861, 20);
            this.textBoxtest.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 434);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "SNMP";
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
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTableView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWatchedElements)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu3ToolStripMenuItem;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox textBoxAddress;
        private System.Windows.Forms.Label labelOID;
        private System.Windows.Forms.TextBox textBoxOID;
        private System.Windows.Forms.Label labelOperations;
        private System.Windows.Forms.ComboBox comboBoxOperations;
        private System.Windows.Forms.Button buttonGo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.TabControl tabControlResult;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewResultTable;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.DataGridView dataGridViewTableView;
        private System.Windows.Forms.DataGridViewTextBoxColumn OIDColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ValueColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPPortColumn;
        private System.Windows.Forms.ImageList imageList;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridViewWatchedElements;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.ToolStripMenuItem watchToolStripMenuItem;
        public System.Windows.Forms.TextBox textBoxtest;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}

