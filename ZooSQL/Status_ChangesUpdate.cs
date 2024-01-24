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
    public partial class Status_ChangesUpdate : Form
    {
        private DateTime id;
        public Status_ChangesUpdate(DateTime id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void status_ChangesSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.status_ChangesSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Status_ChangesUpdate_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Status_ChangesSet". При необходимости она может быть перемещена или удалена.
            this.status_ChangesSetTableAdapter.FillById(this.dataSet1.Status_ChangesSet, this.id);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.status_ChangesSetBindingSource.EndEdit();
                this.status_ChangesSetTableAdapter.Update(this.dataSet1.Status_ChangesSet);
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
