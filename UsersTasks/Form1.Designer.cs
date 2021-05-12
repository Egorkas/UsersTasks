
namespace UsersTasks
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
            this.components = new System.ComponentModel.Container();
            this.usersDgv = new System.Windows.Forms.DataGridView();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTasksDgv = new System.Windows.Forms.DataGridView();
            this.userTasksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.addUser_btn = new System.Windows.Forms.Button();
            this.changeUser_btn = new System.Windows.Forms.Button();
            this.deleteUser_btn = new System.Windows.Forms.Button();
            this.addTask_btn = new System.Windows.Forms.Button();
            this.changeTask_btn = new System.Windows.Forms.Button();
            this.deleteTask_btn = new System.Windows.Forms.Button();
            this.usersTasksDBDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userTaskDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ruleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userDTOBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usersDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTasksDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTasksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersTasksDBDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTaskDTOBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDgv
            // 
            this.usersDgv.AllowUserToAddRows = false;
            this.usersDgv.AutoGenerateColumns = false;
            this.usersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.ruleDataGridViewTextBoxColumn});
            this.usersDgv.DataSource = this.userDTOBindingSource;
            this.usersDgv.Location = new System.Drawing.Point(12, 11);
            this.usersDgv.Name = "usersDgv";
            this.usersDgv.Size = new System.Drawing.Size(445, 312);
            this.usersDgv.TabIndex = 0;
            // 
            // userTasksDgv
            // 
            this.userTasksDgv.AllowUserToAddRows = false;
            this.userTasksDgv.AutoGenerateColumns = false;
            this.userTasksDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTasksDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.userIdDataGridViewTextBoxColumn});
            this.userTasksDgv.DataSource = this.userTaskDTOBindingSource;
            this.userTasksDgv.Location = new System.Drawing.Point(493, 14);
            this.userTasksDgv.Name = "userTasksDgv";
            this.userTasksDgv.Size = new System.Drawing.Size(535, 309);
            this.userTasksDgv.TabIndex = 1;
            // 
            // addUser_btn
            // 
            this.addUser_btn.Location = new System.Drawing.Point(12, 363);
            this.addUser_btn.Name = "addUser_btn";
            this.addUser_btn.Size = new System.Drawing.Size(75, 23);
            this.addUser_btn.TabIndex = 2;
            this.addUser_btn.Text = "AddUser";
            this.addUser_btn.UseVisualStyleBackColor = true;
            this.addUser_btn.Click += new System.EventHandler(this.addUser_btn_Click);
            // 
            // changeUser_btn
            // 
            this.changeUser_btn.Location = new System.Drawing.Point(115, 363);
            this.changeUser_btn.Name = "changeUser_btn";
            this.changeUser_btn.Size = new System.Drawing.Size(75, 23);
            this.changeUser_btn.TabIndex = 3;
            this.changeUser_btn.Text = "ChangeUser";
            this.changeUser_btn.UseVisualStyleBackColor = true;
            this.changeUser_btn.Click += new System.EventHandler(this.changeUser_btn_Click);
            // 
            // deleteUser_btn
            // 
            this.deleteUser_btn.Location = new System.Drawing.Point(211, 363);
            this.deleteUser_btn.Name = "deleteUser_btn";
            this.deleteUser_btn.Size = new System.Drawing.Size(75, 23);
            this.deleteUser_btn.TabIndex = 4;
            this.deleteUser_btn.Text = "DeleteUser";
            this.deleteUser_btn.UseVisualStyleBackColor = true;
            this.deleteUser_btn.Click += new System.EventHandler(this.deleteUser_btn_Click);
            // 
            // addTask_btn
            // 
            this.addTask_btn.Location = new System.Drawing.Point(559, 363);
            this.addTask_btn.Name = "addTask_btn";
            this.addTask_btn.Size = new System.Drawing.Size(75, 23);
            this.addTask_btn.TabIndex = 5;
            this.addTask_btn.Text = "AddTask";
            this.addTask_btn.UseVisualStyleBackColor = true;
            this.addTask_btn.Click += new System.EventHandler(this.addTask_btn_Click);
            // 
            // changeTask_btn
            // 
            this.changeTask_btn.Location = new System.Drawing.Point(666, 363);
            this.changeTask_btn.Name = "changeTask_btn";
            this.changeTask_btn.Size = new System.Drawing.Size(89, 23);
            this.changeTask_btn.TabIndex = 6;
            this.changeTask_btn.Text = "ChangeTask";
            this.changeTask_btn.UseVisualStyleBackColor = true;
            this.changeTask_btn.Click += new System.EventHandler(this.changeTask_btn_Click);
            // 
            // deleteTask_btn
            // 
            this.deleteTask_btn.Location = new System.Drawing.Point(770, 363);
            this.deleteTask_btn.Name = "deleteTask_btn";
            this.deleteTask_btn.Size = new System.Drawing.Size(75, 23);
            this.deleteTask_btn.TabIndex = 7;
            this.deleteTask_btn.Text = "DeleteTask";
            this.deleteTask_btn.UseVisualStyleBackColor = true;
            this.deleteTask_btn.Click += new System.EventHandler(this.deleteTask_btn_Click);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "NameOfTask";
            this.dataGridViewTextBoxColumn3.HeaderText = "NameOfTask";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Description";
            this.dataGridViewTextBoxColumn4.HeaderText = "Description";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "StartOfTask";
            this.dataGridViewTextBoxColumn5.HeaderText = "StartOfTask";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "DeadLine";
            this.dataGridViewTextBoxColumn6.HeaderText = "DeadLine";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Status";
            this.dataGridViewTextBoxColumn7.HeaderText = "Status";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            // 
            // userTaskDTOBindingSource
            // 
            this.userTaskDTOBindingSource.DataSource = typeof(TaskSheduler.BusinessLayer.DTO.UserTaskDTO);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Age";
            this.dataGridViewTextBoxColumn1.HeaderText = "Age";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn2.HeaderText = "Email";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // ruleDataGridViewTextBoxColumn
            // 
            this.ruleDataGridViewTextBoxColumn.DataPropertyName = "Rule";
            this.ruleDataGridViewTextBoxColumn.HeaderText = "Rule";
            this.ruleDataGridViewTextBoxColumn.Name = "ruleDataGridViewTextBoxColumn";
            // 
            // userDTOBindingSource
            // 
            this.userDTOBindingSource.DataSource = typeof(TaskSheduler.BusinessLayer.DTO.UserDTO);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 519);
            this.Controls.Add(this.deleteTask_btn);
            this.Controls.Add(this.changeTask_btn);
            this.Controls.Add(this.addTask_btn);
            this.Controls.Add(this.deleteUser_btn);
            this.Controls.Add(this.changeUser_btn);
            this.Controls.Add(this.addUser_btn);
            this.Controls.Add(this.userTasksDgv);
            this.Controls.Add(this.usersDgv);
            this.Name = "Form1";
            this.Text = "Form1";
            //this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTasksDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTasksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersTasksDBDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTaskDTOBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userDTOBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersDgv;
        private System.Windows.Forms.DataGridView userTasksDgv;
        private System.Windows.Forms.Button addUser_btn;
        private System.Windows.Forms.Button changeUser_btn;
        private System.Windows.Forms.Button deleteUser_btn;
        private System.Windows.Forms.Button addTask_btn;
        private System.Windows.Forms.Button changeTask_btn;
        private System.Windows.Forms.Button deleteTask_btn;
        //private UsersTasksDBDataSet usersTasksDBDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        //private UsersTasksDBDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.BindingSource usersTasksDBDataSetBindingSource;
        //private UsersTasksDBDataSet1 usersTasksDBDataSet1;
        private System.Windows.Forms.BindingSource userTasksBindingSource;
        //private UsersTasksDBDataSet1TableAdapters.UserTasksTableAdapter userTasksTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOfTaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn startOfTaskDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deadLineDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ruleDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userDTOBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource userTaskDTOBindingSource;
    }
}

