using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Greeting
/// </summary>
[DataContract]
public partial class Greeting : IEquatable<Greeting>
{
    /// <summary>
    /// Greeting type
    /// </summary>
    /// <value>Greeting type</value>
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
        /// Enum Station for "STATION"
        /// </summary>
        [EnumMember(Value = "STATION")]
        Station,

        /// <summary>
        /// Enum Voicemail for "VOICEMAIL"
        /// </summary>
        [EnumMember(Value = "VOICEMAIL")]
        Voicemail,

        /// <summary>
        /// Enum Name for "NAME"
        /// </summary>
        [EnumMember(Value = "NAME")]
        Name
    }
    /// <summary>
    /// Greeting owner type
    /// </summary>
    /// <value>Greeting owner type</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OwnerTypeEnum
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
        /// Enum Organization for "ORGANIZATION"
        /// </summary>
        [EnumMember(Value = "ORGANIZATION")]
        Organization,

        /// <summary>
        /// Enum Group for "GROUP"
        /// </summary>
        [EnumMember(Value = "GROUP")]
        Group
    }
    /// <summary>
    /// Greeting type
    /// </summary>
    /// <value>Greeting type</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Greeting owner type
    /// </summary>
    /// <value>Greeting owner type</value>
    [DataMember(Name = "ownerType", EmitDefaultValue = false)]
    public OwnerTypeEnum? OwnerType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Greeting" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Greeting() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Greeting" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Type">Greeting type (required).</param>
    /// <param name="OwnerType">Greeting owner type (required).</param>
    /// <param name="Owner">Greeting owner (required).</param>
    /// <param name="AudioFile">AudioFile.</param>
    /// <param name="AudioTTS">AudioTTS.</param>
    /// <param name="CreatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="CreatedBy">CreatedBy.</param>
    /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="ModifiedBy">ModifiedBy.</param>
    public Greeting(string Name = null, TypeEnum? Type = null, OwnerTypeEnum? OwnerType = null, DomainEntity Owner = null, GreetingAudioFile AudioFile = null, string AudioTTS = null, DateTime? CreatedDate = null, string CreatedBy = null, DateTime? ModifiedDate = null, string ModifiedBy = null)
    {
        this.Name = Name;
        this.Type = Type;
        this.OwnerType = OwnerType;
        this.Owner = Owner;
        this.AudioFile = AudioFile;
        this.AudioTTS = AudioTTS;
        this.CreatedDate = CreatedDate;
        this.CreatedBy = CreatedBy;
        this.ModifiedDate = ModifiedDate;
        this.ModifiedBy = ModifiedBy;

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
    /// Greeting owner
    /// </summary>
    /// <value>Greeting owner</value>
    [DataMember(Name = "owner", EmitDefaultValue = false)]
    public DomainEntity Owner { get; set; }



    /// <summary>
    /// Gets or Sets AudioFile
    /// </summary>
    [DataMember(Name = "audioFile", EmitDefaultValue = false)]
    public GreetingAudioFile AudioFile { get; set; }



    /// <summary>
    /// Gets or Sets AudioTTS
    /// </summary>
    [DataMember(Name = "audioTTS", EmitDefaultValue = false)]
    public string AudioTTS { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "createdDate", EmitDefaultValue = false)]
    public DateTime? CreatedDate { get; set; }



    /// <summary>
    /// Gets or Sets CreatedBy
    /// </summary>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public string CreatedBy { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "modifiedDate", EmitDefaultValue = false)]
    public DateTime? ModifiedDate { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public string ModifiedBy { get; set; }



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
        sb.Append("class Greeting {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  OwnerType: ").Append(OwnerType).Append("\n");
        sb.Append("  Owner: ").Append(Owner).Append("\n");
        sb.Append("  AudioFile: ").Append(AudioFile).Append("\n");
        sb.Append("  AudioTTS: ").Append(AudioTTS).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
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
        return Equals(obj as Greeting);
    }

    /// <summary>
    /// Returns true if Greeting instances are equal
    /// </summary>
    /// <param name="other">Instance of Greeting to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Greeting other)
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
                OwnerType == other.OwnerType ||
                OwnerType != null &&
                OwnerType.Equals(other.OwnerType)
            ) &&
            (
                Owner == other.Owner ||
                Owner != null &&
                Owner.Equals(other.Owner)
            ) &&
            (
                AudioFile == other.AudioFile ||
                AudioFile != null &&
                AudioFile.Equals(other.AudioFile)
            ) &&
            (
                AudioTTS == other.AudioTTS ||
                AudioTTS != null &&
                AudioTTS.Equals(other.AudioTTS)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
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

            if (OwnerType != null)
            {
                hash = hash * 59 + OwnerType.GetHashCode();
            }

            if (Owner != null)
            {
                hash = hash * 59 + Owner.GetHashCode();
            }

            if (AudioFile != null)
            {
                hash = hash * 59 + AudioFile.GetHashCode();
            }

            if (AudioTTS != null)
            {
                hash = hash * 59 + AudioTTS.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
