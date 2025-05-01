using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ExportUri
/// </summary>
[DataContract]
public partial class ExportUri : IEquatable<ExportUri>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExportUri" /> class.
    /// </summary>
    /// <param name="Uri">Uri.</param>
    /// <param name="ExportTimestamp">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public ExportUri(string Uri = null, DateTime? ExportTimestamp = null)
    {
        this.Uri = Uri;
        this.ExportTimestamp = ExportTimestamp;

    }



    /// <summary>
    /// Gets or Sets Uri
    /// </summary>
    [DataMember(Name = "uri", EmitDefaultValue = false)]
    public string Uri { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "exportTimestamp", EmitDefaultValue = false)]
    public DateTime? ExportTimestamp { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ExportUri {\n");

        sb.Append("  Uri: ").Append(Uri).Append("\n");
        sb.Append("  ExportTimestamp: ").Append(ExportTimestamp).Append("\n");
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
        return Equals(obj as ExportUri);
    }

    /// <summary>
    /// Returns true if ExportUri instances are equal
    /// </summary>
    /// <param name="other">Instance of ExportUri to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ExportUri other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Uri == other.Uri ||
                Uri != null &&
                Uri.Equals(other.Uri)
            ) &&
            (
                ExportTimestamp == other.ExportTimestamp ||
                ExportTimestamp != null &&
                ExportTimestamp.Equals(other.ExportTimestamp)
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
            if (Uri != null)
            {
                hash = hash * 59 + Uri.GetHashCode();
            }

            if (ExportTimestamp != null)
            {
                hash = hash * 59 + ExportTimestamp.GetHashCode();
            }

            return hash;
        }
    }
}
