//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PTITTracNghiem.DuLieu
{
    using System;
    using System.Collections.Generic;
    
    public partial class BANGDIEM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BANGDIEM()
        {
            this.CT_BAITHI = new HashSet<CT_BAITHI>();
        }
    
        public string MASV { get; set; }
        public string MAMH { get; set; }
        public short LAN { get; set; }
        public Nullable<System.DateTime> NGAYTHI { get; set; }
        public Nullable<double> DIEM { get; set; }
        public System.Guid rowguid { get; set; }
    
        public virtual MONHOC MONHOC { get; set; }
        public virtual SINHVIEN SINHVIEN { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_BAITHI> CT_BAITHI { get; set; }
    }
}