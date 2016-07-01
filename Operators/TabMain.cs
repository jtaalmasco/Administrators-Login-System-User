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
    public partial class TabMain : Form
    {
        DataTable DomainTable = new DataTable();
        DataTable Domaintable = new DataTable();
        private Boolean flag = true;
        private int CheckedBoxCount = 0;
        public TabMain()
        {
            InitializeComponent();
        }

        private void TabMain_Load(object sender, EventArgs e)
        {
            FormProperties.GroupID = 1;
            //styles
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.MinimizeBox = false;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            //end of styles

            //Labels
            OperatorNameLabel.Text = FormProperties.OperatorName;
            //End of Labels

            //DropDown
            int tempCount = FormProperties.GroupCount;
            string[] tempArray = FormProperties.InitialDomain;

            for (int i = 0; i < tempCount; i++)
            {
                DropDownDomainIDs.Items.Add(i + 1);
            }
            DropDownDomainIDs.SelectedIndex = 0;
            flag = false;
            //End Of DropDown

            //DataGridView of UserNames
            string[] tempInitialUsers = FormProperties.InitialUsers;
            DataTable ClientsTable = new DataTable();
            ClientsTable.Columns.Add("UserName");
            foreach (var array1 in tempInitialUsers)
            {
                ClientsTable.Rows.Add(array1);
            }
            ClientsGrid.DataSource = ClientsTable;
            //End of DataGridView

            //CheckedListBox
            var items = DomainGroupCheckedListBox.Items;
            items.Add(tempArray[0]);
            //End of CheckedListBox

            //tab Controls
            tabControl1.SelectedIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl_SelectedIndexChanged;
            //end of tab Controls
        }

        private void tabControl_SelectedIndexChanged(Object sender, EventArgs e)
        {
            DataTable LogsTable = new DataTable();
            LogsTable.Columns.Add("GroupID");
            LogsTable.Columns.Add("OperatorName");
            LogsTable.Columns.Add("Time");
            LogsTable.Columns.Add("OperatingType");
            LogsTable.Columns.Add("Domain");
            if (tabControl1.SelectedIndex == 1)
            {
                localhost.Service1 cservice = new localhost.Service1();
                var a = cservice.GetOperatorLogs();

                foreach(var b in a)
                {
                    LogsTable.Rows.Add(b.GroupID,b.OperatorName,b.Time,b.OperatingType,b.Domain);
                }
                LogsGrid.DataSource = LogsTable; 
            }
        }

        private void DropDownDomainIDs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!flag)
            {
                FormProperties.GroupID = DropDownDomainIDs.SelectedIndex + 1;
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
                DomainTable.Rows.Add(result[DropDownDomainIDs.SelectedIndex]);
                DomainTable.RowChanged += new DataRowChangeEventHandler(OnColumnChanged);
            }
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

        protected static void OnColumnChanged(Object sender, DataRowChangeEventArgs args)
        {
            var a = args;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            FormProperties.DomainLabelOperation = "Add";
            AddEditDeleteDomain Add = new AddEditDeleteDomain();
            Add.ShowDialog();
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (CheckedBoxCount == 1)
            {
                FormProperties.DomainLabelOperation = "Edit";
                AddEditDeleteDomain Edit = new AddEditDeleteDomain();
                Edit.ShowDialog();
            }
            else if (CheckedBoxCount > 1)
            {
                MessageBox.Show("Cannot Select More than 2");
            }
            else
            {
                MessageBox.Show("Must Select One Item");
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (CheckedBoxCount == 1)
            {
                FormProperties.DomainLabelOperation = "Delete";
                AddEditDeleteDomain Delete = new AddEditDeleteDomain();
                Delete.ShowDialog();
            }
            else if (CheckedBoxCount > 1)
            {
                MessageBox.Show("Cannot Select More than 2");
            }
            else
            {
                MessageBox.Show("Must Select One Item");
            }
        }

        private void DomainGroupCheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var a = DomainGroupCheckedListBox.CheckedIndices;
            FormProperties.OrigDomainToEdit = DomainGroupCheckedListBox.SelectedItem.ToString();

            if (a.Count >= 1)
            {
                CheckedBoxCount = 1;
            }
            else
            {
                CheckedBoxCount = 0;
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
