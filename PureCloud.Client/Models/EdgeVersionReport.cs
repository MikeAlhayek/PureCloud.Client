using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EdgeVersionReport
/// </summary>
[DataContract]
public partial class EdgeVersionReport : IEquatable<EdgeVersionReport>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EdgeVersionReport" /> class.
    /// </summary>
    /// <param name="OldestVersion">OldestVersion.</param>
    /// <param name="NewestVersion">NewestVersion.</param>
    public EdgeVersionReport(EdgeVersionInformation OldestVersion = null, EdgeVersionInformation NewestVersion = null)
    {
        this.OldestVersion = OldestVersion;
        this.NewestVersion = NewestVersion;

    }



    /// <summary>
    /// Gets or Sets OldestVersion
    /// </summary>
    [DataMember(Name = "oldestVersion", EmitDefaultValue = false)]
    public EdgeVersionInformation OldestVersion { get; set; }



    /// <summary>
    /// Gets or Sets NewestVersion
    /// </summary>
    [DataMember(Name = "newestVersion", EmitDefaultValue = false)]
    public EdgeVersionInformation NewestVersion { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EdgeVersionReport {\n");

        sb.Append("  OldestVersion: ").Append(OldestVersion).Append("\n");
        sb.Append("  NewestVersion: ").Append(NewestVersion).Append("\n");
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
        return Equals(obj as EdgeVersionReport);
    }

    /// <summary>
    /// Returns true if EdgeVersionReport instances are equal
    /// </summary>
    /// <param name="other">Instance of EdgeVersionReport to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EdgeVersionReport other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OldestVersion == other.OldestVersion ||
                OldestVersion != null &&
                OldestVersion.Equals(other.OldestVersion)
            ) &&
            (
                NewestVersion == other.NewestVersion ||
                NewestVersion != null &&
                NewestVersion.Equals(other.NewestVersion)
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
            if (OldestVersion != null)
            {
                hash = hash * 59 + OldestVersion.GetHashCode();
            }

            if (NewestVersion != null)
            {
                hash = hash * 59 + NewestVersion.GetHashCode();
            }

            return hash;
        }
    }
}
