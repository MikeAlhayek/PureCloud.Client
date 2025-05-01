using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CreateUser
/// </summary>
[DataContract]
public partial class CreateUser : IEquatable<CreateUser>
{
    /// <summary>
    /// Optional initialized state of the user. If not specified, state will be Active if invites are sent, otherwise Inactive.
    /// </summary>
    /// <value>Optional initialized state of the user. If not specified, state will be Active if invites are sent, otherwise Inactive.</value>
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
    /// Optional initialized state of the user. If not specified, state will be Active if invites are sent, otherwise Inactive.
    /// </summary>
    /// <value>Optional initialized state of the user. If not specified, state will be Active if invites are sent, otherwise Inactive.</value>
    [DataMember(Name = "state", EmitDefaultValue = false)]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CreateUser" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CreateUser() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CreateUser" /> class.
    /// </summary>
    /// <param name="Name">User&#39;s full name (required).</param>
    /// <param name="Department">Department.</param>
    /// <param name="Email">User&#39;s email and username (required).</param>
    /// <param name="Addresses">Email addresses and phone numbers for this user.</param>
    /// <param name="Title">Title.</param>
    /// <param name="Password">User&#39;s password.</param>
    /// <param name="DivisionId">The division to which this user will belong (required).</param>
    /// <param name="State">Optional initialized state of the user. If not specified, state will be Active if invites are sent, otherwise Inactive..</param>
    public CreateUser(string Name = null, string Department = null, string Email = null, List<Contact> Addresses = null, string Title = null, string Password = null, string DivisionId = null, StateEnum? State = null)
    {
        this.Name = Name;
        this.Department = Department;
        this.Email = Email;
        this.Addresses = Addresses;
        this.Title = Title;
        this.Password = Password;
        this.DivisionId = DivisionId;
        this.State = State;

    }



    /// <summary>
    /// User&#39;s full name
    /// </summary>
    /// <value>User&#39;s full name</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Department
    /// </summary>
    [DataMember(Name = "department", EmitDefaultValue = false)]
    public string Department { get; set; }



    /// <summary>
    /// User&#39;s email and username
    /// </summary>
    /// <value>User&#39;s email and username</value>
    [DataMember(Name = "email", EmitDefaultValue = false)]
    public string Email { get; set; }



    /// <summary>
    /// Email addresses and phone numbers for this user
    /// </summary>
    /// <value>Email addresses and phone numbers for this user</value>
    [DataMember(Name = "addresses", EmitDefaultValue = false)]
    public List<Contact> Addresses { get; set; }



    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [DataMember(Name = "title", EmitDefaultValue = false)]
    public string Title { get; set; }



    /// <summary>
    /// User&#39;s password
    /// </summary>
    /// <value>User&#39;s password</value>
    [DataMember(Name = "password", EmitDefaultValue = false)]
    public string Password { get; set; }



    /// <summary>
    /// The division to which this user will belong
    /// </summary>
    /// <value>The division to which this user will belong</value>
    [DataMember(Name = "divisionId", EmitDefaultValue = false)]
    public string DivisionId { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CreateUser {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Department: ").Append(Department).Append("\n");
        sb.Append("  Email: ").Append(Email).Append("\n");
        sb.Append("  Addresses: ").Append(Addresses).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Password: ").Append(Password).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
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
        return Equals(obj as CreateUser);
    }

    /// <summary>
    /// Returns true if CreateUser instances are equal
    /// </summary>
    /// <param name="other">Instance of CreateUser to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CreateUser other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
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
                Password == other.Password ||
                Password != null &&
                Password.Equals(other.Password)
            ) &&
            (
                DivisionId == other.DivisionId ||
                DivisionId != null &&
                DivisionId.Equals(other.DivisionId)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Department != null)
            {
                hash = hash * 59 + Department.GetHashCode();
            }

            if (Email != null)
            {
                hash = hash * 59 + Email.GetHashCode();
            }

            if (Addresses != null)
            {
                hash = hash * 59 + Addresses.GetHashCode();
            }

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Password != null)
            {
                hash = hash * 59 + Password.GetHashCode();
            }

            if (DivisionId != null)
            {
                hash = hash * 59 + DivisionId.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            return hash;
        }
    }
}
