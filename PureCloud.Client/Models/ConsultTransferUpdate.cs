using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConsultTransferUpdate
/// </summary>

public partial class ConsultTransferUpdate : IEquatable<ConsultTransferUpdate>
{
    /// <summary>
    /// Determines to whom the initiating participant is speaking.
    /// </summary>
    /// <value>Determines to whom the initiating participant is speaking.</value>
    
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
    /// Determines to whom the initiating participant is speaking.
    /// </summary>
    /// <value>Determines to whom the initiating participant is speaking.</value>
    [JsonPropertyName("speakTo")]
    public SpeakToEnum? SpeakTo { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConsultTransferUpdate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConsultTransferUpdate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConsultTransferUpdate" /> class.
    /// </summary>
    /// <param name="SpeakTo">Determines to whom the initiating participant is speaking. (required).</param>
    /// <param name="ConsultingUserId">The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID.</param>
    public ConsultTransferUpdate(SpeakToEnum? SpeakTo = null, string ConsultingUserId = null)
    {
        this.SpeakTo = SpeakTo;
        this.ConsultingUserId = ConsultingUserId;

    }





    /// <summary>
    /// The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID
    /// </summary>
    /// <value>The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID</value>
    [JsonPropertyName("consultingUserId")]
    public string ConsultingUserId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConsultTransferUpdate {\n");

        sb.Append("  SpeakTo: ").Append(SpeakTo).Append("\n");
        sb.Append("  ConsultingUserId: ").Append(ConsultingUserId).Append("\n");
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
        return Equals(obj as ConsultTransferUpdate);
    }

    /// <summary>
    /// Returns true if ConsultTransferUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of ConsultTransferUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConsultTransferUpdate other)
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

            return hash;
        }
    }
}
