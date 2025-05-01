using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueueConversationCobrowseEventTopicWrapup
/// </summary>
[DataContract]
public partial class QueueConversationCobrowseEventTopicWrapup : IEquatable<QueueConversationCobrowseEventTopicWrapup>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="QueueConversationCobrowseEventTopicWrapup" /> class.
    /// </summary>
    /// <param name="Code">The user configured wrap up code name..</param>
    /// <param name="Notes">Text entered by the agent to describe the call or disposition..</param>
    /// <param name="Tags">List of tags selected by the agent to describe the call or disposition..</param>
    /// <param name="DurationSeconds">The length of time in seconds that the agent spent doing after call work., Note, the format of utc-millisec should be ignored, our code generator needs it to generate a Long for us internally.</param>
    /// <param name="EndTime">The timestamp when the wrapup was finished..</param>
    public QueueConversationCobrowseEventTopicWrapup(string Code = null, string Notes = null, List<string> Tags = null, long? DurationSeconds = null, DateTime? EndTime = null)
    {
        this.Code = Code;
        this.Notes = Notes;
        this.Tags = Tags;
        this.DurationSeconds = DurationSeconds;
        this.EndTime = EndTime;

    }



    /// <summary>
    /// The user configured wrap up code name.
    /// </summary>
    /// <value>The user configured wrap up code name.</value>
    [DataMember(Name = "code", EmitDefaultValue = false)]
    public string Code { get; set; }



    /// <summary>
    /// Text entered by the agent to describe the call or disposition.
    /// </summary>
    /// <value>Text entered by the agent to describe the call or disposition.</value>
    [DataMember(Name = "notes", EmitDefaultValue = false)]
    public string Notes { get; set; }



    /// <summary>
    /// List of tags selected by the agent to describe the call or disposition.
    /// </summary>
    /// <value>List of tags selected by the agent to describe the call or disposition.</value>
    [DataMember(Name = "tags", EmitDefaultValue = false)]
    public List<string> Tags { get; set; }



    /// <summary>
    /// The length of time in seconds that the agent spent doing after call work., Note, the format of utc-millisec should be ignored, our code generator needs it to generate a Long for us internally
    /// </summary>
    /// <value>The length of time in seconds that the agent spent doing after call work., Note, the format of utc-millisec should be ignored, our code generator needs it to generate a Long for us internally</value>
    [DataMember(Name = "durationSeconds", EmitDefaultValue = false)]
    public long? DurationSeconds { get; set; }



    /// <summary>
    /// The timestamp when the wrapup was finished.
    /// </summary>
    /// <value>The timestamp when the wrapup was finished.</value>
    [DataMember(Name = "endTime", EmitDefaultValue = false)]
    public DateTime? EndTime { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueueConversationCobrowseEventTopicWrapup {\n");

        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
        sb.Append("  DurationSeconds: ").Append(DurationSeconds).Append("\n");
        sb.Append("  EndTime: ").Append(EndTime).Append("\n");
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
        return Equals(obj as QueueConversationCobrowseEventTopicWrapup);
    }

    /// <summary>
    /// Returns true if QueueConversationCobrowseEventTopicWrapup instances are equal
    /// </summary>
    /// <param name="other">Instance of QueueConversationCobrowseEventTopicWrapup to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueueConversationCobrowseEventTopicWrapup other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Code == other.Code ||
                Code != null &&
                Code.Equals(other.Code)
            ) &&
            (
                Notes == other.Notes ||
                Notes != null &&
                Notes.Equals(other.Notes)
            ) &&
            (
                Tags == other.Tags ||
                Tags != null &&
                Tags.SequenceEqual(other.Tags)
            ) &&
            (
                DurationSeconds == other.DurationSeconds ||
                DurationSeconds != null &&
                DurationSeconds.Equals(other.DurationSeconds)
            ) &&
            (
                EndTime == other.EndTime ||
                EndTime != null &&
                EndTime.Equals(other.EndTime)
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
            if (Code != null)
            {
                hash = hash * 59 + Code.GetHashCode();
            }

            if (Notes != null)
            {
                hash = hash * 59 + Notes.GetHashCode();
            }

            if (Tags != null)
            {
                hash = hash * 59 + Tags.GetHashCode();
            }

            if (DurationSeconds != null)
            {
                hash = hash * 59 + DurationSeconds.GetHashCode();
            }

            if (EndTime != null)
            {
                hash = hash * 59 + EndTime.GetHashCode();
            }

            return hash;
        }
    }
}
