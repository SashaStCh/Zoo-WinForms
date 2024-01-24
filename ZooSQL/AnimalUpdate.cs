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
    public partial class AnimalUpdate : Form
    {
        private Int32 id;
        public AnimalUpdate(Int32 id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void animalSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animalSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void AnimalUpdate_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.AnimalSet". При необходимости она может быть перемещена или удалена.
            this.animalSetTableAdapter.FillById(this.dataSet1.AnimalSet, this.id);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.animalSetBindingSource.EndEdit();
                this.animalSetTableAdapter.Update(this.dataSet1.AnimalSet);
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
