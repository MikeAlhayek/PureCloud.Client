using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Settings for an input event to the bot flow indicating an error has occurred.
/// </summary>

public partial class TextBotErrorInputEvent : IEquatable<TextBotErrorInputEvent>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotErrorInputEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TextBotErrorInputEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotErrorInputEvent" /> class.
    /// </summary>
    /// <param name="Code">The error code. (required).</param>
    /// <param name="Message">The error message. (required).</param>
    public TextBotErrorInputEvent(string Code = null, string Message = null)
    {
        this.Code = Code;
        this.Message = Message;

    }



    /// <summary>
    /// The error code.
    /// </summary>
    /// <value>The error code.</value>
    [JsonPropertyName("code")]
    public string Code { get; set; }



    /// <summary>
    /// The error message.
    /// </summary>
    /// <value>The error message.</value>
    [JsonPropertyName("message")]
    public string Message { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotErrorInputEvent {\n");

        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
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
        return Equals(obj as TextBotErrorInputEvent);
    }

    /// <summary>
    /// Returns true if TextBotErrorInputEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotErrorInputEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotErrorInputEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Code == other.Code ||
                Code != null &&
                Code.Equals(other.Code)
            ) &&
            (
                Message == other.Message ||
                Message != null &&
                Message.Equals(other.Message)
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
            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
            }

            if (Message != null)
            {
                hash = hash * 59 + Message.GetHashCode();
            }

            return hash;
        }
    }
}
