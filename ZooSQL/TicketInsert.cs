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
    public partial class TicketInsert : Form
    {
        public TicketInsert()
        {
            InitializeComponent();
        }

        private void ticketSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void TicketInsert_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime date_of_purchase = date_of_purchaseDateTimePicker.Value;
                Int32 cashbox_code = Int32.Parse(cashbox_cashbox_codeTextBox.Text);
                string ticket_type = ticket_Type_t_typeTextBox.Text;


                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.ticketSetBindingSource.EndEdit();
                this.ticketSetTableAdapter.Insert(date_of_purchase, cashbox_code, ticket_type);
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
