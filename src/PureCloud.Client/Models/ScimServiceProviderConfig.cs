using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM service provider&#39;s configuration.
/// </summary>

public sealed class ScimServiceProviderConfig
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimServiceProviderConfig" /> class.
    /// </summary>



    /// <summary>
    /// The list of supported schemas.
    /// </summary>
    /// <value>The list of supported schemas.</value>
    public IEnumerable<string> Schemas { get; set; }



    /// <summary>
    /// The HTTP-addressable URL that points to the service provider&#39;s documentation.
    /// </summary>
    /// <value>The HTTP-addressable URL that points to the service provider&#39;s documentation.</value>
    public string DocumentationUri { get; set; }



    /// <summary>
    /// The \&quot;patch\&quot; configuration options.
    /// </summary>
    /// <value>The \&quot;patch\&quot; configuration options.</value>
    public ScimServiceProviderConfigSimpleFeature Patch { get; set; }



    /// <summary>
    /// The \&quot;filter\&quot; configuration options.
    /// </summary>
    /// <value>The \&quot;filter\&quot; configuration options.</value>
    public ScimServiceProviderConfigFilterFeature Filter { get; set; }



    /// <summary>
    /// The \&quot;etag\&quot; configuration options.
    /// </summary>
    /// <value>The \&quot;etag\&quot; configuration options.</value>
    public ScimServiceProviderConfigSimpleFeature Etag { get; set; }



    /// <summary>
    /// The \&quot;sort\&quot; configuration options.
    /// </summary>
    /// <value>The \&quot;sort\&quot; configuration options.</value>
    public ScimServiceProviderConfigSimpleFeature Sort { get; set; }



    /// <summary>
    /// The \&quot;bulk\&quot; configuration options.
    /// </summary>
    /// <value>The \&quot;bulk\&quot; configuration options.</value>
    public ScimServiceProviderConfigBulkFeature Bulk { get; set; }



    /// <summary>
    /// The \&quot;changePassword\&quot; configuration options.
    /// </summary>
    /// <value>The \&quot;changePassword\&quot; configuration options.</value>
    public ScimServiceProviderConfigSimpleFeature ChangePassword { get; set; }



    /// <summary>
    /// The list of supported authentication schemes.
    /// </summary>
    /// <value>The list of supported authentication schemes.</value>
    public IEnumerable<ScimServiceProviderConfigAuthenticationScheme> AuthenticationSchemes { get; set; }



    /// <summary>
    /// The metadata of the SCIM resource. Metadata is defined as immutable per SCIM RFC.
    /// </summary>
    /// <value>The metadata of the SCIM resource. Metadata is defined as immutable per SCIM RFC.</value>
    public ScimMetadata Meta { get; set; }


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
    /// Returns true if ScimServiceProviderConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimServiceProviderConfig to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
