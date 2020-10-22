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

namespace QuanlyPhongKham.Md_KhamBenh
{
    public partial class FmPhieuKham : DevExpress.XtraEditors.XtraForm
    {
        public FmPhieuKham()
        {
            InitializeComponent();
        }

        private void btn_Insert_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FmPhieuKhamInsert f = new FmPhieuKhamInsert();
            f.Show();
        }
    }
}