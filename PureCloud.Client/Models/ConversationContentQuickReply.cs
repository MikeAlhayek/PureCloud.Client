using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Quick reply object.
/// </summary>
[DataContract]
public partial class ConversationContentQuickReply : IEquatable<ConversationContentQuickReply>
{
    /// <summary>
    /// Specifies the type of action that is triggered upon clicking the quick reply.
    /// </summary>
    /// <value>Specifies the type of action that is triggered upon clicking the quick reply.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ActionEnum
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
        Message
    }
    /// <summary>
    /// Specifies the type of action that is triggered upon clicking the quick reply.
    /// </summary>
    /// <value>Specifies the type of action that is triggered upon clicking the quick reply.</value>
    [DataMember(Name = "action", EmitDefaultValue = false)]
    public ActionEnum? Action { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationContentQuickReply" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationContentQuickReply() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationContentQuickReply" /> class.
    /// </summary>
    /// <param name="Text">Text to show inside the quick reply. This is also used as the response text after clicking on the quick reply. (required).</param>
    /// <param name="Payload">Content of the payload included in the quick reply response. Could be an ID identifying the quick reply response. (required).</param>
    /// <param name="Image">URL of an image associated with the quick reply..</param>
    /// <param name="Action">Specifies the type of action that is triggered upon clicking the quick reply..</param>
    public ConversationContentQuickReply(string Text = null, string Payload = null, string Image = null, ActionEnum? Action = null)
    {
        this.Text = Text;
        this.Payload = Payload;
        this.Image = Image;
        this.Action = Action;

    }



    /// <summary>
    /// Text to show inside the quick reply. This is also used as the response text after clicking on the quick reply.
    /// </summary>
    /// <value>Text to show inside the quick reply. This is also used as the response text after clicking on the quick reply.</value>
    [DataMember(Name = "text", EmitDefaultValue = false)]
    public string Text { get; set; }



    /// <summary>
    /// Content of the payload included in the quick reply response. Could be an ID identifying the quick reply response.
    /// </summary>
    /// <value>Content of the payload included in the quick reply response. Could be an ID identifying the quick reply response.</value>
    [DataMember(Name = "payload", EmitDefaultValue = false)]
    public string Payload { get; set; }



    /// <summary>
    /// URL of an image associated with the quick reply.
    /// </summary>
    /// <value>URL of an image associated with the quick reply.</value>
    [DataMember(Name = "image", EmitDefaultValue = false)]
    public string Image { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationContentQuickReply {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Payload: ").Append(Payload).Append("\n");
        sb.Append("  Image: ").Append(Image).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
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
        return Equals(obj as ConversationContentQuickReply);
    }

    /// <summary>
    /// Returns true if ConversationContentQuickReply instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationContentQuickReply to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationContentQuickReply other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                Image == other.Image ||
                Image != null &&
                Image.Equals(other.Image)
            ) &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
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
            if (Text != null)
            {
                hash = hash * 59 + Text.GetHashCode();
            }

            if (Payload != null)
            {
                hash = hash * 59 + Payload.GetHashCode();
            }

            if (Image != null)
            {
                hash = hash * 59 + Image.GetHashCode();
            }

            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            return hash;
        }
    }
}
