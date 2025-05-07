using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Descriptor for a type of Integration.
/// </summary>

public partial class IntegrationType : IEquatable<IntegrationType>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="IntegrationType" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected IntegrationType() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="IntegrationType" /> class.
    /// </summary>
    /// <param name="Id">The ID of the integration type. (required).</param>
    /// <param name="Name">Name.</param>
    public IntegrationType(string Id = null, string Name = null)
    {
        this.Id = Id;
        this.Name = Name;

    }



    /// <summary>
    /// The ID of the integration type.
    /// </summary>
    /// <value>The ID of the integration type.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Description of the integration type.
    /// </summary>
    /// <value>Description of the integration type.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// PureCloudEnvironment provider of the integration type.
    /// </summary>
    /// <value>PureCloudEnvironment provider of the integration type.</value>
    [JsonPropertyName("provider")]
    public string Provider { get; set; }



    /// <summary>
    /// Category describing the integration type.
    /// </summary>
    /// <value>Category describing the integration type.</value>
    [JsonPropertyName("category")]
    public string Category { get; set; }



    /// <summary>
    /// Collection of logos.
    /// </summary>
    /// <value>Collection of logos.</value>
    [JsonPropertyName("images")]
    public List<Image> Images { get; set; }



    /// <summary>
    /// URI of the schema describing the key-value properties needed to configure an integration of this type.
    /// </summary>
    /// <value>URI of the schema describing the key-value properties needed to configure an integration of this type.</value>
    [JsonPropertyName("configPropertiesSchemaUri")]
    public string ConfigPropertiesSchemaUri { get; set; }



    /// <summary>
    /// URI of the schema describing the advanced JSON document needed to configure an integration of this type.
    /// </summary>
    /// <value>URI of the schema describing the advanced JSON document needed to configure an integration of this type.</value>
    [JsonPropertyName("configAdvancedSchemaUri")]
    public string ConfigAdvancedSchemaUri { get; set; }



    /// <summary>
    /// URI of a page with more information about the integration type
    /// </summary>
    /// <value>URI of a page with more information about the integration type</value>
    [JsonPropertyName("helpUri")]
    public string HelpUri { get; set; }



    /// <summary>
    /// URI of a page with terms and conditions for the integration type
    /// </summary>
    /// <value>URI of a page with terms and conditions for the integration type</value>
    [JsonPropertyName("termsOfServiceUri")]
    public string TermsOfServiceUri { get; set; }



    /// <summary>
    /// Name of the vendor of this integration type
    /// </summary>
    /// <value>Name of the vendor of this integration type</value>
    [JsonPropertyName("vendorName")]
    public string VendorName { get; set; }



    /// <summary>
    /// URI of the vendor&#39;s website
    /// </summary>
    /// <value>URI of the vendor&#39;s website</value>
    [JsonPropertyName("vendorWebsiteUri")]
    public string VendorWebsiteUri { get; set; }



    /// <summary>
    /// URI of the marketplace listing for this integration type
    /// </summary>
    /// <value>URI of the marketplace listing for this integration type</value>
    [JsonPropertyName("marketplaceUri")]
    public string MarketplaceUri { get; set; }



    /// <summary>
    /// URI of frequently asked questions about the integration type
    /// </summary>
    /// <value>URI of frequently asked questions about the integration type</value>
    [JsonPropertyName("faqUri")]
    public string FaqUri { get; set; }



    /// <summary>
    /// URI of a privacy policy for users of the integration type
    /// </summary>
    /// <value>URI of a privacy policy for users of the integration type</value>
    [JsonPropertyName("privacyPolicyUri")]
    public string PrivacyPolicyUri { get; set; }



    /// <summary>
    /// URI for vendor support
    /// </summary>
    /// <value>URI for vendor support</value>
    [JsonPropertyName("supportContactUri")]
    public string SupportContactUri { get; set; }



    /// <summary>
    /// URI for vendor sales information
    /// </summary>
    /// <value>URI for vendor sales information</value>
    [JsonPropertyName("salesContactUri")]
    public string SalesContactUri { get; set; }



    /// <summary>
    /// List of links to additional help resources
    /// </summary>
    /// <value>List of links to additional help resources</value>
    [JsonPropertyName("helpLinks")]
    public List<HelpLink> HelpLinks { get; set; }



    /// <summary>
    /// Map of credentials for integrations of this type. The key is the name of a credential that can be provided in the credentials property of the integration configuration.
    /// </summary>
    /// <value>Map of credentials for integrations of this type. The key is the name of a credential that can be provided in the credentials property of the integration configuration.</value>
    [JsonPropertyName("credentials")]
    public Dictionary<string, CredentialSpecification> Credentials { get; set; }



    /// <summary>
    /// Indicates if the integration type is installable or not.
    /// </summary>
    /// <value>Indicates if the integration type is installable or not.</value>
    [JsonPropertyName("nonInstallable")]
    public bool? NonInstallable { get; set; }



    /// <summary>
    /// The maximum number of integration instances allowable for this integration type
    /// </summary>
    /// <value>The maximum number of integration instances allowable for this integration type</value>
    [JsonPropertyName("maxInstances")]
    public int? MaxInstances { get; set; }



    /// <summary>
    /// List of permissions required to permit user access to the integration type.
    /// </summary>
    /// <value>List of permissions required to permit user access to the integration type.</value>
    [JsonPropertyName("userPermissions")]
    public List<string> UserPermissions { get; set; }



    /// <summary>
    /// List of OAuth Client IDs that must be authorized when the integration is created.
    /// </summary>
    /// <value>List of OAuth Client IDs that must be authorized when the integration is created.</value>
    [JsonPropertyName("vendorOAuthClientIds")]
    public List<string> VendorOAuthClientIds { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class IntegrationType {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Provider: ").Append(Provider).Append("\n");
        sb.Append("  Category: ").Append(Category).Append("\n");
        sb.Append("  Images: ").Append(Images).Append("\n");
        sb.Append("  ConfigPropertiesSchemaUri: ").Append(ConfigPropertiesSchemaUri).Append("\n");
        sb.Append("  ConfigAdvancedSchemaUri: ").Append(ConfigAdvancedSchemaUri).Append("\n");
        sb.Append("  HelpUri: ").Append(HelpUri).Append("\n");
        sb.Append("  TermsOfServiceUri: ").Append(TermsOfServiceUri).Append("\n");
        sb.Append("  VendorName: ").Append(VendorName).Append("\n");
        sb.Append("  VendorWebsiteUri: ").Append(VendorWebsiteUri).Append("\n");
        sb.Append("  MarketplaceUri: ").Append(MarketplaceUri).Append("\n");
        sb.Append("  FaqUri: ").Append(FaqUri).Append("\n");
        sb.Append("  PrivacyPolicyUri: ").Append(PrivacyPolicyUri).Append("\n");
        sb.Append("  SupportContactUri: ").Append(SupportContactUri).Append("\n");
        sb.Append("  SalesContactUri: ").Append(SalesContactUri).Append("\n");
        sb.Append("  HelpLinks: ").Append(HelpLinks).Append("\n");
        sb.Append("  Credentials: ").Append(Credentials).Append("\n");
        sb.Append("  NonInstallable: ").Append(NonInstallable).Append("\n");
        sb.Append("  MaxInstances: ").Append(MaxInstances).Append("\n");
        sb.Append("  UserPermissions: ").Append(UserPermissions).Append("\n");
        sb.Append("  VendorOAuthClientIds: ").Append(VendorOAuthClientIds).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as IntegrationType);
    }

    /// <summary>
    /// Returns true if IntegrationType instances are equal
    /// </summary>
    /// <param name="other">Instance of IntegrationType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(IntegrationType other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Provider == other.Provider ||
                Provider != null &&
                Provider.Equals(other.Provider)
            ) &&
            (
                Category == other.Category ||
                Category != null &&
                Category.Equals(other.Category)
            ) &&
            (
                Images == other.Images ||
                Images != null &&
                Images.SequenceEqual(other.Images)
            ) &&
            (
                ConfigPropertiesSchemaUri == other.ConfigPropertiesSchemaUri ||
                ConfigPropertiesSchemaUri != null &&
                ConfigPropertiesSchemaUri.Equals(other.ConfigPropertiesSchemaUri)
            ) &&
            (
                ConfigAdvancedSchemaUri == other.ConfigAdvancedSchemaUri ||
                ConfigAdvancedSchemaUri != null &&
                ConfigAdvancedSchemaUri.Equals(other.ConfigAdvancedSchemaUri)
            ) &&
            (
                HelpUri == other.HelpUri ||
                HelpUri != null &&
                HelpUri.Equals(other.HelpUri)
            ) &&
            (
                TermsOfServiceUri == other.TermsOfServiceUri ||
                TermsOfServiceUri != null &&
                TermsOfServiceUri.Equals(other.TermsOfServiceUri)
            ) &&
            (
                VendorName == other.VendorName ||
                VendorName != null &&
                VendorName.Equals(other.VendorName)
            ) &&
            (
                VendorWebsiteUri == other.VendorWebsiteUri ||
                VendorWebsiteUri != null &&
                VendorWebsiteUri.Equals(other.VendorWebsiteUri)
            ) &&
            (
                MarketplaceUri == other.MarketplaceUri ||
                MarketplaceUri != null &&
                MarketplaceUri.Equals(other.MarketplaceUri)
            ) &&
            (
                FaqUri == other.FaqUri ||
                FaqUri != null &&
                FaqUri.Equals(other.FaqUri)
            ) &&
            (
                PrivacyPolicyUri == other.PrivacyPolicyUri ||
                PrivacyPolicyUri != null &&
                PrivacyPolicyUri.Equals(other.PrivacyPolicyUri)
            ) &&
            (
                SupportContactUri == other.SupportContactUri ||
                SupportContactUri != null &&
                SupportContactUri.Equals(other.SupportContactUri)
            ) &&
            (
                SalesContactUri == other.SalesContactUri ||
                SalesContactUri != null &&
                SalesContactUri.Equals(other.SalesContactUri)
            ) &&
            (
                HelpLinks == other.HelpLinks ||
                HelpLinks != null &&
                HelpLinks.SequenceEqual(other.HelpLinks)
            ) &&
            (
                Credentials == other.Credentials ||
                Credentials != null &&
                Credentials.SequenceEqual(other.Credentials)
            ) &&
            (
                NonInstallable == other.NonInstallable ||
                NonInstallable != null &&
                NonInstallable.Equals(other.NonInstallable)
            ) &&
            (
                MaxInstances == other.MaxInstances ||
                MaxInstances != null &&
                MaxInstances.Equals(other.MaxInstances)
            ) &&
            (
                UserPermissions == other.UserPermissions ||
                UserPermissions != null &&
                UserPermissions.SequenceEqual(other.UserPermissions)
            ) &&
            (
                VendorOAuthClientIds == other.VendorOAuthClientIds ||
                VendorOAuthClientIds != null &&
                VendorOAuthClientIds.SequenceEqual(other.VendorOAuthClientIds)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Provider != null)
            {
                hash = hash * 59 + Provider.GetHashCode();
            }

            if (Category != null)
            {
                hash = hash * 59 + Category.GetHashCode();
            }

            if (Images != null)
            {
                hash = hash * 59 + Images.GetHashCode();
            }

            if (ConfigPropertiesSchemaUri != null)
            {
                hash = hash * 59 + ConfigPropertiesSchemaUri.GetHashCode();
            }

            if (ConfigAdvancedSchemaUri != null)
            {
                hash = hash * 59 + ConfigAdvancedSchemaUri.GetHashCode();
            }

            if (HelpUri != null)
            {
                hash = hash * 59 + HelpUri.GetHashCode();
            }

            if (TermsOfServiceUri != null)
            {
                hash = hash * 59 + TermsOfServiceUri.GetHashCode();
            }

            if (VendorName != null)
            {
                hash = hash * 59 + VendorName.GetHashCode();
            }

            if (VendorWebsiteUri != null)
            {
                hash = hash * 59 + VendorWebsiteUri.GetHashCode();
            }

            if (MarketplaceUri != null)
            {
                hash = hash * 59 + MarketplaceUri.GetHashCode();
            }

            if (FaqUri != null)
            {
                hash = hash * 59 + FaqUri.GetHashCode();
            }

            if (PrivacyPolicyUri != null)
            {
                hash = hash * 59 + PrivacyPolicyUri.GetHashCode();
            }

            if (SupportContactUri != null)
            {
                hash = hash * 59 + SupportContactUri.GetHashCode();
            }

            if (SalesContactUri != null)
            {
                hash = hash * 59 + SalesContactUri.GetHashCode();
            }

            if (HelpLinks != null)
            {
                hash = hash * 59 + HelpLinks.GetHashCode();
            }

            if (Credentials != null)
            {
                hash = hash * 59 + Credentials.GetHashCode();
            }

            if (NonInstallable != null)
            {
                hash = hash * 59 + NonInstallable.GetHashCode();
            }

            if (MaxInstances != null)
            {
                hash = hash * 59 + MaxInstances.GetHashCode();
            }

            if (UserPermissions != null)
            {
                hash = hash * 59 + UserPermissions.GetHashCode();
            }

            if (VendorOAuthClientIds != null)
            {
                hash = hash * 59 + VendorOAuthClientIds.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
