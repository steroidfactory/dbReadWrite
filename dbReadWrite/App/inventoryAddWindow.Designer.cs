namespace App
{
    partial class inventoryAddWindow
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
            this.button1 = new System.Windows.Forms.Button();
            this.inputEm = new System.Windows.Forms.TextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelLogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(42, 70);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // inputEm
            // 
            this.inputEm.Location = new System.Drawing.Point(42, 44);
            this.inputEm.Name = "inputEm";
            this.inputEm.Size = new System.Drawing.Size(100, 20);
            this.inputEm.TabIndex = 1;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.label1);
            this.panelLogin.Controls.Add(this.inputEm);
            this.panelLogin.Controls.Add(this.button1);
            this.panelLogin.Location = new System.Drawing.Point(12, 12);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(200, 110);
            this.panelLogin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please Enter Your Employee ID";
            // 
            // inventoryAddWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(219, 127);
            this.Controls.Add(this.panelLogin);
            this.Name = "inventoryAddWindow";
            this.Text = "inventoryAddWindow";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox inputEm;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label1;
    }
}