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
    public partial class frmSinhVien : Form
    {
        SinhVienViewModel sinhVien = null;
        public frmSinhVien()
        {
            InitializeComponent();
            NapDsNhom();
        }
        void NapDsNhom()
        {
            var ls = NhomViewModel.GetList();
            cbbTenNhom.DataSource = ls;
            cbbTenNhom.ValueMember = "ID";
            cbbTenNhom.DisplayMember = "TenNhom";
        }
        public NhomViewModel selectedNhom
        {
            get
            {
                return cbbTenNhom.SelectedItem as NhomViewModel;
            }
        }
        private void btnDongY_Click(object sender, EventArgs e)
        {
            if (this.sinhVien == null)
            {
                var sv = new SinhVien
                {
                    TenSinhVien = txtTenGoi.Text,
                    DiaChi = txtDiaChi1.Text,
                    Email = txtEmail1.Text,
                    SoDienThoai = txtSoDienThoai1.Text,
                    IDNhom = selectedNhom.ID,
                };
                if (SinhVienServices.AddSinhVien(sv) == KetQua.ThanhCong)
                {
                    DialogResult = DialogResult.OK;
                }
            }
        }
    }
}
