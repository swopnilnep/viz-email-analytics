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
    
    public partial class tbl_st_EmailNotificationInfo
    {
        public long Id { get; set; }
        public string NotificationIdentifier { get; set; }
        public long GenericLogId { get; set; }
        public Nullable<System.DateTime> NotifiedDate { get; set; }
        public bool IsSuccess { get; set; }
    }
}
