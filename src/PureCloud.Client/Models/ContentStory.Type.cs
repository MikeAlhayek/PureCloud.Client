using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ContentStoryType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Mention for "Mention"
    /// </summary>
    [EnumMember(Value = "Mention")]
    Mention,

    /// <summary>
    /// Enum Reply for "Reply"
    /// </summary>
    [EnumMember(Value = "Reply")]
    Reply
}
