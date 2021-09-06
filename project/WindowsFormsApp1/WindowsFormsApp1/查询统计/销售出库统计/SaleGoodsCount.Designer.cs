namespace WindowsFormsApp1.查询统计.销售入库统计
{
    partial class SaleGoodsCount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SaleGoodsCount));
            this.btnexit = new System.Windows.Forms.Button();
            this.btnsum = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnlast = new System.Windows.Forms.Button();
            this.btnnext = new System.Windows.Forms.Button();
            this.btnprv = new System.Windows.Forms.Button();
            this.btnhome = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.butdaoru = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnexit
            // 
            this.btnexit.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnexit.Location = new System.Drawing.Point(1039, 438);
            this.btnexit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(111, 36);
            this.btnexit.TabIndex = 53;
            this.btnexit.Text = "退出";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // btnsum
            // 
            this.btnsum.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnsum.Location = new System.Drawing.Point(920, 438);
            this.btnsum.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(111, 36);
            this.btnsum.TabIndex = 52;
            this.btnsum.Text = "总计";
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(564, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 19);
            this.label1.TabIndex = 51;
            this.label1.Text = " 111";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 12);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1139, 404);
            this.dataGridView1.TabIndex = 50;
            // 
            // btnlast
            // 
            this.btnlast.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnlast.Location = new System.Drawing.Point(416, 438);
            this.btnlast.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnlast.Name = "btnlast";
            this.btnlast.Size = new System.Drawing.Size(111, 36);
            this.btnlast.TabIndex = 49;
            this.btnlast.Text = "最后一页";
            this.btnlast.UseVisualStyleBackColor = true;
            this.btnlast.Click += new System.EventHandler(this.btnlast_Click);
            // 
            // btnnext
            // 
            this.btnnext.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnnext.Location = new System.Drawing.Point(279, 438);
            this.btnnext.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnnext.Name = "btnnext";
            this.btnnext.Size = new System.Drawing.Size(111, 36);
            this.btnnext.TabIndex = 48;
            this.btnnext.Text = "下一页";
            this.btnnext.UseVisualStyleBackColor = true;
            this.btnnext.Click += new System.EventHandler(this.btnnext_Click);
            // 
            // btnprv
            // 
            this.btnprv.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnprv.Location = new System.Drawing.Point(144, 438);
            this.btnprv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnprv.Name = "btnprv";
            this.btnprv.Size = new System.Drawing.Size(111, 36);
            this.btnprv.TabIndex = 47;
            this.btnprv.Text = "上一页";
            this.btnprv.UseVisualStyleBackColor = true;
            this.btnprv.Click += new System.EventHandler(this.btnprv_Click);
            // 
            // btnhome
            // 
            this.btnhome.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnhome.Location = new System.Drawing.Point(-124, 420);
            this.btnhome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnhome.Name = "btnhome";
            this.btnhome.Size = new System.Drawing.Size(111, 36);
            this.btnhome.TabIndex = 46;
            this.btnhome.Text = "首页";
            this.btnhome.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.Location = new System.Drawing.Point(13, 438);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 36);
            this.button1.TabIndex = 54;
            this.button1.Text = "首页";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butdaoru
            // 
            this.butdaoru.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.butdaoru.Location = new System.Drawing.Point(797, 438);
            this.butdaoru.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.butdaoru.Name = "butdaoru";
            this.butdaoru.Size = new System.Drawing.Size(115, 36);
            this.butdaoru.TabIndex = 55;
            this.butdaoru.Text = "导出";
            this.butdaoru.UseVisualStyleBackColor = true;
            this.butdaoru.Click += new System.EventHandler(this.butdaoru_Click);
            // 
            // SaleGoodsCount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 499);
            this.Controls.Add(this.butdaoru);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnlast);
            this.Controls.Add(this.btnnext);
            this.Controls.Add(this.btnprv);
            this.Controls.Add(this.btnhome);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "SaleGoodsCount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "销售出库统计";
            this.Load += new System.EventHandler(this.SaleGoodsCount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnlast;
        private System.Windows.Forms.Button btnnext;
        private System.Windows.Forms.Button btnprv;
        private System.Windows.Forms.Button btnhome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butdaoru;
    }
}