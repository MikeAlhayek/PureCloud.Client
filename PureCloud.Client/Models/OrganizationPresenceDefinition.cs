using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OrganizationPresenceDefinition
/// </summary>
[DataContract]
public partial class OrganizationPresenceDefinition : IEquatable<OrganizationPresenceDefinition>
{
    /// <summary>
    /// The type of definition
    /// </summary>
    /// <value>The type of definition</value>
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
        /// Enum System for "System"
        /// </summary>
        [EnumMember(Value = "System")]
        System,

        /// <summary>
        /// Enum User for "User"
        /// </summary>
        [EnumMember(Value = "User")]
        User
    }
    /// <summary>
    /// Gets or Sets SystemPresence
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SystemPresenceEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Available for "Available"
        /// </summary>
        [EnumMember(Value = "Available")]
        Available,

        /// <summary>
        /// Enum Away for "Away"
        /// </summary>
        [EnumMember(Value = "Away")]
        Away,

        /// <summary>
        /// Enum Busy for "Busy"
        /// </summary>
        [EnumMember(Value = "Busy")]
        Busy,

        /// <summary>
        /// Enum Offline for "Offline"
        /// </summary>
        [EnumMember(Value = "Offline")]
        Offline,

        /// <summary>
        /// Enum Idle for "Idle"
        /// </summary>
        [EnumMember(Value = "Idle")]
        Idle,

        /// <summary>
        /// Enum Onqueue for "OnQueue"
        /// </summary>
        [EnumMember(Value = "OnQueue")]
        Onqueue,

        /// <summary>
        /// Enum Meal for "Meal"
        /// </summary>
        [EnumMember(Value = "Meal")]
        Meal,

        /// <summary>
        /// Enum Training for "Training"
        /// </summary>
        [EnumMember(Value = "Training")]
        Training,

        /// <summary>
        /// Enum Meeting for "Meeting"
        /// </summary>
        [EnumMember(Value = "Meeting")]
        Meeting,

        /// <summary>
        /// Enum Break for "Break"
        /// </summary>
        [EnumMember(Value = "Break")]
        Break
    }
    /// <summary>
    /// The type of definition
    /// </summary>
    /// <value>The type of definition</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Gets or Sets SystemPresence
    /// </summary>
    [DataMember(Name = "systemPresence", EmitDefaultValue = false)]
    public SystemPresenceEnum? SystemPresence { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="OrganizationPresenceDefinition" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OrganizationPresenceDefinition() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OrganizationPresenceDefinition" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Type">The type of definition.</param>
    /// <param name="LanguageLabels">The label used for the definition in each specified language (required).</param>
    /// <param name="SystemPresence">SystemPresence.</param>
    /// <param name="DivisionId">DivisionId.</param>
    /// <param name="Deactivated">Deactivated.</param>
    public OrganizationPresenceDefinition(string Name = null, TypeEnum? Type = null, Dictionary<string, string> LanguageLabels = null, SystemPresenceEnum? SystemPresence = null, string DivisionId = null, bool? Deactivated = null)
    {
        this.Name = Name;
        this.Type = Type;
        this.LanguageLabels = LanguageLabels;
        this.SystemPresence = SystemPresence;
        this.DivisionId = DivisionId;
        this.Deactivated = Deactivated;

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
    /// The label used for the definition in each specified language
    /// </summary>
    /// <value>The label used for the definition in each specified language</value>
    [DataMember(Name = "languageLabels", EmitDefaultValue = false)]
    public Dictionary<string, string> LanguageLabels { get; set; }





    /// <summary>
    /// Gets or Sets DivisionId
    /// </summary>
    [DataMember(Name = "divisionId", EmitDefaultValue = false)]
    public string DivisionId { get; set; }



    /// <summary>
    /// Gets or Sets Deactivated
    /// </summary>
    [DataMember(Name = "deactivated", EmitDefaultValue = false)]
    public bool? Deactivated { get; set; }



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
        sb.Append("class OrganizationPresenceDefinition {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  LanguageLabels: ").Append(LanguageLabels).Append("\n");
        sb.Append("  SystemPresence: ").Append(SystemPresence).Append("\n");
        sb.Append("  DivisionId: ").Append(DivisionId).Append("\n");
        sb.Append("  Deactivated: ").Append(Deactivated).Append("\n");
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
        return Equals(obj as OrganizationPresenceDefinition);
    }

    /// <summary>
    /// Returns true if OrganizationPresenceDefinition instances are equal
    /// </summary>
    /// <param name="other">Instance of OrganizationPresenceDefinition to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OrganizationPresenceDefinition other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                LanguageLabels == other.LanguageLabels ||
                LanguageLabels != null &&
                LanguageLabels.SequenceEqual(other.LanguageLabels)
            ) &&
            (
                SystemPresence == other.SystemPresence ||
                SystemPresence != null &&
                SystemPresence.Equals(other.SystemPresence)
            ) &&
            (
                DivisionId == other.DivisionId ||
                DivisionId != null &&
                DivisionId.Equals(other.DivisionId)
            ) &&
            (
                Deactivated == other.Deactivated ||
                Deactivated != null &&
                Deactivated.Equals(other.Deactivated)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (LanguageLabels != null)
            {
                hash = hash * 59 + LanguageLabels.GetHashCode();
            }

            if (SystemPresence != null)
            {
                hash = hash * 59 + SystemPresence.GetHashCode();
            }

            if (DivisionId != null)
            {
                hash = hash * 59 + DivisionId.GetHashCode();
            }

            if (Deactivated != null)
            {
                hash = hash * 59 + Deactivated.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
