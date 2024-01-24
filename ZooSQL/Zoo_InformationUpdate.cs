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
    public partial class Zoo_InformationUpdate : Form
    {
        private string id;
        public Zoo_InformationUpdate(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void zoo_InformationSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.zoo_InformationSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Zoo_InformationUpdate_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Zoo_InformationSet". При необходимости она может быть перемещена или удалена.
            this.zoo_InformationSetTableAdapter.FillById(this.dataSet1.Zoo_InformationSet, this.id);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.zoo_InformationSetBindingSource.EndEdit();
                this.zoo_InformationSetTableAdapter.Update(this.dataSet1.Zoo_InformationSet);
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
