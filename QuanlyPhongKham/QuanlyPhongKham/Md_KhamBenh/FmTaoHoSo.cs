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
    public partial class FmTaoHoSo : DevExpress.XtraEditors.XtraForm
    {
        public FmTaoHoSo()
        {
            InitializeComponent();
        }

        private void labelControl13_Click(object sender, EventArgs e)
        {

        }
        dbConnect db = new dbConnect();
        //bool xtraTabPage1 = true;
        private void simpleButton5_Click(object sender, EventArgs e)
        {
            if(xtraTabControl1.SelectedTabPage == xtraTabPage1)
            {
                FmDichVuKhamBenh f = new FmDichVuKhamBenh();
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var listTS = f.SelectedTS;
                    var list = gridControl1.DataSource as DataTable;
                    if (list == null) return;

                    foreach (DataRow ts in listTS)
                    {
                        var r = list.NewRow();
                        r["MATS"] = ts["MATS"] + "";
                        r["TENTS"] = ts["TENTS"] + "";
                        r["TENDVT"] = ts["TENDVT"] + "";

                        list.Rows.Add(r);
                    }
                }
               
            }
              if(xtraTabControl1.SelectedTabPage == xtraTabPage2)
            {
                FmDichVu f = new FmDichVu();
                if (f.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    var listTS = f.SelectedTS;
                    var list = gridControl2.DataSource as DataTable;
                    if (list == null) return;

                    foreach (DataRow ts in listTS)
                    {
                        var r = list.NewRow();
                        r["MaDV"] = ts["MaDV"] + "";
                        r["MaLoaiDV"] = ts["MaLoaiDV"] + "";
                        r["DienGiai"] = ts["DienGiai"] + "";
                        r["DonGia"] = ts["DonGia"] + "";
                        r["Active"] = ts["Active"] + "";

                        list.Rows.Add(r);
                    }
                }
            }

        }

        private void FmTaoHoSo_Load(object sender, EventArgs e)
        {
            gridControl2.DataSource = db.GetData("select * from DichVu");
            var dt = gridControl2.DataSource as DataTable;
            dt.Clear();
        }

        private void repositoryItemButtonEdit1_Click(object sender, EventArgs e)
        {
            gridView4.DeleteRow(gridView4.FocusedRowHandle);
        }
    }
}