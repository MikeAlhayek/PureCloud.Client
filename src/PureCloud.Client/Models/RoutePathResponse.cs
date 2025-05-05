using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// RoutePathResponse
/// </summary>

public partial class RoutePathResponse : IEquatable<RoutePathResponse>
{
    /// <summary>
    /// The media type of the given queue associated with the route path
    /// </summary>
    /// <value>The media type of the given queue associated with the route path</value>
    
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
        /// Enum Voice for "Voice"
        /// </summary>
        [EnumMember(Value = "Voice")]
        Voice,

        /// <summary>
        /// Enum Chat for "Chat"
        /// </summary>
        [EnumMember(Value = "Chat")]
        Chat,

        /// <summary>
        /// Enum Email for "Email"
        /// </summary>
        [EnumMember(Value = "Email")]
        Email,

        /// <summary>
        /// Enum Callback for "Callback"
        /// </summary>
        [EnumMember(Value = "Callback")]
        Callback,

        /// <summary>
        /// Enum Message for "Message"
        /// </summary>
        [EnumMember(Value = "Message")]
        Message,

        /// <summary>
        /// Enum Workitem for "Workitem"
        /// </summary>
        [EnumMember(Value = "Workitem")]
        Workitem
    }
    /// <summary>
    /// The media type of the given queue associated with the route path
    /// </summary>
    /// <value>The media type of the given queue associated with the route path</value>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="RoutePathResponse" /> class.
    /// </summary>
    /// <param name="Queue">The ID of the queue associated with the route path.</param>
    /// <param name="MediaType">The media type of the given queue associated with the route path.</param>
    /// <param name="Language">The ID of the language associated with the route path.</param>
    /// <param name="Skills">The set of skills associated with the route path.</param>
    public RoutePathResponse(QueueReference Queue = null, MediaTypeEnum? MediaType = null, LanguageReference Language = null, List<RoutingSkillReference> Skills = null)
    {
        this.Queue = Queue;
        this.MediaType = MediaType;
        this.Language = Language;
        this.Skills = Skills;

    }



    /// <summary>
    /// The ID of the queue associated with the route path
    /// </summary>
    /// <value>The ID of the queue associated with the route path</value>
    [JsonPropertyName("queue")]
    public QueueReference Queue { get; set; }





    /// <summary>
    /// The ID of the language associated with the route path
    /// </summary>
    /// <value>The ID of the language associated with the route path</value>
    [JsonPropertyName("language")]
    public LanguageReference Language { get; set; }



    /// <summary>
    /// The set of skills associated with the route path
    /// </summary>
    /// <value>The set of skills associated with the route path</value>
    [JsonPropertyName("skills")]
    public List<RoutingSkillReference> Skills { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class RoutePathResponse {\n");

        sb.Append("  Queue: ").Append(Queue).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  Skills: ").Append(Skills).Append("\n");
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
        return Equals(obj as RoutePathResponse);
    }

    /// <summary>
    /// Returns true if RoutePathResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of RoutePathResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(RoutePathResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Queue == other.Queue ||
                Queue != null &&
                Queue.Equals(other.Queue)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                Skills == other.Skills ||
                Skills != null &&
                Skills.SequenceEqual(other.Skills)
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
            if (Queue != null)
            {
                hash = hash * 59 + Queue.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (Skills != null)
            {
                hash = hash * 59 + Skills.GetHashCode();
            }

            return hash;
        }
    }
}
