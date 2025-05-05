using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ButtonResponse
/// </summary>

public partial class ButtonResponse : IEquatable<ButtonResponse>
{
    /// <summary>
    /// Button response type that captures Button and QuickReply type responses
    /// </summary>
    /// <value>Button response type that captures Button and QuickReply type responses</value>
    
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
        /// Enum Button for "Button"
        /// </summary>
        [EnumMember(Value = "Button")]
        Button,

        /// <summary>
        /// Enum Quickreply for "QuickReply"
        /// </summary>
        [EnumMember(Value = "QuickReply")]
        Quickreply,

        /// <summary>
        /// Enum Datepicker for "DatePicker"
        /// </summary>
        [EnumMember(Value = "DatePicker")]
        Datepicker
    }
    /// <summary>
    /// Button response message type that captures QuickReply , Cards and Carousel .This is used  as label for Card selection
    /// </summary>
    /// <value>Button response message type that captures QuickReply , Cards and Carousel .This is used  as label for Card selection</value>
    
    public enum MessageTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Quickreply for "QuickReply"
        /// </summary>
        [EnumMember(Value = "QuickReply")]
        Quickreply,

        /// <summary>
        /// Enum Card for "Card"
        /// </summary>
        [EnumMember(Value = "Card")]
        Card,

        /// <summary>
        /// Enum Carousel for "Carousel"
        /// </summary>
        [EnumMember(Value = "Carousel")]
        Carousel
    }
    /// <summary>
    /// Button response type that captures Button and QuickReply type responses
    /// </summary>
    /// <value>Button response type that captures Button and QuickReply type responses</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Button response message type that captures QuickReply , Cards and Carousel .This is used  as label for Card selection
    /// </summary>
    /// <value>Button response message type that captures QuickReply , Cards and Carousel .This is used  as label for Card selection</value>
    [JsonPropertyName("messageType")]
    public MessageTypeEnum? MessageType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ButtonResponse" /> class.
    /// </summary>
    /// <param name="Type">Button response type that captures Button and QuickReply type responses.</param>
    /// <param name="Text">Text to show inside the Button reply. This is also used as the response text after clicking on the Button..</param>
    /// <param name="Payload">Content of the textback payload after clicking a button.</param>
    /// <param name="MessageType">Button response message type that captures QuickReply , Cards and Carousel .This is used  as label for Card selection.</param>
    public ButtonResponse(TypeEnum? Type = null, string Text = null, string Payload = null, MessageTypeEnum? MessageType = null)
    {
        this.Type = Type;
        this.Text = Text;
        this.Payload = Payload;
        this.MessageType = MessageType;

    }





    /// <summary>
    /// Text to show inside the Button reply. This is also used as the response text after clicking on the Button.
    /// </summary>
    /// <value>Text to show inside the Button reply. This is also used as the response text after clicking on the Button.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Content of the textback payload after clicking a button
    /// </summary>
    /// <value>Content of the textback payload after clicking a button</value>
    [JsonPropertyName("payload")]
    public string Payload { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ButtonResponse {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Payload: ").Append(Payload).Append("\n");
        sb.Append("  MessageType: ").Append(MessageType).Append("\n");
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
        return Equals(obj as ButtonResponse);
    }

    /// <summary>
    /// Returns true if ButtonResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ButtonResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ButtonResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                Payload == other.Payload ||
                Payload != null &&
                Payload.Equals(other.Payload)
            ) &&
            (
                MessageType == other.MessageType ||
                MessageType != null &&
                MessageType.Equals(other.MessageType)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Payload != null)
            {
                hash = hash * 59 + Payload.GetHashCode();
            }

            if (MessageType != null)
            {
                hash = hash * 59 + MessageType.GetHashCode();
            }

            return hash;
        }
    }
}
