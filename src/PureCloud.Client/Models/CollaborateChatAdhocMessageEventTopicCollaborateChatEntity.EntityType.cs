using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum CollaborateChatAdhocMessageEventTopicCollaborateChatEntityEntityTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Group for "Group"
    /// </summary>
    [EnumMember(Value = "Group")]
    Group,

    /// <summary>
    /// Enum User for "User"
    /// </summary>
    [EnumMember(Value = "User")]
    User,

    /// <summary>
    /// Enum Adhoc for "Adhoc"
    /// </summary>
    [EnumMember(Value = "Adhoc")]
    Adhoc
}
