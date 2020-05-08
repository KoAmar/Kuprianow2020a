namespace lab_6
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
            this.label1 = new System.Windows.Forms.Label();
            this.AuditBt = new System.Windows.Forms.Button();
            this.AdminsBt = new System.Windows.Forms.Button();
            this.ClientsBt = new System.Windows.Forms.Button();
            this.RoomsBt = new System.Windows.Forms.Button();
            this.LangBt = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.AuditBt, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AdminsBt, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.ClientsBt, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.RoomsBt, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.LangBt, 1, 5);
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
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(269, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "База данных отеля";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AuditBt
            // 
            this.AuditBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AuditBt.Location = new System.Drawing.Point(276, 84);
            this.AuditBt.Margin = new System.Windows.Forms.Padding(10);
            this.AuditBt.Name = "AuditBt";
            this.AuditBt.Size = new System.Drawing.Size(246, 54);
            this.AuditBt.TabIndex = 1;
            this.AuditBt.Text = "Журнал Аудита";
            this.AuditBt.UseVisualStyleBackColor = true;
            this.AuditBt.Click += new System.EventHandler(this.AuditBt_Click);
            // 
            // AdminsBt
            // 
            this.AdminsBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AdminsBt.Location = new System.Drawing.Point(276, 158);
            this.AdminsBt.Margin = new System.Windows.Forms.Padding(10);
            this.AdminsBt.Name = "AdminsBt";
            this.AdminsBt.Size = new System.Drawing.Size(246, 54);
            this.AdminsBt.TabIndex = 2;
            this.AdminsBt.Text = "Администраторы";
            this.AdminsBt.UseVisualStyleBackColor = true;
            this.AdminsBt.Click += new System.EventHandler(this.AdminsBt_Click);
            // 
            // ClientsBt
            // 
            this.ClientsBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ClientsBt.Location = new System.Drawing.Point(276, 232);
            this.ClientsBt.Margin = new System.Windows.Forms.Padding(10);
            this.ClientsBt.Name = "ClientsBt";
            this.ClientsBt.Size = new System.Drawing.Size(246, 54);
            this.ClientsBt.TabIndex = 3;
            this.ClientsBt.Text = "Клиенты";
            this.ClientsBt.UseVisualStyleBackColor = true;
            this.ClientsBt.Click += new System.EventHandler(this.ClientsBt_Click);
            // 
            // RoomsBt
            // 
            this.RoomsBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RoomsBt.Location = new System.Drawing.Point(276, 306);
            this.RoomsBt.Margin = new System.Windows.Forms.Padding(10);
            this.RoomsBt.Name = "RoomsBt";
            this.RoomsBt.Size = new System.Drawing.Size(246, 54);
            this.RoomsBt.TabIndex = 4;
            this.RoomsBt.Text = "Комнаты";
            this.RoomsBt.UseVisualStyleBackColor = true;
            this.RoomsBt.Click += new System.EventHandler(this.RoomsBt_Click);
            // 
            // LangBt
            // 
            this.LangBt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LangBt.Location = new System.Drawing.Point(276, 380);
            this.LangBt.Margin = new System.Windows.Forms.Padding(10);
            this.LangBt.Name = "LangBt";
            this.LangBt.Size = new System.Drawing.Size(246, 60);
            this.LangBt.TabIndex = 5;
            this.LangBt.Text = "Языки";
            this.LangBt.UseVisualStyleBackColor = true;
            this.LangBt.Click += new System.EventHandler(this.LangBt_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Menu";
            this.Text = "MainForm";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
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
    }
}

