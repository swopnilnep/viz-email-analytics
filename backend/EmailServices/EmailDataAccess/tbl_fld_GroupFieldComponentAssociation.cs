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
    
    public partial class tbl_fld_GroupFieldComponentAssociation
    {
        public long FieldId { get; set; }
        public long UserGroupId { get; set; }
        public Nullable<bool> IsCustomField { get; set; }
        public int FieldDisplayOrder { get; set; }
        public string Component { get; set; }
    }
}
