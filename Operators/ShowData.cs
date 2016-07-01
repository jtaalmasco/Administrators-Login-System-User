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
    public partial class ShowData : Form
    {
        DataTable DomainTable = new DataTable();
        DataTable Domaintable = new DataTable();
        private Boolean flag = true;               
        public ShowData()
        {
            InitializeComponent();          
        }

        private void ShowData_Load(object sender, EventArgs e)
        {
            OperatorNameLabel.Text = FormProperties.OperatorName;
            int tempCount = FormProperties.GroupCount;
            string[] tempArray = FormProperties.InitialDomain;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MinimizeBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            for (int i = 0; i < tempCount; i++)
            {
                DropDownDomainIDs.Items.Add(i + 1);
            }
            DropDownDomainIDs.SelectedIndex = 0;
            flag = false;
            var items = DomainGroupCheckedListBox.Items;
            items.Add(tempArray[0]);
            //ClientsGridView
            string[] tempInitialUsers = FormProperties.InitialUsers;
            DataTable ClientsTable = new DataTable();
            ClientsTable.Columns.Add("UserName");
            foreach (var array1 in tempInitialUsers)
            {
                ClientsTable.Rows.Add(array1);
            }
            ClientsGrid.DataSource = ClientsTable;
            //end ClientsGridView

            //DomainGridView
            Domaintable.Columns.Add("Domain");
            Domaintable.Rows.Add(tempArray[0]);
            //end DomainGridView
        }

        private void DropDownDomainIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!flag)
            {
                localhost.Service1 cservice = new localhost.Service1();
                BackgroundWorker bwrk = new BackgroundWorker();
                bwrk.DoWork += backgroundWorker1_DoWork1;
                bwrk.RunWorkerCompleted += backgroundWorker1_DoWork2;
                bwrk.RunWorkerAsync();
                string[] result;
                string[] ClientsResult;
                result = cservice.GetDomains();
                var items = DomainGroupCheckedListBox.Items;
                items.Clear();
                items.Add(result[DropDownDomainIDs.SelectedIndex]);
                ClientsResult = cservice.GetClientsPerGroup(DropDownDomainIDs.SelectedIndex + 1);
                //ClientsGridView
                DataTable table = new DataTable();
                table.Columns.Add("UserName");
                foreach (var array in ClientsResult)
                {
                    table.Rows.Add(array);
                }
                ClientsGrid.DataSource = table;
                ClientsGrid.ReadOnly = true;
                //End ClientsGridView

                //DomainGridView
               
                DomainTable.Columns.Add("Domain");
                DomainTable.Rows.Add(result[DropDownDomainIDs.SelectedIndex ]);
                DomainTable.RowChanged += new DataRowChangeEventHandler(OnColumnChanged);
                //end DomainGridView

            }
        }

        protected static void OnColumnChanged(Object sender, DataRowChangeEventArgs args)
        {
            var a = args;
        }


        private void backgroundWorker1_DoWork2(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("Completed");
        }

        private void backgroundWorker1_DoWork1(object sender, DoWorkEventArgs e)
        {
            //localhost.Service1 cservice = new localhost.Service1();
            MessageBox.Show("Processing");
        }

        private void ShowHistoryButton_Click(object sender, EventArgs e)
        {

        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {

        }

        private void DomainGroupCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SaveDomainChangesButton_Click(object sender, EventArgs e)
        {
           foreach(DataRow dr in Domaintable.Rows)
           {
               if(dr.RowState == DataRowState.Modified)
               {

               }
           }
        }

        private void CancelDomainChangesButton_Click(object sender, EventArgs e)
        {
        }

        private void DomainGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
          
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            ////Form2 testDialog = new Form2();

            ////// Show testDialog as a modal dialog and determine if DialogResult = OK.
            ////if (testDialog.ShowDialog(this) == DialogResult.OK)
            ////{
            ////    // Read the contents of testDialog's TextBox.
            ////    this.txtResult.Text = testDialog.TextBox1.Text;
            ////}
            ////else
            ////{
            ////    this.txtResult.Text = "Cancelled";
            ////}
            ////testDialog.Dispose();
            FormProperties.DomainLabelOperation = "Add";
            AddEditDeleteDomain Add = new AddEditDeleteDomain();
            Add.ShowDialog();

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            FormProperties.DomainLabelOperation = "Edit";
            AddEditDeleteDomain Add = new AddEditDeleteDomain();
            Add.ShowDialog();
        }


    }
}
