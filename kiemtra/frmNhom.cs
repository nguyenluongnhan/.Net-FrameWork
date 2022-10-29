using kiemtra.Model;
using kiemtra.services;
using kiemtra.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kiemtra
{
    public partial class frmNhom : Form
    {
        NhomViewModel nhom = null;
        public frmNhom()
        {
            InitializeComponent();
        }

        private void btnThemNhom_Click(object sender, EventArgs e)
        {
            if (this.nhom == null)
            {
                var n = new Nhom
                {
                    TenNhom = txtTenNhom.Text
                };
                if (Nhomservices.AddNhom(n) == KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Tên nhóm trùng", "Thông báo");
                    txtTenNhom.Focus();
                }
            }
        }
    }
}

