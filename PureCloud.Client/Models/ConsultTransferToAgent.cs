using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConsultTransferToAgent
/// </summary>

public partial class ConsultTransferToAgent : IEquatable<ConsultTransferToAgent>
{
    /// <summary>
    /// Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION
    /// </summary>
    /// <value>Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION</value>
    
    public enum SpeakToEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Destination for "DESTINATION"
        /// </summary>
        [EnumMember(Value = "DESTINATION")]
        Destination,

        /// <summary>
        /// Enum Object for "OBJECT"
        /// </summary>
        [EnumMember(Value = "OBJECT")]
        Object,

        /// <summary>
        /// Enum Both for "BOTH"
        /// </summary>
        [EnumMember(Value = "BOTH")]
        Both,

        /// <summary>
        /// Enum Conference for "CONFERENCE"
        /// </summary>
        [EnumMember(Value = "CONFERENCE")]
        Conference
    }
    /// <summary>
    /// Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION
    /// </summary>
    /// <value>Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION</value>
    [JsonPropertyName("speakTo")]
    public SpeakToEnum? SpeakTo { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConsultTransferToAgent" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConsultTransferToAgent() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConsultTransferToAgent" /> class.
    /// </summary>
    /// <param name="SpeakTo">Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION (required).</param>
    /// <param name="ConsultingUserId">The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID.</param>
    /// <param name="UserId">The id of the internal user..</param>
    /// <param name="UserDisplayName">The name of the internal user..</param>
    public ConsultTransferToAgent(SpeakToEnum? SpeakTo = null, string ConsultingUserId = null, string UserId = null, string UserDisplayName = null)
    {
        this.SpeakTo = SpeakTo;
        this.ConsultingUserId = ConsultingUserId;
        this.UserId = UserId;
        this.UserDisplayName = UserDisplayName;

    }





    /// <summary>
    /// The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID
    /// </summary>
    /// <value>The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID</value>
    [JsonPropertyName("consultingUserId")]
    public string ConsultingUserId { get; set; }



    /// <summary>
    /// The id of the internal user.
    /// </summary>
    /// <value>The id of the internal user.</value>
    [JsonPropertyName("userId")]
    public string UserId { get; set; }



    /// <summary>
    /// The name of the internal user.
    /// </summary>
    /// <value>The name of the internal user.</value>
    [JsonPropertyName("userDisplayName")]
    public string UserDisplayName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConsultTransferToAgent {\n");

        sb.Append("  SpeakTo: ").Append(SpeakTo).Append("\n");
        sb.Append("  ConsultingUserId: ").Append(ConsultingUserId).Append("\n");
        sb.Append("  UserId: ").Append(UserId).Append("\n");
        sb.Append("  UserDisplayName: ").Append(UserDisplayName).Append("\n");
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
        return Equals(obj as ConsultTransferToAgent);
    }

    /// <summary>
    /// Returns true if ConsultTransferToAgent instances are equal
    /// </summary>
    /// <param name="other">Instance of ConsultTransferToAgent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConsultTransferToAgent other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SpeakTo == other.SpeakTo ||
                SpeakTo != null &&
                SpeakTo.Equals(other.SpeakTo)
            ) &&
            (
                ConsultingUserId == other.ConsultingUserId ||
                ConsultingUserId != null &&
                ConsultingUserId.Equals(other.ConsultingUserId)
            ) &&
            (
                UserId == other.UserId ||
                UserId != null &&
                UserId.Equals(other.UserId)
            ) &&
            (
                UserDisplayName == other.UserDisplayName ||
                UserDisplayName != null &&
                UserDisplayName.Equals(other.UserDisplayName)
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
            if (SpeakTo != null)
            {
                hash = hash * 59 + SpeakTo.GetHashCode();
            }

            if (ConsultingUserId != null)
            {
                hash = hash * 59 + ConsultingUserId.GetHashCode();
            }

            if (UserId != null)
            {
                hash = hash * 59 + UserId.GetHashCode();
            }

            if (UserDisplayName != null)
            {
                hash = hash * 59 + UserDisplayName.GetHashCode();
            }

            return hash;
        }
    }
}
