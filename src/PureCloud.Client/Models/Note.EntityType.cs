using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum NoteEntityTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Contact for "contact"
    /// </summary>
    [EnumMember(Value = "contact")]
    Contact,

    /// <summary>
    /// Enum Organization for "organization"
    /// </summary>
    [EnumMember(Value = "organization")]
    Organization
}
