using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum FacetEntryTermTypeEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Term for "TERM"
    /// </summary>
    [EnumMember(Value = "TERM")]
    Term,

    /// <summary>
    /// Enum Numberrange for "NUMBERRANGE"
    /// </summary>
    [EnumMember(Value = "NUMBERRANGE")]
    Numberrange,

    /// <summary>
    /// Enum Numberhistogram for "NUMBERHISTOGRAM"
    /// </summary>
    [EnumMember(Value = "NUMBERHISTOGRAM")]
    Numberhistogram,

    /// <summary>
    /// Enum Daterange for "DATERANGE"
    /// </summary>
    [EnumMember(Value = "DATERANGE")]
    Daterange,

    /// <summary>
    /// Enum Datehistogram for "DATEHISTOGRAM"
    /// </summary>
    [EnumMember(Value = "DATEHISTOGRAM")]
    Datehistogram,

    /// <summary>
    /// Enum Id for "ID"
    /// </summary>
    [EnumMember(Value = "ID")]
    Id
}
