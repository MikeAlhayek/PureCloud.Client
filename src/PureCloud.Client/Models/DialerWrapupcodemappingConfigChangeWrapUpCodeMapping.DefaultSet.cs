using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DialerWrapupcodemappingConfigChangeWrapUpCodeMappingDefaultSetEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum ContactUncallable for "CONTACT_UNCALLABLE"
    /// </summary>
    [EnumMember(Value = "CONTACT_UNCALLABLE")]
    ContactUncallable,

    /// <summary>
    /// Enum NumberUncallable for "NUMBER_UNCALLABLE"
    /// </summary>
    [EnumMember(Value = "NUMBER_UNCALLABLE")]
    NumberUncallable,

    /// <summary>
    /// Enum RightPartyContact for "RIGHT_PARTY_CONTACT"
    /// </summary>
    [EnumMember(Value = "RIGHT_PARTY_CONTACT")]
    RightPartyContact
}
