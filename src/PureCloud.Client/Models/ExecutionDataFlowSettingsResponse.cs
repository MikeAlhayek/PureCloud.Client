using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExecutionDataFlowSettingsResponse
/// </summary>

public partial class ExecutionDataFlowSettingsResponse : IEquatable<ExecutionDataFlowSettingsResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExecutionDataFlowSettingsResponse" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Enabled">whether or not the setting is enabled..</param>
    /// <param name="ModifiedBy">User that last changed the setting..</param>
    /// <param name="ModifiedByClient">OAuth client that last changed the setting..</param>
    /// <param name="DateModified">The time this setting was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public ExecutionDataFlowSettingsResponse(string Name = null, bool? Enabled = null, UserReference ModifiedBy = null, DomainEntityRef ModifiedByClient = null, DateTime? DateModified = null)
    {
        this.Name = Name;
        this.Enabled = Enabled;
        this.ModifiedBy = ModifiedBy;
        this.ModifiedByClient = ModifiedByClient;
        this.DateModified = DateModified;

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
    /// whether or not the setting is enabled.
    /// </summary>
    /// <value>whether or not the setting is enabled.</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// User that last changed the setting.
    /// </summary>
    /// <value>User that last changed the setting.</value>
    [JsonPropertyName("modifiedBy")]
    public UserReference ModifiedBy { get; set; }



    /// <summary>
    /// OAuth client that last changed the setting.
    /// </summary>
    /// <value>OAuth client that last changed the setting.</value>
    [JsonPropertyName("modifiedByClient")]
    public DomainEntityRef ModifiedByClient { get; set; }



    /// <summary>
    /// The time this setting was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The time this setting was set. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



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
        sb.Append("class ExecutionDataFlowSettingsResponse {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  ModifiedByClient: ").Append(ModifiedByClient).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
        return Equals(obj as ExecutionDataFlowSettingsResponse);
    }

    /// <summary>
    /// Returns true if ExecutionDataFlowSettingsResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ExecutionDataFlowSettingsResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExecutionDataFlowSettingsResponse other)
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
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                ModifiedByClient == other.ModifiedByClient ||
                ModifiedByClient != null &&
                ModifiedByClient.Equals(other.ModifiedByClient)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
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

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (ModifiedByClient != null)
            {
                hash = hash * 59 + ModifiedByClient.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
