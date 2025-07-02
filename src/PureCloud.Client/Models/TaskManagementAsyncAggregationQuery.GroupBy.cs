using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum TaskManagementAsyncAggregationQueryGroupByEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Assigneeid for "assigneeId"
    /// </summary>
    [EnumMember(Value = "assigneeId")]
    Assigneeid,

    /// <summary>
    /// Enum Divisionid for "divisionId"
    /// </summary>
    [EnumMember(Value = "divisionId")]
    Divisionid,

    /// <summary>
    /// Enum Externaltag for "externalTag"
    /// </summary>
    [EnumMember(Value = "externalTag")]
    Externaltag,

    /// <summary>
    /// Enum Queueid for "queueId"
    /// </summary>
    [EnumMember(Value = "queueId")]
    Queueid,

    /// <summary>
    /// Enum Reporterid for "reporterId"
    /// </summary>
    [EnumMember(Value = "reporterId")]
    Reporterid,

    /// <summary>
    /// Enum Requestedlanguageid for "requestedLanguageId"
    /// </summary>
    [EnumMember(Value = "requestedLanguageId")]
    Requestedlanguageid,

    /// <summary>
    /// Enum Requestedrouting for "requestedRouting"
    /// </summary>
    [EnumMember(Value = "requestedRouting")]
    Requestedrouting,

    /// <summary>
    /// Enum Requestedroutingskillid for "requestedRoutingSkillId"
    /// </summary>
    [EnumMember(Value = "requestedRoutingSkillId")]
    Requestedroutingskillid,

    /// <summary>
    /// Enum Statuscategory for "statusCategory"
    /// </summary>
    [EnumMember(Value = "statusCategory")]
    Statuscategory,

    /// <summary>
    /// Enum Statusid for "statusId"
    /// </summary>
    [EnumMember(Value = "statusId")]
    Statusid,

    /// <summary>
    /// Enum Typeid for "typeId"
    /// </summary>
    [EnumMember(Value = "typeId")]
    Typeid,

    /// <summary>
    /// Enum Usedrouting for "usedRouting"
    /// </summary>
    [EnumMember(Value = "usedRouting")]
    Usedrouting,

    /// <summary>
    /// Enum Userid for "userId"
    /// </summary>
    [EnumMember(Value = "userId")]
    Userid,

    /// <summary>
    /// Enum Workbinid for "workbinId"
    /// </summary>
    [EnumMember(Value = "workbinId")]
    Workbinid,

    /// <summary>
    /// Enum Workitemid for "workitemId"
    /// </summary>
    [EnumMember(Value = "workitemId")]
    Workitemid,

    /// <summary>
    /// Enum Wrapupcode for "wrapUpCode"
    /// </summary>
    [EnumMember(Value = "wrapUpCode")]
    Wrapupcode
}
