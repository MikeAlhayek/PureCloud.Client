using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeImportJobResponse
/// </summary>

public partial class KnowledgeImportJobResponse : IEquatable<KnowledgeImportJobResponse>
{
    /// <summary>
    /// File type of the document
    /// </summary>
    /// <value>File type of the document</value>
    
    public enum FileTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Json for "Json"
        /// </summary>
        [EnumMember(Value = "Json")]
        Json,

        /// <summary>
        /// Enum Csv for "Csv"
        /// </summary>
        [EnumMember(Value = "Csv")]
        Csv,

        /// <summary>
        /// Enum Xlsx for "Xlsx"
        /// </summary>
        [EnumMember(Value = "Xlsx")]
        Xlsx
    }
    /// <summary>
    /// Status of the import job
    /// </summary>
    /// <value>Status of the import job</value>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Created for "Created"
        /// </summary>
        [EnumMember(Value = "Created")]
        Created,

        /// <summary>
        /// Enum Validationinprogress for "ValidationInProgress"
        /// </summary>
        [EnumMember(Value = "ValidationInProgress")]
        Validationinprogress,

        /// <summary>
        /// Enum Validationcompleted for "ValidationCompleted"
        /// </summary>
        [EnumMember(Value = "ValidationCompleted")]
        Validationcompleted,

        /// <summary>
        /// Enum Validationfailed for "ValidationFailed"
        /// </summary>
        [EnumMember(Value = "ValidationFailed")]
        Validationfailed,

        /// <summary>
        /// Enum Started for "Started"
        /// </summary>
        [EnumMember(Value = "Started")]
        Started,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Partialcompleted for "PartialCompleted"
        /// </summary>
        [EnumMember(Value = "PartialCompleted")]
        Partialcompleted,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Abortrequested for "AbortRequested"
        /// </summary>
        [EnumMember(Value = "AbortRequested")]
        Abortrequested,

        /// <summary>
        /// Enum Aborted for "Aborted"
        /// </summary>
        [EnumMember(Value = "Aborted")]
        Aborted
    }
    /// <summary>
    /// File type of the document
    /// </summary>
    /// <value>File type of the document</value>
    [JsonPropertyName("fileType")]
    public FileTypeEnum? FileType { get; set; }
    /// <summary>
    /// Status of the import job
    /// </summary>
    /// <value>Status of the import job</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeImportJobResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeImportJobResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeImportJobResponse" /> class.
    /// </summary>
    /// <param name="DownloadURL">The URL of the location at which the caller can download the imported file..</param>
    /// <param name="FailedEntitiesURL">The URL of the location at which the caller can download the entities in json format that failed during the import..</param>
    /// <param name="UploadKey">Upload key (required).</param>
    /// <param name="FileType">File type of the document (required).</param>
    /// <param name="Settings">Additional optional settings.</param>
    /// <param name="SkipConfirmationStep">If enabled pre-validation step will be skipped..</param>
    public KnowledgeImportJobResponse(string DownloadURL = null, string FailedEntitiesURL = null, string UploadKey = null, FileTypeEnum? FileType = null, KnowledgeImportJobSettings Settings = null, bool? SkipConfirmationStep = null)
    {
        this.DownloadURL = DownloadURL;
        this.FailedEntitiesURL = FailedEntitiesURL;
        this.UploadKey = UploadKey;
        this.FileType = FileType;
        this.Settings = Settings;
        this.SkipConfirmationStep = SkipConfirmationStep;

    }



    /// <summary>
    /// Id of the import job
    /// </summary>
    /// <value>Id of the import job</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The URL of the location at which the caller can download the imported file.
    /// </summary>
    /// <value>The URL of the location at which the caller can download the imported file.</value>
    [JsonPropertyName("downloadURL")]
    public string DownloadURL { get; set; }



    /// <summary>
    /// The URL of the location at which the caller can download the entities in json format that failed during the import.
    /// </summary>
    /// <value>The URL of the location at which the caller can download the entities in json format that failed during the import.</value>
    [JsonPropertyName("failedEntitiesURL")]
    public string FailedEntitiesURL { get; set; }



    /// <summary>
    /// Upload key
    /// </summary>
    /// <value>Upload key</value>
    [JsonPropertyName("uploadKey")]
    public string UploadKey { get; set; }





    /// <summary>
    /// Additional optional settings
    /// </summary>
    /// <value>Additional optional settings</value>
    [JsonPropertyName("settings")]
    public KnowledgeImportJobSettings Settings { get; set; }





    /// <summary>
    /// Report of the import job
    /// </summary>
    /// <value>Report of the import job</value>
    [JsonPropertyName("report")]
    public KnowledgeImportJobReport Report { get; private set; }



    /// <summary>
    /// Knowledge base which document import does belong to
    /// </summary>
    /// <value>Knowledge base which document import does belong to</value>
    [JsonPropertyName("knowledgeBase")]
    public KnowledgeBase KnowledgeBase { get; private set; }



    /// <summary>
    /// The user who created the operation
    /// </summary>
    /// <value>The user who created the operation</value>
    [JsonPropertyName("createdBy")]
    public UserReference CreatedBy { get; private set; }



    /// <summary>
    /// Created date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Created date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified date. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// If enabled pre-validation step will be skipped.
    /// </summary>
    /// <value>If enabled pre-validation step will be skipped.</value>
    [JsonPropertyName("skipConfirmationStep")]
    public bool? SkipConfirmationStep { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeImportJobResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DownloadURL: ").Append(DownloadURL).Append("\n");
        sb.Append("  FailedEntitiesURL: ").Append(FailedEntitiesURL).Append("\n");
        sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
        sb.Append("  FileType: ").Append(FileType).Append("\n");
        sb.Append("  Settings: ").Append(Settings).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Report: ").Append(Report).Append("\n");
        sb.Append("  KnowledgeBase: ").Append(KnowledgeBase).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  SkipConfirmationStep: ").Append(SkipConfirmationStep).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as KnowledgeImportJobResponse);
    }

    /// <summary>
    /// Returns true if KnowledgeImportJobResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeImportJobResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeImportJobResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                DownloadURL == other.DownloadURL ||
                DownloadURL != null &&
                DownloadURL.Equals(other.DownloadURL)
            ) &&
            (
                FailedEntitiesURL == other.FailedEntitiesURL ||
                FailedEntitiesURL != null &&
                FailedEntitiesURL.Equals(other.FailedEntitiesURL)
            ) &&
            (
                UploadKey == other.UploadKey ||
                UploadKey != null &&
                UploadKey.Equals(other.UploadKey)
            ) &&
            (
                FileType == other.FileType ||
                FileType != null &&
                FileType.Equals(other.FileType)
            ) &&
            (
                Settings == other.Settings ||
                Settings != null &&
                Settings.Equals(other.Settings)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Report == other.Report ||
                Report != null &&
                Report.Equals(other.Report)
            ) &&
            (
                KnowledgeBase == other.KnowledgeBase ||
                KnowledgeBase != null &&
                KnowledgeBase.Equals(other.KnowledgeBase)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                SkipConfirmationStep == other.SkipConfirmationStep ||
                SkipConfirmationStep != null &&
                SkipConfirmationStep.Equals(other.SkipConfirmationStep)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (DownloadURL != null)
            {
                hash = hash * 59 + DownloadURL.GetHashCode();
            }

            if (FailedEntitiesURL != null)
            {
                hash = hash * 59 + FailedEntitiesURL.GetHashCode();
            }

            if (UploadKey != null)
            {
                hash = hash * 59 + UploadKey.GetHashCode();
            }

            if (FileType != null)
            {
                hash = hash * 59 + FileType.GetHashCode();
            }

            if (Settings != null)
            {
                hash = hash * 59 + Settings.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Report != null)
            {
                hash = hash * 59 + Report.GetHashCode();
            }

            if (KnowledgeBase != null)
            {
                hash = hash * 59 + KnowledgeBase.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (SkipConfirmationStep != null)
            {
                hash = hash * 59 + SkipConfirmationStep.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
