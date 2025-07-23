using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum BenefitAssessmentState
{
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    [EnumMember(Value = "Created")]
    Created,

    [EnumMember(Value = "Finished")]
    Finished,

    [EnumMember(Value = "Failed")]
    Failed
}