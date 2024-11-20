namespace cs2_final
{
    partial class ProfessionalsForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.removeBtn = new System.Windows.Forms.Button();
            this.salaryLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.trainerBtn = new System.Windows.Forms.RadioButton();
            this.agentBtn = new System.Windows.Forms.RadioButton();
            this.asstBtn = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.lawyerBtn = new System.Windows.Forms.RadioButton();
            this.previewListBox = new System.Windows.Forms.ListBox();
            this.categoryPnl = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.categoryPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.categoryPnl);
            this.groupBox2.Controls.Add(this.removeBtn);
            this.groupBox2.Controls.Add(this.salaryLbl);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.addBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nameTxt);
            this.groupBox2.Controls.Add(this.previewListBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(550, 400);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Professionals";
            // 
            // removeBtn
            // 
            this.removeBtn.Location = new System.Drawing.Point(417, 357);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(127, 23);
            this.removeBtn.TabIndex = 14;
            this.removeBtn.Text = "&Remove Selected";
            this.removeBtn.UseVisualStyleBackColor = true;
            // 
            // salaryLbl
            // 
            this.salaryLbl.AutoSize = true;
            this.salaryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryLbl.Location = new System.Drawing.Point(90, 369);
            this.salaryLbl.Name = "salaryLbl";
            this.salaryLbl.Size = new System.Drawing.Size(50, 16);
            this.salaryLbl.TabIndex = 13;
            this.salaryLbl.Text = "label3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Athlete Salary:";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(9, 145);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 11;
            this.addBtn.Text = "&Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // trainerBtn
            // 
            this.trainerBtn.AutoSize = true;
            this.trainerBtn.Location = new System.Drawing.Point(3, 72);
            this.trainerBtn.Name = "trainerBtn";
            this.trainerBtn.Size = new System.Drawing.Size(58, 17);
            this.trainerBtn.TabIndex = 10;
            this.trainerBtn.TabStop = true;
            this.trainerBtn.Tag = "trainer";
            this.trainerBtn.Text = "&Trainer";
            this.trainerBtn.UseVisualStyleBackColor = true;
            // 
            // agentBtn
            // 
            this.agentBtn.AutoSize = true;
            this.agentBtn.Location = new System.Drawing.Point(3, 49);
            this.agentBtn.Name = "agentBtn";
            this.agentBtn.Size = new System.Drawing.Size(53, 17);
            this.agentBtn.TabIndex = 9;
            this.agentBtn.TabStop = true;
            this.agentBtn.Tag = "agent";
            this.agentBtn.Text = "A&gent";
            this.agentBtn.UseVisualStyleBackColor = true;
            // 
            // asstBtn
            // 
            this.asstBtn.AutoSize = true;
            this.asstBtn.Location = new System.Drawing.Point(3, 26);
            this.asstBtn.Name = "asstBtn";
            this.asstBtn.Size = new System.Drawing.Size(111, 17);
            this.asstBtn.TabIndex = 8;
            this.asstBtn.TabStop = true;
            this.asstBtn.Tag = "asst";
            this.asstBtn.Text = "&Personal Assistant";
            this.asstBtn.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name:";
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(50, 19);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(219, 20);
            this.nameTxt.TabIndex = 6;
            // 
            // lawyerBtn
            // 
            this.lawyerBtn.AutoSize = true;
            this.lawyerBtn.Location = new System.Drawing.Point(3, 3);
            this.lawyerBtn.Name = "lawyerBtn";
            this.lawyerBtn.Size = new System.Drawing.Size(59, 17);
            this.lawyerBtn.TabIndex = 5;
            this.lawyerBtn.TabStop = true;
            this.lawyerBtn.Tag = "lawyer";
            this.lawyerBtn.Text = "&Lawyer";
            this.lawyerBtn.UseVisualStyleBackColor = true;
            // 
            // previewListBox
            // 
            this.previewListBox.FormattingEnabled = true;
            this.previewListBox.Location = new System.Drawing.Point(277, 22);
            this.previewListBox.Name = "previewListBox";
            this.previewListBox.Size = new System.Drawing.Size(267, 329);
            this.previewListBox.TabIndex = 4;
            // 
            // categoryPnl
            // 
            this.categoryPnl.Controls.Add(this.lawyerBtn);
            this.categoryPnl.Controls.Add(this.asstBtn);
            this.categoryPnl.Controls.Add(this.agentBtn);
            this.categoryPnl.Controls.Add(this.trainerBtn);
            this.categoryPnl.Location = new System.Drawing.Point(9, 45);
            this.categoryPnl.Name = "categoryPnl";
            this.categoryPnl.Size = new System.Drawing.Size(120, 94);
            this.categoryPnl.TabIndex = 15;
            // 
            // ProfessionalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 430);
            this.Controls.Add(this.groupBox2);
            this.Name = "ProfessionalsForm";
            this.Text = "Professional Athlete | Data Entry";
            this.Load += new System.EventHandler(this.ProfessionalsForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.categoryPnl.ResumeLayout(false);
            this.categoryPnl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox previewListBox;
        private System.Windows.Forms.RadioButton trainerBtn;
        private System.Windows.Forms.RadioButton agentBtn;
        private System.Windows.Forms.RadioButton asstBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.RadioButton lawyerBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Label salaryLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel categoryPnl;
    }
}

