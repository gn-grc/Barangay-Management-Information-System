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
    using System.ComponentModel.DataAnnotations;

    public partial class Summon
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Summon()
        {
            this.SummonInvolvedResidents = new HashSet<SummonInvolvedResident>();
        }
    
        public string SummonId { get; set; }
        public string ReportDescription { get; set; }

        [DataType(DataType.Date)]
        public System.DateTime IncidentDate { get; set; }
        public System.DateTime DateReported { get; set; }
        public string SummonStatusId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SummonInvolvedResident> SummonInvolvedResidents { get; set; }
        public virtual SummonStatu SummonStatu { get; set; }
    }
}
