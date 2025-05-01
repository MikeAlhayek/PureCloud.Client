using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// EmergencyLocation
/// </summary>
[DataContract]
public partial class EmergencyLocation : IEquatable<EmergencyLocation>
{
    /// <summary>
    /// source
    /// </summary>
    /// <value>source</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SourceEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Admin for "Admin"
        /// </summary>
        [EnumMember(Value = "Admin")]
        Admin,

        /// <summary>
        /// Enum User for "User"
        /// </summary>
        [EnumMember(Value = "User")]
        User
    }
    /// <summary>
    /// source
    /// </summary>
    /// <value>source</value>
    [DataMember(Name = "source", EmitDefaultValue = false)]
    public SourceEnum? Source { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="EmergencyLocation" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EmergencyLocation() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EmergencyLocation" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Address">Emergency address (required).</param>
    /// <param name="Did">Phone number in E164 format (required).</param>
    /// <param name="Source">source (required).</param>
    public EmergencyLocation(string Name = null, LocationAddress Address = null, string Did = null, SourceEnum? Source = null)
    {
        this.Name = Name;
        this.Address = Address;
        this.Did = Did;
        this.Source = Source;

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
    /// Emergency address
    /// </summary>
    /// <value>Emergency address</value>
    [DataMember(Name = "address", EmitDefaultValue = false)]
    public LocationAddress Address { get; set; }



    /// <summary>
    /// Phone number in E164 format
    /// </summary>
    /// <value>Phone number in E164 format</value>
    [DataMember(Name = "did", EmitDefaultValue = false)]
    public string Did { get; set; }





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
        sb.Append("class EmergencyLocation {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
        sb.Append("  Did: ").Append(Did).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
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
        return Equals(obj as EmergencyLocation);
    }

    /// <summary>
    /// Returns true if EmergencyLocation instances are equal
    /// </summary>
    /// <param name="other">Instance of EmergencyLocation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EmergencyLocation other)
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
                Address == other.Address ||
                Address != null &&
                Address.Equals(other.Address)
            ) &&
            (
                Did == other.Did ||
                Did != null &&
                Did.Equals(other.Did)
            ) &&
            (
                Source == other.Source ||
                Source != null &&
                Source.Equals(other.Source)
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

            if (Address != null)
            {
                hash = hash * 59 + Address.GetHashCode();
            }

            if (Did != null)
            {
                hash = hash * 59 + Did.GetHashCode();
            }

            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
