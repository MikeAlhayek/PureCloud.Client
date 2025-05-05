using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum AuthorizedGrantType
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Code for "CODE"
    /// </summary>
    [EnumMember(Value = "CODE")]
    Code,

    /// <summary>
    /// Enum Token for "TOKEN"
    /// </summary>
    [EnumMember(Value = "TOKEN")]
    Token,

    /// <summary>
    /// Enum Saml2bearer for "SAML2-BEARER"
    /// </summary>
    [EnumMember(Value = "SAML2-BEARER")]
    Saml2bearer,

    /// <summary>
    /// Enum Password for "PASSWORD"
    /// </summary>
    [EnumMember(Value = "PASSWORD")]
    Password,

    /// <summary>
    /// Enum Clientcredentials for "CLIENT-CREDENTIALS"
    /// </summary>
    [EnumMember(Value = "CLIENT-CREDENTIALS")]
    ClientCredentials,
}
