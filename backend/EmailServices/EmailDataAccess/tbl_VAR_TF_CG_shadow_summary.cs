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
    
    public partial class tbl_VAR_TF_CG_shadow_summary
    {
        public long TFCGSeqID { get; set; }
        public Nullable<long> JobID { get; set; }
        public string JOB { get; set; }
        public Nullable<int> JOBTYPE { get; set; }
        public Nullable<int> ProfileID { get; set; }
        public string Profile { get; set; }
        public Nullable<long> TOTAL_COUNT { get; set; }
        public Nullable<long> NOTSTARTED { get; set; }
        public Nullable<long> IN_PROGRESS { get; set; }
        public Nullable<long> COMPLETED { get; set; }
        public Nullable<long> FAILED { get; set; }
        public Nullable<long> POSTPONED { get; set; }
        public string STATUS { get; set; }
        public string POSTPROCESSINGSTATUS { get; set; }
        public string ETA { get; set; }
        public string PERCENT_ { get; set; }
        public string REQUESTEDBY { get; set; }
        public Nullable<long> REQUESTEDID { get; set; }
    }
}
