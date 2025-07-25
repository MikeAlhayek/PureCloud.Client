namespace PureCloud.Client.Models;

/// <summary>
/// Represents the parsed certificate information.
/// </summary>
public sealed class ParsedCertificate
{
    /// <summary>
    /// The details of the certificates that were parsed correctly.
    /// </summary>
    public IEnumerable<CertificateDetails> CertificateDetails { get; set; }
}
