using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum GrammarLanguageFileMetadataFileTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Gram for "Gram"
    /// </summary>
    [EnumMember(Value = "Gram")]
    Gram,

    /// <summary>
    /// Enum Grxml for "Grxml"
    /// </summary>
    [EnumMember(Value = "Grxml")]
    Grxml
}
