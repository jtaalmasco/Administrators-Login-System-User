namespace Operators
{
    partial class TabMain
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabOperator = new System.Windows.Forms.TabPage();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ClientsGrid = new System.Windows.Forms.DataGridView();
            this.DomainGroupCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.DropDownDomainIDs = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.OperatorNameLabel = new System.Windows.Forms.Label();
            this.tabLogs = new System.Windows.Forms.TabPage();
            this.LogsGrid = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabOperator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).BeginInit();
            this.tabLogs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabOperator);
            this.tabControl1.Controls.Add(this.tabLogs);
            this.tabControl1.Location = new System.Drawing.Point(17, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 437);
            this.tabControl1.TabIndex = 0;
            // 
            // tabOperator
            // 
            this.tabOperator.Controls.Add(this.DeleteButton);
            this.tabOperator.Controls.Add(this.EditButton);
            this.tabOperator.Controls.Add(this.AddButton);
            this.tabOperator.Controls.Add(this.ClientsGrid);
            this.tabOperator.Controls.Add(this.DomainGroupCheckedListBox);
            this.tabOperator.Controls.Add(this.DropDownDomainIDs);
            this.tabOperator.Controls.Add(this.label1);
            this.tabOperator.Controls.Add(this.OperatorNameLabel);
            this.tabOperator.Location = new System.Drawing.Point(4, 22);
            this.tabOperator.Name = "tabOperator";
            this.tabOperator.Padding = new System.Windows.Forms.Padding(3);
            this.tabOperator.Size = new System.Drawing.Size(781, 411);
            this.tabOperator.TabIndex = 0;
            this.tabOperator.Text = "Operator";
            this.tabOperator.UseVisualStyleBackColor = true;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(505, 96);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(88, 23);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "Delete Domain";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(396, 96);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(94, 23);
            this.EditButton.TabIndex = 5;
            this.EditButton.Text = "Edit Domain";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(298, 96);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(83, 23);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Add Domain";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ClientsGrid
            // 
            this.ClientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGrid.Location = new System.Drawing.Point(19, 125);
            this.ClientsGrid.Name = "ClientsGrid";
            this.ClientsGrid.Size = new System.Drawing.Size(744, 263);
            this.ClientsGrid.TabIndex = 3;
            // 
            // DomainGroupCheckedListBox
            // 
            this.DomainGroupCheckedListBox.FormattingEnabled = true;
            this.DomainGroupCheckedListBox.Location = new System.Drawing.Point(298, 22);
            this.DomainGroupCheckedListBox.Name = "DomainGroupCheckedListBox";
            this.DomainGroupCheckedListBox.Size = new System.Drawing.Size(314, 64);
            this.DomainGroupCheckedListBox.TabIndex = 1;
            this.DomainGroupCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.DomainGroupCheckedListBox_SelectedIndexChanged);
            // 
            // DropDownDomainIDs
            // 
            this.DropDownDomainIDs.FormattingEnabled = true;
            this.DropDownDomainIDs.Location = new System.Drawing.Point(170, 22);
            this.DropDownDomainIDs.Name = "DropDownDomainIDs";
            this.DropDownDomainIDs.Size = new System.Drawing.Size(68, 21);
            this.DropDownDomainIDs.TabIndex = 2;
            this.DropDownDomainIDs.SelectedIndexChanged += new System.EventHandler(this.DropDownDomainIDs_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Groups";
            // 
            // OperatorNameLabel
            // 
            this.OperatorNameLabel.AutoSize = true;
            this.OperatorNameLabel.Location = new System.Drawing.Point(16, 25);
            this.OperatorNameLabel.Name = "OperatorNameLabel";
            this.OperatorNameLabel.Size = new System.Drawing.Size(35, 13);
            this.OperatorNameLabel.TabIndex = 0;
            this.OperatorNameLabel.Text = "label1";
            // 
            // tabLogs
            // 
            this.tabLogs.Controls.Add(this.LogsGrid);
            this.tabLogs.Location = new System.Drawing.Point(4, 22);
            this.tabLogs.Name = "tabLogs";
            this.tabLogs.Padding = new System.Windows.Forms.Padding(3);
            this.tabLogs.Size = new System.Drawing.Size(781, 411);
            this.tabLogs.TabIndex = 1;
            this.tabLogs.Text = "Logs";
            this.tabLogs.UseVisualStyleBackColor = true;
            // 
            // LogsGrid
            // 
            this.LogsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LogsGrid.Location = new System.Drawing.Point(6, 6);
            this.LogsGrid.Name = "LogsGrid";
            this.LogsGrid.Size = new System.Drawing.Size(769, 399);
            this.LogsGrid.TabIndex = 0;
            // 
            // TabMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 504);
            this.Controls.Add(this.tabControl1);
            this.Name = "TabMain";
            this.Text = "TabMain";
            this.Load += new System.EventHandler(this.TabMain_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabOperator.ResumeLayout(false);
            this.tabOperator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).EndInit();
            this.tabLogs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabOperator;
        private System.Windows.Forms.TabPage tabLogs;
        private System.Windows.Forms.Label OperatorNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox DropDownDomainIDs;
        private System.Windows.Forms.CheckedListBox DomainGroupCheckedListBox;
        private System.Windows.Forms.DataGridView ClientsGrid;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DataGridView LogsGrid;
    }
}