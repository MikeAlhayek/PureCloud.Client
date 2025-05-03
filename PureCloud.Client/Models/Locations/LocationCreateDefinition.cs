using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// LocationCreateDefinition
/// </summary>

public partial class LocationCreateDefinition : IEquatable<LocationCreateDefinition>
{
    /// <summary>
    /// Current activity status of the location.
    /// </summary>
    /// <value>Current activity status of the location.</value>
    
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
        /// Enum Deleted for "deleted"
        /// </summary>
        [EnumMember(Value = "deleted")]
        Deleted
    }
    /// <summary>
    /// Current activity status of the location.
    /// </summary>
    /// <value>Current activity status of the location.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="LocationCreateDefinition" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LocationCreateDefinition() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="LocationCreateDefinition" /> class.
    /// </summary>
    /// <param name="Name">The name of the Location. Required for creates, not required for updates (required).</param>
    /// <param name="Version">Current version of the location.</param>
    /// <param name="State">Current activity status of the location..</param>
    /// <param name="Path">A list of ancestor ids.</param>
    /// <param name="Notes">Notes for the location.</param>
    /// <param name="ContactUser">The user id of the location contact.</param>
    /// <param name="EmergencyNumber">Emergency number for the location.</param>
    /// <param name="Address">Address of the location.</param>
    public LocationCreateDefinition(string Name = null, int? Version = null, StateEnum? State = null, List<string> Path = null, string Notes = null, string ContactUser = null, LocationEmergencyNumber EmergencyNumber = null, LocationAddress Address = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.State = State;
        this.Path = Path;
        this.Notes = Notes;
        this.ContactUser = ContactUser;
        this.EmergencyNumber = EmergencyNumber;
        this.Address = Address;

    }



    /// <summary>
    /// The name of the Location. Required for creates, not required for updates
    /// </summary>
    /// <value>The name of the Location. Required for creates, not required for updates</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Current version of the location
    /// </summary>
    /// <value>Current version of the location</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }





    /// <summary>
    /// A list of ancestor ids
    /// </summary>
    /// <value>A list of ancestor ids</value>
    [JsonPropertyName("path")]
    public List<string> Path { get; set; }



    /// <summary>
    /// Notes for the location
    /// </summary>
    /// <value>Notes for the location</value>
    [JsonPropertyName("notes")]
    public string Notes { get; set; }



    /// <summary>
    /// The user id of the location contact
    /// </summary>
    /// <value>The user id of the location contact</value>
    [JsonPropertyName("contactUser")]
    public string ContactUser { get; set; }



    /// <summary>
    /// Emergency number for the location
    /// </summary>
    /// <value>Emergency number for the location</value>
    [JsonPropertyName("emergencyNumber")]
    public LocationEmergencyNumber EmergencyNumber { get; set; }



    /// <summary>
    /// Address of the location
    /// </summary>
    /// <value>Address of the location</value>
    [JsonPropertyName("address")]
    public LocationAddress Address { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class LocationCreateDefinition {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  Path: ").Append(Path).Append("\n");
        sb.Append("  Notes: ").Append(Notes).Append("\n");
        sb.Append("  ContactUser: ").Append(ContactUser).Append("\n");
        sb.Append("  EmergencyNumber: ").Append(EmergencyNumber).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
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
        return Equals(obj as LocationCreateDefinition);
    }

    /// <summary>
    /// Returns true if LocationCreateDefinition instances are equal
    /// </summary>
    /// <param name="other">Instance of LocationCreateDefinition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LocationCreateDefinition other)
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
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                Path == other.Path ||
                Path != null &&
                Path.SequenceEqual(other.Path)
            ) &&
            (
                Notes == other.Notes ||
                Notes != null &&
                Notes.Equals(other.Notes)
            ) &&
            (
                ContactUser == other.ContactUser ||
                ContactUser != null &&
                ContactUser.Equals(other.ContactUser)
            ) &&
            (
                EmergencyNumber == other.EmergencyNumber ||
                EmergencyNumber != null &&
                EmergencyNumber.Equals(other.EmergencyNumber)
            ) &&
            (
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
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

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (Path != null)
            {
                hash = hash * 59 + Path.GetHashCode();
            }

            if (Notes != null)
            {
                hash = hash * 59 + Notes.GetHashCode();
            }

            if (ContactUser != null)
            {
                hash = hash * 59 + ContactUser.GetHashCode();
            }

            if (EmergencyNumber != null)
            {
                hash = hash * 59 + EmergencyNumber.GetHashCode();
            }

            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            return hash;
        }
    }
}
