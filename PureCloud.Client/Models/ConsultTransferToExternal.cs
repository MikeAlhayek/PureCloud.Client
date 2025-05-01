using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ConsultTransferToExternal
/// </summary>
[DataContract]
public partial class ConsultTransferToExternal : IEquatable<ConsultTransferToExternal>
{
    /// <summary>
    /// Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION
    /// </summary>
    /// <value>Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [DataMember(Name = "speakTo", EmitDefaultValue = false)]
    public SpeakToEnum? SpeakTo { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConsultTransferToExternal" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConsultTransferToExternal() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConsultTransferToExternal" /> class.
    /// </summary>
    /// <param name="SpeakTo">Determines to whom the initiating participant is requesting to speak. Defaults to DESTINATION (required).</param>
    /// <param name="ConsultingUserId">The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID.</param>
    /// <param name="Address">The address (like phone number) of the external contact..</param>
    public ConsultTransferToExternal(SpeakToEnum? SpeakTo = null, string ConsultingUserId = null, string Address = null)
    {
        this.SpeakTo = SpeakTo;
        this.ConsultingUserId = ConsultingUserId;
        this.Address = Address;

    }





    /// <summary>
    /// The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID
    /// </summary>
    /// <value>The user ID of the person who wants to talk before completing the transfer. Could be the same of the context user ID</value>
    [DataMember(Name = "consultingUserId", EmitDefaultValue = false)]
    public string ConsultingUserId { get; set; }



    /// <summary>
    /// The address (like phone number) of the external contact.
    /// </summary>
    /// <value>The address (like phone number) of the external contact.</value>
    [DataMember(Name = "address", EmitDefaultValue = false)]
    public string Address { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConsultTransferToExternal {\n");

        sb.Append("  SpeakTo: ").Append(SpeakTo).Append("\n");
        sb.Append("  ConsultingUserId: ").Append(ConsultingUserId).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
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
        return Equals(obj as ConsultTransferToExternal);
    }

    /// <summary>
    /// Returns true if ConsultTransferToExternal instances are equal
    /// </summary>
    /// <param name="other">Instance of ConsultTransferToExternal to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConsultTransferToExternal other)
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
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
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

            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            return hash;
        }
    }
}
