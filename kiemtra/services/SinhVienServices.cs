using kiemtra.Model;
using kiemtra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtra.services
{
    internal class SinhVienServices
    {
        public static List<SinhVienViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.SinhViens.Select(e => new SinhVienViewModel
            {
                ID = e.ID,
                TenSinhVien = e.TenSinhVien,
                DiaChi = e.DiaChi,
                Email = e.Email,
                SoDienThoai = e.SoDienThoai,
                IDNhom = e.IDNhom,
            }).ToList();
            return rs;
        }
        
        public static List<SinhVienViewModel> getByNhom(int IDNhomm)
        {
            var list = GetList();
            var rs = list.Where(t => t.IDNhom == IDNhomm).ToList();
            return rs;
        }
       
        public static KetQua AddSinhVien(SinhVien sv)
        {
            var db = new AppDBContext();
            db.SinhViens.Add(sv);
            db.SaveChanges();
            return KetQua.ThanhCong;
            
        }
        public static KetQua RemoveSinhVien(SinhVienViewModel sv)
        {
            var db = new AppDBContext();
            var sinhVien = db.SinhViens.Where(e => e.ID == sv.ID).FirstOrDefault();
            db.SinhViens.Remove(sinhVien);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
    }
}

