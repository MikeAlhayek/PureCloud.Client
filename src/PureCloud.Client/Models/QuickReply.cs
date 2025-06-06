using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QuickReply
/// </summary>

public partial class QuickReply : IEquatable<QuickReply>
{
    /// <summary>
    /// Specifies the type of action that is triggered upon clicking the quick reply. Currently, the only supported action is \"Message\" which sends a message using the quick reply text.
    /// </summary>
    /// <value>Specifies the type of action that is triggered upon clicking the quick reply. Currently, the only supported action is \"Message\" which sends a message using the quick reply text.</value>
    
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
    /// Specifies the type of action that is triggered upon clicking the quick reply. Currently, the only supported action is \"Message\" which sends a message using the quick reply text.
    /// </summary>
    /// <value>Specifies the type of action that is triggered upon clicking the quick reply. Currently, the only supported action is \"Message\" which sends a message using the quick reply text.</value>
    [JsonPropertyName("action")]
    public ActionEnum? Action { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="QuickReply" /> class.
    /// </summary>
    /// <param name="Text">Text to show inside the quick reply. This is also used as the response text after clicking on the quick reply..</param>
    /// <param name="Payload">Content of the textback payload after clicking a quick reply.</param>
    /// <param name="Url">The location of the image file associated with quick reply.</param>
    /// <param name="Action">Specifies the type of action that is triggered upon clicking the quick reply. Currently, the only supported action is \&quot;Message\&quot; which sends a message using the quick reply text..</param>
    /// <param name="IsSelected">Indicates if the quick reply option is selected by end customer.</param>
    public QuickReply(string Text = null, string Payload = null, string Url = null, ActionEnum? Action = null, bool? IsSelected = null)
    {
        this.Text = Text;
        this.Payload = Payload;
        this.Url = Url;
        this.Action = Action;
        this.IsSelected = IsSelected;

    }



    /// <summary>
    /// Text to show inside the quick reply. This is also used as the response text after clicking on the quick reply.
    /// </summary>
    /// <value>Text to show inside the quick reply. This is also used as the response text after clicking on the quick reply.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Content of the textback payload after clicking a quick reply
    /// </summary>
    /// <value>Content of the textback payload after clicking a quick reply</value>
    [JsonPropertyName("payload")]
    public string Payload { get; set; }



    /// <summary>
    /// The location of the image file associated with quick reply
    /// </summary>
    /// <value>The location of the image file associated with quick reply</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }





    /// <summary>
    /// Indicates if the quick reply option is selected by end customer
    /// </summary>
    /// <value>Indicates if the quick reply option is selected by end customer</value>
    [JsonPropertyName("isSelected")]
    public bool? IsSelected { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QuickReply {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Payload: ").Append(Payload).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  IsSelected: ").Append(IsSelected).Append("\n");
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
        return Equals(obj as QuickReply);
    }

    /// <summary>
    /// Returns true if QuickReply instances are equal
    /// </summary>
    /// <param name="other">Instance of QuickReply to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QuickReply other)
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
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                IsSelected == other.IsSelected ||
                IsSelected != null &&
                IsSelected.Equals(other.IsSelected)
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

            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (IsSelected != null)
            {
                hash = hash * 59 + IsSelected.GetHashCode();
            }

            return hash;
        }
    }
}
