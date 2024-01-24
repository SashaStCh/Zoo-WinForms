using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZooSQL
{
    public partial class Status_ChangesInsert : Form
    {
        public Status_ChangesInsert()
        {
            InitializeComponent();
        }

        private void status_ChangesSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.status_ChangesSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void status_ChangesSetBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.status_ChangesSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Status_ChangesInsert_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime status_date = status_dateDateTimePicker.Value;
                Int32 emp_code = Int32.Parse(employee_emp_codeTextBox.Text);
                string status_name = cashbox_Status_status_nameTextBox.Text;
                Int32 cashbox_code = Int32.Parse(cashbox_cashbox_codeTextBox.Text);

                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.status_ChangesSetBindingSource.EndEdit();
                this.status_ChangesSetTableAdapter.Insert(status_date, emp_code, status_name, cashbox_code);
                refreshButton.PerformClick();
                this.Close();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
