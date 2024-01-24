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
    public partial class History_Work_ShiftInsert : Form
    {
        public History_Work_ShiftInsert()
        {
            InitializeComponent();
        }

        private void history_Work_ShiftSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.history_Work_ShiftSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void History_Work_ShiftInsert_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime h_a_l = time_a_lDateTimePicker.Value;
                Int32 emp_code = Int32.Parse(employee_emp_codeTextBox.Text);
                string arrival_leaving = work_Shift_arrival_leavingTextBox.Text;

                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.history_Work_ShiftSetBindingSource.EndEdit();
                this.history_Work_ShiftSetTableAdapter.Insert(h_a_l, emp_code, arrival_leaving);
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
