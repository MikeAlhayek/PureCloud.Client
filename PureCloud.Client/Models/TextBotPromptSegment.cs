using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Data for a single bot flow prompt segment.
/// </summary>

public partial class TextBotPromptSegment : IEquatable<TextBotPromptSegment>
{
    /// <summary>
    /// The segment type which describes any semantics about the 'text' and also indicates which other field might include additional relevant info.
    /// </summary>
    /// <value>The segment type which describes any semantics about the 'text' and also indicates which other field might include additional relevant info.</value>
    
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
        /// Enum Richmedia for "RichMedia"
        /// </summary>
        [EnumMember(Value = "RichMedia")]
        Richmedia,

        /// <summary>
        /// Enum Messageevent for "MessageEvent"
        /// </summary>
        [EnumMember(Value = "MessageEvent")]
        Messageevent
    }
    /// <summary>
    /// The segment type which describes any semantics about the 'text' and also indicates which other field might include additional relevant info.
    /// </summary>
    /// <value>The segment type which describes any semantics about the 'text' and also indicates which other field might include additional relevant info.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotPromptSegment" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TextBotPromptSegment() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotPromptSegment" /> class.
    /// </summary>
    /// <param name="Text">The text of this prompt segment. (required).</param>
    /// <param name="Type">The segment type which describes any semantics about the &#39;text&#39; and also indicates which other field might include additional relevant info. (required).</param>
    /// <param name="Format">Additional details describing the segment’s contents, which the client should honour where possible..</param>
    /// <param name="Content">Details to display Rich Media content. This is only populated when the segment &#39;type&#39; is &#39;Rich Media&#39;..</param>
    public TextBotPromptSegment(string Text = null, TypeEnum? Type = null, Format Format = null, List<MessageContent> Content = null)
    {
        this.Text = Text;
        this.Type = Type;
        this.Format = Format;
        this.Content = Content;

    }



    /// <summary>
    /// The text of this prompt segment.
    /// </summary>
    /// <value>The text of this prompt segment.</value>
    [JsonPropertyName("text")]
    public string Text { get; set; }





    /// <summary>
    /// Additional details describing the segment’s contents, which the client should honour where possible.
    /// </summary>
    /// <value>Additional details describing the segment’s contents, which the client should honour where possible.</value>
    [JsonPropertyName("format")]
    public Format Format { get; set; }



    /// <summary>
    /// Details to display Rich Media content. This is only populated when the segment &#39;type&#39; is &#39;Rich Media&#39;.
    /// </summary>
    /// <value>Details to display Rich Media content. This is only populated when the segment &#39;type&#39; is &#39;Rich Media&#39;.</value>
    [JsonPropertyName("content")]
    public List<MessageContent> Content { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotPromptSegment {\n");

        sb.Append("  Text: ").Append(Text).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Format: ").Append(Format).Append("\n");
        sb.Append("  Content: ").Append(Content).Append("\n");
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
        return Equals(obj as TextBotPromptSegment);
    }

    /// <summary>
    /// Returns true if TextBotPromptSegment instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotPromptSegment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotPromptSegment other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Format == other.Format ||
                Format != null &&
                Format.Equals(other.Format)
            ) &&
            (
                Content == other.Content ||
                Content != null &&
                Content.SequenceEqual(other.Content)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Format != null)
            {
                hash = hash * 59 + Format.GetHashCode();
            }

            if (Content != null)
            {
                hash = hash * 59 + Content.GetHashCode();
            }

            return hash;
        }
    }
}
