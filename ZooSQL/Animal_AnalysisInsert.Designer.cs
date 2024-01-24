
namespace ZooSQL
{
    partial class Animal_AnalysisInsert
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
            System.Windows.Forms.Label analysis_dateLabel;
            System.Windows.Forms.Label weightLabel;
            System.Windows.Forms.Label animal_animal_codeLabel;
            System.Windows.Forms.Label health_Status_h_statusLabel;
            this.dataSet1 = new ZooSQL.DataSet1();
            this.animal_AnalysisSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animal_AnalysisSetTableAdapter = new ZooSQL.DataSet1TableAdapters.Animal_AnalysisSetTableAdapter();
            this.tableAdapterManager = new ZooSQL.DataSet1TableAdapters.TableAdapterManager();
            this.analysis_dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.animal_animal_codeTextBox = new System.Windows.Forms.TextBox();
            this.health_Status_h_statusTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            analysis_dateLabel = new System.Windows.Forms.Label();
            weightLabel = new System.Windows.Forms.Label();
            animal_animal_codeLabel = new System.Windows.Forms.Label();
            health_Status_h_statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal_AnalysisSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // analysis_dateLabel
            // 
            analysis_dateLabel.AutoSize = true;
            analysis_dateLabel.Location = new System.Drawing.Point(12, 9);
            analysis_dateLabel.Name = "analysis_dateLabel";
            analysis_dateLabel.Size = new System.Drawing.Size(33, 13);
            analysis_dateLabel.TabIndex = 3;
            analysis_dateLabel.Text = "Дата";
            // 
            // weightLabel
            // 
            weightLabel.AutoSize = true;
            weightLabel.Location = new System.Drawing.Point(12, 34);
            weightLabel.Name = "weightLabel";
            weightLabel.Size = new System.Drawing.Size(26, 13);
            weightLabel.TabIndex = 5;
            weightLabel.Text = "Вес";
            // 
            // animal_animal_codeLabel
            // 
            animal_animal_codeLabel.AutoSize = true;
            animal_animal_codeLabel.Location = new System.Drawing.Point(12, 60);
            animal_animal_codeLabel.Name = "animal_animal_codeLabel";
            animal_animal_codeLabel.Size = new System.Drawing.Size(83, 13);
            animal_animal_codeLabel.TabIndex = 7;
            animal_animal_codeLabel.Text = "Код животного";
            // 
            // health_Status_h_statusLabel
            // 
            health_Status_h_statusLabel.AutoSize = true;
            health_Status_h_statusLabel.Location = new System.Drawing.Point(12, 86);
            health_Status_h_statusLabel.Name = "health_Status_h_statusLabel";
            health_Status_h_statusLabel.Size = new System.Drawing.Size(112, 13);
            health_Status_h_statusLabel.TabIndex = 9;
            health_Status_h_statusLabel.Text = "Состояние здоровья";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animal_AnalysisSetBindingSource
            // 
            this.animal_AnalysisSetBindingSource.DataMember = "Animal_AnalysisSet";
            this.animal_AnalysisSetBindingSource.DataSource = this.dataSet1;
            // 
            // animal_AnalysisSetTableAdapter
            // 
            this.animal_AnalysisSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Animal_AnalysisSetTableAdapter = this.animal_AnalysisSetTableAdapter;
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
            this.tableAdapterManager.Status_ChangesSetTableAdapter = null;
            this.tableAdapterManager.Ticket_TypeSetTableAdapter = null;
            this.tableAdapterManager.TicketSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ZooSQL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Work_ShiftSetTableAdapter = null;
            this.tableAdapterManager.Zoo_InformationSetTableAdapter = null;
            // 
            // analysis_dateDateTimePicker
            // 
            this.analysis_dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.animal_AnalysisSetBindingSource, "analysis_date", true));
            this.analysis_dateDateTimePicker.Location = new System.Drawing.Point(132, 5);
            this.analysis_dateDateTimePicker.Name = "analysis_dateDateTimePicker";
            this.analysis_dateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.analysis_dateDateTimePicker.TabIndex = 4;
            // 
            // weightTextBox
            // 
            this.weightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animal_AnalysisSetBindingSource, "weight", true));
            this.weightTextBox.Location = new System.Drawing.Point(132, 31);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(200, 20);
            this.weightTextBox.TabIndex = 6;
            // 
            // animal_animal_codeTextBox
            // 
            this.animal_animal_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animal_AnalysisSetBindingSource, "Animal_animal_code", true));
            this.animal_animal_codeTextBox.Location = new System.Drawing.Point(132, 57);
            this.animal_animal_codeTextBox.Name = "animal_animal_codeTextBox";
            this.animal_animal_codeTextBox.Size = new System.Drawing.Size(200, 20);
            this.animal_animal_codeTextBox.TabIndex = 8;
            // 
            // health_Status_h_statusTextBox
            // 
            this.health_Status_h_statusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animal_AnalysisSetBindingSource, "Health_Status_h_status", true));
            this.health_Status_h_statusTextBox.Location = new System.Drawing.Point(132, 83);
            this.health_Status_h_statusTextBox.Name = "health_Status_h_statusTextBox";
            this.health_Status_h_statusTextBox.Size = new System.Drawing.Size(200, 20);
            this.health_Status_h_statusTextBox.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Animal_AnalysisInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 209);
            this.Controls.Add(this.button1);
            this.Controls.Add(analysis_dateLabel);
            this.Controls.Add(this.analysis_dateDateTimePicker);
            this.Controls.Add(weightLabel);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(animal_animal_codeLabel);
            this.Controls.Add(this.animal_animal_codeTextBox);
            this.Controls.Add(health_Status_h_statusLabel);
            this.Controls.Add(this.health_Status_h_statusTextBox);
            this.Name = "Animal_AnalysisInsert";
            this.Text = "Анализы";
            this.Load += new System.EventHandler(this.Animal_AnalysisInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animal_AnalysisSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource animal_AnalysisSetBindingSource;
        private DataSet1TableAdapters.Animal_AnalysisSetTableAdapter animal_AnalysisSetTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DateTimePicker analysis_dateDateTimePicker;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.TextBox animal_animal_codeTextBox;
        private System.Windows.Forms.TextBox health_Status_h_statusTextBox;
        private System.Windows.Forms.Button button1;
    }
}