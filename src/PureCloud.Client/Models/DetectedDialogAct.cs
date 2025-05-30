using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DetectedDialogAct
/// </summary>

public partial class DetectedDialogAct : IEquatable<DetectedDialogAct>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DetectedDialogAct" /> class.
    /// </summary>
    public DetectedDialogAct()
    {

    }



    /// <summary>
    /// The name of the detected dialog act.
    /// </summary>
    /// <value>The name of the detected dialog act.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The probability of the detected dialog act.
    /// </summary>
    /// <value>The probability of the detected dialog act.</value>
    [JsonPropertyName("probability")]
    public double? Probability { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DetectedDialogAct {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Probability: ").Append(Probability).Append("\n");
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
        return Equals(obj as DetectedDialogAct);
    }

    /// <summary>
    /// Returns true if DetectedDialogAct instances are equal
    /// </summary>
    /// <param name="other">Instance of DetectedDialogAct to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DetectedDialogAct other)
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

            return hash;
        }
    }
}
