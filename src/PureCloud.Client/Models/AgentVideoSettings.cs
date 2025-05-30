using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The settings for Agent Video
/// </summary>

public partial class AgentVideoSettings : IEquatable<AgentVideoSettings>
{
    /// <summary>
    /// background for agent
    /// </summary>
    /// <value>background for agent</value>
    
    public enum BackgroundEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Blur for "BLUR"
        /// </summary>
        [EnumMember(Value = "BLUR")]
        Blur,

        /// <summary>
        /// Enum None for "NONE"
        /// </summary>
        [EnumMember(Value = "NONE")]
        None,

        /// <summary>
        /// Enum Image for "IMAGE"
        /// </summary>
        [EnumMember(Value = "IMAGE")]
        Image
    }
    /// <summary>
    /// background for agent
    /// </summary>
    /// <value>background for agent</value>
    [JsonPropertyName("background")]
    public BackgroundEnum? Background { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="AgentVideoSettings" /> class.
    /// </summary>
    /// <param name="AllowCamera">whether or not agent camera is allowed.</param>
    /// <param name="AllowScreenShare">whether or not agent screen share is allowed.</param>
    /// <param name="Background">background for agent.</param>
    /// <param name="BackgroundImage">background image settings for agent.</param>
    public AgentVideoSettings(bool? AllowCamera = null, bool? AllowScreenShare = null, BackgroundEnum? Background = null, BackgroundImageSettings BackgroundImage = null)
    {
        this.AllowCamera = AllowCamera;
        this.AllowScreenShare = AllowScreenShare;
        this.Background = Background;
        this.BackgroundImage = BackgroundImage;

    }



    /// <summary>
    /// whether or not agent camera is allowed
    /// </summary>
    /// <value>whether or not agent camera is allowed</value>
    [JsonPropertyName("allowCamera")]
    public bool? AllowCamera { get; set; }



    /// <summary>
    /// whether or not agent screen share is allowed
    /// </summary>
    /// <value>whether or not agent screen share is allowed</value>
    [JsonPropertyName("allowScreenShare")]
    public bool? AllowScreenShare { get; set; }





    /// <summary>
    /// background image settings for agent
    /// </summary>
    /// <value>background image settings for agent</value>
    [JsonPropertyName("backgroundImage")]
    public BackgroundImageSettings BackgroundImage { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AgentVideoSettings {\n");

        sb.Append("  AllowCamera: ").Append(AllowCamera).Append("\n");
        sb.Append("  AllowScreenShare: ").Append(AllowScreenShare).Append("\n");
        sb.Append("  Background: ").Append(Background).Append("\n");
        sb.Append("  BackgroundImage: ").Append(BackgroundImage).Append("\n");
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
        return Equals(obj as AgentVideoSettings);
    }

    /// <summary>
    /// Returns true if AgentVideoSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of AgentVideoSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AgentVideoSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AllowCamera == other.AllowCamera ||
                AllowCamera != null &&
                AllowCamera.Equals(other.AllowCamera)
            ) &&
            (
                AllowScreenShare == other.AllowScreenShare ||
                AllowScreenShare != null &&
                AllowScreenShare.Equals(other.AllowScreenShare)
            ) &&
            (
                Background == other.Background ||
                Background != null &&
                Background.Equals(other.Background)
            ) &&
            (
                BackgroundImage == other.BackgroundImage ||
                BackgroundImage != null &&
                BackgroundImage.Equals(other.BackgroundImage)
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
            if (AllowCamera != null)
            {
                hash = hash * 59 + AllowCamera.GetHashCode();
            }

            if (AllowScreenShare != null)
            {
                hash = hash * 59 + AllowScreenShare.GetHashCode();
            }

            if (Background != null)
            {
                hash = hash * 59 + Background.GetHashCode();
            }

            if (BackgroundImage != null)
            {
                hash = hash * 59 + BackgroundImage.GetHashCode();
            }

            return hash;
        }
    }
}
