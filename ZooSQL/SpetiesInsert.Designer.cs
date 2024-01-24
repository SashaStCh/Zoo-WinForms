
namespace ZooSQL
{
    partial class SpetiesInsert
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
            System.Windows.Forms.Label species_nameLabel;
            System.Windows.Forms.Label name_in_latinLabel;
            System.Windows.Forms.Label descriptionLabel;
            this.dataSet1 = new ZooSQL.DataSet1();
            this.spetiesSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.spetiesSetTableAdapter = new ZooSQL.DataSet1TableAdapters.SpetiesSetTableAdapter();
            this.tableAdapterManager = new ZooSQL.DataSet1TableAdapters.TableAdapterManager();
            this.species_nameTextBox = new System.Windows.Forms.TextBox();
            this.name_in_latinTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            species_nameLabel = new System.Windows.Forms.Label();
            name_in_latinLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spetiesSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // spetiesSetBindingSource
            // 
            this.spetiesSetBindingSource.DataMember = "SpetiesSet";
            this.spetiesSetBindingSource.DataSource = this.dataSet1;
            // 
            // spetiesSetTableAdapter
            // 
            this.spetiesSetTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.SpetiesSetTableAdapter = this.spetiesSetTableAdapter;
            this.tableAdapterManager.Status_ChangesSetTableAdapter = null;
            this.tableAdapterManager.Ticket_TypeSetTableAdapter = null;
            this.tableAdapterManager.TicketSetTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = ZooSQL.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Work_ShiftSetTableAdapter = null;
            this.tableAdapterManager.Zoo_InformationSetTableAdapter = null;
            // 
            // species_nameLabel
            // 
            species_nameLabel.AutoSize = true;
            species_nameLabel.Location = new System.Drawing.Point(12, 9);
            species_nameLabel.Name = "species_nameLabel";
            species_nameLabel.Size = new System.Drawing.Size(75, 13);
            species_nameLabel.TabIndex = 1;
            species_nameLabel.Text = "species name:";
            // 
            // species_nameTextBox
            // 
            this.species_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spetiesSetBindingSource, "species_name", true));
            this.species_nameTextBox.Location = new System.Drawing.Point(93, 6);
            this.species_nameTextBox.Name = "species_nameTextBox";
            this.species_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.species_nameTextBox.TabIndex = 2;
            // 
            // name_in_latinLabel
            // 
            name_in_latinLabel.AutoSize = true;
            name_in_latinLabel.Location = new System.Drawing.Point(12, 35);
            name_in_latinLabel.Name = "name_in_latinLabel";
            name_in_latinLabel.Size = new System.Drawing.Size(69, 13);
            name_in_latinLabel.TabIndex = 3;
            name_in_latinLabel.Text = "name in latin:";
            // 
            // name_in_latinTextBox
            // 
            this.name_in_latinTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spetiesSetBindingSource, "name_in_latin", true));
            this.name_in_latinTextBox.Location = new System.Drawing.Point(93, 32);
            this.name_in_latinTextBox.Name = "name_in_latinTextBox";
            this.name_in_latinTextBox.Size = new System.Drawing.Size(100, 20);
            this.name_in_latinTextBox.TabIndex = 4;
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(12, 61);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(61, 13);
            descriptionLabel.TabIndex = 5;
            descriptionLabel.Text = "description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.spetiesSetBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(93, 58);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(100, 20);
            this.descriptionTextBox.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SpetiesInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(265, 163);
            this.Controls.Add(this.button1);
            this.Controls.Add(species_nameLabel);
            this.Controls.Add(this.species_nameTextBox);
            this.Controls.Add(name_in_latinLabel);
            this.Controls.Add(this.name_in_latinTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Name = "SpetiesInsert";
            this.Text = "SpetiesInsert";
            this.Load += new System.EventHandler(this.SpetiesInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spetiesSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource spetiesSetBindingSource;
        private DataSet1TableAdapters.SpetiesSetTableAdapter spetiesSetTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox species_nameTextBox;
        private System.Windows.Forms.TextBox name_in_latinTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Button button1;
    }
}