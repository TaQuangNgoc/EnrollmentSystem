//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EnrollmentSystem
{
    using System;
    using System.Collections.Generic;
    
    public partial class Candidate
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Candidate()
        {
            this.Marks = new HashSet<Mark>();
            this.Options = new HashSet<Option>();
        }
    
        public int ID { get; set; }
        public string CandidateID { get; set; }
        public string Name { get; set; }
        public System.DateTime DateOfBirth { get; set; }
        public Nullable<int> RegionID { get; set; }
        public Nullable<int> BeneficiaryID { get; set; }
        public bool HasPrivilege { get; set; }
        public byte[] Password { get; set; }
        public Nullable<int> AdmittingMajorID { get; set; }
    
        public virtual Beneficiary Beneficiary { get; set; }
        public virtual Major Major { get; set; }
        public virtual Region Region { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Mark> Marks { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Option> Options { get; set; }
    }
}
