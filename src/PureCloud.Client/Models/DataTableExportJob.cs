using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// State information for an export job of rows from a datatable
/// </summary>

public partial class DataTableExportJob : IEquatable<DataTableExportJob>
{
    /// <summary>
    /// The status of the export job
    /// </summary>
    /// <value>The status of the export job</value>
    
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
    /// The status of the export job
    /// </summary>
    /// <value>The status of the export job</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DataTableExportJob" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DataTableExportJob() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DataTableExportJob" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Owner">The PureCloudEnvironment user who started the export job.</param>
    /// <param name="Status">The status of the export job (required).</param>
    /// <param name="DateCreated">The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateCompleted">The timestamp of when the export stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DownloadURI">The URL of the location at which the caller can download the export file, when available.</param>
    /// <param name="ErrorInformation">Any error information, or null of the processing is not in an error state.</param>
    /// <param name="CountRecordsProcessed">The current count of the number of records processed.</param>
    public DataTableExportJob(string Name = null, AddressableEntityRef Owner = null, StatusEnum? Status = null, DateTime? DateCreated = null, DateTime? DateCompleted = null, string DownloadURI = null, ErrorBody ErrorInformation = null, int? CountRecordsProcessed = null)
    {
        this.Name = Name;
        this.Owner = Owner;
        this.Status = Status;
        this.DateCreated = DateCreated;
        this.DateCompleted = DateCompleted;
        this.DownloadURI = DownloadURI;
        this.ErrorInformation = ErrorInformation;
        this.CountRecordsProcessed = CountRecordsProcessed;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The PureCloudEnvironment user who started the export job
    /// </summary>
    /// <value>The PureCloudEnvironment user who started the export job</value>
    [JsonPropertyName("owner")]
    public AddressableEntityRef Owner { get; set; }





    /// <summary>
    /// The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of when the export began. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// The timestamp of when the export stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The timestamp of when the export stopped (either successfully or unsuccessfully). Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCompleted")]
    public DateTime? DateCompleted { get; set; }



    /// <summary>
    /// The URL of the location at which the caller can download the export file, when available
    /// </summary>
    /// <value>The URL of the location at which the caller can download the export file, when available</value>
    [JsonPropertyName("downloadURI")]
    public string DownloadURI { get; set; }



    /// <summary>
    /// Any error information, or null of the processing is not in an error state
    /// </summary>
    /// <value>Any error information, or null of the processing is not in an error state</value>
    [JsonPropertyName("errorInformation")]
    public ErrorBody ErrorInformation { get; set; }



    /// <summary>
    /// The current count of the number of records processed
    /// </summary>
    /// <value>The current count of the number of records processed</value>
    [JsonPropertyName("countRecordsProcessed")]
    public int? CountRecordsProcessed { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DataTableExportJob {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Owner: ").Append(Owner).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateCompleted: ").Append(DateCompleted).Append("\n");
        sb.Append("  DownloadURI: ").Append(DownloadURI).Append("\n");
        sb.Append("  ErrorInformation: ").Append(ErrorInformation).Append("\n");
        sb.Append("  CountRecordsProcessed: ").Append(CountRecordsProcessed).Append("\n");
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
        return Equals(obj as DataTableExportJob);
    }

    /// <summary>
    /// Returns true if DataTableExportJob instances are equal
    /// </summary>
    /// <param name="other">Instance of DataTableExportJob to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DataTableExportJob other)
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
                DownloadURI == other.DownloadURI ||
                DownloadURI != null &&
                DownloadURI.Equals(other.DownloadURI)
            ) &&
            (
                ErrorInformation == other.ErrorInformation ||
                ErrorInformation != null &&
                ErrorInformation.Equals(other.ErrorInformation)
            ) &&
            (
                CountRecordsProcessed == other.CountRecordsProcessed ||
                CountRecordsProcessed != null &&
                CountRecordsProcessed.Equals(other.CountRecordsProcessed)
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

            if (DownloadURI != null)
            {
                hash = hash * 59 + DownloadURI.GetHashCode();
            }

            if (ErrorInformation != null)
            {
                hash = hash * 59 + ErrorInformation.GetHashCode();
            }

            if (CountRecordsProcessed != null)
            {
                hash = hash * 59 + CountRecordsProcessed.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
