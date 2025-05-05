using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Settings for an input event to the bot flow indicating user input is available.
/// </summary>

public partial class TextBotUserInputEvent : IEquatable<TextBotUserInputEvent>
{
    /// <summary>
    /// The input mode.
    /// </summary>
    /// <value>The input mode.</value>
    
    public enum ModeEnum
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
        Text
    }
    /// <summary>
    /// The input mode.
    /// </summary>
    /// <value>The input mode.</value>
    [JsonPropertyName("mode")]
    public ModeEnum? Mode { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotUserInputEvent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TextBotUserInputEvent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotUserInputEvent" /> class.
    /// </summary>
    /// <param name="Mode">The input mode. (required).</param>
    /// <param name="Alternatives">The input alternatives. (required).</param>
    public TextBotUserInputEvent(ModeEnum? Mode = null, List<TextBotUserInputAlternative> Alternatives = null)
    {
        this.Mode = Mode;
        this.Alternatives = Alternatives;

    }





    /// <summary>
    /// The input alternatives.
    /// </summary>
    /// <value>The input alternatives.</value>
    [JsonPropertyName("alternatives")]
    public List<TextBotUserInputAlternative> Alternatives { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotUserInputEvent {\n");

        sb.Append("  Mode: ").Append(Mode).Append("\n");
        sb.Append("  Alternatives: ").Append(Alternatives).Append("\n");
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
        return Equals(obj as TextBotUserInputEvent);
    }

    /// <summary>
    /// Returns true if TextBotUserInputEvent instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotUserInputEvent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotUserInputEvent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Mode == other.Mode ||
                Mode != null &&
                Mode.Equals(other.Mode)
            ) &&
            (
                Alternatives == other.Alternatives ||
                Alternatives != null &&
                Alternatives.SequenceEqual(other.Alternatives)
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
            if (Mode != null)
            {
                hash = hash * 59 + Mode.GetHashCode();
            }

            if (Alternatives != null)
            {
                hash = hash * 59 + Alternatives.GetHashCode();
            }

            return hash;
        }
    }
}
