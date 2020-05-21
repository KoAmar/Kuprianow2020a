using lab_8.HotelDBDataSetTableAdapters;

namespace lab_8.Editors
{
    partial class AdminsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminsEditor));
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label patronymicLabel;
            this.hotelDBDataSet = new HotelDBDataSet();
            this.administratorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.administratorsTableAdapter = new AdministratorsTableAdapter();
            this.tableAdapterManager = new TableAdapterManager();
            this.administratorsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.administratorsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorsBindingNavigator)).BeginInit();
            this.administratorsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // administratorsBindingSource
            // 
            this.administratorsBindingSource.DataMember = "Administrators";
            this.administratorsBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // administratorsTableAdapter
            // 
            this.administratorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratorsTableAdapter = this.administratorsTableAdapter;
            this.tableAdapterManager.AuditLogTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = null;
            this.tableAdapterManager.LanguagesTableAdapter = null;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // administratorsBindingNavigator
            // 
            this.administratorsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.administratorsBindingNavigator.BindingSource = this.administratorsBindingSource;
            this.administratorsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.administratorsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.administratorsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.administratorsBindingNavigatorSaveItem});
            this.administratorsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.administratorsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.administratorsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.administratorsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.administratorsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.administratorsBindingNavigator.Name = "administratorsBindingNavigator";
            this.administratorsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.administratorsBindingNavigator.Size = new System.Drawing.Size(286, 25);
            this.administratorsBindingNavigator.TabIndex = 0;
            this.administratorsBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // administratorsBindingNavigatorSaveItem
            // 
            this.administratorsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.administratorsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("administratorsBindingNavigatorSaveItem.Image")));
            this.administratorsBindingNavigatorSaveItem.Name = "administratorsBindingNavigatorSaveItem";
            this.administratorsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.administratorsBindingNavigatorSaveItem.Text = "Save Data";
            this.administratorsBindingNavigatorSaveItem.Click += new System.EventHandler(this.administratorsBindingNavigatorSaveItem_Click);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(4, 41);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.administratorsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(72, 38);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(202, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(4, 67);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 5;
            surnameLabel.Text = "Surname:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.administratorsBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(72, 64);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(202, 20);
            this.surnameTextBox.TabIndex = 6;
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new System.Drawing.Point(4, 93);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(62, 13);
            patronymicLabel.TabIndex = 7;
            patronymicLabel.Text = "Patronymic:";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.administratorsBindingSource, "Patronymic", true));
            this.patronymicTextBox.Location = new System.Drawing.Point(72, 90);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(202, 20);
            this.patronymicTextBox.TabIndex = 8;
            // 
            // AdminsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(286, 148);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(patronymicLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(this.administratorsBindingNavigator);
            this.Name = "AdminsEditor";
            this.Text = "AdminsEditor";
            this.Load += new System.EventHandler(this.AdminsEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.administratorsBindingNavigator)).EndInit();
            this.administratorsBindingNavigator.ResumeLayout(false);
            this.administratorsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource administratorsBindingSource;
        private HotelDBDataSetTableAdapters.AdministratorsTableAdapter administratorsTableAdapter;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator administratorsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton administratorsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
    }
}