using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum RoomRoomTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Adhoc for "adhoc"
    /// </summary>
    [EnumMember(Value = "adhoc")]
    Adhoc,

    /// <summary>
    /// Enum Acd for "acd"
    /// </summary>
    [EnumMember(Value = "acd")]
    Acd,

    /// <summary>
    /// Enum Group for "group"
    /// </summary>
    [EnumMember(Value = "group")]
    Group,

    /// <summary>
    /// Enum Oneonone for "oneOnOne"
    /// </summary>
    [EnumMember(Value = "oneOnOne")]
    Oneonone,

    /// <summary>
    /// Enum Supervisorassistance for "supervisorAssistance"
    /// </summary>
    [EnumMember(Value = "supervisorAssistance")]
    Supervisorassistance
}
