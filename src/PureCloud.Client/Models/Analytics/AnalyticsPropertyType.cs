using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Analytics;

/// <summary>
/// Indicates what the data type is (e.g. integer vs string) and therefore how to evaluate what would constitute a match
/// </summary>
/// <value>Indicates what the data type is (e.g. integer vs string) and therefore how to evaluate what would constitute a match</value>

public enum AnalyticsPropertyType
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
