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
    public partial class FmDichVuKhamBenh : DevExpress.XtraEditors.XtraForm
    {
        public FmDichVuKhamBenh()
        {
            InitializeComponent();
        }
        dbConnect db = new dbConnect();
        private void FmDichVuKhamBenh_Load(object sender, EventArgs e)
        {
            loaddl();
        }
        private void loaddl()
        {
            gridControl1.DataSource = db.GetData("select * from HSTheoDoiKB");
        }
        public List<DataRow> SelectedTS = new List<DataRow>();
        private void btn_Chon_Click(object sender, EventArgs e)
        {
            try
            {
                SelectedTS.Clear();
                var rows = gridView1.GetSelectedRows();
                for (int i = 0; i < rows.Length; i++)
                {
                    var r = gridView1.GetDataRow(rows[i]);
                    SelectedTS.Add(r);

                }

                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch { }
        }
    }
}