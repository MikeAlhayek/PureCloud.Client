using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The type of error that occurred while processing AI scores. It is null where there is no error.
/// </summary>
/// <value>The type of error that occurred while processing AI scores. It is null where there is no error.</value>

public enum AiScoringFailureType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Quotareached for "QuotaReached"
    /// </summary>
    [EnumMember(Value = "QuotaReached")]
    Quotareached,

    /// <summary>
    /// Enum Parsingerror for "ParsingError"
    /// </summary>
    [EnumMember(Value = "ParsingError")]
    Parsingerror,

    /// <summary>
    /// Enum Serviceerror for "ServiceError"
    /// </summary>
    [EnumMember(Value = "ServiceError")]
    Serviceerror,

    /// <summary>
    /// Enum Invalidrequest for "InvalidRequest"
    /// </summary>
    [EnumMember(Value = "InvalidRequest")]
    Invalidrequest,

    /// <summary>
    /// Enum Duplicateformsameagent for "DuplicateFormSameAgent"
    /// </summary>
    [EnumMember(Value = "DuplicateFormSameAgent")]
    Duplicateformsameagent,

    /// <summary>
    /// Enum Unauthorized for "Unauthorized"
    /// </summary>
    [EnumMember(Value = "Unauthorized")]
    Unauthorized
}
