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
    
    public partial class tbl_VAR_TrainingItems
    {
        public long SeqNo { get; set; }
        public Nullable<int> ProfileID { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public Nullable<long> FileID { get; set; }
        public string TrainingItemIDPrefixCode { get; set; }
        public Nullable<int> TrainingSourceID { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string TrainingItemID { get; set; }
    
        public virtual tbl_VAR_CategoryInfo tbl_VAR_CategoryInfo { get; set; }
        public virtual tbl_VAR_CategoryTrainingSources tbl_VAR_CategoryTrainingSources { get; set; }
    }
}
