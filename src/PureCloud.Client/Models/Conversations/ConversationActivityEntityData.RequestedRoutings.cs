using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ConversationActivityEntityDataRequestedRoutingsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Bullseye for "Bullseye"
    /// </summary>
    [EnumMember(Value = "Bullseye")]
    Bullseye,

    /// <summary>
    /// Enum Conditional for "Conditional"
    /// </summary>
    [EnumMember(Value = "Conditional")]
    Conditional,

    /// <summary>
    /// Enum Direct for "Direct"
    /// </summary>
    [EnumMember(Value = "Direct")]
    Direct,

    /// <summary>
    /// Enum Last for "Last"
    /// </summary>
    [EnumMember(Value = "Last")]
    Last,

    /// <summary>
    /// Enum Manual for "Manual"
    /// </summary>
    [EnumMember(Value = "Manual")]
    Manual,

    /// <summary>
    /// Enum Predictive for "Predictive"
    /// </summary>
    [EnumMember(Value = "Predictive")]
    Predictive,

    /// <summary>
    /// Enum Preferred for "Preferred"
    /// </summary>
    [EnumMember(Value = "Preferred")]
    Preferred,

    /// <summary>
    /// Enum Standard for "Standard"
    /// </summary>
    [EnumMember(Value = "Standard")]
    Standard,

    /// <summary>
    /// Enum Vip for "Vip"
    /// </summary>
    [EnumMember(Value = "Vip")]
    Vip
}
