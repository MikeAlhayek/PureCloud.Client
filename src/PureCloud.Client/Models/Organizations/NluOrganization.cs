using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluOrganization
/// </summary>

public sealed class NluOrganization 
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NluOrganization" /> class.
    /// </summary>
    /// <param name="Limits">The NLU limits defined for this Organization.</param>
    /// <param name="SupportedLanguagesInfo">The list of Supported features for each languages for this Organization.</param>

    /// <summary>
    /// The NLU limits defined for this Organization
    /// </summary>
    /// <value>The NLU limits defined for this Organization</value>
    public Dictionary<string, int?> Limits { get; set; }

    /// <summary>
    /// The list of Supported features for each languages for this Organization
    /// </summary>
    /// <value>The list of Supported features for each languages for this Organization</value>
    public IEnumerable<SupportedLanguagesInfoDefinition> SupportedLanguagesInfo { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Returns true if NluOrganization instances are equal
    /// </summary>
    /// <param name="other">Instance of NluOrganization to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
