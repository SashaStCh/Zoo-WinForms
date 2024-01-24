
namespace ZooSQL
{
    partial class Status_ChangesUpdate
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
            System.Windows.Forms.Label status_dateLabel;
            System.Windows.Forms.Label employee_emp_codeLabel;
            System.Windows.Forms.Label cashbox_Status_status_nameLabel;
            System.Windows.Forms.Label cashbox_cashbox_codeLabel;
            this.dataSet1 = new ZooSQL.DataSet1();
            this.status_ChangesSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.status_ChangesSetTableAdapter = new ZooSQL.DataSet1TableAdapters.Status_ChangesSetTableAdapter();
            this.tableAdapterManager = new ZooSQL.DataSet1TableAdapters.TableAdapterManager();
            this.status_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.employee_emp_codeTextBox = new System.Windows.Forms.TextBox();
            this.cashbox_Status_status_nameTextBox = new System.Windows.Forms.TextBox();
            this.cashbox_cashbox_codeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            status_dateLabel = new System.Windows.Forms.Label();
            employee_emp_codeLabel = new System.Windows.Forms.Label();
            cashbox_Status_status_nameLabel = new System.Windows.Forms.Label();
            cashbox_cashbox_codeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_ChangesSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // status_dateLabel
            // 
            status_dateLabel.AutoSize = true;
            status_dateLabel.Location = new System.Drawing.Point(12, 9);
            status_dateLabel.Name = "status_dateLabel";
            status_dateLabel.Size = new System.Drawing.Size(62, 13);
            status_dateLabel.TabIndex = 1;
            status_dateLabel.Text = "status date:";
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
            // cashbox_Status_status_nameLabel
            // 
            cashbox_Status_status_nameLabel.AutoSize = true;
            cashbox_Status_status_nameLabel.Location = new System.Drawing.Point(12, 60);
            cashbox_Status_status_nameLabel.Name = "cashbox_Status_status_nameLabel";
            cashbox_Status_status_nameLabel.Size = new System.Drawing.Size(144, 13);
            cashbox_Status_status_nameLabel.TabIndex = 5;
            cashbox_Status_status_nameLabel.Text = "Cashbox Status status name:";
            // 
            // cashbox_cashbox_codeLabel
            // 
            cashbox_cashbox_codeLabel.AutoSize = true;
            cashbox_cashbox_codeLabel.Location = new System.Drawing.Point(12, 86);
            cashbox_cashbox_codeLabel.Name = "cashbox_cashbox_codeLabel";
            cashbox_cashbox_codeLabel.Size = new System.Drawing.Size(121, 13);
            cashbox_cashbox_codeLabel.TabIndex = 7;
            cashbox_cashbox_codeLabel.Text = "Cashbox cashbox code:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // status_ChangesSetBindingSource
            // 
            this.status_ChangesSetBindingSource.DataMember = "Status_ChangesSet";
            this.status_ChangesSetBindingSource.DataSource = this.dataSet1;
            // 
            // status_ChangesSetTableAdapter
            // 
            this.status_ChangesSetTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.History_Work_ShiftSetTableAdapter = null;
            this.tableAdapterManager.JobSetTableAdapter = null;
            this.tableAdapterManager.SpetiesSetTableAdapter = null;
            this.tableAdapterManager.Status_ChangesSetTableAdapter = this.status_ChangesSetTableAdapter;
            this.tableAdapterManager.Ticket_TypeSetTableAdapter = null;
            this.tableAdapterManager.TicketSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ZooSQL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Work_ShiftSetTableAdapter = null;
            this.tableAdapterManager.Zoo_InformationSetTableAdapter = null;
            // 
            // status_dateDateTimePicker
            // 
            this.status_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.status_ChangesSetBindingSource, "status_date", true));
            this.status_dateDateTimePicker.Location = new System.Drawing.Point(162, 5);
            this.status_dateDateTimePicker.Name = "status_dateDateTimePicker";
            this.status_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.status_dateDateTimePicker.TabIndex = 2;
            // 
            // employee_emp_codeTextBox
            // 
            this.employee_emp_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.status_ChangesSetBindingSource, "Employee_emp_code", true));
            this.employee_emp_codeTextBox.Location = new System.Drawing.Point(162, 31);
            this.employee_emp_codeTextBox.Name = "employee_emp_codeTextBox";
            this.employee_emp_codeTextBox.Size = new System.Drawing.Size(200, 20);
            this.employee_emp_codeTextBox.TabIndex = 4;
            // 
            // cashbox_Status_status_nameTextBox
            // 
            this.cashbox_Status_status_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.status_ChangesSetBindingSource, "Cashbox_Status_status_name", true));
            this.cashbox_Status_status_nameTextBox.Location = new System.Drawing.Point(162, 57);
            this.cashbox_Status_status_nameTextBox.Name = "cashbox_Status_status_nameTextBox";
            this.cashbox_Status_status_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.cashbox_Status_status_nameTextBox.TabIndex = 6;
            // 
            // cashbox_cashbox_codeTextBox
            // 
            this.cashbox_cashbox_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.status_ChangesSetBindingSource, "Cashbox_cashbox_code", true));
            this.cashbox_cashbox_codeTextBox.Location = new System.Drawing.Point(162, 83);
            this.cashbox_cashbox_codeTextBox.Name = "cashbox_cashbox_codeTextBox";
            this.cashbox_cashbox_codeTextBox.Size = new System.Drawing.Size(200, 20);
            this.cashbox_cashbox_codeTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 118);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 35);
            this.button1.TabIndex = 9;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Status_ChangesUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 173);
            this.Controls.Add(this.button1);
            this.Controls.Add(status_dateLabel);
            this.Controls.Add(this.status_dateDateTimePicker);
            this.Controls.Add(employee_emp_codeLabel);
            this.Controls.Add(this.employee_emp_codeTextBox);
            this.Controls.Add(cashbox_Status_status_nameLabel);
            this.Controls.Add(this.cashbox_Status_status_nameTextBox);
            this.Controls.Add(cashbox_cashbox_codeLabel);
            this.Controls.Add(this.cashbox_cashbox_codeTextBox);
            this.Name = "Status_ChangesUpdate";
            this.Text = "Status_ChangesUpdate";
            this.Load += new System.EventHandler(this.Status_ChangesUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.status_ChangesSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource status_ChangesSetBindingSource;
        private DataSet1TableAdapters.Status_ChangesSetTableAdapter status_ChangesSetTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker status_dateDateTimePicker;
        private System.Windows.Forms.TextBox employee_emp_codeTextBox;
        private System.Windows.Forms.TextBox cashbox_Status_status_nameTextBox;
        private System.Windows.Forms.TextBox cashbox_cashbox_codeTextBox;
        private System.Windows.Forms.Button button1;
    }
}