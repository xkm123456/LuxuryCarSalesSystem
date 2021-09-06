using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.销售出库
{
    public partial class BuyOut : Form
    {
        public BuyOut()
        {
            InitializeComponent();
        }

        private void BuyOut_Load(object sender, EventArgs e)
        {
            //将当前时间作为销售编号
            string xiaoshoubianhao = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            txtxsbianhao.Text = xiaoshoubianhao;
            this.dataGridView1.DataSource = DBHelper.Select("select xiaoShouBianhao 销售编号,shangPingBianhao 商品编号,shangPingName 商品名称,xiaoShouPrice 销售价格,xiaoShouShuliang 销售数量,xiaoShouDate 销售日期,fuKuanStyle 付款方式 from xiaoShouTable");
            //将付款方式加入下拉列表
            DataTable dt = DBHelper.Select("select distinct fuKuanStyle from dingHuoTable");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                cmbpaytype.Items.Add(dt.Rows[i][0].ToString());
            }
            //将商品编号加入下拉列表
            dt = DBHelper.Select("select distinct shangPingBianhao from shangPingInfo");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtspbianhao.Items.Add(dt.Rows[i][0].ToString());
            }

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //关闭此窗口
            this.Close();
        }

        private void btnsx_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DBHelper.Select("select xiaoShouBianhao 销售编号,shangPingBianhao 商品编号,shangPingName 商品名称,xiaoShouPrice 销售价格,xiaoShouShuliang 销售数量,xiaoShouDate 销售日期,fuKuanStyle 付款方式 from xiaoShouTable");
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtxsbianhao.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            txtspbianhao.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtshangpingName.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            txtspprice.Text= dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            txtxsshuliang.Text= dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            if(dataGridView1.SelectedRows[0].Cells[5].Value.ToString()!="")
            {
                dtdate.Value = DateTime.Parse(dataGridView1.SelectedRows[0].Cells[5].Value.ToString());
            }
            cmbpaytype.Text= dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
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
            //将当前时间作为销售编号
            string xiaoshoubianhao = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            txtxsbianhao.Text = xiaoshoubianhao;
            if (TextIsNull())
            {
                try
                {
                    //判断是否插入了正确的商品编号和商品名称
                    if (DBHelper.Select(string.Format("select * from shangPingInfo where shangPingbianhao='{0}' and shangPingName='{1}'", txtspbianhao.Text,txtshangpingName.Text)).Rows.Count>0)
                    {
                        //保存库存表中的指定商品库存
                        int stock = int.Parse(DBHelper.Select(string.Format("select kuCunshuliang from kuCunTable  where shangpingbianhao=(select shangPingBianhao from shangPingInfo where shangPingName='{0}')", txtshangpingName.Text)).Rows[0][0].ToString());
                        //保存指定商品的商品编号
                        string spid = DBHelper.Select(string.Format("select shangPingBianhao from shangPingInfo where shangPingName='{0}'", txtshangpingName.Text)).Rows[0][0].ToString();
                        //保存用户选择的日期
                        DateTime date = DateTime.Parse(dtdate.Text);
                        string riqi = date.Year + "-" + date.Month + "-" + date.Day;

                        //判断输入的商品库存是否超过了库存表中的库存
                        if (stock- int.Parse(txtxsshuliang.Text)>= 0)
                        {
                            //更新库存
                            string sql = string.Format("update kuCunTable set kuCunshuliang-={0} where shangPingBianhao='{1}'",txtxsshuliang.Text,txtspbianhao.Text);
                            if (DBHelper.Excute(sql))
                            {
                                MessageBox.Show("库存更新成功!");
                            }
                            else
                            {
                                MessageBox.Show("库存更新失败!");
                            }
                            //插入数据
                            sql = string.Format("insert xiaoShouTable values('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",txtxsbianhao.Text,txtspbianhao.Text,txtspprice.Text,txtxsshuliang.Text,riqi,cmbpaytype.Text,txtshangpingName.Text);
                            if (DBHelper.Excute(sql))
                            {
                                MessageBox.Show("数据插入成功!");
                            }
                            else
                            {
                                MessageBox.Show("库存插入失败!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("库存不足，请重新输入");
                        }
                    }
                    else
                    {
                        MessageBox.Show("请输入正确的商品编号或商品名称");
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

        private void btnreset_Click(object sender, EventArgs e)
        {
            TextNull();
            //将下拉框置空
            cmbpaytype.Text = "";
            //将当前时间作为销售编号
            string xiaoshoubianhao = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            txtxsbianhao.Text = xiaoshoubianhao;
        }

        private void txtspbianhao_SelectedIndexChanged(object sender, EventArgs e)
        {
            //将当前时间作为销售编号
            string xiaoshoubianhao = DateTime.Now.Year.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Second.ToString();
            txtxsbianhao.Text = xiaoshoubianhao;
            DataTable dt = DBHelper.Select(string.Format("select shangPingName,xiaoShouPrice from shangPingInfo where shangPingBianhao='{0}'", txtspbianhao.SelectedItem.ToString()));
            txtshangpingName.Text = dt.Rows[0][0].ToString();
            txtspprice.Text = dt.Rows[0][1].ToString();
        }
    }
}
