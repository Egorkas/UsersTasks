
namespace UsersTasks
{
    partial class UserTasks
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
            this.inputNameOfTasktextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputDescriptionOfTasktextBox = new System.Windows.Forms.TextBox();
            this.startDtp = new System.Windows.Forms.DateTimePicker();
            this.deadLineDtp = new System.Windows.Forms.DateTimePicker();
            this.statusTaskCmbBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.adding_Task_btn = new System.Windows.Forms.Button();
            this.canсel_Task_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputNameOfTasktextBox
            // 
            this.inputNameOfTasktextBox.Location = new System.Drawing.Point(60, 52);
            this.inputNameOfTasktextBox.Name = "inputNameOfTasktextBox";
            this.inputNameOfTasktextBox.Size = new System.Drawing.Size(200, 20);
            this.inputNameOfTasktextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "StartTask";
            // 
            // inputDescriptionOfTasktextBox
            // 
            this.inputDescriptionOfTasktextBox.Location = new System.Drawing.Point(60, 118);
            this.inputDescriptionOfTasktextBox.Name = "inputDescriptionOfTasktextBox";
            this.inputDescriptionOfTasktextBox.Size = new System.Drawing.Size(200, 20);
            this.inputDescriptionOfTasktextBox.TabIndex = 9;
            // 
            // startDtp
            // 
            this.startDtp.Location = new System.Drawing.Point(60, 178);
            this.startDtp.Name = "startDtp";
            this.startDtp.Size = new System.Drawing.Size(200, 20);
            this.startDtp.TabIndex = 10;
            // 
            // deadLineDtp
            // 
            this.deadLineDtp.Location = new System.Drawing.Point(60, 245);
            this.deadLineDtp.Name = "deadLineDtp";
            this.deadLineDtp.Size = new System.Drawing.Size(200, 20);
            this.deadLineDtp.TabIndex = 11;
            // 
            // statusTaskCmbBox
            // 
            this.statusTaskCmbBox.FormattingEnabled = true;
            this.statusTaskCmbBox.Items.AddRange(new object[] {
            "Active",
            "Done",
            "YouAreFired"});
            this.statusTaskCmbBox.Location = new System.Drawing.Point(60, 319);
            this.statusTaskCmbBox.Name = "statusTaskCmbBox";
            this.statusTaskCmbBox.Size = new System.Drawing.Size(200, 21);
            this.statusTaskCmbBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "NameOfTask";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "DescriptionOfTask";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 303);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Status";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "DeadLine";
            // 
            // adding_Task_btn
            // 
            
            this.adding_Task_btn.Location = new System.Drawing.Point(60, 381);
            this.adding_Task_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.adding_Task_btn.Name = "adding_Task_btn";
            this.adding_Task_btn.Size = new System.Drawing.Size(75, 23);
            this.adding_Task_btn.TabIndex = 17;
            this.adding_Task_btn.Text = "Add";
            this.adding_Task_btn.UseVisualStyleBackColor = true;
            // 
            // canсel_Task_btn
            // 
            
            this.canсel_Task_btn.Location = new System.Drawing.Point(185, 381);
            this.canсel_Task_btn.Name = "canсel_Task_btn";
            this.canсel_Task_btn.Size = new System.Drawing.Size(75, 23);
            this.canсel_Task_btn.TabIndex = 18;
            this.canсel_Task_btn.Text = "Cancel";
            this.canсel_Task_btn.UseVisualStyleBackColor = true;
            this.adding_Task_btn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            // 
            // UserTasks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 450);
            this.Controls.Add(this.canсel_Task_btn);
            this.Controls.Add(this.adding_Task_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusTaskCmbBox);
            this.Controls.Add(this.deadLineDtp);
            this.Controls.Add(this.startDtp);
            this.Controls.Add(this.inputDescriptionOfTasktextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputNameOfTasktextBox);
            this.Name = "UserTasks";
            this.Text = "UserTasks";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.TextBox inputNameOfTasktextBox;
        private System.Windows.Forms.Label label1;
        internal System.Windows.Forms.TextBox inputDescriptionOfTasktextBox;
        internal System.Windows.Forms.DateTimePicker startDtp;
        internal System.Windows.Forms.DateTimePicker deadLineDtp;
        internal System.Windows.Forms.ComboBox statusTaskCmbBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button adding_Task_btn;
        private System.Windows.Forms.Button canсel_Task_btn;
    }
}