//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OnThi2.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tDanhMucSP
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tDanhMucSP()
        {
            this.tAnhSPs = new HashSet<tAnhSP>();
        }
    
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public string MaChatLieu { get; set; }
        public string NganLapTop { get; set; }
        public string Model { get; set; }
        public string MauSac { get; set; }
        public string MaKichThuoc { get; set; }
        public Nullable<double> CanNang { get; set; }
        public Nullable<double> DoNoi { get; set; }
        public string MaHangSX { get; set; }
        public string MaNuocSX { get; set; }
        public string MaDacTinh { get; set; }
        public string Website { get; set; }
        public Nullable<double> ThoiGianBaoHanh { get; set; }
        public string GioiThieuSP { get; set; }
        public Nullable<double> Gia { get; set; }
        public Nullable<double> ChietKhau { get; set; }
        public string MaLoai { get; set; }
        public string MaDT { get; set; }
        public string Anh { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tAnhSP> tAnhSPs { get; set; }
        public virtual tChatLieu tChatLieu { get; set; }
        public virtual tHangSX tHangSX { get; set; }
        public virtual tKichThuoc tKichThuoc { get; set; }
        public virtual tLoaiDT tLoaiDT { get; set; }
        public virtual tLoaiSP tLoaiSP { get; set; }
        public virtual tQuocGia tQuocGia { get; set; }
    }
}
