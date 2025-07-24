using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a \&quot;filter\&quot; request in the SCIM service provider&#39;s configuration.
/// </summary>

public sealed class ScimServiceProviderConfigFilterFeature
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimServiceProviderConfigFilterFeature" /> class.
    /// </summary>



    /// <summary>
    /// Indicates whether configuration options are supported.
    /// </summary>
    /// <value>Indicates whether configuration options are supported.</value>
    public bool? Supported { get; set; }



    /// <summary>
    /// The maximum number of results returned from a filtered query.
    /// </summary>
    /// <value>The maximum number of results returned from a filtered query.</value>
    public int? MaxResults { get; set; }


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
    /// Returns true if ScimServiceProviderConfigFilterFeature instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimServiceProviderConfigFilterFeature to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
