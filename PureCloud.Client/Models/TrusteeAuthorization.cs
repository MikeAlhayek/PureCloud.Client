using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TrusteeAuthorization
/// </summary>

public partial class TrusteeAuthorization : IEquatable<TrusteeAuthorization>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="TrusteeAuthorization" /> class.
    /// </summary>
    public TrusteeAuthorization()
    {

    }



    /// <summary>
    /// Permissions that the trustee user has in the trustor organization
    /// </summary>
    /// <value>Permissions that the trustee user has in the trustor organization</value>
    [JsonPropertyName("permissions")]
    public List<string> Permissions { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TrusteeAuthorization {\n");

        sb.Append("  Permissions: ").Append(Permissions).Append("\n");
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
        return Equals(obj as TrusteeAuthorization);
    }

    /// <summary>
    /// Returns true if TrusteeAuthorization instances are equal
    /// </summary>
    /// <param name="other">Instance of TrusteeAuthorization to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TrusteeAuthorization other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Permissions == other.Permissions ||
                Permissions != null &&
                Permissions.SequenceEqual(other.Permissions)
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
            if (Permissions != null)
            {
                hash = hash * 59 + Permissions.GetHashCode();
            }

            return hash;
        }
    }
}
