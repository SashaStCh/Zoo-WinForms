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
    public partial class TicketUpdate : Form
    {
        private Int32 id;
        public TicketUpdate(Int32 id)
        {
            InitializeComponent();
            this.id = id;
        }

        private void ticketSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void TicketUpdate_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.TicketSet". При необходимости она может быть перемещена или удалена.
            this.ticketSetTableAdapter.FillById(this.dataSet1.TicketSet, this.id);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.ticketSetBindingSource.EndEdit();
                this.ticketSetTableAdapter.Update(this.dataSet1.TicketSet);
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
