using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum PersistentConnectionChangeTopicPersistentConnectionChangeEventPersistentStateEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "UNKNOWN"
    /// </summary>
    [EnumMember(Value = "UNKNOWN")]
    Unknown,

    /// <summary>
    /// Enum Persisted for "PERSISTED"
    /// </summary>
    [EnumMember(Value = "PERSISTED")]
    Persisted,

    /// <summary>
    /// Enum ActiveCall for "ACTIVE_CALL"
    /// </summary>
    [EnumMember(Value = "ACTIVE_CALL")]
    ActiveCall,

    /// <summary>
    /// Enum Disconnected for "DISCONNECTED"
    /// </summary>
    [EnumMember(Value = "DISCONNECTED")]
    Disconnected,

    /// <summary>
    /// Enum Failed for "FAILED"
    /// </summary>
    [EnumMember(Value = "FAILED")]
    Failed
}
