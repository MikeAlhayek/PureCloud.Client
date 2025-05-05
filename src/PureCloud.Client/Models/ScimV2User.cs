using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM user.
/// </summary>

public partial class ScimV2User : IEquatable<ScimV2User>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2User" /> class.
    /// </summary>
    /// <param name="Active">Indicates whether the user&#39;s administrative status is active..</param>
    /// <param name="UserName">The user&#39;s Genesys Cloud email address. Must be unique..</param>
    /// <param name="DisplayName">The display name of the user..</param>
    /// <param name="Password">The new password for the Genesys Cloud user. Does not return an existing password. When creating a user, if a password is not supplied, then a password will be randomly generated that is 40 characters in length and contains five characters from each of the password policy groups..</param>
    /// <param name="Title">The user&#39;s title..</param>
    /// <param name="PhoneNumbers">The list of the user&#39;s phone numbers..</param>
    /// <param name="Emails">The list of the user&#39;s email addresses..</param>
    /// <param name="ExternalId">The external ID of the user. Set by the provisioning client. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readWrite\&quot;..</param>
    /// <param name="Roles">The list of roles assigned to the user..</param>
    /// <param name="Urnietfparamsscimschemasextensionenterprise20User">The URI of the schema for the enterprise user..</param>
    /// <param name="Urnietfparamsscimschemasextensiongenesyspurecloud20User">The URI of the schema for the Genesys Cloud user..</param>
    public ScimV2User(bool? Active = null, string UserName = null, string DisplayName = null, string Password = null, string Title = null, List<ScimPhoneNumber> PhoneNumbers = null, List<ScimEmail> Emails = null, string ExternalId = null, List<ScimUserRole> Roles = null, ScimV2EnterpriseUser Urnietfparamsscimschemasextensionenterprise20User = null, ScimUserExtensions Urnietfparamsscimschemasextensiongenesyspurecloud20User = null)
    {
        this.Active = Active;
        this.UserName = UserName;
        this.DisplayName = DisplayName;
        this.Password = Password;
        this.Title = Title;
        this.PhoneNumbers = PhoneNumbers;
        this.Emails = Emails;
        this.ExternalId = ExternalId;
        this.Roles = Roles;
        this.Urnietfparamsscimschemasextensionenterprise20User = Urnietfparamsscimschemasextensionenterprise20User;
        this.Urnietfparamsscimschemasextensiongenesyspurecloud20User = Urnietfparamsscimschemasextensiongenesyspurecloud20User;

    }



    /// <summary>
    /// The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;returned\&quot; is set to \&quot;always\&quot;.
    /// </summary>
    /// <value>The ID of the SCIM resource. Set by the service provider. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readOnly\&quot;. \&quot;returned\&quot; is set to \&quot;always\&quot;.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The list of supported schemas.
    /// </summary>
    /// <value>The list of supported schemas.</value>
    [JsonPropertyName("schemas")]
    public List<string> Schemas { get; private set; }



    /// <summary>
    /// Indicates whether the user&#39;s administrative status is active.
    /// </summary>
    /// <value>Indicates whether the user&#39;s administrative status is active.</value>
    [JsonPropertyName("active")]
    public bool? Active { get; set; }



    /// <summary>
    /// The user&#39;s Genesys Cloud email address. Must be unique.
    /// </summary>
    /// <value>The user&#39;s Genesys Cloud email address. Must be unique.</value>
    [JsonPropertyName("userName")]
    public string UserName { get; set; }



    /// <summary>
    /// The display name of the user.
    /// </summary>
    /// <value>The display name of the user.</value>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }



    /// <summary>
    /// The new password for the Genesys Cloud user. Does not return an existing password. When creating a user, if a password is not supplied, then a password will be randomly generated that is 40 characters in length and contains five characters from each of the password policy groups.
    /// </summary>
    /// <value>The new password for the Genesys Cloud user. Does not return an existing password. When creating a user, if a password is not supplied, then a password will be randomly generated that is 40 characters in length and contains five characters from each of the password policy groups.</value>
    [JsonPropertyName("password")]
    public string Password { get; set; }



    /// <summary>
    /// The user&#39;s title.
    /// </summary>
    /// <value>The user&#39;s title.</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// The list of the user&#39;s phone numbers.
    /// </summary>
    /// <value>The list of the user&#39;s phone numbers.</value>
    [JsonPropertyName("phoneNumbers")]
    public List<ScimPhoneNumber> PhoneNumbers { get; set; }



    /// <summary>
    /// The list of the user&#39;s email addresses.
    /// </summary>
    /// <value>The list of the user&#39;s email addresses.</value>
    [JsonPropertyName("emails")]
    public List<ScimEmail> Emails { get; set; }



    /// <summary>
    /// The external ID of the user. Set by the provisioning client. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readWrite\&quot;.
    /// </summary>
    /// <value>The external ID of the user. Set by the provisioning client. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readWrite\&quot;.</value>
    [JsonPropertyName("externalId")]
    public string ExternalId { get; set; }



    /// <summary>
    /// The list of groups that the user is a member of. This list is immutable per SCIM RFC and may only be updated using the GROUPS resource endpoint.
    /// </summary>
    /// <value>The list of groups that the user is a member of. This list is immutable per SCIM RFC and may only be updated using the GROUPS resource endpoint.</value>
    [JsonPropertyName("groups")]
    public List<ScimV2GroupReference> Groups { get; private set; }



    /// <summary>
    /// The list of roles assigned to the user.
    /// </summary>
    /// <value>The list of roles assigned to the user.</value>
    [JsonPropertyName("roles")]
    public List<ScimUserRole> Roles { get; set; }



    /// <summary>
    /// The URI of the schema for the enterprise user.
    /// </summary>
    /// <value>The URI of the schema for the enterprise user.</value>
    [JsonPropertyName("urn:ietf:params:scim:schemas:extension:enterprise:2.0:User")]
    public ScimV2EnterpriseUser Urnietfparamsscimschemasextensionenterprise20User { get; set; }



    /// <summary>
    /// The URI of the schema for the Genesys Cloud user.
    /// </summary>
    /// <value>The URI of the schema for the Genesys Cloud user.</value>
    [JsonPropertyName("urn:ietf:params:scim:schemas:extension:genesys:purecloud:2.0:User")]
    public ScimUserExtensions Urnietfparamsscimschemasextensiongenesyspurecloud20User { get; set; }



    /// <summary>
    /// The metadata of the SCIM resource. Metadata is defined as immutable per SCIM RFC.
    /// </summary>
    /// <value>The metadata of the SCIM resource. Metadata is defined as immutable per SCIM RFC.</value>
    [JsonPropertyName("meta")]
    public ScimMetadata Meta { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimV2User {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Schemas: ").Append(Schemas).Append("\n");
        sb.Append("  Active: ").Append(Active).Append("\n");
        sb.Append("  UserName: ").Append(UserName).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
        sb.Append("  Emails: ").Append(Emails).Append("\n");
        sb.Append("  ExternalId: ").Append(ExternalId).Append("\n");
        sb.Append("  Groups: ").Append(Groups).Append("\n");
        sb.Append("  Roles: ").Append(Roles).Append("\n");
        sb.Append("  Urnietfparamsscimschemasextensionenterprise20User: ").Append(Urnietfparamsscimschemasextensionenterprise20User).Append("\n");
        sb.Append("  Urnietfparamsscimschemasextensiongenesyspurecloud20User: ").Append(Urnietfparamsscimschemasextensiongenesyspurecloud20User).Append("\n");
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
        return Equals(obj as ScimV2User);
    }

    /// <summary>
    /// Returns true if ScimV2User instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimV2User to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimV2User other)
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
                Schemas == other.Schemas ||
                Schemas != null &&
                Schemas.SequenceEqual(other.Schemas)
            ) &&
            (
                Active == other.Active ||
                Active != null &&
                Active.Equals(other.Active)
            ) &&
            (
                UserName == other.UserName ||
                UserName != null &&
                UserName.Equals(other.UserName)
            ) &&
            (
                DisplayName == other.DisplayName ||
                DisplayName != null &&
                DisplayName.Equals(other.DisplayName)
            ) &&
            (
                Password == other.Password ||
                Password != null &&
                Password.Equals(other.Password)
            ) &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                PhoneNumbers == other.PhoneNumbers ||
                PhoneNumbers != null &&
                PhoneNumbers.SequenceEqual(other.PhoneNumbers)
            ) &&
            (
                Emails == other.Emails ||
                Emails != null &&
                Emails.SequenceEqual(other.Emails)
            ) &&
            (
                ExternalId == other.ExternalId ||
                ExternalId != null &&
                ExternalId.Equals(other.ExternalId)
            ) &&
            (
                Groups == other.Groups ||
                Groups != null &&
                Groups.SequenceEqual(other.Groups)
            ) &&
            (
                Roles == other.Roles ||
                Roles != null &&
                Roles.SequenceEqual(other.Roles)
            ) &&
            (
                Urnietfparamsscimschemasextensionenterprise20User == other.Urnietfparamsscimschemasextensionenterprise20User ||
                Urnietfparamsscimschemasextensionenterprise20User != null &&
                Urnietfparamsscimschemasextensionenterprise20User.Equals(other.Urnietfparamsscimschemasextensionenterprise20User)
            ) &&
            (
                Urnietfparamsscimschemasextensiongenesyspurecloud20User == other.Urnietfparamsscimschemasextensiongenesyspurecloud20User ||
                Urnietfparamsscimschemasextensiongenesyspurecloud20User != null &&
                Urnietfparamsscimschemasextensiongenesyspurecloud20User.Equals(other.Urnietfparamsscimschemasextensiongenesyspurecloud20User)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Schemas != null)
            {
                hash = hash * 59 + Schemas.GetHashCode();
            }

            if (Active != null)
            {
                hash = hash * 59 + Active.GetHashCode();
            }

            if (UserName != null)
            {
                hash = hash * 59 + UserName.GetHashCode();
            }

            if (DisplayName != null)
            {
                hash = hash * 59 + DisplayName.GetHashCode();
            }

            if (Password != null)
            {
                hash = hash * 59 + Password.GetHashCode();
            }

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (PhoneNumbers != null)
            {
                hash = hash * 59 + PhoneNumbers.GetHashCode();
            }

            if (Emails != null)
            {
                hash = hash * 59 + Emails.GetHashCode();
            }

            if (ExternalId != null)
            {
                hash = hash * 59 + ExternalId.GetHashCode();
            }

            if (Groups != null)
            {
                hash = hash * 59 + Groups.GetHashCode();
            }

            if (Roles != null)
            {
                hash = hash * 59 + Roles.GetHashCode();
            }

            if (Urnietfparamsscimschemasextensionenterprise20User != null)
            {
                hash = hash * 59 + Urnietfparamsscimschemasextensionenterprise20User.GetHashCode();
            }

            if (Urnietfparamsscimschemasextensiongenesyspurecloud20User != null)
            {
                hash = hash * 59 + Urnietfparamsscimschemasextensiongenesyspurecloud20User.GetHashCode();
            }

            if (Meta != null)
            {
                hash = hash * 59 + Meta.GetHashCode();
            }

            return hash;
        }
    }
}
