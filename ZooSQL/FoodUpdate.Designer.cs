
namespace ZooSQL
{
    partial class FoodUpdate
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
            System.Windows.Forms.Label food_nameLabel;
            this.dataSet1 = new ZooSQL.DataSet1();
            this.foodSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foodSetTableAdapter = new ZooSQL.DataSet1TableAdapters.FoodSetTableAdapter();
            this.tableAdapterManager = new ZooSQL.DataSet1TableAdapters.TableAdapterManager();
            this.food_nameTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            food_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // food_nameLabel
            // 
            food_nameLabel.AutoSize = true;
            food_nameLabel.Location = new System.Drawing.Point(12, 9);
            food_nameLabel.Name = "food_nameLabel";
            food_nameLabel.Size = new System.Drawing.Size(60, 13);
            food_nameLabel.TabIndex = 1;
            food_nameLabel.Text = "food name:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // foodSetBindingSource
            // 
            this.foodSetBindingSource.DataMember = "FoodSet";
            this.foodSetBindingSource.DataSource = this.dataSet1;
            // 
            // foodSetTableAdapter
            // 
            this.foodSetTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.FoodSetTableAdapter = this.foodSetTableAdapter;
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
            // food_nameTextBox
            // 
            this.food_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.foodSetBindingSource, "food_name", true));
            this.food_nameTextBox.Location = new System.Drawing.Point(78, 6);
            this.food_nameTextBox.Name = "food_nameTextBox";
            this.food_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.food_nameTextBox.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 34);
            this.button1.TabIndex = 3;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FoodUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 91);
            this.Controls.Add(this.button1);
            this.Controls.Add(food_nameLabel);
            this.Controls.Add(this.food_nameTextBox);
            this.Name = "FoodUpdate";
            this.Text = "FoodUpdate";
            this.Load += new System.EventHandler(this.FoodUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource foodSetBindingSource;
        private DataSet1TableAdapters.FoodSetTableAdapter foodSetTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox food_nameTextBox;
        private System.Windows.Forms.Button button1;
    }
}