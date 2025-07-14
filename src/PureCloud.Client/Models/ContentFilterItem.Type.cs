using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ContentFilterItemTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Number for "NUMBER"
    /// </summary>
    [EnumMember(Value = "NUMBER")]
    Number,

    /// <summary>
    /// Enum String for "STRING"
    /// </summary>
    [EnumMember(Value = "STRING")]
    String,

    /// <summary>
    /// Enum Date for "DATE"
    /// </summary>
    [EnumMember(Value = "DATE")]
    Date,

    /// <summary>
    /// Enum Boolean for "BOOLEAN"
    /// </summary>
    [EnumMember(Value = "BOOLEAN")]
    Boolean,

    /// <summary>
    /// Enum List for "LIST"
    /// </summary>
    [EnumMember(Value = "LIST")]
    List
}
