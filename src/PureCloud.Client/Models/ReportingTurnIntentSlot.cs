using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ReportingTurnIntentSlot
/// </summary>

public partial class ReportingTurnIntentSlot : IEquatable<ReportingTurnIntentSlot>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ReportingTurnIntentSlot" /> class.
    /// </summary>
    /// <param name="Name">The name of the slot..</param>
    /// <param name="Value">The value of the slot..</param>
    /// <param name="Type">The NLU entity type of the slot (either builtin or user defined).</param>
    /// <param name="Confidence">The confidence score this slot received during detection..</param>
    public ReportingTurnIntentSlot(string Name = null, string Value = null, string Type = null, double? Confidence = null)
    {
        this.Name = Name;
        this.Value = Value;
        this.Type = Type;
        this.Confidence = Confidence;

    }



    /// <summary>
    /// The name of the slot.
    /// </summary>
    /// <value>The name of the slot.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The value of the slot.
    /// </summary>
    /// <value>The value of the slot.</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }



    /// <summary>
    /// The NLU entity type of the slot (either builtin or user defined)
    /// </summary>
    /// <value>The NLU entity type of the slot (either builtin or user defined)</value>
    [JsonPropertyName("type")]
    public string Type { get; set; }



    /// <summary>
    /// The confidence score this slot received during detection.
    /// </summary>
    /// <value>The confidence score this slot received during detection.</value>
    [JsonPropertyName("confidence")]
    public double? Confidence { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ReportingTurnIntentSlot {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Confidence: ").Append(Confidence).Append("\n");
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
        return Equals(obj as ReportingTurnIntentSlot);
    }

    /// <summary>
    /// Returns true if ReportingTurnIntentSlot instances are equal
    /// </summary>
    /// <param name="other">Instance of ReportingTurnIntentSlot to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ReportingTurnIntentSlot other)
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
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Confidence == other.Confidence ||
                Confidence != null &&
                Confidence.Equals(other.Confidence)
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

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Confidence != null)
            {
                hash = hash * 59 + Confidence.GetHashCode();
            }

            return hash;
        }
    }
}
