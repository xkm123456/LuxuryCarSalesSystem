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
    public partial class StaffInfoWhForm : Form
    {
        public StaffInfoWhForm()
        {
            InitializeComponent();
        }

        private void StaffInfoWhForm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DBHelper.Select("select y.Ygbianhao 员工编号, b.Bumenmingcheng 部门名称, y.YgName 员工姓名, Sex 员工性别, Zhiwu 职位, GongZi 工资, Address 住址, Phone 电话, YgPassword 密码 from Ygbiao y, Bumenbiao b where y.Bumenbianhao = b.Bumenbianhao");
            DataTable dt = DBHelper.Select("select distinct Bumenmingcheng from Bumenbiao");
            for(int i=0; i<dt.Rows.Count;i++)
            {
                comboBox1.Items.Add(dt.Rows[i][0].ToString());
            }
            checkBox1.Checked = true;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtbianhao.Text= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            comboBox1.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            txtname.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            if(dataGridView1.SelectedRows[0].Cells[3].Value.ToString().Trim()=="男")
            {
                rdman.Checked = true;
            }
            else
            {
                rdwoman.Checked = true;
            }
            txtmoney.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtaddress.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            txtphone.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            txtpassword.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            txtposition.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //关闭此窗口
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
            {
                txtpassword.PasswordChar = '*';
            }
            else
            {
                txtpassword.PasswordChar = (char)0;
            }
        }

        private void btnxg_Click(object sender, EventArgs e)
        {
            //保存用户输入的部门相对应的编号
            string bumenBianhao = DBHelper.Select(string.Format("select Bumenbianhao from BumenBiao where Bumenmingcheng='{0}'",comboBox1.Text)).Rows[0][0].ToString();
            string sql = string.Format("update Ygbiao set Ygbianhao='{0}',Bumenbianhao='{1}',YgName='{2}',Sex='{3}',Gongzi='{4}',Address='{5}',Phone='{6}',YgPassword='{7}',Zhiwu ='{8}' where Ygbianhao='{9}'",
                txtbianhao.Text,bumenBianhao,txtname.Text,rdman.Checked?"男":"女",txtmoney.Text,txtaddress.Text,txtphone.Text,txtpassword.Text,txtposition.Text,txtbianhao.Text);

            if(DBHelper.Excute(sql))
            {
                MessageBox.Show("修改成功");
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            //保存在dataGridView中选择的员工信息的编号
            string Ygid= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            if (MessageBox.Show("是否删除此条员工信息", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string sql = string.Format("delete from Ygbiao where Ygbianhao='{0}'", Ygid);
                if(DBHelper.Excute(sql))
                {
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }

        private void btnsx_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DBHelper.Select("select y.Ygbianhao 员工编号, b.Bumenmingcheng 部门名称, y.YgName 员工姓名, Sex 员工性别, Zhiwu 职位, GongZi 工资, Address 住址, Phone 电话, YgPassword 密码 from Ygbiao y, Bumenbiao b where y.Bumenbianhao = b.Bumenbianhao");
        }

        private void txtmoney_KeyPress(object sender, KeyPressEventArgs e)
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
