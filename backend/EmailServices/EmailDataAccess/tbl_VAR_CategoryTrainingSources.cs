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
    
    public partial class tbl_VAR_CategoryTrainingSources
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_VAR_CategoryTrainingSources()
        {
            this.tbl_VAR_TrainingItems = new HashSet<tbl_VAR_TrainingItems>();
        }
    
        public int TrainingSourceID { get; set; }
        public int CategoryID { get; set; }
        public Nullable<int> ProfileID { get; set; }
        public Nullable<int> TrainingSourceTypeID { get; set; }
        public Nullable<int> ManualTagID { get; set; }
        public string LoadFilePath { get; set; }
        public string TagExpression { get; set; }
        public string SampleID { get; set; }
        public string FolderExpression { get; set; }
        public Nullable<int> SavedSearchId { get; set; }
    
        public virtual tbl_VAR_TrainingSourceInfo tbl_VAR_TrainingSourceInfo { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_VAR_TrainingItems> tbl_VAR_TrainingItems { get; set; }
    }
}
