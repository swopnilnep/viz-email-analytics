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
    
    public partial class Tbl_Ep_PdfDetails
    {
        public long ExportId { get; set; }
        public long FileId { get; set; }
        public long GroupId { get; set; }
        public string PdfPath { get; set; }
        public Nullable<long> PdfSize { get; set; }
        public int Status { get; set; }
        public string ProcessingInstanceId { get; set; }
        public Nullable<int> RetryCount { get; set; }
    }
}