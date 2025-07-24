using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a \&quot;bulk\&quot; request in the SCIM service provider&#39;s configuration.
/// </summary>

public sealed class ScimServiceProviderConfigBulkFeature
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimServiceProviderConfigBulkFeature" /> class.
    /// </summary>



    /// <summary>
    /// Indicates whether configuration options are supported.
    /// </summary>
    /// <value>Indicates whether configuration options are supported.</value>
    public bool? Supported { get; set; }



    /// <summary>
    /// The maximum number of operations for each bulk request.
    /// </summary>
    /// <value>The maximum number of operations for each bulk request.</value>
    public int? MaxOperations { get; set; }



    /// <summary>
    /// The maximum payload size.
    /// </summary>
    /// <value>The maximum payload size.</value>
    public int? MaxPayloadSize { get; set; }


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
    /// Returns true if ScimServiceProviderConfigBulkFeature instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimServiceProviderConfigBulkFeature to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
