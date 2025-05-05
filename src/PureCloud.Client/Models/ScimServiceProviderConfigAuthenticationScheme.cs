using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines an authentication scheme in the SCIM service provider&#39;s configuration.
/// </summary>

public partial class ScimServiceProviderConfigAuthenticationScheme : IEquatable<ScimServiceProviderConfigAuthenticationScheme>
{
    /// <summary>
    /// The type of authentication scheme.
    /// </summary>
    /// <value>The type of authentication scheme.</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Oauth for "oauth"
        /// </summary>
        [EnumMember(Value = "oauth")]
        Oauth,

        /// <summary>
        /// Enum Oauth2 for "oauth2"
        /// </summary>
        [EnumMember(Value = "oauth2")]
        Oauth2,

        /// <summary>
        /// Enum Oauthbearertoken for "oauthbearertoken"
        /// </summary>
        [EnumMember(Value = "oauthbearertoken")]
        Oauthbearertoken,

        /// <summary>
        /// Enum Httpbasic for "httpbasic"
        /// </summary>
        [EnumMember(Value = "httpbasic")]
        Httpbasic,

        /// <summary>
        /// Enum Httpdigest for "httpdigest"
        /// </summary>
        [EnumMember(Value = "httpdigest")]
        Httpdigest
    }
    /// <summary>
    /// The type of authentication scheme.
    /// </summary>
    /// <value>The type of authentication scheme.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimServiceProviderConfigAuthenticationScheme" /> class.
    /// </summary>
    public ScimServiceProviderConfigAuthenticationScheme()
    {

    }



    /// <summary>
    /// The name of the authentication scheme, for example, HTTP Basic.
    /// </summary>
    /// <value>The name of the authentication scheme, for example, HTTP Basic.</value>
    [JsonPropertyName("name")]
    public string Name { get; private set; }



    /// <summary>
    /// The description of the authentication scheme.
    /// </summary>
    /// <value>The description of the authentication scheme.</value>
    [JsonPropertyName("description")]
    public string Description { get; private set; }



    /// <summary>
    /// The HTTP-addressable URL that points to the authentication scheme&#39;s specification.
    /// </summary>
    /// <value>The HTTP-addressable URL that points to the authentication scheme&#39;s specification.</value>
    [JsonPropertyName("specUri")]
    public string SpecUri { get; private set; }



    /// <summary>
    /// The HTTP-addressable URL that points to the authentication scheme&#39;s usage documentation.
    /// </summary>
    /// <value>The HTTP-addressable URL that points to the authentication scheme&#39;s usage documentation.</value>
    [JsonPropertyName("documentationUri")]
    public string DocumentationUri { get; private set; }





    /// <summary>
    /// Indicates whether this authentication scheme is the primary method of authentication.
    /// </summary>
    /// <value>Indicates whether this authentication scheme is the primary method of authentication.</value>
    [JsonPropertyName("primary")]
    public bool? Primary { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimServiceProviderConfigAuthenticationScheme {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  SpecUri: ").Append(SpecUri).Append("\n");
        sb.Append("  DocumentationUri: ").Append(DocumentationUri).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Primary: ").Append(Primary).Append("\n");
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
        return Equals(obj as ScimServiceProviderConfigAuthenticationScheme);
    }

    /// <summary>
    /// Returns true if ScimServiceProviderConfigAuthenticationScheme instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimServiceProviderConfigAuthenticationScheme to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimServiceProviderConfigAuthenticationScheme other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                SpecUri == other.SpecUri ||
                SpecUri != null &&
                SpecUri.Equals(other.SpecUri)
            ) &&
            (
                DocumentationUri == other.DocumentationUri ||
                DocumentationUri != null &&
                DocumentationUri.Equals(other.DocumentationUri)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Primary == other.Primary ||
                Primary != null &&
                Primary.Equals(other.Primary)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (SpecUri != null)
            {
                hash = hash * 59 + SpecUri.GetHashCode();
            }

            if (DocumentationUri != null)
            {
                hash = hash * 59 + DocumentationUri.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Primary != null)
            {
                hash = hash * 59 + Primary.GetHashCode();
            }

            return hash;
        }
    }
}
