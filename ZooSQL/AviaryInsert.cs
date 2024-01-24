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
    public partial class AviaryInsert : Form
    {
        public AviaryInsert()
        {
            InitializeComponent();
        }

        private void aviarySetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aviarySetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void AviaryInsert_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string aviaryType = aviary_typeTextBox.Text;
                Int32 area = Int32.Parse(areaTextBox.Text);

                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.aviarySetBindingSource.EndEdit();
                this.aviarySetTableAdapter.Insert(aviaryType, area);
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
