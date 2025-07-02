using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Left hand side for property predicates
/// </summary>
/// <value>Left hand side for property predicates</value>

public enum SegmentDetailQueryPredicatePropertyTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Bool for "bool"
    /// </summary>
    [EnumMember(Value = "bool")]
    Bool,

    /// <summary>
    /// Enum Integer for "integer"
    /// </summary>
    [EnumMember(Value = "integer")]
    Integer,

    /// <summary>
    /// Enum Real for "real"
    /// </summary>
    [EnumMember(Value = "real")]
    Real,

    /// <summary>
    /// Enum Date for "date"
    /// </summary>
    [EnumMember(Value = "date")]
    Date,

    /// <summary>
    /// Enum String for "string"
    /// </summary>
    [EnumMember(Value = "string")]
    String,

    /// <summary>
    /// Enum Uuid for "uuid"
    /// </summary>
    [EnumMember(Value = "uuid")]
    Uuid
}
