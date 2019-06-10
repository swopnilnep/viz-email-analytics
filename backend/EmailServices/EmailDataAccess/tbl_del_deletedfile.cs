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
    
    public partial class tbl_del_deletedfile
    {
        public long BatchId { get; set; }
        public long FileId { get; set; }
        public string FileName { get; set; }
        public string AbsoluteFilePath { get; set; }
        public string RelativeFilePath { get; set; }
        public Nullable<long> GroupId { get; set; }
        public Nullable<bool> IsParent { get; set; }
        public string HashValue { get; set; }
        public Nullable<bool> IsDuplicate { get; set; }
        public Nullable<bool> IsDuplicateCustodianLevel { get; set; }
        public Nullable<long> OriginalGroupId { get; set; }
        public string AccessPath { get; set; }
        public string LogicalPath { get; set; }
        public Nullable<long> FileSize { get; set; }
        public string FileType { get; set; }
        public Nullable<bool> IsArchive { get; set; }
        public Nullable<bool> IsSystem { get; set; }
        public Nullable<bool> IsEdocs { get; set; }
        public Nullable<bool> IsEmail { get; set; }
        public Nullable<bool> IsAttachment { get; set; }
        public Nullable<bool> IsEmbedded { get; set; }
        public string ParentDocType { get; set; }
        public string Extension { get; set; }
        public Nullable<bool> IsPasswordprotected { get; set; }
        public Nullable<bool> IsCorrupted { get; set; }
        public Nullable<bool> IsNonProcessed { get; set; }
        public Nullable<bool> IsDedupProcessed { get; set; }
        public Nullable<bool> IsIndexed { get; set; }
        public Nullable<bool> isDeNIST { get; set; }
        public Nullable<System.DateTime> GroupDate { get; set; }
        public Nullable<long> ParentFileID { get; set; }
        public Nullable<long> ElaspedTime { get; set; }
        public bool HasHiddenObject { get; set; }
        public string OriginalFilePath { get; set; }
        public Nullable<System.DateTime> FSLastAccessDateTime { get; set; }
        public Nullable<System.DateTime> FSCreatedDateTime { get; set; }
        public Nullable<System.DateTime> FSModifiedDateTime { get; set; }
        public string OriginalFileExtension { get; set; }
        public bool IsNoText { get; set; }
        public string OriginalAccessPath { get; set; }
        public Nullable<long> ChildCount { get; set; }
        public bool IsDeleted { get; set; }
        public Nullable<long> ImportID { get; set; }
        public Nullable<System.DateTime> FSLastAccessDateTimeGMT { get; set; }
        public Nullable<System.DateTime> FSCreatedDateTimeGMT { get; set; }
        public Nullable<System.DateTime> FSModifiedDateTimeGMT { get; set; }
        public Nullable<System.DateTime> GroupDateGMT { get; set; }
        public Nullable<long> ScanFileId { get; set; }
        public bool IsUnknownFile { get; set; }
        public bool IsUnSupportedFiletype { get; set; }
        public bool IsProcessingError { get; set; }
        public Nullable<bool> IsZeroByte { get; set; }
        public string RelativeIndexPathForQC { get; set; }
        public bool IsPasswordDecrypted { get; set; }
        public bool IsPasswordDecryptionSupported { get; set; }
        public string ControlNumber { get; set; }
        public string ExportID { get; set; }
        public string HashValueSecondary { get; set; }
        public Nullable<bool> IsWriteProtected { get; set; }
        public string GroupHashValue { get; set; }
        public bool MetaDataExtractionSAFEerror { get; set; }
    }
}