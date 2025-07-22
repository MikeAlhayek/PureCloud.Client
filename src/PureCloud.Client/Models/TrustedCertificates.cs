using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class TrustedCertificates
{
    /// <summary>
    /// The list of trusted certificates
    /// </summary>
    /// <value>The list of trusted certificates</value>
    public IEnumerable<TrustedCertificateInfo> Entities { get; set; }

    /// <summary>
    /// The total number of trusted certificates
    /// </summary>
    /// <value>The total number of trusted certificates</value>
    public int? Total { get; set; }
}
