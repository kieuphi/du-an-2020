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
    public partial class FmDichVu : DevExpress.XtraEditors.XtraForm
    {
        public FmDichVu()
        {
            InitializeComponent();
        }
        private decimal soluong = 0;
        private decimal gia = 0;
        private decimal tongtien = 0;

        dbConnect db = new dbConnect();
        private void FmDichVu_Load(object sender, EventArgs e)
        {
   
            loaddl();
        }
        private void loaddl()
        {
            gridControl2.DataSource = db.GetData("select dv.MaDV MaDV,MaLoaiDV,DienGiai,SoLuong = '1',dv.DonGia DonGia,ThanhTien,Active from DichVu dv left join ChiTietDV ctdv on dv.MaDV = ctdv.MaDV");
        }
        public List<DataRow> SelectedTS = new List<DataRow>();
        private void btn_Chon_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedTS.Clear();
                var rows = gridView4.GetSelectedRows();
                for (int i = 0; i < rows.Length; i++)
                {
                    var r = gridView4.GetDataRow(rows[i]);
                    SelectedTS.Add(r);

                }

                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch { }
        }

        private void gridView4_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if(e.Column.FieldName == "SoLuong")
            {
                soluong = Convert.ToDecimal(gridView4.GetFocusedRowCellValue(colSoLuong));
                gia = Convert.ToDecimal(gridView4.GetFocusedRowCellValue(colDonGia));
                tongtien = soluong * gia;
                gridView4.SetFocusedRowCellValue(colTongTien, tongtien);
            }
        }
    }
}