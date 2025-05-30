using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Settings for a user&#39;s mobile notifications
/// </summary>

public partial class MobileNotificationSettings : IEquatable<MobileNotificationSettings>
{
    /// <summary>
    /// When the user should receive notifications
    /// </summary>
    /// <value>When the user should receive notifications</value>
    
    public enum WhenEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Always for "Always"
        /// </summary>
        [EnumMember(Value = "Always")]
        Always,

        /// <summary>
        /// Enum Onlywheninactive for "OnlyWhenInactive"
        /// </summary>
        [EnumMember(Value = "OnlyWhenInactive")]
        Onlywheninactive
    }
    /// <summary>
    /// When the user should receive notifications
    /// </summary>
    /// <value>When the user should receive notifications</value>
    [JsonPropertyName("when")]
    public WhenEnum? When { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="MobileNotificationSettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MobileNotificationSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MobileNotificationSettings" /> class.
    /// </summary>
    /// <param name="When">When the user should receive notifications (required).</param>
    public MobileNotificationSettings(WhenEnum? When = null)
    {
        this.When = When;

    }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MobileNotificationSettings {\n");

        sb.Append("  When: ").Append(When).Append("\n");
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
        return Equals(obj as MobileNotificationSettings);
    }

    /// <summary>
    /// Returns true if MobileNotificationSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of MobileNotificationSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MobileNotificationSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                When == other.When ||
                When != null &&
                When.Equals(other.When)
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
            if (When != null)
            {
                hash = hash * 59 + When.GetHashCode();
            }

            return hash;
        }
    }
}
