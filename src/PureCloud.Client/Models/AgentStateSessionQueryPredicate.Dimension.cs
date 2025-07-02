using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum AgentStateSessionQueryPredicateDimensionEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Mediatype for "mediaType"
    /// </summary>
    [EnumMember(Value = "mediaType")]
    Mediatype,

    /// <summary>
    /// Enum Originatingdirection for "originatingDirection"
    /// </summary>
    [EnumMember(Value = "originatingDirection")]
    Originatingdirection,

    /// <summary>
    /// Enum Requestedlanguageid for "requestedLanguageId"
    /// </summary>
    [EnumMember(Value = "requestedLanguageId")]
    Requestedlanguageid,

    /// <summary>
    /// Enum Requestedroutingskillid for "requestedRoutingSkillId"
    /// </summary>
    [EnumMember(Value = "requestedRoutingSkillId")]
    Requestedroutingskillid,

    /// <summary>
    /// Enum Routedqueueid for "routedQueueId"
    /// </summary>
    [EnumMember(Value = "routedQueueId")]
    Routedqueueid,

    /// <summary>
    /// Enum Segmenttype for "segmentType"
    /// </summary>
    [EnumMember(Value = "segmentType")]
    Segmenttype
}
