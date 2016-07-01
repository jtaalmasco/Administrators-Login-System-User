namespace Operators
{
    partial class Operator_Login
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
            this.OperatorUserNameTextbox = new System.Windows.Forms.TextBox();
            this.OperatorPasswordTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Remember = new System.Windows.Forms.CheckBox();
            this.AutoLogin = new System.Windows.Forms.CheckBox();
            this.OperatorLogin = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // OperatorUserNameTextbox
            // 
            this.OperatorUserNameTextbox.Location = new System.Drawing.Point(111, 27);
            this.OperatorUserNameTextbox.Name = "OperatorUserNameTextbox";
            this.OperatorUserNameTextbox.Size = new System.Drawing.Size(233, 20);
            this.OperatorUserNameTextbox.TabIndex = 0;
            this.OperatorUserNameTextbox.TextChanged += new System.EventHandler(this.OperatorUserNameTextbox_TextChanged);
            // 
            // OperatorPasswordTextbox
            // 
            this.OperatorPasswordTextbox.Location = new System.Drawing.Point(111, 77);
            this.OperatorPasswordTextbox.Name = "OperatorPasswordTextbox";
            this.OperatorPasswordTextbox.Size = new System.Drawing.Size(233, 20);
            this.OperatorPasswordTextbox.TabIndex = 1;
            this.OperatorPasswordTextbox.TextChanged += new System.EventHandler(this.OperatorPasswordTextbox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "UserName";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.OperatorLogin);
            this.panel1.Controls.Add(this.AutoLogin);
            this.panel1.Controls.Add(this.Remember);
            this.panel1.Controls.Add(this.OperatorUserNameTextbox);
            this.panel1.Controls.Add(this.OperatorPasswordTextbox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(123, 139);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(420, 183);
            this.panel1.TabIndex = 7;
            // 
            // Remember
            // 
            this.Remember.AutoSize = true;
            this.Remember.Location = new System.Drawing.Point(135, 113);
            this.Remember.Name = "Remember";
            this.Remember.Size = new System.Drawing.Size(77, 17);
            this.Remember.TabIndex = 7;
            this.Remember.Text = "Remember";
            this.Remember.UseVisualStyleBackColor = true;
            // 
            // AutoLogin
            // 
            this.AutoLogin.AutoSize = true;
            this.AutoLogin.Location = new System.Drawing.Point(255, 113);
            this.AutoLogin.Name = "AutoLogin";
            this.AutoLogin.Size = new System.Drawing.Size(48, 17);
            this.AutoLogin.TabIndex = 8;
            this.AutoLogin.Text = "Auto";
            this.AutoLogin.UseVisualStyleBackColor = true;
            // 
            // OperatorLogin
            // 
            this.OperatorLogin.Location = new System.Drawing.Point(135, 145);
            this.OperatorLogin.Name = "OperatorLogin";
            this.OperatorLogin.Size = new System.Drawing.Size(75, 23);
            this.OperatorLogin.TabIndex = 9;
            this.OperatorLogin.Text = "Login";
            this.OperatorLogin.UseVisualStyleBackColor = true;
            this.OperatorLogin.Click += new System.EventHandler(this.OperatorLogin_Click_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(269, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Register";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Operator_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(674, 480);
            this.Controls.Add(this.panel1);
            this.Name = "Operator_Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Operator_Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox OperatorUserNameTextbox;
        private System.Windows.Forms.TextBox OperatorPasswordTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox AutoLogin;
        private System.Windows.Forms.CheckBox Remember;
        private System.Windows.Forms.Button OperatorLogin;
        private System.Windows.Forms.Button button1;
    }
}

