namespace kiemtra.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SinhVien")]
    public partial class SinhVien
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string TenSinhVien { get; set; }

        [Required]
        [StringLength(250)]
        public string DiaChi { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(50)]
        public string SoDienThoai { get; set; }

        public int IDNhom { get; set; }

        public virtual Nhom Nhom { get; set; }
    }
}
