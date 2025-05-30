using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EmailSetup
/// </summary>

public partial class EmailSetup : IEquatable<EmailSetup>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmailSetup" /> class.
    /// </summary>
    /// <param name="RootDomain">The root PureCloudEnvironment domain that all sub-domains are created from..</param>
    public EmailSetup(string RootDomain = null)
    {
        this.RootDomain = RootDomain;

    }



    /// <summary>
    /// The root PureCloudEnvironment domain that all sub-domains are created from.
    /// </summary>
    /// <value>The root PureCloudEnvironment domain that all sub-domains are created from.</value>
    [JsonPropertyName("rootDomain")]
    public string RootDomain { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EmailSetup {\n");

        sb.Append("  RootDomain: ").Append(RootDomain).Append("\n");
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
        return Equals(obj as EmailSetup);
    }

    /// <summary>
    /// Returns true if EmailSetup instances are equal
    /// </summary>
    /// <param name="other">Instance of EmailSetup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EmailSetup other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RootDomain == other.RootDomain ||
                RootDomain != null &&
                RootDomain.Equals(other.RootDomain)
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
            if (RootDomain != null)
            {
                hash = hash * 59 + RootDomain.GetHashCode();
            }

            return hash;
        }
    }
}
