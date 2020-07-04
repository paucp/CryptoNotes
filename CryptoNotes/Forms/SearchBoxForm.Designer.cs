namespace CryptoNotes
{
    partial class SearchBox
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
            this.textBoxKeyword = new System.Windows.Forms.TextBox();
            this.buttonFind = new System.Windows.Forms.Button();
            this.panelPasswordTextbox = new System.Windows.Forms.Panel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrev = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Black;
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Location = new System.Drawing.Point(-2, -1);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(330, 40);
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
            this.labelHeader.Size = new System.Drawing.Size(69, 18);
            this.labelHeader.TabIndex = 23;
            this.labelHeader.Text = "Keyword:";
            // 
            // textBoxKeyword
            // 
            this.textBoxKeyword.BackColor = System.Drawing.Color.White;
            this.textBoxKeyword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxKeyword.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxKeyword.ForeColor = System.Drawing.Color.Black;
            this.textBoxKeyword.Location = new System.Drawing.Point(5, 50);
            this.textBoxKeyword.Name = "textBoxKeyword";
            this.textBoxKeyword.ShortcutsEnabled = false;
            this.textBoxKeyword.Size = new System.Drawing.Size(310, 19);
            this.textBoxKeyword.TabIndex = 24;
            this.textBoxKeyword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxKeyword.TextChanged += new System.EventHandler(this.textBoxKeyword_TextChanged);
            // 
            // buttonFind
            // 
            this.buttonFind.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonFind.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonFind.FlatAppearance.BorderSize = 0;
            this.buttonFind.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonFind.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFind.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFind.Location = new System.Drawing.Point(10, 90);
            this.buttonFind.Name = "buttonFind";
            this.buttonFind.Size = new System.Drawing.Size(86, 35);
            this.buttonFind.TabIndex = 22;
            this.buttonFind.TabStop = false;
            this.buttonFind.Text = "Find";
            this.buttonFind.UseVisualStyleBackColor = false;
            this.buttonFind.Click += new System.EventHandler(this.buttonFind_Click);
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
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonNext.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonNext.FlatAppearance.BorderSize = 0;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonNext.Location = new System.Drawing.Point(102, 90);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(86, 35);
            this.buttonNext.TabIndex = 27;
            this.buttonNext.TabStop = false;
            this.buttonNext.Text = "Find next";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrev
            // 
            this.buttonPrev.BackColor = System.Drawing.Color.Gainsboro;
            this.buttonPrev.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPrev.FlatAppearance.BorderSize = 0;
            this.buttonPrev.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonPrev.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.buttonPrev.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrev.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPrev.Location = new System.Drawing.Point(194, 90);
            this.buttonPrev.Name = "buttonPrev";
            this.buttonPrev.Size = new System.Drawing.Size(113, 35);
            this.buttonPrev.TabIndex = 28;
            this.buttonPrev.TabStop = false;
            this.buttonPrev.Text = "Find previous";
            this.buttonPrev.UseVisualStyleBackColor = false;
            this.buttonPrev.Click += new System.EventHandler(this.buttonPrev_Click);
            // 
            // SearchBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(319, 137);
            this.Controls.Add(this.buttonPrev);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.panelPasswordTextbox);
            this.Controls.Add(this.textBoxKeyword);
            this.Controls.Add(this.buttonFind);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SearchBox";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SearchBox_FormClosing);
            this.Shown += new System.EventHandler(this.SearchBox_Shown);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.TextBox textBoxKeyword;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Button buttonFind;
        private System.Windows.Forms.Panel panelPasswordTextbox;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonPrev;
    }
}