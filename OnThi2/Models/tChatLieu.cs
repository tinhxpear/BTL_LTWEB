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
    
    public partial class tChatLieu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tChatLieu()
        {
            this.tDanhMucSPs = new HashSet<tDanhMucSP>();
        }
    
        public string MaChatLieu { get; set; }
        public string ChatLieu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tDanhMucSP> tDanhMucSPs { get; set; }
    }
}
