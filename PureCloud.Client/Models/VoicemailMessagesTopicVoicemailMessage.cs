using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// VoicemailMessagesTopicVoicemailMessage
/// </summary>

public partial class VoicemailMessagesTopicVoicemailMessage : IEquatable<VoicemailMessagesTopicVoicemailMessage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="VoicemailMessagesTopicVoicemailMessage" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="Read">Read.</param>
    /// <param name="AudioRecordingDurationSeconds">AudioRecordingDurationSeconds.</param>
    /// <param name="AudioRecordingSizeBytes">AudioRecordingSizeBytes.</param>
    /// <param name="CreatedDate">CreatedDate.</param>
    /// <param name="ModifiedDate">ModifiedDate.</param>
    /// <param name="CreatedDateString">CreatedDateString.</param>
    /// <param name="CallerAddress">CallerAddress.</param>
    /// <param name="CallerName">CallerName.</param>
    /// <param name="Action">Action.</param>
    /// <param name="Note">Note.</param>
    /// <param name="Deleted">Deleted.</param>
    /// <param name="ModifiedByUserId">ModifiedByUserId.</param>
    /// <param name="CopiedTo">CopiedTo.</param>
    /// <param name="CopiedFrom">CopiedFrom.</param>
    /// <param name="ModifiedDateString">ModifiedDateString.</param>
    public VoicemailMessagesTopicVoicemailMessage(string Id = null, bool? Read = null, long? AudioRecordingDurationSeconds = null, long? AudioRecordingSizeBytes = null, DateTime? CreatedDate = null, DateTime? ModifiedDate = null, string CreatedDateString = null, string CallerAddress = null, string CallerName = null, string Action = null, string Note = null, bool? Deleted = null, string ModifiedByUserId = null, List<VoicemailMessagesTopicVoicemailCopyRecord> CopiedTo = null, VoicemailMessagesTopicVoicemailCopyRecord CopiedFrom = null, string ModifiedDateString = null)
    {
        this.Id = Id;
        this.Read = Read;
        this.AudioRecordingDurationSeconds = AudioRecordingDurationSeconds;
        this.AudioRecordingSizeBytes = AudioRecordingSizeBytes;
        this.CreatedDate = CreatedDate;
        this.ModifiedDate = ModifiedDate;
        this.CreatedDateString = CreatedDateString;
        this.CallerAddress = CallerAddress;
        this.CallerName = CallerName;
        this.Action = Action;
        this.Note = Note;
        this.Deleted = Deleted;
        this.ModifiedByUserId = ModifiedByUserId;
        this.CopiedTo = CopiedTo;
        this.CopiedFrom = CopiedFrom;
        this.ModifiedDateString = ModifiedDateString;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Read
    /// </summary>
    [JsonPropertyName("read")]
    public bool? Read { get; set; }



    /// <summary>
    /// Gets or Sets AudioRecordingDurationSeconds
    /// </summary>
    [JsonPropertyName("audioRecordingDurationSeconds")]
    public long? AudioRecordingDurationSeconds { get; set; }



    /// <summary>
    /// Gets or Sets AudioRecordingSizeBytes
    /// </summary>
    [JsonPropertyName("audioRecordingSizeBytes")]
    public long? AudioRecordingSizeBytes { get; set; }



    /// <summary>
    /// Gets or Sets CreatedDate
    /// </summary>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedDate
    /// </summary>
    [JsonPropertyName("modifiedDate")]
    public DateTime? ModifiedDate { get; set; }



    /// <summary>
    /// Gets or Sets CreatedDateString
    /// </summary>
    [JsonPropertyName("createdDateString")]
    public string CreatedDateString { get; set; }



    /// <summary>
    /// Gets or Sets CallerAddress
    /// </summary>
    [JsonPropertyName("callerAddress")]
    public string CallerAddress { get; set; }



    /// <summary>
    /// Gets or Sets CallerName
    /// </summary>
    [JsonPropertyName("callerName")]
    public string CallerName { get; set; }



    /// <summary>
    /// Gets or Sets Action
    /// </summary>
    [JsonPropertyName("action")]
    public string Action { get; set; }



    /// <summary>
    /// Gets or Sets Note
    /// </summary>
    [JsonPropertyName("note")]
    public string Note { get; set; }



    /// <summary>
    /// Gets or Sets Deleted
    /// </summary>
    [JsonPropertyName("deleted")]
    public bool? Deleted { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedByUserId
    /// </summary>
    [JsonPropertyName("modifiedByUserId")]
    public string ModifiedByUserId { get; set; }



    /// <summary>
    /// Gets or Sets CopiedTo
    /// </summary>
    [JsonPropertyName("copiedTo")]
    public List<VoicemailMessagesTopicVoicemailCopyRecord> CopiedTo { get; set; }



    /// <summary>
    /// Gets or Sets CopiedFrom
    /// </summary>
    [JsonPropertyName("copiedFrom")]
    public VoicemailMessagesTopicVoicemailCopyRecord CopiedFrom { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedDateString
    /// </summary>
    [JsonPropertyName("modifiedDateString")]
    public string ModifiedDateString { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VoicemailMessagesTopicVoicemailMessage {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Read: ").Append(Read).Append("\n");
        sb.Append("  AudioRecordingDurationSeconds: ").Append(AudioRecordingDurationSeconds).Append("\n");
        sb.Append("  AudioRecordingSizeBytes: ").Append(AudioRecordingSizeBytes).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        sb.Append("  CreatedDateString: ").Append(CreatedDateString).Append("\n");
        sb.Append("  CallerAddress: ").Append(CallerAddress).Append("\n");
        sb.Append("  CallerName: ").Append(CallerName).Append("\n");
        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  Note: ").Append(Note).Append("\n");
        sb.Append("  Deleted: ").Append(Deleted).Append("\n");
        sb.Append("  ModifiedByUserId: ").Append(ModifiedByUserId).Append("\n");
        sb.Append("  CopiedTo: ").Append(CopiedTo).Append("\n");
        sb.Append("  CopiedFrom: ").Append(CopiedFrom).Append("\n");
        sb.Append("  ModifiedDateString: ").Append(ModifiedDateString).Append("\n");
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
        return Equals(obj as VoicemailMessagesTopicVoicemailMessage);
    }

    /// <summary>
    /// Returns true if VoicemailMessagesTopicVoicemailMessage instances are equal
    /// </summary>
    /// <param name="other">Instance of VoicemailMessagesTopicVoicemailMessage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VoicemailMessagesTopicVoicemailMessage other)
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
                CreatedDateString == other.CreatedDateString ||
                CreatedDateString != null &&
                CreatedDateString.Equals(other.CreatedDateString)
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
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                Note == other.Note ||
                Note != null &&
                Note.Equals(other.Note)
            ) &&
            (
                Deleted == other.Deleted ||
                Deleted != null &&
                Deleted.Equals(other.Deleted)
            ) &&
            (
                ModifiedByUserId == other.ModifiedByUserId ||
                ModifiedByUserId != null &&
                ModifiedByUserId.Equals(other.ModifiedByUserId)
            ) &&
            (
                CopiedTo == other.CopiedTo ||
                CopiedTo != null &&
                CopiedTo.SequenceEqual(other.CopiedTo)
            ) &&
            (
                CopiedFrom == other.CopiedFrom ||
                CopiedFrom != null &&
                CopiedFrom.Equals(other.CopiedFrom)
            ) &&
            (
                ModifiedDateString == other.ModifiedDateString ||
                ModifiedDateString != null &&
                ModifiedDateString.Equals(other.ModifiedDateString)
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

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (CreatedDateString != null)
            {
                hash = hash * 59 + CreatedDateString.GetHashCode();
            }

            if (CallerAddress != null)
            {
                hash = hash * 59 + CallerAddress.GetHashCode();
            }

            if (CallerName != null)
            {
                hash = hash * 59 + CallerName.GetHashCode();
            }

            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (Note != null)
            {
                hash = hash * 59 + Note.GetHashCode();
            }

            if (Deleted != null)
            {
                hash = hash * 59 + Deleted.GetHashCode();
            }

            if (ModifiedByUserId != null)
            {
                hash = hash * 59 + ModifiedByUserId.GetHashCode();
            }

            if (CopiedTo != null)
            {
                hash = hash * 59 + CopiedTo.GetHashCode();
            }

            if (CopiedFrom != null)
            {
                hash = hash * 59 + CopiedFrom.GetHashCode();
            }

            if (ModifiedDateString != null)
            {
                hash = hash * 59 + ModifiedDateString.GetHashCode();
            }

            return hash;
        }
    }
}
