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
    
    public partial class SubjectCombination
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SubjectCombination()
        {
            this.MajorSubjectCombinations = new HashSet<MajorSubjectCombination>();
        }
    
        public int ID { get; set; }
        public int SubjectID1 { get; set; }
        public int SubjectID2 { get; set; }
        public int SubjectID3 { get; set; }
        public bool HasMainSubject { get; set; }
        public string SubjectCombinationName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MajorSubjectCombination> MajorSubjectCombinations { get; set; }
        public virtual Subject Subject { get; set; }
        public virtual Subject Subject1 { get; set; }
        public virtual Subject Subject2 { get; set; }
    }
}