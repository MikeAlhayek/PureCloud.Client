using System.Runtime.Serialization;

namespace PureCloud.Client.Models;

public enum OneLoginNameIdentifierFormatEnum
{
    /// <summary>
    /// Your SDK version is out of date and an unknown enum value was encountered. 
    /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
    /// in the Package Manager Console
    /// </summary>
    [EnumMember(Value = "OUTDATED_SDK_VERSION")]
    OutdatedSdkVersion,

    /// <summary>
    /// Enum _11nameidformatunspecified for "urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified"
    /// </summary>
    [EnumMember(Value = "urn:oasis:names:tc:SAML:1.1:nameid-format:unspecified")]
    _11nameidformatunspecified,

    /// <summary>
    /// Enum _11nameidformatemailaddress for "urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress"
    /// </summary>
    [EnumMember(Value = "urn:oasis:names:tc:SAML:1.1:nameid-format:emailAddress")]
    _11nameidformatemailaddress,

    /// <summary>
    /// Enum _11nameidformatx509subjectname for "urn:oasis:names:tc:SAML:1.1:nameid-format:X509SubjectName"
    /// </summary>
    [EnumMember(Value = "urn:oasis:names:tc:SAML:1.1:nameid-format:X509SubjectName")]
    _11nameidformatx509subjectname,

    /// <summary>
    /// Enum _11nameidformatwindowsdomainqualifiedname for "urn:oasis:names:tc:SAML:1.1:nameid-format:WindowsDomainQualifiedName"
    /// </summary>
    [EnumMember(Value = "urn:oasis:names:tc:SAML:1.1:nameid-format:WindowsDomainQualifiedName")]
    _11nameidformatwindowsdomainqualifiedname,

    /// <summary>
    /// Enum _20nameidformatkerberos for "urn:oasis:names:tc:SAML:2.0:nameid-format:kerberos"
    /// </summary>
    [EnumMember(Value = "urn:oasis:names:tc:SAML:2.0:nameid-format:kerberos")]
    _20nameidformatkerberos,

    /// <summary>
    /// Enum _20nameidformatentity for "urn:oasis:names:tc:SAML:2.0:nameid-format:entity"
    /// </summary>
    [EnumMember(Value = "urn:oasis:names:tc:SAML:2.0:nameid-format:entity")]
    _20nameidformatentity,

    /// <summary>
    /// Enum _20nameidformatpersistent for "urn:oasis:names:tc:SAML:2.0:nameid-format:persistent"
    /// </summary>
    [EnumMember(Value = "urn:oasis:names:tc:SAML:2.0:nameid-format:persistent")]
    _20nameidformatpersistent,

    /// <summary>
    /// Enum _20nameidformattransient for "urn:oasis:names:tc:SAML:2.0:nameid-format:transient"
    /// </summary>
    [EnumMember(Value = "urn:oasis:names:tc:SAML:2.0:nameid-format:transient")]
    _20nameidformattransient
}
