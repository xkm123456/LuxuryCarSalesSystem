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

namespace WindowsFormsApp1.基础资料.基础资料_商品管理
{
    public partial class GoodsInfoWhForm : Form
    {
        public GoodsInfoWhForm()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //关闭此窗体
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DBHelper.Select("select shangPingBianhao 商品编号,shangPingName 商品名称,gysBianhao 供应商编号,jinHuoPrice 进货价格,xiaoShouPrice 销售价格,carjieshao 汽车介绍 from shangPingInfo");
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
                string sql = "select shangPingBianhao 商品编号,shangPingName 商品名称, gysBianhao 供应商编号,jinHuoPrice 进货价格, xiaoShouPrice 销售价格,carjieshao 汽车介绍 from shangPingInfo";
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

        private void btndel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否删除此数据","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                if (txtbianhao.Text == "")
                {
                    MessageBox.Show("请输入商品编号！");
                }
                else
                {
                    try
                    {
                        //删除库存表中的对应商品数据
                        string sql = string.Format("delete from dingHuoTable where shangPingBianhao={0}", txtbianhao.Text);
                        if (DBHelper.Excute(sql))
                        {
                            MessageBox.Show("删除成功！");
                        }
                        else
                        {
                            MessageBox.Show("删除失败！");
                        }
                        //删除销售表中的对应商品数据
                        sql = string.Format("delete from kuCunTable where shangPingBianhao={0}", txtbianhao.Text);
                        DBHelper.Excute(sql);
                        
                        //删除商品信息表中对应的数据
                        sql = string.Format("delete from shangPingInfo where shangPingBianhao={0}", txtbianhao.Text);
                        DBHelper.Excute(sql);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("出现错误信息：" + ex.Message + "，请联系管理员!");
                    }
                }
            }
        }

        private void GoodsInfoWhForm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DBHelper.Select("select shangPingBianhao 商品编号,shangPingName 商品名称,gysBianhao 供应商编号,jinHuoPrice 进货价格,xiaoShouPrice 销售价格,carjieshao 汽车介绍 from shangPingInfo");
            //将商品编号加入下拉列表
            DataTable dt = DBHelper.Select("select distinct shangPingBianhao from shangPingInfo");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtbianhao.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            if(txtname.Text == "")
            {
                MessageBox.Show("请输入商品名称");
            }
            else if(DBHelper.Select(string.Format("select shangPingBianhao 商品编号,shangPingName 商品名称,gysBianhao 供应商编号,jinHuoPrice 进货价格,xiaoShouPrice 销售价格,carjieshao 汽车介绍 from shangPingInfo where shangpingbianhao='{0}' and  shangPingName='{1}'", txtbianhao.Text, txtname.Text)).Rows.Count > 0)
            {
                //只有商品名称
                this.dataGridView1.DataSource = DBHelper.Select(string.Format("select shangPingBianhao 商品编号,shangPingName 商品名称,gysBianhao 供应商编号,jinHuoPrice 进货价格,xiaoShouPrice 销售价格,carjieshao 汽车介绍 from shangPingInfo where shangPingName='{0}'", txtname.Text));
            }
            else
            {
                 if (MessageBox.Show("没有查询到汽车信息，是否跳转到网站查询", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                 {
                    //跳转网页
                    System.Diagnostics.Process.Start("https://www.dcdapp.com/");
                 }
            }
        }

        private void txtbianhao_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.Select(string.Format("select shangPingName from shangPingInfo where shangPingBianhao='{0}'", txtbianhao.SelectedItem.ToString()));
            txtname.Text = dt.Rows[0][0].ToString();
        }
    }
}
