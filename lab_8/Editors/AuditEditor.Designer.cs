namespace lab_7_2.Editors
{
    partial class AuditEditor
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
            System.Windows.Forms.Label administratorIdLabel;
            System.Windows.Forms.Label arrivalDateLabel;
            System.Windows.Forms.Label departureDateLabel;
            System.Windows.Forms.Label paymentTimeLabel;
            System.Windows.Forms.Label clientIdLabel;
            System.Windows.Forms.Label roomIdLabel;
            System.Windows.Forms.Label paymentAmountLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuditEditor));
            this.hotelDBDataSet = new lab_7_2.HotelDBDataSet();
            this.auditLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.auditLogTableAdapter = new lab_7_2.HotelDBDataSetTableAdapters.AuditLogTableAdapter();
            this.tableAdapterManager = new lab_7_2.HotelDBDataSetTableAdapters.TableAdapterManager();
            this.administratorsTableAdapter = new lab_7_2.HotelDBDataSetTableAdapters.AdministratorsTableAdapter();
            this.clientsTableAdapter = new lab_7_2.HotelDBDataSetTableAdapters.ClientsTableAdapter();
            this.roomsTableAdapter = new lab_7_2.HotelDBDataSetTableAdapters.RoomsTableAdapter();
            this.auditLogBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.auditLogBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.administratorIdListBox = new System.Windows.Forms.ListBox();
            this.administratorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.arrivalDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.departureDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.paymentTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.clientIdListBox = new System.Windows.Forms.ListBox();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomIdListBox = new System.Windows.Forms.ListBox();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentAmountTextBox = new System.Windows.Forms.TextBox();
            administratorIdLabel = new System.Windows.Forms.Label();
            arrivalDateLabel = new System.Windows.Forms.Label();
            departureDateLabel = new System.Windows.Forms.Label();
            paymentTimeLabel = new System.Windows.Forms.Label();
            clientIdLabel = new System.Windows.Forms.Label();
            roomIdLabel = new System.Windows.Forms.Label();
            paymentAmountLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditLogBindingNavigator)).BeginInit();
            this.auditLogBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.administratorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // administratorIdLabel
            // 
            administratorIdLabel.AutoSize = true;
            administratorIdLabel.Location = new System.Drawing.Point(12, 41);
            administratorIdLabel.Name = "administratorIdLabel";
            administratorIdLabel.Size = new System.Drawing.Size(70, 13);
            administratorIdLabel.TabIndex = 3;
            administratorIdLabel.Text = "Administrator:";
            // 
            // arrivalDateLabel
            // 
            arrivalDateLabel.AutoSize = true;
            arrivalDateLabel.Location = new System.Drawing.Point(12, 147);
            arrivalDateLabel.Name = "arrivalDateLabel";
            arrivalDateLabel.Size = new System.Drawing.Size(65, 13);
            arrivalDateLabel.TabIndex = 5;
            arrivalDateLabel.Text = "Arrival Date:";
            // 
            // departureDateLabel
            // 
            departureDateLabel.AutoSize = true;
            departureDateLabel.Location = new System.Drawing.Point(12, 173);
            departureDateLabel.Name = "departureDateLabel";
            departureDateLabel.Size = new System.Drawing.Size(83, 13);
            departureDateLabel.TabIndex = 7;
            departureDateLabel.Text = "Departure Date:";
            // 
            // paymentTimeLabel
            // 
            paymentTimeLabel.AutoSize = true;
            paymentTimeLabel.Location = new System.Drawing.Point(12, 199);
            paymentTimeLabel.Name = "paymentTimeLabel";
            paymentTimeLabel.Size = new System.Drawing.Size(77, 13);
            paymentTimeLabel.TabIndex = 9;
            paymentTimeLabel.Text = "Payment Time:";
            // 
            // clientIdLabel
            // 
            clientIdLabel.AutoSize = true;
            clientIdLabel.Location = new System.Drawing.Point(12, 221);
            clientIdLabel.Name = "clientIdLabel";
            clientIdLabel.Size = new System.Drawing.Size(36, 13);
            clientIdLabel.TabIndex = 11;
            clientIdLabel.Text = "Client:";
            // 
            // roomIdLabel
            // 
            roomIdLabel.AutoSize = true;
            roomIdLabel.Location = new System.Drawing.Point(12, 323);
            roomIdLabel.Name = "roomIdLabel";
            roomIdLabel.Size = new System.Drawing.Size(38, 13);
            roomIdLabel.TabIndex = 13;
            roomIdLabel.Text = "Room:";
            // 
            // paymentAmountLabel
            // 
            paymentAmountLabel.AutoSize = true;
            paymentAmountLabel.Location = new System.Drawing.Point(12, 428);
            paymentAmountLabel.Name = "paymentAmountLabel";
            paymentAmountLabel.Size = new System.Drawing.Size(90, 13);
            paymentAmountLabel.TabIndex = 15;
            paymentAmountLabel.Text = "Payment Amount:";
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // auditLogBindingSource
            // 
            this.auditLogBindingSource.DataMember = "AuditLog";
            this.auditLogBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // auditLogTableAdapter
            // 
            this.auditLogTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratorsTableAdapter = this.administratorsTableAdapter;
            this.tableAdapterManager.AuditLogTableAdapter = this.auditLogTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.LanguagesTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = this.roomsTableAdapter;
            this.tableAdapterManager.UpdateOrder = lab_7_2.HotelDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // administratorsTableAdapter
            // 
            this.administratorsTableAdapter.ClearBeforeFill = true;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // roomsTableAdapter
            // 
            this.roomsTableAdapter.ClearBeforeFill = true;
            // 
            // auditLogBindingNavigator
            // 
            this.auditLogBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.auditLogBindingNavigator.BindingSource = this.auditLogBindingSource;
            this.auditLogBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.auditLogBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.auditLogBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.auditLogBindingNavigatorSaveItem,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3});
            this.auditLogBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.auditLogBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.auditLogBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.auditLogBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.auditLogBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.auditLogBindingNavigator.Name = "auditLogBindingNavigator";
            this.auditLogBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.auditLogBindingNavigator.Size = new System.Drawing.Size(504, 25);
            this.auditLogBindingNavigator.TabIndex = 0;
            this.auditLogBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // auditLogBindingNavigatorSaveItem
            // 
            this.auditLogBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.auditLogBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("auditLogBindingNavigatorSaveItem.Image")));
            this.auditLogBindingNavigatorSaveItem.Name = "auditLogBindingNavigatorSaveItem";
            this.auditLogBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.auditLogBindingNavigatorSaveItem.Text = "Save Data";
            this.auditLogBindingNavigatorSaveItem.Click += new System.EventHandler(this.auditLogBindingNavigatorSaveItem_Click_1);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(73, 22);
            this.toolStripButton1.Text = "Edit admins";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(68, 22);
            this.toolStripButton2.Text = "Edit clients";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(68, 22);
            this.toolStripButton3.Text = "Edit rooms";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // administratorIdListBox
            // 
            this.administratorIdListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.auditLogBindingSource, "AdministratorId", true));
            this.administratorIdListBox.DataSource = this.administratorsBindingSource;
            this.administratorIdListBox.DisplayMember = "Surname";
            this.administratorIdListBox.FormattingEnabled = true;
            this.administratorIdListBox.Location = new System.Drawing.Point(108, 41);
            this.administratorIdListBox.Name = "administratorIdListBox";
            this.administratorIdListBox.Size = new System.Drawing.Size(384, 95);
            this.administratorIdListBox.TabIndex = 4;
            this.administratorIdListBox.ValueMember = "Id";
            // 
            // administratorsBindingSource
            // 
            this.administratorsBindingSource.DataMember = "Administrators";
            this.administratorsBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // arrivalDateDateTimePicker
            // 
            this.arrivalDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.auditLogBindingSource, "ArrivalDate", true));
            this.arrivalDateDateTimePicker.Location = new System.Drawing.Point(108, 143);
            this.arrivalDateDateTimePicker.Name = "arrivalDateDateTimePicker";
            this.arrivalDateDateTimePicker.Size = new System.Drawing.Size(384, 20);
            this.arrivalDateDateTimePicker.TabIndex = 6;
            // 
            // departureDateDateTimePicker
            // 
            this.departureDateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.auditLogBindingSource, "DepartureDate", true));
            this.departureDateDateTimePicker.Location = new System.Drawing.Point(108, 169);
            this.departureDateDateTimePicker.Name = "departureDateDateTimePicker";
            this.departureDateDateTimePicker.Size = new System.Drawing.Size(384, 20);
            this.departureDateDateTimePicker.TabIndex = 8;
            // 
            // paymentTimeDateTimePicker
            // 
            this.paymentTimeDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.auditLogBindingSource, "PaymentTime", true));
            this.paymentTimeDateTimePicker.Location = new System.Drawing.Point(108, 195);
            this.paymentTimeDateTimePicker.Name = "paymentTimeDateTimePicker";
            this.paymentTimeDateTimePicker.Size = new System.Drawing.Size(384, 20);
            this.paymentTimeDateTimePicker.TabIndex = 10;
            // 
            // clientIdListBox
            // 
            this.clientIdListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.auditLogBindingSource, "ClientId", true));
            this.clientIdListBox.DataSource = this.clientsBindingSource;
            this.clientIdListBox.DisplayMember = "Surname";
            this.clientIdListBox.FormattingEnabled = true;
            this.clientIdListBox.Location = new System.Drawing.Point(108, 221);
            this.clientIdListBox.Name = "clientIdListBox";
            this.clientIdListBox.Size = new System.Drawing.Size(384, 95);
            this.clientIdListBox.TabIndex = 12;
            this.clientIdListBox.ValueMember = "Id";
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // roomIdListBox
            // 
            this.roomIdListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.auditLogBindingSource, "RoomId", true));
            this.roomIdListBox.DataSource = this.roomsBindingSource;
            this.roomIdListBox.DisplayMember = "Number";
            this.roomIdListBox.FormattingEnabled = true;
            this.roomIdListBox.Location = new System.Drawing.Point(108, 323);
            this.roomIdListBox.Name = "roomIdListBox";
            this.roomIdListBox.Size = new System.Drawing.Size(384, 95);
            this.roomIdListBox.TabIndex = 14;
            this.roomIdListBox.ValueMember = "Number";
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // paymentAmountTextBox
            // 
            this.paymentAmountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.auditLogBindingSource, "PaymentAmount", true));
            this.paymentAmountTextBox.Location = new System.Drawing.Point(108, 425);
            this.paymentAmountTextBox.Name = "paymentAmountTextBox";
            this.paymentAmountTextBox.Size = new System.Drawing.Size(384, 20);
            this.paymentAmountTextBox.TabIndex = 16;
            // 
            // AuditEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 449);
            this.Controls.Add(administratorIdLabel);
            this.Controls.Add(this.administratorIdListBox);
            this.Controls.Add(arrivalDateLabel);
            this.Controls.Add(this.arrivalDateDateTimePicker);
            this.Controls.Add(departureDateLabel);
            this.Controls.Add(this.departureDateDateTimePicker);
            this.Controls.Add(paymentTimeLabel);
            this.Controls.Add(this.paymentTimeDateTimePicker);
            this.Controls.Add(clientIdLabel);
            this.Controls.Add(this.clientIdListBox);
            this.Controls.Add(roomIdLabel);
            this.Controls.Add(this.roomIdListBox);
            this.Controls.Add(paymentAmountLabel);
            this.Controls.Add(this.paymentAmountTextBox);
            this.Controls.Add(this.auditLogBindingNavigator);
            this.Name = "AuditEditor";
            this.Text = "AuditEditor";
            this.Load += new System.EventHandler(this.AuditEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.auditLogBindingNavigator)).EndInit();
            this.auditLogBindingNavigator.ResumeLayout(false);
            this.auditLogBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.administratorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource auditLogBindingSource;
        private HotelDBDataSetTableAdapters.AuditLogTableAdapter auditLogTableAdapter;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator auditLogBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton auditLogBindingNavigatorSaveItem;
        private System.Windows.Forms.ListBox administratorIdListBox;
        private System.Windows.Forms.DateTimePicker arrivalDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker departureDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker paymentTimeDateTimePicker;
        private System.Windows.Forms.ListBox clientIdListBox;
        private System.Windows.Forms.ListBox roomIdListBox;
        private System.Windows.Forms.TextBox paymentAmountTextBox;
        private HotelDBDataSetTableAdapters.AdministratorsTableAdapter administratorsTableAdapter;
        private System.Windows.Forms.BindingSource administratorsBindingSource;
        private HotelDBDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private HotelDBDataSetTableAdapters.RoomsTableAdapter roomsTableAdapter;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
    }
}