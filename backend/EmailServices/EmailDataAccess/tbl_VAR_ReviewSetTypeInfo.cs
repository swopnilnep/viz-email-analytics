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
    
    public partial class tbl_VAR_ReviewSetTypeInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_VAR_ReviewSetTypeInfo()
        {
            this.tbl_VAR_ProfileReviewSetAssociation = new HashSet<tbl_VAR_ProfileReviewSetAssociation>();
        }
    
        public int ReviewSetTypeID { get; set; }
        public string ReviewSetType { get; set; }
        public string Description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_VAR_ProfileReviewSetAssociation> tbl_VAR_ProfileReviewSetAssociation { get; set; }
    }
}
