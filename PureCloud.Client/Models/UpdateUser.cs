using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// UpdateUser
/// </summary>
[DataContract]
public partial class UpdateUser : IEquatable<UpdateUser>
{
    /// <summary>
    /// The state of the user. This property can be used to restore a deleted user or transition between active and inactive. If specified, it is the only modifiable field.
    /// </summary>
    /// <value>The state of the user. This property can be used to restore a deleted user or transition between active and inactive. If specified, it is the only modifiable field.</value>
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
    /// The state of the user. This property can be used to restore a deleted user or transition between active and inactive. If specified, it is the only modifiable field.
    /// </summary>
    /// <value>The state of the user. This property can be used to restore a deleted user or transition between active and inactive. If specified, it is the only modifiable field.</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateUser" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected UpdateUser() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="UpdateUser" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Chat">Chat.</param>
    /// <param name="Department">Department.</param>
    /// <param name="Email">Email.</param>
    /// <param name="Addresses">Email address, phone number, and/or extension for this user. One entry is allowed per media type.</param>
    /// <param name="Title">Title.</param>
    /// <param name="Username">Username.</param>
    /// <param name="PreferredName">Preferred full name of agent.</param>
    /// <param name="Manager">Manager.</param>
    /// <param name="Images">Images.</param>
    /// <param name="Version">This value should be the current version of the user. The current version can be obtained with a GET on the user before doing a PATCH. (required).</param>
    /// <param name="ProfileSkills">Profile skills possessed by the user.</param>
    /// <param name="Locations">The user placement at each site location..</param>
    /// <param name="Groups">The groups the user is a member of.</param>
    /// <param name="State">The state of the user. This property can be used to restore a deleted user or transition between active and inactive. If specified, it is the only modifiable field..</param>
    /// <param name="AcdAutoAnswer">The value that denotes if acdAutoAnswer is set on the user.</param>
    /// <param name="Certifications">Certifications.</param>
    /// <param name="Biography">Biography.</param>
    /// <param name="EmployerInfo">EmployerInfo.</param>
    public UpdateUser(string Name = null, Chat Chat = null, string Department = null, string Email = null, List<Contact> Addresses = null, string Title = null, string Username = null, string PreferredName = null, string Manager = null, List<Image> Images = null, int? Version = null, List<string> ProfileSkills = null, List<Location> Locations = null, List<Group> Groups = null, StateEnum? State = null, bool? AcdAutoAnswer = null, List<string> Certifications = null, Biography Biography = null, EmployerInfo EmployerInfo = null)
    {
        this.Name = Name;
        this.Chat = Chat;
        this.Department = Department;
        this.Email = Email;
        this.Addresses = Addresses;
        this.Title = Title;
        this.Username = Username;
        this.PreferredName = PreferredName;
        this.Manager = Manager;
        this.Images = Images;
        this.Version = Version;
        this.ProfileSkills = ProfileSkills;
        this.Locations = Locations;
        this.Groups = Groups;
        this.State = State;
        this.AcdAutoAnswer = AcdAutoAnswer;
        this.Certifications = Certifications;
        this.Biography = Biography;
        this.EmployerInfo = EmployerInfo;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Chat
    /// </summary>
    [DataMember(Name = "chat", EmitDefaultValue = false)]
    public Chat Chat { get; set; }



    /// <summary>
    /// Gets or Sets Department
    /// </summary>
    [DataMember(Name = "department", EmitDefaultValue = false)]
    public string Department { get; set; }



    /// <summary>
    /// Gets or Sets Email
    /// </summary>
    [DataMember(Name = "email", EmitDefaultValue = false)]
    public string Email { get; set; }



    /// <summary>
    /// The address(s) used for primary contact. Updates to the corresponding address in the addresses list will be reflected here.
    /// </summary>
    /// <value>The address(s) used for primary contact. Updates to the corresponding address in the addresses list will be reflected here.</value>
    [DataMember(Name = "primaryContactInfo", EmitDefaultValue = false)]
    public List<Contact> PrimaryContactInfo { get; private set; }



    /// <summary>
    /// Email address, phone number, and/or extension for this user. One entry is allowed per media type
    /// </summary>
    /// <value>Email address, phone number, and/or extension for this user. One entry is allowed per media type</value>
    [DataMember(Name = "addresses", EmitDefaultValue = false)]
    public List<Contact> Addresses { get; set; }



    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }



