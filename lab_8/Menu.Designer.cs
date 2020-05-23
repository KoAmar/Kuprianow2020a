namespace lab_8
{
    partial class Menu
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.LangBt = new System.Windows.Forms.Button();
            this.RoomsBt = new System.Windows.Forms.Button();
            this.ClientsBt = new System.Windows.Forms.Button();
            this.AdminsBt = new System.Windows.Forms.Button();
            this.AuditBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.auditEditorBt = new System.Windows.Forms.Button();
            this.addAuditRecordBt = new System.Windows.Forms.Button();
            this.addAdminBt = new System.Windows.Forms.Button();
            this.addClientBt = new System.Windows.Forms.Button();
            this.addRoomBt = new System.Windows.Forms.Button();
            this.LastClientPrintBt = new System.Windows.Forms.Button();
            this.ClientsInRoomsBt = new System.Windows.Forms.Button();
            this.AuditLogPrintBt = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.Controls.Add(this.LangBt, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.RoomsBt, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.ClientsBt, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.AdminsBt, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.addRoomBt, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.addClientBt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.addAdminBt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.addAuditRecordBt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.ClientsInRoomsBt, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.LastClientPrintBt, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.AuditLogPrintBt, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 2, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(948, 582);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // LangBt
            // 
            this.LangBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LangBt.Location = new System.Drawing.Point(293, 495);
            this.LangBt.Margin = new System.Windows.Forms.Padding(10);
            this.LangBt.Name = "LangBt";
            this.LangBt.Size = new System.Drawing.Size(359, 77);
            this.LangBt.TabIndex = 5;
            this.LangBt.Text = "Языки";
            this.LangBt.UseVisualStyleBackColor = true;
            this.LangBt.Click += new System.EventHandler(this.LangBt_Click);
            // 
            // RoomsBt
            // 
            this.RoomsBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomsBt.Location = new System.Drawing.Point(293, 398);
            this.RoomsBt.Margin = new System.Windows.Forms.Padding(10);
            this.RoomsBt.Name = "RoomsBt";
            this.RoomsBt.Size = new System.Drawing.Size(359, 77);
            this.RoomsBt.TabIndex = 4;
            this.RoomsBt.Text = "Комнаты";
            this.RoomsBt.UseVisualStyleBackColor = true;
            this.RoomsBt.Click += new System.EventHandler(this.RoomsBt_Click);
            // 
            // ClientsBt
            // 
            this.ClientsBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsBt.Location = new System.Drawing.Point(293, 301);
            this.ClientsBt.Margin = new System.Windows.Forms.Padding(10);
            this.ClientsBt.Name = "ClientsBt";
            this.ClientsBt.Size = new System.Drawing.Size(359, 77);
            this.ClientsBt.TabIndex = 3;
            this.ClientsBt.Text = "Клиенты";
            this.ClientsBt.UseVisualStyleBackColor = true;
            this.ClientsBt.Click += new System.EventHandler(this.ClientsBt_Click);
            // 
            // AdminsBt
            // 
            this.AdminsBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminsBt.Location = new System.Drawing.Point(293, 204);
            this.AdminsBt.Margin = new System.Windows.Forms.Padding(10);
            this.AdminsBt.Name = "AdminsBt";
            this.AdminsBt.Size = new System.Drawing.Size(359, 77);
            this.AdminsBt.TabIndex = 2;
            this.AdminsBt.Text = "Администраторы";
            this.AdminsBt.UseVisualStyleBackColor = true;
            this.AdminsBt.Click += new System.EventHandler(this.AdminsBt_Click);
            // 
            // AuditBt
            // 
            this.AuditBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuditBt.Location = new System.Drawing.Point(10, 10);
            this.AuditBt.Margin = new System.Windows.Forms.Padding(10);
            this.AuditBt.Name = "AuditBt";
            this.AuditBt.Size = new System.Drawing.Size(169, 77);
            this.AuditBt.TabIndex = 1;
            this.AuditBt.Text = "Журнал Аудита";
            this.AuditBt.UseVisualStyleBackColor = true;
            this.AuditBt.Click += new System.EventHandler(this.AuditBt_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(286, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "База данных отеля";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // auditEditorBt
            // 
            this.auditEditorBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.auditEditorBt.Location = new System.Drawing.Point(199, 10);
            this.auditEditorBt.Margin = new System.Windows.Forms.Padding(10);
            this.auditEditorBt.Name = "auditEditorBt";
            this.auditEditorBt.Size = new System.Drawing.Size(170, 77);
            this.auditEditorBt.TabIndex = 7;
            this.auditEditorBt.Text = "Редактор журнала аудита";
            this.auditEditorBt.UseVisualStyleBackColor = true;
            this.auditEditorBt.Click += new System.EventHandler(this.AuditEditorBt_Click);
            // 
            // addAuditRecordBt
            // 
            this.addAuditRecordBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addAuditRecordBt.Location = new System.Drawing.Point(104, 107);
            this.addAuditRecordBt.Margin = new System.Windows.Forms.Padding(10);
            this.addAuditRecordBt.Name = "addAuditRecordBt";
            this.addAuditRecordBt.Size = new System.Drawing.Size(169, 77);
            this.addAuditRecordBt.TabIndex = 8;
            this.addAuditRecordBt.Text = "Зарегистрировать клиента";
            this.addAuditRecordBt.UseVisualStyleBackColor = true;
            this.addAuditRecordBt.Click += new System.EventHandler(this.AddAuditRecordBt_Click);
            // 
            // addAdminBt
            // 
            this.addAdminBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addAdminBt.Location = new System.Drawing.Point(104, 204);
            this.addAdminBt.Margin = new System.Windows.Forms.Padding(10);
            this.addAdminBt.Name = "addAdminBt";
            this.addAdminBt.Size = new System.Drawing.Size(169, 77);
            this.addAdminBt.TabIndex = 9;
            this.addAdminBt.Text = "Добавить администратора ";
            this.addAdminBt.UseVisualStyleBackColor = true;
            this.addAdminBt.Click += new System.EventHandler(this.AddAdminBt_Click);
            // 
            // addClientBt
            // 
            this.addClientBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addClientBt.Location = new System.Drawing.Point(104, 301);
            this.addClientBt.Margin = new System.Windows.Forms.Padding(10);
            this.addClientBt.Name = "addClientBt";
            this.addClientBt.Size = new System.Drawing.Size(169, 77);
            this.addClientBt.TabIndex = 10;
            this.addClientBt.Text = "Добавить клиента";
            this.addClientBt.UseVisualStyleBackColor = true;
            this.addClientBt.Click += new System.EventHandler(this.AddClientBt_Click);
            // 
            // addRoomBt
            // 
            this.addRoomBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addRoomBt.Location = new System.Drawing.Point(104, 398);
            this.addRoomBt.Margin = new System.Windows.Forms.Padding(10);
            this.addRoomBt.Name = "addRoomBt";
            this.addRoomBt.Size = new System.Drawing.Size(169, 77);
            this.addRoomBt.TabIndex = 11;
            this.addRoomBt.Text = "Добавить комнату";
            this.addRoomBt.UseVisualStyleBackColor = true;
            this.addRoomBt.Click += new System.EventHandler(this.AddRoomBt_Click);
            // 
            // LastClientPrintBt
            // 
            this.LastClientPrintBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LastClientPrintBt.Location = new System.Drawing.Point(672, 107);
            this.LastClientPrintBt.Margin = new System.Windows.Forms.Padding(10);
            this.LastClientPrintBt.Name = "LastClientPrintBt";
            this.LastClientPrintBt.Size = new System.Drawing.Size(122, 77);
            this.LastClientPrintBt.TabIndex = 12;
            this.LastClientPrintBt.Text = "Печать последнего клиента";
            this.LastClientPrintBt.UseVisualStyleBackColor = true;
            this.LastClientPrintBt.Click += new System.EventHandler(this.LastClientPrintBt_Click);
            // 
            // ClientsInRoomsBt
            // 
            this.ClientsInRoomsBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsInRoomsBt.Location = new System.Drawing.Point(672, 398);
            this.ClientsInRoomsBt.Margin = new System.Windows.Forms.Padding(10);
            this.ClientsInRoomsBt.Name = "ClientsInRoomsBt";
            this.ClientsInRoomsBt.Size = new System.Drawing.Size(122, 77);
            this.ClientsInRoomsBt.TabIndex = 13;
            this.ClientsInRoomsBt.Text = "Печать списка комнат";
            this.ClientsInRoomsBt.UseVisualStyleBackColor = true;
            this.ClientsInRoomsBt.Click += new System.EventHandler(this.ClientsInRoomsBt_Click);
            // 
            // AuditLogPrintBt
            // 
            this.AuditLogPrintBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuditLogPrintBt.Location = new System.Drawing.Point(814, 107);
            this.AuditLogPrintBt.Margin = new System.Windows.Forms.Padding(10);
            this.AuditLogPrintBt.Name = "AuditLogPrintBt";
            this.AuditLogPrintBt.Size = new System.Drawing.Size(124, 77);
            this.AuditLogPrintBt.TabIndex = 14;
            this.AuditLogPrintBt.Text = "Печать журнала аудита";
            this.AuditLogPrintBt.UseVisualStyleBackColor = true;
            this.AuditLogPrintBt.Click += new System.EventHandler(this.AuditLogPrintBt_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.AuditBt, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.auditEditorBt, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(283, 97);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(379, 97);
            this.tableLayoutPanel2.TabIndex = 15;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 582);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Menu";
            this.Text = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AuditBt;
        private System.Windows.Forms.Button AdminsBt;
        private System.Windows.Forms.Button ClientsBt;
        private System.Windows.Forms.Button RoomsBt;
        private System.Windows.Forms.Button LangBt;
        private System.Windows.Forms.Button auditEditorBt;
        private System.Windows.Forms.Button addAuditRecordBt;
        private System.Windows.Forms.Button addAdminBt;
        private System.Windows.Forms.Button addClientBt;
        private System.Windows.Forms.Button addRoomBt;
        private System.Windows.Forms.Button LastClientPrintBt;
        private System.Windows.Forms.Button ClientsInRoomsBt;
        private System.Windows.Forms.Button AuditLogPrintBt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
    }
}

