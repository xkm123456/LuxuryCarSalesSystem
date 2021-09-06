using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.基础资料.基础资料_供商管理;
using WindowsFormsApp1.基础资料.基础资料_客户管理;
using WindowsFormsApp1.基础资料.基础资料_商品管理;
using WindowsFormsApp1.基础资料.基础资料_员工管理;
using WindowsFormsApp1.采购计划;
using WindowsFormsApp1.销售出库;
using WindowsFormsApp1.库存盘点;
using WindowsFormsApp1.系统关于;
using WindowsFormsApp1.进货入库统计;
using WindowsFormsApp1.查询统计.销售入库统计;

namespace WindowsFormsApp1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void 供商信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //供应商信息录入
            InfoInsertForm infoInsertForm = new InfoInsertForm();
            infoInsertForm.Show();
        }

        private void 进货管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 供商信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //供应商信息维护
            InfoWhForm infoWhForm = new InfoWhForm();
            infoWhForm.Show();
        }

        private void 供商信息一览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //供应商信息一览
            InfoLookForm infoLookForm = new InfoLookForm();
            infoLookForm.Show();
        }

        private void 关闭系统ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("是否退出豪车销售系统","提示",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)
            {
                //退出程序
                Application.Exit();
            }
        }

        private void 客户信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //客户信息录入窗体
            CustInfoInsertForm custInfoInsertForm = new CustInfoInsertForm();
            custInfoInsertForm.Show();
        }

        private void 客户信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //客户信息维护窗体
            CustInfoWhForm custInfoWhForm = new CustInfoWhForm();
            custInfoWhForm.Show();
        }

        private void 客户信息一览ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //客户信息一览窗体
            CustInfoLookForm custInfoLookForm = new CustInfoLookForm();
            custInfoLookForm.Show();
        }

        private void 商品信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //商品信息录入窗体
            GoodsInfoInsertForm goodsInfoInsertForm = new GoodsInfoInsertForm();
            goodsInfoInsertForm.Show();
        }

        private void 商品信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //商品信息维护窗口
            GoodsInfoWhForm goodsInfoWhForm = new GoodsInfoWhForm();
            goodsInfoWhForm.Show();
        }

        private void 商品信息一览表ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //商品信息一览窗口
            GoodsInfoLookForm goodsInfoLookForm = new GoodsInfoLookForm();
            goodsInfoLookForm.Show();
        }

        private void 员工信息录入ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //员工信息录入窗口
            StaffInfoInsertForm staffInsertForm = new StaffInfoInsertForm();
            staffInsertForm.Show();
        }

        private void 员工信息维护ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //员工信息维护窗口
            StaffInfoWhForm staffInfoWhForm = new StaffInfoWhForm();
            staffInfoWhForm.Show();
        }

        private void 员工信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //员工信息查找窗口
            StaffInfoFindForm staffInfoFindForm = new StaffInfoFindForm();
            staffInfoFindForm.Show();
        }

        private void 商品类型设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            //采购计划窗口
            BuyPlan buyPlan = new BuyPlan();
            buyPlan.Show();
        }

        private void toolStripLabel3_Click(object sender, EventArgs e)
        {
            //销售出库窗口
            BuyOut buyOut = new BuyOut();
            buyOut.Show();
        }

        private void toolStripLabel5_Click(object sender, EventArgs e)
        {
            //库存盘点窗口
            KuKunPandian kuKunPandian = new KuKunPandian();
            kuKunPandian.Show();
        }

        private void 系统关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //系统关于窗口
            XiTongGy xiTongGy = new XiTongGy();
            xiTongGy.Show();
        }

        private void 查询统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            skinEngine1.SkinFile = System.Environment.CurrentDirectory + "\\Skins\\RealOne.ssk";  //皮肤文件以 .ssk结尾
        }

        private void 进货入库统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //进货入库统计窗口
            IntoGoodsCount intoGoodsCount = new IntoGoodsCount();
            intoGoodsCount.Show();
        }

        private void 销售出库统计ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //销售出库统计窗口
            SaleGoodsCount saleGoodsCount = new SaleGoodsCount();
            saleGoodsCount.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
