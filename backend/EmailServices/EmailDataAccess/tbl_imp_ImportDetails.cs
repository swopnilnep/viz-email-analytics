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
    
    public partial class tbl_imp_ImportDetails
    {
        public long ImportID { get; set; }
        public Nullable<long> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public string ImportOptions { get; set; }
        public string FieldMappingDetails { get; set; }
        public string importmachine { get; set; }
        public string loadfilepath { get; set; }
        public bool IsOverlay { get; set; }
        public string ImportLogFolder { get; set; }
        public string ImageLoadFilePath { get; set; }
    
        public virtual tbl_jb_ImportProgress tbl_jb_ImportProgress { get; set; }
    }
}
