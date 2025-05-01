using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// GamificationScorecardChangeTopicEvaluationDetail
/// </summary>
[DataContract]
public partial class GamificationScorecardChangeTopicEvaluationDetail : IEquatable<GamificationScorecardChangeTopicEvaluationDetail>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="GamificationScorecardChangeTopicEvaluationDetail" /> class.
    /// </summary>
    /// <param name="EvaluationId">EvaluationId.</param>
    /// <param name="ConversationId">ConversationId.</param>
    /// <param name="ConversationDate">ConversationDate.</param>
    /// <param name="FormName">FormName.</param>
    /// <param name="Points">Points.</param>
    /// <param name="MaxPoints">MaxPoints.</param>
    /// <param name="EvaluationScore">EvaluationScore.</param>
    /// <param name="EvaluationScoreDouble">EvaluationScoreDouble.</param>
    /// <param name="MediaTypes">MediaTypes.</param>
    public GamificationScorecardChangeTopicEvaluationDetail(Guid? EvaluationId = null, Guid? ConversationId = null, string ConversationDate = null, string FormName = null, long? Points = null, long? MaxPoints = null, long? EvaluationScore = null, double? EvaluationScoreDouble = null, List<string> MediaTypes = null)
    {
        this.EvaluationId = EvaluationId;
        this.ConversationId = ConversationId;
        this.ConversationDate = ConversationDate;
        this.FormName = FormName;
        this.Points = Points;
        this.MaxPoints = MaxPoints;
        this.EvaluationScore = EvaluationScore;
        this.EvaluationScoreDouble = EvaluationScoreDouble;
        this.MediaTypes = MediaTypes;

    }



    /// <summary>
    /// Gets or Sets EvaluationId
    /// </summary>
    [DataMember(Name = "evaluationId", EmitDefaultValue = false)]
    public Guid? EvaluationId { get; set; }



    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public Guid? ConversationId { get; set; }



    /// <summary>
    /// Gets or Sets ConversationDate
    /// </summary>
    [DataMember(Name = "conversationDate", EmitDefaultValue = false)]
    public string ConversationDate { get; set; }



    /// <summary>
    /// Gets or Sets FormName
    /// </summary>
    [DataMember(Name = "formName", EmitDefaultValue = false)]
    public string FormName { get; set; }



    /// <summary>
    /// Gets or Sets Points
    /// </summary>
    [DataMember(Name = "points", EmitDefaultValue = false)]
    public long? Points { get; set; }



    /// <summary>
    /// Gets or Sets MaxPoints
    /// </summary>
    [DataMember(Name = "maxPoints", EmitDefaultValue = false)]
    public long? MaxPoints { get; set; }



    /// <summary>
    /// Gets or Sets EvaluationScore
    /// </summary>
    [DataMember(Name = "evaluationScore", EmitDefaultValue = false)]
    public long? EvaluationScore { get; set; }



    /// <summary>
    /// Gets or Sets EvaluationScoreDouble
    /// </summary>
    [DataMember(Name = "evaluationScoreDouble", EmitDefaultValue = false)]
    public double? EvaluationScoreDouble { get; set; }



    /// <summary>
    /// Gets or Sets MediaTypes
    /// </summary>
    [DataMember(Name = "mediaTypes", EmitDefaultValue = false)]
    public List<string> MediaTypes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GamificationScorecardChangeTopicEvaluationDetail {\n");

        sb.Append("  EvaluationId: ").Append(EvaluationId).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  ConversationDate: ").Append(ConversationDate).Append("\n");
        sb.Append("  FormName: ").Append(FormName).Append("\n");
        sb.Append("  Points: ").Append(Points).Append("\n");
        sb.Append("  MaxPoints: ").Append(MaxPoints).Append("\n");
        sb.Append("  EvaluationScore: ").Append(EvaluationScore).Append("\n");
        sb.Append("  EvaluationScoreDouble: ").Append(EvaluationScoreDouble).Append("\n");
        sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
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
        return Equals(obj as GamificationScorecardChangeTopicEvaluationDetail);
    }

    /// <summary>
    /// Returns true if GamificationScorecardChangeTopicEvaluationDetail instances are equal
    /// </summary>
    /// <param name="other">Instance of GamificationScorecardChangeTopicEvaluationDetail to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GamificationScorecardChangeTopicEvaluationDetail other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EvaluationId == other.EvaluationId ||
                EvaluationId != null &&
                EvaluationId.Equals(other.EvaluationId)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                ConversationDate == other.ConversationDate ||
                ConversationDate != null &&
                ConversationDate.Equals(other.ConversationDate)
            ) &&
            (
                FormName == other.FormName ||
                FormName != null &&
                FormName.Equals(other.FormName)
            ) &&
            (
                Points == other.Points ||
                Points != null &&
                Points.Equals(other.Points)
            ) &&
            (
                MaxPoints == other.MaxPoints ||
                MaxPoints != null &&
                MaxPoints.Equals(other.MaxPoints)
            ) &&
            (
                EvaluationScore == other.EvaluationScore ||
                EvaluationScore != null &&
                EvaluationScore.Equals(other.EvaluationScore)
            ) &&
            (
                EvaluationScoreDouble == other.EvaluationScoreDouble ||
                EvaluationScoreDouble != null &&
                EvaluationScoreDouble.Equals(other.EvaluationScoreDouble)
            ) &&
            (
                MediaTypes == other.MediaTypes ||
                MediaTypes != null &&
                MediaTypes.SequenceEqual(other.MediaTypes)
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
            if (EvaluationId != null)
            {
                hash = hash * 59 + EvaluationId.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (ConversationDate != null)
            {
                hash = hash * 59 + ConversationDate.GetHashCode();
            }

            if (FormName != null)
            {
                hash = hash * 59 + FormName.GetHashCode();
            }

            if (Points != null)
            {
                hash = hash * 59 + Points.GetHashCode();
            }

            if (MaxPoints != null)
            {
                hash = hash * 59 + MaxPoints.GetHashCode();
            }

            if (EvaluationScore != null)
            {
                hash = hash * 59 + EvaluationScore.GetHashCode();
            }

            if (EvaluationScoreDouble != null)
            {
                hash = hash * 59 + EvaluationScoreDouble.GetHashCode();
            }

            if (MediaTypes != null)
            {
                hash = hash * 59 + MediaTypes.GetHashCode();
            }

            return hash;
        }
    }
}
