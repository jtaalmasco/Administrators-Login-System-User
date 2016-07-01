using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Operators
{
    public partial class AddEditDeleteDomain : Form
    {
        public AddEditDeleteDomain()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string operatorName = FormProperties.OperatorName;
            string OrigText = FormProperties.OrigDomainToEdit;
            string Text = DomainTextBox.Text;
            int GroupID = FormProperties.GroupID;
            if(FormProperties.DomainLabelOperation == "Add")
            {
                localhost.Service1 cservice = new localhost.Service1();
                cservice.AddNewDomain(operatorName,GroupID, Text);
                this.Hide();
            }
            else if(FormProperties.DomainLabelOperation == "Edit")
            {
                localhost.Service1 cservice = new localhost.Service1();
                cservice.EditDomain(operatorName,GroupID, FormProperties.OrigDomainToEdit, Text);
                this.Hide();
            }
            else if(FormProperties.DomainLabelOperation == "Delete")
            {
                localhost.Service1 cservice = new localhost.Service1();
                cservice.DeleteDomain(operatorName, GroupID, FormProperties.OrigDomainToEdit);
                this.Hide();
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AddEditDeleteDomain_Load(object sender, EventArgs e)
        {
            if (FormProperties.DomainLabelOperation == "Delete")
            {
                AED.Text = "Delete: " + FormProperties.OrigDomainToEdit + " ?";
                DomainTextBox.Visible = false;
            }
            else if (FormProperties.DomainLabelOperation == "Edit")
            {
                DomainTextBox.Text = FormProperties.OrigDomainToEdit;
                AED.Text = "Edit";
            }
            else if (FormProperties.DomainLabelOperation == "Add")
            {
                AED.Text = "Add";
            }
            

        }
    }
}
