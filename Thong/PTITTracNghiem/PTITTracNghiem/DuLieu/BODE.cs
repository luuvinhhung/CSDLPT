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
    
    public partial class BODE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BODE()
        {
            this.CT_BAITHI = new HashSet<CT_BAITHI>();
        }
    
        public int CAUHOI { get; set; }
        public string MAMH { get; set; }
        public string TRINHDO { get; set; }
        public string NOIDUNG { get; set; }
        public string A { get; set; }
        public string B { get; set; }
        public string C { get; set; }
        public string D { get; set; }
        public string DAP_AN { get; set; }
        public string MAGV { get; set; }
        public System.Guid rowguid { get; set; }
    
        public virtual GIAOVIEN GIAOVIEN { get; set; }
        public virtual MONHOC MONHOC { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CT_BAITHI> CT_BAITHI { get; set; }
    }
}
