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
    public partial class EmployeeUpdate : Form
    {
        private Int32 id;
        public EmployeeUpdate(Int32 id)
        {
            InitializeComponent(); 
            this.id = id;
        }

        private void employeeSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void EmployeeUpdate_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.EmployeeSet". При необходимости она может быть перемещена или удалена.
            this.employeeSetTableAdapter.FillById(this.dataSet1.EmployeeSet, this.id);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.employeeSetBindingSource.EndEdit();
                this.employeeSetTableAdapter.Update(this.dataSet1.EmployeeSet);
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
