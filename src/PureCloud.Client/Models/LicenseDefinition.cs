using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LicenseDefinition
/// </summary>
public sealed class LicenseDefinition
{



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets Permissions
    /// </summary>
    [JsonPropertyName("permissions")]
    public Permissions Permissions { get; set; }



    /// <summary>
    /// Gets or Sets Prerequisites
    /// </summary>
    [JsonPropertyName("prerequisites")]
    public IEnumerable<AddressableLicenseDefinition> Prerequisites { get; set; }



    /// <summary>
    /// Gets or Sets Comprises
    /// </summary>
    [JsonPropertyName("comprises")]
    public IEnumerable<LicenseDefinition> Comprises { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }

}
