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
    
    public partial class BarangayCounselor
    {
        public string BarangayCounselorId { get; set; }
        public string ResidentId { get; set; }
        public string CaptainId { get; set; }
    
        public virtual BarangayCaptain BarangayCaptain { get; set; }
        public virtual ResidentsInformation ResidentsInformation { get; set; }
    }
}
