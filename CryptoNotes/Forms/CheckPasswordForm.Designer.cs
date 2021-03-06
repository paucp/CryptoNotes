﻿namespace CryptoNotes
{
    partial class CheckPasswordForm
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
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.buttonCleanup = new System.Windows.Forms.Button();
            this.panelPasswordTextbox = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Black;
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Location = new System.Drawing.Point(-2, -1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(329, 40);
            this.panelHeader.TabIndex = 14;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(14, 11);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(79, 19);
            this.labelHeader.TabIndex = 23;
            this.labelHeader.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.White;
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword.ForeColor = System.Drawing.Color.Black;
            this.textBoxPassword.Location = new System.Drawing.Point(5, 50);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.ShortcutsEnabled = false;
            this.textBoxPassword.Size = new System.Drawing.Size(310, 18);
            this.textBoxPassword.TabIndex = 24;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonLogin.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLogin.FlatAppearance.BorderSize = 0;
            this.buttonLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogin.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(133, 85);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(182, 35);
            this.buttonLogin.TabIndex = 22;
            this.buttonLogin.TabStop = false;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // buttonCleanup
            // 
            this.buttonCleanup.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCleanup.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonCleanup.FlatAppearance.BorderSize = 0;
            this.buttonCleanup.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonCleanup.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonCleanup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCleanup.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCleanup.Location = new System.Drawing.Point(8, 85);
            this.buttonCleanup.Name = "buttonCleanup";
            this.buttonCleanup.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCleanup.Size = new System.Drawing.Size(119, 35);
            this.buttonCleanup.TabIndex = 25;
            this.buttonCleanup.TabStop = false;
            this.buttonCleanup.Text = "Wipe data";
            this.buttonCleanup.UseVisualStyleBackColor = false;
            this.buttonCleanup.Click += new System.EventHandler(this.buttonCleanup_Click);
            // 
            // panelPasswordTextbox
            // 
            this.panelPasswordTextbox.BackColor = System.Drawing.Color.Gainsboro;
            this.panelPasswordTextbox.Location = new System.Drawing.Point(10, 72);
            this.panelPasswordTextbox.Name = "panelPasswordTextbox";
            this.panelPasswordTextbox.Size = new System.Drawing.Size(300, 2);
            this.panelPasswordTextbox.TabIndex = 26;
            this.panelPasswordTextbox.TabStop = true;
            // 
            // CheckPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(321, 130);
            this.Controls.Add(this.panelPasswordTextbox);
            this.Controls.Add(this.buttonCleanup);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "CheckPasswordForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Login";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.Button buttonCleanup;
        private System.Windows.Forms.Panel panelPasswordTextbox;
    }
}