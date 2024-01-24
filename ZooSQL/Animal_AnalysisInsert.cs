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
    public partial class Animal_AnalysisInsert : Form
    {
        public Animal_AnalysisInsert()
        {
            InitializeComponent();
        }

        private void animal_AnalysisSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animal_AnalysisSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Animal_AnalysisInsert_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime analysis_date = analysis_dateDateTimePicker.Value;
                Int32 weight = Int32.Parse(weightTextBox.Text);
                Int32 code = Int32.Parse(animal_animal_codeTextBox.Text);
                string h_status = health_Status_h_statusTextBox.Text;

                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.animal_AnalysisSetBindingSource.EndEdit();
                this.animal_AnalysisSetTableAdapter.Insert(analysis_date, weight, code, h_status);
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

