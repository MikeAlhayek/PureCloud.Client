using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum PermissionDetailsType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Requirescurrentuser for "requiresCurrentUser"
    /// </summary>
    [EnumMember(Value = "requiresCurrentUser")]
    Requirescurrentuser,

    /// <summary>
    /// Enum Requirespermissions for "requiresPermissions"
    /// </summary>
    [EnumMember(Value = "requiresPermissions")]
    Requirespermissions,

    /// <summary>
    /// Enum Requiresdivisionpermissions for "requiresDivisionPermissions"
    /// </summary>
    [EnumMember(Value = "requiresDivisionPermissions")]
    Requiresdivisionpermissions,

    /// <summary>
    /// Enum Requiresanydivisionpermissions for "requiresAnyDivisionPermissions"
    /// </summary>
    [EnumMember(Value = "requiresAnyDivisionPermissions")]
    Requiresanydivisionpermissions,

    /// <summary>
    /// Enum Requiresuserbeconversationparticipant for "requiresUserBeConversationParticipant"
    /// </summary>
    [EnumMember(Value = "requiresUserBeConversationParticipant")]
    Requiresuserbeconversationparticipant
}
