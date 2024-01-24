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
    public partial class SpetiesInsert : Form
    {
        public SpetiesInsert()
        {
            InitializeComponent();
        }

        private void spetiesSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.spetiesSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void SpetiesInsert_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string speciesName = species_nameTextBox.Text;
                string name_In_Latin = name_in_latinTextBox.Text;
                string description = descriptionTextBox.Text;

                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.spetiesSetBindingSource.EndEdit();
                this.spetiesSetTableAdapter.Insert(speciesName, name_In_Latin, description);
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