    /// <summary>
    /// Gets or Sets Username
    /// </summary>
    [DataMember(Name = "username", EmitDefaultValue = false)]
    public string Username { get; set; }



    /// <summary>
    /// Preferred full name of agent
    /// </summary>
    /// <value>Preferred full name of agent</value>
    [DataMember(Name = "preferredName", EmitDefaultValue = false)]
    public string PreferredName { get; set; }



    /// <summary>
    /// Gets or Sets Manager
    /// </summary>
    [DataMember(Name = "manager", EmitDefaultValue = false)]
    public string Manager { get; set; }



    /// <summary>
    /// Gets or Sets Images
    /// </summary>
    [DataMember(Name = "images", EmitDefaultValue = false)]
    public List<Image> Images { get; set; }



    /// <summary>
    /// This value should be the current version of the user. The current version can be obtained with a GET on the user before doing a PATCH.
    /// </summary>
    /// <value>This value should be the current version of the user. The current version can be obtained with a GET on the user before doing a PATCH.</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public int? Version { get; set; }



    /// <summary>
    /// Profile skills possessed by the user
    /// </summary>
    /// <value>Profile skills possessed by the user</value>
    [DataMember(Name = "profileSkills", EmitDefaultValue = false)]
    public List<string> ProfileSkills { get; set; }



    /// <summary>
    /// The user placement at each site location.
    /// </summary>
    /// <value>The user placement at each site location.</value>
    [DataMember(Name = "locations", EmitDefaultValue = false)]
    public List<Location> Locations { get; set; }



    /// <summary>
    /// The groups the user is a member of
    /// </summary>
    /// <value>The groups the user is a member of</value>
    [DataMember(Name = "groups", EmitDefaultValue = false)]
    public List<Group> Groups { get; set; }





    /// <summary>
    /// The value that denotes if acdAutoAnswer is set on the user
    /// </summary>
    /// <value>The value that denotes if acdAutoAnswer is set on the user</value>
    [DataMember(Name = "acdAutoAnswer", EmitDefaultValue = false)]
    public bool? AcdAutoAnswer { get; set; }



    /// <summary>
    /// Gets or Sets Certifications
    /// </summary>
    [DataMember(Name = "certifications", EmitDefaultValue = false)]
    public List<string> Certifications { get; set; }



    /// <summary>
    /// Gets or Sets Biography
    /// </summary>
    [DataMember(Name = "biography", EmitDefaultValue = false)]
    public Biography Biography { get; set; }



