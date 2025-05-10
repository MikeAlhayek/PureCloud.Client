using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Analytics;

public enum AnalyticsFlowEntryType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Agent for "agent"
    /// </summary>
    [EnumMember(Value = "agent")]
    Agent,

    /// <summary>
    /// Enum Direct for "direct"
    /// </summary>
    [EnumMember(Value = "direct")]
    Direct,

    /// <summary>
    /// Enum Dnis for "dnis"
    /// </summary>
    [EnumMember(Value = "dnis")]
    Dnis,

    /// <summary>
    /// Enum Flow for "flow"
    /// </summary>
    [EnumMember(Value = "flow")]
    Flow,

    /// <summary>
    /// Enum Outbound for "outbound"
    /// </summary>
    [EnumMember(Value = "outbound")]
    Outbound
}
