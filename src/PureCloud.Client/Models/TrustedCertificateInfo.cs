using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TrustedCertificateInfo
{
    /// <summary>
    /// The description of the certificate
    /// </summary>
    /// <value>The description of the certificate</value>
    public string Description { get; set; }

    /// <summary>
    /// The serial number of the certificate
    /// </summary>
    /// <value>The serial number of the certificate</value>
    public string SerialNumber { get; set; }

    /// <summary>
    /// The signature of the certificate
    /// </summary>
    /// <value>The signature of the certificate</value>
    public string Signature { get; set; }
}
