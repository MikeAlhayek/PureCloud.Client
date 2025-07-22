using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum ActionCertificateSigningAuthorityEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum Digicert for "DigiCert"
    /// </summary>
    [EnumMember(Value = "DigiCert")]
    Digicert,

    /// <summary>
    /// Enum Genesys for "Genesys"
    /// </summary>
    [EnumMember(Value = "Genesys")]
    Genesys
}
