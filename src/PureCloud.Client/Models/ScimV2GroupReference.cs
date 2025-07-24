using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a reference to SCIM groups.
/// </summary>

public sealed class ScimV2GroupReference
{
    /// <summary>
    /// The type of SCIM resource.
    /// </summary>
    /// <value>The type of SCIM resource.</value>
    
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
        /// Enum User for "User"
        /// </summary>
        [EnumMember(Value = "User")]
        User,

        /// <summary>
        /// Enum Group for "Group"
        /// </summary>
        [EnumMember(Value = "Group")]
        Group,

        /// <summary>
        /// Enum Serviceproviderconfig for "ServiceProviderConfig"
        /// </summary>
        [EnumMember(Value = "ServiceProviderConfig")]
        Serviceproviderconfig,

        /// <summary>
        /// Enum Resourcetype for "ResourceType"
        /// </summary>
        [EnumMember(Value = "ResourceType")]
        Resourcetype,

        /// <summary>
        /// Enum Schema for "Schema"
        /// </summary>
        [EnumMember(Value = "Schema")]
        Schema
    }
    /// <summary>
    /// The type of SCIM resource.
    /// </summary>
    /// <value>The type of SCIM resource.</value>
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2GroupReference" /> class.
    /// </summary>
    /// <param name="Value">The ID of the group member. Can be \&quot;userId\&quot; or \&quot;groupId\&quot;..</param>





    /// <summary>
    /// The ID of the group member. Can be \&quot;userId\&quot; or \&quot;groupId\&quot;.
    /// </summary>
    /// <value>The ID of the group member. Can be \&quot;userId\&quot; or \&quot;groupId\&quot;.</value>
    public string Value { get; set; }



    /// <summary>
    /// The reference URI of the SCIM resource.
    /// </summary>
    /// <value>The reference URI of the SCIM resource.</value>
    public string Ref { get; set; }


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
    /// Returns true if ScimV2GroupReference instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimV2GroupReference to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
