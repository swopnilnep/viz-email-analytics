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
    
    public partial class tbl_imp_ImportLog
    {
        public long LogId { get; set; }
        public Nullable<long> ImportId { get; set; }
        public Nullable<long> UserId { get; set; }
        public string OperationType { get; set; }
        public Nullable<long> LineNumber { get; set; }
        public string LogType { get; set; }
        public string LogMessage { get; set; }
        public string LogRemark { get; set; }
        public string LogDetail { get; set; }
        public string AdditionalData { get; set; }
        public string Application { get; set; }
        public string AppHostMachine { get; set; }
        public System.DateTime LogDateTime { get; set; }
    }
}