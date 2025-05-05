using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeDocumentFeedbackUpdateRequest
/// </summary>

public partial class KnowledgeDocumentFeedbackUpdateRequest : IEquatable<KnowledgeDocumentFeedbackUpdateRequest>
{
    /// <summary>
    /// Feedback rating.
    /// </summary>
    /// <value>Feedback rating.</value>
    
    public enum RatingEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Negative for "Negative"
        /// </summary>
        [EnumMember(Value = "Negative")]
        Negative,

        /// <summary>
        /// Enum Positive for "Positive"
        /// </summary>
        [EnumMember(Value = "Positive")]
        Positive
    }
    /// <summary>
    /// Feedback reason
    /// </summary>
    /// <value>Feedback reason</value>
    
    public enum ReasonEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Documentcontent for "DocumentContent"
        /// </summary>
        [EnumMember(Value = "DocumentContent")]
        Documentcontent,

        /// <summary>
        /// Enum Searchresults for "SearchResults"
        /// </summary>
        [EnumMember(Value = "SearchResults")]
        Searchresults
    }
    /// <summary>
    /// Feedback state
    /// </summary>
    /// <value>Feedback state</value>
    
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Draft for "Draft"
        /// </summary>
        [EnumMember(Value = "Draft")]
        Draft,

        /// <summary>
        /// Enum Final for "Final"
        /// </summary>
        [EnumMember(Value = "Final")]
        Final
    }
    /// <summary>
    /// Feedback rating.
    /// </summary>
    /// <value>Feedback rating.</value>
    [JsonPropertyName("rating")]
    public RatingEnum? Rating { get; set; }
    /// <summary>
    /// Feedback reason
    /// </summary>
    /// <value>Feedback reason</value>
    [JsonPropertyName("reason")]
    public ReasonEnum? Reason { get; set; }
    /// <summary>
    /// Feedback state
    /// </summary>
    /// <value>Feedback state</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentFeedbackUpdateRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeDocumentFeedbackUpdateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeDocumentFeedbackUpdateRequest" /> class.
    /// </summary>
    /// <param name="Rating">Feedback rating. (required).</param>
    /// <param name="Reason">Feedback reason.</param>
    /// <param name="Comment">Feedback comment.</param>
    /// <param name="State">Feedback state.</param>
    public KnowledgeDocumentFeedbackUpdateRequest(RatingEnum? Rating = null, ReasonEnum? Reason = null, string Comment = null, StateEnum? State = null)
    {
        this.Rating = Rating;
        this.Reason = Reason;
        this.Comment = Comment;
        this.State = State;

    }







    /// <summary>
    /// Feedback comment
    /// </summary>
    /// <value>Feedback comment</value>
    [JsonPropertyName("comment")]
    public string Comment { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeDocumentFeedbackUpdateRequest {\n");

        sb.Append("  Rating: ").Append(Rating).Append("\n");
        sb.Append("  Reason: ").Append(Reason).Append("\n");
        sb.Append("  Comment: ").Append(Comment).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
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
        return Equals(obj as KnowledgeDocumentFeedbackUpdateRequest);
    }

    /// <summary>
    /// Returns true if KnowledgeDocumentFeedbackUpdateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeDocumentFeedbackUpdateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeDocumentFeedbackUpdateRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Rating == other.Rating ||
                Rating != null &&
                Rating.Equals(other.Rating)
            ) &&
            (
                Reason == other.Reason ||
                Reason != null &&
                Reason.Equals(other.Reason)
            ) &&
            (
                Comment == other.Comment ||
                Comment != null &&
                Comment.Equals(other.Comment)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
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
            if (Rating != null)
            {
                hash = hash * 59 + Rating.GetHashCode();
            }

            if (Reason != null)
            {
                hash = hash * 59 + Reason.GetHashCode();
            }

            if (Comment != null)
            {
                hash = hash * 59 + Comment.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            return hash;
        }
    }
}
