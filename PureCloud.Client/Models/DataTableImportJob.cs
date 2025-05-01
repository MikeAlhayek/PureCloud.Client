using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// State information for an import job of rows to a datatable
/// </summary>
[DataContract]
public partial class DataTableImportJob : IEquatable<DataTableImportJob>
{
    /// <summary>
    /// The status of the import job
    /// </summary>
    /// <value>The status of the import job</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Waitingforupload for "WaitingForUpload"
        /// </summary>
        [EnumMember(Value = "WaitingForUpload")]
        Waitingforupload,

        /// <summary>
        /// Enum Processing for "Processing"
        /// </summary>
        [EnumMember(Value = "Processing")]
        Processing,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Succeeded for "Succeeded"
        /// </summary>
        [EnumMember(Value = "Succeeded")]
        Succeeded
    }
    /// <summary>
    /// The indication of whether the processing should remove rows that don't appear in the import file
    /// </summary>
    /// <value>The indication of whether the processing should remove rows that don't appear in the import file</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ImportModeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Replaceall for "ReplaceAll"
        /// </summary>
        [EnumMember(Value = "ReplaceAll")]
        Replaceall,

        /// <summary>
        /// Enum Append for "Append"
        /// </summary>
        [EnumMember(Value = "Append")]
        Append
    }
    /// <summary>
    /// The status of the import job
    /// </summary>
    /// <value>The status of the import job</value>
    [DataMember(Name = "status", EmitDefaultValue = false)]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// The indication of whether the processing should remove rows that don't appear in the import file
    /// </summary>
    /// <value>The indication of whether the processing should remove rows that don't appear in the import file</value>
    [DataMember(Name = "importMode", EmitDefaultValue = false)]
    public ImportModeEnum? ImportMode { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataTableImportJob" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DataTableImportJob() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DataTableImportJob" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Owner">The PureCloudEnvironment user who started the import job.</param>
    /// <param name="Status">The status of the import job (required).</param>
    /// <param name="DateCreated">The timestamp of when the import began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateCompleted">The timestamp of when the import stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="UploadURI">The URL of the location at which the caller can upload the file to be imported.</param>
    /// <param name="ImportMode">The indication of whether the processing should remove rows that don&#39;t appear in the import file.</param>
    /// <param name="ErrorInformation">Any error information, or null of the processing is not in an error state.</param>
    /// <param name="CountRecordsUpdated">The current count of the number of records processed.</param>
    /// <param name="CountRecordsDeleted">The current count of the number of records deleted.</param>
    /// <param name="CountRecordsFailed">The current count of the number of records that failed to import.</param>
    public DataTableImportJob(string Name = null, AddressableEntityRef Owner = null, StatusEnum? Status = null, DateTime? DateCreated = null, DateTime? DateCompleted = null, string UploadURI = null, ImportModeEnum? ImportMode = null, ErrorBody ErrorInformation = null, int? CountRecordsUpdated = null, int? CountRecordsDeleted = null, int? CountRecordsFailed = null)
    {
        this.Name = Name;
        this.Owner = Owner;
        this.Status = Status;
        this.DateCreated = DateCreated;
        this.DateCompleted = DateCompleted;
        this.UploadURI = UploadURI;
        this.ImportMode = ImportMode;
        this.ErrorInformation = ErrorInformation;
        this.CountRecordsUpdated = CountRecordsUpdated;
        this.CountRecordsDeleted = CountRecordsDeleted;
        this.CountRecordsFailed = CountRecordsFailed;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// The PureCloudEnvironment user who started the import job
    /// </summary>
    /// <value>The PureCloudEnvironment user who started the import job</value>
    [DataMember(Name = "owner", EmitDefaultValue = false)]
    public AddressableEntityRef Owner { get; set; }





    /// <summary>
    /// The timestamp of when the import began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of when the import began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The timestamp of when the import stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of when the import stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCompleted", EmitDefaultValue = false)]
    public DateTime? DateCompleted { get; set; }



    /// <summary>
    /// The URL of the location at which the caller can upload the file to be imported
    /// </summary>
    /// <value>The URL of the location at which the caller can upload the file to be imported</value>
    [DataMember(Name = "uploadURI", EmitDefaultValue = false)]
    public string UploadURI { get; set; }





    /// <summary>
    /// Any error information, or null of the processing is not in an error state
    /// </summary>
    /// <value>Any error information, or null of the processing is not in an error state</value>
    [DataMember(Name = "errorInformation", EmitDefaultValue = false)]
    public ErrorBody ErrorInformation { get; set; }



    /// <summary>
    /// The current count of the number of records processed
    /// </summary>
    /// <value>The current count of the number of records processed</value>
    [DataMember(Name = "countRecordsUpdated", EmitDefaultValue = false)]
    public int? CountRecordsUpdated { get; set; }



    /// <summary>
    /// The current count of the number of records deleted
    /// </summary>
    /// <value>The current count of the number of records deleted</value>
    [DataMember(Name = "countRecordsDeleted", EmitDefaultValue = false)]
    public int? CountRecordsDeleted { get; set; }



    /// <summary>
    /// The current count of the number of records that failed to import
    /// </summary>
    /// <value>The current count of the number of records that failed to import</value>
    [DataMember(Name = "countRecordsFailed", EmitDefaultValue = false)]
    public int? CountRecordsFailed { get; set; }



    /// <summary>
    /// Required headers when uploading a file through PUT request to the URL in the &#39;uploadURI&#39; field
    /// </summary>
    /// <value>Required headers when uploading a file through PUT request to the URL in the &#39;uploadURI&#39; field</value>
    [DataMember(Name = "uploadHeaders", EmitDefaultValue = false)]
    public Dictionary<string, string> UploadHeaders { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DataTableImportJob {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Owner: ").Append(Owner).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
        sb.Append("  UploadURI: ").Append(UploadURI).Append("\n");
        sb.Append("  ImportMode: ").Append(ImportMode).Append("\n");
        sb.Append("  ErrorInformation: ").Append(ErrorInformation).Append("\n");
        sb.Append("  CountRecordsUpdated: ").Append(CountRecordsUpdated).Append("\n");
        sb.Append("  CountRecordsDeleted: ").Append(CountRecordsDeleted).Append("\n");
        sb.Append("  CountRecordsFailed: ").Append(CountRecordsFailed).Append("\n");
        sb.Append("  UploadHeaders: ").Append(UploadHeaders).Append("\n");
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
        return Equals(obj as DataTableImportJob);
    }

    /// <summary>
    /// Returns true if DataTableImportJob instances are equal
    /// </summary>
    /// <param name="other">Instance of DataTableImportJob to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DataTableImportJob other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Owner == other.Owner ||
                Owner != null &&
                Owner.Equals(other.Owner)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateCompleted == other.DateCompleted ||
                DateCompleted != null &&
                DateCompleted.Equals(other.DateCompleted)
            ) &&
            (
                UploadURI == other.UploadURI ||
                UploadURI != null &&
                UploadURI.Equals(other.UploadURI)
            ) &&
            (
                ImportMode == other.ImportMode ||
                ImportMode != null &&
                ImportMode.Equals(other.ImportMode)
            ) &&
            (
                ErrorInformation == other.ErrorInformation ||
                ErrorInformation != null &&
                ErrorInformation.Equals(other.ErrorInformation)
            ) &&
            (
                CountRecordsUpdated == other.CountRecordsUpdated ||
                CountRecordsUpdated != null &&
                CountRecordsUpdated.Equals(other.CountRecordsUpdated)
            ) &&
            (
                CountRecordsDeleted == other.CountRecordsDeleted ||
                CountRecordsDeleted != null &&
                CountRecordsDeleted.Equals(other.CountRecordsDeleted)
            ) &&
            (
                CountRecordsFailed == other.CountRecordsFailed ||
                CountRecordsFailed != null &&
                CountRecordsFailed.Equals(other.CountRecordsFailed)
            ) &&
            (
                UploadHeaders == other.UploadHeaders ||
                UploadHeaders != null &&
                UploadHeaders.SequenceEqual(other.UploadHeaders)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Owner != null)
            {
                hash = hash * 59 + Owner.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateCompleted != null)
            {
                hash = hash * 59 + DateCompleted.GetHashCode();
            }

            if (UploadURI != null)
            {
                hash = hash * 59 + UploadURI.GetHashCode();
            }

            if (ImportMode != null)
            {
                hash = hash * 59 + ImportMode.GetHashCode();
            }

            if (ErrorInformation != null)
            {
                hash = hash * 59 + ErrorInformation.GetHashCode();
            }

            if (CountRecordsUpdated != null)
            {
                hash = hash * 59 + CountRecordsUpdated.GetHashCode();
            }

            if (CountRecordsDeleted != null)
            {
                hash = hash * 59 + CountRecordsDeleted.GetHashCode();
            }

            if (CountRecordsFailed != null)
            {
                hash = hash * 59 + CountRecordsFailed.GetHashCode();
            }

            if (UploadHeaders != null)
            {
                hash = hash * 59 + UploadHeaders.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
