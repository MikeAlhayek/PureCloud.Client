using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DetectedNamedEntity
/// </summary>

public partial class DetectedNamedEntity : IEquatable<DetectedNamedEntity>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DetectedNamedEntity" /> class.
    /// </summary>
    public DetectedNamedEntity()
    {

    }



    /// <summary>
    /// The name of the detected named entity.
    /// </summary>
    /// <value>The name of the detected named entity.</value>
    [JsonPropertyName("name")]
    public string Name { get; private set; }



    /// <summary>
    /// The type of the detected named entity.
    /// </summary>
    /// <value>The type of the detected named entity.</value>
    [JsonPropertyName("entityType")]
    public string EntityType { get; private set; }



    /// <summary>
    /// The probability of the detected named entity.
    /// </summary>
    /// <value>The probability of the detected named entity.</value>
    [JsonPropertyName("probability")]
    public double? Probability { get; private set; }



    /// <summary>
    /// The value of the detected named entity.
    /// </summary>
    /// <value>The value of the detected named entity.</value>
    [JsonPropertyName("value")]
    public DetectedNamedEntityValue Value { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DetectedNamedEntity {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  EntityType: ").Append(EntityType).Append("\n");
        sb.Append("  Probability: ").Append(Probability).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as DetectedNamedEntity);
    }

    /// <summary>
    /// Returns true if DetectedNamedEntity instances are equal
    /// </summary>
    /// <param name="other">Instance of DetectedNamedEntity to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DetectedNamedEntity other)
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
                EntityType == other.EntityType ||
                EntityType != null &&
                EntityType.Equals(other.EntityType)
            ) &&
            (
                Probability == other.Probability ||
                Probability != null &&
                Probability.Equals(other.Probability)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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

            if (EntityType != null)
            {
                hash = hash * 59 + EntityType.GetHashCode();
            }

            if (Probability != null)
            {
                hash = hash * 59 + Probability.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
