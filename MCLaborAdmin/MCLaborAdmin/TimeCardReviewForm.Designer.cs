namespace MCLaborAdmin
{
    partial class TimeCardReviewForm
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
            this.timeCardReviewEmpNameTxt = new System.Windows.Forms.TextBox();
            this.timeCardReviewDateRangeTxt = new System.Windows.Forms.TextBox();
            this.timeCardDataGridView = new System.Windows.Forms.DataGridView();
            this.timeCardReviewAddBtn = new System.Windows.Forms.Button();
            this.timeCardReviewEditBtn = new System.Windows.Forms.Button();
            this.timeCardReviewCloseBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timeCardDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(319, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Date Range:";
            // 
            // timeCardReviewEmpNameTxt
            // 
            this.timeCardReviewEmpNameTxt.BackColor = System.Drawing.SystemColors.Control;
            this.timeCardReviewEmpNameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeCardReviewEmpNameTxt.Enabled = false;
            this.timeCardReviewEmpNameTxt.Location = new System.Drawing.Point(84, 16);
            this.timeCardReviewEmpNameTxt.Name = "timeCardReviewEmpNameTxt";
            this.timeCardReviewEmpNameTxt.Size = new System.Drawing.Size(207, 13);
            this.timeCardReviewEmpNameTxt.TabIndex = 2;
            // 
            // timeCardReviewDateRangeTxt
            // 
            this.timeCardReviewDateRangeTxt.BackColor = System.Drawing.SystemColors.Control;
            this.timeCardReviewDateRangeTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.timeCardReviewDateRangeTxt.Enabled = false;
            this.timeCardReviewDateRangeTxt.Location = new System.Drawing.Point(393, 16);
            this.timeCardReviewDateRangeTxt.Name = "timeCardReviewDateRangeTxt";
            this.timeCardReviewDateRangeTxt.Size = new System.Drawing.Size(207, 13);
            this.timeCardReviewDateRangeTxt.TabIndex = 3;
            // 
            // timeCardDataGridView
            // 
            this.timeCardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.timeCardDataGridView.Location = new System.Drawing.Point(24, 49);
            this.timeCardDataGridView.Name = "timeCardDataGridView";
            this.timeCardDataGridView.Size = new System.Drawing.Size(649, 303);
            this.timeCardDataGridView.TabIndex = 4;
            // 
            // timeCardReviewAddBtn
            // 
            this.timeCardReviewAddBtn.Location = new System.Drawing.Point(27, 377);
            this.timeCardReviewAddBtn.Name = "timeCardReviewAddBtn";
            this.timeCardReviewAddBtn.Size = new System.Drawing.Size(124, 35);
            this.timeCardReviewAddBtn.TabIndex = 5;
            this.timeCardReviewAddBtn.Text = "Add";
            this.timeCardReviewAddBtn.UseVisualStyleBackColor = true;
            // 
            // timeCardReviewEditBtn
            // 
            this.timeCardReviewEditBtn.Location = new System.Drawing.Point(178, 377);
            this.timeCardReviewEditBtn.Name = "timeCardReviewEditBtn";
            this.timeCardReviewEditBtn.Size = new System.Drawing.Size(124, 35);
            this.timeCardReviewEditBtn.TabIndex = 6;
            this.timeCardReviewEditBtn.Text = "Edit";
            this.timeCardReviewEditBtn.UseVisualStyleBackColor = true;
            // 
            // timeCardReviewCloseBtn
            // 
            this.timeCardReviewCloseBtn.Location = new System.Drawing.Point(331, 377);
            this.timeCardReviewCloseBtn.Name = "timeCardReviewCloseBtn";
            this.timeCardReviewCloseBtn.Size = new System.Drawing.Size(124, 35);
            this.timeCardReviewCloseBtn.TabIndex = 7;
            this.timeCardReviewCloseBtn.Text = "Close";
            this.timeCardReviewCloseBtn.UseVisualStyleBackColor = true;
            // 
            // TimeCardReviewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 436);
            this.Controls.Add(this.timeCardReviewCloseBtn);
            this.Controls.Add(this.timeCardReviewEditBtn);
            this.Controls.Add(this.timeCardReviewAddBtn);
            this.Controls.Add(this.timeCardDataGridView);
            this.Controls.Add(this.timeCardReviewDateRangeTxt);
            this.Controls.Add(this.timeCardReviewEmpNameTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TimeCardReviewForm";
            this.Text = "MCLabor Administration - Add/Edit Time Cards";
            ((System.ComponentModel.ISupportInitialize)(this.timeCardDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox timeCardReviewEmpNameTxt;
        private System.Windows.Forms.TextBox timeCardReviewDateRangeTxt;
        private System.Windows.Forms.DataGridView timeCardDataGridView;
        private System.Windows.Forms.Button timeCardReviewAddBtn;
        private System.Windows.Forms.Button timeCardReviewEditBtn;
        private System.Windows.Forms.Button timeCardReviewCloseBtn;
    }
}