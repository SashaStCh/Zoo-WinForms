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
    public partial class AnimalInsert : Form
    {
        public AnimalInsert()
        {
            InitializeComponent();
        }

        private void animalSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animalSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void AnimalInsert_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string animalName = animal_nameTextBox.Text;
                string animalGender = animal_genderTextBox.Text;
                string color = colorTextBox.Text;
                DateTime dateTime = date_of_birthDateTimePicker.Value;
                string species = speties_species_nameTextBox.Text;
                Int32 aviary = Int32.Parse(aviary_aviary_codeTextBox.Text);

                Form1 form1 = (Form1)Application.OpenForms["Form1"];
                Button refreshButton = (Button)form1.Controls.Find("button4", true)[0];
                this.Validate();
                this.animalSetBindingSource.EndEdit();
                this.animalSetTableAdapter.Insert(animalName, animalGender, color, dateTime, species, aviary);
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
