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
    
    public partial class tbl_pj_DateRestriction
    {
        public int DateRestrictionID { get; set; }
        public string DateField { get; set; }
        public string DocumentType { get; set; }
        public string DateRestrictionOperator { get; set; }
        public System.DateTime DateRestrictionFrom { get; set; }
        public Nullable<System.DateTime> DateRestrictionTo { get; set; }
        public System.DateTime DateRestrictionFromGMT { get; set; }
        public Nullable<System.DateTime> DateRestrictionToGMT { get; set; }
    }
}
