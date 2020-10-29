using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using QuanlyPhongKham.Md_KhamBenh;

namespace QuanlyPhongKham
{
    public partial class FmMain : DevExpress.XtraEditors.XtraForm
    {
        public FmMain()
        {
            InitializeComponent();
        }
        Form CheckForm(Type fType)
        {
            foreach (var f in this.MdiChildren)
            {
                if (f.GetType() == fType)
                    return f;
            }
            return null;
        }


        private void btn_PhieuKham_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Form frm = CheckForm(typeof(FmDanhSachChoKham));
            if (frm != null)
                frm.Activate();
            else
            {
                FmDanhSachChoKham ts = new FmDanhSachChoKham();
                ts.MdiParent = this;
                ts.Show();
            }

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }


        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FmTaoHoSo f = new FmTaoHoSo();
           // f.WindowState = FormWindowState.Maximized;
            f.Show();
        }

        private void FmMain_Load(object sender, EventArgs e)
        {
            Form frm = CheckForm(typeof(FmDanhSachChoKham));
            if (frm != null)
                frm.Activate();
            else
            {
                FmDanhSachChoKham ts = new FmDanhSachChoKham();
                ts.MdiParent = this;
                ts.Show();
            }

        }
    }
}