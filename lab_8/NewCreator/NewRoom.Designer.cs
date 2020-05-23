namespace lab_8.NewCreator
{
    partial class NewRoom
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
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label numberOfBedsLabel;
            System.Windows.Forms.Label costOfNightLabel;
            this.hotelDBDataSet = new lab_8.HotelDBDataSet();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsTableAdapter = new lab_8.HotelDBDataSetTableAdapters.RoomsTableAdapter();
            this.tableAdapterManager = new lab_8.HotelDBDataSetTableAdapters.TableAdapterManager();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.numberOfBedsTextBox = new System.Windows.Forms.TextBox();
            this.costOfNightTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            numberLabel = new System.Windows.Forms.Label();
            numberOfBedsLabel = new System.Windows.Forms.Label();
            costOfNightLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratorsTableAdapter = null;
            this.tableAdapterManager.AuditLogTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.LanguagesTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = this.roomsTableAdapter;
            this.tableAdapterManager.UpdateOrder = lab_8.HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(12, 9);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(47, 13);
            numberLabel.TabIndex = 3;
            numberLabel.Text = "Number:";
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(106, 6);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 4;
            // 
            // numberOfBedsLabel
            // 
            numberOfBedsLabel.AutoSize = true;
            numberOfBedsLabel.Location = new System.Drawing.Point(12, 35);
            numberOfBedsLabel.Name = "numberOfBedsLabel";
            numberOfBedsLabel.Size = new System.Drawing.Size(88, 13);
            numberOfBedsLabel.TabIndex = 5;
            numberOfBedsLabel.Text = "Number Of Beds:";
            // 
            // numberOfBedsTextBox
            // 
            this.numberOfBedsTextBox.Location = new System.Drawing.Point(106, 32);
            this.numberOfBedsTextBox.Name = "numberOfBedsTextBox";
            this.numberOfBedsTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberOfBedsTextBox.TabIndex = 6;
            // 
            // costOfNightLabel
            // 
            costOfNightLabel.AutoSize = true;
            costOfNightLabel.Location = new System.Drawing.Point(12, 61);
            costOfNightLabel.Name = "costOfNightLabel";
            costOfNightLabel.Size = new System.Drawing.Size(73, 13);
            costOfNightLabel.TabIndex = 7;
            costOfNightLabel.Text = "Cost Of Night:";
            // 
            // costOfNightTextBox
            // 
            this.costOfNightTextBox.Location = new System.Drawing.Point(106, 58);
            this.costOfNightTextBox.Name = "costOfNightTextBox";
            this.costOfNightTextBox.Size = new System.Drawing.Size(100, 20);
            this.costOfNightTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(194, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить комнату";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // NewRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 136);
            this.Controls.Add(this.button1);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(numberOfBedsLabel);
            this.Controls.Add(this.numberOfBedsTextBox);
            this.Controls.Add(costOfNightLabel);
            this.Controls.Add(this.costOfNightTextBox);
            this.Name = "NewRoom";
            this.Text = "NewRoom";
            this.Load += new System.EventHandler(this.NewRoom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private HotelDBDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox numberTextBox;
        private System.Windows.Forms.TextBox numberOfBedsTextBox;
        private System.Windows.Forms.TextBox costOfNightTextBox;
        private System.Windows.Forms.Button button1;
    }
}