using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The operator for the assistance condition. The operator defines whether the listed topicIds should EXIST or NOTEXIST for the condition to be evaluated as true.
/// </summary>
/// <value>The operator for the assistance condition. The operator defines whether the listed topicIds should EXIST or NOTEXIST for the condition to be evaluated as true.</value>

public enum AssistanceConditionOperator
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Exists for "EXISTS"
    /// </summary>
    [EnumMember(Value = "EXISTS")]
    Exists,

    /// <summary>
    /// Enum Notexists for "NOTEXISTS"
    /// </summary>
    [EnumMember(Value = "NOTEXISTS")]
    Notexists
}
