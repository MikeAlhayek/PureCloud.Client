using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LinkConfiguration
/// </summary>

public partial class LinkConfiguration : IEquatable<LinkConfiguration>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LinkConfiguration" /> class.
    /// </summary>
    /// <param name="UriTemplate">UriTemplate.</param>
    public LinkConfiguration(string UriTemplate = null)
    {
        this.UriTemplate = UriTemplate;

    }



    /// <summary>
    /// Gets or Sets UriTemplate
    /// </summary>
    [JsonPropertyName("uriTemplate")]
    public string UriTemplate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LinkConfiguration {\n");

        sb.Append("  UriTemplate: ").Append(UriTemplate).Append("\n");
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
        return Equals(obj as LinkConfiguration);
    }

    /// <summary>
    /// Returns true if LinkConfiguration instances are equal
    /// </summary>
    /// <param name="other">Instance of LinkConfiguration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LinkConfiguration other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UriTemplate == other.UriTemplate ||
                UriTemplate != null &&
                UriTemplate.Equals(other.UriTemplate)
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
            if (UriTemplate != null)
            {
                hash = hash * 59 + UriTemplate.GetHashCode();
            }

            return hash;
        }
    }
}
