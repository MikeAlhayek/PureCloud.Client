using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a link between an External Identifier and Authority pair to a Entity Type and Entity Identifier pair. Represents the two way, one to one mapping of an External Authority or System of Record&#39;s identifier to a PureCloudEnvironment entity. e.g. (ExternalId&#x3D;&#39;05001&#39;,Authority&#x3D;&#39;XyzCRM&#39;) to (entityType&#x3D;user,entityId&#x3D;&#39;8eb03b33-3acb-4bc1-a244-50b9b9f19495&#39;)
/// </summary>

public partial class UserExternalIdentifier : IEquatable<UserExternalIdentifier>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="UserExternalIdentifier" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UserExternalIdentifier() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UserExternalIdentifier" /> class.
    /// </summary>
    /// <param name="AuthorityName">Authority or System of Record which owns the External Identifier (required).</param>
    /// <param name="ExternalKey">External Key (required).</param>
    public UserExternalIdentifier(string AuthorityName = null, string ExternalKey = null)
    {
        this.AuthorityName = AuthorityName;
        this.ExternalKey = ExternalKey;

    }



    /// <summary>
    /// Authority or System of Record which owns the External Identifier
    /// </summary>
    /// <value>Authority or System of Record which owns the External Identifier</value>
    [JsonPropertyName("authorityName")]
    public string AuthorityName { get; set; }



    /// <summary>
    /// External Key
    /// </summary>
    /// <value>External Key</value>
    [JsonPropertyName("externalKey")]
    public string ExternalKey { get; set; }



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
        sb.Append("class UserExternalIdentifier {\n");

        sb.Append("  AuthorityName: ").Append(AuthorityName).Append("\n");
        sb.Append("  ExternalKey: ").Append(ExternalKey).Append("\n");
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
        return Equals(obj as UserExternalIdentifier);
    }

    /// <summary>
    /// Returns true if UserExternalIdentifier instances are equal
    /// </summary>
    /// <param name="other">Instance of UserExternalIdentifier to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserExternalIdentifier other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AuthorityName == other.AuthorityName ||
                AuthorityName != null &&
                AuthorityName.Equals(other.AuthorityName)
            ) &&
            (
                ExternalKey == other.ExternalKey ||
                ExternalKey != null &&
                ExternalKey.Equals(other.ExternalKey)
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
            if (AuthorityName != null)
            {
                hash = hash * 59 + AuthorityName.GetHashCode();
            }

            if (ExternalKey != null)
            {
                hash = hash * 59 + ExternalKey.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
