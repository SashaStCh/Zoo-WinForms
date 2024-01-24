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
    public partial class AviaryUpdate : Form
    {
        private Int32 id;
        public AviaryUpdate(Int32 id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void aviarySetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.aviarySetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void AviaryUpdate_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.AviarySet". При необходимости она может быть перемещена или удалена.
            this.aviarySetTableAdapter.FillById(this.dataSet1.AviarySet, this.id);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.aviarySetBindingSource.EndEdit();
                this.aviarySetTableAdapter.Update(this.dataSet1.AviarySet);
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
