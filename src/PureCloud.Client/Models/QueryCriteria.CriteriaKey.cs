using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum QueryCriteriaCriteriaKeyEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Flowstartdatetime for "FlowStartDateTime"
    /// </summary>
    [EnumMember(Value = "FlowStartDateTime")]
    Flowstartdatetime,

    /// <summary>
    /// Enum Flowenddatetime for "FlowEndDateTime"
    /// </summary>
    [EnumMember(Value = "FlowEndDateTime")]
    Flowenddatetime,

    /// <summary>
    /// Enum Conversationid for "ConversationId"
    /// </summary>
    [EnumMember(Value = "ConversationId")]
    Conversationid,

    /// <summary>
    /// Enum Workitemid for "WorkitemId"
    /// </summary>
    [EnumMember(Value = "WorkitemId")]
    Workitemid,

    /// <summary>
    /// Enum Flowtype for "FlowType"
    /// </summary>
    [EnumMember(Value = "FlowType")]
    Flowtype,

    /// <summary>
    /// Enum Flowid for "FlowId"
    /// </summary>
    [EnumMember(Value = "FlowId")]
    Flowid,

    /// <summary>
    /// Enum Flowerrorreason for "FlowErrorReason"
    /// </summary>
    [EnumMember(Value = "FlowErrorReason")]
    Flowerrorreason,

    /// <summary>
    /// Enum Flowwarningreason for "FlowWarningReason"
    /// </summary>
    [EnumMember(Value = "FlowWarningReason")]
    Flowwarningreason,

    /// <summary>
    /// Enum Flowalternateexecutionid for "FlowAlternateExecutionId"
    /// </summary>
    [EnumMember(Value = "FlowAlternateExecutionId")]
    Flowalternateexecutionid,

    /// <summary>
    /// Enum Flowobjectexecutionid for "FlowObjectExecutionId"
    /// </summary>
    [EnumMember(Value = "FlowObjectExecutionId")]
    Flowobjectexecutionid,

    /// <summary>
    /// Enum Flowactionid for "FlowActionId"
    /// </summary>
    [EnumMember(Value = "FlowActionId")]
    Flowactionid,

    /// <summary>
    /// Enum Flowactiontype for "FlowActionType"
    /// </summary>
    [EnumMember(Value = "FlowActionType")]
    Flowactiontype,

    /// <summary>
    /// Enum Flowactionoutputpathid for "FlowActionOutputPathId"
    /// </summary>
    [EnumMember(Value = "FlowActionOutputPathId")]
    Flowactionoutputpathid,

    /// <summary>
    /// Enum Flowactionoutputpathname for "FlowActionOutputPathName"
    /// </summary>
    [EnumMember(Value = "FlowActionOutputPathName")]
    Flowactionoutputpathname,

    /// <summary>
    /// Enum Flowactionidoutputpathid for "FlowActionIdOutputPathId"
    /// </summary>
    [EnumMember(Value = "FlowActionIdOutputPathId")]
    Flowactionidoutputpathid,

    /// <summary>
    /// Enum Flowactionidoutputpathname for "FlowActionIdOutputPathName"
    /// </summary>
    [EnumMember(Value = "FlowActionIdOutputPathName")]
    Flowactionidoutputpathname,

    /// <summary>
    /// Enum Flowactiontypeoutputpathid for "FlowActionTypeOutputPathId"
    /// </summary>
    [EnumMember(Value = "FlowActionTypeOutputPathId")]
    Flowactiontypeoutputpathid,

    /// <summary>
    /// Enum Flowactiontypeoutputpathname for "FlowActionTypeOutputPathName"
    /// </summary>
    [EnumMember(Value = "FlowActionTypeOutputPathName")]
    Flowactiontypeoutputpathname,

    /// <summary>
    /// Enum Botid for "BotId"
    /// </summary>
    [EnumMember(Value = "BotId")]
    Botid,

    /// <summary>
    /// Enum Boterrorreason for "BotErrorReason"
    /// </summary>
    [EnumMember(Value = "BotErrorReason")]
    Boterrorreason,

    /// <summary>
    /// Enum Botflowexecutionid for "BotFlowExecutionId"
    /// </summary>
    [EnumMember(Value = "BotFlowExecutionId")]
    Botflowexecutionid,

    /// <summary>
    /// Enum Botobjectexecutionid for "BotObjectExecutionId"
    /// </summary>
    [EnumMember(Value = "BotObjectExecutionId")]
    Botobjectexecutionid
}
