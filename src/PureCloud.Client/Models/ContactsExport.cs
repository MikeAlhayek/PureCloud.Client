using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactsExport
/// </summary>

public partial class ContactsExport : IEquatable<ContactsExport>
{
    /// <summary>
    /// The status of the request
    /// </summary>
    /// <value>The status of the request</value>
    
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
        /// Enum Running for "RUNNING"
        /// </summary>
        [EnumMember(Value = "RUNNING")]
        Running,

        /// <summary>
        /// Enum Succeeded for "SUCCEEDED"
        /// </summary>
        [EnumMember(Value = "SUCCEEDED")]
        Succeeded,

        /// <summary>
        /// Enum Failed for "FAILED"
        /// </summary>
        [EnumMember(Value = "FAILED")]
        Failed
    }
    /// <summary>
    /// The status of the request
    /// </summary>
    /// <value>The status of the request</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactsExport" /> class.
    /// </summary>
    /// <param name="DivisionIds">Division IDs of entities.</param>
    /// <param name="QueryConditions">Query conditions to apply on export.</param>
    public ContactsExport(List<string> DivisionIds = null, ContactsExportQueryConditions QueryConditions = null)
    {
        this.DivisionIds = DivisionIds;
        this.QueryConditions = QueryConditions;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Division IDs of entities
    /// </summary>
    /// <value>Division IDs of entities</value>
    [JsonPropertyName("divisionIds")]
    public List<string> DivisionIds { get; set; }



    /// <summary>
    /// Query conditions to apply on export
    /// </summary>
    /// <value>Query conditions to apply on export</value>
    [JsonPropertyName("queryConditions")]
    public ContactsExportQueryConditions QueryConditions { get; set; }



    /// <summary>
    /// The user that created this request
    /// </summary>
    /// <value>The user that created this request</value>
    [JsonPropertyName("createdBy")]
    public DomainEntityRef CreatedBy { get; set; }



    /// <summary>
    /// When the request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>When the request was submitted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }





    /// <summary>
    /// The location where the results of the request can be retrieved
    /// </summary>
    /// <value>The location where the results of the request can be retrieved</value>
    [JsonPropertyName("downloadUrl")]
    public string DownloadUrl { get; set; }



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
        sb.Append("class ContactsExport {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DivisionIds: ").Append(DivisionIds).Append("\n");
        sb.Append("  QueryConditions: ").Append(QueryConditions).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  DownloadUrl: ").Append(DownloadUrl).Append("\n");
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
        return Equals(obj as ContactsExport);
    }

    /// <summary>
    /// Returns true if ContactsExport instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactsExport to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactsExport other)
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
                DivisionIds == other.DivisionIds ||
                DivisionIds != null &&
                DivisionIds.SequenceEqual(other.DivisionIds)
            ) &&
            (
                QueryConditions == other.QueryConditions ||
                QueryConditions != null &&
                QueryConditions.Equals(other.QueryConditions)
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
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                DownloadUrl == other.DownloadUrl ||
                DownloadUrl != null &&
                DownloadUrl.Equals(other.DownloadUrl)
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

            if (DivisionIds != null)
            {
                hash = hash * 59 + DivisionIds.GetHashCode();
            }

            if (QueryConditions != null)
            {
                hash = hash * 59 + QueryConditions.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (DownloadUrl != null)
            {
                hash = hash * 59 + DownloadUrl.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
