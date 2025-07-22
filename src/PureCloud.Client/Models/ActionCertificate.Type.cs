using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// The certificate type
/// </summary>
/// <value>The certificate type</value>

public enum ActionCertificateTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Client for "Client"
    /// </summary>
    [EnumMember(Value = "Client")]
    Client
}
