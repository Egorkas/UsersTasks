namespace UsersTasks
{
    partial class UserData
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
            this.inputUserNameTextBox = new System.Windows.Forms.TextBox();
            this.inputUserAgeTextBox = new System.Windows.Forms.TextBox();
            this.inputUserEmailTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ruleOfUserComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.add_user_btn = new System.Windows.Forms.Button();
            this.cancel_user_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputUserNameTextBox
            // 
            this.inputUserNameTextBox.Location = new System.Drawing.Point(32, 19);
            this.inputUserNameTextBox.Name = "inputUserNameTextBox";
            this.inputUserNameTextBox.Size = new System.Drawing.Size(197, 20);
            this.inputUserNameTextBox.TabIndex = 0;
            // 
            // inputUserAgeTextBox
            // 
            this.inputUserAgeTextBox.Location = new System.Drawing.Point(32, 68);
            this.inputUserAgeTextBox.Name = "inputUserAgeTextBox";
            this.inputUserAgeTextBox.Size = new System.Drawing.Size(197, 20);
            this.inputUserAgeTextBox.TabIndex = 1;
            // 
            // inputUserEmailTextBox
            // 
            this.inputUserEmailTextBox.Location = new System.Drawing.Point(32, 122);
            this.inputUserEmailTextBox.Name = "inputUserEmailTextBox";
            this.inputUserEmailTextBox.Size = new System.Drawing.Size(196, 20);
            this.inputUserEmailTextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            //this.label1.Click += new System.EventHandler(this.UserData_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Age";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // ruleOfUserComboBox
            // 
            this.ruleOfUserComboBox.FormattingEnabled = true;
            this.ruleOfUserComboBox.Items.AddRange(new object[] {
            "Admin",
            "User"});
            this.ruleOfUserComboBox.Location = new System.Drawing.Point(32, 171);
            this.ruleOfUserComboBox.Name = "ruleOfUserComboBox";
            this.ruleOfUserComboBox.Size = new System.Drawing.Size(196, 21);
            this.ruleOfUserComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "RuleType";
            // 
            // add_user_btn
            // 
            this.add_user_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.add_user_btn.Location = new System.Drawing.Point(32, 237);
            this.add_user_btn.Name = "add_user_btn";
            this.add_user_btn.Size = new System.Drawing.Size(75, 23);
            this.add_user_btn.TabIndex = 9;
            this.add_user_btn.Text = "Add";
            this.add_user_btn.UseVisualStyleBackColor = true;
            // 
            // cancel_user_btn
            // 
            this.cancel_user_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancel_user_btn.Location = new System.Drawing.Point(153, 237);
            this.cancel_user_btn.Name = "cancel_user_btn";
            this.cancel_user_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_user_btn.TabIndex = 10;
            this.cancel_user_btn.Text = "Cancel";
            this.cancel_user_btn.UseVisualStyleBackColor = true;
            // 
            // UserData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(281, 292);
            this.Controls.Add(this.cancel_user_btn);
            this.Controls.Add(this.add_user_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ruleOfUserComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputUserEmailTextBox);
            this.Controls.Add(this.inputUserAgeTextBox);
            this.Controls.Add(this.inputUserNameTextBox);
            this.Name = "UserData";
            this.Text = "UserData";
            //this.Load += new System.EventHandler(this.UserData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox inputUserNameTextBox;
        internal System.Windows.Forms.TextBox inputUserAgeTextBox;
        internal System.Windows.Forms.TextBox inputUserEmailTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.ComboBox ruleOfUserComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button add_user_btn;
        private System.Windows.Forms.Button cancel_user_btn;
    }
}