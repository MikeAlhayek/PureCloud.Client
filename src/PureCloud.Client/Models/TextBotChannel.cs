using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Channel information relevant to a bot flow.
/// </summary>

public partial class TextBotChannel : IEquatable<TextBotChannel>
{
    /// <summary>
    /// The name of the channel.
    /// </summary>
    /// <value>The name of the channel.</value>
    
    public enum NameEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Chat for "Chat"
        /// </summary>
        [EnumMember(Value = "Chat")]
        Chat,

        /// <summary>
        /// Enum Call for "Call"
        /// </summary>
        [EnumMember(Value = "Call")]
        Call,

        /// <summary>
        /// Enum Messaging for "Messaging"
        /// </summary>
        [EnumMember(Value = "Messaging")]
        Messaging
    }
    /// <summary>
    /// Gets or Sets InputModes
    /// </summary>
    
    public enum InputModesEnum
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
    /// Gets or Sets OutputModes
    /// </summary>
    
    public enum OutputModesEnum
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
    /// The name of the channel.
    /// </summary>
    /// <value>The name of the channel.</value>
    [JsonPropertyName("name")]
    public NameEnum? Name { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotChannel" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TextBotChannel() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="TextBotChannel" /> class.
    /// </summary>
    /// <param name="Name">The name of the channel. (required).</param>
    /// <param name="InputModes">The input modes for the channel. (required).</param>
    /// <param name="OutputModes">The output modes for the channel. (required).</param>
    /// <param name="UserAgent">Information about the end user agent calling the bot flow. (required).</param>
    public TextBotChannel(NameEnum? Name = null, List<InputModesEnum> InputModes = null, List<OutputModesEnum> OutputModes = null, TextBotUserAgent UserAgent = null)
    {
        this.Name = Name;
        this.InputModes = InputModes;
        this.OutputModes = OutputModes;
        this.UserAgent = UserAgent;

    }





    /// <summary>
    /// The input modes for the channel.
    /// </summary>
    /// <value>The input modes for the channel.</value>
    [JsonPropertyName("inputModes")]
    public List<InputModesEnum> InputModes { get; set; }



    /// <summary>
    /// The output modes for the channel.
    /// </summary>
    /// <value>The output modes for the channel.</value>
    [JsonPropertyName("outputModes")]
    public List<OutputModesEnum> OutputModes { get; set; }



    /// <summary>
    /// Information about the end user agent calling the bot flow.
    /// </summary>
    /// <value>Information about the end user agent calling the bot flow.</value>
    [JsonPropertyName("userAgent")]
    public TextBotUserAgent UserAgent { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TextBotChannel {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  InputModes: ").Append(InputModes).Append("\n");
        sb.Append("  OutputModes: ").Append(OutputModes).Append("\n");
        sb.Append("  UserAgent: ").Append(UserAgent).Append("\n");
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
        return Equals(obj as TextBotChannel);
    }

    /// <summary>
    /// Returns true if TextBotChannel instances are equal
    /// </summary>
    /// <param name="other">Instance of TextBotChannel to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TextBotChannel other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                InputModes == other.InputModes ||
                InputModes != null &&
                InputModes.SequenceEqual(other.InputModes)
            ) &&
            (
                OutputModes == other.OutputModes ||
                OutputModes != null &&
                OutputModes.SequenceEqual(other.OutputModes)
            ) &&
            (
                UserAgent == other.UserAgent ||
                UserAgent != null &&
                UserAgent.Equals(other.UserAgent)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (InputModes != null)
            {
                hash = hash * 59 + InputModes.GetHashCode();
            }

            if (OutputModes != null)
            {
                hash = hash * 59 + OutputModes.GetHashCode();
            }

            if (UserAgent != null)
            {
                hash = hash * 59 + UserAgent.GetHashCode();
            }

            return hash;
        }
    }
}
