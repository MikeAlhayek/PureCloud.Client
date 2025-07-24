using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// External Identifiers of user. The external identifier must be unique within the organization and the &#39;authority&#39;
/// </summary>

public sealed class ScimGenesysUserExternalId
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ScimGenesysUserExternalId" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ScimGenesysUserExternalId() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimGenesysUserExternalId" /> class.
    /// </summary>
    /// <param name="Authority">Authority, or scope, of \&quot;externalId\&quot;. Allows multiple external identifiers to be defined. Represents the source of the external identifier. (required).</param>
    /// <param name="Value">Identifier of the user in an external system. (required).</param>



    /// <summary>
    /// Authority, or scope, of \&quot;externalId\&quot;. Allows multiple external identifiers to be defined. Represents the source of the external identifier.
    /// </summary>
    /// <value>Authority, or scope, of \&quot;externalId\&quot;. Allows multiple external identifiers to be defined. Represents the source of the external identifier.</value>
    public string Authority { get; set; }



    /// <summary>
    /// Identifier of the user in an external system.
    /// </summary>
    /// <value>Identifier of the user in an external system.</value>
    public string Value { get; set; }


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
    /// Returns true if ScimGenesysUserExternalId instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimGenesysUserExternalId to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
