using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FreeTrialLimitDocs
/// </summary>

public partial class FreeTrialLimitDocs : IEquatable<FreeTrialLimitDocs>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="FreeTrialLimitDocs" /> class.
    /// </summary>
    /// <param name="Namespaces">Namespaces.</param>
    public FreeTrialLimitDocs(List<FreeTrialNamespace> Namespaces = null)
    {
        this.Namespaces = Namespaces;

    }



    /// <summary>
    /// Gets or Sets Namespaces
    /// </summary>
    [JsonPropertyName("namespaces")]
    public List<FreeTrialNamespace> Namespaces { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FreeTrialLimitDocs {\n");

        sb.Append("  Namespaces: ").Append(Namespaces).Append("\n");
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
        return Equals(obj as FreeTrialLimitDocs);
    }

    /// <summary>
    /// Returns true if FreeTrialLimitDocs instances are equal
    /// </summary>
    /// <param name="other">Instance of FreeTrialLimitDocs to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FreeTrialLimitDocs other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Namespaces == other.Namespaces ||
                Namespaces != null &&
                Namespaces.SequenceEqual(other.Namespaces)
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
            if (Namespaces != null)
            {
                hash = hash * 59 + Namespaces.GetHashCode();
            }

            return hash;
        }
    }
}
