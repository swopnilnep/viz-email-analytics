//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmailDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_ex_Media
    {
        public long CustodianId { get; set; }
        public long MediaId { get; set; }
        public string MediaName { get; set; }
        public string MediaStatus { get; set; }
        public int ScanStatus { get; set; }
        public string IndexLocation { get; set; }
        public int DrillLevel { get; set; }
        public short parsed { get; set; }
        public short indexed { get; set; }
        public System.DateTime CreatedOn { get; set; }
        public System.DateTime LastUpdateOn { get; set; }
        public bool CustodianDeduped { get; set; }
        public bool LanguageIdentification { get; set; }
        public bool EmailAnalysis { get; set; }
        public bool MediaLocked { get; set; }
        public string CreatedMachineName { get; set; }
        public string ProcessedMachineName { get; set; }
        public string MediaNote { get; set; }
        public bool IsImported { get; set; }
        public bool IsMediaWithExceptionDocument { get; set; }
        public Nullable<long> OriginalMediaIdWithExceptionDocument { get; set; }
        public long CreatedBy { get; set; }
        public int FSID { get; set; }
        public string FileLocation { get; set; }
        public int IFSID { get; set; }
    
        public virtual tbl_ex_Custodian tbl_ex_Custodian { get; set; }
    }
}
