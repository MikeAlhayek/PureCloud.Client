using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConfusionDetails
/// </summary>

public partial class ConfusionDetails : IEquatable<ConfusionDetails>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ConfusionDetails" /> class.
    /// </summary>
    /// <param name="Intents">Confusion details between this utterance and other intents..</param>
    public ConfusionDetails(List<ConfusionIntentDetails> Intents = null)
    {
        this.Intents = Intents;

    }



    /// <summary>
    /// Confusion details between this utterance and other intents.
    /// </summary>
    /// <value>Confusion details between this utterance and other intents.</value>
    [JsonPropertyName("intents")]
    public List<ConfusionIntentDetails> Intents { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConfusionDetails {\n");

        sb.Append("  Intents: ").Append(Intents).Append("\n");
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
        return Equals(obj as ConfusionDetails);
    }

    /// <summary>
    /// Returns true if ConfusionDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of ConfusionDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConfusionDetails other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Intents == other.Intents ||
                Intents != null &&
                Intents.SequenceEqual(other.Intents)
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
            if (Intents != null)
            {
                hash = hash * 59 + Intents.GetHashCode();
            }

            return hash;
        }
    }
}
