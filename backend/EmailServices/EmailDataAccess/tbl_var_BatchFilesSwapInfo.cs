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
    
    public partial class tbl_var_BatchFilesSwapInfo
    {
        public long Id { get; set; }
        public Nullable<long> ProfileId { get; set; }
        public Nullable<long> PredictionJobId { get; set; }
        public Nullable<long> BatchId { get; set; }
        public Nullable<int> FileSwapTimes { get; set; }
        public Nullable<long> NoOfCSDocs { get; set; }
        public Nullable<long> RequiredRespDocCountForSwap { get; set; }
        public Nullable<long> NoOfInherientRespDocs { get; set; }
        public Nullable<long> NoOfDocsDeletedFromThisBatch { get; set; }
        public Nullable<long> NoOfDocsDeletedFromOtherBatch { get; set; }
        public Nullable<long> NoOfDocsAddedToThisBatchOnSwap { get; set; }
        public Nullable<long> NoOfDocsAddedToOtherBatchOnSwap { get; set; }
        public Nullable<System.DateTime> DateOfEntry { get; set; }
        public Nullable<decimal> PredictionAccuracyThreshold { get; set; }
    }
}
