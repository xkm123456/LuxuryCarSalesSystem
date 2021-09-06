namespace WindowsFormsApp1.基础资料.基础资料_客户管理
{
    partial class CustInfoInsertForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustInfoInsertForm));
            this.txtbianhao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rdman = new System.Windows.Forms.RadioButton();
            this.rdwoman = new System.Windows.Forms.RadioButton();
            this.txtphone = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtwork = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnexit = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtbianhao
            // 
            this.txtbianhao.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtbianhao.Location = new System.Drawing.Point(128, 38);
            this.txtbianhao.Margin = new System.Windows.Forms.Padding(4);
            this.txtbianhao.Name = "txtbianhao";
            this.txtbianhao.ReadOnly = true;
            this.txtbianhao.Size = new System.Drawing.Size(183, 27);
            this.txtbianhao.TabIndex = 4;
            this.txtbianhao.TextChanged += new System.EventHandler(this.txtbianhao_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(34, 44);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "顾客编号";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtname.Location = new System.Drawing.Point(537, 35);
            this.txtname.Margin = new System.Windows.Forms.Padding(4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(183, 27);
            this.txtname.TabIndex = 6;
            this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(443, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "顾客姓名";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(61, 122);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 18);
            this.label3.TabIndex = 7;
            this.label3.Text = "性别";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // rdman
            // 
            this.rdman.AutoSize = true;
            this.rdman.Location = new System.Drawing.Point(137, 122);
            this.rdman.Name = "rdman";
            this.rdman.Size = new System.Drawing.Size(43, 19);
            this.rdman.TabIndex = 8;
            this.rdman.TabStop = true;
            this.rdman.Text = "男";
            this.rdman.UseVisualStyleBackColor = true;
            this.rdman.CheckedChanged += new System.EventHandler(this.rdman_CheckedChanged);
            // 
            // rdwoman
            // 
            this.rdwoman.AutoSize = true;
            this.rdwoman.Location = new System.Drawing.Point(268, 122);
            this.rdwoman.Name = "rdwoman";
            this.rdwoman.Size = new System.Drawing.Size(43, 19);
            this.rdwoman.TabIndex = 9;
            this.rdwoman.TabStop = true;
            this.rdwoman.Text = "女";
            this.rdwoman.UseVisualStyleBackColor = true;
            this.rdwoman.CheckedChanged += new System.EventHandler(this.rdwoman_CheckedChanged);
            // 
            // txtphone
            // 
            this.txtphone.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtphone.Location = new System.Drawing.Point(537, 113);
            this.txtphone.Margin = new System.Windows.Forms.Padding(4);
            this.txtphone.MaxLength = 11;
            this.txtphone.Name = "txtphone";
            this.txtphone.Size = new System.Drawing.Size(183, 27);
            this.txtphone.TabIndex = 11;
            this.txtphone.TextChanged += new System.EventHandler(this.txtphone_TextChanged);
            this.txtphone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtphone_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(443, 119);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 10;
            this.label4.Text = "手机号码";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtwork
            // 
            this.txtwork.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtwork.Location = new System.Drawing.Point(128, 205);
            this.txtwork.Margin = new System.Windows.Forms.Padding(4);
            this.txtwork.Name = "txtwork";
            this.txtwork.Size = new System.Drawing.Size(592, 27);
            this.txtwork.TabIndex = 13;
            this.txtwork.TextChanged += new System.EventHandler(this.txtwork_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(34, 211);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "工作单位";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtaddress.Location = new System.Drawing.Point(128, 288);
            this.txtaddress.Margin = new System.Windows.Forms.Padding(4);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(592, 27);
            this.txtaddress.TabIndex = 15;
            this.txtaddress.TextChanged += new System.EventHandler(this.txtaddress_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(61, 295);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "地址";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnexit.Location = new System.Drawing.Point(615, 373);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(111, 36);
            this.btnexit.TabIndex = 20;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnreset.Location = new System.Drawing.Point(338, 373);
            this.btnreset.Margin = new System.Windows.Forms.Padding(4);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(111, 36);
            this.btnreset.TabIndex = 19;
            this.btnreset.Text = "重置";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btninsert.Location = new System.Drawing.Point(61, 373);
            this.btninsert.Margin = new System.Windows.Forms.Padding(4);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(111, 36);
            this.btninsert.TabIndex = 18;
            this.btninsert.Text = "添加\r\n";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // CustInfoInsertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(786, 450);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btninsert);
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
            this.Name = "CustInfoInsertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "客户信息录入";
            this.Load += new System.EventHandler(this.CustInfoInsertForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbianhao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdman;
        private System.Windows.Forms.RadioButton rdwoman;
        private System.Windows.Forms.TextBox txtphone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtwork;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtaddress;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.Button btninsert;
    }
}