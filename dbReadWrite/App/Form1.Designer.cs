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
            this.btnCheckOrder = new System.Windows.Forms.Button();
            this.inputOrderStatus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelInput = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listDM = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inputTracking = new System.Windows.Forms.TextBox();
            this.inputEmployee = new System.Windows.Forms.TextBox();
            this.inputOrderNumber = new System.Windows.Forms.TextBox();
            this.listQT = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panelInventory = new System.Windows.Forms.Panel();
            this.btnInventoryAdd = new System.Windows.Forms.Button();
            this.btnInventoryCheck = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.btnLoginCancel = new System.Windows.Forms.Button();
            this.inputLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.panelInventoryAdd = new System.Windows.Forms.Panel();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.inputInventoryAddHeight = new System.Windows.Forms.TextBox();
            this.inputInventoryAddWidth = new System.Windows.Forms.TextBox();
            this.inputInventoryAddQT = new System.Windows.Forms.TextBox();
            this.btnInventoryAddDone = new System.Windows.Forms.Button();
            this.inputInventoryAddLength = new System.Windows.Forms.TextBox();
            this.btnInventoryAddAdd = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.readBox)).BeginInit();
            this.panelReadBox.SuspendLayout();
            this.panelOrderStatus.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panelInventory.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panelInventoryAdd.SuspendLayout();
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
            this.readBox.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.readBox_RowHeaderMouseDoubleClick);
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
            this.panelOrderStatus.Controls.Add(this.btnCheckOrder);
            this.panelOrderStatus.Controls.Add(this.inputOrderStatus);
            this.panelOrderStatus.Controls.Add(this.label6);
            this.panelOrderStatus.Location = new System.Drawing.Point(617, 27);
            this.panelOrderStatus.Name = "panelOrderStatus";
            this.panelOrderStatus.Size = new System.Drawing.Size(183, 152);
            this.panelOrderStatus.TabIndex = 13;
            // 
            // btnCheckOrder
            // 
            this.btnCheckOrder.Location = new System.Drawing.Point(9, 104);
            this.btnCheckOrder.Name = "btnCheckOrder";
            this.btnCheckOrder.Size = new System.Drawing.Size(159, 33);
            this.btnCheckOrder.TabIndex = 20;
            this.btnCheckOrder.Text = "Check Order";
            this.btnCheckOrder.UseVisualStyleBackColor = true;
            this.btnCheckOrder.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // inputOrderStatus
            // 
            this.inputOrderStatus.Location = new System.Drawing.Point(44, 65);
            this.inputOrderStatus.Name = "inputOrderStatus";
            this.inputOrderStatus.Size = new System.Drawing.Size(93, 20);
            this.inputOrderStatus.TabIndex = 19;
            this.inputOrderStatus.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputOrderStatus_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label6.Location = new System.Drawing.Point(3, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 36);
            this.label6.TabIndex = 17;
            this.label6.Text = "Check Order";
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
            this.tableLayoutPanel1.Controls.Add(this.inputTracking, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputEmployee, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.inputOrderNumber, 2, 1);
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
            this.listDM.Location = new System.Drawing.Point(3, 51);
            this.listDM.Name = "listDM";
            this.listDM.Size = new System.Drawing.Size(75, 21);
            this.listDM.TabIndex = 7;
            this.listDM.SelectedValueChanged += new System.EventHandler(this.listDM_SelectedValueChanged);
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
            // inputTracking
            // 
            this.inputTracking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTracking.Location = new System.Drawing.Point(419, 51);
            this.inputTracking.Name = "inputTracking";
            this.inputTracking.Size = new System.Drawing.Size(152, 20);
            this.inputTracking.TabIndex = 3;
            this.inputTracking.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input3_KeyDown);
            // 
            // inputEmployee
            // 
            this.inputEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputEmployee.Location = new System.Drawing.Point(275, 51);
            this.inputEmployee.Name = "inputEmployee";
            this.inputEmployee.PasswordChar = '*';
            this.inputEmployee.Size = new System.Drawing.Size(138, 20);
            this.inputEmployee.TabIndex = 2;
            this.inputEmployee.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input2_KeyDown);
            // 
            // inputOrderNumber
            // 
            this.inputOrderNumber.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputOrderNumber.Location = new System.Drawing.Point(131, 51);
            this.inputOrderNumber.Name = "inputOrderNumber";
            this.inputOrderNumber.Size = new System.Drawing.Size(138, 20);
            this.inputOrderNumber.TabIndex = 1;
            this.inputOrderNumber.TextChanged += new System.EventHandler(this.input1_TextChanged);
            this.inputOrderNumber.KeyDown += new System.Windows.Forms.KeyEventHandler(this.input1_KeyDown);
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
            // panelInventory
            // 
            this.panelInventory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInventory.Controls.Add(this.btnInventoryAdd);
            this.panelInventory.Controls.Add(this.btnInventoryCheck);
            this.panelInventory.Controls.Add(this.label8);
            this.panelInventory.Location = new System.Drawing.Point(809, 27);
            this.panelInventory.Name = "panelInventory";
            this.panelInventory.Size = new System.Drawing.Size(164, 152);
            this.panelInventory.TabIndex = 21;
            // 
            // btnInventoryAdd
            // 
            this.btnInventoryAdd.Location = new System.Drawing.Point(14, 58);
            this.btnInventoryAdd.Name = "btnInventoryAdd";
            this.btnInventoryAdd.Size = new System.Drawing.Size(134, 33);
            this.btnInventoryAdd.TabIndex = 21;
            this.btnInventoryAdd.Text = "Add";
            this.btnInventoryAdd.UseVisualStyleBackColor = true;
            this.btnInventoryAdd.Click += new System.EventHandler(this.btnInventoryAdd_Click_1);
            // 
            // btnInventoryCheck
            // 
            this.btnInventoryCheck.Location = new System.Drawing.Point(14, 103);
            this.btnInventoryCheck.Name = "btnInventoryCheck";
            this.btnInventoryCheck.Size = new System.Drawing.Size(134, 33);
            this.btnInventoryCheck.TabIndex = 20;
            this.btnInventoryCheck.Text = "Check";
            this.btnInventoryCheck.UseVisualStyleBackColor = true;
            this.btnInventoryCheck.Click += new System.EventHandler(this.btnInventoryCheck_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label8.Location = new System.Drawing.Point(16, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 36);
            this.label8.TabIndex = 17;
            this.label8.Text = "Inventory";
            // 
            // panelLogin
            // 
            this.panelLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelLogin.Controls.Add(this.btnLoginCancel);
            this.panelLogin.Controls.Add(this.inputLogin);
            this.panelLogin.Controls.Add(this.btnLogin);
            this.panelLogin.Controls.Add(this.label9);
            this.panelLogin.Location = new System.Drawing.Point(809, 26);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(164, 152);
            this.panelLogin.TabIndex = 22;
            // 
            // btnLoginCancel
            // 
            this.btnLoginCancel.Location = new System.Drawing.Point(84, 103);
            this.btnLoginCancel.Name = "btnLoginCancel";
            this.btnLoginCancel.Size = new System.Drawing.Size(70, 33);
            this.btnLoginCancel.TabIndex = 22;
            this.btnLoginCancel.Text = "Cancel";
            this.btnLoginCancel.UseVisualStyleBackColor = true;
            this.btnLoginCancel.Click += new System.EventHandler(this.btnLoginCancel_Click);
            // 
            // inputLogin
            // 
            this.inputLogin.Location = new System.Drawing.Point(37, 66);
            this.inputLogin.Name = "inputLogin";
            this.inputLogin.PasswordChar = '*';
            this.inputLogin.Size = new System.Drawing.Size(93, 20);
            this.inputLogin.TabIndex = 21;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(8, 103);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(70, 33);
            this.btnLogin.TabIndex = 20;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label9.Location = new System.Drawing.Point(40, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 36);
            this.label9.TabIndex = 17;
            this.label9.Text = "Login";
            // 
            // panelInventoryAdd
            // 
            this.panelInventoryAdd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelInventoryAdd.Controls.Add(this.label14);
            this.panelInventoryAdd.Controls.Add(this.label13);
            this.panelInventoryAdd.Controls.Add(this.label12);
            this.panelInventoryAdd.Controls.Add(this.label11);
            this.panelInventoryAdd.Controls.Add(this.inputInventoryAddHeight);
            this.panelInventoryAdd.Controls.Add(this.inputInventoryAddWidth);
            this.panelInventoryAdd.Controls.Add(this.inputInventoryAddQT);
            this.panelInventoryAdd.Controls.Add(this.btnInventoryAddDone);
            this.panelInventoryAdd.Controls.Add(this.inputInventoryAddLength);
            this.panelInventoryAdd.Controls.Add(this.btnInventoryAddAdd);
            this.panelInventoryAdd.Controls.Add(this.label10);
            this.panelInventoryAdd.Location = new System.Drawing.Point(809, 26);
            this.panelInventoryAdd.Name = "panelInventoryAdd";
            this.panelInventoryAdd.Size = new System.Drawing.Size(164, 152);
            this.panelInventoryAdd.TabIndex = 23;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(124, 50);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(22, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "QT";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(74, 50);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(15, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "H";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(42, 50);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "W";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(11, 50);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(13, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "L";
            // 
            // inputInventoryAddHeight
            // 
            this.inputInventoryAddHeight.Location = new System.Drawing.Point(66, 66);
            this.inputInventoryAddHeight.Name = "inputInventoryAddHeight";
            this.inputInventoryAddHeight.Size = new System.Drawing.Size(23, 20);
            this.inputInventoryAddHeight.TabIndex = 27;
            // 
            // inputInventoryAddWidth
            // 
            this.inputInventoryAddWidth.Location = new System.Drawing.Point(37, 66);
            this.inputInventoryAddWidth.Name = "inputInventoryAddWidth";
            this.inputInventoryAddWidth.Size = new System.Drawing.Size(23, 20);
            this.inputInventoryAddWidth.TabIndex = 26;
            // 
            // inputInventoryAddQT
            // 
            this.inputInventoryAddQT.Location = new System.Drawing.Point(118, 66);
            this.inputInventoryAddQT.Name = "inputInventoryAddQT";
            this.inputInventoryAddQT.Size = new System.Drawing.Size(36, 20);
            this.inputInventoryAddQT.TabIndex = 25;
            // 
            // btnInventoryAddDone
            // 
            this.btnInventoryAddDone.Location = new System.Drawing.Point(84, 103);
            this.btnInventoryAddDone.Name = "btnInventoryAddDone";
            this.btnInventoryAddDone.Size = new System.Drawing.Size(70, 33);
            this.btnInventoryAddDone.TabIndex = 22;
            this.btnInventoryAddDone.Text = "Done";
            this.btnInventoryAddDone.UseVisualStyleBackColor = true;
            this.btnInventoryAddDone.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // inputInventoryAddLength
            // 
            this.inputInventoryAddLength.Location = new System.Drawing.Point(8, 66);
            this.inputInventoryAddLength.Name = "inputInventoryAddLength";
            this.inputInventoryAddLength.Size = new System.Drawing.Size(23, 20);
            this.inputInventoryAddLength.TabIndex = 21;
            // 
            // btnInventoryAddAdd
            // 
            this.btnInventoryAddAdd.Location = new System.Drawing.Point(8, 103);
            this.btnInventoryAddAdd.Name = "btnInventoryAddAdd";
            this.btnInventoryAddAdd.Size = new System.Drawing.Size(70, 33);
            this.btnInventoryAddAdd.TabIndex = 20;
            this.btnInventoryAddAdd.Text = "Add";
            this.btnInventoryAddAdd.UseVisualStyleBackColor = true;
            this.btnInventoryAddAdd.Click += new System.EventHandler(this.btnInventoryAddAdd_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.label10.Location = new System.Drawing.Point(3, 14);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 36);
            this.label10.TabIndex = 17;
            this.label10.Text = "Add Invent.";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1008, 682);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.panelReadBox);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelInventory);
            this.Controls.Add(this.panelOrderStatus);
            this.Controls.Add(this.panelInventoryAdd);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.readBox)).EndInit();
            this.panelReadBox.ResumeLayout(false);
            this.panelOrderStatus.ResumeLayout(false);
            this.panelOrderStatus.PerformLayout();
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panelInventory.ResumeLayout(false);
            this.panelInventory.PerformLayout();
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelInventoryAdd.ResumeLayout(false);
            this.panelInventoryAdd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView readBox;
        private System.Windows.Forms.Panel panelReadBox;
        private System.Windows.Forms.Panel panelOrderStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox inputOrderStatus;
        private System.Windows.Forms.Button btnCheckOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelInput;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputTracking;
        private System.Windows.Forms.TextBox inputEmployee;
        private System.Windows.Forms.TextBox inputOrderNumber;
        private System.Windows.Forms.ComboBox listQT;
        private System.Windows.Forms.ComboBox listDM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn readDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn readQT;
        private System.Windows.Forms.DataGridViewTextBoxColumn readOrderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn readID;
        private System.Windows.Forms.DataGridViewTextBoxColumn readTrackingNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn readTimeIn;
        private System.Windows.Forms.Panel panelInventory;
        private System.Windows.Forms.Button btnInventoryAdd;
        private System.Windows.Forms.Button btnInventoryCheck;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Button btnLoginCancel;
        private System.Windows.Forms.TextBox inputLogin;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panelInventoryAdd;
        private System.Windows.Forms.Button btnInventoryAddDone;
        private System.Windows.Forms.TextBox inputInventoryAddLength;
        private System.Windows.Forms.Button btnInventoryAddAdd;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox inputInventoryAddQT;
        private System.Windows.Forms.TextBox inputInventoryAddHeight;
        private System.Windows.Forms.TextBox inputInventoryAddWidth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
    }
}

