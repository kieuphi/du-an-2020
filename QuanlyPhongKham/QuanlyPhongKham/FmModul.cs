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

namespace QuanlyPhongKham
{
    public partial class FmModul : DevExpress.XtraEditors.XtraForm
    {
        public FmModul()
        {
            InitializeComponent();
        }

        private void FmModul_Load(object sender, EventArgs e)
        {
            labelControl3.Text = DateTime.Now.ToString("dd/MM/yyyy");
            Login f = new Login();
            f.Show();
        }

        private void labelControl4_SizeChanged(object sender, EventArgs e)
        {
          
        }

        private void tlt_KhamBenh_ItemClick(object sender, TileItemEventArgs e)
        {
            FmMain f = new FmMain();
            //f.WindowState = FormWindowState.Maximized;
            f.Show();
        }
    }
}