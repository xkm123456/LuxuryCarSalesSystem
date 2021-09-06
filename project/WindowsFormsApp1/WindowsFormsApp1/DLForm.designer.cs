namespace WindowsFormsApp1
{
    partial class DLForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DLForm));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labadmin = new System.Windows.Forms.Label();
            this.txtadmin = new System.Windows.Forms.TextBox();
            this.labpwd = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labcompany = new System.Windows.Forms.Label();
            this.cbobumen = new System.Windows.Forms.ComboBox();
            this.labtishi = new System.Windows.Forms.Label();
            this.btndl = new System.Windows.Forms.Button();
            this.btncancel = new System.Windows.Forms.Button();
            this.txtpwd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(912, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(32, 32);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(877, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 32);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // labadmin
            // 
            this.labadmin.AutoSize = true;
            this.labadmin.BackColor = System.Drawing.Color.Transparent;
            this.labadmin.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labadmin.ForeColor = System.Drawing.Color.White;
            this.labadmin.Location = new System.Drawing.Point(323, 154);
            this.labadmin.Name = "labadmin";
            this.labadmin.Size = new System.Drawing.Size(62, 25);
            this.labadmin.TabIndex = 2;
            this.labadmin.Text = "编号";
            // 
            // txtadmin
            // 
            this.txtadmin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtadmin.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtadmin.Location = new System.Drawing.Point(404, 149);
            this.txtadmin.Name = "txtadmin";
            this.txtadmin.Size = new System.Drawing.Size(220, 30);
            this.txtadmin.TabIndex = 3;
            this.txtadmin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtadmin_KeyPress);
            this.txtadmin.Validating += new System.ComponentModel.CancelEventHandler(this.txtadmin_Validating);
            // 
            // labpwd
            // 
            this.labpwd.AutoSize = true;
            this.labpwd.BackColor = System.Drawing.Color.Transparent;
            this.labpwd.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labpwd.ForeColor = System.Drawing.Color.White;
            this.labpwd.Location = new System.Drawing.Point(323, 218);
            this.labpwd.Name = "labpwd";
            this.labpwd.Size = new System.Drawing.Size(62, 25);
            this.labpwd.TabIndex = 4;
            this.labpwd.Text = "部门";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labcompany
            // 
            this.labcompany.AutoSize = true;
            this.labcompany.BackColor = System.Drawing.Color.Transparent;
            this.labcompany.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labcompany.ForeColor = System.Drawing.Color.White;
            this.labcompany.Location = new System.Drawing.Point(323, 282);
            this.labcompany.Name = "labcompany";
            this.labcompany.Size = new System.Drawing.Size(62, 25);
            this.labcompany.TabIndex = 9;
            this.labcompany.Text = "密码";
            // 
            // cbobumen
            // 
            this.cbobumen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbobumen.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cbobumen.FormattingEnabled = true;
            this.cbobumen.Location = new System.Drawing.Point(405, 214);
            this.cbobumen.Name = "cbobumen";
            this.cbobumen.Size = new System.Drawing.Size(219, 28);
            this.cbobumen.TabIndex = 10;
            this.cbobumen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cboxcompany_KeyPress);
            this.cbobumen.Validating += new System.ComponentModel.CancelEventHandler(this.cboxcompany_Validating);
            // 
            // labtishi
            // 
            this.labtishi.AutoSize = true;
            this.labtishi.BackColor = System.Drawing.Color.Transparent;
            this.labtishi.Font = new System.Drawing.Font("华文行楷", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labtishi.ForeColor = System.Drawing.Color.White;
            this.labtishi.Location = new System.Drawing.Point(261, 55);
            this.labtishi.Name = "labtishi";
            this.labtishi.Size = new System.Drawing.Size(450, 45);
            this.labtishi.TabIndex = 11;
            this.labtishi.Text = "欢迎来到豪车销售系统\r\n";
            // 
            // btndl
            // 
            this.btndl.BackColor = System.Drawing.Color.Transparent;
            this.btndl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btndl.BackgroundImage")));
            this.btndl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btndl.FlatAppearance.BorderSize = 0;
            this.btndl.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btndl.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btndl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndl.ForeColor = System.Drawing.Color.Transparent;
            this.btndl.Location = new System.Drawing.Point(289, 386);
            this.btndl.Name = "btndl";
            this.btndl.Size = new System.Drawing.Size(122, 52);
            this.btndl.TabIndex = 12;
            this.btndl.UseVisualStyleBackColor = false;
            this.btndl.Click += new System.EventHandler(this.btndl_Click);
            // 
            // btncancel
            // 
            this.btncancel.BackColor = System.Drawing.Color.Transparent;
            this.btncancel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btncancel.BackgroundImage")));
            this.btncancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btncancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btncancel.FlatAppearance.BorderSize = 0;
            this.btncancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btncancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncancel.ForeColor = System.Drawing.Color.Transparent;
            this.btncancel.Location = new System.Drawing.Point(533, 388);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(122, 50);
            this.btncancel.TabIndex = 13;
            this.btncancel.UseVisualStyleBackColor = false;
            this.btncancel.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // txtpwd
            // 
            this.txtpwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtpwd.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtpwd.Location = new System.Drawing.Point(405, 277);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(219, 30);
            this.txtpwd.TabIndex = 5;
            this.txtpwd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtpwd_KeyPress);
            this.txtpwd.Validating += new System.ComponentModel.CancelEventHandler(this.txtpwd_Validating);
            // 
            // DLForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btncancel;
            this.ClientSize = new System.Drawing.Size(945, 503);
            this.Controls.Add(this.labtishi);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btndl);
            this.Controls.Add(this.cbobumen);
            this.Controls.Add(this.labcompany);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.labpwd);
            this.Controls.Add(this.txtadmin);
            this.Controls.Add(this.labadmin);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DLForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labadmin;
        private System.Windows.Forms.TextBox txtadmin;
        private System.Windows.Forms.Label labpwd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbobumen;
        private System.Windows.Forms.Label labcompany;
        private System.Windows.Forms.Label labtishi;
        private System.Windows.Forms.Button btndl;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.TextBox txtpwd;
    }
}

