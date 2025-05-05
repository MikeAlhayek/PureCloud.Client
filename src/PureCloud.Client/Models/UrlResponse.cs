using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UrlResponse
/// </summary>

public partial class UrlResponse : IEquatable<UrlResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UrlResponse" /> class.
    /// </summary>
    /// <param name="Url">Url.</param>
    public UrlResponse(string Url = null)
    {
        this.Url = Url;

    }



    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UrlResponse {\n");

        sb.Append("  Url: ").Append(Url).Append("\n");
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
        return Equals(obj as UrlResponse);
    }

    /// <summary>
    /// Returns true if UrlResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of UrlResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UrlResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
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
            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            return hash;
        }
    }
}
