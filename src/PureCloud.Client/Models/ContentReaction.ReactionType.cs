using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Type of reaction.
/// </summary>
public enum ReactionType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

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
