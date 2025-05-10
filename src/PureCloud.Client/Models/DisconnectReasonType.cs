using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Disconnect reason protocol type.
/// </summary>
/// <value>Disconnect reason protocol type.</value>

public enum DisconnectReasonType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Q850 for "q850"
    /// </summary>
    [EnumMember(Value = "q850")]
    Q850,

    /// <summary>
    /// Enum Sip for "sip"
    /// </summary>
    [EnumMember(Value = "sip")]
    Sip
}
