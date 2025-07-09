using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum AuditQueryFilterPropertyEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Userid for "UserId"
    /// </summary>
    [EnumMember(Value = "UserId")]
    Userid,

    /// <summary>
    /// Enum Trusteeorganizationid for "TrusteeOrganizationId"
    /// </summary>
    [EnumMember(Value = "TrusteeOrganizationId")]
    Trusteeorganizationid,

    /// <summary>
    /// Enum Clientid for "ClientId"
    /// </summary>
    [EnumMember(Value = "ClientId")]
    Clientid,

    /// <summary>
    /// Enum Action for "Action"
    /// </summary>
    [EnumMember(Value = "Action")]
    Action,

    /// <summary>
    /// Enum Entitytype for "EntityType"
    /// </summary>
    [EnumMember(Value = "EntityType")]
    Entitytype,

    /// <summary>
    /// Enum Entityid for "EntityId"
    /// </summary>
    [EnumMember(Value = "EntityId")]
    Entityid
}
