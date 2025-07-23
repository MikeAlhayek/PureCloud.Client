using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Response text content type.
/// </summary>
public enum ResponseTextContentType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Plain for "text/plain"
    /// </summary>
    [EnumMember(Value = "text/plain")]
    Plain,

    /// <summary>
    /// Enum Html for "text/html"
    /// </summary>
    [EnumMember(Value = "text/html")]
    Html
}