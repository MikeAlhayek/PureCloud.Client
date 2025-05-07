using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SocialTopicResponse
/// </summary>

public partial class SocialTopicResponse : IEquatable<SocialTopicResponse>
{
    /// <summary>
    /// The status of the social topic.
    /// </summary>
    /// <value>The status of the social topic.</value>
    
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
        /// Enum Active for "Active"
        /// </summary>
        [EnumMember(Value = "Active")]
        Active,

        /// <summary>
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Deleted for "Deleted"
        /// </summary>
        [EnumMember(Value = "Deleted")]
        Deleted
    }
    /// <summary>
    /// The status of the social topic.
    /// </summary>
    /// <value>The status of the social topic.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SocialTopicResponse" /> class.
    /// </summary>
    /// <param name="Id">ID of the social topic..</param>
    /// <param name="Name">The name of the social topic..</param>
    /// <param name="Description">A description of the social topic..</param>
    /// <param name="DateCreated">Timestamp indicating when the social topic was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateModified">Timestamp indicating when the social topic was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DivisionId">The ID of the division to which the social topic belongs to..</param>
    /// <param name="Status">The status of the social topic..</param>
    /// <param name="DataIngestionRulesMetadata">The data ingestion rule metadata..</param>
    public SocialTopicResponse(string Id = null, string Name = null, string Description = null, DateTime? DateCreated = null, DateTime? DateModified = null, string DivisionId = null, StatusEnum? Status = null, List<DataIngestionRulesMetadata> DataIngestionRulesMetadata = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Description = Description;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.DivisionId = DivisionId;
        this.Status = Status;
        this.DataIngestionRulesMetadata = DataIngestionRulesMetadata;

    }



    /// <summary>
    /// ID of the social topic.
    /// </summary>
    /// <value>ID of the social topic.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the social topic.
    /// </summary>
    /// <value>The name of the social topic.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// A description of the social topic.
    /// </summary>
    /// <value>A description of the social topic.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Timestamp indicating when the social topic was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the social topic was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Timestamp indicating when the social topic was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp indicating when the social topic was last updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// The ID of the division to which the social topic belongs to.
    /// </summary>
    /// <value>The ID of the division to which the social topic belongs to.</value>
    [JsonPropertyName("divisionId")]
    public string DivisionId { get; set; }





    /// <summary>
    /// The data ingestion rule metadata.
    /// </summary>
    /// <value>The data ingestion rule metadata.</value>
    [JsonPropertyName("dataIngestionRulesMetadata")]
    public List<DataIngestionRulesMetadata> DataIngestionRulesMetadata { get; set; }



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
        sb.Append("class SocialTopicResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  DataIngestionRulesMetadata: ").Append(DataIngestionRulesMetadata).Append("\n");
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
        return Equals(obj as SocialTopicResponse);
    }

    /// <summary>
    /// Returns true if SocialTopicResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of SocialTopicResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SocialTopicResponse other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
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
                DivisionId == other.DivisionId ||
                DivisionId != null &&
                DivisionId.Equals(other.DivisionId)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                DataIngestionRulesMetadata == other.DataIngestionRulesMetadata ||
                DataIngestionRulesMetadata != null &&
                DataIngestionRulesMetadata.SequenceEqual(other.DataIngestionRulesMetadata)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (DivisionId != null)
            {
                hash = hash * 59 + DivisionId.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (DataIngestionRulesMetadata != null)
            {
                hash = hash * 59 + DataIngestionRulesMetadata.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
