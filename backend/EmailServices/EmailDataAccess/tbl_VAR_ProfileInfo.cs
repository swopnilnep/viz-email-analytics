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
    
    public partial class tbl_VAR_ProfileInfo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_VAR_ProfileInfo()
        {
            this.tbl_VAR_CategoryInfo = new HashSet<tbl_VAR_CategoryInfo>();
            this.tbl_VAR_JobInitiatedStatus = new HashSet<tbl_VAR_JobInitiatedStatus>();
            this.tbl_VAR_PredictionResult = new HashSet<tbl_VAR_PredictionResult>();
            this.tbl_VAR_ProfileReviewSetAssociation = new HashSet<tbl_VAR_ProfileReviewSetAssociation>();
            this.tbl_VAR_ProfileReviewSetLog = new HashSet<tbl_VAR_ProfileReviewSetLog>();
        }
    
        public int ProfileID { get; set; }
        public string ProfileName { get; set; }
        public string ActualProfileName { get; set; }
        public string Purpose { get; set; }
        public Nullable<long> TagGroupID { get; set; }
        public Nullable<long> PredictedBelowThresholdTagId { get; set; }
        public string ProfileFolder { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedOn { get; set; }
        public Nullable<int> LastUpdatedBy { get; set; }
        public Nullable<System.DateTime> LastUpdatedOn { get; set; }
        public Nullable<int> TrainingRecallThreshold { get; set; }
        public Nullable<int> CategoryConfidenceThreshold { get; set; }
        public Nullable<int> PredictionAccuracyThreshold { get; set; }
        public Nullable<bool> SkipStopWords { get; set; }
        public string StopWordFile { get; set; }
        public Nullable<bool> StemWords { get; set; }
        public Nullable<bool> UseEnglishStemmer { get; set; }
        public Nullable<bool> SkipNumber { get; set; }
        public Nullable<bool> SkipStartNumber { get; set; }
        public Nullable<int> MinCharThreashold { get; set; }
        public Nullable<int> MaxCharThreashold { get; set; }
        public Nullable<bool> SkipWordLessThanDocCount { get; set; }
        public Nullable<int> MinWordThreshold { get; set; }
        public Nullable<bool> SkipWordMoreThanDocCount { get; set; }
        public Nullable<int> MaxWordThreshold { get; set; }
        public Nullable<int> MinC { get; set; }
        public Nullable<int> MaxC { get; set; }
        public Nullable<int> CStep { get; set; }
        public Nullable<int> MinG { get; set; }
        public Nullable<int> MaxG { get; set; }
        public Nullable<int> GStep { get; set; }
        public byte[] StopWordFileByte { get; set; }
        public bool ExcludeTrainingItemsOnPrediction { get; set; }
        public bool isLocked { get; set; }
        public Nullable<long> ExcludeDocumentTextSizeThresholdInKB { get; set; }
        public string RetrainReason { get; set; }
        public Nullable<long> ProfileSettingTemplateId { get; set; }
        public Nullable<long> NotAGoodExampleTagId { get; set; }
        public Nullable<long> ControlSetFlagTagID { get; set; }
        public int FSID { get; set; }
        public Nullable<bool> IsCalProfile { get; set; }
        public Nullable<long> CalControlSetDocCount { get; set; }
        public Nullable<decimal> BatchRichnessThreshold { get; set; }
        public Nullable<decimal> ReviewRelevanceThreshold { get; set; }
        public Nullable<long> PotentiallyNonRelevantFlagTagId { get; set; }
        public Nullable<bool> IsDynamicControlSet { get; set; }
        public Nullable<decimal> ControlSetPercentFromTrainingBatch { get; set; }
        public Nullable<long> CalControlSetMinDocCount { get; set; }
        public Nullable<long> CalControlSetMaxDocCount { get; set; }
        public Nullable<bool> IsDiscontinueDynamicControlSet { get; set; }
        public Nullable<long> CalTrainingSetMinDocCount { get; set; }
        public Nullable<long> CalTrainingSetMaxDocCount { get; set; }
        public Nullable<bool> IsRecomputeTFOnRetraining { get; set; }
        public Nullable<bool> IsBalanceSeed { get; set; }
        public string BalanceSeedMode { get; set; }
        public bool RepredictPastErroredFiles { get; set; }
        public bool ShowReviewStatistics { get; set; }
        public Nullable<double> ConfidenceInterval { get; set; }
        public Nullable<double> ConfidenceLevel { get; set; }
        public Nullable<long> ControlSetSizeDerivedBy { get; set; }
        public Nullable<double> PercentageOfPopulation { get; set; }
        public Nullable<long> NumberOfDocument { get; set; }
        public bool IsMoreDocsAdded { get; set; }
    
        public virtual tbl_ex_tag tbl_ex_tag { get; set; }
        public virtual Tbl_tg_TagGroup Tbl_tg_TagGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_VAR_CategoryInfo> tbl_VAR_CategoryInfo { get; set; }
        public virtual tbl_VAR_DF_Files tbl_VAR_DF_Files { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_VAR_JobInitiatedStatus> tbl_VAR_JobInitiatedStatus { get; set; }
        public virtual tbl_VAR_Model_Files tbl_VAR_Model_Files { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_VAR_PredictionResult> tbl_VAR_PredictionResult { get; set; }
        public virtual tbl_VAR_Problem_Files tbl_VAR_Problem_Files { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_VAR_ProfileReviewSetAssociation> tbl_VAR_ProfileReviewSetAssociation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_VAR_ProfileReviewSetLog> tbl_VAR_ProfileReviewSetLog { get; set; }
        public virtual tbl_VAR_TF_Files tbl_VAR_TF_Files { get; set; }
    }
}
