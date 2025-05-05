using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AssistantQueue
/// </summary>

public partial class AssistantQueue : IEquatable<AssistantQueue>
{
    /// <summary>
    /// Gets or Sets MediaTypes
    /// </summary>
    
    public enum MediaTypesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Call for "Call"
        /// </summary>
        [EnumMember(Value = "Call")]
        Call,

        /// <summary>
        /// Enum Email for "Email"
        /// </summary>
        [EnumMember(Value = "Email")]
        Email,

        /// <summary>
        /// Enum Message for "Message"
        /// </summary>
        [EnumMember(Value = "Message")]
        Message
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="AssistantQueue" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AssistantQueue() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AssistantQueue" /> class.
    /// </summary>
    /// <param name="Id">The globally unique identifier for the queue. (required).</param>
    /// <param name="MediaTypes">List of media Types in which the assistant is activated for this queue. (required).</param>
    public AssistantQueue(string Id = null, List<MediaTypesEnum> MediaTypes = null)
    {
        this.Id = Id;
        this.MediaTypes = MediaTypes;

    }



    /// <summary>
    /// The globally unique identifier for the queue.
    /// </summary>
    /// <value>The globally unique identifier for the queue.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// List of media Types in which the assistant is activated for this queue.
    /// </summary>
    /// <value>List of media Types in which the assistant is activated for this queue.</value>
    [JsonPropertyName("mediaTypes")]
    public List<MediaTypesEnum> MediaTypes { get; set; }



    /// <summary>
    /// Assistant to which the queue is assigned.
    /// </summary>
    /// <value>Assistant to which the queue is assigned.</value>
    [JsonPropertyName("assistant")]
    public Assistant Assistant { get; private set; }



    /// <summary>
    /// Date when the assistant queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the assistant queue was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// Date when the assistant queue was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date when the assistant queue was last modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



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
        sb.Append("class AssistantQueue {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  MediaTypes: ").Append(MediaTypes).Append("\n");
        sb.Append("  Assistant: ").Append(Assistant).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
        return Equals(obj as AssistantQueue);
    }

    /// <summary>
    /// Returns true if AssistantQueue instances are equal
    /// </summary>
    /// <param name="other">Instance of AssistantQueue to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AssistantQueue other)
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
                MediaTypes == other.MediaTypes ||
                MediaTypes != null &&
                MediaTypes.SequenceEqual(other.MediaTypes)
            ) &&
            (
                Assistant == other.Assistant ||
                Assistant != null &&
                Assistant.Equals(other.Assistant)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
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

            if (MediaTypes != null)
            {
                hash = hash * 59 + MediaTypes.GetHashCode();
            }

            if (Assistant != null)
            {
                hash = hash * 59 + Assistant.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
