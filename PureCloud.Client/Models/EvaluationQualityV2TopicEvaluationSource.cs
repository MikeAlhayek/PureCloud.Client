using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EvaluationQualityV2TopicEvaluationSource
/// </summary>

public partial class EvaluationQualityV2TopicEvaluationSource : IEquatable<EvaluationQualityV2TopicEvaluationSource>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EvaluationQualityV2TopicEvaluationSource" /> class.
    /// </summary>
    /// <param name="EvaluationSourceType">EvaluationSourceType.</param>
    /// <param name="EvaluationSourceId">EvaluationSourceId.</param>
    /// <param name="EvaluationSourceName">EvaluationSourceName.</param>
    public EvaluationQualityV2TopicEvaluationSource(string EvaluationSourceType = null, string EvaluationSourceId = null, string EvaluationSourceName = null)
    {
        this.EvaluationSourceType = EvaluationSourceType;
        this.EvaluationSourceId = EvaluationSourceId;
        this.EvaluationSourceName = EvaluationSourceName;

    }



    /// <summary>
    /// Gets or Sets EvaluationSourceType
    /// </summary>
    [JsonPropertyName("evaluationSourceType")]
    public string EvaluationSourceType { get; set; }



    /// <summary>
    /// Gets or Sets EvaluationSourceId
    /// </summary>
    [JsonPropertyName("evaluationSourceId")]
    public string EvaluationSourceId { get; set; }



    /// <summary>
    /// Gets or Sets EvaluationSourceName
    /// </summary>
    [JsonPropertyName("evaluationSourceName")]
    public string EvaluationSourceName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EvaluationQualityV2TopicEvaluationSource {\n");

        sb.Append("  EvaluationSourceType: ").Append(EvaluationSourceType).Append("\n");
        sb.Append("  EvaluationSourceId: ").Append(EvaluationSourceId).Append("\n");
        sb.Append("  EvaluationSourceName: ").Append(EvaluationSourceName).Append("\n");
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
        return Equals(obj as EvaluationQualityV2TopicEvaluationSource);
    }

    /// <summary>
    /// Returns true if EvaluationQualityV2TopicEvaluationSource instances are equal
    /// </summary>
    /// <param name="other">Instance of EvaluationQualityV2TopicEvaluationSource to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EvaluationQualityV2TopicEvaluationSource other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EvaluationSourceType == other.EvaluationSourceType ||
                EvaluationSourceType != null &&
                EvaluationSourceType.Equals(other.EvaluationSourceType)
            ) &&
            (
                EvaluationSourceId == other.EvaluationSourceId ||
                EvaluationSourceId != null &&
                EvaluationSourceId.Equals(other.EvaluationSourceId)
            ) &&
            (
                EvaluationSourceName == other.EvaluationSourceName ||
                EvaluationSourceName != null &&
                EvaluationSourceName.Equals(other.EvaluationSourceName)
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
            if (EvaluationSourceType != null)
            {
                hash = hash * 59 + EvaluationSourceType.GetHashCode();
            }

            if (EvaluationSourceId != null)
            {
                hash = hash * 59 + EvaluationSourceId.GetHashCode();
            }

            if (EvaluationSourceName != null)
            {
                hash = hash * 59 + EvaluationSourceName.GetHashCode();
            }

            return hash;
        }
    }
}
