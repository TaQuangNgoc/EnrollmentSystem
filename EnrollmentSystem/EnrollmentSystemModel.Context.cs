﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Beneficiary> Beneficiaries { get; set; }
        public virtual DbSet<Candidate> Candidates { get; set; }
        public virtual DbSet<Major> Majors { get; set; }
        public virtual DbSet<MajorSubjectCombination> MajorSubjectCombinations { get; set; }
        public virtual DbSet<Mark> Marks { get; set; }
        public virtual DbSet<Option> Options { get; set; }
        public virtual DbSet<Region> Regions { get; set; }
        public virtual DbSet<SubjectCombination> SubjectCombinations { get; set; }
        public virtual DbSet<Subject> Subjects { get; set; }
        public virtual DbSet<MajorSujectCombinationsView> MajorSujectCombinationsViews { get; set; }
        public virtual DbSet<ReportView> ReportViews { get; set; }
    
        public virtual int ProcedureInsertCandidate(string candidateID, string name, Nullable<System.DateTime> dateOfBirth, Nullable<int> regionID, Nullable<int> benificiaryID, Nullable<bool> hasPrivilege)
        {
            var candidateIDParameter = candidateID != null ?
                new ObjectParameter("CandidateID", candidateID) :
                new ObjectParameter("CandidateID", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var dateOfBirthParameter = dateOfBirth.HasValue ?
                new ObjectParameter("DateOfBirth", dateOfBirth) :
                new ObjectParameter("DateOfBirth", typeof(System.DateTime));
    
            var regionIDParameter = regionID.HasValue ?
                new ObjectParameter("RegionID", regionID) :
                new ObjectParameter("RegionID", typeof(int));
    
            var benificiaryIDParameter = benificiaryID.HasValue ?
                new ObjectParameter("BenificiaryID", benificiaryID) :
                new ObjectParameter("BenificiaryID", typeof(int));
    
            var hasPrivilegeParameter = hasPrivilege.HasValue ?
                new ObjectParameter("HasPrivilege", hasPrivilege) :
                new ObjectParameter("HasPrivilege", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProcedureInsertCandidate", candidateIDParameter, nameParameter, dateOfBirthParameter, regionIDParameter, benificiaryIDParameter, hasPrivilegeParameter);
        }
    
        public virtual int ProcedureInsertMark(Nullable<int> candidateID, Nullable<decimal> markToan, Nullable<decimal> markVan, Nullable<decimal> markLy, Nullable<decimal> markHoa, Nullable<decimal> markSinh, Nullable<decimal> markSu, Nullable<decimal> markDia, Nullable<decimal> markAnh, Nullable<decimal> markNga, Nullable<decimal> markPhap, Nullable<decimal> markTrung, Nullable<decimal> markDuc, Nullable<decimal> markNhat)
        {
            var candidateIDParameter = candidateID.HasValue ?
                new ObjectParameter("CandidateID", candidateID) :
                new ObjectParameter("CandidateID", typeof(int));
    
            var markToanParameter = markToan.HasValue ?
                new ObjectParameter("MarkToan", markToan) :
                new ObjectParameter("MarkToan", typeof(decimal));
    
            var markVanParameter = markVan.HasValue ?
                new ObjectParameter("MarkVan", markVan) :
                new ObjectParameter("MarkVan", typeof(decimal));
    
            var markLyParameter = markLy.HasValue ?
                new ObjectParameter("MarkLy", markLy) :
                new ObjectParameter("MarkLy", typeof(decimal));
    
            var markHoaParameter = markHoa.HasValue ?
                new ObjectParameter("MarkHoa", markHoa) :
                new ObjectParameter("MarkHoa", typeof(decimal));
    
            var markSinhParameter = markSinh.HasValue ?
                new ObjectParameter("MarkSinh", markSinh) :
                new ObjectParameter("MarkSinh", typeof(decimal));
    
            var markSuParameter = markSu.HasValue ?
                new ObjectParameter("MarkSu", markSu) :
                new ObjectParameter("MarkSu", typeof(decimal));
    
            var markDiaParameter = markDia.HasValue ?
                new ObjectParameter("MarkDia", markDia) :
                new ObjectParameter("MarkDia", typeof(decimal));
    
            var markAnhParameter = markAnh.HasValue ?
                new ObjectParameter("MarkAnh", markAnh) :
                new ObjectParameter("MarkAnh", typeof(decimal));
    
            var markNgaParameter = markNga.HasValue ?
                new ObjectParameter("MarkNga", markNga) :
                new ObjectParameter("MarkNga", typeof(decimal));
    
            var markPhapParameter = markPhap.HasValue ?
                new ObjectParameter("MarkPhap", markPhap) :
                new ObjectParameter("MarkPhap", typeof(decimal));
    
            var markTrungParameter = markTrung.HasValue ?
                new ObjectParameter("MarkTrung", markTrung) :
                new ObjectParameter("MarkTrung", typeof(decimal));
    
            var markDucParameter = markDuc.HasValue ?
                new ObjectParameter("MarkDuc", markDuc) :
                new ObjectParameter("MarkDuc", typeof(decimal));
    
            var markNhatParameter = markNhat.HasValue ?
                new ObjectParameter("MarkNhat", markNhat) :
                new ObjectParameter("MarkNhat", typeof(decimal));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ProcedureInsertMark", candidateIDParameter, markToanParameter, markVanParameter, markLyParameter, markHoaParameter, markSinhParameter, markSuParameter, markDiaParameter, markAnhParameter, markNgaParameter, markPhapParameter, markTrungParameter, markDucParameter, markNhatParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int TruncateEverything()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("TruncateEverything");
        }
    }
}