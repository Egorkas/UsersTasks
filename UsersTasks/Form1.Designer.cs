
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
            this.usersDgv = new System.Windows.Forms.DataGridView();
            this.userTasksDgv = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.usersDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTasksDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // usersDgv
            // 
            this.usersDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usersDgv.Location = new System.Drawing.Point(12, 12);
            this.usersDgv.Name = "usersDgv";
            this.usersDgv.Size = new System.Drawing.Size(496, 312);
            this.usersDgv.TabIndex = 0;
            // 
            // userTasksDgv
            // 
            this.userTasksDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userTasksDgv.Location = new System.Drawing.Point(559, 14);
            this.userTasksDgv.Name = "userTasksDgv";
            this.userTasksDgv.Size = new System.Drawing.Size(469, 309);
            this.userTasksDgv.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1040, 519);
            this.Controls.Add(this.userTasksDgv);
            this.Controls.Add(this.usersDgv);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.usersDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTasksDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView usersDgv;
        private System.Windows.Forms.DataGridView userTasksDgv;
    }
}

