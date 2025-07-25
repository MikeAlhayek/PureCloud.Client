using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ApiUsageSimpleSearchHttpMethodsEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Get for "GET"
    /// </summary>
    [EnumMember(Value = "GET")]
    Get,

    /// <summary>
    /// Enum Post for "POST"
    /// </summary>
    [EnumMember(Value = "POST")]
    Post,

    /// <summary>
    /// Enum Delete for "DELETE"
    /// </summary>
    [EnumMember(Value = "DELETE")]
    Delete,

    /// <summary>
    /// Enum Patch for "PATCH"
    /// </summary>
    [EnumMember(Value = "PATCH")]
    Patch,

    /// <summary>
    /// Enum Put for "PUT"
    /// </summary>
    [EnumMember(Value = "PUT")]
    Put,

    /// <summary>
    /// Enum Head for "HEAD"
    /// </summary>
    [EnumMember(Value = "HEAD")]
    Head,

    /// <summary>
    /// Enum Connect for "CONNECT"
    /// </summary>
    [EnumMember(Value = "CONNECT")]
    Connect,

    /// <summary>
    /// Enum Options for "OPTIONS"
    /// </summary>
    [EnumMember(Value = "OPTIONS")]
    Options,

    /// <summary>
    /// Enum Trace for "TRACE"
    /// </summary>
    [EnumMember(Value = "TRACE")]
    Trace
}