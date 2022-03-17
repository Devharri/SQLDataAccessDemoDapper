
namespace FormUI
{
    partial class Dashboard
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
            this.PeopleFoundListBox = new System.Windows.Forms.ListBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.FirstNameInsertLabel = new System.Windows.Forms.Label();
            this.FirstNameInsertTextBox = new System.Windows.Forms.TextBox();
            this.LastNameInsertLabel = new System.Windows.Forms.Label();
            this.LastNameInsertTextBox = new System.Windows.Forms.TextBox();
            this.EmailAddressInsertLabel = new System.Windows.Forms.Label();
            this.EmailAddressInsertTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberInsertLabel = new System.Windows.Forms.Label();
            this.PhoneNumberInsertTextBox = new System.Windows.Forms.TextBox();
            this.InsertRecordButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PeopleFoundListBox
            // 
            this.PeopleFoundListBox.BackColor = System.Drawing.SystemColors.Window;
            this.PeopleFoundListBox.FormattingEnabled = true;
            this.PeopleFoundListBox.ItemHeight = 25;
            this.PeopleFoundListBox.Location = new System.Drawing.Point(51, 168);
            this.PeopleFoundListBox.Name = "PeopleFoundListBox";
            this.PeopleFoundListBox.Size = new System.Drawing.Size(449, 479);
            this.PeopleFoundListBox.TabIndex = 0;
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(182, 70);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(318, 31);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(46, 73);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(115, 25);
            this.LastNameLabel.TabIndex = 2;
            this.LastNameLabel.Text = "Last Name";
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(226, 112);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(98, 46);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // FirstNameInsertLabel
            // 
            this.FirstNameInsertLabel.AutoSize = true;
            this.FirstNameInsertLabel.Location = new System.Drawing.Point(559, 73);
            this.FirstNameInsertLabel.Name = "FirstNameInsertLabel";
            this.FirstNameInsertLabel.Size = new System.Drawing.Size(116, 25);
            this.FirstNameInsertLabel.TabIndex = 5;
            this.FirstNameInsertLabel.Text = "First Name";
            // 
            // FirstNameInsertTextBox
            // 
            this.FirstNameInsertTextBox.Location = new System.Drawing.Point(715, 70);
            this.FirstNameInsertTextBox.Name = "FirstNameInsertTextBox";
            this.FirstNameInsertTextBox.Size = new System.Drawing.Size(318, 31);
            this.FirstNameInsertTextBox.TabIndex = 4;
            // 
            // LastNameInsertLabel
            // 
            this.LastNameInsertLabel.AutoSize = true;
            this.LastNameInsertLabel.Location = new System.Drawing.Point(559, 123);
            this.LastNameInsertLabel.Name = "LastNameInsertLabel";
            this.LastNameInsertLabel.Size = new System.Drawing.Size(115, 25);
            this.LastNameInsertLabel.TabIndex = 7;
            this.LastNameInsertLabel.Text = "Last Name";
            // 
            // LastNameInsertTextBox
            // 
            this.LastNameInsertTextBox.Location = new System.Drawing.Point(715, 120);
            this.LastNameInsertTextBox.Name = "LastNameInsertTextBox";
            this.LastNameInsertTextBox.Size = new System.Drawing.Size(318, 31);
            this.LastNameInsertTextBox.TabIndex = 6;
            // 
            // EmailAddressInsertLabel
            // 
            this.EmailAddressInsertLabel.AutoSize = true;
            this.EmailAddressInsertLabel.Location = new System.Drawing.Point(559, 173);
            this.EmailAddressInsertLabel.Name = "EmailAddressInsertLabel";
            this.EmailAddressInsertLabel.Size = new System.Drawing.Size(150, 25);
            this.EmailAddressInsertLabel.TabIndex = 9;
            this.EmailAddressInsertLabel.Text = "Email Address";
            // 
            // EmailAddressInsertTextBox
            // 
            this.EmailAddressInsertTextBox.Location = new System.Drawing.Point(715, 170);
            this.EmailAddressInsertTextBox.Name = "EmailAddressInsertTextBox";
            this.EmailAddressInsertTextBox.Size = new System.Drawing.Size(318, 31);
            this.EmailAddressInsertTextBox.TabIndex = 8;
            // 
            // PhoneNumberInsertLabel
            // 
            this.PhoneNumberInsertLabel.AutoSize = true;
            this.PhoneNumberInsertLabel.Location = new System.Drawing.Point(559, 223);
            this.PhoneNumberInsertLabel.Name = "PhoneNumberInsertLabel";
            this.PhoneNumberInsertLabel.Size = new System.Drawing.Size(155, 25);
            this.PhoneNumberInsertLabel.TabIndex = 11;
            this.PhoneNumberInsertLabel.Text = "Phone Number";
            // 
            // PhoneNumberInsertTextBox
            // 
            this.PhoneNumberInsertTextBox.Location = new System.Drawing.Point(715, 220);
            this.PhoneNumberInsertTextBox.Name = "PhoneNumberInsertTextBox";
            this.PhoneNumberInsertTextBox.Size = new System.Drawing.Size(318, 31);
            this.PhoneNumberInsertTextBox.TabIndex = 10;
            // 
            // InsertRecordButton
            // 
            this.InsertRecordButton.Location = new System.Drawing.Point(715, 271);
            this.InsertRecordButton.Name = "InsertRecordButton";
            this.InsertRecordButton.Size = new System.Drawing.Size(98, 46);
            this.InsertRecordButton.TabIndex = 12;
            this.InsertRecordButton.Text = "Insert";
            this.InsertRecordButton.UseVisualStyleBackColor = true;
            this.InsertRecordButton.Click += new System.EventHandler(this.InsertRecordButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(516, 601);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(98, 46);
            this.DeleteButton.TabIndex = 13;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1076, 668);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.InsertRecordButton);
            this.Controls.Add(this.PhoneNumberInsertLabel);
            this.Controls.Add(this.PhoneNumberInsertTextBox);
            this.Controls.Add(this.EmailAddressInsertLabel);
            this.Controls.Add(this.EmailAddressInsertTextBox);
            this.Controls.Add(this.LastNameInsertLabel);
            this.Controls.Add(this.LastNameInsertTextBox);
            this.Controls.Add(this.FirstNameInsertLabel);
            this.Controls.Add(this.FirstNameInsertTextBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.PeopleFoundListBox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Dashboard";
            this.Text = "SQL Data Access Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox PeopleFoundListBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.Label FirstNameInsertLabel;
        private System.Windows.Forms.TextBox FirstNameInsertTextBox;
        private System.Windows.Forms.Label LastNameInsertLabel;
        private System.Windows.Forms.TextBox LastNameInsertTextBox;
        private System.Windows.Forms.Label EmailAddressInsertLabel;
        private System.Windows.Forms.TextBox EmailAddressInsertTextBox;
        private System.Windows.Forms.Label PhoneNumberInsertLabel;
        private System.Windows.Forms.TextBox PhoneNumberInsertTextBox;
        private System.Windows.Forms.Button InsertRecordButton;
        private System.Windows.Forms.Button DeleteButton;
    }
}

