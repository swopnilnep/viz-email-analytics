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
    
    public partial class tbl_jb_ocrGeneratedTiff
    {
        public long JobId { get; set; }
        public long FileId { get; set; }
        public Nullable<int> Status { get; set; }
        public string ProcessingInstanceID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<long> RetryCount { get; set; }
        public string PageNumberList { get; set; }
        public string LanguageSelected { get; set; }
    }
}
