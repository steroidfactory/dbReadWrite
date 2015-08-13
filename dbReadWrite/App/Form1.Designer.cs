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
            this.readBox = new System.Windows.Forms.DataGridView();
            this.readDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readQT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readOrderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readTrackingNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.readTimeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelReadBox = new System.Windows.Forms.Panel();
            this.panelOrderStatus = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.inputOrderStatus = new System.Windows.Forms.TextBox();
            this.btnCheckOrder = new System.Windows.Forms.Button();
            this.lblStatusOrder = new System.Windows.Forms.Label();
            this.lblOrderStatusNumber = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listDM = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.input3 = new System.Windows.Forms.TextBox();
            this.input2 = new System.Windows.Forms.TextBox();
            this.input1 = new System.Windows.Forms.TextBox();
            this.listQT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.readBox)).BeginInit();
            this.panelReadBox.SuspendLayout();
            this.panelOrderStatus.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // readBox
            // 
            this.readBox.AllowUserToAddRows = false;
            this.readBox.AllowUserToDeleteRows = false;
            this.readBox.AllowUserToResizeColumns = false;
            this.readBox.AllowUserToResizeRows = false;
            this.readBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.readBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.readDM,
            this.readQT,
            this.readOrderNumber,
            this.readID,
            this.readTrackingNumber,
            this.readTimeIn});
            this.readBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.readBox.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.readBox.GridColor = System.Drawing.SystemColors.HotTrack;
            this.readBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.readBox.Location = new System.Drawing.Point(0, 0);
            this.readBox.MultiSelect = false;
            this.readBox.Name = "readBox";
            this.readBox.ReadOnly = true;
            this.readBox.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.readBox.Size = new System.Drawing.Size(915, 386);
            this.readBox.StandardTab = true;
            this.readBox.TabIndex = 11;
            this.readBox.TabStop = false;
            this.readBox.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.readBox_CellMouseClick);
            // 
            // readDM
            // 
            this.readDM.HeaderText = "DM";
            this.readDM.Name = "readDM";
            this.readDM.ReadOnly = true;
            // 
            // readQT
            // 
            this.readQT.HeaderText = "QT";
            this.readQT.Name = "readQT";
            this.readQT.ReadOnly = true;
            this.readQT.Width = 77;
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
            // readTimeIn
            // 
            this.readTimeIn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.readTimeIn.HeaderText = "TimeIn";
            this.readTimeIn.Name = "readTimeIn";
            this.readTimeIn.ReadOnly = true;
            // 
            // panelReadBox
            // 
            this.panelReadBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelReadBox.Controls.Add(this.readBox);
            this.panelReadBox.Location = new System.Drawing.Point(23, 220);
            this.panelReadBox.Name = "panelReadBox";
            this.panelReadBox.Size = new System.Drawing.Size(917, 388);
            this.panelReadBox.TabIndex = 12;
            // 
            // panelOrderStatus
            // 
            this.panelOrderStatus.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrderStatus.Controls.Add(this.label6);
            this.panelOrderStatus.Controls.Add(this.tableLayoutPanel2);
            this.panelOrderStatus.Location = new System.Drawing.Point(617, 27);
            this.panelOrderStatus.Name = "panelOrderStatus";
            this.panelOrderStatus.Size = new System.Drawing.Size(389, 152);
            this.panelOrderStatus.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label6.Location = new System.Drawing.Point(16, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 36);
            this.label6.TabIndex = 17;
            this.label6.Text = "Check Order";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.76389F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.23611F));
            this.tableLayoutPanel2.Controls.Add(this.inputOrderStatus, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnCheckOrder, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.lblStatusOrder, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.lblOrderStatusNumber, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 71);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(387, 79);
            this.tableLayoutPanel2.TabIndex = 16;
            // 
            // inputOrderStatus
            // 
            this.inputOrderStatus.Location = new System.Drawing.Point(3, 3);
            this.inputOrderStatus.Name = "inputOrderStatus";
            this.inputOrderStatus.Size = new System.Drawing.Size(93, 20);
            this.inputOrderStatus.TabIndex = 19;
            this.inputOrderStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputOrderStatus_KeyDown);
            // 
            // btnCheckOrder
            // 
            this.btnCheckOrder.Location = new System.Drawing.Point(141, 3);
            this.btnCheckOrder.Name = "btnCheckOrder";
            this.btnCheckOrder.Size = new System.Drawing.Size(179, 33);
            this.btnCheckOrder.TabIndex = 20;
            this.btnCheckOrder.Text = "Check Order";
            this.btnCheckOrder.UseVisualStyleBackColor = true;
            this.btnCheckOrder.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // lblStatusOrder
            // 
            this.lblStatusOrder.AutoSize = true;
            this.lblStatusOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblStatusOrder.Location = new System.Drawing.Point(141, 39);
            this.lblStatusOrder.Name = "lblStatusOrder";
            this.lblStatusOrder.Size = new System.Drawing.Size(0, 17);
            this.lblStatusOrder.TabIndex = 21;
            // 
            // lblOrderStatusNumber
            // 
            this.lblOrderStatusNumber.AutoSize = true;
            this.lblOrderStatusNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblOrderStatusNumber.Location = new System.Drawing.Point(3, 39);
            this.lblOrderStatusNumber.Name = "lblOrderStatusNumber";
            this.lblOrderStatusNumber.Size = new System.Drawing.Size(0, 17);
            this.lblOrderStatusNumber.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label5.Location = new System.Drawing.Point(159, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 36);
            this.label5.TabIndex = 2;
            this.label5.Text = "Input Orders";
            // 
            // panelInput
            // 
            this.panelInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInput.Controls.Add(this.label5);
            this.panelInput.Controls.Add(this.tableLayoutPanel1);
            this.panelInput.Location = new System.Drawing.Point(23, 27);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(576, 152);
            this.panelInput.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.15756F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.285463F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.10747F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.10747F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 27.34203F));
            this.tableLayoutPanel1.Controls.Add(this.listDM, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.input3, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.input2, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.input1, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.listQT, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 65);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(574, 85);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // listDM
            // 
            this.listDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listDM.FormattingEnabled = true;
            this.listDM.Items.AddRange(new object[] {
            "4x4x4"});
            this.listDM.Location = new System.Drawing.Point(3, 51);
            this.listDM.Name = "listDM";
            this.listDM.Size = new System.Drawing.Size(75, 21);
            this.listDM.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(84, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 48);
            this.label4.TabIndex = 5;
            this.label4.Text = "QT";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(419, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 48);
            this.label3.TabIndex = 0;
            this.label3.Text = "Tracking Number";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(275, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Employee ID";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(131, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Order Number";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // input3
            // 
            this.input3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input3.Location = new System.Drawing.Point(419, 51);
            this.input3.Name = "input3";
            this.input3.Size = new System.Drawing.Size(152, 20);
            this.input3.TabIndex = 3;
            this.input3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input3_KeyDown);
            // 
            // input2
            // 
            this.input2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input2.Location = new System.Drawing.Point(275, 51);
            this.input2.Name = "input2";
            this.input2.Size = new System.Drawing.Size(138, 20);
            this.input2.TabIndex = 2;
            this.input2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input2_KeyDown);
            // 
            // input1
            // 
            this.input1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.input1.Location = new System.Drawing.Point(131, 51);
            this.input1.Name = "input1";
            this.input1.Size = new System.Drawing.Size(138, 20);
            this.input1.TabIndex = 1;
            this.input1.TextChanged += new System.EventHandler(this.input1_TextChanged);
            this.input1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input1_KeyDown);
            // 
            // listQT
            // 
            this.listQT.FormattingEnabled = true;
            this.listQT.Location = new System.Drawing.Point(84, 51);
            this.listQT.Name = "listQT";
            this.listQT.Size = new System.Drawing.Size(38, 21);
            this.listQT.TabIndex = 4;
            this.listQT.SelectedIndexChanged += new System.EventHandler(this.listQT_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 48);
            this.label7.TabIndex = 6;
            this.label7.Text = "DM";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelOrderStatus);
            this.Controls.Add(this.panelReadBox);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.readBox)).EndInit();
            this.panelReadBox.ResumeLayout(false);
            this.panelOrderStatus.ResumeLayout(false);
            this.panelOrderStatus.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView readBox;
        private System.Windows.Forms.Panel panelReadBox;
        private System.Windows.Forms.Panel panelOrderStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox inputOrderStatus;
        private System.Windows.Forms.Button btnCheckOrder;
        private System.Windows.Forms.Label lblStatusOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox input3;
        private System.Windows.Forms.TextBox input2;
        private System.Windows.Forms.TextBox input1;
        private System.Windows.Forms.ComboBox listQT;
        private System.Windows.Forms.Label lblOrderStatusNumber;
        private System.Windows.Forms.ComboBox listDM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn readDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn readQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn readOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn readID;
        private System.Windows.Forms.DataGridViewTextBoxColumn readTrackingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn readTimeIn;
    }
}

