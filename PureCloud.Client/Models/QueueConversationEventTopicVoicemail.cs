using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The voicemail data to be used when this callback is an ACD voicemail.
/// </summary>
[DataContract]
public partial class QueueConversationEventTopicVoicemail : IEquatable<QueueConversationEventTopicVoicemail>
{
    /// <summary>
    /// current state of the voicemail upload
    /// </summary>
    /// <value>current state of the voicemail upload</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum UploadStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Pending for "pending"
        /// </summary>
        [EnumMember(Value = "pending")]
        Pending,

        /// <summary>
        /// Enum Complete for "complete"
        /// </summary>
        [EnumMember(Value = "complete")]
        Complete,

        /// <summary>
        /// Enum Failed for "failed"
        /// </summary>
        [EnumMember(Value = "failed")]
        Failed,

        /// <summary>
        /// Enum Timeout for "timeout"
        /// </summary>
        [EnumMember(Value = "timeout")]
        Timeout,

        /// <summary>
        /// Enum None for "none"
        /// </summary>
        [EnumMember(Value = "none")]
        None
    }
    /// <summary>
    /// current state of the voicemail upload
    /// </summary>
    /// <value>current state of the voicemail upload</value>
    [DataMember(Name = "uploadStatus", EmitDefaultValue = false)]
    public UploadStatusEnum? UploadStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationEventTopicVoicemail" /> class.
    /// </summary>
    /// <param name="Id">The voicemail id.</param>
    /// <param name="UploadStatus">current state of the voicemail upload.</param>
    public QueueConversationEventTopicVoicemail(string Id = null, UploadStatusEnum? UploadStatus = null)
    {
        this.Id = Id;
        this.UploadStatus = UploadStatus;

    }



    /// <summary>
    /// The voicemail id
    /// </summary>
    /// <value>The voicemail id</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationEventTopicVoicemail {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  UploadStatus: ").Append(UploadStatus).Append("\n");
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
        return Equals(obj as QueueConversationEventTopicVoicemail);
    }

    /// <summary>
    /// Returns true if QueueConversationEventTopicVoicemail instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationEventTopicVoicemail to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationEventTopicVoicemail other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                UploadStatus == other.UploadStatus ||
                UploadStatus != null &&
                UploadStatus.Equals(other.UploadStatus)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (UploadStatus != null)
            {
                hash = hash * 59 + UploadStatus.GetHashCode();
            }

            return hash;
        }
    }
}
