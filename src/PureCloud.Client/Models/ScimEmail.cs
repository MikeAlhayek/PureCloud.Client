using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM email address.
/// </summary>

public sealed class ScimEmail
{
    /// <summary>
    /// The type of email address. \"value\" is immutable if \"type\" is set to \"other\".
    /// </summary>
    /// <value>The type of email address. \"value\" is immutable if \"type\" is set to \"other\".</value>
    
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
        /// Enum Work for "work"
        /// </summary>
        [EnumMember(Value = "work")]
        Work,

        /// <summary>
        /// Enum Other for "other"
        /// </summary>
        [EnumMember(Value = "other")]
        Other
    }
    /// <summary>
    /// The type of email address. \"value\" is immutable if \"type\" is set to \"other\".
    /// </summary>
    /// <value>The type of email address. \"value\" is immutable if \"type\" is set to \"other\".</value>
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimEmail" /> class.
    /// </summary>
    /// <param name="Value">The email address. Is immutable if \&quot;type\&quot; is set to \&quot;other\&quot;..</param>
    /// <param name="Type">The type of email address. \&quot;value\&quot; is immutable if \&quot;type\&quot; is set to \&quot;other\&quot;..</param>
    /// <param name="Primary">Indicates whether the email address is the primary email address..</param>



    /// <summary>
    /// The email address. Is immutable if \&quot;type\&quot; is set to \&quot;other\&quot;.
    /// </summary>
    /// <value>The email address. Is immutable if \&quot;type\&quot; is set to \&quot;other\&quot;.</value>
    public string Value { get; set; }





    /// <summary>
    /// Indicates whether the email address is the primary email address.
    /// </summary>
    /// <value>Indicates whether the email address is the primary email address.</value>
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
    /// Returns true if ScimEmail instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimEmail to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
