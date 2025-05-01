using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// User reaction to public message.
/// </summary>
[DataContract]
public partial class ConversationContentReaction : IEquatable<ConversationContentReaction>
{
    /// <summary>
    /// Type of reaction.
    /// </summary>
    /// <value>Type of reaction.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ReactionTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum None for "None"
        /// </summary>
        [EnumMember(Value = "None")]
        None,

        /// <summary>
        /// Enum Like for "Like"
        /// </summary>
        [EnumMember(Value = "Like")]
        Like,

        /// <summary>
        /// Enum Love for "Love"
        /// </summary>
        [EnumMember(Value = "Love")]
        Love,

        /// <summary>
        /// Enum Wow for "Wow"
        /// </summary>
        [EnumMember(Value = "Wow")]
        Wow,

        /// <summary>
        /// Enum Haha for "Haha"
        /// </summary>
        [EnumMember(Value = "Haha")]
        Haha,

        /// <summary>
        /// Enum Sad for "Sad"
        /// </summary>
        [EnumMember(Value = "Sad")]
        Sad,

        /// <summary>
        /// Enum Angry for "Angry"
        /// </summary>
        [EnumMember(Value = "Angry")]
        Angry,

        /// <summary>
        /// Enum Thankful for "Thankful"
        /// </summary>
        [EnumMember(Value = "Thankful")]
        Thankful,

        /// <summary>
        /// Enum Pride for "Pride"
        /// </summary>
        [EnumMember(Value = "Pride")]
        Pride,

        /// <summary>
        /// Enum Care for "Care"
        /// </summary>
        [EnumMember(Value = "Care")]
        Care,

        /// <summary>
        /// Enum Share for "Share"
        /// </summary>
        [EnumMember(Value = "Share")]
        Share,

        /// <summary>
        /// Enum Comment for "Comment"
        /// </summary>
        [EnumMember(Value = "Comment")]
        Comment,

        /// <summary>
        /// Enum View for "View"
        /// </summary>
        [EnumMember(Value = "View")]
        View,

        /// <summary>
        /// Enum Rating for "Rating"
        /// </summary>
        [EnumMember(Value = "Rating")]
        Rating
    }
    /// <summary>
    /// Type of reaction.
    /// </summary>
    /// <value>Type of reaction.</value>
    [DataMember(Name = "reactionType", EmitDefaultValue = false)]
    public ReactionTypeEnum? ReactionType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationContentReaction" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConversationContentReaction() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ConversationContentReaction" /> class.
    /// </summary>
    /// <param name="ReactionType">Type of reaction..</param>
    /// <param name="Count">Number of users that reacted this way to the message. (required).</param>
    public ConversationContentReaction(ReactionTypeEnum? ReactionType = null, int? Count = null)
    {
        this.ReactionType = ReactionType;
        this.Count = Count;

    }





    /// <summary>
    /// Number of users that reacted this way to the message.
    /// </summary>
    /// <value>Number of users that reacted this way to the message.</value>
    [DataMember(Name = "count", EmitDefaultValue = false)]
    public int? Count { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConversationContentReaction {\n");

        sb.Append("  ReactionType: ").Append(ReactionType).Append("\n");
        sb.Append("  Count: ").Append(Count).Append("\n");
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
        return Equals(obj as ConversationContentReaction);
    }

    /// <summary>
    /// Returns true if ConversationContentReaction instances are equal
    /// </summary>
    /// <param name="other">Instance of ConversationContentReaction to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConversationContentReaction other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ReactionType == other.ReactionType ||
                ReactionType != null &&
                ReactionType.Equals(other.ReactionType)
            ) &&
            (
                Count == other.Count ||
                Count != null &&
                Count.Equals(other.Count)
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
            if (ReactionType != null)
            {
                hash = hash * 59 + ReactionType.GetHashCode();
            }

            if (Count != null)
            {
                hash = hash * 59 + Count.GetHashCode();
            }

            return hash;
        }
    }
}
