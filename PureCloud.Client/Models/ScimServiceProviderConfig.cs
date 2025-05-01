using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM service provider&#39;s configuration.
/// </summary>
[DataContract]
public partial class ScimServiceProviderConfig : IEquatable<ScimServiceProviderConfig>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimServiceProviderConfig" /> class.
    /// </summary>
    public ScimServiceProviderConfig()
    {

    }



    /// <summary>
    /// The list of supported schemas.
    /// </summary>
    /// <value>The list of supported schemas.</value>
    [DataMember(Name = "schemas", EmitDefaultValue = false)]
    public List<string> Schemas { get; private set; }



    /// <summary>
    /// The HTTP-addressable URL that points to the service provider&#39;s documentation.
    /// </summary>
    /// <value>The HTTP-addressable URL that points to the service provider&#39;s documentation.</value>
    [DataMember(Name = "documentationUri", EmitDefaultValue = false)]
    public string DocumentationUri { get; private set; }



    /// <summary>
    /// The \&quot;patch\&quot; configuration options.
    /// </summary>
    /// <value>The \&quot;patch\&quot; configuration options.</value>
    [DataMember(Name = "patch", EmitDefaultValue = false)]
    public ScimServiceProviderConfigSimpleFeature Patch { get; private set; }



    /// <summary>
    /// The \&quot;filter\&quot; configuration options.
    /// </summary>
    /// <value>The \&quot;filter\&quot; configuration options.</value>
    [DataMember(Name = "filter", EmitDefaultValue = false)]
    public ScimServiceProviderConfigFilterFeature Filter { get; private set; }



    /// <summary>
    /// The \&quot;etag\&quot; configuration options.
    /// </summary>
    /// <value>The \&quot;etag\&quot; configuration options.</value>
    [DataMember(Name = "etag", EmitDefaultValue = false)]
    public ScimServiceProviderConfigSimpleFeature Etag { get; private set; }



    /// <summary>
    /// The \&quot;sort\&quot; configuration options.
    /// </summary>
    /// <value>The \&quot;sort\&quot; configuration options.</value>
    [DataMember(Name = "sort", EmitDefaultValue = false)]
    public ScimServiceProviderConfigSimpleFeature Sort { get; private set; }



    /// <summary>
    /// The \&quot;bulk\&quot; configuration options.
    /// </summary>
    /// <value>The \&quot;bulk\&quot; configuration options.</value>
    [DataMember(Name = "bulk", EmitDefaultValue = false)]
    public ScimServiceProviderConfigBulkFeature Bulk { get; private set; }



    /// <summary>
    /// The \&quot;changePassword\&quot; configuration options.
    /// </summary>
    /// <value>The \&quot;changePassword\&quot; configuration options.</value>
    [DataMember(Name = "changePassword", EmitDefaultValue = false)]
    public ScimServiceProviderConfigSimpleFeature ChangePassword { get; private set; }



    /// <summary>
    /// The list of supported authentication schemes.
    /// </summary>
    /// <value>The list of supported authentication schemes.</value>
    [DataMember(Name = "authenticationSchemes", EmitDefaultValue = false)]
    public List<ScimServiceProviderConfigAuthenticationScheme> AuthenticationSchemes { get; private set; }



    /// <summary>
    /// The metadata of the SCIM resource. Metadata is defined as immutable per SCIM RFC.
    /// </summary>
    /// <value>The metadata of the SCIM resource. Metadata is defined as immutable per SCIM RFC.</value>
    [DataMember(Name = "meta", EmitDefaultValue = false)]
    public ScimMetadata Meta { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimServiceProviderConfig {\n");

        sb.Append("  Schemas: ").Append(Schemas).Append("\n");
        sb.Append("  DocumentationUri: ").Append(DocumentationUri).Append("\n");
        sb.Append("  Patch: ").Append(Patch).Append("\n");
        sb.Append("  Filter: ").Append(Filter).Append("\n");
        sb.Append("  Etag: ").Append(Etag).Append("\n");
        sb.Append("  Sort: ").Append(Sort).Append("\n");
        sb.Append("  Bulk: ").Append(Bulk).Append("\n");
        sb.Append("  ChangePassword: ").Append(ChangePassword).Append("\n");
        sb.Append("  AuthenticationSchemes: ").Append(AuthenticationSchemes).Append("\n");
        sb.Append("  Meta: ").Append(Meta).Append("\n");
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
        return Equals(obj as ScimServiceProviderConfig);
    }

    /// <summary>
    /// Returns true if ScimServiceProviderConfig instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimServiceProviderConfig to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimServiceProviderConfig other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Schemas == other.Schemas ||
                Schemas != null &&
                Schemas.SequenceEqual(other.Schemas)
            ) &&
            (
                DocumentationUri == other.DocumentationUri ||
                DocumentationUri != null &&
                DocumentationUri.Equals(other.DocumentationUri)
            ) &&
            (
                Patch == other.Patch ||
                Patch != null &&
                Patch.Equals(other.Patch)
            ) &&
            (
                Filter == other.Filter ||
                Filter != null &&
                Filter.Equals(other.Filter)
            ) &&
            (
                Etag == other.Etag ||
                Etag != null &&
                Etag.Equals(other.Etag)
            ) &&
            (
                Sort == other.Sort ||
                Sort != null &&
                Sort.Equals(other.Sort)
            ) &&
            (
                Bulk == other.Bulk ||
                Bulk != null &&
                Bulk.Equals(other.Bulk)
            ) &&
            (
                ChangePassword == other.ChangePassword ||
                ChangePassword != null &&
                ChangePassword.Equals(other.ChangePassword)
            ) &&
            (
                AuthenticationSchemes == other.AuthenticationSchemes ||
                AuthenticationSchemes != null &&
                AuthenticationSchemes.SequenceEqual(other.AuthenticationSchemes)
            ) &&
            (
                Meta == other.Meta ||
                Meta != null &&
                Meta.Equals(other.Meta)
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
            if (Schemas != null)
            {
                hash = hash * 59 + Schemas.GetHashCode();
            }

            if (DocumentationUri != null)
            {
                hash = hash * 59 + DocumentationUri.GetHashCode();
            }

            if (Patch != null)
            {
                hash = hash * 59 + Patch.GetHashCode();
            }

            if (Filter != null)
            {
                hash = hash * 59 + Filter.GetHashCode();
            }

            if (Etag != null)
            {
                hash = hash * 59 + Etag.GetHashCode();
            }

            if (Sort != null)
            {
                hash = hash * 59 + Sort.GetHashCode();
            }

            if (Bulk != null)
            {
                hash = hash * 59 + Bulk.GetHashCode();
            }

            if (ChangePassword != null)
            {
                hash = hash * 59 + ChangePassword.GetHashCode();
            }

            if (AuthenticationSchemes != null)
            {
                hash = hash * 59 + AuthenticationSchemes.GetHashCode();
            }

            if (Meta != null)
            {
                hash = hash * 59 + Meta.GetHashCode();
            }

            return hash;
        }
    }
}
