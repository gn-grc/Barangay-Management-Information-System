//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Barangay_Management_Information_System.Models.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class HouseHoldAddress
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HouseHoldAddress()
        {
            this.ResidentsLocations = new HashSet<ResidentsLocation>();
        }
    
        public string AddressId { get; set; }
        public string Address { get; set; }
        public string SiteId { get; set; }
    
        public virtual Site Site { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ResidentsLocation> ResidentsLocations { get; set; }
    }
}
