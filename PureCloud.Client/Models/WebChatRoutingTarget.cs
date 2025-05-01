using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WebChatRoutingTarget
/// </summary>
[DataContract]
public partial class WebChatRoutingTarget : IEquatable<WebChatRoutingTarget>
{
    /// <summary>
    /// The target type of the routing target, such as 'QUEUE'.
    /// </summary>
    /// <value>The target type of the routing target, such as 'QUEUE'.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TargetTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Queue for "QUEUE"
        /// </summary>
        [EnumMember(Value = "QUEUE")]
        Queue
    }
    /// <summary>
    /// The target type of the routing target, such as 'QUEUE'.
    /// </summary>
    /// <value>The target type of the routing target, such as 'QUEUE'.</value>
    [DataMember(Name = "targetType", EmitDefaultValue = false)]
    public TargetTypeEnum? TargetType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WebChatRoutingTarget" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WebChatRoutingTarget() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WebChatRoutingTarget" /> class.
    /// </summary>
    /// <param name="TargetType">The target type of the routing target, such as &#39;QUEUE&#39;. (required).</param>
    /// <param name="TargetAddress">The target of the route, in the format appropriate given the &#39;targetType&#39;. (required).</param>
    /// <param name="Skills">The list of skill names to use for routing..</param>
    /// <param name="Language">The language name to use for routing..</param>
    /// <param name="Priority">The priority to assign to the conversation for routing..</param>
    public WebChatRoutingTarget(TargetTypeEnum? TargetType = null, string TargetAddress = null, List<string> Skills = null, string Language = null, long? Priority = null)
    {
        this.TargetType = TargetType;
        this.TargetAddress = TargetAddress;
        this.Skills = Skills;
        this.Language = Language;
        this.Priority = Priority;

    }





    /// <summary>
    /// The target of the route, in the format appropriate given the &#39;targetType&#39;.
    /// </summary>
    /// <value>The target of the route, in the format appropriate given the &#39;targetType&#39;.</value>
    [DataMember(Name = "targetAddress", EmitDefaultValue = false)]
    public string TargetAddress { get; set; }



    /// <summary>
    /// The list of skill names to use for routing.
    /// </summary>
    /// <value>The list of skill names to use for routing.</value>
    [DataMember(Name = "skills", EmitDefaultValue = false)]
    public List<string> Skills { get; set; }



    /// <summary>
    /// The language name to use for routing.
    /// </summary>
    /// <value>The language name to use for routing.</value>
    [DataMember(Name = "language", EmitDefaultValue = false)]
    public string Language { get; set; }



    /// <summary>
    /// The priority to assign to the conversation for routing.
    /// </summary>
    /// <value>The priority to assign to the conversation for routing.</value>
    [DataMember(Name = "priority", EmitDefaultValue = false)]
    public long? Priority { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WebChatRoutingTarget {\n");

        sb.Append("  TargetType: ").Append(TargetType).Append("\n");
        sb.Append("  TargetAddress: ").Append(TargetAddress).Append("\n");
        sb.Append("  Skills: ").Append(Skills).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  Priority: ").Append(Priority).Append("\n");
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
        return Equals(obj as WebChatRoutingTarget);
    }

    /// <summary>
    /// Returns true if WebChatRoutingTarget instances are equal
    /// </summary>
    /// <param name="other">Instance of WebChatRoutingTarget to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WebChatRoutingTarget other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TargetType == other.TargetType ||
                TargetType != null &&
                TargetType.Equals(other.TargetType)
            ) &&
            (
                TargetAddress == other.TargetAddress ||
                TargetAddress != null &&
                TargetAddress.Equals(other.TargetAddress)
            ) &&
            (
                Skills == other.Skills ||
                Skills != null &&
                Skills.SequenceEqual(other.Skills)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                Priority == other.Priority ||
                Priority != null &&
                Priority.Equals(other.Priority)
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
            if (TargetType != null)
            {
                hash = hash * 59 + TargetType.GetHashCode();
            }

            if (TargetAddress != null)
            {
                hash = hash * 59 + TargetAddress.GetHashCode();
            }

            if (Skills != null)
            {
                hash = hash * 59 + Skills.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (Priority != null)
            {
                hash = hash * 59 + Priority.GetHashCode();
            }

            return hash;
        }
    }
}
