using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum RecordingAttachmentMediaTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Image for "Image"
    /// </summary>
    [EnumMember(Value = "Image")]
    Image,

    /// <summary>
    /// Enum Video for "Video"
    /// </summary>
    [EnumMember(Value = "Video")]
    Video,

    /// <summary>
    /// Enum Audio for "Audio"
    /// </summary>
    [EnumMember(Value = "Audio")]
    Audio,

    /// <summary>
    /// Enum File for "File"
    /// </summary>
    [EnumMember(Value = "File")]
    File,

    /// <summary>
    /// Enum Link for "Link"
    /// </summary>
    [EnumMember(Value = "Link")]
    Link
}
