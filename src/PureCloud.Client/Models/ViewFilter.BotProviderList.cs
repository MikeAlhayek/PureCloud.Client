using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets BotProviderList
/// </summary>

public enum ViewFilterBotProviderListEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown,

    /// <summary>
    /// Enum Genesys for "Genesys"
    /// </summary>
    [EnumMember(Value = "Genesys")]
    Genesys,

    /// <summary>
    /// Enum Amazon for "Amazon"
    /// </summary>
    [EnumMember(Value = "Amazon")]
    Amazon,

    /// <summary>
    /// Enum Google for "Google"
    /// </summary>
    [EnumMember(Value = "Google")]
    Google,

    /// <summary>
    /// Enum Nuance for "Nuance"
    /// </summary>
    [EnumMember(Value = "Nuance")]
    Nuance
}
