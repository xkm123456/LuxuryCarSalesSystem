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
using WindowsFormsApp1.基础资料.基础资料_商品管理;
using WindowsFormsApp1.库存盘点;

namespace WindowsFormsApp1
{
    public partial class DLForm : Form
    {
        public DLForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //将命令按钮的边框线去除
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            btndl.FlatAppearance.BorderSize = 0;
            
            //将光标焦点集中到文本框中
            this.Show();
            txtadmin.Focus();

            //将部门名称添加到下拉列表中
            DataTable dt=DBHelper.Select("select distinct Bumenmingcheng from Glyuanbiao");
            for(int i=0;i<dt.Rows.Count;i++)
            {
                cbobumen.Items.Add(dt.Rows[i][0].ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否退出豪车商城","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //最小化窗体
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
        }
        //设置错误变量，只有用户输入了完整的信息才能登陆
        int a, b,c;
        private SqlDataReader IsDL(string sql)
        {
            //创建连接字符串
            string connString = "server=.;database=car;Integrated Security=true";
            //创建连接对象
            SqlConnection conn = new SqlConnection(connString);
            //打开连接
            conn.Open();
            //创建命令对象
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader read = cmd.ExecuteReader();
            return read;
        }
        private void txtadmin_Validating(object sender, CancelEventArgs e)
        {
            if(txtadmin.Text=="")
            {
                //设置错误提示
                errorProvider1.SetError(txtadmin, "编号不能为空");
                
            }
            else
            {
                errorProvider1.SetError(txtadmin, "");
                a = 1;
            }
        }

        private void txtpwd_TextChanged(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
            //创建Zhuce窗体对象
            //ZhuCeForm zc = new ZhuCeForm();
            //显示注册窗体
            //zc.Show();
            //隐藏主窗体
            Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }
        //创建一个变量保存当前用户名称
        public static string username = "";
        private void btndl_Click(object sender, EventArgs e)
        {
            //创建sql语句
            string sql = "select * from Glyuanbiao";
            //使用DBHelper中的Select方法返回数据表
            SqlDataReader read = IsDL(sql);

            //判断编号文本框、密码文本框或部门文本框是否为空
            if (a + b + c != 3)
            {
                MessageBox.Show("请输入编号、密码或部门");
            }
            else
            {
                while (read.Read())
                {
                    //判断用户输入的编号、密码和部门是否与已在数据库中的数据一致
                    if (txtadmin.Text == read["Glyuanbianhao"].ToString() && txtpwd.Text == read["Password"].ToString() && cbobumen.Text== read["Bumenmingcheng"].ToString())
                    {
                        //判断是否是管理部人员
                        if (cbobumen.Text=="管理部")
                        {
                            MessageBox.Show("登录成功");
                            //实例化主窗口
                            MainForm mainForm = new MainForm();
                            mainForm.Show();
                            //隐藏登录窗口
                            this.Hide();
                        }
                        else if(cbobumen.Text == "销售部")
                        {
                            //销售部门人员登录成功看只能操作商品信息录入模块
                            GoodsInfoInsertForm goodsInfoInsertForm = new GoodsInfoInsertForm();
                            goodsInfoInsertForm.Show();
                            //隐藏登录窗口
                            this.Hide();
                        }
                        else if(cbobumen.Text == "后勤部")
                        {
                            //后勤人员登录成功后 只能查看库存盘点信息
                            KuKunPandian kuKunPandian = new KuKunPandian();
                            kuKunPandian.Show();
                            //隐藏登录窗口
                            this.Hide();
                        }
                        return;
                    }
                }
                MessageBox.Show("编号或密码或部门错误!");
            }

        }

        private void txtadmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            //检测键盘是否输入了回车键，如果按下回车键，则将鼠标光标(焦点)移至下一个文本框txxpwd
            if (e.KeyChar == '\r')  cbobumen.Focus();
        }

        private void txtpwd_KeyPress(object sender, KeyPressEventArgs e)
        {
            //检测键盘是否输入了回车键，如果按下回车键，则将鼠标光标(焦点)移至登录按钮btndl
            if (e.KeyChar == '\r') btndl.Focus();
        }

        private void cboxcompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            //检测键盘是否输入了回车键，如果按下回车键，则将鼠标光标(焦点)移至下拉框cboxcompany
            if (e.KeyChar == '\r') txtpwd.Focus();
        }

        //设置一个坐标变量，存储坐标
        private Point mypoint;
        //鼠标按下时的事件
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //获取鼠标按下时的位置
            mypoint = new Point(e.X,e.Y);
        }
        //鼠标移动事件
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                //如果不减去鼠标按下时的位置mypoint的话，窗体会直接移到鼠标按下的位置
                this.Location = new Point(this.Location.X + e.X - mypoint.X, this.Location.Y + e.Y - mypoint.Y);
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            //退出系统
            if (MessageBox.Show("是否退出豪车商城", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void cboxcompany_Validating(object sender, CancelEventArgs e)
        {
            if(cbobumen.Text=="")
            {
                errorProvider1.SetError(cbobumen, "请输入或选择部门");
            }
            else
            {
                errorProvider1.SetError(cbobumen, "");
                c = 1;
            }
        }

        private void txtpwd_Validating(object sender, CancelEventArgs e)
        {
            if (txtpwd.Text == "")
            {
                //设置错误按钮
                errorProvider1.SetError(txtpwd, "密码不能为空");
                //如果密码没输入，则不能登录
                //btndl.Enabled = false;
            }
            else
            {
                errorProvider1.SetError(txtpwd, "");
                b = 1;
            }
        }
    }
}
