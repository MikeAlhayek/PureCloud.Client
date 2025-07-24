using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines the SCIM metadata.
/// </summary>

public sealed class ScimMetadata
{
    /// <summary>
    /// The type of SCIM resource.
    /// </summary>
    /// <value>The type of SCIM resource.</value>
    
    public enum ResourceTypeEnum
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
    public ResourceTypeEnum? ResourceType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimMetadata" /> class.
    /// </summary>





    /// <summary>
    /// The last time that the resource was modified. Date time is represented as an \&quot;ISO-8601 string\&quot;, for example, yyyy-MM-ddTHH:mm:ss.SSSZ. Not included with \&quot;Schema\&quot; and \&quot;ResourceType\&quot; resources.
    /// </summary>
    /// <value>The last time that the resource was modified. Date time is represented as an \&quot;ISO-8601 string\&quot;, for example, yyyy-MM-ddTHH:mm:ss.SSSZ. Not included with \&quot;Schema\&quot; and \&quot;ResourceType\&quot; resources.</value>
    public DateTime? LastModified { get; set; }



    /// <summary>
    /// The URI of the resource.
    /// </summary>
    /// <value>The URI of the resource.</value>
    public string Location { get; set; }



    /// <summary>
    /// The version of the resource. Matches the ETag HTTP response header. Not included with \&quot;Schema\&quot; and \&quot;ResourceType\&quot; resources.
    /// </summary>
    /// <value>The version of the resource. Matches the ETag HTTP response header. Not included with \&quot;Schema\&quot; and \&quot;ResourceType\&quot; resources.</value>
    public string Version { get; set; }


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
    /// Returns true if ScimMetadata instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimMetadata to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
