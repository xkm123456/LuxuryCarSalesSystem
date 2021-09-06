using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.基础资料.基础资料_供商管理
{
    public partial class InfoInsertForm : Form
    {
        public InfoInsertForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判断用户数据是否输入完整
            if(txtbianhao.Text != ""&&txtname.Text!=""&&txtphone.Text!=""&& txtemail.Text != ""&&txtaddress.Text!="")
            {
                //判断email格式是否正确
                if (!txtemail.Text.Contains("@"))
                {
                    MessageBox.Show("邮箱格式不正确");
                    return;
                }
                try
                {
                    //判断是否插入重复的供应商名
                    if(DBHelper.Select(string.Format("select * from gysTable where gysbianhao='{0}'",txtbianhao.Text)).Rows.Count>0)
                    {
                        MessageBox.Show("已经有此供应商，不能再次录入!");
                    }
                    else
                    {
                        string sql = string.Format("insert into gysTable values('{0}','{1}','{2}','{3}','{4}')", txtbianhao.Text, txtname.Text, txtphone.Text, txtemail.Text, txtaddress.Text);
                        if (DBHelper.Excute(sql))
                        {
                            MessageBox.Show("数据插入成功!");
                        }
                        else
                        {
                            MessageBox.Show("数据插入失败!");
                        }
                    }
                    
                }
                catch(Exception ex)
                {
                    MessageBox.Show("错误原因："+ex.Message+",请联系管理员!");
                }
            }
            else
            {
                MessageBox.Show("请将数据填写完整！");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //隐藏此窗体
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //置空所有文本框
            txtname.Text = "";
            txtbianhao.Text = "";
            txtaddress.Text = "";
            txtphone.Text = "";
            txtemail.Text = "";
        }

        private void InfoInsertForm_Load(object sender, EventArgs e)
        {
            DataTable dt =DBHelper.Select("select gysbianhao from gysTable");
            for(int i=0;i<dt.Rows.Count;i++)
            {
                txtbianhao.Items.Add(dt.Rows[i][0].ToString());
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {}

        private void txtemail_Validating(object sender, CancelEventArgs e)
        {
                                                                                     
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
    }
}
