using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Utterance
/// </summary>

public partial class Utterance : IEquatable<Utterance>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="Utterance" /> class.
    /// </summary>
    /// <param name="UtteranceText">Utterance text.</param>
    public Utterance(string UtteranceText = null)
    {
        this.UtteranceText = UtteranceText;

    }



    /// <summary>
    /// Utterance text
    /// </summary>
    /// <value>Utterance text</value>
    [JsonPropertyName("utteranceText")]
    public string UtteranceText { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Utterance {\n");

        sb.Append("  UtteranceText: ").Append(UtteranceText).Append("\n");
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
        return Equals(obj as Utterance);
    }

    /// <summary>
    /// Returns true if Utterance instances are equal
    /// </summary>
    /// <param name="other">Instance of Utterance to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Utterance other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UtteranceText == other.UtteranceText ||
                UtteranceText != null &&
                UtteranceText.Equals(other.UtteranceText)
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
            if (UtteranceText != null)
            {
                hash = hash * 59 + UtteranceText.GetHashCode();
            }

            return hash;
        }
    }
}
