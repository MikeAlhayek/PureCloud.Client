using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class UpdateVerifierRequest
{
    /// <summary>
    /// The name of the verifier.
    /// </summary>
    /// <value>The name of the verifier.</value>
    public string Name { get; set; }

    /// <summary>
    /// Indicates whether this verifier will be enabled.
    /// </summary>
    /// <value>Indicates whether this verifier will be enabled.</value>
    public bool? Enabled { get; set; }

    /// <summary>
    /// Indicates whether this will be the default verifier.
    /// </summary>
    /// <value>Indicates whether this will be the default verifier.</value>
    public bool? Default { get; set; }
}
