using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A web messaging message
/// </summary>

public partial class WebMessagingMessage : IEquatable<WebMessagingMessage>
{
    /// <summary>
    /// Message type.
    /// </summary>
    /// <value>Message type.</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Text for "Text"
        /// </summary>
        [EnumMember(Value = "Text")]
        Text,

        /// <summary>
        /// Enum Structured for "Structured"
        /// </summary>
        [EnumMember(Value = "Structured")]
        Structured,

        /// <summary>
        /// Enum Receipt for "Receipt"
        /// </summary>
        [EnumMember(Value = "Receipt")]
        Receipt,

        /// <summary>
        /// Enum Event for "Event"
        /// </summary>
        [EnumMember(Value = "Event")]
        Event
    }
    /// <summary>
    /// Message receipt status, only used with type Receipt.
    /// </summary>
    /// <value>Message receipt status, only used with type Receipt.</value>
    
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
        /// Enum Sent for "Sent"
        /// </summary>
        [EnumMember(Value = "Sent")]
        Sent,

        /// <summary>
        /// Enum Delivered for "Delivered"
        /// </summary>
        [EnumMember(Value = "Delivered")]
        Delivered,

        /// <summary>
        /// Enum Read for "Read"
        /// </summary>
        [EnumMember(Value = "Read")]
        Read,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Published for "Published"
        /// </summary>
        [EnumMember(Value = "Published")]
        Published,

        /// <summary>
        /// Enum Removed for "Removed"
        /// </summary>
        [EnumMember(Value = "Removed")]
        Removed
    }
    /// <summary>
    /// The direction of the message.  Direction is always from the perspective of the Genesys Cloud platform.  An Inbound message is one sent from a guest to the Genesys Cloud Platform.  An Outbound message is one sent from the Genesys Cloud Platform to a guest.
    /// </summary>
    /// <value>The direction of the message.  Direction is always from the perspective of the Genesys Cloud platform.  An Inbound message is one sent from a guest to the Genesys Cloud Platform.  An Outbound message is one sent from the Genesys Cloud Platform to a guest.</value>
    
    public enum DirectionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Inbound for "Inbound"
        /// </summary>
        [EnumMember(Value = "Inbound")]
        Inbound,

        /// <summary>
        /// Enum Outbound for "Outbound"
        /// </summary>
        [EnumMember(Value = "Outbound")]
        Outbound
    }
    /// <summary>
    /// Specifies if this message was sent by a human agent or bot. The platform may use this to apply appropriate provider policies.
    /// </summary>
    /// <value>Specifies if this message was sent by a human agent or bot. The platform may use this to apply appropriate provider policies.</value>
    
    public enum OriginatingEntityEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Human for "Human"
        /// </summary>
        [EnumMember(Value = "Human")]
        Human,

        /// <summary>
        /// Enum Bot for "Bot"
        /// </summary>
        [EnumMember(Value = "Bot")]
        Bot
    }
    /// <summary>
    /// Message type.
    /// </summary>
    /// <value>Message type.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Message receipt status, only used with type Receipt.
    /// </summary>
    /// <value>Message receipt status, only used with type Receipt.</value>
    [JsonPropertyName("status")]
    public StatusEnum? Status { get; set; }
    /// <summary>
    /// The direction of the message.  Direction is always from the perspective of the Genesys Cloud platform.  An Inbound message is one sent from a guest to the Genesys Cloud Platform.  An Outbound message is one sent from the Genesys Cloud Platform to a guest.
    /// </summary>
    /// <value>The direction of the message.  Direction is always from the perspective of the Genesys Cloud platform.  An Inbound message is one sent from a guest to the Genesys Cloud Platform.  An Outbound message is one sent from the Genesys Cloud Platform to a guest.</value>
    [JsonPropertyName("direction")]
    public DirectionEnum? Direction { get; set; }
    /// <summary>
    /// Specifies if this message was sent by a human agent or bot. The platform may use this to apply appropriate provider policies.
    /// </summary>
    /// <value>Specifies if this message was sent by a human agent or bot. The platform may use this to apply appropriate provider policies.</value>
    [JsonPropertyName("originatingEntity")]
    public OriginatingEntityEnum? OriginatingEntity { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebMessagingMessage" /> class.
    /// </summary>
    /// <param name="Id">Unique ID of the message. This ID is generated by Messaging Platform. Message receipts will have the same ID as the message they reference..</param>
    /// <param name="Channel">Channel-specific information that describes the message and the message channel/provider..</param>
    /// <param name="Type">Message type..</param>
    /// <param name="Text">Message text..</param>
    /// <param name="Content">List of content elements..</param>
    /// <param name="Events">List of event elements..</param>
    /// <param name="Direction">The direction of the message.  Direction is always from the perspective of the Genesys Cloud platform.  An Inbound message is one sent from a guest to the Genesys Cloud Platform.  An Outbound message is one sent from the Genesys Cloud Platform to a guest..</param>
    /// <param name="OriginatingEntity">Specifies if this message was sent by a human agent or bot. The platform may use this to apply appropriate provider policies..</param>
    /// <param name="Metadata">Additional metadata about this message..</param>
    public WebMessagingMessage(string Id = null, WebMessagingChannel Channel = null, TypeEnum? Type = null, string Text = null, List<WebMessagingContent> Content = null, List<WebMessagingEvent> Events = null, DirectionEnum? Direction = null, OriginatingEntityEnum? OriginatingEntity = null, Dictionary<string, string> Metadata = null)
    {
        this.Id = Id;
        this.Channel = Channel;
        this.Type = Type;
        this.Text = Text;
        this.Content = Content;
        this.Events = Events;
        this.Direction = Direction;
        this.OriginatingEntity = OriginatingEntity;
        this.Metadata = Metadata;

    }



    /// <summary>
    /// Unique ID of the message. This ID is generated by Messaging Platform. Message receipts will have the same ID as the message they reference.
    /// </summary>
    /// <value>Unique ID of the message. This ID is generated by Messaging Platform. Message receipts will have the same ID as the message they reference.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Channel-specific information that describes the message and the message channel/provider.
    /// </summary>
    /// <value>Channel-specific information that describes the message and the message channel/provider.</value>
    [JsonPropertyName("channel")]
    public WebMessagingChannel Channel { get; set; }





    /// <summary>
    /// Message text.
    /// </summary>
    /// <value>Message text.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// List of content elements.
    /// </summary>
    /// <value>List of content elements.</value>
    [JsonPropertyName("content")]
    public List<WebMessagingContent> Content { get; set; }





    /// <summary>
    /// List of reasons for a message receipt that indicates the message has failed. Only used with Failed status.
    /// </summary>
    /// <value>List of reasons for a message receipt that indicates the message has failed. Only used with Failed status.</value>
    [JsonPropertyName("reasons")]
    public List<Reason> Reasons { get; set; }



    /// <summary>
    /// List of event elements.
    /// </summary>
    /// <value>List of event elements.</value>
    [JsonPropertyName("events")]
    public List<WebMessagingEvent> Events { get; set; }







    /// <summary>
    /// Additional metadata about this message.
    /// </summary>
    /// <value>Additional metadata about this message.</value>
    [JsonPropertyName("metadata")]
    public Dictionary<string, string> Metadata { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebMessagingMessage {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Channel: ").Append(Channel).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Content: ").Append(Content).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Reasons: ").Append(Reasons).Append("\n");
        sb.Append("  Events: ").Append(Events).Append("\n");
        sb.Append("  Direction: ").Append(Direction).Append("\n");
        sb.Append("  OriginatingEntity: ").Append(OriginatingEntity).Append("\n");
        sb.Append("  Metadata: ").Append(Metadata).Append("\n");
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
        return Equals(obj as WebMessagingMessage);
    }

    /// <summary>
    /// Returns true if WebMessagingMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of WebMessagingMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebMessagingMessage other)
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
                Channel == other.Channel ||
                Channel != null &&
                Channel.Equals(other.Channel)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Text == other.Text ||
                Text != null &&
                Text.Equals(other.Text)
            ) &&
            (
                Content == other.Content ||
                Content != null &&
                Content.SequenceEqual(other.Content)
            ) &&
            (
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                Reasons == other.Reasons ||
                Reasons != null &&
                Reasons.SequenceEqual(other.Reasons)
            ) &&
            (
                Events == other.Events ||
                Events != null &&
                Events.SequenceEqual(other.Events)
            ) &&
            (
                Direction == other.Direction ||
                Direction != null &&
                Direction.Equals(other.Direction)
            ) &&
            (
                OriginatingEntity == other.OriginatingEntity ||
                OriginatingEntity != null &&
                OriginatingEntity.Equals(other.OriginatingEntity)
            ) &&
            (
                Metadata == other.Metadata ||
                Metadata != null &&
                Metadata.SequenceEqual(other.Metadata)
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

            if (Channel != null)
            {
                hash = hash * 59 + Channel.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Content != null)
            {
                hash = hash * 59 + Content.GetHashCode();
            }

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (Reasons != null)
            {
                hash = hash * 59 + Reasons.GetHashCode();
            }

            if (Events != null)
            {
                hash = hash * 59 + Events.GetHashCode();
            }

            if (Direction != null)
            {
                hash = hash * 59 + Direction.GetHashCode();
            }

            if (OriginatingEntity != null)
            {
                hash = hash * 59 + OriginatingEntity.GetHashCode();
            }

            if (Metadata != null)
            {
                hash = hash * 59 + Metadata.GetHashCode();
            }

            return hash;
        }
    }
}
