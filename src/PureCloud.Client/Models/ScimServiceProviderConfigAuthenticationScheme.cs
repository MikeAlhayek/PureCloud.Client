using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines an authentication scheme in the SCIM service provider&#39;s configuration.
/// </summary>

public sealed class ScimServiceProviderConfigAuthenticationScheme
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
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimServiceProviderConfigAuthenticationScheme" /> class.
    /// </summary>



    /// <summary>
    /// The name of the authentication scheme, for example, HTTP Basic.
    /// </summary>
    /// <value>The name of the authentication scheme, for example, HTTP Basic.</value>
    public string Name { get; set; }



    /// <summary>
    /// The description of the authentication scheme.
    /// </summary>
    /// <value>The description of the authentication scheme.</value>
    public string Description { get; set; }



    /// <summary>
    /// The HTTP-addressable URL that points to the authentication scheme&#39;s specification.
    /// </summary>
    /// <value>The HTTP-addressable URL that points to the authentication scheme&#39;s specification.</value>
    public string SpecUri { get; set; }



    /// <summary>
    /// The HTTP-addressable URL that points to the authentication scheme&#39;s usage documentation.
    /// </summary>
    /// <value>The HTTP-addressable URL that points to the authentication scheme&#39;s usage documentation.</value>
    public string DocumentationUri { get; set; }





    /// <summary>
    /// Indicates whether this authentication scheme is the primary method of authentication.
    /// </summary>
    /// <value>Indicates whether this authentication scheme is the primary method of authentication.</value>
    public bool? Primary { get; set; }


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
    /// Returns true if ScimServiceProviderConfigAuthenticationScheme instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimServiceProviderConfigAuthenticationScheme to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
