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
    public partial class Feeding_TimeInsert : Form
    {
        public Feeding_TimeInsert()
        {
            InitializeComponent();
        }

        private void feeding_TimeSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.feeding_TimeSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Feeding_TimeInsert_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime f_Time = f_timeDateTimePicker.Value;
                string food_Name = food_food_nameTextBox.Text;
                Int32 animalCode = Int32.Parse(animal_animal_codeTextBox.Text);
                Int32 emp_code = Int32.Parse(employee_emp_codeTextBox.Text);

                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.feeding_TimeSetBindingSource.EndEdit();
                this.feeding_TimeSetTableAdapter.Insert(f_Time, food_Name, animalCode, emp_code);
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