    /// <summary>
    /// Gets or Sets EmployerInfo
    /// </summary>
    [DataMember(Name = "employerInfo", EmitDefaultValue = false)]
    public EmployerInfo EmployerInfo { get; set; }



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
        sb.Append("class UpdateUser {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Chat: ").Append(Chat).Append("\n");
        sb.Append("  Department: ").Append(Department).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  PrimaryContactInfo: ").Append(PrimaryContactInfo).Append("\n");
        sb.Append("  Addresses: ").Append(Addresses).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Username: ").Append(Username).Append("\n");
        sb.Append("  PreferredName: ").Append(PreferredName).Append("\n");
        sb.Append("  Manager: ").Append(Manager).Append("\n");
        sb.Append("  Images: ").Append(Images).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  ProfileSkills: ").Append(ProfileSkills).Append("\n");
        sb.Append("  Locations: ").Append(Locations).Append("\n");
        sb.Append("  Groups: ").Append(Groups).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  AcdAutoAnswer: ").Append(AcdAutoAnswer).Append("\n");
        sb.Append("  Certifications: ").Append(Certifications).Append("\n");
        sb.Append("  Biography: ").Append(Biography).Append("\n");
        sb.Append("  EmployerInfo: ").Append(EmployerInfo).Append("\n");
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
        return Equals(obj as UpdateUser);
    }

    /// <summary>
    /// Returns true if UpdateUser instances are equal
    /// </summary>
    /// <param name="other">Instance of UpdateUser to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UpdateUser other)
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
                Chat == other.Chat ||
                Chat != null &&
                Chat.Equals(other.Chat)
            ) &&
            (
                Department == other.Department ||
                Department != null &&
                Department.Equals(other.Department)
            ) &&
            (
                Email == other.Email ||
                Email != null &&
                Email.Equals(other.Email)
            ) &&
            (
                PrimaryContactInfo == other.PrimaryContactInfo ||
                PrimaryContactInfo != null &&
                PrimaryContactInfo.SequenceEqual(other.PrimaryContactInfo)
            ) &&
            (
                Addresses == other.Addresses ||
                Addresses != null &&
                Addresses.SequenceEqual(other.Addresses)
            ) &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Username == other.Username ||
                Username != null &&
                Username.Equals(other.Username)
            ) &&
            (
                PreferredName == other.PreferredName ||
                PreferredName != null &&
                PreferredName.Equals(other.PreferredName)
            ) &&
            (
                Manager == other.Manager ||
                Manager != null &&
                Manager.Equals(other.Manager)
            ) &&
            (
                Images == other.Images ||
                Images != null &&
                Images.SequenceEqual(other.Images)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                ProfileSkills == other.ProfileSkills ||
                ProfileSkills != null &&
                ProfileSkills.SequenceEqual(other.ProfileSkills)
            ) &&
            (
                Locations == other.Locations ||
                Locations != null &&
                Locations.SequenceEqual(other.Locations)
            ) &&
            (
                Groups == other.Groups ||
                Groups != null &&
                Groups.SequenceEqual(other.Groups)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                AcdAutoAnswer == other.AcdAutoAnswer ||
                AcdAutoAnswer != null &&
                AcdAutoAnswer.Equals(other.AcdAutoAnswer)
            ) &&
            (
                Certifications == other.Certifications ||
                Certifications != null &&
                Certifications.SequenceEqual(other.Certifications)
            ) &&
            (
                Biography == other.Biography ||
                Biography != null &&
                Biography.Equals(other.Biography)
            ) &&
            (
                EmployerInfo == other.EmployerInfo ||
                EmployerInfo != null &&
                EmployerInfo.Equals(other.EmployerInfo)
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

            if (Chat != null)
            {
                hash = hash * 59 + Chat.GetHashCode();
            }

            if (Department != null)
            {
                hash = hash * 59 + Department.GetHashCode();
            }

            if (Email != null)
            {
                hash = hash * 59 + Email.GetHashCode();
            }

            if (PrimaryContactInfo != null)
            {
                hash = hash * 59 + PrimaryContactInfo.GetHashCode();
            }

            if (Addresses != null)
            {
                hash = hash * 59 + Addresses.GetHashCode();
            }

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Username != null)
            {
                hash = hash * 59 + Username.GetHashCode();
            }

            if (PreferredName != null)
            {
                hash = hash * 59 + PreferredName.GetHashCode();
            }

            if (Manager != null)
            {
                hash = hash * 59 + Manager.GetHashCode();
            }

            if (Images != null)
            {
                hash = hash * 59 + Images.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (ProfileSkills != null)
            {
                hash = hash * 59 + ProfileSkills.GetHashCode();
            }

            if (Locations != null)
            {
                hash = hash * 59 + Locations.GetHashCode();
            }

            if (Groups != null)
            {
                hash = hash * 59 + Groups.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (AcdAutoAnswer != null)
            {
                hash = hash * 59 + AcdAutoAnswer.GetHashCode();
            }

            if (Certifications != null)
            {
                hash = hash * 59 + Certifications.GetHashCode();
            }

            if (Biography != null)
            {
                hash = hash * 59 + Biography.GetHashCode();
            }

            if (EmployerInfo != null)
            {
                hash = hash * 59 + EmployerInfo.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
