using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a SCIM PATCH operation. The path and value follow very specific rules based on operation types. See section 3.5.2 \&quot;Modifying with PATCH\&quot; in RFC 7644 for details.
/// </summary>

public sealed class ScimV2PatchOperation
{
    /// <summary>
    /// The PATCH operation to perform.
    /// </summary>
    /// <value>The PATCH operation to perform.</value>
    
    public enum OpEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Add for "add"
        /// </summary>
        [EnumMember(Value = "add")]
        Add,

        /// <summary>
        /// Enum Replace for "replace"
        /// </summary>
        [EnumMember(Value = "replace")]
        Replace,

        /// <summary>
        /// Enum Remove for "remove"
        /// </summary>
        [EnumMember(Value = "remove")]
        Remove
    }
    /// <summary>
    /// The PATCH operation to perform.
    /// </summary>
    /// <value>The PATCH operation to perform.</value>
    public OpEnum? Op { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2PatchOperation" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ScimV2PatchOperation() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2PatchOperation" /> class.
    /// </summary>
    /// <param name="Op">The PATCH operation to perform. (required).</param>
    /// <param name="Path">The attribute path that describes the target of the operation. Required for a \&quot;remove\&quot; operation..</param>
    /// <param name="Value">The value to set in the path..</param>





    /// <summary>
    /// The attribute path that describes the target of the operation. Required for a \&quot;remove\&quot; operation.
    /// </summary>
    /// <value>The attribute path that describes the target of the operation. Required for a \&quot;remove\&quot; operation.</value>
    public string Path { get; set; }



    /// <summary>
    /// The value to set in the path.
    /// </summary>
    /// <value>The value to set in the path.</value>
    public object Value { get; set; }


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
    /// Returns true if ScimV2PatchOperation instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimV2PatchOperation to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
