using System.Text;
using System.Text.Json.Serialization;
using PureCloud.Client.Models.Users;

namespace PureCloud.Client.Models;

public sealed class IntegrationType
{
    /// <summary>
    /// The ID of the integration type.
    /// </summary>
    /// <value>The ID of the integration type.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Description of the integration type.
    /// </summary>
    /// <value>Description of the integration type.</value>
    public string Description { get; set; }

    /// <summary>
    /// PureCloudEnvironment provider of the integration type.
    /// </summary>
    /// <value>PureCloudEnvironment provider of the integration type.</value>
    public string Provider { get; set; }

    /// <summary>
    /// Category describing the integration type.
    /// </summary>
    /// <value>Category describing the integration type.</value>
    public string Category { get; set; }

    /// <summary>
    /// Collection of logos.
    /// </summary>
    /// <value>Collection of logos.</value>
    public IEnumerable<Image> Images { get; set; }

    /// <summary>
    /// URI of the schema describing the key-value properties needed to configure an integration of this type.
    /// </summary>
    /// <value>URI of the schema describing the key-value properties needed to configure an integration of this type.</value>
    public string ConfigPropertiesSchemaUri { get; set; }

    /// <summary>
    /// URI of the schema describing the advanced JSON document needed to configure an integration of this type.
    /// </summary>
    /// <value>URI of the schema describing the advanced JSON document needed to configure an integration of this type.</value>
    public string ConfigAdvancedSchemaUri { get; set; }

    /// <summary>
    /// URI of a page with more information about the integration type
    /// </summary>
    /// <value>URI of a page with more information about the integration type</value>
    public string HelpUri { get; set; }

    /// <summary>
    /// URI of a page with terms and conditions for the integration type
    /// </summary>
    /// <value>URI of a page with terms and conditions for the integration type</value>
    public string TermsOfServiceUri { get; set; }

    /// <summary>
    /// Name of the vendor of this integration type
    /// </summary>
    /// <value>Name of the vendor of this integration type</value>
    public string VendorName { get; set; }

    /// <summary>
    /// URI of the vendor&#39;s website
    /// </summary>
    /// <value>URI of the vendor&#39;s website</value>
    public string VendorWebsiteUri { get; set; }

    /// <summary>
    /// URI of the marketplace listing for this integration type
    /// </summary>
    /// <value>URI of the marketplace listing for this integration type</value>
    public string MarketplaceUri { get; set; }

    /// <summary>
    /// URI of frequently asked questions about the integration type
    /// </summary>
    /// <value>URI of frequently asked questions about the integration type</value>
    public string FaqUri { get; set; }

    /// <summary>
    /// URI of a privacy policy for users of the integration type
    /// </summary>
    /// <value>URI of a privacy policy for users of the integration type</value>
    public string PrivacyPolicyUri { get; set; }

    /// <summary>
    /// URI for vendor support
    /// </summary>
    /// <value>URI for vendor support</value>
    public string SupportContactUri { get; set; }

    /// <summary>
    /// URI for vendor sales information
    /// </summary>
    /// <value>URI for vendor sales information</value>
    public string SalesContactUri { get; set; }

    /// <summary>
    /// List of links to additional help resources
    /// </summary>
    /// <value>List of links to additional help resources</value>
    public IEnumerable<HelpLink> HelpLinks { get; set; }

    /// <summary>
    /// Map of credentials for integrations of this type. The key is the name of a credential that can be provided in the credentials property of the integration configuration.
    /// </summary>
    /// <value>Map of credentials for integrations of this type. The key is the name of a credential that can be provided in the credentials property of the integration configuration.</value>
    public Dictionary<string, CredentialSpecification> Credentials { get; set; }

    /// <summary>
    /// Indicates if the integration type is installable or not.
    /// </summary>
    /// <value>Indicates if the integration type is installable or not.</value>
    public bool? NonInstallable { get; set; }

    /// <summary>
    /// The maximum number of integration instances allowable for this integration type
    /// </summary>
    /// <value>The maximum number of integration instances allowable for this integration type</value>
    public int? MaxInstances { get; set; }

    /// <summary>
    /// List of permissions required to permit user access to the integration type.
    /// </summary>
    /// <value>List of permissions required to permit user access to the integration type.</value>
    public IEnumerable<string> UserPermissions { get; set; }

    /// <summary>
    /// List of OAuth Client IDs that must be authorized when the integration is created.
    /// </summary>
    /// <value>List of OAuth Client IDs that must be authorized when the integration is created.</value>
    public IEnumerable<string> VendorOAuthClientIds { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
