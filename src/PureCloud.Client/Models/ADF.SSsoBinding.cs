using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Gets or Sets SsoBinding
/// </summary>

public enum ADFSSsoBindingEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Post for "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-POST"
    /// </summary>
    [EnumMember(Value = "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-POST")]
    Post,

    /// <summary>
    /// Enum Redirect for "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect"
    /// </summary>
    [EnumMember(Value = "urn:oasis:names:tc:SAML:2.0:bindings:HTTP-Redirect")]
    Redirect
}
