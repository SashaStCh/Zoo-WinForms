
namespace ZooSQL
{
    partial class TicketUpdate
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
            System.Windows.Forms.Label ticket_codeLabel;
            System.Windows.Forms.Label date_of_purchaseLabel;
            System.Windows.Forms.Label cashbox_cashbox_codeLabel;
            System.Windows.Forms.Label ticket_Type_t_typeLabel;
            this.dataSet1 = new ZooSQL.DataSet1();
            this.ticketSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ticketSetTableAdapter = new ZooSQL.DataSet1TableAdapters.TicketSetTableAdapter();
            this.tableAdapterManager = new ZooSQL.DataSet1TableAdapters.TableAdapterManager();
            this.ticket_codeTextBox = new System.Windows.Forms.TextBox();
            this.date_of_purchaseDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cashbox_cashbox_codeTextBox = new System.Windows.Forms.TextBox();
            this.ticket_Type_t_typeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ticket_codeLabel = new System.Windows.Forms.Label();
            date_of_purchaseLabel = new System.Windows.Forms.Label();
            cashbox_cashbox_codeLabel = new System.Windows.Forms.Label();
            ticket_Type_t_typeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ticket_codeLabel
            // 
            ticket_codeLabel.AutoSize = true;
            ticket_codeLabel.Location = new System.Drawing.Point(12, 9);
            ticket_codeLabel.Name = "ticket_codeLabel";
            ticket_codeLabel.Size = new System.Drawing.Size(63, 13);
            ticket_codeLabel.TabIndex = 1;
            ticket_codeLabel.Text = "ticket code:";
            // 
            // date_of_purchaseLabel
            // 
            date_of_purchaseLabel.AutoSize = true;
            date_of_purchaseLabel.Location = new System.Drawing.Point(12, 36);
            date_of_purchaseLabel.Name = "date_of_purchaseLabel";
            date_of_purchaseLabel.Size = new System.Drawing.Size(90, 13);
            date_of_purchaseLabel.TabIndex = 3;
            date_of_purchaseLabel.Text = "date of purchase:";
            // 
            // cashbox_cashbox_codeLabel
            // 
            cashbox_cashbox_codeLabel.AutoSize = true;
            cashbox_cashbox_codeLabel.Location = new System.Drawing.Point(12, 61);
            cashbox_cashbox_codeLabel.Name = "cashbox_cashbox_codeLabel";
            cashbox_cashbox_codeLabel.Size = new System.Drawing.Size(121, 13);
            cashbox_cashbox_codeLabel.TabIndex = 5;
            cashbox_cashbox_codeLabel.Text = "Cashbox cashbox code:";
            // 
            // ticket_Type_t_typeLabel
            // 
            ticket_Type_t_typeLabel.AutoSize = true;
            ticket_Type_t_typeLabel.Location = new System.Drawing.Point(12, 87);
            ticket_Type_t_typeLabel.Name = "ticket_Type_t_typeLabel";
            ticket_Type_t_typeLabel.Size = new System.Drawing.Size(96, 13);
            ticket_Type_t_typeLabel.TabIndex = 7;
            ticket_Type_t_typeLabel.Text = "Ticket Type t type:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ticketSetBindingSource
            // 
            this.ticketSetBindingSource.DataMember = "TicketSet";
            this.ticketSetBindingSource.DataSource = this.dataSet1;
            // 
            // ticketSetTableAdapter
            // 
            this.ticketSetTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.TicketSetTableAdapter = this.ticketSetTableAdapter;
            this.tableAdapterManager.UpdateOrder = ZooSQL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Work_ShiftSetTableAdapter = null;
            this.tableAdapterManager.Zoo_InformationSetTableAdapter = null;
            // 
            // ticket_codeTextBox
            // 
            this.ticket_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketSetBindingSource, "ticket_code", true));
            this.ticket_codeTextBox.Location = new System.Drawing.Point(139, 6);
            this.ticket_codeTextBox.Name = "ticket_codeTextBox";
            this.ticket_codeTextBox.Size = new System.Drawing.Size(200, 20);
            this.ticket_codeTextBox.TabIndex = 2;
            // 
            // date_of_purchaseDateTimePicker
            // 
            this.date_of_purchaseDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.ticketSetBindingSource, "date_of_purchase", true));
            this.date_of_purchaseDateTimePicker.Location = new System.Drawing.Point(139, 32);
            this.date_of_purchaseDateTimePicker.Name = "date_of_purchaseDateTimePicker";
            this.date_of_purchaseDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_of_purchaseDateTimePicker.TabIndex = 4;
            // 
            // cashbox_cashbox_codeTextBox
            // 
            this.cashbox_cashbox_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketSetBindingSource, "Cashbox_cashbox_code", true));
            this.cashbox_cashbox_codeTextBox.Location = new System.Drawing.Point(139, 58);
            this.cashbox_cashbox_codeTextBox.Name = "cashbox_cashbox_codeTextBox";
            this.cashbox_cashbox_codeTextBox.Size = new System.Drawing.Size(200, 20);
            this.cashbox_cashbox_codeTextBox.TabIndex = 6;
            // 
            // ticket_Type_t_typeTextBox
            // 
            this.ticket_Type_t_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ticketSetBindingSource, "Ticket_Type_t_type", true));
            this.ticket_Type_t_typeTextBox.Location = new System.Drawing.Point(139, 84);
            this.ticket_Type_t_typeTextBox.Name = "ticket_Type_t_typeTextBox";
            this.ticket_Type_t_typeTextBox.Size = new System.Drawing.Size(200, 20);
            this.ticket_Type_t_typeTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 116);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(109, 36);
            this.button1.TabIndex = 9;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TicketUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 172);
            this.Controls.Add(this.button1);
            this.Controls.Add(ticket_codeLabel);
            this.Controls.Add(this.ticket_codeTextBox);
            this.Controls.Add(date_of_purchaseLabel);
            this.Controls.Add(this.date_of_purchaseDateTimePicker);
            this.Controls.Add(cashbox_cashbox_codeLabel);
            this.Controls.Add(this.cashbox_cashbox_codeTextBox);
            this.Controls.Add(ticket_Type_t_typeLabel);
            this.Controls.Add(this.ticket_Type_t_typeTextBox);
            this.Name = "TicketUpdate";
            this.Text = "TicketUpdate";
            this.Load += new System.EventHandler(this.TicketUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ticketSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource ticketSetBindingSource;
        private DataSet1TableAdapters.TicketSetTableAdapter ticketSetTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox ticket_codeTextBox;
        private System.Windows.Forms.DateTimePicker date_of_purchaseDateTimePicker;
        private System.Windows.Forms.TextBox cashbox_cashbox_codeTextBox;
        private System.Windows.Forms.TextBox ticket_Type_t_typeTextBox;
        private System.Windows.Forms.Button button1;
    }
}