using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LicenseUser
/// </summary>
public sealed class LicenseUser
{



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Licenses
    /// </summary>
    [JsonPropertyName("licenses")]
    public IEnumerable<LicenseDefinition> Licenses { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }

}
