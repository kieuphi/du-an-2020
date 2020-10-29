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
    public partial class FmDanhSachChoKham : DevExpress.XtraEditors.XtraForm
    {
        public FmDanhSachChoKham()
        {
            InitializeComponent();
        }
        dbConnect db = new dbConnect();
        private void FmDanhSachChoKham_Load(object sender, EventArgs e)
        {
            
        }
        private void loaddl()
        {
            if(radioGroup1.EditValue == "0")
            {
                gridControl1.DataSource = db.GetData("select ROW_NUMBER() OVER (ORDER BY MaPhieuKham) AS STT,* from BenhNhan bn left join HSKhamBenh hs on bn.ID = hs.MaBN where TrangThai = 1");
            }
            if(radioGroup1.EditValue == "1")
            {
                gridControl1.DataSource = db.GetData("select ROW_NUMBER() OVER (ORDER BY MaPhieuKham) AS STT,* from BenhNhan bn left join HSKhamBenh hs on bn.ID = hs.MaBN where TrangThai = 2");
            }

        }

        private void radioGroup1_SelectedIndexChanged(object sender, EventArgs e)
        {
            loaddl();
        }
    }
}