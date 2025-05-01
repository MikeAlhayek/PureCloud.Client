using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a reference to SCIM groups.
/// </summary>
[DataContract]
public partial class ScimV2GroupReference : IEquatable<ScimV2GroupReference>
{
    /// <summary>
    /// The type of SCIM resource.
    /// </summary>
    /// <value>The type of SCIM resource.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2GroupReference" /> class.
    /// </summary>
    /// <param name="Value">The ID of the group member. Can be \&quot;userId\&quot; or \&quot;groupId\&quot;..</param>
    public ScimV2GroupReference(string Value = null)
    {
        this.Value = Value;

    }





    /// <summary>
    /// The ID of the group member. Can be \&quot;userId\&quot; or \&quot;groupId\&quot;.
    /// </summary>
    /// <value>The ID of the group member. Can be \&quot;userId\&quot; or \&quot;groupId\&quot;.</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }



    /// <summary>
    /// The reference URI of the SCIM resource.
    /// </summary>
    /// <value>The reference URI of the SCIM resource.</value>
    [DataMember(Name = "$ref", EmitDefaultValue = false)]
    public string Ref { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimV2GroupReference {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Ref: ").Append(Ref).Append("\n");
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
        return Equals(obj as ScimV2GroupReference);
    }

    /// <summary>
    /// Returns true if ScimV2GroupReference instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimV2GroupReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimV2GroupReference other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                Ref == other.Ref ||
                Ref != null &&
                Ref.Equals(other.Ref)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Ref != null)
            {
                hash = hash * 59 + Ref.GetHashCode();
            }

            return hash;
        }
    }
}
