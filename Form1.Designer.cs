namespace WindowsFormGUI
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.phoneNumBox = new System.Windows.Forms.TextBox();
            this.createBtn = new System.Windows.Forms.Button();
            this.contactListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 120);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 241);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 370);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phone #:";
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(168, 112);
            this.firstNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(124, 27);
            this.firstNameBox.TabIndex = 3;
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(168, 241);
            this.lastNameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(124, 27);
            this.lastNameBox.TabIndex = 4;
            // 
            // phoneNumBox
            // 
            this.phoneNumBox.Location = new System.Drawing.Point(168, 370);
            this.phoneNumBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.phoneNumBox.Name = "phoneNumBox";
            this.phoneNumBox.Size = new System.Drawing.Size(124, 27);
            this.phoneNumBox.TabIndex = 5;
            // 
            // createBtn
            // 
            this.createBtn.Location = new System.Drawing.Point(394, 469);
            this.createBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.createBtn.Name = "createBtn";
            this.createBtn.Size = new System.Drawing.Size(188, 62);
            this.createBtn.TabIndex = 6;
            this.createBtn.Text = "Create";
            this.createBtn.UseVisualStyleBackColor = true;
            // 
            // contactListBox
            // 
            this.contactListBox.FormattingEnabled = true;
            this.contactListBox.ItemHeight = 20;
            this.contactListBox.Location = new System.Drawing.Point(678, 120);
            this.contactListBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contactListBox.Name = "contactListBox";
            this.contactListBox.Size = new System.Drawing.Size(218, 264);
            this.contactListBox.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 561);
            this.Controls.Add(this.contactListBox);
            this.Controls.Add(this.createBtn);
            this.Controls.Add(this.phoneNumBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox phoneNumBox;
        private System.Windows.Forms.Button createBtn;
        private System.Windows.Forms.ListBox contactListBox;
    }
}

