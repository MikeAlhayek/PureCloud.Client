using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ReportingTurnAskActionResultEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Successcollection for "SuccessCollection"
    /// </summary>
    [EnumMember(Value = "SuccessCollection")]
    Successcollection,

    /// <summary>
    /// Enum Successconfirmationyes for "SuccessConfirmationYes"
    /// </summary>
    [EnumMember(Value = "SuccessConfirmationYes")]
    Successconfirmationyes,

    /// <summary>
    /// Enum Successconfirmationno for "SuccessConfirmationNo"
    /// </summary>
    [EnumMember(Value = "SuccessConfirmationNo")]
    Successconfirmationno,

    /// <summary>
    /// Enum Skippedcollection for "SkippedCollection"
    /// </summary>
    [EnumMember(Value = "SkippedCollection")]
    Skippedcollection,

    /// <summary>
    /// Enum Partialcollection for "PartialCollection"
    /// </summary>
    [EnumMember(Value = "PartialCollection")]
    Partialcollection,

    /// <summary>
    /// Enum Nomatchcollection for "NoMatchCollection"
    /// </summary>
    [EnumMember(Value = "NoMatchCollection")]
    Nomatchcollection,

    /// <summary>
    /// Enum Nomatchconfirmation for "NoMatchConfirmation"
    /// </summary>
    [EnumMember(Value = "NoMatchConfirmation")]
    Nomatchconfirmation,

    /// <summary>
    /// Enum Agentrequestedbyuser for "AgentRequestedByUser"
    /// </summary>
    [EnumMember(Value = "AgentRequestedByUser")]
    Agentrequestedbyuser,

    /// <summary>
    /// Enum Confirmationrequired for "ConfirmationRequired"
    /// </summary>
    [EnumMember(Value = "ConfirmationRequired")]
    Confirmationrequired,

    /// <summary>
    /// Enum Error for "Error"
    /// </summary>
    [EnumMember(Value = "Error")]
    Error,

    /// <summary>
    /// Enum Expressionerror for "ExpressionError"
    /// </summary>
    [EnumMember(Value = "ExpressionError")]
    Expressionerror,

    /// <summary>
    /// Enum Noinputcollection for "NoInputCollection"
    /// </summary>
    [EnumMember(Value = "NoInputCollection")]
    Noinputcollection,

    /// <summary>
    /// Enum Noinputconfirmation for "NoInputConfirmation"
    /// </summary>
    [EnumMember(Value = "NoInputConfirmation")]
    Noinputconfirmation,

    /// <summary>
    /// Enum Disambiguationrequired for "DisambiguationRequired"
    /// </summary>
    [EnumMember(Value = "DisambiguationRequired")]
    Disambiguationrequired,

    /// <summary>
    /// Enum Successdisambiguation for "SuccessDisambiguation"
    /// </summary>
    [EnumMember(Value = "SuccessDisambiguation")]
    Successdisambiguation,

    /// <summary>
    /// Enum Successdisambiguationnone for "SuccessDisambiguationNone"
    /// </summary>
    [EnumMember(Value = "SuccessDisambiguationNone")]
    Successdisambiguationnone,

    /// <summary>
    /// Enum Nomatchdisambiguation for "NoMatchDisambiguation"
    /// </summary>
    [EnumMember(Value = "NoMatchDisambiguation")]
    Nomatchdisambiguation,

    /// <summary>
    /// Enum Noinputdisambiguation for "NoInputDisambiguation"
    /// </summary>
    [EnumMember(Value = "NoInputDisambiguation")]
    Noinputdisambiguation
}
