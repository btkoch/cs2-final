namespace cs2_final
{
    partial class AthleteSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AthleteSalary));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.hireProfBtn = new System.Windows.Forms.Button();
            this.athFirstnameTxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.athLstnameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.submitBtn = new System.Windows.Forms.Button();
            this.salaryTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hiredProfessionalsDBDataSet = new cs2_final.HiredProfessionalsDBDataSet();
            this.athletesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.athletesTableAdapter = new cs2_final.HiredProfessionalsDBDataSetTableAdapters.AthletesTableAdapter();
            this.tableAdapterManager = new cs2_final.HiredProfessionalsDBDataSetTableAdapters.TableAdapterManager();
            this.athletesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.athletesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.athletesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiredProfessionalsDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athletesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.athletesBindingNavigator)).BeginInit();
            this.athletesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.athletesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.hireProfBtn);
            this.groupBox1.Controls.Add(this.athFirstnameTxt);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.athLstnameTxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.submitBtn);
            this.groupBox1.Controls.Add(this.salaryTxt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Athlete Salary";
            // 
            // hireProfBtn
            // 
            this.hireProfBtn.Location = new System.Drawing.Point(25, 119);
            this.hireProfBtn.Name = "hireProfBtn";
            this.hireProfBtn.Size = new System.Drawing.Size(102, 23);
            this.hireProfBtn.TabIndex = 7;
            this.hireProfBtn.Text = "Hire Professionals";
            this.hireProfBtn.UseVisualStyleBackColor = true;
            this.hireProfBtn.Click += new System.EventHandler(this.hireProfBtn_Click);
            // 
            // athFirstnameTxt
            // 
            this.athFirstnameTxt.Location = new System.Drawing.Point(100, 16);
            this.athFirstnameTxt.Name = "athFirstnameTxt";
            this.athFirstnameTxt.Size = new System.Drawing.Size(169, 20);
            this.athFirstnameTxt.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter First Name:";
            // 
            // athLstnameTxt
            // 
            this.athLstnameTxt.Location = new System.Drawing.Point(100, 42);
            this.athLstnameTxt.Name = "athLstnameTxt";
            this.athLstnameTxt.Size = new System.Drawing.Size(169, 20);
            this.athLstnameTxt.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Last Name: ";
            // 
            // submitBtn
            // 
            this.submitBtn.Enabled = false;
            this.submitBtn.Location = new System.Drawing.Point(148, 119);
            this.submitBtn.Name = "submitBtn";
            this.submitBtn.Size = new System.Drawing.Size(102, 23);
            this.submitBtn.TabIndex = 2;
            this.submitBtn.Text = "Add Athlete";
            this.submitBtn.UseVisualStyleBackColor = true;
            this.submitBtn.Click += new System.EventHandler(this.submitBtn_Click);
            // 
            // salaryTxt
            // 
            this.salaryTxt.Location = new System.Drawing.Point(169, 68);
            this.salaryTxt.Name = "salaryTxt";
            this.salaryTxt.Size = new System.Drawing.Size(100, 20);
            this.salaryTxt.TabIndex = 1;
            this.salaryTxt.TextChanged += new System.EventHandler(this.salaryTxt_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the athlete\'s yearly salary: $";
            // 
            // hiredProfessionalsDBDataSet
            // 
            this.hiredProfessionalsDBDataSet.DataSetName = "HiredProfessionalsDBDataSet";
            this.hiredProfessionalsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // athletesBindingSource
            // 
            this.athletesBindingSource.DataMember = "Athletes";
            this.athletesBindingSource.DataSource = this.hiredProfessionalsDBDataSet;
            // 
            // athletesTableAdapter
            // 
            this.athletesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AthletesTableAdapter = this.athletesTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProfessionalsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = cs2_final.HiredProfessionalsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // athletesBindingNavigator
            // 
            this.athletesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.athletesBindingNavigator.BindingSource = this.athletesBindingSource;
            this.athletesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.athletesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.athletesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.athletesBindingNavigatorSaveItem});
            this.athletesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.athletesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.athletesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.athletesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.athletesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.athletesBindingNavigator.Name = "athletesBindingNavigator";
            this.athletesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.athletesBindingNavigator.Size = new System.Drawing.Size(575, 25);
            this.athletesBindingNavigator.TabIndex = 2;
            this.athletesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // athletesBindingNavigatorSaveItem
            // 
            this.athletesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.athletesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("athletesBindingNavigatorSaveItem.Image")));
            this.athletesBindingNavigatorSaveItem.Name = "athletesBindingNavigatorSaveItem";
            this.athletesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.athletesBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // athletesDataGridView
            // 
            this.athletesDataGridView.AutoGenerateColumns = false;
            this.athletesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.athletesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.athletesDataGridView.DataSource = this.athletesBindingSource;
            this.athletesDataGridView.Location = new System.Drawing.Point(12, 177);
            this.athletesDataGridView.MultiSelect = false;
            this.athletesDataGridView.Name = "athletesDataGridView";
            this.athletesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.athletesDataGridView.Size = new System.Drawing.Size(446, 144);
            this.athletesDataGridView.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "AthleteID";
            this.dataGridViewTextBoxColumn1.HeaderText = "AthleteID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Salary";
            this.dataGridViewTextBoxColumn4.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // AthleteSalary
            // 
            this.AcceptButton = this.submitBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 344);
            this.Controls.Add(this.athletesDataGridView);
            this.Controls.Add(this.athletesBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Name = "AthleteSalary";
            this.Text = "Professional Athlete | Salary";
            this.Load += new System.EventHandler(this.AthleteSalary_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hiredProfessionalsDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athletesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.athletesBindingNavigator)).EndInit();
            this.athletesBindingNavigator.ResumeLayout(false);
            this.athletesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.athletesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button submitBtn;
        private System.Windows.Forms.TextBox salaryTxt;
        private System.Windows.Forms.Label label1;
        private HiredProfessionalsDBDataSet hiredProfessionalsDBDataSet;
        private System.Windows.Forms.BindingSource athletesBindingSource;
        private HiredProfessionalsDBDataSetTableAdapters.AthletesTableAdapter athletesTableAdapter;
        private HiredProfessionalsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator athletesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton athletesBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView athletesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox athFirstnameTxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox athLstnameTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button hireProfBtn;
    }
}