using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The state of the rule the query will return.  The accepted choices are Enabled, Disabled, or All
/// </summary>
/// <value>The state of the rule the query will return.  The accepted choices are Enabled, Disabled, or All</value>

public enum GetRulesQueryEnabledTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Enabled for "Enabled"
    /// </summary>
    [EnumMember(Value = "Enabled")]
    Enabled,

    /// <summary>
    /// Enum Disabled for "Disabled"
    /// </summary>
    [EnumMember(Value = "Disabled")]
    Disabled,

    /// <summary>
    /// Enum All for "All"
    /// </summary>
    [EnumMember(Value = "All")]
    All
}
