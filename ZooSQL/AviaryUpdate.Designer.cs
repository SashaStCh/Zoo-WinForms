
namespace ZooSQL
{
    partial class AviaryUpdate
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
            System.Windows.Forms.Label aviary_codeLabel;
            System.Windows.Forms.Label aviary_typeLabel;
            System.Windows.Forms.Label areaLabel;
            this.dataSet1 = new ZooSQL.DataSet1();
            this.aviarySetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aviarySetTableAdapter = new ZooSQL.DataSet1TableAdapters.AviarySetTableAdapter();
            this.tableAdapterManager = new ZooSQL.DataSet1TableAdapters.TableAdapterManager();
            this.aviary_codeTextBox = new System.Windows.Forms.TextBox();
            this.aviary_typeTextBox = new System.Windows.Forms.TextBox();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            aviary_codeLabel = new System.Windows.Forms.Label();
            aviary_typeLabel = new System.Windows.Forms.Label();
            areaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aviarySetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // aviary_codeLabel
            // 
            aviary_codeLabel.AutoSize = true;
            aviary_codeLabel.Location = new System.Drawing.Point(14, 15);
            aviary_codeLabel.Name = "aviary_codeLabel";
            aviary_codeLabel.Size = new System.Drawing.Size(65, 13);
            aviary_codeLabel.TabIndex = 1;
            aviary_codeLabel.Text = "aviary code:";
            // 
            // aviary_typeLabel
            // 
            aviary_typeLabel.AutoSize = true;
            aviary_typeLabel.Location = new System.Drawing.Point(14, 41);
            aviary_typeLabel.Name = "aviary_typeLabel";
            aviary_typeLabel.Size = new System.Drawing.Size(61, 13);
            aviary_typeLabel.TabIndex = 3;
            aviary_typeLabel.Text = "aviary type:";
            // 
            // areaLabel
            // 
            areaLabel.AutoSize = true;
            areaLabel.Location = new System.Drawing.Point(14, 67);
            areaLabel.Name = "areaLabel";
            areaLabel.Size = new System.Drawing.Size(31, 13);
            areaLabel.TabIndex = 5;
            areaLabel.Text = "area:";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // aviarySetBindingSource
            // 
            this.aviarySetBindingSource.DataMember = "AviarySet";
            this.aviarySetBindingSource.DataSource = this.dataSet1;
            // 
            // aviarySetTableAdapter
            // 
            this.aviarySetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Animal_AnalysisSetTableAdapter = null;
            this.tableAdapterManager.AnimalSetTableAdapter = null;
            this.tableAdapterManager.AuthorizationSetTableAdapter = null;
            this.tableAdapterManager.AviarySetTableAdapter = this.aviarySetTableAdapter;
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
            // aviary_codeTextBox
            // 
            this.aviary_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aviarySetBindingSource, "aviary_code", true));
            this.aviary_codeTextBox.Location = new System.Drawing.Point(85, 12);
            this.aviary_codeTextBox.Name = "aviary_codeTextBox";
            this.aviary_codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.aviary_codeTextBox.TabIndex = 2;
            // 
            // aviary_typeTextBox
            // 
            this.aviary_typeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aviarySetBindingSource, "aviary_type", true));
            this.aviary_typeTextBox.Location = new System.Drawing.Point(85, 38);
            this.aviary_typeTextBox.Name = "aviary_typeTextBox";
            this.aviary_typeTextBox.Size = new System.Drawing.Size(100, 20);
            this.aviary_typeTextBox.TabIndex = 4;
            // 
            // areaTextBox
            // 
            this.areaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.aviarySetBindingSource, "area", true));
            this.areaTextBox.Location = new System.Drawing.Point(85, 64);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(100, 20);
            this.areaTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(17, 100);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 39);
            this.button1.TabIndex = 7;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AviaryUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 181);
            this.Controls.Add(this.button1);
            this.Controls.Add(aviary_codeLabel);
            this.Controls.Add(this.aviary_codeTextBox);
            this.Controls.Add(aviary_typeLabel);
            this.Controls.Add(this.aviary_typeTextBox);
            this.Controls.Add(areaLabel);
            this.Controls.Add(this.areaTextBox);
            this.Name = "AviaryUpdate";
            this.Text = "AviaryUpdate";
            this.Load += new System.EventHandler(this.AviaryUpdate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aviarySetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource aviarySetBindingSource;
        private DataSet1TableAdapters.AviarySetTableAdapter aviarySetTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox aviary_codeTextBox;
        private System.Windows.Forms.TextBox aviary_typeTextBox;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.Button button1;
    }
}