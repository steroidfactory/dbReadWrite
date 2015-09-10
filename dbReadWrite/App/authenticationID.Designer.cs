namespace App
{
    partial class authenticationID
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
            this.inputLoginID = new System.Windows.Forms.TextBox();
            this.btnLoginID = new System.Windows.Forms.Button();
            this.btnInputIDCancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inputLoginID
            // 
            this.inputLoginID.Location = new System.Drawing.Point(51, 43);
            this.inputLoginID.Name = "inputLoginID";
            this.inputLoginID.PasswordChar = '*';
            this.inputLoginID.Size = new System.Drawing.Size(100, 20);
            this.inputLoginID.TabIndex = 0;
            this.inputLoginID.TextChanged += new System.EventHandler(this.inputLoginID_TextChanged);
            this.inputLoginID.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputLoginID_KeyDown);
            // 
            // btnLoginID
            // 
            this.btnLoginID.Location = new System.Drawing.Point(26, 80);
            this.btnLoginID.Name = "btnLoginID";
            this.btnLoginID.Size = new System.Drawing.Size(68, 23);
            this.btnLoginID.TabIndex = 1;
            this.btnLoginID.Text = "OK";
            this.btnLoginID.UseVisualStyleBackColor = true;
            this.btnLoginID.Click += new System.EventHandler(this.btnLoginID_Click);
            // 
            // btnInputIDCancel
            // 
            this.btnInputIDCancel.Location = new System.Drawing.Point(113, 80);
            this.btnInputIDCancel.Name = "btnInputIDCancel";
            this.btnInputIDCancel.Size = new System.Drawing.Size(68, 23);
            this.btnInputIDCancel.TabIndex = 2;
            this.btnInputIDCancel.Text = "Cancel";
            this.btnInputIDCancel.UseVisualStyleBackColor = true;
            this.btnInputIDCancel.Click += new System.EventHandler(this.btnInputIDCancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Enter Your ID";
            // 
            // authenticationID
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 125);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnInputIDCancel);
            this.Controls.Add(this.btnLoginID);
            this.Controls.Add(this.inputLoginID);
            this.Name = "authenticationID";
            this.Text = "authenticationID";
            this.Load += new System.EventHandler(this.authenticationID_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputLoginID;
        private System.Windows.Forms.Button btnLoginID;
        private System.Windows.Forms.Button btnInputIDCancel;
        private System.Windows.Forms.Label label1;
    }
}