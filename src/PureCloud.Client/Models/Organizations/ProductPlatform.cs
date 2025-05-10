using System.Runtime.Serialization;

namespace PureCloud.Client.Models.Organizations;

public enum ProductPlatform
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Genesyscloud for "GenesysCloud"
    /// </summary>
    [EnumMember(Value = "GenesysCloud")]
    Genesyscloud,

    /// <summary>
    /// Enum PureCloudEnvironment for "PureCloud"
    /// </summary>
    [EnumMember(Value = "PureCloud")]
    Purecloud,

    /// <summary>
    /// Enum Pureengage for "PureEngage"
    /// </summary>
    [EnumMember(Value = "PureEngage")]
    Pureengage,

    /// <summary>
    /// Enum Pureengagecloud for "PureEngageCloud"
    /// </summary>
    [EnumMember(Value = "PureEngageCloud")]
    Pureengagecloud,

    /// <summary>
    /// Enum Pureconnect for "PureConnect"
    /// </summary>
    [EnumMember(Value = "PureConnect")]
    Pureconnect,

    /// <summary>
    /// Enum Pureconnectcloud for "PureConnectCloud"
    /// </summary>
    [EnumMember(Value = "PureConnectCloud")]
    Pureconnectcloud,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
