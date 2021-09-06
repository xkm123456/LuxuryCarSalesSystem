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

namespace WindowsFormsApp1.基础资料.基础资料_客户管理
{
    public partial class CustInfoWhForm : Form
    {
        public CustInfoWhForm()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //关闭此窗体
            this.Close();
        }

        private void btnsx_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DBHelper.Select("select kehubianhao 客户编号,KehuName 客户姓名,Address 地址,Phone 电话,sex 性别,company 公司 from Gukebiao");
        }

        private void btndel_Click(object sender, EventArgs e)
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
                        string sql = string.Format("delete from Gukebiao where kehubianhao={0}", txtbianhao.Text);
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
                string sql = "select kehubianhao 客户编号,KehuName 客户姓名,Address 地址,Phone 电话,sex 性别,company 公司 from Gukebiao";
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
        private void btnxg_Click(object sender, EventArgs e)
        {
            if (XiuGaiData())
            {
                MessageBox.Show("数据修改成功!");
            }
            else
            {
                MessageBox.Show("数据修改失败!");
            }
        }

        private void CustInfoWhForm_Load(object sender, EventArgs e)
        {
            string sql = "select kehubianhao 客户编号,KehuName 客户姓名,Address 地址,Phone 电话,sex 性别,company 公司 from Gukebiao";
            this.dataGridView1.DataSource = DBHelper.Select(sql);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbianhao.Text = this.dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtname.Text = this.dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtaddress.Text = this.dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtphone.Text = this.dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //更改单选按钮的状态
            if(this.dataGridView1.SelectedRows[0].Cells[4].Value.ToString().Trim()=="男")
            {
                rdman.Checked = true;
            }
            else
            {
                rdwoman.Checked = true;
            }
            txtwork.Text= this.dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
        }

        private void txtbianhao_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.SelectedRows[0].Cells[0].Value = txtbianhao.Text;
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.SelectedRows[0].Cells[1].Value = txtname.Text;
        }

        private void txtphone_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.SelectedRows[0].Cells[3].Value = txtphone.Text;
        }

        private void txtwork_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.SelectedRows[0].Cells[5].Value = txtwork.Text;
        }

        private void txtaddress_TextChanged(object sender, EventArgs e)
        {
            this.dataGridView1.SelectedRows[0].Cells[2].Value = txtaddress.Text;
        }

        private void rdman_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridView1.SelectedRows[0].Cells[4].Value = rdman.Text;
        }

        private void rdwoman_CheckedChanged(object sender, EventArgs e)
        {
            this.dataGridView1.SelectedRows[0].Cells[4].Value = rdwoman.Text;
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
