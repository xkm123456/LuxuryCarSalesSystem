using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.基础资料.基础资料_商品管理
{
    public partial class GoodsInfoInsertForm : Form
    {
        public GoodsInfoInsertForm()
        {
            InitializeComponent();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //关闭此窗口
            this.Close();
        }
        private void btninsert_Click(object sender, EventArgs e)
        {
            if (TextIsNull())
            {
                //保存输入的添加数量
                int kucun = int.Parse(txtspshuliang.Text);
                try
                {
                    //判断是否插入相同的商品名
                    if(DBHelper.Select(string.Format("select * from shangPingInfo where Shangpingname='{0}'",txtspname.Text)).Rows.Count>0)
                    {
                        //找到相同商品名的编号
                        string spbianhao = DBHelper.Select(string.Format("select s.shangPingBianhao from shangPingInfo s,kuCunTable k where s.shangPingBianhao = k.shangPingBianhao and s.shangPingName = '{0}'", txtspname.Text)).Rows[0][0].ToString();
                        //插入相同商品名即将此商品的库存加输入的数量
                        if (DBHelper.Excute(string.Format("update kuCunTable set kuCunshuliang+={0} where Shangpingbianhao='{1}'", kucun, spbianhao)))
                        {
                            MessageBox.Show("已将"+txtspname.Text+"添加到库存");
                        }
                        //插入相同商品名即将此商品的订货表中的订货数量加输入的数量
                        if (DBHelper.Excute(string.Format("update dingHuoTable set dingDanshuliang+={0} where Shangpingbianhao='{1}'", kucun, spbianhao)))
                        {
                            MessageBox.Show("已将" + txtspname.Text + "添加到订货表");
                        }
                    }
                    else
                    {
                        //这是进了新的货源，将商品信息表中的数据加1
                        string sql = string.Format("insert shangPingInfo values('{0}','{1}','{2}',{3},{4},'{5}')",
                            txtspbianhao.Text, txtspname.Text, txtgysbianhao.Text, txtjhprice.Text, txtxsprice.Text, txtcarjieshao.Text);
                        if (DBHelper.Excute(sql))
                        {
                            MessageBox.Show("商品信息表数据插入成功!");
                        }
                        else
                        {
                            MessageBox.Show("商品信息表数据插入失败!");
                        }
                        //这是进了新的货源，将订单表中的数据加1
                        string dinghuoid = NewId("select top 1 dingHuoDanhao from dingHuoTable order by dingHuoDanhao desc");
                        sql = string.Format("insert dingHuoTable values('{0}','{1}','{2}',{3},'{4}','{5}','{6}')",
                            dinghuoid,txtgysbianhao.Text,DateTime.Now.ToShortDateString(),kucun,txtspbianhao.Text,txtbeizhu.Text,"刷卡");
                        if (DBHelper.Excute(sql))
                        {
                            MessageBox.Show("商品订货表数据插入成功!");
                        }
                        else
                        {
                            MessageBox.Show("商品订货表数据插入失败!");
                        }
                        //这是进了新的货源，将库存表中的数据加1
                        string kucunbianhao = NewId("select top 1 KuCunbianhao from kuCunTable order by KuCunbianhao desc");
                        sql = string.Format("insert kuCunTable values('{0}','{1}',{2})",
                            kucunbianhao,txtspbianhao.Text, kucun);
                        if (DBHelper.Excute(sql))
                        {
                            MessageBox.Show("商品库存表数据插入成功!");
                        }
                        else
                        {
                            MessageBox.Show("商品库存表数据插入失败!");
                        }
                    }
                }  
                catch(Exception ex)
                {
                    MessageBox.Show("出现错误："+ex.Message+"，请联系管理员!");
                }
            }
            else
            {
                MessageBox.Show("请将数据输入完整!");
            }
        }
        //自定义方法，每次查询订货表中最后的订货编号并加1形成新的订货id
        private string NewId(string sql)
        {
            string newId = DBHelper.Select(sql).Rows[0][0].ToString();
            //将最后一个订货编号加1形成新的订货编号
            int newdinghuoid = int.Parse(newId) + 1;
            return newdinghuoid.ToString();
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

        private void button1_Click(object sender, EventArgs e)
        {
            TextNull();
            txtspbianhao.Text = "";
            txtspname.Text = "";
            txtgysbianhao.Text = "";
        }

        private void GoodsInfoInsertForm_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\RealOne.ssk";  //皮肤文件以 .ssk结尾
            //将商品编号、商品名称、供应商编号添加到下拉框中
            DataTable dt =DBHelper.Select("select shangpingbianhao,shangpingname from shangPingInfo");
            for(int i=0;i<dt.Rows.Count;i++)
            {
                txtspbianhao.Items.Add(dt.Rows[i][0].ToString());
                txtspname.Items.Add(dt.Rows[i][1].ToString());
            }
            dt= DBHelper.Select("select distinct gysbianhao from gysTable");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                txtgysbianhao.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void txtspbianhao_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = DBHelper.Select(string.Format("select shangpingname,gysbianhao,jinhuoPrice,xiaoshouprice from shangPingInfo where shangpingbianhao='{0}'", txtspbianhao.SelectedItem.ToString()));
            txtspname.Text = dt.Rows[0][0].ToString();
            txtgysbianhao.Text = dt.Rows[0][1].ToString();
            txtjhprice.Text = dt.Rows[0][2].ToString();
            txtxsprice.Text = dt.Rows[0][3].ToString();
        }
    }
}
