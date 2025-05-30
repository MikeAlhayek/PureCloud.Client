using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeVersionInformation
/// </summary>

public partial class EdgeVersionInformation : IEquatable<EdgeVersionInformation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeVersionInformation" /> class.
    /// </summary>
    /// <param name="SoftwareVersion">SoftwareVersion.</param>
    public EdgeVersionInformation(string SoftwareVersion = null)
    {
        this.SoftwareVersion = SoftwareVersion;

    }



    /// <summary>
    /// Gets or Sets SoftwareVersion
    /// </summary>
    [JsonPropertyName("softwareVersion")]
    public string SoftwareVersion { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeVersionInformation {\n");

        sb.Append("  SoftwareVersion: ").Append(SoftwareVersion).Append("\n");
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
        return Equals(obj as EdgeVersionInformation);
    }

    /// <summary>
    /// Returns true if EdgeVersionInformation instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeVersionInformation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeVersionInformation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SoftwareVersion == other.SoftwareVersion ||
                SoftwareVersion != null &&
                SoftwareVersion.Equals(other.SoftwareVersion)
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
            if (SoftwareVersion != null)
            {
                hash = hash * 59 + SoftwareVersion.GetHashCode();
            }

            return hash;
        }
    }
}
