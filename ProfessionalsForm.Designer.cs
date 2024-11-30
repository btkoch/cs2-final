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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfessionalsForm));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.trainerCountLbl = new System.Windows.Forms.Label();
            this.agentCountLbl = new System.Windows.Forms.Label();
            this.asstCountLbl = new System.Windows.Forms.Label();
            this.lawyerCountLbl = new System.Windows.Forms.Label();
            this.totalSpentLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.athIDLbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.professionalsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.professionalsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hiredProfessionalsDBDataSet = new cs2_final.HiredProfessionalsDBDataSet();
            this.categoryPnl = new System.Windows.Forms.Panel();
            this.lawyerBtn = new System.Windows.Forms.RadioButton();
            this.asstBtn = new System.Windows.Forms.RadioButton();
            this.agentBtn = new System.Windows.Forms.RadioButton();
            this.trainerBtn = new System.Windows.Forms.RadioButton();
            this.salaryLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.professionalsTableAdapter = new cs2_final.HiredProfessionalsDBDataSetTableAdapters.ProfessionalsTableAdapter();
            this.tableAdapterManager = new cs2_final.HiredProfessionalsDBDataSetTableAdapters.TableAdapterManager();
            this.professionalsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.professionalsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.remainingLbl = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professionalsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionalsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiredProfessionalsDBDataSet)).BeginInit();
            this.categoryPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professionalsBindingNavigator)).BeginInit();
            this.professionalsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.remainingLbl);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.trainerCountLbl);
            this.groupBox2.Controls.Add(this.agentCountLbl);
            this.groupBox2.Controls.Add(this.asstCountLbl);
            this.groupBox2.Controls.Add(this.lawyerCountLbl);
            this.groupBox2.Controls.Add(this.totalSpentLbl);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.athIDLbl);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.professionalsDataGridView);
            this.groupBox2.Controls.Add(this.categoryPnl);
            this.groupBox2.Controls.Add(this.salaryLbl);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.addBtn);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.nameTxt);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(852, 405);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Professionals";
            // 
            // trainerCountLbl
            // 
            this.trainerCountLbl.AutoSize = true;
            this.trainerCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.trainerCountLbl.Location = new System.Drawing.Point(135, 117);
            this.trainerCountLbl.Name = "trainerCountLbl";
            this.trainerCountLbl.Size = new System.Drawing.Size(90, 16);
            this.trainerCountLbl.TabIndex = 23;
            this.trainerCountLbl.Text = "trainerCount";
            // 
            // agentCountLbl
            // 
            this.agentCountLbl.AutoSize = true;
            this.agentCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agentCountLbl.Location = new System.Drawing.Point(135, 95);
            this.agentCountLbl.Name = "agentCountLbl";
            this.agentCountLbl.Size = new System.Drawing.Size(85, 16);
            this.agentCountLbl.TabIndex = 22;
            this.agentCountLbl.Text = "agentCount";
            // 
            // asstCountLbl
            // 
            this.asstCountLbl.AutoSize = true;
            this.asstCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.asstCountLbl.Location = new System.Drawing.Point(135, 72);
            this.asstCountLbl.Name = "asstCountLbl";
            this.asstCountLbl.Size = new System.Drawing.Size(87, 16);
            this.asstCountLbl.TabIndex = 21;
            this.asstCountLbl.Text = "assistCount";
            // 
            // lawyerCountLbl
            // 
            this.lawyerCountLbl.AutoSize = true;
            this.lawyerCountLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lawyerCountLbl.Location = new System.Drawing.Point(135, 48);
            this.lawyerCountLbl.Name = "lawyerCountLbl";
            this.lawyerCountLbl.Size = new System.Drawing.Size(91, 16);
            this.lawyerCountLbl.TabIndex = 20;
            this.lawyerCountLbl.Text = "lawyerCount";
            // 
            // totalSpentLbl
            // 
            this.totalSpentLbl.AutoSize = true;
            this.totalSpentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalSpentLbl.Location = new System.Drawing.Point(357, 372);
            this.totalSpentLbl.Name = "totalSpentLbl";
            this.totalSpentLbl.Size = new System.Drawing.Size(65, 13);
            this.totalSpentLbl.TabIndex = 19;
            this.totalSpentLbl.Text = "totalSpent";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(283, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Total Spent: ";
            // 
            // athIDLbl
            // 
            this.athIDLbl.AutoSize = true;
            this.athIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.athIDLbl.Location = new System.Drawing.Point(107, 321);
            this.athIDLbl.Name = "athIDLbl";
            this.athIDLbl.Size = new System.Drawing.Size(43, 16);
            this.athIDLbl.TabIndex = 17;
            this.athIDLbl.Text = "athID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Athlete ID:";
            // 
            // professionalsDataGridView
            // 
            this.professionalsDataGridView.AutoGenerateColumns = false;
            this.professionalsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.professionalsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.professionalsDataGridView.DataSource = this.professionalsBindingSource;
            this.professionalsDataGridView.Location = new System.Drawing.Point(275, 16);
            this.professionalsDataGridView.Name = "professionalsDataGridView";
            this.professionalsDataGridView.ReadOnly = true;
            this.professionalsDataGridView.Size = new System.Drawing.Size(550, 344);
            this.professionalsDataGridView.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Id";
            this.dataGridViewTextBoxColumn1.HeaderText = "Id";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "FirstName";
            this.dataGridViewTextBoxColumn2.HeaderText = "FirstName";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "LastName";
            this.dataGridViewTextBoxColumn3.HeaderText = "LastName";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Profession";
            this.dataGridViewTextBoxColumn4.HeaderText = "Profession";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Salary";
            dataGridViewCellStyle1.Format = "C2";
            dataGridViewCellStyle1.NullValue = null;
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewTextBoxColumn5.HeaderText = "Salary";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // professionalsBindingSource
            // 
            this.professionalsBindingSource.DataMember = "Professionals";
            this.professionalsBindingSource.DataSource = this.hiredProfessionalsDBDataSet;
            // 
            // hiredProfessionalsDBDataSet
            // 
            this.hiredProfessionalsDBDataSet.DataSetName = "HiredProfessionalsDBDataSet";
            this.hiredProfessionalsDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // salaryLbl
            // 
            this.salaryLbl.AutoSize = true;
            this.salaryLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryLbl.Location = new System.Drawing.Point(107, 346);
            this.salaryLbl.Name = "salaryLbl";
            this.salaryLbl.Size = new System.Drawing.Size(50, 16);
            this.salaryLbl.TabIndex = 13;
            this.salaryLbl.Text = "salary";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 348);
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
            // professionalsTableAdapter
            // 
            this.professionalsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AthletesTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ProfessionalsTableAdapter = this.professionalsTableAdapter;
            this.tableAdapterManager.UpdateOrder = cs2_final.HiredProfessionalsDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // professionalsBindingNavigator
            // 
            this.professionalsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.professionalsBindingNavigator.BindingSource = this.professionalsBindingSource;
            this.professionalsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.professionalsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.professionalsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.professionalsBindingNavigatorSaveItem});
            this.professionalsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.professionalsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.professionalsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.professionalsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.professionalsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.professionalsBindingNavigator.Name = "professionalsBindingNavigator";
            this.professionalsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.professionalsBindingNavigator.Size = new System.Drawing.Size(876, 25);
            this.professionalsBindingNavigator.TabIndex = 4;
            this.professionalsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Enabled = false;
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
            // professionalsBindingNavigatorSaveItem
            // 
            this.professionalsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.professionalsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("professionalsBindingNavigatorSaveItem.Image")));
            this.professionalsBindingNavigatorSaveItem.Name = "professionalsBindingNavigatorSaveItem";
            this.professionalsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.professionalsBindingNavigatorSaveItem.Text = "Save Data";
            this.professionalsBindingNavigatorSaveItem.Click += new System.EventHandler(this.professionalsBindingNavigatorSaveItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(428, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Remaining Salary:";
            // 
            // remainingLbl
            // 
            this.remainingLbl.AutoSize = true;
            this.remainingLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.remainingLbl.Location = new System.Drawing.Point(526, 370);
            this.remainingLbl.Name = "remainingLbl";
            this.remainingLbl.Size = new System.Drawing.Size(75, 16);
            this.remainingLbl.TabIndex = 25;
            this.remainingLbl.Text = "remaining";
            // 
            // ProfessionalsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 430);
            this.Controls.Add(this.professionalsBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Name = "ProfessionalsForm";
            this.Text = "Professional Athlete | Data Entry";
            this.Load += new System.EventHandler(this.ProfessionalsForm_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professionalsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.professionalsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hiredProfessionalsDBDataSet)).EndInit();
            this.categoryPnl.ResumeLayout(false);
            this.categoryPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.professionalsBindingNavigator)).EndInit();
            this.professionalsBindingNavigator.ResumeLayout(false);
            this.professionalsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton trainerBtn;
        private System.Windows.Forms.RadioButton agentBtn;
        private System.Windows.Forms.RadioButton asstBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.RadioButton lawyerBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label salaryLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel categoryPnl;
        private HiredProfessionalsDBDataSet hiredProfessionalsDBDataSet;
        private System.Windows.Forms.BindingSource professionalsBindingSource;
        private HiredProfessionalsDBDataSetTableAdapters.ProfessionalsTableAdapter professionalsTableAdapter;
        private HiredProfessionalsDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator professionalsBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton professionalsBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView professionalsDataGridView;
        private System.Windows.Forms.Label athIDLbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Label totalSpentLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label trainerCountLbl;
        private System.Windows.Forms.Label agentCountLbl;
        private System.Windows.Forms.Label asstCountLbl;
        private System.Windows.Forms.Label lawyerCountLbl;
        private System.Windows.Forms.Label remainingLbl;
        private System.Windows.Forms.Label label5;
    }
}

