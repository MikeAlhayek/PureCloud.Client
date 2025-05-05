using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A card action that a user can take.
/// </summary>

public partial class ContentCardAction : IEquatable<ContentCardAction>
{
    /// <summary>
    /// Describes the type of action.
    /// </summary>
    /// <value>Describes the type of action.</value>
    
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
        /// Enum Link for "Link"
        /// </summary>
        [EnumMember(Value = "Link")]
        Link,

        /// <summary>
        /// Enum Postback for "Postback"
        /// </summary>
        [EnumMember(Value = "Postback")]
        Postback
    }
    /// <summary>
    /// Describes the type of action.
    /// </summary>
    /// <value>Describes the type of action.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContentCardAction" /> class.
    /// </summary>
    /// <param name="Type">Describes the type of action..</param>
    /// <param name="Text">The response text from the button click..</param>
    /// <param name="Payload">Text to be returned as the payload from a ButtonResponse when a button is clicked. The payload and text are a combination which will have to be unique across each card and carousel in order to determine which button was clicked in that card or carousel..</param>
    /// <param name="Url">A URL of a web page to direct the user to..</param>
    public ContentCardAction(TypeEnum? Type = null, string Text = null, string Payload = null, string Url = null)
    {
        this.Type = Type;
        this.Text = Text;
        this.Payload = Payload;
        this.Url = Url;

    }





    /// <summary>
    /// The response text from the button click.
    /// </summary>
    /// <value>The response text from the button click.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }



    /// <summary>
    /// Text to be returned as the payload from a ButtonResponse when a button is clicked. The payload and text are a combination which will have to be unique across each card and carousel in order to determine which button was clicked in that card or carousel.
    /// </summary>
    /// <value>Text to be returned as the payload from a ButtonResponse when a button is clicked. The payload and text are a combination which will have to be unique across each card and carousel in order to determine which button was clicked in that card or carousel.</value>
    [JsonPropertyName("payload")]
    public string Payload { get; set; }



    /// <summary>
    /// A URL of a web page to direct the user to.
    /// </summary>
    /// <value>A URL of a web page to direct the user to.</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContentCardAction {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Payload: ").Append(Payload).Append("\n");
        sb.Append("  Url: ").Append(Url).Append("\n");
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
        return Equals(obj as ContentCardAction);
    }

    /// <summary>
    /// Returns true if ContentCardAction instances are equal
    /// </summary>
    /// <param name="other">Instance of ContentCardAction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContentCardAction other)
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
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
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

            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            return hash;
        }
    }
}
