using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Left hand side for dimension predicates
/// </summary>
/// <value>Left hand side for dimension predicates</value>

public enum PresenceDetailQueryPredicateDimensionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Organizationpresenceid for "organizationPresenceId"
    /// </summary>
    [EnumMember(Value = "organizationPresenceId")]
    Organizationpresenceid,

    /// <summary>
    /// Enum Systempresence for "systemPresence"
    /// </summary>
    [EnumMember(Value = "systemPresence")]
    Systempresence
}
