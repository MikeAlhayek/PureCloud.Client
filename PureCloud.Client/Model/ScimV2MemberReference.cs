using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Defines a reference to SCIM group members.
    /// </summary>
    [DataContract]
    public partial class ScimV2MemberReference : IEquatable<ScimV2MemberReference>
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
        /// Initializes a new instance of the <see cref="ScimV2MemberReference" /> class.
        /// </summary>
        /// <param name="Value">The ID of the group member. Can be \&quot;userId\&quot; or \&quot;groupId\&quot;..</param>
        public ScimV2MemberReference(string Value = null)
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
            sb.Append("class ScimV2MemberReference {\n");

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
            return this.Equals(obj as ScimV2MemberReference);
        }

        /// <summary>
        /// Returns true if ScimV2MemberReference instances are equal
        /// </summary>
        /// <param name="other">Instance of ScimV2MemberReference to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScimV2MemberReference other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Type == other.Type ||
                    this.Type != null &&
                    this.Type.Equals(other.Type)
                ) &&
                (
                    this.Value == other.Value ||
                    this.Value != null &&
                    this.Value.Equals(other.Value)
                ) &&
                (
                    this.Ref == other.Ref ||
                    this.Ref != null &&
                    this.Ref.Equals(other.Ref)
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
                if (this.Type != null)
                    hash = hash * 59 + this.Type.GetHashCode();

                if (this.Value != null)
                    hash = hash * 59 + this.Value.GetHashCode();

                if (this.Ref != null)
                    hash = hash * 59 + this.Ref.GetHashCode();

                return hash;
            }
        }
    }

}
