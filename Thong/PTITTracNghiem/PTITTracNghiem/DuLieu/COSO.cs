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
    
    public partial class COSO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public COSO()
        {
            this.KHOAs = new HashSet<KHOA>();
        }
    
        public string MACS { get; set; }
        public string TENCS { get; set; }
        public string DIACHI { get; set; }
        public System.Guid rowguid { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KHOA> KHOAs { get; set; }
    }
}
