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
    
    public partial class tbl_ex_ConvertedDXLFileLocation
    {
        public long CustodianID { get; set; }
        public long MediaID { get; set; }
        public long FileID { get; set; }
        public string NSFFileLocation { get; set; }
        public string DXLFileLocation { get; set; }
        public Nullable<long> FileSize { get; set; }
        public string Unid { get; set; }
        public bool IsMimeExtracted { get; set; }
        public string DXLFileLocationWithMimeData { get; set; }
    }
}
