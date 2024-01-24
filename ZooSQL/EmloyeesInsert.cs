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
    public partial class EmloyeesInsert : Form
    {
        public EmloyeesInsert()
        {
            InitializeComponent();
        }

        private void employeeSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void EmloyeesInsert_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string last_Name = last_nameTextBox.Text;
                string first_Name = first_nameTextBox.Text;
                string patronymic = patronymicTextBox.Text;
                string gender = emp_genderTextBox.Text;
                Int32 salary = Int32.Parse(salaryTextBox.Text);
                string phone = phone_numberTextBox.Text;
                string address = addressTextBox.Text;
                string email = emailTextBox.Text;
                TimeSpan start_schedule = TimeSpan.Parse(start_scheduleTextBox.Text);
                TimeSpan finish_schedule = TimeSpan.Parse(finish_scheduleTextBox.Text);
                Int32 jobId = Int32.Parse(job_job_idTextBox.Text);


                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.employeeSetBindingSource.EndEdit();
                this.employeeSetTableAdapter.Insert(last_Name, first_Name, patronymic, gender, salary, phone, address, email, start_schedule, finish_schedule, jobId);
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
