
namespace ZooSQL
{
    partial class AnimalInsert
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
            System.Windows.Forms.Label animal_nameLabel;
            System.Windows.Forms.Label animal_genderLabel;
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label date_of_birthLabel;
            System.Windows.Forms.Label speties_species_nameLabel;
            System.Windows.Forms.Label aviary_aviary_codeLabel;
            this.dataSet1 = new ZooSQL.DataSet1();
            this.animalSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.animalSetTableAdapter = new ZooSQL.DataSet1TableAdapters.AnimalSetTableAdapter();
            this.tableAdapterManager = new ZooSQL.DataSet1TableAdapters.TableAdapterManager();
            this.animal_nameTextBox = new System.Windows.Forms.TextBox();
            this.animal_genderTextBox = new System.Windows.Forms.TextBox();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.date_of_birthDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.speties_species_nameTextBox = new System.Windows.Forms.TextBox();
            this.aviary_aviary_codeTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            animal_nameLabel = new System.Windows.Forms.Label();
            animal_genderLabel = new System.Windows.Forms.Label();
            colorLabel = new System.Windows.Forms.Label();
            date_of_birthLabel = new System.Windows.Forms.Label();
            speties_species_nameLabel = new System.Windows.Forms.Label();
            aviary_aviary_codeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // animal_nameLabel
            // 
            animal_nameLabel.AutoSize = true;
            animal_nameLabel.Location = new System.Drawing.Point(12, 9);
            animal_nameLabel.Name = "animal_nameLabel";
            animal_nameLabel.Size = new System.Drawing.Size(29, 13);
            animal_nameLabel.TabIndex = 3;
            animal_nameLabel.Text = "Имя";
            // 
            // animal_genderLabel
            // 
            animal_genderLabel.AutoSize = true;
            animal_genderLabel.Location = new System.Drawing.Point(12, 35);
            animal_genderLabel.Name = "animal_genderLabel";
            animal_genderLabel.Size = new System.Drawing.Size(27, 13);
            animal_genderLabel.TabIndex = 5;
            animal_genderLabel.Text = "Пол";
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(12, 61);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(32, 13);
            colorLabel.TabIndex = 7;
            colorLabel.Text = "Цвет";
            // 
            // date_of_birthLabel
            // 
            date_of_birthLabel.AutoSize = true;
            date_of_birthLabel.Location = new System.Drawing.Point(12, 88);
            date_of_birthLabel.Name = "date_of_birthLabel";
            date_of_birthLabel.Size = new System.Drawing.Size(86, 13);
            date_of_birthLabel.TabIndex = 9;
            date_of_birthLabel.Text = "Дата рождения";
            // 
            // speties_species_nameLabel
            // 
            speties_species_nameLabel.AutoSize = true;
            speties_species_nameLabel.Location = new System.Drawing.Point(12, 113);
            speties_species_nameLabel.Name = "speties_species_nameLabel";
            speties_species_nameLabel.Size = new System.Drawing.Size(26, 13);
            speties_species_nameLabel.TabIndex = 11;
            speties_species_nameLabel.Text = "Вид";
            // 
            // aviary_aviary_codeLabel
            // 
            aviary_aviary_codeLabel.AutoSize = true;
            aviary_aviary_codeLabel.Location = new System.Drawing.Point(12, 139);
            aviary_aviary_codeLabel.Name = "aviary_aviary_codeLabel";
            aviary_aviary_codeLabel.Size = new System.Drawing.Size(71, 13);
            aviary_aviary_codeLabel.TabIndex = 13;
            aviary_aviary_codeLabel.Text = "Код вольера";
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // animalSetBindingSource
            // 
            this.animalSetBindingSource.DataMember = "AnimalSet";
            this.animalSetBindingSource.DataSource = this.dataSet1;
            // 
            // animalSetTableAdapter
            // 
            this.animalSetTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Animal_AnalysisSetTableAdapter = null;
            this.tableAdapterManager.AnimalSetTableAdapter = this.animalSetTableAdapter;
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
            // animal_nameTextBox
            // 
            this.animal_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalSetBindingSource, "animal_name", true));
            this.animal_nameTextBox.Location = new System.Drawing.Point(131, 6);
            this.animal_nameTextBox.Name = "animal_nameTextBox";
            this.animal_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.animal_nameTextBox.TabIndex = 4;
            // 
            // animal_genderTextBox
            // 
            this.animal_genderTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalSetBindingSource, "animal_gender", true));
            this.animal_genderTextBox.Location = new System.Drawing.Point(131, 32);
            this.animal_genderTextBox.Name = "animal_genderTextBox";
            this.animal_genderTextBox.Size = new System.Drawing.Size(200, 20);
            this.animal_genderTextBox.TabIndex = 6;
            // 
            // colorTextBox
            // 
            this.colorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalSetBindingSource, "color", true));
            this.colorTextBox.Location = new System.Drawing.Point(131, 58);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(200, 20);
            this.colorTextBox.TabIndex = 8;
            // 
            // date_of_birthDateTimePicker
            // 
            this.date_of_birthDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.animalSetBindingSource, "date_of_birth", true));
            this.date_of_birthDateTimePicker.Location = new System.Drawing.Point(131, 84);
            this.date_of_birthDateTimePicker.Name = "date_of_birthDateTimePicker";
            this.date_of_birthDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_of_birthDateTimePicker.TabIndex = 10;
            // 
            // speties_species_nameTextBox
            // 
            this.speties_species_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalSetBindingSource, "Speties_species_name", true));
            this.speties_species_nameTextBox.Location = new System.Drawing.Point(131, 110);
            this.speties_species_nameTextBox.Name = "speties_species_nameTextBox";
            this.speties_species_nameTextBox.Size = new System.Drawing.Size(200, 20);
            this.speties_species_nameTextBox.TabIndex = 12;
            // 
            // aviary_aviary_codeTextBox
            // 
            this.aviary_aviary_codeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalSetBindingSource, "Aviary_aviary_code", true));
            this.aviary_aviary_codeTextBox.Location = new System.Drawing.Point(131, 136);
            this.aviary_aviary_codeTextBox.Name = "aviary_aviary_codeTextBox";
            this.aviary_aviary_codeTextBox.Size = new System.Drawing.Size(200, 20);
            this.aviary_aviary_codeTextBox.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 177);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 37);
            this.button1.TabIndex = 15;
            this.button1.Text = "Принять";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnimalInsert
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 226);
            this.Controls.Add(this.button1);
            this.Controls.Add(animal_nameLabel);
            this.Controls.Add(this.animal_nameTextBox);
            this.Controls.Add(animal_genderLabel);
            this.Controls.Add(this.animal_genderTextBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(date_of_birthLabel);
            this.Controls.Add(this.date_of_birthDateTimePicker);
            this.Controls.Add(speties_species_nameLabel);
            this.Controls.Add(this.speties_species_nameTextBox);
            this.Controls.Add(aviary_aviary_codeLabel);
            this.Controls.Add(this.aviary_aviary_codeTextBox);
            this.Name = "AnimalInsert";
            this.Text = "Животные";
            this.Load += new System.EventHandler(this.AnimalInsert_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource animalSetBindingSource;
        private DataSet1TableAdapters.AnimalSetTableAdapter animalSetTableAdapter;
        private DataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox animal_nameTextBox;
        private System.Windows.Forms.TextBox animal_genderTextBox;
        private System.Windows.Forms.TextBox colorTextBox;
        private System.Windows.Forms.DateTimePicker date_of_birthDateTimePicker;
        private System.Windows.Forms.TextBox speties_species_nameTextBox;
        private System.Windows.Forms.TextBox aviary_aviary_codeTextBox;
        private System.Windows.Forms.Button button1;
    }
}