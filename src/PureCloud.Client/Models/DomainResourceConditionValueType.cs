using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum DomainResourceConditionValueType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Scalar for "SCALAR"
    /// </summary>
    [EnumMember(Value = "SCALAR")]
    Scalar,

    /// <summary>
    /// Enum Variable for "VARIABLE"
    /// </summary>
    [EnumMember(Value = "VARIABLE")]
    Variable,

    /// <summary>
    /// Enum User for "USER"
    /// </summary>
    [EnumMember(Value = "USER")]
    User,

    /// <summary>
    /// Enum Team for "TEAM"
    /// </summary>
    [EnumMember(Value = "TEAM")]
    Team,

    /// <summary>
    /// Enum Queue for "QUEUE"
    /// </summary>
    [EnumMember(Value = "QUEUE")]
    Queue
}
