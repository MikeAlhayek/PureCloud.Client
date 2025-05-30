using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OpenMessagingIdentityResolutionConfig
/// </summary>

public partial class OpenMessagingIdentityResolutionConfig : IEquatable<OpenMessagingIdentityResolutionConfig>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="OpenMessagingIdentityResolutionConfig" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OpenMessagingIdentityResolutionConfig() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OpenMessagingIdentityResolutionConfig" /> class.
    /// </summary>
    /// <param name="Division">The division to which this entity belongs..</param>
    /// <param name="ResolveIdentities">Whether the channel should resolve identities (required).</param>
    /// <param name="ExternalSource">The external source used for stitching this channel - used only for Open Messaging..</param>
    public OpenMessagingIdentityResolutionConfig(WritableStarrableDivision Division = null, bool? ResolveIdentities = null, AddressableEntityRef ExternalSource = null)
    {
        this.Division = Division;
        this.ResolveIdentities = ResolveIdentities;
        this.ExternalSource = ExternalSource;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The division to which this entity belongs.
    /// </summary>
    /// <value>The division to which this entity belongs.</value>
    [JsonPropertyName("division")]
    public WritableStarrableDivision Division { get; set; }



    /// <summary>
    /// Whether the channel should resolve identities
    /// </summary>
    /// <value>Whether the channel should resolve identities</value>
    [JsonPropertyName("resolveIdentities")]
    public bool? ResolveIdentities { get; set; }



    /// <summary>
    /// The external source used for stitching this channel - used only for Open Messaging.
    /// </summary>
    /// <value>The external source used for stitching this channel - used only for Open Messaging.</value>
    [JsonPropertyName("externalSource")]
    public AddressableEntityRef ExternalSource { get; set; }



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
        sb.Append("class OpenMessagingIdentityResolutionConfig {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Division: ").Append(Division).Append("\n");
        sb.Append("  ResolveIdentities: ").Append(ResolveIdentities).Append("\n");
        sb.Append("  ExternalSource: ").Append(ExternalSource).Append("\n");
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
        return Equals(obj as OpenMessagingIdentityResolutionConfig);
    }

    /// <summary>
    /// Returns true if OpenMessagingIdentityResolutionConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of OpenMessagingIdentityResolutionConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OpenMessagingIdentityResolutionConfig other)
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
                Division == other.Division ||
                Division != null &&
                Division.Equals(other.Division)
            ) &&
            (
                ResolveIdentities == other.ResolveIdentities ||
                ResolveIdentities != null &&
                ResolveIdentities.Equals(other.ResolveIdentities)
            ) &&
            (
                ExternalSource == other.ExternalSource ||
                ExternalSource != null &&
                ExternalSource.Equals(other.ExternalSource)
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

            if (Division != null)
            {
                hash = hash * 59 + Division.GetHashCode();
            }

            if (ResolveIdentities != null)
            {
                hash = hash * 59 + ResolveIdentities.GetHashCode();
            }

            if (ExternalSource != null)
            {
                hash = hash * 59 + ExternalSource.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
