using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// Journey
/// </summary>
[DataContract]
public partial class Journey : IEquatable<Journey>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="Journey" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Journey() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Journey" /> class.
    /// </summary>
    /// <param name="Patterns">A list of zero or more patterns to match. (required).</param>
    public Journey(List<JourneyPattern> Patterns = null)
    {
        this.Patterns = Patterns;

    }



    /// <summary>
    /// A list of zero or more patterns to match.
    /// </summary>
    /// <value>A list of zero or more patterns to match.</value>
    [DataMember(Name = "patterns", EmitDefaultValue = false)]
    public List<JourneyPattern> Patterns { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Journey {\n");

        sb.Append("  Patterns: ").Append(Patterns).Append("\n");
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
        return this.Equals(obj as Journey);
    }

    /// <summary>
    /// Returns true if Journey instances are equal
    /// </summary>
    /// <param name="other">Instance of Journey to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Journey other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Patterns == other.Patterns ||
                this.Patterns != null &&
                this.Patterns.SequenceEqual(other.Patterns)
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
            if (this.Patterns != null)
            {
                hash = hash * 59 + this.Patterns.GetHashCode();
            }

            return hash;
        }
    }
}
