namespace App
{
    partial class Form1
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input3 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input1 = new System.Windows.Forms.TextBox();
            this.listQT = new System.Windows.Forms.ComboBox();
            this.readBox = new System.Windows.Forms.DataGridView();
            this.readQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readTrackingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readBox)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 9.651944F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.24832F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.24832F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.85142F));
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.input3, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.input2, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.input1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listQT, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(69, 28);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(501, 85);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 48);
            this.label4.TabIndex = 5;
            this.label4.Text = "QT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(343, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tracking Number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(197, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(51, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input3
            // 
            this.input3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input3.Location = new System.Drawing.Point(343, 51);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(155, 20);
            this.input3.TabIndex = 3;
            this.input3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input3_KeyDown);
            // 
            // input2
            // 
            this.input2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input2.Location = new System.Drawing.Point(197, 51);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(140, 20);
            this.input2.TabIndex = 2;
            this.input2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input2_KeyDown);
            // 
            // input1
            // 
            this.input1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input1.Location = new System.Drawing.Point(51, 51);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(140, 20);
            this.input1.TabIndex = 1;
            this.input1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input1_KeyDown);
            // 
            // listQT
            // 
            this.listQT.FormattingEnabled = true;
            this.listQT.Location = new System.Drawing.Point(3, 51);
            this.listQT.Name = "listQT";
            this.listQT.Size = new System.Drawing.Size(42, 21);
            this.listQT.TabIndex = 4;
            this.listQT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listQT_KeyDown);
            // 
            // readBox
            // 
            this.readBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.readQT,
            this.readOrderNumber,
            this.readID,
            this.readTrackingNumber});
            this.readBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readBox.Location = new System.Drawing.Point(0, 0);
            this.readBox.MultiSelect = false;
            this.readBox.Name = "readBox";
            this.readBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.readBox.Size = new System.Drawing.Size(501, 179);
            this.readBox.TabIndex = 11;
            this.readBox.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.readBox_CellMouseClick);
            // 
            // readQT
            // 
            this.readQT.HeaderText = "QT";
            this.readQT.Name = "readQT";
            this.readQT.ReadOnly = true;
            this.readQT.Width = 25;
            // 
            // readOrderNumber
            // 
            this.readOrderNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.readOrderNumber.HeaderText = "Order Number";
            this.readOrderNumber.Name = "readOrderNumber";
            this.readOrderNumber.ReadOnly = true;
            // 
            // readID
            // 
            this.readID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.readID.HeaderText = "Employee ID";
            this.readID.Name = "readID";
            this.readID.ReadOnly = true;
            // 
            // readTrackingNumber
            // 
            this.readTrackingNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.readTrackingNumber.HeaderText = "Tracking Number";
            this.readTrackingNumber.Name = "readTrackingNumber";
            this.readTrackingNumber.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.readBox);
            this.panel1.Location = new System.Drawing.Point(69, 130);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 179);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(587, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Delete ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 321);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.readBox)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox listQT;
        private System.Windows.Forms.DataGridView readBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn readQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn readOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn readID;
        private System.Windows.Forms.DataGridViewTextBoxColumn readTrackingNumber;
        private System.Windows.Forms.Button button1;
    }
}

