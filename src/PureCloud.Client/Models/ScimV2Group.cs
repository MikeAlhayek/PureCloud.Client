using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM group.
/// </summary>

public partial class ScimV2Group : IEquatable<ScimV2Group>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2Group" /> class.
    /// </summary>
    /// <param name="ExternalId">The external ID of the group. Set by the provisioning client. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readWrite\&quot;..</param>
    /// <param name="Members">The list of members in the group..</param>
    public ScimV2Group(string ExternalId = null, List<ScimV2MemberReference> Members = null)
    {
        this.ExternalId = ExternalId;
        this.Members = Members;

    }



    /// <summary>
    /// The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;returned\&quot; is set to \&quot;always\&quot;.
    /// </summary>
    /// <value>The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;returned\&quot; is set to \&quot;always\&quot;.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The list of supported schemas.
    /// </summary>
    /// <value>The list of supported schemas.</value>
    [JsonPropertyName("schemas")]
    public List<string> Schemas { get; private set; }



    /// <summary>
    /// The display name of the group.
    /// </summary>
    /// <value>The display name of the group.</value>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; private set; }



    /// <summary>
    /// The external ID of the group. Set by the provisioning client. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readWrite\&quot;.
    /// </summary>
    /// <value>The external ID of the group. Set by the provisioning client. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readWrite\&quot;.</value>
    [JsonPropertyName("externalId")]
    public string ExternalId { get; set; }



    /// <summary>
    /// The list of members in the group.
    /// </summary>
    /// <value>The list of members in the group.</value>
    [JsonPropertyName("members")]
    public List<ScimV2MemberReference> Members { get; set; }



    /// <summary>
    /// The metadata of the SCIM resource. Metadata is defined as immutable per SCIM RFC.
    /// </summary>
    /// <value>The metadata of the SCIM resource. Metadata is defined as immutable per SCIM RFC.</value>
    [JsonPropertyName("meta")]
    public ScimMetadata Meta { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimV2Group {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Schemas: ").Append(Schemas).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
        sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
        sb.Append("  Members: ").Append(Members).Append("\n");
        sb.Append("  Meta: ").Append(Meta).Append("\n");
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
        return Equals(obj as ScimV2Group);
    }

    /// <summary>
    /// Returns true if ScimV2Group instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimV2Group to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimV2Group other)
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
                Schemas == other.Schemas ||
                Schemas != null &&
                Schemas.SequenceEqual(other.Schemas)
            ) &&
            (
                DisplayName == other.DisplayName ||
                DisplayName != null &&
                DisplayName.Equals(other.DisplayName)
            ) &&
            (
                ExternalId == other.ExternalId ||
                ExternalId != null &&
                ExternalId.Equals(other.ExternalId)
            ) &&
            (
                Members == other.Members ||
                Members != null &&
                Members.SequenceEqual(other.Members)
            ) &&
            (
                Meta == other.Meta ||
                Meta != null &&
                Meta.Equals(other.Meta)
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

            if (Schemas != null)
            {
                hash = hash * 59 + Schemas.GetHashCode();
            }

            if (DisplayName != null)
            {
                hash = hash * 59 + DisplayName.GetHashCode();
            }

            if (ExternalId != null)
            {
                hash = hash * 59 + ExternalId.GetHashCode();
            }

            if (Members != null)
            {
                hash = hash * 59 + Members.GetHashCode();
            }

            if (Meta != null)
            {
                hash = hash * 59 + Meta.GetHashCode();
            }

            return hash;
        }
    }
}
