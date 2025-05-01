using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// IpAddressAuthentication
/// </summary>
[DataContract]
public partial class IpAddressAuthentication : IEquatable<IpAddressAuthentication>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="IpAddressAuthentication" /> class.
    /// </summary>
    /// <param name="NetworkWhitelist">NetworkWhitelist.</param>
    public IpAddressAuthentication(List<string> NetworkWhitelist = null)
    {
        this.NetworkWhitelist = NetworkWhitelist;

    }



    /// <summary>
    /// Gets or Sets NetworkWhitelist
    /// </summary>
    [DataMember(Name = "networkWhitelist", EmitDefaultValue = false)]
    public List<string> NetworkWhitelist { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class IpAddressAuthentication {\n");

        sb.Append("  NetworkWhitelist: ").Append(NetworkWhitelist).Append("\n");
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
        return Equals(obj as IpAddressAuthentication);
    }

    /// <summary>
    /// Returns true if IpAddressAuthentication instances are equal
    /// </summary>
    /// <param name="other">Instance of IpAddressAuthentication to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(IpAddressAuthentication other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                NetworkWhitelist == other.NetworkWhitelist ||
                NetworkWhitelist != null &&
                NetworkWhitelist.SequenceEqual(other.NetworkWhitelist)
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
            if (NetworkWhitelist != null)
            {
                hash = hash * 59 + NetworkWhitelist.GetHashCode();
            }

            return hash;
        }
    }
}
