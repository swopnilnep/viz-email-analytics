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
    
    public partial class tbl_jb_ImportProgress
    {
        public long ImportId { get; set; }
        public System.DateTime ProgressLogTime { get; set; }
        public decimal ExtractionProgress { get; set; }
        public decimal AnalysisProgress { get; set; }
        public string AnalysisProgressRemark { get; set; }
        public long ValidationLineNumber { get; set; }
        public string ValidationRemark { get; set; }
        public long ImportLineNumber { get; set; }
        public decimal ImportProgress { get; set; }
        public string ImportProgressRemark { get; set; }
        public int QueueEmailAnalysisStatus { get; set; }
        public int DuplicateMediaSummaryStatus { get; set; }
        public int QueueLanguageIdentificationStatus { get; set; }
        public int QueueIndexingStatus { get; set; }
        public string QueueEmailAnalysisRemark { get; set; }
        public string DuplicateMediaSummaryRemark { get; set; }
        public string QueueLanguageIdentificationRemark { get; set; }
        public string QueueIndexingRemark { get; set; }
        public string ErrorMessage { get; set; }
        public string ErrorDetail { get; set; }
        public decimal ValidationProgress { get; set; }
    
        public virtual tbl_imp_ImportDetails tbl_imp_ImportDetails { get; set; }
    }
}