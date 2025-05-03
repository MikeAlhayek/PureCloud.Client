using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DetectedIntent
/// </summary>

public partial class DetectedIntent : IEquatable<DetectedIntent>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DetectedIntent" /> class.
    /// </summary>
    public DetectedIntent()
    {

    }



    /// <summary>
    /// The name of the detected intent.
    /// </summary>
    /// <value>The name of the detected intent.</value>
    [JsonPropertyName("name")]
    public string Name { get; private set; }



    /// <summary>
    /// The probability of the detected intent.
    /// </summary>
    /// <value>The probability of the detected intent.</value>
    [JsonPropertyName("probability")]
    public double? Probability { get; private set; }



    /// <summary>
    /// The collection of named entities detected.
    /// </summary>
    /// <value>The collection of named entities detected.</value>
    [JsonPropertyName("entities")]
    public List<DetectedNamedEntity> Entities { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DetectedIntent {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Probability: ").Append(Probability).Append("\n");
        sb.Append("  Entities: ").Append(Entities).Append("\n");
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
        return Equals(obj as DetectedIntent);
    }

    /// <summary>
    /// Returns true if DetectedIntent instances are equal
    /// </summary>
    /// <param name="other">Instance of DetectedIntent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DetectedIntent other)
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
            ) &&
            (
                Probability == other.Probability ||
                Probability != null &&
                Probability.Equals(other.Probability)
            ) &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
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

            if (Probability != null)
            {
                hash = hash * 59 + Probability.GetHashCode();
            }

            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            return hash;
        }
    }
}
