using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM error.
/// </summary>

public sealed class ScimError
{
    /// <summary>
    /// The type of SCIM error when httpStatus is a \"400\" error.
    /// </summary>
    /// <value>The type of SCIM error when httpStatus is a \"400\" error.</value>
    
    public enum ScimTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Invalidfilter for "invalidFilter"
        /// </summary>
        [EnumMember(Value = "invalidFilter")]
        Invalidfilter,

        /// <summary>
        /// Enum Toomany for "tooMany"
        /// </summary>
        [EnumMember(Value = "tooMany")]
        Toomany,

        /// <summary>
        /// Enum Uniqueness for "uniqueness"
        /// </summary>
        [EnumMember(Value = "uniqueness")]
        Uniqueness,

        /// <summary>
        /// Enum Mutability for "mutability"
        /// </summary>
        [EnumMember(Value = "mutability")]
        Mutability,

        /// <summary>
        /// Enum Invalidsyntax for "invalidSyntax"
        /// </summary>
        [EnumMember(Value = "invalidSyntax")]
        Invalidsyntax,

        /// <summary>
        /// Enum Invalidpath for "invalidPath"
        /// </summary>
        [EnumMember(Value = "invalidPath")]
        Invalidpath,

        /// <summary>
        /// Enum Notarget for "noTarget"
        /// </summary>
        [EnumMember(Value = "noTarget")]
        Notarget,

        /// <summary>
        /// Enum Invalidvalue for "invalidValue"
        /// </summary>
        [EnumMember(Value = "invalidValue")]
        Invalidvalue,

        /// <summary>
        /// Enum Invalidvers for "invalidVers"
        /// </summary>
        [EnumMember(Value = "invalidVers")]
        Invalidvers,

        /// <summary>
        /// Enum Sensitive for "sensitive"
        /// </summary>
        [EnumMember(Value = "sensitive")]
        Sensitive
    }
    /// <summary>
    /// The type of SCIM error when httpStatus is a \"400\" error.
    /// </summary>
    /// <value>The type of SCIM error when httpStatus is a \"400\" error.</value>
    public ScimTypeEnum? ScimType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimError" /> class.
    /// </summary>



    /// <summary>
    /// The list of schemas for the SCIM error.
    /// </summary>
    /// <value>The list of schemas for the SCIM error.</value>
    public IEnumerable<string> Schemas { get; set; }



    /// <summary>
    /// The HTTP status code returned for the SCIM error.
    /// </summary>
    /// <value>The HTTP status code returned for the SCIM error.</value>
    public string Status { get; set; }





    /// <summary>
    /// The detailed description of the SCIM error.
    /// </summary>
    /// <value>The detailed description of the SCIM error.</value>
    public string Detail { get; set; }


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
    /// Returns true if ScimError instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimError to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
