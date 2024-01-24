
namespace ZooSQL
{
    partial class Zoo_InformationUpdate
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
            System.Windows.Forms.Label zoo_nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label zoo_areaLabel;
            System.Windows.Forms.Label opening_timeLabel;
            System.Windows.Forms.Label closing_timeLabel;
            System.Windows.Forms.Label hotline_phoneLabel;
            System.Windows.Forms.Label zoo_historyLabel;
            this.dataSet1 = new ZooSQL.DataSet1();
            this.zoo_InformationSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zoo_InformationSetTableAdapter = new ZooSQL.DataSet1TableAdapters.Zoo_InformationSetTableAdapter();
            this.tableAdapterManager = new ZooSQL.DataSet1TableAdapters.TableAdapterManager();
            this.zoo_nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.zoo_areaTextBox = new System.Windows.Forms.TextBox();
            this.opening_timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.closing_timeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.hotline_phoneTextBox = new System.Windows.Forms.TextBox();
            this.zoo_historyTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            zoo_nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            zoo_areaLabel = new System.Windows.Forms.Label();
            opening_timeLabel = new System.Windows.Forms.Label();
            closing_timeLabel = new System.Windows.Forms.Label();
            hotline_phoneLabel = new System.Windows.Forms.Label();
            zoo_historyLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoo_InformationSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // zoo_nameLabel
            // 
            zoo_nameLabel.AutoSize = true;
            zoo_nameLabel.Location = new System.Drawing.Point(12, 9);
            zoo_nameLabel.Name = "zoo_nameLabel";
            zoo_nameLabel.Size = new System.Drawing.Size(56, 13);
            zoo_nameLabel.TabIndex = 1;
            zoo_nameLabel.Text = "zoo name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 35);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(47, 13);
            addressLabel.TabIndex = 3;
            addressLabel.Text = "address:";
            // 
            // zoo_areaLabel
            // 
            zoo_areaLabel.AutoSize = true;
            zoo_areaLabel.Location = new System.Drawing.Point(12, 61);
            zoo_areaLabel.Name = "zoo_areaLabel";
            zoo_areaLabel.Size = new System.Drawing.Size(51, 13);
            zoo_areaLabel.TabIndex = 5;
            zoo_areaLabel.Text = "zoo area:";
            // 
            // opening_timeLabel
            // 
            opening_timeLabel.AutoSize = true;
            opening_timeLabel.Location = new System.Drawing.Point(12, 88);
            opening_timeLabel.Name = "opening_timeLabel";
            opening_timeLabel.Size = new System.Drawing.Size(70, 13);
            opening_timeLabel.TabIndex = 7;
            opening_timeLabel.Text = "opening time:";
            // 
            // closing_timeLabel
            // 
            closing_timeLabel.AutoSize = true;
            closing_timeLabel.Location = new System.Drawing.Point(12, 114);
            closing_timeLabel.Name = "closing_timeLabel";
            closing_timeLabel.Size = new System.Drawing.Size(65, 13);
            closing_timeLabel.TabIndex = 9;
            closing_timeLabel.Text = "closing time:";
            // 
            // hotline_phoneLabel
            // 
            hotline_phoneLabel.AutoSize = true;
            hotline_phoneLabel.Location = new System.Drawing.Point(12, 139);
            hotline_phoneLabel.Name = "hotline_phoneLabel";
            hotline_phoneLabel.Size = new System.Drawing.Size(74, 13);
            hotline_phoneLabel.TabIndex = 11;
            hotline_phoneLabel.Text = "hotline phone:";
            // 
            // zoo_historyLabel
            // 
            zoo_historyLabel.AutoSize = true;
            zoo_historyLabel.Location = new System.Drawing.Point(12, 165);
            zoo_historyLabel.Name = "zoo_historyLabel";
            zoo_historyLabel.Size = new System.Drawing.Size(60, 13);
            zoo_historyLabel.TabIndex = 13;
            zoo_historyLabel.Text = "zoo history:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zoo_InformationSetBindingSource
            // 
            this.zoo_InformationSetBindingSource.DataMember = "Zoo_InformationSet";
            this.zoo_InformationSetBindingSource.DataSource = this.dataSet1;
            // 
            // zoo_InformationSetTableAdapter
            // 
            this.zoo_InformationSetTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.Status_ChangesSetTableAdapter = null;
            this.tableAdapterManager.Ticket_TypeSetTableAdapter = null;
            this.tableAdapterManager.TicketSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ZooSQL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Work_ShiftSetTableAdapter = null;
            this.tableAdapterManager.Zoo_InformationSetTableAdapter = this.zoo_InformationSetTableAdapter;
            // 
            // zoo_nameTextBox
            // 
            this.zoo_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zoo_InformationSetBindingSource, "zoo_name", true));
            this.zoo_nameTextBox.Location = new System.Drawing.Point(92, 6);
            this.zoo_nameTextBox.Name = "zoo_nameTextBox";
            this.zoo_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.zoo_nameTextBox.TabIndex = 2;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zoo_InformationSetBindingSource, "address", true));
            this.addressTextBox.Location = new System.Drawing.Point(92, 32);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.addressTextBox.TabIndex = 4;
            // 
            // zoo_areaTextBox
            // 
            this.zoo_areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zoo_InformationSetBindingSource, "zoo_area", true));
            this.zoo_areaTextBox.Location = new System.Drawing.Point(92, 58);
            this.zoo_areaTextBox.Name = "zoo_areaTextBox";
            this.zoo_areaTextBox.Size = new System.Drawing.Size(200, 20);
            this.zoo_areaTextBox.TabIndex = 6;
            // 
            // opening_timeDateTimePicker
            // 
            this.opening_timeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zoo_InformationSetBindingSource, "opening_time", true));
            this.opening_timeDateTimePicker.Location = new System.Drawing.Point(92, 84);
            this.opening_timeDateTimePicker.Name = "opening_timeDateTimePicker";
            this.opening_timeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.opening_timeDateTimePicker.TabIndex = 8;
            // 
            // closing_timeDateTimePicker
            // 
            this.closing_timeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.zoo_InformationSetBindingSource, "closing_time", true));
            this.closing_timeDateTimePicker.Location = new System.Drawing.Point(92, 110);
            this.closing_timeDateTimePicker.Name = "closing_timeDateTimePicker";
            this.closing_timeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.closing_timeDateTimePicker.TabIndex = 10;
            // 
            // hotline_phoneTextBox
            // 
            this.hotline_phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zoo_InformationSetBindingSource, "hotline_phone", true));
            this.hotline_phoneTextBox.Location = new System.Drawing.Point(92, 136);
            this.hotline_phoneTextBox.Name = "hotline_phoneTextBox";
            this.hotline_phoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.hotline_phoneTextBox.TabIndex = 12;
            // 
            // zoo_historyTextBox
            // 
            this.zoo_historyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.zoo_InformationSetBindingSource, "zoo_history", true));
            this.zoo_historyTextBox.Location = new System.Drawing.Point(92, 162);
            this.zoo_historyTextBox.Name = "zoo_historyTextBox";
            this.zoo_historyTextBox.Size = new System.Drawing.Size(200, 20);
            this.zoo_historyTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 198);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(127, 28);
            this.button1.TabIndex = 15;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zoo_InformationUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 246);
            this.Controls.Add(this.button1);
            this.Controls.Add(zoo_nameLabel);
            this.Controls.Add(this.zoo_nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(zoo_areaLabel);
            this.Controls.Add(this.zoo_areaTextBox);
            this.Controls.Add(opening_timeLabel);
            this.Controls.Add(this.opening_timeDateTimePicker);
            this.Controls.Add(closing_timeLabel);
            this.Controls.Add(this.closing_timeDateTimePicker);
            this.Controls.Add(hotline_phoneLabel);
            this.Controls.Add(this.hotline_phoneTextBox);
            this.Controls.Add(zoo_historyLabel);
            this.Controls.Add(this.zoo_historyTextBox);
            this.Name = "Zoo_InformationUpdate";
            this.Text = "Zoo_InformationUpdate";
            this.Load += new System.EventHandler(this.Zoo_InformationUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zoo_InformationSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource zoo_InformationSetBindingSource;
        private DataSet1TableAdapters.Zoo_InformationSetTableAdapter zoo_InformationSetTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox zoo_nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox zoo_areaTextBox;
        private System.Windows.Forms.DateTimePicker opening_timeDateTimePicker;
        private System.Windows.Forms.DateTimePicker closing_timeDateTimePicker;
        private System.Windows.Forms.TextBox hotline_phoneTextBox;
        private System.Windows.Forms.TextBox zoo_historyTextBox;
        private System.Windows.Forms.Button button1;
    }
}