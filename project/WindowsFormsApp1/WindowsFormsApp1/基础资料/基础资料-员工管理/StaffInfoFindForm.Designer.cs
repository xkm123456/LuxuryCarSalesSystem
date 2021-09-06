namespace WindowsFormsApp1.基础资料.基础资料_员工管理
{
    partial class StaffInfoFindForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StaffInfoFindForm));
            this.btnexit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnfind = new System.Windows.Forms.Button();
            this.btnsx = new System.Windows.Forms.Button();
            this.btnout = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnexit.Location = new System.Drawing.Point(946, 34);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(100, 36);
            this.btnexit.TabIndex = 53;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 114);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(1033, 444);
            this.dataGridView1.TabIndex = 52;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(261, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 19);
            this.label1.TabIndex = 54;
            this.label1.Text = "查找";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtname.Location = new System.Drawing.Point(327, 38);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(178, 28);
            this.txtname.TabIndex = 55;
            // 
            // btnfind
            // 
            this.btnfind.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnfind.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnfind.Location = new System.Drawing.Point(546, 34);
            this.btnfind.Margin = new System.Windows.Forms.Padding(4);
            this.btnfind.Name = "btnfind";
            this.btnfind.Size = new System.Drawing.Size(111, 36);
            this.btnfind.TabIndex = 56;
            this.btnfind.Text = "查找";
            this.btnfind.UseVisualStyleBackColor = true;
            this.btnfind.Click += new System.EventHandler(this.btnfind_Click);
            // 
            // btnsx
            // 
            this.btnsx.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnsx.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnsx.Location = new System.Drawing.Point(678, 34);
            this.btnsx.Margin = new System.Windows.Forms.Padding(4);
            this.btnsx.Name = "btnsx";
            this.btnsx.Size = new System.Drawing.Size(111, 36);
            this.btnsx.TabIndex = 57;
            this.btnsx.Text = "刷新";
            this.btnsx.UseVisualStyleBackColor = true;
            this.btnsx.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnout
            // 
            this.btnout.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnout.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnout.Location = new System.Drawing.Point(813, 34);
            this.btnout.Margin = new System.Windows.Forms.Padding(4);
            this.btnout.Name = "btnout";
            this.btnout.Size = new System.Drawing.Size(111, 36);
            this.btnout.TabIndex = 58;
            this.btnout.Text = "导出";
            this.btnout.UseVisualStyleBackColor = true;
            this.btnout.Click += new System.EventHandler(this.btnout_Click);
            // 
            // StaffInfoFindForm
            // 
            this.AcceptButton = this.btnfind;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(1067, 582);
            this.Controls.Add(this.btnout);
            this.Controls.Add(this.btnsx);
            this.Controls.Add(this.btnfind);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "StaffInfoFindForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "员工信息查询";
            this.Load += new System.EventHandler(this.StaffInfoFindForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Button btnfind;
        private System.Windows.Forms.Button btnsx;
        private System.Windows.Forms.Button btnout;
    }
}