using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationThreadingWindowSetting
/// </summary>

public partial class ConversationThreadingWindowSetting : IEquatable<ConversationThreadingWindowSetting>
{
    /// <summary>
    /// The type of messenger
    /// </summary>
    /// <value>The type of messenger</value>
    
    public enum MessengerTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Sms for "sms"
        /// </summary>
        [EnumMember(Value = "sms")]
        Sms,

        /// <summary>
        /// Enum Facebook for "facebook"
        /// </summary>
        [EnumMember(Value = "facebook")]
        Facebook,

        /// <summary>
        /// Enum Twitter for "twitter"
        /// </summary>
        [EnumMember(Value = "twitter")]
        Twitter,

        /// <summary>
        /// Enum Whatsapp for "whatsapp"
        /// </summary>
        [EnumMember(Value = "whatsapp")]
        Whatsapp,

        /// <summary>
        /// Enum Webmessaging for "webmessaging"
        /// </summary>
        [EnumMember(Value = "webmessaging")]
        Webmessaging,

        /// <summary>
        /// Enum Instagram for "instagram"
        /// </summary>
        [EnumMember(Value = "instagram")]
        Instagram,

        /// <summary>
        /// Enum Open for "open"
        /// </summary>
        [EnumMember(Value = "open")]
        Open,

        /// <summary>
        /// Enum Apple for "apple"
        /// </summary>
        [EnumMember(Value = "apple")]
        Apple
    }
    /// <summary>
    /// The type of messenger
    /// </summary>
    /// <value>The type of messenger</value>
    [JsonPropertyName("messengerType")]
    public MessengerTypeEnum? MessengerType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationThreadingWindowSetting" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationThreadingWindowSetting() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationThreadingWindowSetting" /> class.
    /// </summary>
    /// <param name="MessengerType">The type of messenger (required).</param>
    /// <param name="TimeoutInMinutes">The conversation threading window timeout (Minutes) of specified messenger type (required).</param>
    public ConversationThreadingWindowSetting(MessengerTypeEnum? MessengerType = null, long? TimeoutInMinutes = null)
    {
        this.MessengerType = MessengerType;
        this.TimeoutInMinutes = TimeoutInMinutes;

    }





    /// <summary>
    /// The conversation threading window timeout (Minutes) of specified messenger type
    /// </summary>
    /// <value>The conversation threading window timeout (Minutes) of specified messenger type</value>
    [JsonPropertyName("timeoutInMinutes")]
    public long? TimeoutInMinutes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationThreadingWindowSetting {\n");

        sb.Append("  MessengerType: ").Append(MessengerType).Append("\n");
        sb.Append("  TimeoutInMinutes: ").Append(TimeoutInMinutes).Append("\n");
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
        return Equals(obj as ConversationThreadingWindowSetting);
    }

    /// <summary>
    /// Returns true if ConversationThreadingWindowSetting instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationThreadingWindowSetting to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationThreadingWindowSetting other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MessengerType == other.MessengerType ||
                MessengerType != null &&
                MessengerType.Equals(other.MessengerType)
            ) &&
            (
                TimeoutInMinutes == other.TimeoutInMinutes ||
                TimeoutInMinutes != null &&
                TimeoutInMinutes.Equals(other.TimeoutInMinutes)
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
            if (MessengerType != null)
            {
                hash = hash * 59 + MessengerType.GetHashCode();
            }

            if (TimeoutInMinutes != null)
            {
                hash = hash * 59 + TimeoutInMinutes.GetHashCode();
            }

            return hash;
        }
    }
}
