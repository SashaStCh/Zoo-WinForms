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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void animal_AnalysisSetBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.animal_AnalysisSetBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Zoo_InformationSet". При необходимости она может быть перемещена или удалена.
            this.zoo_InformationSetTableAdapter.Fill(this.dataSet1.Zoo_InformationSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.TicketSet". При необходимости она может быть перемещена или удалена.
            this.ticketSetTableAdapter.Fill(this.dataSet1.TicketSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.CashboxSet". При необходимости она может быть перемещена или удалена.
            this.cashboxSetTableAdapter.Fill(this.dataSet1.CashboxSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Status_ChangesSet". При необходимости она может быть перемещена или удалена.
            this.status_ChangesSetTableAdapter.Fill(this.dataSet1.Status_ChangesSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.History_Work_ShiftSet". При необходимости она может быть перемещена или удалена.
            this.history_Work_ShiftSetTableAdapter.Fill(this.dataSet1.History_Work_ShiftSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.EmployeeSet". При необходимости она может быть перемещена или удалена.
            this.employeeSetTableAdapter.Fill(this.dataSet1.EmployeeSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Feeding_TimeSet". При необходимости она может быть перемещена или удалена.
            this.feeding_TimeSetTableAdapter.Fill(this.dataSet1.Feeding_TimeSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.FoodSet". При необходимости она может быть перемещена или удалена.
            this.foodSetTableAdapter.Fill(this.dataSet1.FoodSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.SpetiesSet". При необходимости она может быть перемещена или удалена.
            this.spetiesSetTableAdapter.Fill(this.dataSet1.SpetiesSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.AviarySet". При необходимости она может быть перемещена или удалена.
            this.aviarySetTableAdapter.Fill(this.dataSet1.AviarySet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.AnimalSet". При необходимости она может быть перемещена или удалена.
            this.animalSetTableAdapter.Fill(this.dataSet1.AnimalSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Ticket_TypeSet". При необходимости она может быть перемещена или удалена.
            this.ticket_TypeSetTableAdapter.Fill(this.dataSet1.Ticket_TypeSet);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Animal_AnalysisSet". При необходимости она может быть перемещена или удалена.
            this.animal_AnalysisSetTableAdapter.Fill(this.dataSet1.Animal_AnalysisSet);

        }

        private void animal_AnalysisSetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void foodSetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void feeding_TimeSetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void animalSetDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DataGridView selected = tabControl1.SelectedTab.Controls.OfType<DataGridView>().First();
            DataGridViewRow row = selected.Rows[selected.SelectedCells[0].RowIndex];
            switch (selected.Name)
            {
                case "animalSetDataGridView":
                    CRUDAnimal.Instance.Delete((Int32)row.Cells[0].Value);
                    break;
                case "animal_AnalysisSetDataGridView":
                    CRUDAnimal_Analysis.Instance.Delete((Int32)row.Cells[0].Value);
                    break;
                case "aviarySetDataGridView":
                    CRUDAviary.Instance.Delete((Int32)row.Cells[0].Value);
                    break;
                case "spetiesSetDataGridView":
                    CRUDSpeties.Instance.Delete((String)row.Cells[0].Value);
                    break;
                case "foodSetDataGridView":
                    CRUDFood.Instance.Delete((String)row.Cells[0].Value);
                    break;
                case "feeding_TimeSetDataGridView":
                    CRUDFeeding_Time.Instance.Delete((DateTime)row.Cells[0].Value);
                    break;
                case "employeeSetDataGridView":
                    CRUDEmployee.Instance.Delete((Int32)row.Cells[0].Value);
                    break;
                case "history_Work_ShiftSetDataGridView":
                    CRUDHistory_Work_Shift.Instance.Delete((DateTime)row.Cells[0].Value);
                    break;
                case "status_ChangesSetDataGridView":
                    CRUDStatus_Changes.Instance.Delete((DateTime)row.Cells[0].Value);
                    break;
                case "cashboxSetDataGridView":
                    CRUDCashbox.Instance.Delete((Int32)row.Cells[0].Value);
                    break;
                case "ticketSetDataGridView":
                    CRUDTicket.Instance.Delete((Int32)row.Cells[0].Value);
                    break;
                case "zoo_InformationSetDataGridView":
                    CRUDZoo_Information.Instance.Delete((String)row.Cells[0].Value);
                    break;
            }
            Form1_Load(sender, e);
        }
        private void Update_Click(object sender, EventArgs e)
        {
            DataGridView selected = tabControl1.SelectedTab.Controls.OfType<DataGridView>().First();
            DataGridViewRow row = selected.Rows[selected.SelectedCells[0].RowIndex];
            switch (selected.Name)
            {
                case "animalSetDataGridView":
                    AnimalUpdate animalUpdate = new AnimalUpdate((Int32)row.Cells[0].Value);
                    animalUpdate.Show();
                    break;
                case "animal_AnalysisSetDataGridView":
                    Animal_AnalysisUpdate animal_AnalysisUpdate = new Animal_AnalysisUpdate((Int32)row.Cells[0].Value);
                    animal_AnalysisUpdate.Show();
                    break;
                case "aviarySetDataGridView":
                    AviaryUpdate aviaryUpdate = new AviaryUpdate((Int32)row.Cells[0].Value);
                    aviaryUpdate.Show();
                    break;
                case "spetiesSetDataGridView":
                    SpetiesUpdate spetiesUpdate = new SpetiesUpdate((string)row.Cells[0].Value);
                    spetiesUpdate.Show();
                    break;
                case "foodSetDataGridView":
                    FoodUpdate foodUpdate = new FoodUpdate((string)row.Cells[0].Value);
                    foodUpdate.Show();
                    break;
                case "feeding_TimeSetDataGridView":
                    Feeding_TimeUpdate feeding_TimeUpdate = new Feeding_TimeUpdate((DateTime)row.Cells[0].Value);
                    feeding_TimeUpdate.Show();
                    break;
                case "employeeSetDataGridView":
                    EmployeeUpdate employeeUpdate = new EmployeeUpdate((Int32)row.Cells[0].Value);
                    employeeUpdate.Show();
                    break;
                case "history_Work_ShiftSetDataGridView":
                    History_Work_ShiftUpdate history_Work_ShiftUpdate = new History_Work_ShiftUpdate((DateTime)row.Cells[0].Value);
                    history_Work_ShiftUpdate.Show();
                    break;
                case "status_ChangesSetDataGridView":
                    Status_ChangesUpdate status_ChangesUpdate = new Status_ChangesUpdate((DateTime)row.Cells[0].Value);
                    status_ChangesUpdate.Show();
                    break;
                case "cashboxSetDataGridView":
                    break;
                case "ticketSetDataGridView":
                    TicketUpdate ticketUpdate = new TicketUpdate((Int32)row.Cells[0].Value);
                    ticketUpdate.Show();
                    break;
                case "zoo_InformationSetDataGridView":
                    Zoo_InformationUpdate zoo_InformationUpdate = new Zoo_InformationUpdate((string)row.Cells[0].Value);
                    zoo_InformationUpdate.Show();
                    break;
            }

        }

        private void Insert_Click(object sender, EventArgs e)
        {
            DataGridView selected = tabControl1.SelectedTab.Controls.OfType<DataGridView>().First();
            switch (selected.Name)
            {
                case "animalSetDataGridView":
                    AnimalInsert animalInsert = new AnimalInsert();
                    animalInsert.Show();
                    break;
                case "animal_AnalysisSetDataGridView":
                    Animal_AnalysisInsert animal_AnalysisInsert = new Animal_AnalysisInsert();
                    animal_AnalysisInsert.Show();
                    break;
                case "aviarySetDataGridView":
                    AviaryInsert aviaryInsert = new AviaryInsert();
                    aviaryInsert.Show();
                    break;
                case "spetiesSetDataGridView":
                    SpetiesInsert spetiesInsert = new SpetiesInsert();
                    spetiesInsert.Show();
                    break;
                case "foodSetDataGridView":
                    FoodInsert foodInsert = new FoodInsert();
                    foodInsert.Show();
                    break;
                case "feeding_TimeSetDataGridView":
                    Feeding_TimeInsert feeding_Time = new Feeding_TimeInsert();
                    feeding_Time.Show();
                    break;
                case "employeeSetDataGridView":
                    EmloyeesInsert employeesInsert = new EmloyeesInsert();
                    employeesInsert.Show();
                    break;
                case "history_Work_ShiftSetDataGridView":
                    History_Work_ShiftInsert history_Work_ShiftInsert = new History_Work_ShiftInsert();
                    history_Work_ShiftInsert.Show();
                    break;
                case "status_ChangesSetDataGridView":
                    Status_ChangesInsert status_ChangesInsert = new Status_ChangesInsert();
                    status_ChangesInsert.Show();
                    break;
                case "cashboxSetDataGridView":
                    CRUDCashbox.Instance.Create();
                    Form1_Load(sender, e);
                    break;
                case "ticketSetDataGridView":
                    TicketInsert ticketInsert = new TicketInsert();
                    ticketInsert.Show();
                    break;
                case "zoo_InformationSetDataGridView":
                    ZooInformationInsert zooInformationInsert = new ZooInformationInsert();
                    zooInformationInsert.Show();
                    break;
            }
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            Form1_Load(sender, e);
        }

    }
}
