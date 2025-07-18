using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class Okta
{
    /// <summary>
    /// Gets or Sets NameIdentifierFormat
    /// </summary>
    public OktaNameIdentifierFormatEnum? NameIdentifierFormat { get; set; }

    /// <summary>
    /// Gets or Sets SsoBinding
    /// </summary>
    public OktaSsoBindingEnum? SsoBinding { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Gets or Sets Disabled
    /// </summary>
    public bool? Disabled { get; set; }

    /// <summary>
    /// Gets or Sets IssuerURI
    /// </summary>
    public string IssuerURI { get; set; }

    /// <summary>
    /// Gets or Sets SsoTargetURI
    /// </summary>
    public string SsoTargetURI { get; set; }

    /// <summary>
    /// Gets or Sets SloURI
    /// </summary>
    public string SloURI { get; set; }

    /// <summary>
    /// Gets or Sets SloBinding
    /// </summary>
    public string SloBinding { get; set; }

    /// <summary>
    /// Gets or Sets RelyingPartyIdentifier
    /// </summary>
    public string RelyingPartyIdentifier { get; set; }

    /// <summary>
    /// Gets or Sets Certificate
    /// </summary>
    public string Certificate { get; set; }

    /// <summary>
    /// Gets or Sets Certificates
    /// </summary>
    public IEnumerable<string> Certificates { get; set; }

    /// <summary>
    /// Gets or Sets LogoImageData
    /// </summary>
    public string LogoImageData { get; set; }

    /// <summary>
    /// Gets or Sets SignAuthnRequests
    /// </summary>
    public bool? SignAuthnRequests { get; set; }

    /// <summary>
    /// Gets or Sets ProviderName
    /// </summary>
    public string ProviderName { get; set; }

    /// <summary>
    /// Gets or Sets DisplayOnLogin
    /// </summary>
    public bool? DisplayOnLogin { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
