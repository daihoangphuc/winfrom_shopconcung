namespace Form_ShopConCung
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietDonHang")]
    public partial class ChiTietDonHang
    {
        [Key]
        [StringLength(10)]
        public string MaChiTietDonHang { get; set; }

        [StringLength(10)]
        public string MaDonHang { get; set; }

        [StringLength(10)]
        public string MaSanPham { get; set; }

        public int SoLuong { get; set; }

        public int Gia { get; set; }

        public virtual DonHang DonHang { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
