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
    
    public partial class tbl_fd_FolderActionLog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_fd_FolderActionLog()
        {
            this.tbl_fd_folderHistory = new HashSet<tbl_fd_folderHistory>();
        }
    
        public long ActionID { get; set; }
        public string ActionType { get; set; }
        public string ActionDescription { get; set; }
        public long Action_By { get; set; }
        public System.DateTime Action_DateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_fd_folderHistory> tbl_fd_folderHistory { get; set; }
    }
}
