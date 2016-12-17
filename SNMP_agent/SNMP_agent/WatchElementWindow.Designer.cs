namespace SNMP_agent
{
    partial class WatchElementWindow
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
            this.OID = new System.Windows.Forms.TextBox();
            this.SNMPOperation = new System.Windows.Forms.ComboBox();
            this.OID_label = new System.Windows.Forms.Label();
            this.SNMPOperation_label = new System.Windows.Forms.Label();
            this.OK_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OID
            // 
            this.OID.Location = new System.Drawing.Point(130, 12);
            this.OID.Name = "OID";
            this.OID.Size = new System.Drawing.Size(180, 20);
            this.OID.TabIndex = 0;
            // 
            // SNMPOperation
            // 
            this.SNMPOperation.FormattingEnabled = true;
            this.SNMPOperation.Items.AddRange(new object[] {
            "Get",
            "GetNext"});
            this.SNMPOperation.Location = new System.Drawing.Point(130, 51);
            this.SNMPOperation.Name = "SNMPOperation";
            this.SNMPOperation.Size = new System.Drawing.Size(180, 21);
            this.SNMPOperation.TabIndex = 2;
            // 
            // OID_label
            // 
            this.OID_label.AutoSize = true;
            this.OID_label.Location = new System.Drawing.Point(86, 15);
            this.OID_label.Name = "OID_label";
            this.OID_label.Size = new System.Drawing.Size(26, 13);
            this.OID_label.TabIndex = 5;
            this.OID_label.Text = "OID";
            // 
            // SNMPOperation_label
            // 
            this.SNMPOperation_label.AutoSize = true;
            this.SNMPOperation_label.Location = new System.Drawing.Point(25, 54);
            this.SNMPOperation_label.Name = "SNMPOperation_label";
            this.SNMPOperation_label.Size = new System.Drawing.Size(87, 13);
            this.SNMPOperation_label.TabIndex = 7;
            this.SNMPOperation_label.Text = "SNMP Operation";
            // 
            // OK_button
            // 
            this.OK_button.Location = new System.Drawing.Point(130, 108);
            this.OK_button.Name = "OK_button";
            this.OK_button.Size = new System.Drawing.Size(60, 23);
            this.OK_button.TabIndex = 9;
            this.OK_button.Text = "OK";
            this.OK_button.UseVisualStyleBackColor = true;
            this.OK_button.Click += new System.EventHandler(this.OK_button_Click);
            // 
            // WatchElementWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 154);
            this.Controls.Add(this.OK_button);
            this.Controls.Add(this.SNMPOperation_label);
            this.Controls.Add(this.OID_label);
            this.Controls.Add(this.SNMPOperation);
            this.Controls.Add(this.OID);
            this.Name = "WatchElementWindow";
            this.Text = "Add Watch";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OID;
        private System.Windows.Forms.ComboBox SNMPOperation;
        private System.Windows.Forms.Label OID_label;
        private System.Windows.Forms.Label SNMPOperation_label;
        private System.Windows.Forms.Button OK_button;
    }
}