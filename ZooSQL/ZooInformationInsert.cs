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
    public partial class ZooInformationInsert : Form
    {
        public ZooInformationInsert()
        {
            InitializeComponent();
        }

        private void zoo_InformationSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zoo_InformationSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void ZooInformationInsert_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string zoo_name = zoo_nameTextBox.Text;
                string address = addressTextBox.Text;
                Int32 area = Int32.Parse(zoo_areaTextBox.Text);
                DateTime opening_time = opening_timeDateTimePicker.Value;
                DateTime closing_time = closing_timeDateTimePicker.Value;
                string hotline_phone = hotline_phoneTextBox.Text;
                string history = zoo_historyTextBox.Text;

                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.zoo_InformationSetBindingSource.EndEdit();
                this.zoo_InformationSetTableAdapter.Insert(zoo_name, address, area, opening_time, closing_time, hotline_phone, history);
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
