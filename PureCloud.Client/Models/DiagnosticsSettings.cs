using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DiagnosticsSettings
/// </summary>
[DataContract]
public partial class DiagnosticsSettings : IEquatable<DiagnosticsSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DiagnosticsSettings" /> class.
    /// </summary>
    public DiagnosticsSettings()
    {

    }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DiagnosticsSettings {\n");

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
        return Equals(obj as DiagnosticsSettings);
    }

    /// <summary>
    /// Returns true if DiagnosticsSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of DiagnosticsSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DiagnosticsSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true && false;
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
            return hash;
        }
    }
}
