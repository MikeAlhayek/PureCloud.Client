using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MinerExecuteRequest
/// </summary>

public partial class MinerExecuteRequest : IEquatable<MinerExecuteRequest>
{
    /// <summary>
    /// Media type for filtering conversations.
    /// </summary>
    /// <value>Media type for filtering conversations.</value>
    
    public enum MediaTypeEnum
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
        /// Enum Message for "Message"
        /// </summary>
        [EnumMember(Value = "Message")]
        Message,

        /// <summary>
        /// Enum Email for "Email"
        /// </summary>
        [EnumMember(Value = "Email")]
        Email
    }
    /// <summary>
    /// Type of the participant, either agent, customer or both.
    /// </summary>
    /// <value>Type of the participant, either agent, customer or both.</value>
    
    public enum ParticipantTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Customer for "Customer"
        /// </summary>
        [EnumMember(Value = "Customer")]
        Customer,

        /// <summary>
        /// Enum Agent for "Agent"
        /// </summary>
        [EnumMember(Value = "Agent")]
        Agent,

        /// <summary>
        /// Enum Both for "Both"
        /// </summary>
        [EnumMember(Value = "Both")]
        Both
    }
    /// <summary>
    /// Media type for filtering conversations.
    /// </summary>
    /// <value>Media type for filtering conversations.</value>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Type of the participant, either agent, customer or both.
    /// </summary>
    /// <value>Type of the participant, either agent, customer or both.</value>
    [JsonPropertyName("participantType")]
    public ParticipantTypeEnum? ParticipantType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="MinerExecuteRequest" /> class.
    /// </summary>
    /// <param name="DateStart">Start date for the date range to mine. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="DateEnd">End date for the date range to mine. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd.</param>
    /// <param name="UploadKey">Location of input conversations..</param>
    /// <param name="MediaType">Media type for filtering conversations..</param>
    /// <param name="ParticipantType">Type of the participant, either agent, customer or both..</param>
    /// <param name="QueueIds">List of queue IDs for filtering conversations..</param>
    public MinerExecuteRequest(string DateStart = null, string DateEnd = null, string UploadKey = null, MediaTypeEnum? MediaType = null, ParticipantTypeEnum? ParticipantType = null, List<string> QueueIds = null)
    {
        this.DateStart = DateStart;
        this.DateEnd = DateEnd;
        this.UploadKey = UploadKey;
        this.MediaType = MediaType;
        this.ParticipantType = ParticipantType;
        this.QueueIds = QueueIds;

    }



    /// <summary>
    /// Start date for the date range to mine. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>Start date for the date range to mine. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateStart")]
    public string DateStart { get; set; }



    /// <summary>
    /// End date for the date range to mine. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd
    /// </summary>
    /// <value>End date for the date range to mine. Dates are represented as an ISO-8601 string. For example: yyyy-MM-dd</value>
    [JsonPropertyName("dateEnd")]
    public string DateEnd { get; set; }



    /// <summary>
    /// Location of input conversations.
    /// </summary>
    /// <value>Location of input conversations.</value>
    [JsonPropertyName("uploadKey")]
    public string UploadKey { get; set; }







    /// <summary>
    /// List of queue IDs for filtering conversations.
    /// </summary>
    /// <value>List of queue IDs for filtering conversations.</value>
    [JsonPropertyName("queueIds")]
    public List<string> QueueIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MinerExecuteRequest {\n");

        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
        sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  ParticipantType: ").Append(ParticipantType).Append("\n");
        sb.Append("  QueueIds: ").Append(QueueIds).Append("\n");
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
        return Equals(obj as MinerExecuteRequest);
    }

    /// <summary>
    /// Returns true if MinerExecuteRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of MinerExecuteRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MinerExecuteRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                DateEnd == other.DateEnd ||
                DateEnd != null &&
                DateEnd.Equals(other.DateEnd)
            ) &&
            (
                UploadKey == other.UploadKey ||
                UploadKey != null &&
                UploadKey.Equals(other.UploadKey)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                ParticipantType == other.ParticipantType ||
                ParticipantType != null &&
                ParticipantType.Equals(other.ParticipantType)
            ) &&
            (
                QueueIds == other.QueueIds ||
                QueueIds != null &&
                QueueIds.SequenceEqual(other.QueueIds)
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
            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (DateEnd != null)
            {
                hash = hash * 59 + DateEnd.GetHashCode();
            }

            if (UploadKey != null)
            {
                hash = hash * 59 + UploadKey.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (ParticipantType != null)
            {
                hash = hash * 59 + ParticipantType.GetHashCode();
            }

            if (QueueIds != null)
            {
                hash = hash * 59 + QueueIds.GetHashCode();
            }

            return hash;
        }
    }
}
