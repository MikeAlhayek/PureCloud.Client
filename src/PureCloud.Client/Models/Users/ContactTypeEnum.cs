using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Users;


public enum ContactTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Primary for "PRIMARY"
    /// </summary>
    [EnumMember(Value = "PRIMARY")]
    Primary,

    /// <summary>
    /// Enum Work for "WORK"
    /// </summary>
    [EnumMember(Value = "WORK")]
    Work,

    /// <summary>
    /// Enum Work2 for "WORK2"
    /// </summary>
    [EnumMember(Value = "WORK2")]
    Work2,

    /// <summary>
    /// Enum Work3 for "WORK3"
    /// </summary>
    [EnumMember(Value = "WORK3")]
    Work3,

    /// <summary>
    /// Enum Work4 for "WORK4"
    /// </summary>
    [EnumMember(Value = "WORK4")]
    Work4,

    /// <summary>
    /// Enum Home for "HOME"
    /// </summary>
    [EnumMember(Value = "HOME")]
    Home,

    /// <summary>
    /// Enum Mobile for "MOBILE"
    /// </summary>
    [EnumMember(Value = "MOBILE")]
    Mobile,

    /// <summary>
    /// Enum Main for "MAIN"
    /// </summary>
    [EnumMember(Value = "MAIN")]
    Main,

    /// <summary>
    /// Enum Other for "OTHER"
    /// </summary>
    [EnumMember(Value = "OTHER")]
    Other,
}
