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
    public partial class SpetiesUpdate : Form
    {
        private string id;
        public SpetiesUpdate(string id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void spetiesSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.spetiesSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void SpetiesUpdate_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.SpetiesSet". При необходимости она может быть перемещена или удалена.
            this.spetiesSetTableAdapter.FillById(this.dataSet1.SpetiesSet, this.id);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.spetiesSetBindingSource.EndEdit();
                this.spetiesSetTableAdapter.Update(this.dataSet1.SpetiesSet);
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
