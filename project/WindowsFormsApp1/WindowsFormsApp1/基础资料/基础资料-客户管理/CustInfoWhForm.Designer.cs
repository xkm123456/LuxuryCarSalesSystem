namespace WindowsFormsApp1.基础资料.基础资料_客户管理
{
    partial class CustInfoWhForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustInfoWhForm));
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtwork = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rdwoman = new System.Windows.Forms.RadioButton();
            this.rdman = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbianhao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnsx = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btndel = new System.Windows.Forms.Button();
            this.btnxg = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtaddress.Location = new System.Drawing.Point(205, 287);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(592, 27);
            this.txtaddress.TabIndex = 28;
            this.txtaddress.TextChanged += new System.EventHandler(this.txtaddress_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(147, 296);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 27;
            this.label6.Text = "地址";
            // 
            // txtwork
            // 
            this.txtwork.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtwork.Location = new System.Drawing.Point(205, 204);
            this.txtwork.Margin = new System.Windows.Forms.Padding(4);
            this.txtwork.Name = "txtwork";
            this.txtwork.Size = new System.Drawing.Size(592, 27);
            this.txtwork.TabIndex = 26;
            this.txtwork.TextChanged += new System.EventHandler(this.txtwork_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(111, 210);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 25;
            this.label5.Text = "工作单位";
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtphone.Location = new System.Drawing.Point(614, 112);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone.MaxLength = 11;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(183, 27);
            this.txtphone.TabIndex = 24;
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(520, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 23;
            this.label4.Text = "手机号码";
            // 
            // rdwoman
            // 
            this.rdwoman.AutoSize = true;
            this.rdwoman.Location = new System.Drawing.Point(345, 121);
            this.rdwoman.Name = "rdwoman";
            this.rdwoman.Size = new System.Drawing.Size(43, 19);
            this.rdwoman.TabIndex = 22;
            this.rdwoman.TabStop = true;
            this.rdwoman.Text = "女";
            this.rdwoman.UseVisualStyleBackColor = true;
            this.rdwoman.CheckedChanged += new System.EventHandler(this.rdwoman_CheckedChanged);
            // 
            // rdman
            // 
            this.rdman.AutoSize = true;
            this.rdman.Location = new System.Drawing.Point(214, 121);
            this.rdman.Name = "rdman";
            this.rdman.Size = new System.Drawing.Size(43, 19);
            this.rdman.TabIndex = 21;
            this.rdman.TabStop = true;
            this.rdman.Text = "男";
            this.rdman.UseVisualStyleBackColor = true;
            this.rdman.CheckedChanged += new System.EventHandler(this.rdman_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(138, 121);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "性别";
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtname.Location = new System.Drawing.Point(614, 34);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(183, 27);
            this.txtname.TabIndex = 19;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(520, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "顾客姓名";
            // 
            // txtbianhao
            // 
            this.txtbianhao.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtbianhao.Location = new System.Drawing.Point(205, 37);
            this.txtbianhao.Margin = new System.Windows.Forms.Padding(4);
            this.txtbianhao.Name = "txtbianhao";
            this.txtbianhao.Size = new System.Drawing.Size(183, 27);
            this.txtbianhao.TabIndex = 17;
            this.txtbianhao.TextChanged += new System.EventHandler(this.txtbianhao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(111, 43);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "顾客编号";
            // 
            // btnsx
            // 
            this.btnsx.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnsx.Location = new System.Drawing.Point(322, 657);
            this.btnsx.Margin = new System.Windows.Forms.Padding(4);
            this.btnsx.Name = "btnsx";
            this.btnsx.Size = new System.Drawing.Size(111, 36);
            this.btnsx.TabIndex = 61;
            this.btnsx.Text = "刷新";
            this.btnsx.UseVisualStyleBackColor = true;
            this.btnsx.Click += new System.EventHandler(this.btnsx_Click);
            // 
            // btnexit
            // 
            this.btnexit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnexit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnexit.Location = new System.Drawing.Point(724, 657);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(111, 36);
            this.btnexit.TabIndex = 60;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btndel
            // 
            this.btndel.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btndel.Location = new System.Drawing.Point(594, 657);
            this.btndel.Margin = new System.Windows.Forms.Padding(4);
            this.btndel.Name = "btndel";
            this.btndel.Size = new System.Drawing.Size(111, 36);
            this.btndel.TabIndex = 59;
            this.btndel.Text = "删除";
            this.btndel.UseVisualStyleBackColor = true;
            this.btndel.Click += new System.EventHandler(this.btndel_Click);
            // 
            // btnxg
            // 
            this.btnxg.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnxg.Location = new System.Drawing.Point(456, 657);
            this.btnxg.Margin = new System.Windows.Forms.Padding(4);
            this.btnxg.Name = "btnxg";
            this.btnxg.Size = new System.Drawing.Size(111, 36);
            this.btnxg.TabIndex = 58;
            this.btnxg.Text = "修改";
            this.btnxg.UseVisualStyleBackColor = true;
            this.btnxg.Click += new System.EventHandler(this.btnxg_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(49, 348);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(811, 270);
            this.dataGridView1.TabIndex = 62;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // CustInfoWhForm
            // 
            this.AcceptButton = this.btnxg;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnexit;
            this.ClientSize = new System.Drawing.Size(909, 720);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnsx);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btndel);
            this.Controls.Add(this.btnxg);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtwork);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtphone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rdwoman);
            this.Controls.Add(this.rdman);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtbianhao);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CustInfoWhForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户信息维护";
            this.Load += new System.EventHandler(this.CustInfoWhForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtwork;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton rdwoman;
        private System.Windows.Forms.RadioButton rdman;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbianhao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsx;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btndel;
        private System.Windows.Forms.Button btnxg;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}