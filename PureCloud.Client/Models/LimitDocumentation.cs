using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LimitDocumentation
/// </summary>
[DataContract]
public partial class LimitDocumentation : IEquatable<LimitDocumentation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="LimitDocumentation" /> class.
    /// </summary>
    /// <param name="Url">Url.</param>
    /// <param name="Namespaces">Namespaces.</param>
    public LimitDocumentation(string Url = null, List<NamespaceDocs> Namespaces = null)
    {
        this.Url = Url;
        this.Namespaces = Namespaces;

    }



    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [DataMember(Name = "url", EmitDefaultValue = false)]
    public string Url { get; set; }



    /// <summary>
    /// Gets or Sets Namespaces
    /// </summary>
    [DataMember(Name = "namespaces", EmitDefaultValue = false)]
    public List<NamespaceDocs> Namespaces { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LimitDocumentation {\n");

        sb.Append("  Url: ").Append(Url).Append("\n");
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
        return Equals(obj as LimitDocumentation);
    }

    /// <summary>
    /// Returns true if LimitDocumentation instances are equal
    /// </summary>
    /// <param name="other">Instance of LimitDocumentation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LimitDocumentation other)
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
            ) &&
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
            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (Namespaces != null)
            {
                hash = hash * 59 + Namespaces.GetHashCode();
            }

            return hash;
        }
    }
}
