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
    public partial class Feeding_TimeUpdate : Form
    {
        private DateTime id;
        public Feeding_TimeUpdate(DateTime id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void feeding_TimeSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.feeding_TimeSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Feeding_TimeUpdate_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Feeding_TimeSet". При необходимости она может быть перемещена или удалена.
            this.feeding_TimeSetTableAdapter.FillById(this.dataSet1.Feeding_TimeSet, this.id);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.feeding_TimeSetBindingSource.EndEdit();
                this.feeding_TimeSetTableAdapter.Update(this.dataSet1.Feeding_TimeSet);
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
