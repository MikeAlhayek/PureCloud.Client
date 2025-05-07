using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AiScoringSettings
/// </summary>

public partial class AiScoringSettings : IEquatable<AiScoringSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="AiScoringSettings" /> class.
    /// </summary>
    /// <param name="QuestionGroupSettings">QuestionGroupSettings.</param>
    public AiScoringSettings(List<QuestionGroupSettings> QuestionGroupSettings = null)
    {
        this.QuestionGroupSettings = QuestionGroupSettings;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets QuestionGroupSettings
    /// </summary>
    [JsonPropertyName("questionGroupSettings")]
    public List<QuestionGroupSettings> QuestionGroupSettings { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AiScoringSettings {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  QuestionGroupSettings: ").Append(QuestionGroupSettings).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as AiScoringSettings);
    }

    /// <summary>
    /// Returns true if AiScoringSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of AiScoringSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AiScoringSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                QuestionGroupSettings == other.QuestionGroupSettings ||
                QuestionGroupSettings != null &&
                QuestionGroupSettings.SequenceEqual(other.QuestionGroupSettings)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (QuestionGroupSettings != null)
            {
                hash = hash * 59 + QuestionGroupSettings.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
