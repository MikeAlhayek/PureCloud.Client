using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

/// <summary>
/// CalibrationCreate
/// </summary>
public sealed class CalibrationCreate
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CalibrationCreate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CalibrationCreate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CalibrationCreate" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Calibrator">Calibrator.</param>
    /// <param name="Agent">Agent.</param>
    /// <param name="Conversation">The conversation to use for the calibration. (required).</param>
    /// <param name="EvaluationForm">EvaluationForm.</param>
    /// <param name="ContextId">ContextId.</param>
    /// <param name="AverageScore">AverageScore.</param>
    /// <param name="HighScore">HighScore.</param>
    /// <param name="LowScore">LowScore.</param>
    /// <param name="CreatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Evaluations">Evaluations.</param>
    /// <param name="Evaluators">Evaluators.</param>
    /// <param name="ScoringIndex">ScoringIndex.</param>
    /// <param name="ExpertEvaluator">ExpertEvaluator.</param>
    public CalibrationCreate(string Name = null, User Calibrator = null, User Agent = null, ConversationReference Conversation = null, EvaluationForm EvaluationForm = null, string ContextId = null, int? AverageScore = null, int? HighScore = null, int? LowScore = null, DateTime? CreatedDate = null, List<Evaluation> Evaluations = null, List<User> Evaluators = null, Evaluation ScoringIndex = null, User ExpertEvaluator = null)
    {
        this.Name = Name;
        this.Calibrator = Calibrator;
        this.Agent = Agent;
        this.Conversation = Conversation;
        this.EvaluationForm = EvaluationForm;
        this.ContextId = ContextId;
        this.AverageScore = AverageScore;
        this.HighScore = HighScore;
        this.LowScore = LowScore;
        this.CreatedDate = CreatedDate;
        this.Evaluations = Evaluations;
        this.Evaluators = Evaluators;
        this.ScoringIndex = ScoringIndex;
        this.ExpertEvaluator = ExpertEvaluator;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Calibrator
    /// </summary>
    [JsonPropertyName("calibrator")]
    public User Calibrator { get; set; }



    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    [JsonPropertyName("agent")]
    public User Agent { get; set; }



    /// <summary>
    /// The conversation to use for the calibration.
    /// </summary>
    /// <value>The conversation to use for the calibration.</value>
    [JsonPropertyName("conversation")]
    public ConversationReference Conversation { get; set; }



    /// <summary>
    /// Gets or Sets EvaluationForm
    /// </summary>
    [JsonPropertyName("evaluationForm")]
    public EvaluationForm EvaluationForm { get; set; }



    /// <summary>
    /// Gets or Sets ContextId
    /// </summary>
    [JsonPropertyName("contextId")]
    public string ContextId { get; set; }



    /// <summary>
    /// Gets or Sets AverageScore
    /// </summary>
    [JsonPropertyName("averageScore")]
    public int? AverageScore { get; set; }



    /// <summary>
    /// Gets or Sets HighScore
    /// </summary>
    [JsonPropertyName("highScore")]
    public int? HighScore { get; set; }



    /// <summary>
    /// Gets or Sets LowScore
    /// </summary>
    [JsonPropertyName("lowScore")]
    public int? LowScore { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }



    /// <summary>
    /// Gets or Sets Evaluations
    /// </summary>
    [JsonPropertyName("evaluations")]
    public List<Evaluation> Evaluations { get; set; }



    /// <summary>
    /// Gets or Sets Evaluators
    /// </summary>
    [JsonPropertyName("evaluators")]
    public List<User> Evaluators { get; set; }



    /// <summary>
    /// Gets or Sets ScoringIndex
    /// </summary>
    [JsonPropertyName("scoringIndex")]
    public Evaluation ScoringIndex { get; set; }



    /// <summary>
    /// Gets or Sets ExpertEvaluator
    /// </summary>
    [JsonPropertyName("expertEvaluator")]
    public User ExpertEvaluator { get; set; }



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
        sb.Append("class CalibrationCreate {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Calibrator: ").Append(Calibrator).Append("\n");
        sb.Append("  Agent: ").Append(Agent).Append("\n");
        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  EvaluationForm: ").Append(EvaluationForm).Append("\n");
        sb.Append("  ContextId: ").Append(ContextId).Append("\n");
        sb.Append("  AverageScore: ").Append(AverageScore).Append("\n");
        sb.Append("  HighScore: ").Append(HighScore).Append("\n");
        sb.Append("  LowScore: ").Append(LowScore).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  Evaluations: ").Append(Evaluations).Append("\n");
        sb.Append("  Evaluators: ").Append(Evaluators).Append("\n");
        sb.Append("  ScoringIndex: ").Append(ScoringIndex).Append("\n");
        sb.Append("  ExpertEvaluator: ").Append(ExpertEvaluator).Append("\n");
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
        return Equals(obj as CalibrationCreate);
    }

    /// <summary>
    /// Returns true if CalibrationCreate instances are equal
    /// </summary>
    /// <param name="other">Instance of CalibrationCreate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CalibrationCreate other)
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
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Calibrator == other.Calibrator ||
                Calibrator != null &&
                Calibrator.Equals(other.Calibrator)
            ) &&
            (
                Agent == other.Agent ||
                Agent != null &&
                Agent.Equals(other.Agent)
            ) &&
            (
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                EvaluationForm == other.EvaluationForm ||
                EvaluationForm != null &&
                EvaluationForm.Equals(other.EvaluationForm)
            ) &&
            (
                ContextId == other.ContextId ||
                ContextId != null &&
                ContextId.Equals(other.ContextId)
            ) &&
            (
                AverageScore == other.AverageScore ||
                AverageScore != null &&
                AverageScore.Equals(other.AverageScore)
            ) &&
            (
                HighScore == other.HighScore ||
                HighScore != null &&
                HighScore.Equals(other.HighScore)
            ) &&
            (
                LowScore == other.LowScore ||
                LowScore != null &&
                LowScore.Equals(other.LowScore)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                Evaluations == other.Evaluations ||
                Evaluations != null &&
                Evaluations.SequenceEqual(other.Evaluations)
            ) &&
            (
                Evaluators == other.Evaluators ||
                Evaluators != null &&
                Evaluators.SequenceEqual(other.Evaluators)
            ) &&
            (
                ScoringIndex == other.ScoringIndex ||
                ScoringIndex != null &&
                ScoringIndex.Equals(other.ScoringIndex)
            ) &&
            (
                ExpertEvaluator == other.ExpertEvaluator ||
                ExpertEvaluator != null &&
                ExpertEvaluator.Equals(other.ExpertEvaluator)
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

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Calibrator != null)
            {
                hash = hash * 59 + Calibrator.GetHashCode();
            }

            if (Agent != null)
            {
                hash = hash * 59 + Agent.GetHashCode();
            }

            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (EvaluationForm != null)
            {
                hash = hash * 59 + EvaluationForm.GetHashCode();
            }

            if (ContextId != null)
            {
                hash = hash * 59 + ContextId.GetHashCode();
            }

            if (AverageScore != null)
            {
                hash = hash * 59 + AverageScore.GetHashCode();
            }

            if (HighScore != null)
            {
                hash = hash * 59 + HighScore.GetHashCode();
            }

            if (LowScore != null)
            {
                hash = hash * 59 + LowScore.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (Evaluations != null)
            {
                hash = hash * 59 + Evaluations.GetHashCode();
            }

            if (Evaluators != null)
            {
                hash = hash * 59 + Evaluators.GetHashCode();
            }

            if (ScoringIndex != null)
            {
                hash = hash * 59 + ScoringIndex.GetHashCode();
            }

            if (ExpertEvaluator != null)
            {
                hash = hash * 59 + ExpertEvaluator.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
