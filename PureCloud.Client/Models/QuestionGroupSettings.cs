using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QuestionGroupSettings
/// </summary>

public partial class QuestionGroupSettings : IEquatable<QuestionGroupSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QuestionGroupSettings" /> class.
    /// </summary>
    /// <param name="QuestionGroupContextId">The context id of the question group in the form..</param>
    /// <param name="QuestionSettings">QuestionSettings.</param>
    public QuestionGroupSettings(string QuestionGroupContextId = null, List<QuestionSettings> QuestionSettings = null)
    {
        this.QuestionGroupContextId = QuestionGroupContextId;
        this.QuestionSettings = QuestionSettings;

    }



    /// <summary>
    /// The context id of the question group in the form.
    /// </summary>
    /// <value>The context id of the question group in the form.</value>
    [JsonPropertyName("questionGroupContextId")]
    public string QuestionGroupContextId { get; set; }



    /// <summary>
    /// Gets or Sets QuestionSettings
    /// </summary>
    [JsonPropertyName("questionSettings")]
    public List<QuestionSettings> QuestionSettings { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QuestionGroupSettings {\n");

        sb.Append("  QuestionGroupContextId: ").Append(QuestionGroupContextId).Append("\n");
        sb.Append("  QuestionSettings: ").Append(QuestionSettings).Append("\n");
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
        return Equals(obj as QuestionGroupSettings);
    }

    /// <summary>
    /// Returns true if QuestionGroupSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of QuestionGroupSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QuestionGroupSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                QuestionGroupContextId == other.QuestionGroupContextId ||
                QuestionGroupContextId != null &&
                QuestionGroupContextId.Equals(other.QuestionGroupContextId)
            ) &&
            (
                QuestionSettings == other.QuestionSettings ||
                QuestionSettings != null &&
                QuestionSettings.SequenceEqual(other.QuestionSettings)
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
            if (QuestionGroupContextId != null)
            {
                hash = hash * 59 + QuestionGroupContextId.GetHashCode();
            }

            if (QuestionSettings != null)
            {
                hash = hash * 59 + QuestionSettings.GetHashCode();
            }

            return hash;
        }
    }
}
