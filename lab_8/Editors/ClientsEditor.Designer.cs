using lab_8.HotelDBDataSetTableAdapters;

namespace lab_8.Editors
{
    partial class ClientsEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsEditor));
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label patronymicLabel;
            System.Windows.Forms.Label discountPercentageLabel;
            System.Windows.Forms.Label languageIdLabel;
            this.hotelDBDataSet = new HotelDBDataSet();
            this.clientsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientsTableAdapter = new ClientsTableAdapter();
            this.tableAdapterManager = new TableAdapterManager();
            this.clientsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.clientsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.patronymicTextBox = new System.Windows.Forms.TextBox();
            this.discountPercentageTextBox = new System.Windows.Forms.TextBox();
            this.languageIdListBox = new System.Windows.Forms.ListBox();
            this.languagesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.languagesTableAdapter = new LanguagesTableAdapter();
            nameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            patronymicLabel = new System.Windows.Forms.Label();
            discountPercentageLabel = new System.Windows.Forms.Label();
            languageIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).BeginInit();
            this.clientsBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languagesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // hotelDBDataSet
            // 
            this.hotelDBDataSet.DataSetName = "HotelDBDataSet";
            this.hotelDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clientsBindingSource
            // 
            this.clientsBindingSource.DataMember = "Clients";
            this.clientsBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // clientsTableAdapter
            // 
            this.clientsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AdministratorsTableAdapter = null;
            this.tableAdapterManager.AuditLogTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ClientsTableAdapter = this.clientsTableAdapter;
            this.tableAdapterManager.LanguagesTableAdapter = this.languagesTableAdapter;
            this.tableAdapterManager.RoomsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clientsBindingNavigator
            // 
            this.clientsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.clientsBindingNavigator.BindingSource = this.clientsBindingSource;
            this.clientsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.clientsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.clientsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.clientsBindingNavigatorSaveItem});
            this.clientsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.clientsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.clientsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.clientsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.clientsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.clientsBindingNavigator.Name = "clientsBindingNavigator";
            this.clientsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.clientsBindingNavigator.Size = new System.Drawing.Size(297, 25);
            this.clientsBindingNavigator.TabIndex = 0;
            this.clientsBindingNavigator.Text = "bindingNavigator1";
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
            // clientsBindingNavigatorSaveItem
            // 
            this.clientsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.clientsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("clientsBindingNavigatorSaveItem.Image")));
            this.clientsBindingNavigatorSaveItem.Name = "clientsBindingNavigatorSaveItem";
            this.clientsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.clientsBindingNavigatorSaveItem.Text = "Save Data";
            this.clientsBindingNavigatorSaveItem.Click += new System.EventHandler(this.clientsBindingNavigatorSaveItem_Click);
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 39);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(38, 13);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(128, 36);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(150, 20);
            this.nameTextBox.TabIndex = 4;
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Location = new System.Drawing.Point(12, 65);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(52, 13);
            surnameLabel.TabIndex = 5;
            surnameLabel.Text = "Surname:";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Surname", true));
            this.surnameTextBox.Location = new System.Drawing.Point(128, 62);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(150, 20);
            this.surnameTextBox.TabIndex = 6;
            // 
            // patronymicLabel
            // 
            patronymicLabel.AutoSize = true;
            patronymicLabel.Location = new System.Drawing.Point(12, 91);
            patronymicLabel.Name = "patronymicLabel";
            patronymicLabel.Size = new System.Drawing.Size(62, 13);
            patronymicLabel.TabIndex = 7;
            patronymicLabel.Text = "Patronymic:";
            // 
            // patronymicTextBox
            // 
            this.patronymicTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "Patronymic", true));
            this.patronymicTextBox.Location = new System.Drawing.Point(128, 88);
            this.patronymicTextBox.Name = "patronymicTextBox";
            this.patronymicTextBox.Size = new System.Drawing.Size(150, 20);
            this.patronymicTextBox.TabIndex = 8;
            // 
            // discountPercentageLabel
            // 
            discountPercentageLabel.AutoSize = true;
            discountPercentageLabel.Location = new System.Drawing.Point(12, 117);
            discountPercentageLabel.Name = "discountPercentageLabel";
            discountPercentageLabel.Size = new System.Drawing.Size(110, 13);
            discountPercentageLabel.TabIndex = 9;
            discountPercentageLabel.Text = "Discount Percentage:";
            // 
            // discountPercentageTextBox
            // 
            this.discountPercentageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.clientsBindingSource, "DiscountPercentage", true));
            this.discountPercentageTextBox.Location = new System.Drawing.Point(128, 114);
            this.discountPercentageTextBox.Name = "discountPercentageTextBox";
            this.discountPercentageTextBox.Size = new System.Drawing.Size(150, 20);
            this.discountPercentageTextBox.TabIndex = 10;
            // 
            // languageIdLabel
            // 
            languageIdLabel.AutoSize = true;
            languageIdLabel.Location = new System.Drawing.Point(12, 140);
            languageIdLabel.Name = "languageIdLabel";
            languageIdLabel.Size = new System.Drawing.Size(70, 13);
            languageIdLabel.TabIndex = 13;
            languageIdLabel.Text = "Language Id:";
            // 
            // languageIdListBox
            // 
            this.languageIdListBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.clientsBindingSource, "LanguageId", true));
            this.languageIdListBox.DataSource = this.languagesBindingSource;
            this.languageIdListBox.DisplayMember = "Name";
            this.languageIdListBox.FormattingEnabled = true;
            this.languageIdListBox.Location = new System.Drawing.Point(128, 140);
            this.languageIdListBox.Name = "languageIdListBox";
            this.languageIdListBox.Size = new System.Drawing.Size(150, 147);
            this.languageIdListBox.TabIndex = 14;
            this.languageIdListBox.ValueMember = "Id";
            // 
            // languagesBindingSource
            // 
            this.languagesBindingSource.DataMember = "Languages";
            this.languagesBindingSource.DataSource = this.hotelDBDataSet;
            // 
            // languagesTableAdapter
            // 
            this.languagesTableAdapter.ClearBeforeFill = true;
            // 
            // ClientsEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 296);
            this.Controls.Add(languageIdLabel);
            this.Controls.Add(this.languageIdListBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(patronymicLabel);
            this.Controls.Add(this.patronymicTextBox);
            this.Controls.Add(discountPercentageLabel);
            this.Controls.Add(this.discountPercentageTextBox);
            this.Controls.Add(this.clientsBindingNavigator);
            this.Name = "ClientsEditor";
            this.Text = "ClientsEditor";
            this.Load += new System.EventHandler(this.ClientsEditor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.hotelDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientsBindingNavigator)).EndInit();
            this.clientsBindingNavigator.ResumeLayout(false);
            this.clientsBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.languagesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private HotelDBDataSet hotelDBDataSet;
        private System.Windows.Forms.BindingSource clientsBindingSource;
        private HotelDBDataSetTableAdapters.ClientsTableAdapter clientsTableAdapter;
        private HotelDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator clientsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton clientsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox patronymicTextBox;
        private System.Windows.Forms.TextBox discountPercentageTextBox;
        private HotelDBDataSetTableAdapters.LanguagesTableAdapter languagesTableAdapter;
        private System.Windows.Forms.ListBox languageIdListBox;
        private System.Windows.Forms.BindingSource languagesBindingSource;
    }
}