using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PredictiveRouting
/// </summary>

public partial class PredictiveRouting : IEquatable<PredictiveRouting>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PredictiveRouting" /> class.
    /// </summary>
    /// <param name="RespectSkills">A switch used to determine if agent skills will be considered..</param>
    /// <param name="EnableConversationScoreBiasing">A switch used to determine if conversations are weighted by conversation score when the system attempts to assign an agent a new conversation..</param>
    public PredictiveRouting(bool? RespectSkills = null, bool? EnableConversationScoreBiasing = null)
    {
        this.RespectSkills = RespectSkills;
        this.EnableConversationScoreBiasing = EnableConversationScoreBiasing;

    }



    /// <summary>
    /// A switch used to determine if agent skills will be considered.
    /// </summary>
    /// <value>A switch used to determine if agent skills will be considered.</value>
    [JsonPropertyName("respectSkills")]
    public bool? RespectSkills { get; set; }



    /// <summary>
    /// A switch used to determine if conversations are weighted by conversation score when the system attempts to assign an agent a new conversation.
    /// </summary>
    /// <value>A switch used to determine if conversations are weighted by conversation score when the system attempts to assign an agent a new conversation.</value>
    [JsonPropertyName("enableConversationScoreBiasing")]
    public bool? EnableConversationScoreBiasing { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PredictiveRouting {\n");

        sb.Append("  RespectSkills: ").Append(RespectSkills).Append("\n");
        sb.Append("  EnableConversationScoreBiasing: ").Append(EnableConversationScoreBiasing).Append("\n");
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
        return Equals(obj as PredictiveRouting);
    }

    /// <summary>
    /// Returns true if PredictiveRouting instances are equal
    /// </summary>
    /// <param name="other">Instance of PredictiveRouting to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PredictiveRouting other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                RespectSkills == other.RespectSkills ||
                RespectSkills != null &&
                RespectSkills.Equals(other.RespectSkills)
            ) &&
            (
                EnableConversationScoreBiasing == other.EnableConversationScoreBiasing ||
                EnableConversationScoreBiasing != null &&
                EnableConversationScoreBiasing.Equals(other.EnableConversationScoreBiasing)
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
            if (RespectSkills != null)
            {
                hash = hash * 59 + RespectSkills.GetHashCode();
            }

            if (EnableConversationScoreBiasing != null)
            {
                hash = hash * 59 + EnableConversationScoreBiasing.GetHashCode();
            }

            return hash;
        }
    }
}
