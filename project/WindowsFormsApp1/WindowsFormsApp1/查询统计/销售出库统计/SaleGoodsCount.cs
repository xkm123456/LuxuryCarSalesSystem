using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WindowsFormsApp1.查询统计.销售入库统计
{
    public partial class SaleGoodsCount : Form
    {
        public SaleGoodsCount()
        {
            InitializeComponent();
        }
        //当前页
        int page = 0;
        DataTable dt = DBHelper.Select("select xiaoShouBianhao 销售编号, s.shangPingBianhao 商品编号, s.shangPingName 商品名称, x.xiaoShouPrice 销售价格, xiaoShouShuliang 销售数量, xiaoShouDate 销售日期, fuKuanStyle 付款方式 from xiaoShouTable x, shangPingInfo s where x.shangPingBianhao = s.shangPingBianhao");
        //页数=总记录数/每页显示的记录数
        int pagecount;
        //自定义方法实现换页
        private void ExchangePage()
        {
            //数据表中总记录数
            int recordsum = dt.Rows.Count;
            //每页显示的记录数
            int record = 3;
            if (recordsum % record == 0)  //判断记录是否是奇数，是奇数就要多出一页来显示多出来的记录8
            {
                //页数=总记录数/每页显示的记录数
                pagecount = recordsum / record;
            }
            else
            {
                pagecount = recordsum / record + 1;
            }

            /*判断页索引*/
            if (pagecount == 2)  //判断页数量是否等于2
            {
                if (page == 0)  //如果是第一页，则上一个按钮不能用
                {
                    btnprv.Enabled = false;
                    btnnext.Enabled = true;
                }
                else if (page == pagecount - 1) //如果是最后一页，则下一个按钮不能用
                {
                    btnprv.Enabled = true;
                    btnnext.Enabled = false;
                }
                else //否则都能
                {
                    btnnext.Enabled = true;
                    btnprv.Enabled = true;
                }
            }
            else if (pagecount < 2)  //只有一页，上下按钮都不能用
            {
                btnprv.Enabled = false;
                btnnext.Enabled = false;
            }
            else
            {
                if (page == 0)  //如果是第一个表，则上一个按钮不能用
                {
                    btnprv.Enabled = false;
                    btnnext.Enabled = true;
                }
                else if (page == pagecount - 1) //如果是最后一个表，则下一个按钮不能用
                {
                    btnprv.Enabled = true;
                    btnnext.Enabled = false;
                }
                else //否则都能
                {
                    btnnext.Enabled = true;
                    btnprv.Enabled = true;
                }
            }
            label1.Text = string.Format("第{0}页/共{1}页 共{2}条记录", page + 1, pagecount, recordsum);

            //显示3条数据到datagridview中
            if (pagecount < 2)
            {
                //从0开始，向后查询3条数据
                string sql = "select xiaoShouBianhao 销售编号, s.shangPingBianhao 商品编号, s.shangPingName 商品名称, x.xiaoShouPrice 销售价格, xiaoShouShuliang 销售数量, xiaoShouDate 销售日期, fuKuanStyle 付款方式 from xiaoShouTable x, shangPingInfo s where x.shangPingBianhao = s.shangPingBianhao ORDER BY xiaoShouBianhao OFFSET 0 ROWS FETCH NEXT 3 ROWS ONLY; ";
                this.dataGridView1.DataSource = DBHelper.Select(sql);
            }
            else
            {
                //page从0开始，每次向后读取3条
                string sql = string.Format("select xiaoShouBianhao 销售编号, s.shangPingBianhao 商品编号, s.shangPingName 商品名称, x.xiaoShouPrice 销售价格, xiaoShouShuliang 销售数量, xiaoShouDate 销售日期, fuKuanStyle 付款方式 from xiaoShouTable x, shangPingInfo s where x.shangPingBianhao = s.shangPingBianhao ORDER BY xiaoShouBianhao OFFSET {0} ROWS FETCH NEXT 3 ROWS ONLY; ", page * 3);
                this.dataGridView1.DataSource = DBHelper.Select(sql);
            }
        }
        private void btnexit_Click(object sender, EventArgs e)
        {
            //关闭此窗口
            this.Close();
        }

        private void SaleGoodsCount_Load(object sender, EventArgs e)
        {
            ExchangePage();
        }

        private void btnprv_Click(object sender, EventArgs e)
        {
            page--;
            ExchangePage();
        }

        private void btnnext_Click(object sender, EventArgs e)
        {
            page++;
            ExchangePage();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            page = 0;
            ExchangePage();
        }

        private void btnlast_Click(object sender, EventArgs e)
        {
            page = pagecount - 1;
            ExchangePage();
        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            //表中总记录
            MessageBox.Show("销售统计：" + dt.Rows.Count, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void butdaoru_Click(object sender, EventArgs e)
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

            GC.Collect();//强行销毁           }

        }
    }
    
}
