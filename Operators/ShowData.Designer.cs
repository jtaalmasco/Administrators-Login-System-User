namespace Operators
{
    partial class ShowData
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
            this.ClientsGrid = new System.Windows.Forms.DataGridView();
            this.DropDownDomainIDs = new System.Windows.Forms.ComboBox();
            this.OperatorNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DomainGroupCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.ShowHistoryButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientsGrid
            // 
            this.ClientsGrid.AllowUserToOrderColumns = true;
            this.ClientsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientsGrid.Location = new System.Drawing.Point(44, 177);
            this.ClientsGrid.Name = "ClientsGrid";
            this.ClientsGrid.Size = new System.Drawing.Size(1029, 288);
            this.ClientsGrid.TabIndex = 1;
            // 
            // DropDownDomainIDs
            // 
            this.DropDownDomainIDs.FormattingEnabled = true;
            this.DropDownDomainIDs.Location = new System.Drawing.Point(320, 36);
            this.DropDownDomainIDs.Name = "DropDownDomainIDs";
            this.DropDownDomainIDs.Size = new System.Drawing.Size(58, 21);
            this.DropDownDomainIDs.TabIndex = 2;
            this.DropDownDomainIDs.SelectedIndexChanged += new System.EventHandler(this.DropDownDomainIDs_SelectedIndexChanged);
            // 
            // OperatorNameLabel
            // 
            this.OperatorNameLabel.AutoSize = true;
            this.OperatorNameLabel.Location = new System.Drawing.Point(51, 39);
            this.OperatorNameLabel.Name = "OperatorNameLabel";
            this.OperatorNameLabel.Size = new System.Drawing.Size(102, 13);
            this.OperatorNameLabel.TabIndex = 3;
            this.OperatorNameLabel.Text = "OperatorNameLabel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(252, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Groups";
            // 
            // DomainGroupCheckedListBox
            // 
            this.DomainGroupCheckedListBox.FormattingEnabled = true;
            this.DomainGroupCheckedListBox.Location = new System.Drawing.Point(532, 39);
            this.DomainGroupCheckedListBox.Name = "DomainGroupCheckedListBox";
            this.DomainGroupCheckedListBox.Size = new System.Drawing.Size(307, 49);
            this.DomainGroupCheckedListBox.TabIndex = 6;
            this.DomainGroupCheckedListBox.SelectedIndexChanged += new System.EventHandler(this.DomainGroupCheckedListBox_SelectedIndexChanged);
            // 
            // LogoutButton
            // 
            this.LogoutButton.Location = new System.Drawing.Point(956, 508);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(117, 35);
            this.LogoutButton.TabIndex = 10;
            this.LogoutButton.Text = "LogOut";
            this.LogoutButton.UseVisualStyleBackColor = true;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // ShowHistoryButton
            // 
            this.ShowHistoryButton.Location = new System.Drawing.Point(807, 508);
            this.ShowHistoryButton.Name = "ShowHistoryButton";
            this.ShowHistoryButton.Size = new System.Drawing.Size(114, 35);
            this.ShowHistoryButton.TabIndex = 11;
            this.ShowHistoryButton.Text = "Show History";
            this.ShowHistoryButton.UseVisualStyleBackColor = true;
            this.ShowHistoryButton.Click += new System.EventHandler(this.ShowHistoryButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(532, 108);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 15;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(623, 108);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 16;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(713, 108);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 17;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            // 
            // ShowData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1101, 552);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ShowHistoryButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.DomainGroupCheckedListBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OperatorNameLabel);
            this.Controls.Add(this.DropDownDomainIDs);
            this.Controls.Add(this.ClientsGrid);
            this.Name = "ShowData";
            this.Text = "ShowData";
            this.Load += new System.EventHandler(this.ShowData_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClientsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ClientsGrid;
        private System.Windows.Forms.ComboBox DropDownDomainIDs;
        private System.Windows.Forms.Label OperatorNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox DomainGroupCheckedListBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button ShowHistoryButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}