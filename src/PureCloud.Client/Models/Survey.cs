using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Survey
/// </summary>

public partial class Survey : IEquatable<Survey>
{
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    
    public enum StatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Pending for "Pending"
        /// </summary>
        [EnumMember(Value = "Pending")]
        Pending,

        /// <summary>
        /// Enum Sent for "Sent"
        /// </summary>
        [EnumMember(Value = "Sent")]
        Sent,

        /// <summary>
        /// Enum Inprogress for "InProgress"
        /// </summary>
        [EnumMember(Value = "InProgress")]
        Inprogress,

        /// <summary>
        /// Enum Finished for "Finished"
        /// </summary>
        [EnumMember(Value = "Finished")]
        Finished,

        /// <summary>
        /// Enum Optout for "OptOut"
        /// </summary>
        [EnumMember(Value = "OptOut")]
        Optout,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Expired for "Expired"
        /// </summary>
        [EnumMember(Value = "Expired")]
        Expired
    }
    /// <summary>
    /// Type of the survey
    /// </summary>
    /// <value>Type of the survey</value>
    
    public enum SurveyTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Web for "Web"
        /// </summary>
        [EnumMember(Value = "Web")]
        Web,

        /// <summary>
        /// Enum Voice for "Voice"
        /// </summary>
        [EnumMember(Value = "Voice")]
        Voice
    }
    /// <summary>
    /// Gets or Sets Status
    /// </summary>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// Type of the survey
    /// </summary>
    /// <value>Type of the survey</value>
    [JsonPropertyName("surveyType")]
    public SurveyTypeEnum? SurveyType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Survey" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Conversation">Conversation.</param>
    /// <param name="SurveyForm">Survey form used for this survey..</param>
    /// <param name="Agent">Agent.</param>
    /// <param name="Status">Status.</param>
    /// <param name="Queue">Queue.</param>
    /// <param name="Answers">Answers.</param>
    /// <param name="CompletedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="SurveyErrorDetails">Additional information about what happened when the survey is in Error status..</param>
    /// <param name="AgentTeam">The team that the agent belongs to.</param>
    /// <param name="SurveyType">Type of the survey.</param>
    /// <param name="MissingRequiredAnswer">True if any of the required questions for the survey form have not been answered. Null if survey is not finished..</param>
    /// <param name="Flow">An Architect flow that executed in order to collect the answers for this survey..</param>
    public Survey(string Name = null, ConversationReference Conversation = null, SurveyForm SurveyForm = null, DomainEntityRef Agent = null, StatusEnum? Status = null, QueueReference Queue = null, SurveyScoringSet Answers = null, DateTime? CompletedDate = null, SurveyErrorDetails SurveyErrorDetails = null, Team AgentTeam = null, SurveyTypeEnum? SurveyType = null, bool? MissingRequiredAnswer = null, AddressableEntityRef Flow = null)
    {
        this.Name = Name;
        this.Conversation = Conversation;
        this.SurveyForm = SurveyForm;
        this.Agent = Agent;
        this.Status = Status;
        this.Queue = Queue;
        this.Answers = Answers;
        this.CompletedDate = CompletedDate;
        this.SurveyErrorDetails = SurveyErrorDetails;
        this.AgentTeam = AgentTeam;
        this.SurveyType = SurveyType;
        this.MissingRequiredAnswer = MissingRequiredAnswer;
        this.Flow = Flow;

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
    /// Gets or Sets Conversation
    /// </summary>
    [JsonPropertyName("conversation")]
    public ConversationReference Conversation { get; set; }



    /// <summary>
    /// Survey form used for this survey.
    /// </summary>
    /// <value>Survey form used for this survey.</value>
    [JsonPropertyName("surveyForm")]
    public SurveyForm SurveyForm { get; set; }



    /// <summary>
    /// Gets or Sets Agent
    /// </summary>
    [JsonPropertyName("agent")]
    public DomainEntityRef Agent { get; set; }





    /// <summary>
    /// Gets or Sets Queue
    /// </summary>
    [JsonPropertyName("queue")]
    public QueueReference Queue { get; set; }



    /// <summary>
    /// Gets or Sets Answers
    /// </summary>
    [JsonPropertyName("answers")]
    public SurveyScoringSet Answers { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("completedDate")]
    public DateTime? CompletedDate { get; set; }



    /// <summary>
    /// Additional information about what happened when the survey is in Error status.
    /// </summary>
    /// <value>Additional information about what happened when the survey is in Error status.</value>
    [JsonPropertyName("surveyErrorDetails")]
    public SurveyErrorDetails SurveyErrorDetails { get; set; }



    /// <summary>
    /// The team that the agent belongs to
    /// </summary>
    /// <value>The team that the agent belongs to</value>
    [JsonPropertyName("agentTeam")]
    public Team AgentTeam { get; set; }





    /// <summary>
    /// True if any of the required questions for the survey form have not been answered. Null if survey is not finished.
    /// </summary>
    /// <value>True if any of the required questions for the survey form have not been answered. Null if survey is not finished.</value>
    [JsonPropertyName("missingRequiredAnswer")]
    public bool? MissingRequiredAnswer { get; set; }



    /// <summary>
    /// An Architect flow that executed in order to collect the answers for this survey.
    /// </summary>
    /// <value>An Architect flow that executed in order to collect the answers for this survey.</value>
    [JsonPropertyName("flow")]
    public AddressableEntityRef Flow { get; set; }



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
        sb.Append("class Survey {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  SurveyForm: ").Append(SurveyForm).Append("\n");
        sb.Append("  Agent: ").Append(Agent).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  Answers: ").Append(Answers).Append("\n");
        sb.Append("  CompletedDate: ").Append(CompletedDate).Append("\n");
        sb.Append("  SurveyErrorDetails: ").Append(SurveyErrorDetails).Append("\n");
        sb.Append("  AgentTeam: ").Append(AgentTeam).Append("\n");
        sb.Append("  SurveyType: ").Append(SurveyType).Append("\n");
        sb.Append("  MissingRequiredAnswer: ").Append(MissingRequiredAnswer).Append("\n");
        sb.Append("  Flow: ").Append(Flow).Append("\n");
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
        return Equals(obj as Survey);
    }

    /// <summary>
    /// Returns true if Survey instances are equal
    /// </summary>
    /// <param name="other">Instance of Survey to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Survey other)
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
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                SurveyForm == other.SurveyForm ||
                SurveyForm != null &&
                SurveyForm.Equals(other.SurveyForm)
            ) &&
            (
                Agent == other.Agent ||
                Agent != null &&
                Agent.Equals(other.Agent)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                Answers == other.Answers ||
                Answers != null &&
                Answers.Equals(other.Answers)
            ) &&
            (
                CompletedDate == other.CompletedDate ||
                CompletedDate != null &&
                CompletedDate.Equals(other.CompletedDate)
            ) &&
            (
                SurveyErrorDetails == other.SurveyErrorDetails ||
                SurveyErrorDetails != null &&
                SurveyErrorDetails.Equals(other.SurveyErrorDetails)
            ) &&
            (
                AgentTeam == other.AgentTeam ||
                AgentTeam != null &&
                AgentTeam.Equals(other.AgentTeam)
            ) &&
            (
                SurveyType == other.SurveyType ||
                SurveyType != null &&
                SurveyType.Equals(other.SurveyType)
            ) &&
            (
                MissingRequiredAnswer == other.MissingRequiredAnswer ||
                MissingRequiredAnswer != null &&
                MissingRequiredAnswer.Equals(other.MissingRequiredAnswer)
            ) &&
            (
                Flow == other.Flow ||
                Flow != null &&
                Flow.Equals(other.Flow)
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

            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (SurveyForm != null)
            {
                hash = hash * 59 + SurveyForm.GetHashCode();
            }

            if (Agent != null)
            {
                hash = hash * 59 + Agent.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (Answers != null)
            {
                hash = hash * 59 + Answers.GetHashCode();
            }

            if (CompletedDate != null)
            {
                hash = hash * 59 + CompletedDate.GetHashCode();
            }

            if (SurveyErrorDetails != null)
            {
                hash = hash * 59 + SurveyErrorDetails.GetHashCode();
            }

            if (AgentTeam != null)
            {
                hash = hash * 59 + AgentTeam.GetHashCode();
            }

            if (SurveyType != null)
            {
                hash = hash * 59 + SurveyType.GetHashCode();
            }

            if (MissingRequiredAnswer != null)
            {
                hash = hash * 59 + MissingRequiredAnswer.GetHashCode();
            }

            if (Flow != null)
            {
                hash = hash * 59 + Flow.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
