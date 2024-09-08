namespace GymRegister
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
            this.btnAdminProcedures = new System.Windows.Forms.Button();
            this.btnCustomerTransactions = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdminProcedures
            // 
            this.btnAdminProcedures.BackColor = System.Drawing.Color.LimeGreen;
            this.btnAdminProcedures.Location = new System.Drawing.Point(12, 35);
            this.btnAdminProcedures.Name = "btnAdminProcedures";
            this.btnAdminProcedures.Size = new System.Drawing.Size(154, 67);
            this.btnAdminProcedures.TabIndex = 0;
            this.btnAdminProcedures.Text = "ADMIN PROCEDURES";
            this.btnAdminProcedures.UseVisualStyleBackColor = false;
            this.btnAdminProcedures.Click += new System.EventHandler(this.btnAdminProcedures_Click);
            // 
            // btnCustomerTransactions
            // 
            this.btnCustomerTransactions.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnCustomerTransactions.Location = new System.Drawing.Point(259, 35);
            this.btnCustomerTransactions.Name = "btnCustomerTransactions";
            this.btnCustomerTransactions.Size = new System.Drawing.Size(154, 67);
            this.btnCustomerTransactions.TabIndex = 1;
            this.btnCustomerTransactions.Text = "CUSTOMER TRANSACTIONS";
            this.btnCustomerTransactions.UseVisualStyleBackColor = false;
            this.btnCustomerTransactions.Click += new System.EventHandler(this.btnCustomerTransactions_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.IndianRed;
            this.btnExit.Location = new System.Drawing.Point(490, 35);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(154, 67);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GymRegister.Properties.Resources.pexels_victorfreitas_791763;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(656, 470);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCustomerTransactions);
            this.Controls.Add(this.btnAdminProcedures);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdminProcedures;
        private System.Windows.Forms.Button btnCustomerTransactions;
        private System.Windows.Forms.Button btnExit;
    }
}

