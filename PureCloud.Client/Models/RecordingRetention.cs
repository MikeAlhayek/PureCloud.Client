using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RecordingRetention
/// </summary>
[DataContract]
public partial class RecordingRetention : IEquatable<RecordingRetention>
{
    /// <summary>
    /// The type of archive medium used. Example: CloudArchive
    /// </summary>
    /// <value>The type of archive medium used. Example: CloudArchive</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ArchiveMediumEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Cloudarchive for "CLOUDARCHIVE"
        /// </summary>
        [EnumMember(Value = "CLOUDARCHIVE")]
        Cloudarchive
    }
    /// <summary>
    /// The type of archive medium used. Example: CloudArchive
    /// </summary>
    /// <value>The type of archive medium used. Example: CloudArchive</value>
    [DataMember(Name = "archiveMedium", EmitDefaultValue = false)]
    public ArchiveMediumEnum? ArchiveMedium { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="RecordingRetention" /> class.
    /// </summary>
    /// <param name="ConversationId">ConversationId.</param>
    /// <param name="RecordingId">RecordingId.</param>
    /// <param name="ArchiveDate">The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ArchiveMedium">The type of archive medium used. Example: CloudArchive.</param>
    /// <param name="DeleteDate">The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ExportDate">The date the recording will be exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ExportedDate">The date the recording was exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreationTime">The creation time of the recording. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public RecordingRetention(string ConversationId = null, string RecordingId = null, DateTime? ArchiveDate = null, ArchiveMediumEnum? ArchiveMedium = null, DateTime? DeleteDate = null, DateTime? ExportDate = null, DateTime? ExportedDate = null, DateTime? CreationTime = null)
    {
        this.ConversationId = ConversationId;
        this.RecordingId = RecordingId;
        this.ArchiveDate = ArchiveDate;
        this.ArchiveMedium = ArchiveMedium;
        this.DeleteDate = DeleteDate;
        this.ExportDate = ExportDate;
        this.ExportedDate = ExportedDate;
        this.CreationTime = CreationTime;

    }



    /// <summary>
    /// Gets or Sets ConversationId
    /// </summary>
    [DataMember(Name = "conversationId", EmitDefaultValue = false)]
    public string ConversationId { get; set; }



    /// <summary>
    /// Gets or Sets RecordingId
    /// </summary>
    [DataMember(Name = "recordingId", EmitDefaultValue = false)]
    public string RecordingId { get; set; }



    /// <summary>
    /// The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the recording will be archived. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "archiveDate", EmitDefaultValue = false)]
    public DateTime? ArchiveDate { get; set; }





    /// <summary>
    /// The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the recording will be deleted. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "deleteDate", EmitDefaultValue = false)]
    public DateTime? DeleteDate { get; set; }



    /// <summary>
    /// The date the recording will be exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the recording will be exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "exportDate", EmitDefaultValue = false)]
    public DateTime? ExportDate { get; set; }



    /// <summary>
    /// The date the recording was exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the recording was exported. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "exportedDate", EmitDefaultValue = false)]
    public DateTime? ExportedDate { get; set; }



    /// <summary>
    /// The creation time of the recording. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The creation time of the recording. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "creationTime", EmitDefaultValue = false)]
    public DateTime? CreationTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RecordingRetention {\n");

        sb.Append("  ConversationId: ").Append(ConversationId).Append("\n");
        sb.Append("  RecordingId: ").Append(RecordingId).Append("\n");
        sb.Append("  ArchiveDate: ").Append(ArchiveDate).Append("\n");
        sb.Append("  ArchiveMedium: ").Append(ArchiveMedium).Append("\n");
        sb.Append("  DeleteDate: ").Append(DeleteDate).Append("\n");
        sb.Append("  ExportDate: ").Append(ExportDate).Append("\n");
        sb.Append("  ExportedDate: ").Append(ExportedDate).Append("\n");
        sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
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
        return Equals(obj as RecordingRetention);
    }

    /// <summary>
    /// Returns true if RecordingRetention instances are equal
    /// </summary>
    /// <param name="other">Instance of RecordingRetention to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RecordingRetention other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ConversationId == other.ConversationId ||
                ConversationId != null &&
                ConversationId.Equals(other.ConversationId)
            ) &&
            (
                RecordingId == other.RecordingId ||
                RecordingId != null &&
                RecordingId.Equals(other.RecordingId)
            ) &&
            (
                ArchiveDate == other.ArchiveDate ||
                ArchiveDate != null &&
                ArchiveDate.Equals(other.ArchiveDate)
            ) &&
            (
                ArchiveMedium == other.ArchiveMedium ||
                ArchiveMedium != null &&
                ArchiveMedium.Equals(other.ArchiveMedium)
            ) &&
            (
                DeleteDate == other.DeleteDate ||
                DeleteDate != null &&
                DeleteDate.Equals(other.DeleteDate)
            ) &&
            (
                ExportDate == other.ExportDate ||
                ExportDate != null &&
                ExportDate.Equals(other.ExportDate)
            ) &&
            (
                ExportedDate == other.ExportedDate ||
                ExportedDate != null &&
                ExportedDate.Equals(other.ExportedDate)
            ) &&
            (
                CreationTime == other.CreationTime ||
                CreationTime != null &&
                CreationTime.Equals(other.CreationTime)
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
            if (ConversationId != null)
            {
                hash = hash * 59 + ConversationId.GetHashCode();
            }

            if (RecordingId != null)
            {
                hash = hash * 59 + RecordingId.GetHashCode();
            }

            if (ArchiveDate != null)
            {
                hash = hash * 59 + ArchiveDate.GetHashCode();
            }

            if (ArchiveMedium != null)
            {
                hash = hash * 59 + ArchiveMedium.GetHashCode();
            }

            if (DeleteDate != null)
            {
                hash = hash * 59 + DeleteDate.GetHashCode();
            }

            if (ExportDate != null)
            {
                hash = hash * 59 + ExportDate.GetHashCode();
            }

            if (ExportedDate != null)
            {
                hash = hash * 59 + ExportedDate.GetHashCode();
            }

            if (CreationTime != null)
            {
                hash = hash * 59 + CreationTime.GetHashCode();
            }

            return hash;
        }
    }
}
