using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.采购计划
{
    public partial class BuyPlan : Form
    {
        public BuyPlan()
        {
            InitializeComponent();
        }

        private void btnsx_Click(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DBHelper.Select("select dingHuoDanhao 订货单号, g.gysName 供应商名称, dingHuoDate 采购日期, dingDanShuliang 采购数量, s.shangPingName 商品名称, beiZhu 备注, fuKuanStyle 付款方式 from dingHuoTable d, gysTable g, shangPingInfo s where d.gysBianhao = g.gysBianhao and d.shangPingBianhao = s.shangPingBianhao");
        }

        private void BuyPlan_Load(object sender, EventArgs e)
        {
            this.dataGridView1.DataSource = DBHelper.Select("select dingHuoDanhao 订货单号, g.gysName 供应商名称, dingHuoDate 采购日期, dingDanShuliang 采购数量, s.shangPingName 商品名称, beiZhu 备注, fuKuanStyle 付款方式 from dingHuoTable d, gysTable g, shangPingInfo s where d.gysBianhao = g.gysBianhao and d.shangPingBianhao = s.shangPingBianhao");

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            //关闭此窗体
            this.Close();
        }

        private void btndel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("是否删除此数据", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                    try
                    {
                        string sql = string.Format("delete from dingHuoTable where dingHuoDanhao='{0}'", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
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
            string sql1 = "select dingHuoDanhao 订货单号, g.gysName 供应商名称, dingHuoDate 采购日期, dingDanShuliang 采购数量, s.shangPingName 商品名称, beiZhu 备注, fuKuanStyle 付款方式 from dingHuoTable d, gysTable g, shangPingInfo s where d.gysBianhao = g.gysBianhao and d.shangPingBianhao = s.shangPingBianhao";
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
