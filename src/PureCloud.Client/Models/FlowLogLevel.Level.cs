using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum FlowLogLevelLevelEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown,

    /// <summary>
    /// Enum Disabled for "Disabled"
    /// </summary>
    [EnumMember(Value = "Disabled")]
    Disabled,

    /// <summary>
    /// Enum Base for "Base"
    /// </summary>
    [EnumMember(Value = "Base")]
    Base,

    /// <summary>
    /// Enum Notes for "Notes"
    /// </summary>
    [EnumMember(Value = "Notes")]
    Notes,

    /// <summary>
    /// Enum Verbosenotes for "VerboseNotes"
    /// </summary>
    [EnumMember(Value = "VerboseNotes")]
    Verbosenotes,

    /// <summary>
    /// Enum All for "All"
    /// </summary>
    [EnumMember(Value = "All")]
    All
}
