using kiemtra.Model;
using kiemtra.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kiemtra.services
{
    public class Nhomservices
    {
        public static KetQua AddNhom(Nhom n)
        {
            var db = new AppDBContext();
            
            int count = db.Nhoms.Where(e => e.TenNhom == n.TenNhom).Count();
            if (count > 0)
            {
                return KetQua.TrungTen;
            }
            else
            {
                db.Nhoms.Add(n);
                db.SaveChanges();
                return KetQua.ThanhCong;
            }

        }
        public static KetQua RemoveNhom(NhomViewModel n)
        {
            var db = new AppDBContext();
            var nhom = db.Nhoms.Where(e => e.ID == n.ID).FirstOrDefault();
            foreach(var item in db.SinhViens)
            {
                if(n.ID == item.IDNhom)
                {
                    db.SinhViens.Remove(item);
                }
            }
            db.Nhoms.Remove(nhom);
            db.SaveChanges();
            return KetQua.ThanhCong;
        }
    }
}
