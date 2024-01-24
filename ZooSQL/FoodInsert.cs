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
    public partial class FoodInsert : Form
    {
        public FoodInsert()
        {
            InitializeComponent();
        }

        private void foodSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.foodSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void FoodInsert_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string foodName = food_nameTextBox.Text;

                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.foodSetBindingSource.EndEdit();
                this.foodSetTableAdapter.Insert(foodName);
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
