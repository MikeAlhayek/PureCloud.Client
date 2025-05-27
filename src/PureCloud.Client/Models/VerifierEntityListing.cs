using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class VerifierEntityListing
{
    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    public long? Total { get; set; }

    /// <summary>
    /// Gets or Sets Entities
    /// </summary>
    public IEnumerable<Verifier> Entities { get; set; }

    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    public string SelfUri { get; set; }
}
