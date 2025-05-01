using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// GroupCreate
/// </summary>
[DataContract]
public partial class GroupCreate : IEquatable<GroupCreate>
{
    /// <summary>
    /// Active, inactive, or deleted state.
    /// </summary>
    /// <value>Active, inactive, or deleted state.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Active for "active"
        /// </summary>
        [EnumMember(Value = "active")]
        Active,

        /// <summary>
        /// Enum Inactive for "inactive"
        /// </summary>
        [EnumMember(Value = "inactive")]
        Inactive,

        /// <summary>
        /// Enum Deleted for "deleted"
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted
    }
    /// <summary>
    /// Type of group.
    /// </summary>
    /// <value>Type of group.</value>
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
        /// Enum Official for "official"
        /// </summary>
        [EnumMember(Value = "official")]
        Official,

        /// <summary>
        /// Enum Social for "social"
        /// </summary>
        [EnumMember(Value = "social")]
        Social
    }
    /// <summary>
    /// Who can view this group
    /// </summary>
    /// <value>Who can view this group</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum VisibilityEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Public for "public"
        /// </summary>
        [EnumMember(Value = "public")]
        Public,

        /// <summary>
        /// Enum Owners for "owners"
        /// </summary>
        [EnumMember(Value = "owners")]
        Owners,

        /// <summary>
        /// Enum Members for "members"
        /// </summary>
        [EnumMember(Value = "members")]
        Members
    }
    /// <summary>
    /// Active, inactive, or deleted state.
    /// </summary>
    /// <value>Active, inactive, or deleted state.</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; private set; }
    /// <summary>
    /// Type of group.
    /// </summary>
    /// <value>Type of group.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Who can view this group
    /// </summary>
    /// <value>Who can view this group</value>
    [DataMember(Name = "visibility", EmitDefaultValue = false)]
    public VisibilityEnum? Visibility { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="GroupCreate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected GroupCreate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="GroupCreate" /> class.
    /// </summary>
    /// <param name="Name">The group name. (required).</param>
    /// <param name="Description">Description.</param>
    /// <param name="Type">Type of group. (required).</param>
    /// <param name="Images">Images.</param>
    /// <param name="Addresses">Addresses.</param>
    /// <param name="RulesVisible">Are membership rules visible to the person requesting to view the group (required).</param>
    /// <param name="Visibility">Who can view this group (required).</param>
    /// <param name="RolesEnabled">Allow roles to be assigned to this group.</param>
    /// <param name="IncludeOwners">Allow owners to be included as members of the group.</param>
    /// <param name="CallsEnabled">Allow calls to be placed to this group..</param>
    /// <param name="OwnerIds">Owners of the group.</param>
    public GroupCreate(string Name = null, string Description = null, TypeEnum? Type = null, List<Image> Images = null, List<GroupContact> Addresses = null, bool? RulesVisible = null, VisibilityEnum? Visibility = null, bool? RolesEnabled = null, bool? IncludeOwners = null, bool? CallsEnabled = null, List<string> OwnerIds = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.Type = Type;
        this.Images = Images;
        this.Addresses = Addresses;
        this.RulesVisible = RulesVisible;
        this.Visibility = Visibility;
        this.RolesEnabled = RolesEnabled;
        this.IncludeOwners = IncludeOwners;
        this.CallsEnabled = CallsEnabled;
        this.OwnerIds = OwnerIds;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The group name.
    /// </summary>
    /// <value>The group name.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Last modified date/time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified date/time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// Number of members.
    /// </summary>
    /// <value>Number of members.</value>
    [DataMember(Name = "memberCount", EmitDefaultValue = false)]
    public long? MemberCount { get; private set; }





    /// <summary>
    /// Current version for this resource.
    /// </summary>
    /// <value>Current version for this resource.</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public int? Version { get; private set; }





    /// <summary>
    /// Gets or Sets Images
    /// </summary>
    [DataMember(Name = "images", EmitDefaultValue = false)]
    public List<Image> Images { get; set; }



    /// <summary>
    /// Gets or Sets Addresses
    /// </summary>
    [DataMember(Name = "addresses", EmitDefaultValue = false)]
    public List<GroupContact> Addresses { get; set; }



    /// <summary>
    /// Are membership rules visible to the person requesting to view the group
    /// </summary>
    /// <value>Are membership rules visible to the person requesting to view the group</value>
    [DataMember(Name = "rulesVisible", EmitDefaultValue = false)]
    public bool? RulesVisible { get; set; }





    /// <summary>
    /// Allow roles to be assigned to this group
    /// </summary>
    /// <value>Allow roles to be assigned to this group</value>
    [DataMember(Name = "rolesEnabled", EmitDefaultValue = false)]
    public bool? RolesEnabled { get; set; }



    /// <summary>
    /// Allow owners to be included as members of the group
    /// </summary>
    /// <value>Allow owners to be included as members of the group</value>
    [DataMember(Name = "includeOwners", EmitDefaultValue = false)]
    public bool? IncludeOwners { get; set; }



    /// <summary>
    /// Allow calls to be placed to this group.
    /// </summary>
    /// <value>Allow calls to be placed to this group.</value>
    [DataMember(Name = "callsEnabled", EmitDefaultValue = false)]
    public bool? CallsEnabled { get; set; }



    /// <summary>
    /// Owners of the group
    /// </summary>
    /// <value>Owners of the group</value>
    [DataMember(Name = "ownerIds", EmitDefaultValue = false)]
    public List<string> OwnerIds { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GroupCreate {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  MemberCount: ").Append(MemberCount).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Images: ").Append(Images).Append("\n");
        sb.Append("  Addresses: ").Append(Addresses).Append("\n");
        sb.Append("  RulesVisible: ").Append(RulesVisible).Append("\n");
        sb.Append("  Visibility: ").Append(Visibility).Append("\n");
        sb.Append("  RolesEnabled: ").Append(RolesEnabled).Append("\n");
        sb.Append("  IncludeOwners: ").Append(IncludeOwners).Append("\n");
        sb.Append("  CallsEnabled: ").Append(CallsEnabled).Append("\n");
        sb.Append("  OwnerIds: ").Append(OwnerIds).Append("\n");
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
        return Equals(obj as GroupCreate);
    }

    /// <summary>
    /// Returns true if GroupCreate instances are equal
    /// </summary>
    /// <param name="other">Instance of GroupCreate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GroupCreate other)
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
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                MemberCount == other.MemberCount ||
                MemberCount != null &&
                MemberCount.Equals(other.MemberCount)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Images == other.Images ||
                Images != null &&
                Images.SequenceEqual(other.Images)
            ) &&
            (
                Addresses == other.Addresses ||
                Addresses != null &&
                Addresses.SequenceEqual(other.Addresses)
            ) &&
            (
                RulesVisible == other.RulesVisible ||
                RulesVisible != null &&
                RulesVisible.Equals(other.RulesVisible)
            ) &&
            (
                Visibility == other.Visibility ||
                Visibility != null &&
                Visibility.Equals(other.Visibility)
            ) &&
            (
                RolesEnabled == other.RolesEnabled ||
                RolesEnabled != null &&
                RolesEnabled.Equals(other.RolesEnabled)
            ) &&
            (
                IncludeOwners == other.IncludeOwners ||
                IncludeOwners != null &&
                IncludeOwners.Equals(other.IncludeOwners)
            ) &&
            (
                CallsEnabled == other.CallsEnabled ||
                CallsEnabled != null &&
                CallsEnabled.Equals(other.CallsEnabled)
            ) &&
            (
                OwnerIds == other.OwnerIds ||
                OwnerIds != null &&
                OwnerIds.SequenceEqual(other.OwnerIds)
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

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (MemberCount != null)
            {
                hash = hash * 59 + MemberCount.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Images != null)
            {
                hash = hash * 59 + Images.GetHashCode();
            }

            if (Addresses != null)
            {
                hash = hash * 59 + Addresses.GetHashCode();
            }

            if (RulesVisible != null)
            {
                hash = hash * 59 + RulesVisible.GetHashCode();
            }

            if (Visibility != null)
            {
                hash = hash * 59 + Visibility.GetHashCode();
            }

            if (RolesEnabled != null)
            {
                hash = hash * 59 + RolesEnabled.GetHashCode();
            }

            if (IncludeOwners != null)
            {
                hash = hash * 59 + IncludeOwners.GetHashCode();
            }

            if (CallsEnabled != null)
            {
                hash = hash * 59 + CallsEnabled.GetHashCode();
            }

            if (OwnerIds != null)
            {
                hash = hash * 59 + OwnerIds.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
