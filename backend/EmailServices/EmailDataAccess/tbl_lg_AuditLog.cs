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
    
    public partial class tbl_lg_AuditLog
    {
        public long AuditLogId { get; set; }
        public string Application { get; set; }
        public string Module { get; set; }
        public string OperationType { get; set; }
        public string DisplayLog { get; set; }
        public string OldValue { get; set; }
        public string CurrentValue { get; set; }
        public string OtherDetails { get; set; }
        public Nullable<long> UserId { get; set; }
        public System.DateTime AuditLogCreatedOn { get; set; }
    }
}
