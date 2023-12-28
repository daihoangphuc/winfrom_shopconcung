namespace Form_ShopConCung
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("TaiKhoan")]
    public partial class TaiKhoan
    {
        [Key]
        [StringLength(10)]
        public string idtaikhoan { get; set; }

        [Column("taikhoan")]
        [StringLength(20)]
        public string taikhoan1 { get; set; }

        [StringLength(10)]
        public string matkhau { get; set; }

        public int? quyen { get; set; }

        [StringLength(10)]
        public string MaNhanVien { get; set; }

        [StringLength(10)]
        public string MaKhachHang { get; set; }

        public virtual KhachHang KhachHang { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
