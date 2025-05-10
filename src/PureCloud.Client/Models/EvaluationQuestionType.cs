using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets Type
/// </summary>

public enum EvaluationQuestionType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Multiplechoicequestion for "multipleChoiceQuestion"
    /// </summary>
    [EnumMember(Value = "multipleChoiceQuestion")]
    Multiplechoicequestion,

    /// <summary>
    /// Enum Freetextquestion for "freeTextQuestion"
    /// </summary>
    [EnumMember(Value = "freeTextQuestion")]
    Freetextquestion,

    /// <summary>
    /// Enum Npsquestion for "npsQuestion"
    /// </summary>
    [EnumMember(Value = "npsQuestion")]
    Npsquestion,

    /// <summary>
    /// Enum Readonlytextblockquestion for "readOnlyTextBlockQuestion"
    /// </summary>
    [EnumMember(Value = "readOnlyTextBlockQuestion")]
    Readonlytextblockquestion
}
