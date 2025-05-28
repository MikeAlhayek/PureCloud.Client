using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum KnowledgeSuggestionConfigVendorNameEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Googledialogflow for "GoogleDialogflow"
    /// </summary>
    [EnumMember(Value = "GoogleDialogflow")]
    Googledialogflow,

    /// <summary>
    /// Enum Genesysknowledge for "GenesysKnowledge"
    /// </summary>
    [EnumMember(Value = "GenesysKnowledge")]
    Genesysknowledge,

    /// <summary>
    /// Enum Unknown for "Unknown"
    /// </summary>
    [EnumMember(Value = "Unknown")]
    Unknown
}
