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
    
    public partial class GIAOVIEN
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GIAOVIEN()
        {
            this.BODEs = new HashSet<BODE>();
            this.GIAOVIEN_DANGKY = new HashSet<GIAOVIEN_DANGKY>();
        }
    
        public string MAGV { get; set; }
        public string HO { get; set; }
        public string TEN { get; set; }
        public string DIACHI { get; set; }
        public string MAKH { get; set; }
        public System.Guid rowguid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BODE> BODEs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GIAOVIEN_DANGKY> GIAOVIEN_DANGKY { get; set; }
        public virtual KHOA KHOA { get; set; }
    }
}
