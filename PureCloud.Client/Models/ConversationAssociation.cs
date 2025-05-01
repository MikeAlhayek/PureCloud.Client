using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationAssociation
/// </summary>
[DataContract]
public partial class ConversationAssociation : IEquatable<ConversationAssociation>
{
    /// <summary>
    /// Media type
    /// </summary>
    /// <value>Media type</value>
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
        /// Enum Call for "CALL"
        /// </summary>
        [EnumMember(Value = "CALL")]
        Call,

        /// <summary>
        /// Enum Callback for "CALLBACK"
        /// </summary>
        [EnumMember(Value = "CALLBACK")]
        Callback,

        /// <summary>
        /// Enum Chat for "CHAT"
        /// </summary>
        [EnumMember(Value = "CHAT")]
        Chat,

        /// <summary>
        /// Enum Cobrowse for "COBROWSE"
        /// </summary>
        [EnumMember(Value = "COBROWSE")]
        Cobrowse,

        /// <summary>
        /// Enum Email for "EMAIL"
        /// </summary>
        [EnumMember(Value = "EMAIL")]
        Email,

        /// <summary>
        /// Enum Message for "MESSAGE"
        /// </summary>
        [EnumMember(Value = "MESSAGE")]
        Message,

        /// <summary>
        /// Enum InternalMessage for "INTERNAL_MESSAGE"
        /// </summary>
        [EnumMember(Value = "INTERNAL_MESSAGE")]
        InternalMessage,

        /// <summary>
        /// Enum SocialExpression for "SOCIAL_EXPRESSION"
        /// </summary>
        [EnumMember(Value = "SOCIAL_EXPRESSION")]
        SocialExpression,

        /// <summary>
        /// Enum Video for "VIDEO"
        /// </summary>
        [EnumMember(Value = "VIDEO")]
        Video,

        /// <summary>
        /// Enum Screenshare for "SCREENSHARE"
        /// </summary>
        [EnumMember(Value = "SCREENSHARE")]
        Screenshare
    }
    /// <summary>
    /// Media type
    /// </summary>
    /// <value>Media type</value>
    [DataMember(Name = "mediaType", EmitDefaultValue = false)]
    public MediaTypeEnum? MediaType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationAssociation" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationAssociation() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationAssociation" /> class.
    /// </summary>
    /// <param name="ExternalContactId">An external contact ID.  If not supplied, implies the conversation should be disassociated with any external contact..</param>
    /// <param name="ConversationId">Conversation ID (required).</param>
    /// <param name="CommunicationId">Communication ID (required).</param>
    /// <param name="MediaType">Media type (required).</param>
    public ConversationAssociation(string ExternalContactId = null, string ConversationId = null, string CommunicationId = null, MediaTypeEnum? MediaType = null)
    {
        this.ExternalContactId = ExternalContactId;
        this.ConversationId = ConversationId;
        this.CommunicationId = CommunicationId;
        this.MediaType = MediaType;

    }



    /// <summary>
    /// An external contact ID.  If not supplied, implies the conversation should be disassociated with any external contact.
    /// </summary>
    /// <value>An external contact ID.  If not supplied, implies the conversation should be disassociated with any external contact.</value>
    [DataMember(Name = "externalContactId", EmitDefaultValue = false)]
    public string ExternalContactId { get; set; }



    /// <summary>
    /// Conversation ID
    /// </summary>
    /// <value>Conversation ID</value>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public string ConversationId { get; set; }



    /// <summary>
    /// Communication ID
    /// </summary>
    /// <value>Communication ID</value>
    [DataMember(Name = "communicationId", EmitDefaultValue = false)]
    public string CommunicationId { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationAssociation {\n");

        sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  CommunicationId: ").Append(CommunicationId).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
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
        return Equals(obj as ConversationAssociation);
    }

    /// <summary>
    /// Returns true if ConversationAssociation instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationAssociation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationAssociation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ExternalContactId == other.ExternalContactId ||
                ExternalContactId != null &&
                ExternalContactId.Equals(other.ExternalContactId)
            ) &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                CommunicationId == other.CommunicationId ||
                CommunicationId != null &&
                CommunicationId.Equals(other.CommunicationId)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
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
            if (ExternalContactId != null)
            {
                hash = hash * 59 + ExternalContactId.GetHashCode();
            }

            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (CommunicationId != null)
            {
                hash = hash * 59 + CommunicationId.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            return hash;
        }
    }
}
