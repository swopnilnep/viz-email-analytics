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
    
    public partial class tbl_ex_ModuleLogin
    {
        public long ModuleLoginID { get; set; }
        public long UserID { get; set; }
        public Nullable<System.DateTime> LoginDateTime { get; set; }
        public Nullable<System.DateTime> LogoutDateTime { get; set; }
        public Nullable<System.DateTime> EstLogoutDateTime { get; set; }
        public Nullable<long> ReviewSetID { get; set; }
        public long ProjectLoginID { get; set; }
        public string Module { get; set; }
    }
}
