using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OAuthLastTokenIssued
/// </summary>

public partial class OAuthLastTokenIssued : IEquatable<OAuthLastTokenIssued>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="OAuthLastTokenIssued" /> class.
    /// </summary>
    /// <param name="DateIssued">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public OAuthLastTokenIssued(DateTime? DateIssued = null)
    {
        this.DateIssued = DateIssued;

    }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateIssued")]
    public DateTime? DateIssued { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OAuthLastTokenIssued {\n");

        sb.Append("  DateIssued: ").Append(DateIssued).Append("\n");
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
        return Equals(obj as OAuthLastTokenIssued);
    }

    /// <summary>
    /// Returns true if OAuthLastTokenIssued instances are equal
    /// </summary>
    /// <param name="other">Instance of OAuthLastTokenIssued to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OAuthLastTokenIssued other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateIssued == other.DateIssued ||
                DateIssued != null &&
                DateIssued.Equals(other.DateIssued)
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
            if (DateIssued != null)
            {
                hash = hash * 59 + DateIssued.GetHashCode();
            }

            return hash;
        }
    }
}
