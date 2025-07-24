using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines the creation of a SCIM user.
/// </summary>

public sealed class ScimV2CreateUser
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2CreateUser" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ScimV2CreateUser() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2CreateUser" /> class.
    /// </summary>
    /// <param name="Active">Indicates whether the user&#39;s administrative status is active..</param>
    /// <param name="UserName">The user&#39;s Genesys Cloud email address. Must be unique. (required).</param>
    /// <param name="DisplayName">The display name of the user. (required).</param>
    /// <param name="Password">The new password for the Genesys Cloud user. Does not return an existing password. When creating a user, if a password is not supplied, then a password will be randomly generated that is 40 characters in length and contains five characters from each of the password policy groups..</param>
    /// <param name="Title">The user&#39;s title..</param>
    /// <param name="PhoneNumbers">The list of the user&#39;s phone numbers..</param>
    /// <param name="Emails">The list of the user&#39;s email addresses..</param>
    /// <param name="ExternalId">The external ID of the user. Set by the provisioning client. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readWrite\&quot;..</param>
    /// <param name="Roles">The list of roles assigned to the user..</param>
    /// <param name="Urnietfparamsscimschemasextensionenterprise20User">The URI of the schema for the enterprise user..</param>
    /// <param name="Urnietfparamsscimschemasextensiongenesyspurecloud20User">The URI of the schema for the Genesys Cloud user..</param>



    /// <summary>
    /// The list of supported schemas.
    /// </summary>
    /// <value>The list of supported schemas.</value>
    public IEnumerable<string> Schemas { get; set; }



    /// <summary>
    /// Indicates whether the user&#39;s administrative status is active.
    /// </summary>
    /// <value>Indicates whether the user&#39;s administrative status is active.</value>
    public bool? Active { get; set; }



    /// <summary>
    /// The user&#39;s Genesys Cloud email address. Must be unique.
    /// </summary>
    /// <value>The user&#39;s Genesys Cloud email address. Must be unique.</value>
    public string UserName { get; set; }



    /// <summary>
    /// The display name of the user.
    /// </summary>
    /// <value>The display name of the user.</value>
    public string DisplayName { get; set; }



    /// <summary>
    /// The new password for the Genesys Cloud user. Does not return an existing password. When creating a user, if a password is not supplied, then a password will be randomly generated that is 40 characters in length and contains five characters from each of the password policy groups.
    /// </summary>
    /// <value>The new password for the Genesys Cloud user. Does not return an existing password. When creating a user, if a password is not supplied, then a password will be randomly generated that is 40 characters in length and contains five characters from each of the password policy groups.</value>
    public string Password { get; set; }



    /// <summary>
    /// The user&#39;s title.
    /// </summary>
    /// <value>The user&#39;s title.</value>
    public string Title { get; set; }



    /// <summary>
    /// The list of the user&#39;s phone numbers.
    /// </summary>
    /// <value>The list of the user&#39;s phone numbers.</value>
    public IEnumerable<ScimPhoneNumber> PhoneNumbers { get; set; }



    /// <summary>
    /// The list of the user&#39;s email addresses.
    /// </summary>
    /// <value>The list of the user&#39;s email addresses.</value>
    public IEnumerable<ScimEmail> Emails { get; set; }



    /// <summary>
    /// The external ID of the user. Set by the provisioning client. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readWrite\&quot;.
    /// </summary>
    /// <value>The external ID of the user. Set by the provisioning client. \&quot;caseExact\&quot; is set to \&quot;true\&quot;. \&quot;mutability\&quot; is set to \&quot;readWrite\&quot;.</value>
    public string ExternalId { get; set; }



    /// <summary>
    /// The list of groups that the user is a member of. This list is immutable per SCIM RFC and may only be updated using the GROUPS resource endpoint.
    /// </summary>
    /// <value>The list of groups that the user is a member of. This list is immutable per SCIM RFC and may only be updated using the GROUPS resource endpoint.</value>
    public IEnumerable<ScimV2GroupReference> Groups { get; set; }



    /// <summary>
    /// The list of roles assigned to the user.
    /// </summary>
    /// <value>The list of roles assigned to the user.</value>
    public IEnumerable<ScimUserRole> Roles { get; set; }



    /// <summary>
    /// The URI of the schema for the enterprise user.
    /// </summary>
    /// <value>The URI of the schema for the enterprise user.</value>
    public ScimV2EnterpriseUser Urnietfparamsscimschemasextensionenterprise20User { get; set; }



    /// <summary>
    /// The URI of the schema for the Genesys Cloud user.
    /// </summary>
    /// <value>The URI of the schema for the Genesys Cloud user.</value>
    public ScimUserExtensions Urnietfparamsscimschemasextensiongenesyspurecloud20User { get; set; }


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
    /// Returns true if ScimV2CreateUser instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimV2CreateUser to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
