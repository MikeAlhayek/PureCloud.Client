using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConsultTransfer
/// </summary>

public partial class ConsultTransfer : IEquatable<ConsultTransfer>
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
    /// Initializes a new instance of the <see cref="ConsultTransfer" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConsultTransfer() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConsultTransfer" /> class.
    /// </summary>
    /// <param name="SpeakTo">Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION (required).</param>
    /// <param name="ConsultingUserId">The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID.</param>
    /// <param name="Destination">Destination. Specify one and only one parameter from the list below. (required).</param>
    public ConsultTransfer(SpeakToEnum? SpeakTo = null, string ConsultingUserId = null, Destination Destination = null)
    {
        this.SpeakTo = SpeakTo;
        this.ConsultingUserId = ConsultingUserId;
        this.Destination = Destination;

    }





    /// <summary>
    /// The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID
    /// </summary>
    /// <value>The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID</value>
    [JsonPropertyName("consultingUserId")]
    public string ConsultingUserId { get; set; }



    /// <summary>
    /// Destination. Specify one and only one parameter from the list below.
    /// </summary>
    /// <value>Destination. Specify one and only one parameter from the list below.</value>
    [JsonPropertyName("destination")]
    public Destination Destination { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConsultTransfer {\n");

        sb.Append("  SpeakTo: ").Append(SpeakTo).Append("\n");
        sb.Append("  ConsultingUserId: ").Append(ConsultingUserId).Append("\n");
        sb.Append("  Destination: ").Append(Destination).Append("\n");
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
        return Equals(obj as ConsultTransfer);
    }

    /// <summary>
    /// Returns true if ConsultTransfer instances are equal
    /// </summary>
    /// <param name="other">Instance of ConsultTransfer to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConsultTransfer other)
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
                Destination == other.Destination ||
                Destination != null &&
                Destination.Equals(other.Destination)
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

            if (Destination != null)
            {
                hash = hash * 59 + Destination.GetHashCode();
            }

            return hash;
        }
    }
}
