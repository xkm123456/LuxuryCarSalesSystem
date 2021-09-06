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
    public partial class StaffInfoFindForm : Form
    {
        public StaffInfoFindForm()
        {
            InitializeComponent();
        }

        private void StaffInfoFindForm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DBHelper.Select("select y.Ygbianhao 员工编号, b.Bumenmingcheng 部门名称, y.YgName 员工姓名, Sex 员工性别, Zhiwu 职位, GongZi 工资, Address 住址, Phone 电话, YgPassword 密码 from Ygbiao y, Bumenbiao b where y.Bumenbianhao = b.Bumenbianhao");
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //关闭此窗口
            this.Close();
        }

        private void btnfind_Click(object sender, EventArgs e)
        {
            string sql =string.Format("select y.Ygbianhao 员工编号, b.Bumenmingcheng 部门名称, y.YgName 员工姓名, Sex 员工性别, Zhiwu 职位, GongZi 工资, Address 住址, Phone 电话, YgPassword 密码 from Ygbiao y, Bumenbiao b where y.Bumenbianhao = b.Bumenbianhao and Ygname like '%{0}%'",txtname.Text);
            this.dataGridView1.DataSource = DBHelper.Select(sql);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DBHelper.Select("select y.Ygbianhao 员工编号, b.Bumenmingcheng 部门名称, y.YgName 员工姓名, Sex 员工性别, Zhiwu 职位, GongZi 工资, Address 住址, Phone 电话, YgPassword 密码 from Ygbiao y, Bumenbiao b where y.Bumenbianhao = b.Bumenbianhao");
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            string fileName = "";

            string saveFileName = "";

            SaveFileDialog saveDialog = new SaveFileDialog();

            saveDialog.DefaultExt = "xlsx";

            saveDialog.Filter = "Excel文件|*.xlsx";

            saveDialog.FileName = fileName;

            saveDialog.ShowDialog();

            saveFileName = saveDialog.FileName;

            if (saveFileName.IndexOf(":") < 0) return; //被点了取消

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)

            {

                MessageBox.Show("无法创建Excel对象，您的电脑可能未安装Excel");

                return;

            }

            Microsoft.Office.Interop.Excel.Workbooks workbooks = xlApp.Workbooks;

            Microsoft.Office.Interop.Excel.Workbook workbook = workbooks.Add(Microsoft.Office.Interop.Excel.XlWBATemplate.xlWBATWorksheet);

            Microsoft.Office.Interop.Excel.Worksheet worksheet = (Microsoft.Office.Interop.Excel.Worksheet)workbook.Worksheets[1];//取得sheet1 

            //写入标题             

            for (int i = 0; i < dataGridView1.ColumnCount; i++)

            { worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText; }

            //写入数值
            string sql1 = "select y.Ygbianhao 员工编号, b.Bumenmingcheng 部门名称, y.YgName 员工姓名, Sex 员工性别, Zhiwu 职位, GongZi 工资, Address 住址, Phone 电话, YgPassword 密码 from Ygbiao y, Bumenbiao b where y.Bumenbianhao = b.Bumenbianhao";
            dataGridView1.DataSource = DBHelper.Select(sql1);
            for (int r = 0; r < dataGridView1.Rows.Count; r++)

            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)

                {

                    worksheet.Cells[r + 2, i + 1] = dataGridView1.Rows[r].Cells[i].Value;

                }

                System.Windows.Forms.Application.DoEvents();

            }

            worksheet.Columns.EntireColumn.AutoFit();//列宽自适应
            MessageBox.Show(fileName + "资料保存成功", "提示", MessageBoxButtons.OK);

            if (saveFileName != "")

            {

                try

                {
                    workbook.Saved = true;

                    workbook.SaveCopyAs(saveFileName);  //fileSaved = true;                 

                }

                catch (Exception ex)

                {//fileSaved = false;                      

                    MessageBox.Show("导出文件时出错,文件可能正被打开！\n" + ex.Message);

                }

            }

            xlApp.Quit();

            GC.Collect();//强行销毁    
        }
    }
}
