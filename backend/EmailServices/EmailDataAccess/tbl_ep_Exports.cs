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
    
    public partial class tbl_ep_Exports
    {
        public long ExportID { get; set; }
        public string ExportName { get; set; }
        public string ExportBase { get; set; }
        public string ExportOptions { get; set; }
        public Nullable<System.DateTime> ExportStartDate { get; set; }
        public Nullable<System.DateTime> ExportEndDate { get; set; }
        public string FolderPrefix { get; set; }
        public Nullable<long> FolderStartNumber { get; set; }
        public Nullable<long> FolderEndNumber { get; set; }
        public Nullable<byte> FolderPadding { get; set; }
        public string FilePrefix { get; set; }
        public Nullable<long> FileStartNumber { get; set; }
        public Nullable<long> FileEndNumber { get; set; }
        public Nullable<byte> FilePadding { get; set; }
        public string MediaList { get; set; }
        public Nullable<long> ExportedBy { get; set; }
        public Nullable<bool> IsReExport { get; set; }
        public Nullable<long> OriginalExportId { get; set; }
        public string ImageFilePrefix { get; set; }
        public Nullable<long> ImageFileStartNumber { get; set; }
        public Nullable<long> ImageFileEndNumber { get; set; }
        public Nullable<byte> ImageFilePadding { get; set; }
        public Nullable<bool> IsTiffPreserved { get; set; }
        public Nullable<System.DateTime> ExportCreatedDate { get; set; }
        public Nullable<long> ExportCreatedBy { get; set; }
        public string ProcessingMachineName { get; set; }
        public Nullable<long> TotalFileCount { get; set; }
        public Nullable<long> TotalTiffPageCount { get; set; }
        public bool CompressedExportedFilesFlag { get; set; }
        public string CompressedFileLocation { get; set; }
        public bool ExportedFromVoD { get; set; }
        public Nullable<long> CompressedFileSize { get; set; }
    }
}