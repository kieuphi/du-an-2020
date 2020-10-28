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
        dbConnect db = new dbConnect();
        private void FmDichVu_Load(object sender, EventArgs e)
        {
   
            loaddl();
        }
        private void loaddl()
        {
            gridControl2.DataSource = db.GetData("select * from DichVu");
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
    }
}