using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Left hand side for dimension predicates
/// </summary>
/// <value>Left hand side for dimension predicates</value>

public enum ActionAggregateQueryPredicateDimensionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Actioncategory for "actionCategory"
    /// </summary>
    [EnumMember(Value = "actionCategory")]
    Actioncategory,

    /// <summary>
    /// Enum Actionid for "actionId"
    /// </summary>
    [EnumMember(Value = "actionId")]
    Actionid,

    /// <summary>
    /// Enum Actionname for "actionName"
    /// </summary>
    [EnumMember(Value = "actionName")]
    Actionname,

    /// <summary>
    /// Enum Correlationid for "correlationId"
    /// </summary>
    [EnumMember(Value = "correlationId")]
    Correlationid,

    /// <summary>
    /// Enum Errortype for "errorType"
    /// </summary>
    [EnumMember(Value = "errorType")]
    Errortype,

    /// <summary>
    /// Enum Integrationid for "integrationId"
    /// </summary>
    [EnumMember(Value = "integrationId")]
    Integrationid,

    /// <summary>
    /// Enum Integrationname for "integrationName"
    /// </summary>
    [EnumMember(Value = "integrationName")]
    Integrationname,

    /// <summary>
    /// Enum Responsestatus for "responseStatus"
    /// </summary>
    [EnumMember(Value = "responseStatus")]
    Responsestatus
}
