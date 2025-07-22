using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class CredentialSpecification
{
    /// <summary>
    /// Indicates if the credential must be provided in order for the integration configuration to be valid.
    /// </summary>
    /// <value>Indicates if the credential must be provided in order for the integration configuration to be valid.</value>
    public bool? Required { get; set; }

    /// <summary>
    /// Title describing the usage for this credential.
    /// </summary>
    /// <value>Title describing the usage for this credential.</value>
    public string Title { get; set; }

    /// <summary>
    /// List of acceptable credential types that can be provided for this credential.
    /// </summary>
    /// <value>List of acceptable credential types that can be provided for this credential.</value>
    public IEnumerable<string> CredentialTypes { get; set; }
}
