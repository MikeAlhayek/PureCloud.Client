using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class ActionCertificate
{
    /// <summary>
    /// The Signing Authority for the certificate
    /// </summary>
    /// <value>The Signing Authority for the certificate</value>
    public ActionCertificateSigningAuthorityEnum? SigningAuthority { get; set; }

    /// <summary>
    /// The certificate status
    /// </summary>
    /// <value>The certificate status</value>
    public ActionCertificateStatusEnum? Status { get; set; }

    /// <summary>
    /// The certificate type
    /// </summary>
    /// <value>The certificate type</value>
    public ActionCertificateTypeEnum? Type { get; set; }

    /// <summary>
    /// The certificate string
    /// </summary>
    /// <value>The certificate string</value>
    public string Certificate { get; set; }
}
