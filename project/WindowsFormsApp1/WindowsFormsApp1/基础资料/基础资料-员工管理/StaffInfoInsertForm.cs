using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.基础资料.基础资料_员工管理
{
    public partial class StaffInfoInsertForm : Form
    {
        public StaffInfoInsertForm()
        {
            InitializeComponent();
        }

        private void StaffInsertForm_Load(object sender, EventArgs e)
        {
            //distinct去掉重复列
            DataTable dt = DBHelper.Select("select distinct Bumenmingcheng from Bumenbiao");
            //将部门名称添加到下拉列表中
            for(int i=0;i<dt.Rows.Count;i++)
            {
                comboBox1.Items.Add(dt.Rows[i][0].ToString());
            }

            //将当前时间作为员工编号
            string yuangongbianhao = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            txtygbianhao.Text = yuangongbianhao;
        }
        //自定义方法，判断此窗体中所有文本框是否都输入了数据
        private bool TextIsNull()
        {
            bool result = true;
            //遍历所有文本框控件
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox t = (TextBox)control;
                    //如果此窗体中一个文本框为空，就将false值赋给result
                    if (t.Text == "") result = false;
                }
            }
            return result;
        }
        private void btninsert_Click(object sender, EventArgs e)
        {
            if (TextIsNull())
            {
                try
                {
                    //保存从下拉框中选择的部门名称对应的部门编号
                    string bumenbianhao = DBHelper.Select(string.Format("select Bumenbianhao from Bumenbiao where Bumenmingcheng='{0}'",comboBox1.Text)).Rows[0][0].ToString();
                    string sql = string.Format("insert Ygbiao values('{0}','{1}','{2}','{3}','{4}',{5},'{6}','{7}','{8}')", txtygbianhao.Text, bumenbianhao, txtname.Text, rdman.Checked ? "男" : "女", txtposition.Text
                        , txtmoney.Text,txtaddress.Text,txtphone.Text,txtpassword.Text);
                    if (DBHelper.Excute(sql))
                    {
                        MessageBox.Show("数据插入成功!");
                        //将当前时间作为员工编号
                        string yuangongbianhao = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
                        txtygbianhao.Text = yuangongbianhao;
                    }
                    else
                    {
                        MessageBox.Show("数据插入失败!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("出现错误：" + ex.Message + "，请联系管理员!");
                }
            }
            else
            {
                MessageBox.Show("请将数据输入完整!");
            }
        }

        //自定义方法，将窗体中所有文本框内容置空
        private void TextNull()
        {
            //遍历所有文本框控件
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    TextBox t = (TextBox)control;
                    //将每个文本框内容置空
                    t.Text = "";
                }
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            //关闭此窗口
            this.Close();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            TextNull();
            comboBox1.Text = "";
            rdman.Checked = false;
            rdwoman.Checked = false;
            //将当前时间作为员工编号
            string yuangongbianhao = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            txtygbianhao.Text = yuangongbianhao;
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtphone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= '0' && e.KeyChar <= '9') || ((Keys)(e.KeyChar) == Keys.Back))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("只能输入数字");
                return;
            }
        }

        private void txtygbianhao_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //distinct去掉重复列
            DataTable dt = DBHelper.Select(string.Format("select distinct Zhiwu from Ygbiao where Zhiwu like '%{0}%'", comboBox1.SelectedItem.ToString()));
            //将部门名称添加到下拉列表中
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtposition.Items.Add(dt.Rows[i][0].ToString());
            }
        }
    }
}
