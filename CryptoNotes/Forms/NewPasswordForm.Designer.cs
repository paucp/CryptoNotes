namespace CryptoNotes
{
    partial class NewPasswordForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelHeader = new System.Windows.Forms.Label();
            this.textBoxPassword1 = new System.Windows.Forms.TextBox();
            this.textBoxPassword2 = new System.Windows.Forms.TextBox();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelPasswordTextBox1 = new System.Windows.Forms.Panel();
            this.panelPasswordTextBox2 = new System.Windows.Forms.Panel();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Black;
            this.panelHeader.Controls.Add(this.label1);
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Location = new System.Drawing.Point(-1, -2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(377, 137);
            this.panelHeader.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 72);
            this.label1.TabIndex = 19;
            this.label1.Text = "1. You must remember this password.\r\n2. It should not contain information about y" +
    "ou.\r\n3. It should be long but easy to remember.\r\n4. It its important that you do" +
    "nt use it anywhere else.";
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader.Font = new System.Drawing.Font("Roboto", 16F);
            this.labelHeader.ForeColor = System.Drawing.Color.White;
            this.labelHeader.Location = new System.Drawing.Point(13, 11);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(341, 27);
            this.labelHeader.TabIndex = 18;
            this.labelHeader.Text = "Write your master password twice";
            // 
            // textBoxPassword1
            // 
            this.textBoxPassword1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword1.Location = new System.Drawing.Point(12, 155);
            this.textBoxPassword1.Name = "textBoxPassword1";
            this.textBoxPassword1.ShortcutsEnabled = false;
            this.textBoxPassword1.Size = new System.Drawing.Size(352, 18);
            this.textBoxPassword1.TabIndex = 20;
            this.textBoxPassword1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword1.UseSystemPasswordChar = true;
            this.textBoxPassword1.Enter += new System.EventHandler(this.textBoxPassword1_Enter);
            this.textBoxPassword1.Leave += new System.EventHandler(this.textBoxPassword1_Leave);
            // 
            // textBoxPassword2
            // 
            this.textBoxPassword2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPassword2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPassword2.Location = new System.Drawing.Point(11, 188);
            this.textBoxPassword2.Name = "textBoxPassword2";
            this.textBoxPassword2.ShortcutsEnabled = false;
            this.textBoxPassword2.Size = new System.Drawing.Size(352, 18);
            this.textBoxPassword2.TabIndex = 21;
            this.textBoxPassword2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword2.UseSystemPasswordChar = true;
            this.textBoxPassword2.Enter += new System.EventHandler(this.textBoxPassword2_Enter);
            this.textBoxPassword2.Leave += new System.EventHandler(this.textBoxPassword2_Leave);
            // 
            // buttonSet
            // 
            this.buttonSet.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonSet.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.buttonSet.FlatAppearance.BorderSize = 0;
            this.buttonSet.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonSet.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSet.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSet.Location = new System.Drawing.Point(120, 234);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(244, 36);
            this.buttonSet.TabIndex = 17;
            this.buttonSet.TabStop = false;
            this.buttonSet.Text = "Set password";
            this.buttonSet.UseVisualStyleBackColor = false;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonCancel.FlatAppearance.BorderSize = 0;
            this.buttonCancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightGray;
            this.buttonCancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancel.Location = new System.Drawing.Point(11, 234);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(103, 36);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.TabStop = false;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelPasswordTextBox1
            // 
            this.panelPasswordTextBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.panelPasswordTextBox1.Location = new System.Drawing.Point(15, 180);
            this.panelPasswordTextBox1.Name = "panelPasswordTextBox1";
            this.panelPasswordTextBox1.Size = new System.Drawing.Size(329, 2);
            this.panelPasswordTextBox1.TabIndex = 27;
            this.panelPasswordTextBox1.TabStop = true;
            // 
            // panelPasswordTextBox2
            // 
            this.panelPasswordTextBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.panelPasswordTextBox2.Location = new System.Drawing.Point(15, 212);
            this.panelPasswordTextBox2.Name = "panelPasswordTextBox2";
            this.panelPasswordTextBox2.Size = new System.Drawing.Size(329, 2);
            this.panelPasswordTextBox2.TabIndex = 28;
            this.panelPasswordTextBox2.TabStop = true;
            // 
            // NewPasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(373, 282);
            this.Controls.Add(this.panelPasswordTextBox2);
            this.Controls.Add(this.panelPasswordTextBox1);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.textBoxPassword2);
            this.Controls.Add(this.textBoxPassword1);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "NewPasswordForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Master Password";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.TextBox textBoxPassword1;
        private System.Windows.Forms.TextBox textBoxPassword2;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelPasswordTextBox1;
        private System.Windows.Forms.Panel panelPasswordTextBox2;
        private System.Windows.Forms.Label label1;
    }
}