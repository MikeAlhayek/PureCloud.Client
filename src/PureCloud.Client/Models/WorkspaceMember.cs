using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkspaceMember
/// </summary>

public partial class WorkspaceMember : IEquatable<WorkspaceMember>
{
    /// <summary>
    /// The workspace member type.
    /// </summary>
    /// <value>The workspace member type.</value>
    
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
        Group
    }
    /// <summary>
    /// The workspace member type.
    /// </summary>
    /// <value>The workspace member type.</value>
    [JsonPropertyName("memberType")]
    public MemberTypeEnum? MemberType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkspaceMember" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WorkspaceMember() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkspaceMember" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Workspace">Workspace.</param>
    /// <param name="MemberType">The workspace member type. (required).</param>
    /// <param name="Member">Member.</param>
    /// <param name="User">User.</param>
    /// <param name="Group">Group.</param>
    /// <param name="SecurityProfile">SecurityProfile.</param>
    public WorkspaceMember(string Name = null, DomainEntityRef Workspace = null, MemberTypeEnum? MemberType = null, DomainEntityRef Member = null, User User = null, Group Group = null, SecurityProfile SecurityProfile = null)
    {
        this.Name = Name;
        this.Workspace = Workspace;
        this.MemberType = MemberType;
        this.Member = Member;
        this.User = User;
        this.Group = Group;
        this.SecurityProfile = SecurityProfile;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Workspace
    /// </summary>
    [JsonPropertyName("workspace")]
    public DomainEntityRef Workspace { get; set; }





    /// <summary>
    /// Gets or Sets Member
    /// </summary>
    [JsonPropertyName("member")]
    public DomainEntityRef Member { get; set; }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [JsonPropertyName("user")]
    public User User { get; set; }



    /// <summary>
    /// Gets or Sets Group
    /// </summary>
    [JsonPropertyName("group")]
    public Group Group { get; set; }



    /// <summary>
    /// Gets or Sets SecurityProfile
    /// </summary>
    [JsonPropertyName("securityProfile")]
    public SecurityProfile SecurityProfile { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkspaceMember {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Workspace: ").Append(Workspace).Append("\n");
        sb.Append("  MemberType: ").Append(MemberType).Append("\n");
        sb.Append("  Member: ").Append(Member).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Group: ").Append(Group).Append("\n");
        sb.Append("  SecurityProfile: ").Append(SecurityProfile).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as WorkspaceMember);
    }

    /// <summary>
    /// Returns true if WorkspaceMember instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkspaceMember to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkspaceMember other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Workspace == other.Workspace ||
                Workspace != null &&
                Workspace.Equals(other.Workspace)
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
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Group == other.Group ||
                Group != null &&
                Group.Equals(other.Group)
            ) &&
            (
                SecurityProfile == other.SecurityProfile ||
                SecurityProfile != null &&
                SecurityProfile.Equals(other.SecurityProfile)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Workspace != null)
            {
                hash = hash * 59 + Workspace.GetHashCode();
            }

            if (MemberType != null)
            {
                hash = hash * 59 + MemberType.GetHashCode();
            }

            if (Member != null)
            {
                hash = hash * 59 + Member.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Group != null)
            {
                hash = hash * 59 + Group.GetHashCode();
            }

            if (SecurityProfile != null)
            {
                hash = hash * 59 + SecurityProfile.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
