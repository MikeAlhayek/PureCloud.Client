using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Describes the type of error associated with the AI answer.
/// </summary>
/// <value>Describes the type of error associated with the AI answer.</value>

public enum AiAnswerFailureType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Lowconfidenceerror for "LowConfidenceError"
    /// </summary>
    [EnumMember(Value = "LowConfidenceError")]
    Lowconfidenceerror,

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
    /// Enum Lowhistoricalaccuracyerror for "LowHistoricalAccuracyError"
    /// </summary>
    [EnumMember(Value = "LowHistoricalAccuracyError")]
    Lowhistoricalaccuracyerror
}
