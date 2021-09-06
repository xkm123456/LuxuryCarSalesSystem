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
    public partial class CustInfoLookForm : Form
    {
        public CustInfoLookForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //关闭此窗体
            this.Close();
        }

        private void CustInfoLookForm_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DBHelper.Select("select kehubianhao 客户编号,KehuName 客户姓名,Address 地址,Phone 电话,sex 性别,company 公司 from Gukebiao");
        }

        private void btnsx_Click(object sender, EventArgs e)
        {
            if(txtname.Text=="")
            {
                MessageBox.Show("请输入需要查询的姓名!");
            }
            else
            {
                string sql = string.Format("select * from Gukebiao where KehuName like '{0}%'", txtname.Text);
                this.dataGridView1.DataSource = DBHelper.Select(sql);
            }
        }

        private void btnsx_Click_1(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DBHelper.Select("select kehubianhao 客户编号,KehuName 客户姓名,Address 地址,Phone 电话,sex 性别,company 公司 from Gukebiao");
        }

        private void button1_Click(object sender, EventArgs e)
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
            string sql1 = "select kehubianhao 客户编号,KehuName 客户姓名,Address 地址,Phone 电话,sex 性别,company 公司 from Gukebiao";
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
