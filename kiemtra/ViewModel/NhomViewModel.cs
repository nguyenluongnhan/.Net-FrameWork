using kiemtra.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtra.ViewModel
{
    public enum KetQua
    {
        TrungTen,
        ThanhCong
    }
    public class NhomViewModel
    {
        public int ID { get; set; }
        public string TenNhom { get; set; }
        public static List<NhomViewModel> GetList()
        {
            var db = new AppDBContext();
            var rs = db.Nhoms.Select(e => new NhomViewModel
            {
                ID = e.ID,
                TenNhom = e.TenNhom
            }).ToList();
            return rs;
        }
    }
}
