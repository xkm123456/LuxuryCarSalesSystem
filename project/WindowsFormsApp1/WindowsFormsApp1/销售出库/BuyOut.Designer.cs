namespace WindowsFormsApp1.销售出库
{
    partial class BuyOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BuyOut));
            this.txtxsbianhao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtxsshuliang = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbpaytype = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnsx = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.btninsert = new System.Windows.Forms.Button();
            this.btnreset = new System.Windows.Forms.Button();
            this.txtspprice = new System.Windows.Forms.TextBox();
            this.dtdate = new System.Windows.Forms.DateTimePicker();
            this.txtshangpingName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtspbianhao = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtxsbianhao
            // 
            this.txtxsbianhao.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtxsbianhao.Location = new System.Drawing.Point(109, 31);
            this.txtxsbianhao.Margin = new System.Windows.Forms.Padding(4);
            this.txtxsbianhao.Name = "txtxsbianhao";
            this.txtxsbianhao.ReadOnly = true;
            this.txtxsbianhao.Size = new System.Drawing.Size(115, 27);
            this.txtxsbianhao.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(23, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 21;
            this.label1.Text = "销售单号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(278, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 23;
            this.label2.Text = "商品编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(20, 103);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 25;
            this.label3.Text = "销售价格";
            // 
            // txtxsshuliang
            // 
            this.txtxsshuliang.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtxsshuliang.Location = new System.Drawing.Point(364, 98);
            this.txtxsshuliang.Margin = new System.Windows.Forms.Padding(4);
            this.txtxsshuliang.Name = "txtxsshuliang";
            this.txtxsshuliang.Size = new System.Drawing.Size(121, 27);
            this.txtxsshuliang.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(278, 103);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 18);
            this.label4.TabIndex = 27;
            this.label4.Text = "销售数量";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(22, 166);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "销售日期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(517, 101);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 18);
            this.label6.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(279, 103);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 18);
            this.label7.TabIndex = 33;
            // 
            // cmbpaytype
            // 
            this.cmbpaytype.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cmbpaytype.FormattingEnabled = true;
            this.cmbpaytype.Location = new System.Drawing.Point(603, 97);
            this.cmbpaytype.Name = "cmbpaytype";
            this.cmbpaytype.Size = new System.Drawing.Size(115, 28);
            this.cmbpaytype.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(516, 101);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 35;
            this.label8.Text = "付费方式";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(25, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(699, 249);
            this.dataGridView1.TabIndex = 39;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // btnsx
            // 
            this.btnsx.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnsx.Location = new System.Drawing.Point(341, 503);
            this.btnsx.Margin = new System.Windows.Forms.Padding(4);
            this.btnsx.Name = "btnsx";
            this.btnsx.Size = new System.Drawing.Size(111, 36);
            this.btnsx.TabIndex = 42;
            this.btnsx.Text = "刷新";
            this.btnsx.UseVisualStyleBackColor = true;
            this.btnsx.Click += new System.EventHandler(this.btnsx_Click);
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnexit.Location = new System.Drawing.Point(613, 503);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(111, 36);
            this.btnexit.TabIndex = 41;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btninsert
            // 
            this.btninsert.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btninsert.Location = new System.Drawing.Point(205, 503);
            this.btninsert.Margin = new System.Windows.Forms.Padding(4);
            this.btninsert.Name = "btninsert";
            this.btninsert.Size = new System.Drawing.Size(111, 36);
            this.btninsert.TabIndex = 40;
            this.btninsert.Text = "添加\r\n";
            this.btninsert.UseVisualStyleBackColor = true;
            this.btninsert.Click += new System.EventHandler(this.btninsert_Click);
            // 
            // btnreset
            // 
            this.btnreset.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnreset.Location = new System.Drawing.Point(477, 503);
            this.btnreset.Margin = new System.Windows.Forms.Padding(4);
            this.btnreset.Name = "btnreset";
            this.btnreset.Size = new System.Drawing.Size(111, 36);
            this.btnreset.TabIndex = 71;
            this.btnreset.Text = "重置";
            this.btnreset.UseVisualStyleBackColor = true;
            this.btnreset.Click += new System.EventHandler(this.btnreset_Click);
            // 
            // txtspprice
            // 
            this.txtspprice.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtspprice.Location = new System.Drawing.Point(108, 98);
            this.txtspprice.Margin = new System.Windows.Forms.Padding(4);
            this.txtspprice.Name = "txtspprice";
            this.txtspprice.Size = new System.Drawing.Size(115, 27);
            this.txtspprice.TabIndex = 72;
            // 
            // dtdate
            // 
            this.dtdate.Location = new System.Drawing.Point(108, 161);
            this.dtdate.Name = "dtdate";
            this.dtdate.Size = new System.Drawing.Size(208, 25);
            this.dtdate.TabIndex = 73;
            // 
            // txtshangpingName
            // 
            this.txtshangpingName.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtshangpingName.Location = new System.Drawing.Point(603, 31);
            this.txtshangpingName.Margin = new System.Windows.Forms.Padding(4);
            this.txtshangpingName.Name = "txtshangpingName";
            this.txtshangpingName.Size = new System.Drawing.Size(115, 27);
            this.txtshangpingName.TabIndex = 75;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(517, 36);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 18);
            this.label9.TabIndex = 74;
            this.label9.Text = "商品名称";
            // 
            // txtspbianhao
            // 
            this.txtspbianhao.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtspbianhao.FormattingEnabled = true;
            this.txtspbianhao.Location = new System.Drawing.Point(364, 31);
            this.txtspbianhao.Name = "txtspbianhao";
            this.txtspbianhao.Size = new System.Drawing.Size(121, 28);
            this.txtspbianhao.TabIndex = 76;
            this.txtspbianhao.SelectedIndexChanged += new System.EventHandler(this.txtspbianhao_SelectedIndexChanged);
            // 
            // BuyOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 570);
            this.Controls.Add(this.txtspbianhao);
            this.Controls.Add(this.txtshangpingName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtdate);
            this.Controls.Add(this.txtspprice);
            this.Controls.Add(this.btnreset);
            this.Controls.Add(this.btnsx);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btninsert);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbpaytype);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtxsshuliang);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtxsbianhao);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BuyOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售出库";
            this.Load += new System.EventHandler(this.BuyOut_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtxsbianhao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtxsshuliang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbpaytype;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnsx;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btninsert;
        private System.Windows.Forms.Button btnreset;
        private System.Windows.Forms.TextBox txtspprice;
        private System.Windows.Forms.DateTimePicker dtdate;
        private System.Windows.Forms.TextBox txtshangpingName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtspbianhao;
    }
}