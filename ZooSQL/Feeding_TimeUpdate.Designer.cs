
namespace ZooSQL
{
    partial class Feeding_TimeUpdate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label f_timeLabel;
            System.Windows.Forms.Label food_food_nameLabel;
            System.Windows.Forms.Label animal_animal_codeLabel;
            System.Windows.Forms.Label employee_emp_codeLabel;
            this.dataSet1 = new ZooSQL.DataSet1();
            this.feeding_TimeSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.feeding_TimeSetTableAdapter = new ZooSQL.DataSet1TableAdapters.Feeding_TimeSetTableAdapter();
            this.tableAdapterManager = new ZooSQL.DataSet1TableAdapters.TableAdapterManager();
            this.f_timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.food_food_nameTextBox = new System.Windows.Forms.TextBox();
            this.animal_animal_codeTextBox = new System.Windows.Forms.TextBox();
            this.employee_emp_codeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            f_timeLabel = new System.Windows.Forms.Label();
            food_food_nameLabel = new System.Windows.Forms.Label();
            animal_animal_codeLabel = new System.Windows.Forms.Label();
            employee_emp_codeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeding_TimeSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // f_timeLabel
            // 
            f_timeLabel.AutoSize = true;
            f_timeLabel.Location = new System.Drawing.Point(12, 9);
            f_timeLabel.Name = "f_timeLabel";
            f_timeLabel.Size = new System.Drawing.Size(35, 13);
            f_timeLabel.TabIndex = 1;
            f_timeLabel.Text = "f time:";
            // 
            // food_food_nameLabel
            // 
            food_food_nameLabel.AutoSize = true;
            food_food_nameLabel.Location = new System.Drawing.Point(12, 34);
            food_food_nameLabel.Name = "food_food_nameLabel";
            food_food_nameLabel.Size = new System.Drawing.Size(87, 13);
            food_food_nameLabel.TabIndex = 3;
            food_food_nameLabel.Text = "Food food name:";
            // 
            // animal_animal_codeLabel
            // 
            animal_animal_codeLabel.AutoSize = true;
            animal_animal_codeLabel.Location = new System.Drawing.Point(12, 60);
            animal_animal_codeLabel.Name = "animal_animal_codeLabel";
            animal_animal_codeLabel.Size = new System.Drawing.Size(101, 13);
            animal_animal_codeLabel.TabIndex = 5;
            animal_animal_codeLabel.Text = "Animal animal code:";
            // 
            // employee_emp_codeLabel
            // 
            employee_emp_codeLabel.AutoSize = true;
            employee_emp_codeLabel.Location = new System.Drawing.Point(12, 86);
            employee_emp_codeLabel.Name = "employee_emp_codeLabel";
            employee_emp_codeLabel.Size = new System.Drawing.Size(106, 13);
            employee_emp_codeLabel.TabIndex = 7;
            employee_emp_codeLabel.Text = "Employee emp code:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // feeding_TimeSetBindingSource
            // 
            this.feeding_TimeSetBindingSource.DataMember = "Feeding_TimeSet";
            this.feeding_TimeSetBindingSource.DataSource = this.dataSet1;
            // 
            // feeding_TimeSetTableAdapter
            // 
            this.feeding_TimeSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Animal_AnalysisSetTableAdapter = null;
            this.tableAdapterManager.AnimalSetTableAdapter = null;
            this.tableAdapterManager.AuthorizationSetTableAdapter = null;
            this.tableAdapterManager.AviarySetTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Cashbox_StatusSetTableAdapter = null;
            this.tableAdapterManager.CashboxSetTableAdapter = null;
            this.tableAdapterManager.EmployeeSetTableAdapter = null;
            this.tableAdapterManager.Feeding_TimeSetTableAdapter = this.feeding_TimeSetTableAdapter;
            this.tableAdapterManager.Food_RationSetTableAdapter = null;
            this.tableAdapterManager.FoodSetTableAdapter = null;
            this.tableAdapterManager.Health_StatusSetTableAdapter = null;
            this.tableAdapterManager.History_Work_ShiftSetTableAdapter = null;
            this.tableAdapterManager.JobSetTableAdapter = null;
            this.tableAdapterManager.SpetiesSetTableAdapter = null;
            this.tableAdapterManager.Status_ChangesSetTableAdapter = null;
            this.tableAdapterManager.Ticket_TypeSetTableAdapter = null;
            this.tableAdapterManager.TicketSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ZooSQL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Work_ShiftSetTableAdapter = null;
            this.tableAdapterManager.Zoo_InformationSetTableAdapter = null;
            // 
            // f_timeDateTimePicker
            // 
            this.f_timeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.feeding_TimeSetBindingSource, "f_time", true));
            this.f_timeDateTimePicker.Location = new System.Drawing.Point(124, 5);
            this.f_timeDateTimePicker.Name = "f_timeDateTimePicker";
            this.f_timeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.f_timeDateTimePicker.TabIndex = 2;
            // 
            // food_food_nameTextBox
            // 
            this.food_food_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feeding_TimeSetBindingSource, "Food_food_name", true));
            this.food_food_nameTextBox.Location = new System.Drawing.Point(124, 31);
            this.food_food_nameTextBox.Name = "food_food_nameTextBox";
            this.food_food_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.food_food_nameTextBox.TabIndex = 4;
            // 
            // animal_animal_codeTextBox
            // 
            this.animal_animal_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feeding_TimeSetBindingSource, "Animal_animal_code", true));
            this.animal_animal_codeTextBox.Location = new System.Drawing.Point(124, 57);
            this.animal_animal_codeTextBox.Name = "animal_animal_codeTextBox";
            this.animal_animal_codeTextBox.Size = new System.Drawing.Size(200, 20);
            this.animal_animal_codeTextBox.TabIndex = 6;
            // 
            // employee_emp_codeTextBox
            // 
            this.employee_emp_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.feeding_TimeSetBindingSource, "Employee_emp_code", true));
            this.employee_emp_codeTextBox.Location = new System.Drawing.Point(124, 83);
            this.employee_emp_codeTextBox.Name = "employee_emp_codeTextBox";
            this.employee_emp_codeTextBox.Size = new System.Drawing.Size(200, 20);
            this.employee_emp_codeTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(20, 121);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 32);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Feeding_TimeUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 173);
            this.Controls.Add(this.button1);
            this.Controls.Add(f_timeLabel);
            this.Controls.Add(this.f_timeDateTimePicker);
            this.Controls.Add(food_food_nameLabel);
            this.Controls.Add(this.food_food_nameTextBox);
            this.Controls.Add(animal_animal_codeLabel);
            this.Controls.Add(this.animal_animal_codeTextBox);
            this.Controls.Add(employee_emp_codeLabel);
            this.Controls.Add(this.employee_emp_codeTextBox);
            this.Name = "Feeding_TimeUpdate";
            this.Text = "Feeding_TimeUpdate";
            this.Load += new System.EventHandler(this.Feeding_TimeUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.feeding_TimeSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource feeding_TimeSetBindingSource;
        private DataSet1TableAdapters.Feeding_TimeSetTableAdapter feeding_TimeSetTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker f_timeDateTimePicker;
        private System.Windows.Forms.TextBox food_food_nameTextBox;
        private System.Windows.Forms.TextBox animal_animal_codeTextBox;
        private System.Windows.Forms.TextBox employee_emp_codeTextBox;
        private System.Windows.Forms.Button button1;
    }
}