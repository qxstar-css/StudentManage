namespace StudentManage
{
    partial class FaAndProForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TxtDepCall = new System.Windows.Forms.TextBox();
            this.TxtDepName = new System.Windows.Forms.TextBox();
            this.TxtDepId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnDepCancel = new System.Windows.Forms.Button();
            this.BtnDepDelete = new System.Windows.Forms.Button();
            this.BtnDepUpdate = new System.Windows.Forms.Button();
            this.BtnDepAdd = new System.Windows.Forms.Button();
            this.DGVDep = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.CboDep = new System.Windows.Forms.ComboBox();
            this.TxtCId = new System.Windows.Forms.TextBox();
            this.TxtCName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnUpdate = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.DGVClass = new System.Windows.Forms.DataGridView();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDep)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClass)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(632, 639);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.DGVDep);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(624, 610);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "院系管理";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TxtDepCall);
            this.groupBox1.Controls.Add(this.TxtDepName);
            this.groupBox1.Controls.Add(this.TxtDepId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.BtnDepCancel);
            this.groupBox1.Controls.Add(this.BtnDepDelete);
            this.groupBox1.Controls.Add(this.BtnDepUpdate);
            this.groupBox1.Controls.Add(this.BtnDepAdd);
            this.groupBox1.Location = new System.Drawing.Point(6, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(601, 396);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "添加";
            // 
            // TxtDepCall
            // 
            this.TxtDepCall.Location = new System.Drawing.Point(178, 172);
            this.TxtDepCall.Name = "TxtDepCall";
            this.TxtDepCall.Size = new System.Drawing.Size(267, 25);
            this.TxtDepCall.TabIndex = 9;
            // 
            // TxtDepName
            // 
            this.TxtDepName.Location = new System.Drawing.Point(178, 109);
            this.TxtDepName.Name = "TxtDepName";
            this.TxtDepName.Size = new System.Drawing.Size(267, 25);
            this.TxtDepName.TabIndex = 8;
            // 
            // TxtDepId
            // 
            this.TxtDepId.Location = new System.Drawing.Point(178, 50);
            this.TxtDepId.Name = "TxtDepId";
            this.TxtDepId.Size = new System.Drawing.Size(267, 25);
            this.TxtDepId.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "电话：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(107, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "系名：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(107, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "系号：";
            // 
            // BtnDepCancel
            // 
            this.BtnDepCancel.Location = new System.Drawing.Point(462, 264);
            this.BtnDepCancel.Name = "BtnDepCancel";
            this.BtnDepCancel.Size = new System.Drawing.Size(100, 51);
            this.BtnDepCancel.TabIndex = 3;
            this.BtnDepCancel.Text = "取消";
            this.BtnDepCancel.UseVisualStyleBackColor = true;
            this.BtnDepCancel.Click += new System.EventHandler(this.BtnDepCancel_Click);
            // 
            // BtnDepDelete
            // 
            this.BtnDepDelete.Location = new System.Drawing.Point(310, 264);
            this.BtnDepDelete.Name = "BtnDepDelete";
            this.BtnDepDelete.Size = new System.Drawing.Size(107, 51);
            this.BtnDepDelete.TabIndex = 2;
            this.BtnDepDelete.Text = "删除";
            this.BtnDepDelete.UseVisualStyleBackColor = true;
            this.BtnDepDelete.Click += new System.EventHandler(this.BtnDepDelete_Click);
            // 
            // BtnDepUpdate
            // 
            this.BtnDepUpdate.Location = new System.Drawing.Point(178, 264);
            this.BtnDepUpdate.Name = "BtnDepUpdate";
            this.BtnDepUpdate.Size = new System.Drawing.Size(90, 51);
            this.BtnDepUpdate.TabIndex = 1;
            this.BtnDepUpdate.Text = "修改";
            this.BtnDepUpdate.UseVisualStyleBackColor = true;
            this.BtnDepUpdate.Click += new System.EventHandler(this.BtnDepUpdate_Click);
            // 
            // BtnDepAdd
            // 
            this.BtnDepAdd.Location = new System.Drawing.Point(36, 264);
            this.BtnDepAdd.Name = "BtnDepAdd";
            this.BtnDepAdd.Size = new System.Drawing.Size(89, 51);
            this.BtnDepAdd.TabIndex = 0;
            this.BtnDepAdd.Text = "添加";
            this.BtnDepAdd.UseVisualStyleBackColor = true;
            this.BtnDepAdd.Click += new System.EventHandler(this.BtnDepAdd_Click);
            // 
            // DGVDep
            // 
            this.DGVDep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVDep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.DGVDep.Location = new System.Drawing.Point(6, 6);
            this.DGVDep.Name = "DGVDep";
            this.DGVDep.RowHeadersWidth = 51;
            this.DGVDep.RowTemplate.Height = 27;
            this.DGVDep.Size = new System.Drawing.Size(612, 196);
            this.DGVDep.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "depID";
            this.Column1.HeaderText = "系部号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "depname";
            this.Column2.HeaderText = "系部名";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "depphone";
            this.Column3.HeaderText = "系部电话";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 125;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVClass);
            this.tabPage2.Controls.Add(this.groupbox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(624, 610);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "专业管理";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.CboDep);
            this.groupbox2.Controls.Add(this.TxtCId);
            this.groupbox2.Controls.Add(this.TxtCName);
            this.groupbox2.Controls.Add(this.label6);
            this.groupbox2.Controls.Add(this.label5);
            this.groupbox2.Controls.Add(this.label4);
            this.groupbox2.Controls.Add(this.BtnCancel);
            this.groupbox2.Controls.Add(this.BtnDelete);
            this.groupbox2.Controls.Add(this.BtnUpdate);
            this.groupbox2.Controls.Add(this.BtnAdd);
            this.groupbox2.Location = new System.Drawing.Point(6, 229);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(612, 344);
            this.groupbox2.TabIndex = 1;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "添加";
            // 
            // CboDep
            // 
            this.CboDep.FormattingEnabled = true;
            this.CboDep.Location = new System.Drawing.Point(186, 155);
            this.CboDep.Name = "CboDep";
            this.CboDep.Size = new System.Drawing.Size(275, 23);
            this.CboDep.TabIndex = 10;
            // 
            // TxtCId
            // 
            this.TxtCId.Location = new System.Drawing.Point(186, 53);
            this.TxtCId.Name = "TxtCId";
            this.TxtCId.Size = new System.Drawing.Size(275, 25);
            this.TxtCId.TabIndex = 9;
            // 
            // TxtCName
            // 
            this.TxtCName.Location = new System.Drawing.Point(186, 100);
            this.TxtCName.Name = "TxtCName";
            this.TxtCName.Size = new System.Drawing.Size(275, 25);
            this.TxtCName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "所在系：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "专业名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "专业号：";
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(419, 253);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(94, 37);
            this.BtnCancel.TabIndex = 3;
            this.BtnCancel.Text = "取消";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(287, 253);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(89, 37);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "删除";
            this.BtnDelete.UseVisualStyleBackColor = true;
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // BtnUpdate
            // 
            this.BtnUpdate.Location = new System.Drawing.Point(154, 253);
            this.BtnUpdate.Name = "BtnUpdate";
            this.BtnUpdate.Size = new System.Drawing.Size(86, 37);
            this.BtnUpdate.TabIndex = 1;
            this.BtnUpdate.Text = "修改";
            this.BtnUpdate.UseVisualStyleBackColor = true;
            this.BtnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(20, 253);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(85, 37);
            this.BtnAdd.TabIndex = 0;
            this.BtnAdd.Text = "添加";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // DGVClass
            // 
            this.DGVClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column4,
            this.Column5,
            this.Column6});
            this.DGVClass.Location = new System.Drawing.Point(3, 3);
            this.DGVClass.Name = "DGVClass";
            this.DGVClass.RowHeadersWidth = 51;
            this.DGVClass.RowTemplate.Height = 27;
            this.DGVClass.Size = new System.Drawing.Size(615, 211);
            this.DGVClass.TabIndex = 2;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "classID";
            this.Column4.HeaderText = "专业号";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "classname";
            this.Column5.HeaderText = "专业名";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "depID";
            this.Column6.HeaderText = "系部";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.Width = 125;
            // 
            // FaAndProForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 657);
            this.Controls.Add(this.tabControl1);
            this.Name = "FaAndProForm";
            this.Text = "院系及专业管理";
            this.Load += new System.EventHandler(this.FaAndProForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVDep)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupbox2.ResumeLayout(false);
            this.groupbox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVClass)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DGVDep;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtDepCall;
        private System.Windows.Forms.TextBox TxtDepName;
        private System.Windows.Forms.TextBox TxtDepId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnDepCancel;
        private System.Windows.Forms.Button BtnDepDelete;
        private System.Windows.Forms.Button BtnDepUpdate;
        private System.Windows.Forms.Button BtnDepAdd;
        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.TextBox TxtCId;
        private System.Windows.Forms.TextBox TxtCName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnUpdate;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.ComboBox CboDep;
        private System.Windows.Forms.DataGridView DGVClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}