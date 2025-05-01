using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateShareRequest
/// </summary>
[DataContract]
public partial class CreateShareRequest : IEquatable<CreateShareRequest>
{
    /// <summary>
    /// The share entity type
    /// </summary>
    /// <value>The share entity type</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SharedEntityTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Document for "DOCUMENT"
        /// </summary>
        [EnumMember(Value = "DOCUMENT")]
        Document
    }
    /// <summary>
    /// Gets or Sets MemberType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum MemberTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum User for "USER"
        /// </summary>
        [EnumMember(Value = "USER")]
        User,

        /// <summary>
        /// Enum Group for "GROUP"
        /// </summary>
        [EnumMember(Value = "GROUP")]
        Group,

        /// <summary>
        /// Enum Public for "PUBLIC"
        /// </summary>
        [EnumMember(Value = "PUBLIC")]
        Public
    }
    /// <summary>
    /// The share entity type
    /// </summary>
    /// <value>The share entity type</value>
    [DataMember(Name = "sharedEntityType", EmitDefaultValue = false)]
    public SharedEntityTypeEnum? SharedEntityType { get; set; }
    /// <summary>
    /// Gets or Sets MemberType
    /// </summary>
    [DataMember(Name = "memberType", EmitDefaultValue = false)]
    public MemberTypeEnum? MemberType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateShareRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateShareRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateShareRequest" /> class.
    /// </summary>
    /// <param name="SharedEntityType">The share entity type (required).</param>
    /// <param name="SharedEntity">The entity that will be shared (required).</param>
    /// <param name="MemberType">MemberType.</param>
    /// <param name="Member">The member that will have access to this share. Only required if a list of members is not provided..</param>
    /// <param name="Members">Members.</param>
    public CreateShareRequest(SharedEntityTypeEnum? SharedEntityType = null, SharedEntity SharedEntity = null, MemberTypeEnum? MemberType = null, SharedEntity Member = null, List<CreateShareRequestMember> Members = null)
    {
        this.SharedEntityType = SharedEntityType;
        this.SharedEntity = SharedEntity;
        this.MemberType = MemberType;
        this.Member = Member;
        this.Members = Members;

    }





    /// <summary>
    /// The entity that will be shared
    /// </summary>
    /// <value>The entity that will be shared</value>
    [DataMember(Name = "sharedEntity", EmitDefaultValue = false)]
    public SharedEntity SharedEntity { get; set; }





    /// <summary>
    /// The member that will have access to this share. Only required if a list of members is not provided.
    /// </summary>
    /// <value>The member that will have access to this share. Only required if a list of members is not provided.</value>
    [DataMember(Name = "member", EmitDefaultValue = false)]
    public SharedEntity Member { get; set; }



    /// <summary>
    /// Gets or Sets Members
    /// </summary>
    [DataMember(Name = "members", EmitDefaultValue = false)]
    public List<CreateShareRequestMember> Members { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateShareRequest {\n");

        sb.Append("  SharedEntityType: ").Append(SharedEntityType).Append("\n");
        sb.Append("  SharedEntity: ").Append(SharedEntity).Append("\n");
        sb.Append("  MemberType: ").Append(MemberType).Append("\n");
        sb.Append("  Member: ").Append(Member).Append("\n");
        sb.Append("  Members: ").Append(Members).Append("\n");
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
        return Equals(obj as CreateShareRequest);
    }

    /// <summary>
    /// Returns true if CreateShareRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateShareRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateShareRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SharedEntityType == other.SharedEntityType ||
                SharedEntityType != null &&
                SharedEntityType.Equals(other.SharedEntityType)
            ) &&
            (
                SharedEntity == other.SharedEntity ||
                SharedEntity != null &&
                SharedEntity.Equals(other.SharedEntity)
            ) &&
            (
                MemberType == other.MemberType ||
                MemberType != null &&
                MemberType.Equals(other.MemberType)
            ) &&
            (
                Member == other.Member ||
                Member != null &&
                Member.Equals(other.Member)
            ) &&
            (
                Members == other.Members ||
                Members != null &&
                Members.SequenceEqual(other.Members)
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
            if (SharedEntityType != null)
            {
                hash = hash * 59 + SharedEntityType.GetHashCode();
            }

            if (SharedEntity != null)
            {
                hash = hash * 59 + SharedEntity.GetHashCode();
            }

            if (MemberType != null)
            {
                hash = hash * 59 + MemberType.GetHashCode();
            }

            if (Member != null)
            {
                hash = hash * 59 + Member.GetHashCode();
            }

            if (Members != null)
            {
                hash = hash * 59 + Members.GetHashCode();
            }

            return hash;
        }
    }
}
