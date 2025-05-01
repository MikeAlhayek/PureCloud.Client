using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SuggestionContext
/// </summary>
[DataContract]
public partial class SuggestionContext : IEquatable<SuggestionContext>
{
    /// <summary>
    /// The media type of the conversation in which the suggestion event was raised.
    /// </summary>
    /// <value>The media type of the conversation in which the suggestion event was raised.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Message for "Message"
        /// </summary>
        [EnumMember(Value = "Message")]
        Message,

        /// <summary>
        /// Enum Voice for "Voice"
        /// </summary>
        [EnumMember(Value = "Voice")]
        Voice,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// The media type of the conversation in which the suggestion event was raised.
    /// </summary>
    /// <value>The media type of the conversation in which the suggestion event was raised.</value>
    [DataMember(Name = "mediaType", EmitDefaultValue = false)]
    public MediaTypeEnum? MediaType { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SuggestionContext" /> class.
    /// </summary>
    public SuggestionContext()
    {

    }



    /// <summary>
    /// The queue used to assign the interaction to the user, if any.
    /// </summary>
    /// <value>The queue used to assign the interaction to the user, if any.</value>
    [DataMember(Name = "queue", EmitDefaultValue = false)]
    public AddressableEntityRef Queue { get; private set; }





    /// <summary>
    /// The agent participant who received the raised suggestion, if any.
    /// </summary>
    /// <value>The agent participant who received the raised suggestion, if any.</value>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public UserReference User { get; private set; }



    /// <summary>
    /// The external contact of the end-user participant, if any.
    /// </summary>
    /// <value>The external contact of the end-user participant, if any.</value>
    [DataMember(Name = "externalContact", EmitDefaultValue = false)]
    public AddressableEntityRef ExternalContact { get; private set; }



    /// <summary>
    /// The utterance in the voice conversation, after which the suggestion was raised, if any.
    /// </summary>
    /// <value>The utterance in the voice conversation, after which the suggestion was raised, if any.</value>
    [DataMember(Name = "utterance", EmitDefaultValue = false)]
    public Entity Utterance { get; private set; }



    /// <summary>
    /// The message in the digital conversation, after which the suggestion was raised, if any.
    /// </summary>
    /// <value>The message in the digital conversation, after which the suggestion was raised, if any.</value>
    [DataMember(Name = "message", EmitDefaultValue = false)]
    public AddressableEntityRef Message { get; private set; }



    /// <summary>
    /// The query statement used when generating the suggestion, if any.
    /// </summary>
    /// <value>The query statement used when generating the suggestion, if any.</value>
    [DataMember(Name = "queryStatement", EmitDefaultValue = false)]
    public string QueryStatement { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SuggestionContext {\n");

        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  ExternalContact: ").Append(ExternalContact).Append("\n");
        sb.Append("  Utterance: ").Append(Utterance).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
        sb.Append("  QueryStatement: ").Append(QueryStatement).Append("\n");
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
        return Equals(obj as SuggestionContext);
    }

    /// <summary>
    /// Returns true if SuggestionContext instances are equal
    /// </summary>
    /// <param name="other">Instance of SuggestionContext to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SuggestionContext other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                ExternalContact == other.ExternalContact ||
                ExternalContact != null &&
                ExternalContact.Equals(other.ExternalContact)
            ) &&
            (
                Utterance == other.Utterance ||
                Utterance != null &&
                Utterance.Equals(other.Utterance)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
            ) &&
            (
                QueryStatement == other.QueryStatement ||
                QueryStatement != null &&
                QueryStatement.Equals(other.QueryStatement)
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
            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (ExternalContact != null)
            {
                hash = hash * 59 + ExternalContact.GetHashCode();
            }

            if (Utterance != null)
            {
                hash = hash * 59 + Utterance.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            if (QueryStatement != null)
            {
                hash = hash * 59 + QueryStatement.GetHashCode();
            }

            return hash;
        }
    }
}
