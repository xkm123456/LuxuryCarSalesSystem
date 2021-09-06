using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1.基础资料.基础资料_供商管理
{
    public partial class InfoWhForm : Form
    {
        public InfoWhForm()
        {
            InitializeComponent();
        }
         
        private void InfoWhForm_Load(object sender, EventArgs e)
        {
            string sql = "select gysBianhao 供应商编号,gysName 供应商名称,gysaddress 供应商地址,Phone 供应商电话,Email 邮箱 from gysTable";
            //string sql = "select * from GYshangbiao";
            this.dataGridView1.DataSource = DBHelper.Select(sql);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbianhao.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtaddress.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtphone.Text = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtemail.Text = this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除此数据", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                if (txtbianhao.Text == "")
                {
                    MessageBox.Show("请输入供应商编号！");
                }
                else
                {
                    try
                    {
                        string sql = string.Format("delete from gysTable where gysBianhao='{0}'", txtbianhao.Text);
                        if (DBHelper.Excute(sql))
                        {
                            MessageBox.Show("删除成功！");
                        }
                        else
                        {
                            MessageBox.Show("删除失败！");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("出现错误信息：" + ex.Message + "，请联系管理员!");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //判断email格式是否正确
            if (!txtemail.Text.Contains("@"))
            {
                MessageBox.Show("邮箱格式不正确");
                return;
            }
            if (XiuGaiData())
            {
                MessageBox.Show("数据修改成功!");
            }
            else
            {
                MessageBox.Show("数据修改失败!");
            }
        }

        SqlDataAdapter dap;
        //自定义方法，实现在DataGridView中修改数据
        private bool XiuGaiData()
        {
            DataTable dt;
            try
            {
                //定义保存修改后数据的表
                dt = new DataTable();
                //获取当前数据源中的数据表
                string sql = "select gysBianhao 供应商编号,gysName 供应商名称,gysaddress 供应商地址,Phone 供应商电话,Email 邮箱 from gysTable";
                dt = Conn(sql);
                //定义临时存储修改后数据的表
                DataTable xgdt = (DataTable)dataGridView1.DataSource;
                //使用ImportRow方法实现复制数据
                for (int i = 0; i < xgdt.Rows.Count; i++)
                {
                    //将临时存储修改的数据表复制给保存修改后数据表
                    //将列复制
                    dt.ImportRow(xgdt.Rows[i]);
                }
                //定义SqlCommandBuilder变量
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dap);
                //调用dap的update方法更新数据
                dap.Update(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("错误原因：" + ex.Message);
                return false;
            }
            //调用表的AcceptChanges方法提交更改
            dt.AcceptChanges();
            return true;
        }

        //自定义方法，实现连接
        private DataTable Conn(string sql)
        {
            //创建连接字符串
            string connString = "server=.;database=car;uid=sa;pwd=123";
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            //创建DataAdapter适配器
            dap = new SqlDataAdapter(sql, conn);
            //创建容器
            DataTable dt = new DataTable();
            //填充
            dap.Fill(dt);
            return dt;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DBHelper.Select("select gysBianhao 供应商编号,gysName 供应商名称,gysaddress 供应商地址,Phone 供应商电话,Email 邮箱 from gysTable");
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            //文本框中的数据更改，datagridview中对应的文本也修改
            this.dataGridView1.SelectedRows[0].Cells[1].Value = txtname.Text;

        }

        private void txtbianhao_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.SelectedRows[0].Cells[0].Value = txtbianhao.Text;
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.SelectedRows[0].Cells[3].Value = txtphone.Text;
        }

        private void txtemail_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.SelectedRows[0].Cells[4].Value = txtemail.Text;
        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.SelectedRows[0].Cells[2].Value = txtaddress.Text;
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
