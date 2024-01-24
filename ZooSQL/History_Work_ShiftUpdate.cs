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
    public partial class History_Work_ShiftUpdate : Form
    {
        private DateTime id;
        public History_Work_ShiftUpdate(DateTime id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void history_Work_ShiftSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.history_Work_ShiftSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void History_Work_ShiftUpdate_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.History_Work_ShiftSet". При необходимости она может быть перемещена или удалена.
            this.history_Work_ShiftSetTableAdapter.FillById(this.dataSet1.History_Work_ShiftSet, this.id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.history_Work_ShiftSetBindingSource.EndEdit();
                this.history_Work_ShiftSetTableAdapter.Update(this.dataSet1.History_Work_ShiftSet);
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
