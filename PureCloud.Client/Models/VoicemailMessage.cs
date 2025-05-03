using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// VoicemailMessage
/// </summary>

public partial class VoicemailMessage : IEquatable<VoicemailMessage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VoicemailMessage" /> class.
    /// </summary>
    /// <param name="Read">Whether the voicemail message is marked as read.</param>
    /// <param name="Deleted">Whether the voicemail message has been marked as deleted.</param>
    /// <param name="Note">An optional note.</param>
    /// <param name="DeleteRetentionPolicy">The retention policy for this voicemail when deleted is set to true.</param>
    public VoicemailMessage(bool? Read = null, bool? Deleted = null, string Note = null, VoicemailRetentionPolicy DeleteRetentionPolicy = null)
    {
        this.Read = Read;
        this.Deleted = Deleted;
        this.Note = Note;
        this.DeleteRetentionPolicy = DeleteRetentionPolicy;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The conversation that the voicemail message is associated with
    /// </summary>
    /// <value>The conversation that the voicemail message is associated with</value>
    [JsonPropertyName("conversation")]
    public Conversation Conversation { get; private set; }



    /// <summary>
    /// Whether the voicemail message is marked as read
    /// </summary>
    /// <value>Whether the voicemail message is marked as read</value>
    [JsonPropertyName("read")]
    public bool? Read { get; set; }



    /// <summary>
    /// The voicemail message&#39;s audio recording duration in seconds
    /// </summary>
    /// <value>The voicemail message&#39;s audio recording duration in seconds</value>
    [JsonPropertyName("audioRecordingDurationSeconds")]
    public int? AudioRecordingDurationSeconds { get; private set; }



    /// <summary>
    /// The voicemail message&#39;s audio recording size in bytes
    /// </summary>
    /// <value>The voicemail message&#39;s audio recording size in bytes</value>
    [JsonPropertyName("audioRecordingSizeBytes")]
    public long? AudioRecordingSizeBytes { get; private set; }



    /// <summary>
    /// The transcription of the voicemail&#39;s audio
    /// </summary>
    /// <value>The transcription of the voicemail&#39;s audio</value>
    [JsonPropertyName("transcription")]
    public string Transcription { get; private set; }



    /// <summary>
    /// The date the voicemail message was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the voicemail message was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; private set; }



    /// <summary>
    /// The date the voicemail message was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the voicemail message was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("modifiedDate")]
    public DateTime? ModifiedDate { get; private set; }



    /// <summary>
    /// The date the voicemail message deleted property was set to true. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the voicemail message deleted property was set to true. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("deletedDate")]
    public DateTime? DeletedDate { get; private set; }



    /// <summary>
    /// The caller address
    /// </summary>
    /// <value>The caller address</value>
    [JsonPropertyName("callerAddress")]
    public string CallerAddress { get; private set; }



    /// <summary>
    /// Optionally the name of the caller that left the voicemail message if the caller was a known user
    /// </summary>
    /// <value>Optionally the name of the caller that left the voicemail message if the caller was a known user</value>
    [JsonPropertyName("callerName")]
    public string CallerName { get; private set; }



    /// <summary>
    /// Optionally the user that left the voicemail message if the caller was a known user
    /// </summary>
    /// <value>Optionally the user that left the voicemail message if the caller was a known user</value>
    [JsonPropertyName("callerUser")]
    public User CallerUser { get; private set; }



    /// <summary>
    /// Whether the voicemail message has been marked as deleted
    /// </summary>
    /// <value>Whether the voicemail message has been marked as deleted</value>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }



    /// <summary>
    /// An optional note
    /// </summary>
    /// <value>An optional note</value>
    [JsonPropertyName("note")]
    public string Note { get; set; }



    /// <summary>
    /// The user that the voicemail message belongs to or null which means the voicemail message belongs to a group or queue
    /// </summary>
    /// <value>The user that the voicemail message belongs to or null which means the voicemail message belongs to a group or queue</value>
    [JsonPropertyName("user")]
    public User User { get; private set; }



    /// <summary>
    /// The group that the voicemail message belongs to or null which means the voicemail message belongs to a user or queue
    /// </summary>
    /// <value>The group that the voicemail message belongs to or null which means the voicemail message belongs to a user or queue</value>
    [JsonPropertyName("group")]
    public Group Group { get; private set; }



    /// <summary>
    /// The queue that the voicemail message belongs to or null which means the voicemail message belongs to a user or group
    /// </summary>
    /// <value>The queue that the voicemail message belongs to or null which means the voicemail message belongs to a user or group</value>
    [JsonPropertyName("queue")]
    public Queue Queue { get; private set; }



    /// <summary>
    /// Represents where this voicemail message was copied from
    /// </summary>
    /// <value>Represents where this voicemail message was copied from</value>
    [JsonPropertyName("copiedFrom")]
    public VoicemailCopyRecord CopiedFrom { get; private set; }



    /// <summary>
    /// Represents where this voicemail has been copied to
    /// </summary>
    /// <value>Represents where this voicemail has been copied to</value>
    [JsonPropertyName("copiedTo")]
    public List<VoicemailCopyRecord> CopiedTo { get; private set; }



    /// <summary>
    /// The retention policy for this voicemail when deleted is set to true
    /// </summary>
    /// <value>The retention policy for this voicemail when deleted is set to true</value>
    [JsonPropertyName("deleteRetentionPolicy")]
    public VoicemailRetentionPolicy DeleteRetentionPolicy { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VoicemailMessage {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Conversation: ").Append(Conversation).Append("\n");
        sb.Append("  Read: ").Append(Read).Append("\n");
        sb.Append("  AudioRecordingDurationSeconds: ").Append(AudioRecordingDurationSeconds).Append("\n");
        sb.Append("  AudioRecordingSizeBytes: ").Append(AudioRecordingSizeBytes).Append("\n");
        sb.Append("  Transcription: ").Append(Transcription).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        sb.Append("  DeletedDate: ").Append(DeletedDate).Append("\n");
        sb.Append("  CallerAddress: ").Append(CallerAddress).Append("\n");
        sb.Append("  CallerName: ").Append(CallerName).Append("\n");
        sb.Append("  CallerUser: ").Append(CallerUser).Append("\n");
        sb.Append("  Deleted: ").Append(Deleted).Append("\n");
        sb.Append("  Note: ").Append(Note).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Group: ").Append(Group).Append("\n");
        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  CopiedFrom: ").Append(CopiedFrom).Append("\n");
        sb.Append("  CopiedTo: ").Append(CopiedTo).Append("\n");
        sb.Append("  DeleteRetentionPolicy: ").Append(DeleteRetentionPolicy).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as VoicemailMessage);
    }

    /// <summary>
    /// Returns true if VoicemailMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of VoicemailMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VoicemailMessage other)
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
                Conversation == other.Conversation ||
                Conversation != null &&
                Conversation.Equals(other.Conversation)
            ) &&
            (
                Read == other.Read ||
                Read != null &&
                Read.Equals(other.Read)
            ) &&
            (
                AudioRecordingDurationSeconds == other.AudioRecordingDurationSeconds ||
                AudioRecordingDurationSeconds != null &&
                AudioRecordingDurationSeconds.Equals(other.AudioRecordingDurationSeconds)
            ) &&
            (
                AudioRecordingSizeBytes == other.AudioRecordingSizeBytes ||
                AudioRecordingSizeBytes != null &&
                AudioRecordingSizeBytes.Equals(other.AudioRecordingSizeBytes)
            ) &&
            (
                Transcription == other.Transcription ||
                Transcription != null &&
                Transcription.Equals(other.Transcription)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
            ) &&
            (
                DeletedDate == other.DeletedDate ||
                DeletedDate != null &&
                DeletedDate.Equals(other.DeletedDate)
            ) &&
            (
                CallerAddress == other.CallerAddress ||
                CallerAddress != null &&
                CallerAddress.Equals(other.CallerAddress)
            ) &&
            (
                CallerName == other.CallerName ||
                CallerName != null &&
                CallerName.Equals(other.CallerName)
            ) &&
            (
                CallerUser == other.CallerUser ||
                CallerUser != null &&
                CallerUser.Equals(other.CallerUser)
            ) &&
            (
                Deleted == other.Deleted ||
                Deleted != null &&
                Deleted.Equals(other.Deleted)
            ) &&
            (
                Note == other.Note ||
                Note != null &&
                Note.Equals(other.Note)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Group == other.Group ||
                Group != null &&
                Group.Equals(other.Group)
            ) &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                CopiedFrom == other.CopiedFrom ||
                CopiedFrom != null &&
                CopiedFrom.Equals(other.CopiedFrom)
            ) &&
            (
                CopiedTo == other.CopiedTo ||
                CopiedTo != null &&
                CopiedTo.SequenceEqual(other.CopiedTo)
            ) &&
            (
                DeleteRetentionPolicy == other.DeleteRetentionPolicy ||
                DeleteRetentionPolicy != null &&
                DeleteRetentionPolicy.Equals(other.DeleteRetentionPolicy)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (Conversation != null)
            {
                hash = hash * 59 + Conversation.GetHashCode();
            }

            if (Read != null)
            {
                hash = hash * 59 + Read.GetHashCode();
            }

            if (AudioRecordingDurationSeconds != null)
            {
                hash = hash * 59 + AudioRecordingDurationSeconds.GetHashCode();
            }

            if (AudioRecordingSizeBytes != null)
            {
                hash = hash * 59 + AudioRecordingSizeBytes.GetHashCode();
            }

            if (Transcription != null)
            {
                hash = hash * 59 + Transcription.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (DeletedDate != null)
            {
                hash = hash * 59 + DeletedDate.GetHashCode();
            }

            if (CallerAddress != null)
            {
                hash = hash * 59 + CallerAddress.GetHashCode();
            }

            if (CallerName != null)
            {
                hash = hash * 59 + CallerName.GetHashCode();
            }

            if (CallerUser != null)
            {
                hash = hash * 59 + CallerUser.GetHashCode();
            }

            if (Deleted != null)
            {
                hash = hash * 59 + Deleted.GetHashCode();
            }

            if (Note != null)
            {
                hash = hash * 59 + Note.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Group != null)
            {
                hash = hash * 59 + Group.GetHashCode();
            }

            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (CopiedFrom != null)
            {
                hash = hash * 59 + CopiedFrom.GetHashCode();
            }

            if (CopiedTo != null)
            {
                hash = hash * 59 + CopiedTo.GetHashCode();
            }

            if (DeleteRetentionPolicy != null)
            {
                hash = hash * 59 + DeleteRetentionPolicy.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
