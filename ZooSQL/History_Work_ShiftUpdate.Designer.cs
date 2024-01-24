
namespace ZooSQL
{
    partial class History_Work_ShiftUpdate
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
            System.Windows.Forms.Label time_a_lLabel;
            System.Windows.Forms.Label employee_emp_codeLabel;
            System.Windows.Forms.Label work_Shift_arrival_leavingLabel;
            this.dataSet1 = new ZooSQL.DataSet1();
            this.history_Work_ShiftSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.history_Work_ShiftSetTableAdapter = new ZooSQL.DataSet1TableAdapters.History_Work_ShiftSetTableAdapter();
            this.tableAdapterManager = new ZooSQL.DataSet1TableAdapters.TableAdapterManager();
            this.time_a_lDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employee_emp_codeTextBox = new System.Windows.Forms.TextBox();
            this.work_Shift_arrival_leavingTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            time_a_lLabel = new System.Windows.Forms.Label();
            employee_emp_codeLabel = new System.Windows.Forms.Label();
            work_Shift_arrival_leavingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.history_Work_ShiftSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // time_a_lLabel
            // 
            time_a_lLabel.AutoSize = true;
            time_a_lLabel.Location = new System.Drawing.Point(12, 9);
            time_a_lLabel.Name = "time_a_lLabel";
            time_a_lLabel.Size = new System.Drawing.Size(43, 13);
            time_a_lLabel.TabIndex = 1;
            time_a_lLabel.Text = "time a l:";
            // 
            // employee_emp_codeLabel
            // 
            employee_emp_codeLabel.AutoSize = true;
            employee_emp_codeLabel.Location = new System.Drawing.Point(12, 34);
            employee_emp_codeLabel.Name = "employee_emp_codeLabel";
            employee_emp_codeLabel.Size = new System.Drawing.Size(106, 13);
            employee_emp_codeLabel.TabIndex = 3;
            employee_emp_codeLabel.Text = "Employee emp code:";
            // 
            // work_Shift_arrival_leavingLabel
            // 
            work_Shift_arrival_leavingLabel.AutoSize = true;
            work_Shift_arrival_leavingLabel.Location = new System.Drawing.Point(12, 60);
            work_Shift_arrival_leavingLabel.Name = "work_Shift_arrival_leavingLabel";
            work_Shift_arrival_leavingLabel.Size = new System.Drawing.Size(128, 13);
            work_Shift_arrival_leavingLabel.TabIndex = 5;
            work_Shift_arrival_leavingLabel.Text = "Work Shift arrival leaving:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // history_Work_ShiftSetBindingSource
            // 
            this.history_Work_ShiftSetBindingSource.DataMember = "History_Work_ShiftSet";
            this.history_Work_ShiftSetBindingSource.DataSource = this.dataSet1;
            // 
            // history_Work_ShiftSetTableAdapter
            // 
            this.history_Work_ShiftSetTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Feeding_TimeSetTableAdapter = null;
            this.tableAdapterManager.Food_RationSetTableAdapter = null;
            this.tableAdapterManager.FoodSetTableAdapter = null;
            this.tableAdapterManager.Health_StatusSetTableAdapter = null;
            this.tableAdapterManager.History_Work_ShiftSetTableAdapter = this.history_Work_ShiftSetTableAdapter;
            this.tableAdapterManager.JobSetTableAdapter = null;
            this.tableAdapterManager.SpetiesSetTableAdapter = null;
            this.tableAdapterManager.Status_ChangesSetTableAdapter = null;
            this.tableAdapterManager.Ticket_TypeSetTableAdapter = null;
            this.tableAdapterManager.TicketSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ZooSQL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Work_ShiftSetTableAdapter = null;
            this.tableAdapterManager.Zoo_InformationSetTableAdapter = null;
            // 
            // time_a_lDateTimePicker
            // 
            this.time_a_lDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.history_Work_ShiftSetBindingSource, "time_a_l", true));
            this.time_a_lDateTimePicker.Location = new System.Drawing.Point(146, 5);
            this.time_a_lDateTimePicker.Name = "time_a_lDateTimePicker";
            this.time_a_lDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.time_a_lDateTimePicker.TabIndex = 2;
            // 
            // employee_emp_codeTextBox
            // 
            this.employee_emp_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.history_Work_ShiftSetBindingSource, "Employee_emp_code", true));
            this.employee_emp_codeTextBox.Location = new System.Drawing.Point(146, 31);
            this.employee_emp_codeTextBox.Name = "employee_emp_codeTextBox";
            this.employee_emp_codeTextBox.Size = new System.Drawing.Size(200, 20);
            this.employee_emp_codeTextBox.TabIndex = 4;
            // 
            // work_Shift_arrival_leavingTextBox
            // 
            this.work_Shift_arrival_leavingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.history_Work_ShiftSetBindingSource, "Work_Shift_arrival_leaving", true));
            this.work_Shift_arrival_leavingTextBox.Location = new System.Drawing.Point(146, 57);
            this.work_Shift_arrival_leavingTextBox.Name = "work_Shift_arrival_leavingTextBox";
            this.work_Shift_arrival_leavingTextBox.Size = new System.Drawing.Size(200, 20);
            this.work_Shift_arrival_leavingTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 86);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 29);
            this.button1.TabIndex = 7;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // History_Work_ShiftUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 135);
            this.Controls.Add(this.button1);
            this.Controls.Add(time_a_lLabel);
            this.Controls.Add(this.time_a_lDateTimePicker);
            this.Controls.Add(employee_emp_codeLabel);
            this.Controls.Add(this.employee_emp_codeTextBox);
            this.Controls.Add(work_Shift_arrival_leavingLabel);
            this.Controls.Add(this.work_Shift_arrival_leavingTextBox);
            this.Name = "History_Work_ShiftUpdate";
            this.Text = "History_Work_ShiftUpdate";
            this.Load += new System.EventHandler(this.History_Work_ShiftUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.history_Work_ShiftSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource history_Work_ShiftSetBindingSource;
        private DataSet1TableAdapters.History_Work_ShiftSetTableAdapter history_Work_ShiftSetTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker time_a_lDateTimePicker;
        private System.Windows.Forms.TextBox employee_emp_codeTextBox;
        private System.Windows.Forms.TextBox work_Shift_arrival_leavingTextBox;
        private System.Windows.Forms.Button button1;
    }
}