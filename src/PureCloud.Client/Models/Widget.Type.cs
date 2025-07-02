using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum WidgetTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Metric for "METRIC"
    /// </summary>
    [EnumMember(Value = "METRIC")]
    Metric,

    /// <summary>
    /// Enum Chart for "CHART"
    /// </summary>
    [EnumMember(Value = "CHART")]
    Chart,

    /// <summary>
    /// Enum Pie for "PIE"
    /// </summary>
    [EnumMember(Value = "PIE")]
    Pie,

    /// <summary>
    /// Enum HeatMap for "HEAT_MAP"
    /// </summary>
    [EnumMember(Value = "HEAT_MAP")]
    HeatMap,

    /// <summary>
    /// Enum FreeText for "FREE_TEXT"
    /// </summary>
    [EnumMember(Value = "FREE_TEXT")]
    FreeText,

    /// <summary>
    /// Enum AgentStatus for "AGENT_STATUS"
    /// </summary>
    [EnumMember(Value = "AGENT_STATUS")]
    AgentStatus,

    /// <summary>
    /// Enum RealtimeAdherence for "REALTIME_ADHERENCE"
    /// </summary>
    [EnumMember(Value = "REALTIME_ADHERENCE")]
    RealtimeAdherence,

    /// <summary>
    /// Enum WebContentUrl for "WEB_CONTENT_URL"
    /// </summary>
    [EnumMember(Value = "WEB_CONTENT_URL")]
    WebContentUrl,

    /// <summary>
    /// Enum AgentActivity for "AGENT_ACTIVITY"
    /// </summary>
    [EnumMember(Value = "AGENT_ACTIVITY")]
    AgentActivity
}
