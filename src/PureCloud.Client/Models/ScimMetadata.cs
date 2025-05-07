using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines the SCIM metadata.
/// </summary>

public partial class ScimMetadata : IEquatable<ScimMetadata>
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
    [JsonPropertyName("resourceType")]
    public ResourceTypeEnum? ResourceType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimMetadata" /> class.
    /// </summary>
    public ScimMetadata()
    {

    }





    /// <summary>
    /// The last time that the resource was modified. Date time is represented as an \&quot;ISO-8601 string\&quot;, for example, yyyy-MM-ddTHH:mm:ss.SSSZ. Not included with \&quot;Schema\&quot; and \&quot;ResourceType\&quot; resources.
    /// </summary>
    /// <value>The last time that the resource was modified. Date time is represented as an \&quot;ISO-8601 string\&quot;, for example, yyyy-MM-ddTHH:mm:ss.SSSZ. Not included with \&quot;Schema\&quot; and \&quot;ResourceType\&quot; resources.</value>
    [JsonPropertyName("lastModified")]
    public DateTime? LastModified { get; set; }



    /// <summary>
    /// The URI of the resource.
    /// </summary>
    /// <value>The URI of the resource.</value>
    [JsonPropertyName("location")]
    public string Location { get; set; }



    /// <summary>
    /// The version of the resource. Matches the ETag HTTP response header. Not included with \&quot;Schema\&quot; and \&quot;ResourceType\&quot; resources.
    /// </summary>
    /// <value>The version of the resource. Matches the ETag HTTP response header. Not included with \&quot;Schema\&quot; and \&quot;ResourceType\&quot; resources.</value>
    [JsonPropertyName("version")]
    public string Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimMetadata {\n");

        sb.Append("  ResourceType: ").Append(ResourceType).Append("\n");
        sb.Append("  LastModified: ").Append(LastModified).Append("\n");
        sb.Append("  Location: ").Append(Location).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as ScimMetadata);
    }

    /// <summary>
    /// Returns true if ScimMetadata instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimMetadata to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimMetadata other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ResourceType == other.ResourceType ||
                ResourceType != null &&
                ResourceType.Equals(other.ResourceType)
            ) &&
            (
                LastModified == other.LastModified ||
                LastModified != null &&
                LastModified.Equals(other.LastModified)
            ) &&
            (
                Location == other.Location ||
                Location != null &&
                Location.Equals(other.Location)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
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
            if (ResourceType != null)
            {
                hash = hash * 59 + ResourceType.GetHashCode();
            }

            if (LastModified != null)
            {
                hash = hash * 59 + LastModified.GetHashCode();
            }

            if (Location != null)
            {
                hash = hash * 59 + Location.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            return hash;
        }
    }
}
