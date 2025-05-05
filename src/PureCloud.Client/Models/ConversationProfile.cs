using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConversationProfile
/// </summary>

public partial class ConversationProfile : IEquatable<ConversationProfile>
{
    /// <summary>
    /// The language code supported by the conversation profile belonging to a particular project for Dialogflow.
    /// </summary>
    /// <value>The language code supported by the conversation profile belonging to a particular project for Dialogflow.</value>
    
    public enum LanguageCodeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum En for "en"
        /// </summary>
        [EnumMember(Value = "en")]
        En,

        /// <summary>
        /// Enum Enau for "en-AU"
        /// </summary>
        [EnumMember(Value = "en-AU")]
        Enau,

        /// <summary>
        /// Enum Enca for "en-CA"
        /// </summary>
        [EnumMember(Value = "en-CA")]
        Enca,

        /// <summary>
        /// Enum Engb for "en-GB"
        /// </summary>
        [EnumMember(Value = "en-GB")]
        Engb,

        /// <summary>
        /// Enum Enin for "en-IN"
        /// </summary>
        [EnumMember(Value = "en-IN")]
        Enin,

        /// <summary>
        /// Enum Enus for "en-US"
        /// </summary>
        [EnumMember(Value = "en-US")]
        Enus
    }
    /// <summary>
    /// The language code supported by the conversation profile belonging to a particular project for Dialogflow.
    /// </summary>
    /// <value>The language code supported by the conversation profile belonging to a particular project for Dialogflow.</value>
    [JsonPropertyName("languageCode")]
    public LanguageCodeEnum? LanguageCode { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationProfile" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationProfile() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationProfile" /> class.
    /// </summary>
    /// <param name="LanguageCode">The language code supported by the conversation profile belonging to a particular project for Dialogflow. (required).</param>
    /// <param name="Name">The name of the conversation profile belonging to a particular project for Dialogflow (required).</param>
    public ConversationProfile(LanguageCodeEnum? LanguageCode = null, string Name = null)
    {
        this.LanguageCode = LanguageCode;
        this.Name = Name;

    }





    /// <summary>
    /// The name of the conversation profile belonging to a particular project for Dialogflow
    /// </summary>
    /// <value>The name of the conversation profile belonging to a particular project for Dialogflow</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationProfile {\n");

        sb.Append("  LanguageCode: ").Append(LanguageCode).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return Equals(obj as ConversationProfile);
    }

    /// <summary>
    /// Returns true if ConversationProfile instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationProfile to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationProfile other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                LanguageCode == other.LanguageCode ||
                LanguageCode != null &&
                LanguageCode.Equals(other.LanguageCode)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
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
            if (LanguageCode != null)
            {
                hash = hash * 59 + LanguageCode.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            return hash;
        }
    }
}
