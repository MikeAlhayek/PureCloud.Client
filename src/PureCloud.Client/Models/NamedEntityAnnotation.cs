using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NamedEntityAnnotation
/// </summary>

public partial class NamedEntityAnnotation : IEquatable<NamedEntityAnnotation>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NamedEntityAnnotation" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NamedEntityAnnotation() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NamedEntityAnnotation" /> class.
    /// </summary>
    /// <param name="Name">The name of the annotated named entity. (required).</param>
    public NamedEntityAnnotation(string Name = null)
    {
        this.Name = Name;

    }



    /// <summary>
    /// The name of the annotated named entity.
    /// </summary>
    /// <value>The name of the annotated named entity.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NamedEntityAnnotation {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return Equals(obj as NamedEntityAnnotation);
    }

    /// <summary>
    /// Returns true if NamedEntityAnnotation instances are equal
    /// </summary>
    /// <param name="other">Instance of NamedEntityAnnotation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NamedEntityAnnotation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            return hash;
        }
    }
}
