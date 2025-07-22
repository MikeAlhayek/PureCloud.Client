using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum FunctionZipConfigStatusEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Pending for "Pending"
    /// </summary>
    [EnumMember(Value = "Pending")]
    Pending,

    /// <summary>
    /// Enum Transferring for "Transferring"
    /// </summary>
    [EnumMember(Value = "Transferring")]
    Transferring,

    /// <summary>
    /// Enum Available for "Available"
    /// </summary>
    [EnumMember(Value = "Available")]
    Available,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown,

    /// <summary>
    /// Enum Invalid for "Invalid"
    /// </summary>
    [EnumMember(Value = "Invalid")]
    Invalid,

    /// <summary>
    /// Enum Invalidformat for "InvalidFormat"
    /// </summary>
    [EnumMember(Value = "InvalidFormat")]
    Invalidformat,

    /// <summary>
    /// Enum Invalidfile for "InvalidFile"
    /// </summary>
    [EnumMember(Value = "InvalidFile")]
    Invalidfile
}
