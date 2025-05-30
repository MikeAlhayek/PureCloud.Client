using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// TouchpointResponse
/// </summary>

public partial class TouchpointResponse : IEquatable<TouchpointResponse>
{
    /// <summary>
    /// Media Type of the touchpoint; allowed values are Email, Message and Voice.
    /// </summary>
    /// <value>Media Type of the touchpoint; allowed values are Email, Message and Voice.</value>
    
    public enum MediaTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Email for "Email"
        /// </summary>
        [EnumMember(Value = "Email")]
        Email,

        /// <summary>
        /// Enum Message for "Message"
        /// </summary>
        [EnumMember(Value = "Message")]
        Message,

        /// <summary>
        /// Enum Voice for "Voice"
        /// </summary>
        [EnumMember(Value = "Voice")]
        Voice
    }
    /// <summary>
    /// Outcome Attribution Touchpoint status.
    /// </summary>
    /// <value>Outcome Attribution Touchpoint status.</value>
    
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
        /// Enum Completed for "Completed"
        /// </summary>
        [EnumMember(Value = "Completed")]
        Completed,

        /// <summary>
        /// Enum Valid for "Valid"
        /// </summary>
        [EnumMember(Value = "Valid")]
        Valid,

        /// <summary>
        /// Enum Invalid for "Invalid"
        /// </summary>
        [EnumMember(Value = "Invalid")]
        Invalid,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
    /// <summary>
    /// Media Type of the touchpoint; allowed values are Email, Message and Voice.
    /// </summary>
    /// <value>Media Type of the touchpoint; allowed values are Email, Message and Voice.</value>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Outcome Attribution Touchpoint status.
    /// </summary>
    /// <value>Outcome Attribution Touchpoint status.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TouchpointResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TouchpointResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TouchpointResponse" /> class.
    /// </summary>
    /// <param name="ConversationId">ID of conversation..</param>
    /// <param name="AgentId">ID of agent. (required).</param>
    /// <param name="AssociatedValue">The value attributed to this touchpoint. (required).</param>
    /// <param name="MediaType">Media Type of the touchpoint; allowed values are Email, Message and Voice..</param>
    /// <param name="State">Outcome Attribution Touchpoint status. (required).</param>
    /// <param name="Message">Additional information on the state of the touchpoint entity, populated when the touchpoint has an error..</param>
    /// <param name="CreatedDate">Date conversation happened. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public TouchpointResponse(string ConversationId = null, string AgentId = null, double? AssociatedValue = null, MediaTypeEnum? MediaType = null, StateEnum? State = null, string Message = null, DateTime? CreatedDate = null)
    {
        this.ConversationId = ConversationId;
        this.AgentId = AgentId;
        this.AssociatedValue = AssociatedValue;
        this.MediaType = MediaType;
        this.State = State;
        this.Message = Message;
        this.CreatedDate = CreatedDate;

    }



    /// <summary>
    /// ID of conversation.
    /// </summary>
    /// <value>ID of conversation.</value>
    [JsonPropertyName("conversationId")]
    public string ConversationId { get; set; }



    /// <summary>
    /// ID of agent.
    /// </summary>
    /// <value>ID of agent.</value>
    [JsonPropertyName("agentId")]
    public string AgentId { get; set; }



    /// <summary>
    /// The value attributed to this touchpoint.
    /// </summary>
    /// <value>The value attributed to this touchpoint.</value>
    [JsonPropertyName("associatedValue")]
    public double? AssociatedValue { get; set; }







    /// <summary>
    /// Additional information on the state of the touchpoint entity, populated when the touchpoint has an error.
    /// </summary>
    /// <value>Additional information on the state of the touchpoint entity, populated when the touchpoint has an error.</value>
    [JsonPropertyName("message")]
    public string Message { get; set; }



    /// <summary>
    /// Date conversation happened. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date conversation happened. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TouchpointResponse {\n");

        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  AgentId: ").Append(AgentId).Append("\n");
        sb.Append("  AssociatedValue: ").Append(AssociatedValue).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
        return Equals(obj as TouchpointResponse);
    }

    /// <summary>
    /// Returns true if TouchpointResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of TouchpointResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TouchpointResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                AgentId == other.AgentId ||
                AgentId != null &&
                AgentId.Equals(other.AgentId)
            ) &&
            (
                AssociatedValue == other.AssociatedValue ||
                AssociatedValue != null &&
                AssociatedValue.Equals(other.AssociatedValue)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
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
            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (AgentId != null)
            {
                hash = hash * 59 + AgentId.GetHashCode();
            }

            if (AssociatedValue != null)
            {
                hash = hash * 59 + AssociatedValue.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            return hash;
        }
    }
}
