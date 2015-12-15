//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ES
{
    using System;
    using System.Collections.Generic;
    
    public partial class Candidates
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Candidates()
        {
            this.Marks = new HashSet<Marks>();
            this.Options = new HashSet<Options>();
        }
    
        public int ID { get; set; }
        public string CandidateID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public Nullable<int> RegionID { get; set; }
        public Nullable<int> BeneficiaryID { get; set; }
        public Nullable<int> PrivilegeID { get; set; }
        public byte[] PASSWORD { get; set; }
        public string MajorPass { get; set; }
    
        public virtual Beneficiaries Beneficiaries { get; set; }
        public virtual Privileges Privileges { get; set; }
        public virtual Regions Regions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Marks> Marks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Options> Options { get; set; }
    }
}
