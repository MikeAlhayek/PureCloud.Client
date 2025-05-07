using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM error.
/// </summary>

public partial class ScimError : IEquatable<ScimError>
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
    [JsonPropertyName("scimType")]
    public ScimTypeEnum? ScimType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimError" /> class.
    /// </summary>
    public ScimError()
    {

    }



    /// <summary>
    /// The list of schemas for the SCIM error.
    /// </summary>
    /// <value>The list of schemas for the SCIM error.</value>
    [JsonPropertyName("schemas")]
    public List<string> Schemas { get; set; }



    /// <summary>
    /// The HTTP status code returned for the SCIM error.
    /// </summary>
    /// <value>The HTTP status code returned for the SCIM error.</value>
    [JsonPropertyName("status")]
    public string Status { get; set; }





    /// <summary>
    /// The detailed description of the SCIM error.
    /// </summary>
    /// <value>The detailed description of the SCIM error.</value>
    [JsonPropertyName("detail")]
    public string Detail { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimError {\n");

        sb.Append("  Schemas: ").Append(Schemas).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  ScimType: ").Append(ScimType).Append("\n");
        sb.Append("  Detail: ").Append(Detail).Append("\n");
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
        return Equals(obj as ScimError);
    }

    /// <summary>
    /// Returns true if ScimError instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimError to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimError other)
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
                Status == other.Status ||
                Status != null &&
                Status.Equals(other.Status)
            ) &&
            (
                ScimType == other.ScimType ||
                ScimType != null &&
                ScimType.Equals(other.ScimType)
            ) &&
            (
                Detail == other.Detail ||
                Detail != null &&
                Detail.Equals(other.Detail)
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

            if (Status != null)
            {
                hash = hash * 59 + Status.GetHashCode();
            }

            if (ScimType != null)
            {
                hash = hash * 59 + ScimType.GetHashCode();
            }

            if (Detail != null)
            {
                hash = hash * 59 + Detail.GetHashCode();
            }

            return hash;
        }
    }
}
