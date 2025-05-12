using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ExternalContactsContactNoteChangedTopicNoteEntityTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Contact for "Contact"
    /// </summary>
    [EnumMember(Value = "Contact")]
    Contact,

    /// <summary>
    /// Enum Organization for "Organization"
    /// </summary>
    [EnumMember(Value = "Organization")]
    Organization
}
