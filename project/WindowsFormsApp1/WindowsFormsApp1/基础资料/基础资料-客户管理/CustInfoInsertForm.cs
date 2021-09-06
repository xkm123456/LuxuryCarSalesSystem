using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.基础资料.基础资料_客户管理
{
    public partial class CustInfoInsertForm : Form
    {
        public CustInfoInsertForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //隐藏此窗体
            this.Hide();
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            //清空所有文本框
            txtbianhao.Text = "";
            txtname.Text = "";
            txtphone.Text = "";
            txtaddress.Text = "";
            txtwork.Text="";
            rdman.Checked = false;
            rdwoman.Checked = false;
            //将当前时间作为顾客编号
            string gukebianhao = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString()+ DateTime.Now.Second.ToString();
            txtbianhao.Text = gukebianhao;
        }

        private void btninsert_Click(object sender, EventArgs e)
        {
            //将当前时间作为顾客编号
            string gukebianhao = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            txtbianhao.Text = gukebianhao;
            //判断用户数据是否输入完整
            if (txtbianhao.Text != "" && txtname.Text != "" && txtphone.Text != "" && txtwork.Text != "" && txtaddress.Text != "")
            {
                try
                {
                    string sql = string.Format("insert into Gukebiao values({0},'{1}','{2}','{3}','{4}','{5}')", txtbianhao.Text, txtname.Text, txtaddress.Text, txtphone.Text,rdman.Checked?"男":"女",txtwork.Text);
                    if (DBHelper.Excute(sql))
                    {
                        MessageBox.Show("数据插入成功!");
                    }
                    else
                    {
                        MessageBox.Show("数据插入失败!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误原因：" + ex.Message + ",请联系管理员!");
                }
            }
            else
            {
                MessageBox.Show("请将数据填写完整！");
            }
        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtwork_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void rdwoman_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdman_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtbianhao_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CustInfoInsertForm_Load(object sender, EventArgs e)
        {
            //将当前时间作为顾客编号
            string gukebianhao = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            txtbianhao.Text = gukebianhao;
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
    }
}
