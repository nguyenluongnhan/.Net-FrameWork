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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            NapDSNhom();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'qLDBDataSet1.SinhVien' table. You can move, or remove it, as needed.
           // this.sinhVienTableAdapter.Fill(this.qLDBDataSet1.SinhVien);
            // TODO: This line of code loads data into the 'qLDBDataSet.Nhom' table. You can move, or remove it, as needed.
          //  this.nhomTableAdapter.Fill(this.qLDBDataSet.Nhom);
        }

        #region Hiển thị danh sách tất cả các nhóm
        void NapDSNhom()
        {
                var list = NhomViewModel.GetList();
                nhomBindingSource.DataSource = list;
                gridViewNhom.DataSource = nhomBindingSource;
        }
        #endregion

        #region SelectedSinhVien
        public SinhVienViewModel selectedSinhVien
        {
            get
            {
                return sinhVienBindingSource.Current as SinhVienViewModel;
            }
        }
        #endregion

        #region selectedNhom
        public NhomViewModel selectedNhom
        {
            get
            {
                return nhomBindingSource.Current as NhomViewModel;
            }
        }
        #endregion

        #region Hiển thị danh sách các liên lạc của nhóm được chọn

        void NapDSSinhVien()
        {
            if (selectedNhom != null)
            {
                var list = SinhVienServices.getByNhom(selectedNhom.ID);
                sinhVienBindingSource.DataSource = list;
                gridViewSinhVien.DataSource = sinhVienBindingSource;
            }
        }
        private void gridViewNhom_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapDSSinhVien();
        }
        #endregion

        #region Hiển thị thông tin chi tiết của liên lạc được chọn

        void NapChiTietSV ()
        {
            if (selectedSinhVien != null)
            {
                lbTenGoi.Text = selectedSinhVien.TenSinhVien;
                lbDiaChi.Text = selectedSinhVien.DiaChi;
                lbEmail.Text = selectedSinhVien.Email;
                lbSoDienThoai.Text = selectedSinhVien.SoDienThoai;
            }
        }

        private void gridViewSinhVien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            NapChiTietSV();
        }
        #endregion

        #region Chức năng thêm, xóa 1 nhóm được chọn

            #region Chức năng thêm nhóm
                private void btnThemNhom_Click(object sender, EventArgs e)
                    {
                        var f = new frmNhom();
                        var rs = f.ShowDialog();
                        if (rs == DialogResult.OK)
                        {
                            NapDSNhom();
                        }
                    }
            #endregion

        #region Chức năng xóa nhóm
        private void btnXoaNhom_Click(object sender, EventArgs e)
        {
            if (selectedNhom != null)
            {
                var rs = MessageBox.Show("Bạn có chắc là muốn xóa nhóm này?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (rs == DialogResult.OK)
                {
                    Nhomservices.RemoveNhom(selectedNhom);
                    NapDSNhom();
                }
            }
        }
        #endregion

        #endregion

        #region Chức năng thêm, xóa 1 liên lạc ra khỏi nhóm được chọn

            #region Chức năng thêm 1 liên lạc
                private void btnThenLienLac_Click(object sender, EventArgs e)
                {
                    var f = new frmSinhVien();
                    var rs = f.ShowDialog();
                    if (rs == DialogResult.OK)
                    {
                        NapDSSinhVien();
                    }
                }
        #endregion

            #region Chức năng xóa 1 liên lạc
                private void btnXoaLienLac_Click(object sender, EventArgs e)
                {
                    if (selectedSinhVien != null)
                    {
                        var rs = MessageBox.Show("Bạn có chắc là muốn xóa liên lạc này?", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        if (rs == DialogResult.OK)
                        {
                            SinhVienServices.RemoveSinhVien(selectedSinhVien);
                            NapDSSinhVien();
                        }
                    }
                }



        #endregion

        #endregion

        #region Tìm kiếm liên lạc
            private void TimKiemS(object sender, EventArgs e)
            {
                var db = new AppDBContext();
                var text = txtTimKiem.Text;
                if (selectedNhom != null)
                {
                    foreach (var item in db.Nhoms)
                    {
                        if (item.ID == selectedNhom.ID)
                        {
                            var results = db.SinhViens.Where(x => x.TenSinhVien.ToLower().Contains(text)).ToList();
                            gridViewSinhVien.DataSource = results;
                        }
                    }
                }
            }
        #endregion
    }
}
