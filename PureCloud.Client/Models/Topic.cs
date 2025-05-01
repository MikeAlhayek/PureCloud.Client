using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Topic
/// </summary>
[DataContract]
public partial class Topic : IEquatable<Topic>
{
    /// <summary>
    /// Gets or Sets Strictness
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum StrictnessEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum _1 for "1"
        /// </summary>
        [EnumMember(Value = "1")]
        _1,

        /// <summary>
        /// Enum _55 for "55"
        /// </summary>
        [EnumMember(Value = "55")]
        _55,

        /// <summary>
        /// Enum _65 for "65"
        /// </summary>
        [EnumMember(Value = "65")]
        _65,

        /// <summary>
        /// Enum _72 for "72"
        /// </summary>
        [EnumMember(Value = "72")]
        _72,

        /// <summary>
        /// Enum _85 for "85"
        /// </summary>
        [EnumMember(Value = "85")]
        _85,

        /// <summary>
        /// Enum _90 for "90"
        /// </summary>
        [EnumMember(Value = "90")]
        _90
    }
    /// <summary>
    /// Gets or Sets Participants
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ParticipantsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum External for "External"
        /// </summary>
        [EnumMember(Value = "External")]
        External,

        /// <summary>
        /// Enum Internal for "Internal"
        /// </summary>
        [EnumMember(Value = "Internal")]
        Internal,

        /// <summary>
        /// Enum All for "All"
        /// </summary>
        [EnumMember(Value = "All")]
        All
    }
    /// <summary>
    /// Gets or Sets Strictness
    /// </summary>
    [DataMember(Name = "strictness", EmitDefaultValue = false)]
    public StrictnessEnum? Strictness { get; set; }
    /// <summary>
    /// Gets or Sets Participants
    /// </summary>
    [DataMember(Name = "participants", EmitDefaultValue = false)]
    public ParticipantsEnum? Participants { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Topic" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Description">Description.</param>
    /// <param name="Published">Published.</param>
    /// <param name="Strictness">Strictness.</param>
    /// <param name="Programs">Programs.</param>
    /// <param name="Tags">Tags.</param>
    /// <param name="Dialect">Dialect.</param>
    /// <param name="Participants">Participants.</param>
    /// <param name="Phrases">Phrases.</param>
    /// <param name="ModifiedBy">ModifiedBy.</param>
    /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="PublishedBy">PublishedBy.</param>
    /// <param name="DatePublished">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public Topic(string Name = null, string Description = null, bool? Published = null, StrictnessEnum? Strictness = null, List<BaseProgramEntity> Programs = null, List<string> Tags = null, string Dialect = null, ParticipantsEnum? Participants = null, List<Phrase> Phrases = null, AddressableEntityRef ModifiedBy = null, DateTime? DateModified = null, AddressableEntityRef PublishedBy = null, DateTime? DatePublished = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.Published = Published;
        this.Strictness = Strictness;
        this.Programs = Programs;
        this.Tags = Tags;
        this.Dialect = Dialect;
        this.Participants = Participants;
        this.Phrases = Phrases;
        this.ModifiedBy = ModifiedBy;
        this.DateModified = DateModified;
        this.PublishedBy = PublishedBy;
        this.DatePublished = DatePublished;

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
    /// Gets or Sets Description
    /// </summary>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets Published
    /// </summary>
    [DataMember(Name = "published", EmitDefaultValue = false)]
    public bool? Published { get; set; }





    /// <summary>
    /// Gets or Sets Programs
    /// </summary>
    [DataMember(Name = "programs", EmitDefaultValue = false)]
    public List<BaseProgramEntity> Programs { get; set; }



    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [DataMember(Name = "tags", EmitDefaultValue = false)]
    public List<string> Tags { get; set; }



    /// <summary>
    /// Gets or Sets Dialect
    /// </summary>
    [DataMember(Name = "dialect", EmitDefaultValue = false)]
    public string Dialect { get; set; }





    /// <summary>
    /// Gets or Sets Phrases
    /// </summary>
    [DataMember(Name = "phrases", EmitDefaultValue = false)]
    public List<Phrase> Phrases { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public AddressableEntityRef ModifiedBy { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Gets or Sets PublishedBy
    /// </summary>
    [DataMember(Name = "publishedBy", EmitDefaultValue = false)]
    public AddressableEntityRef PublishedBy { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "datePublished", EmitDefaultValue = false)]
    public DateTime? DatePublished { get; set; }



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
        sb.Append("class Topic {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Published: ").Append(Published).Append("\n");
        sb.Append("  Strictness: ").Append(Strictness).Append("\n");
        sb.Append("  Programs: ").Append(Programs).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
        sb.Append("  Dialect: ").Append(Dialect).Append("\n");
        sb.Append("  Participants: ").Append(Participants).Append("\n");
        sb.Append("  Phrases: ").Append(Phrases).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  PublishedBy: ").Append(PublishedBy).Append("\n");
        sb.Append("  DatePublished: ").Append(DatePublished).Append("\n");
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
        return Equals(obj as Topic);
    }

    /// <summary>
    /// Returns true if Topic instances are equal
    /// </summary>
    /// <param name="other">Instance of Topic to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Topic other)
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
                Published == other.Published ||
                Published != null &&
                Published.Equals(other.Published)
            ) &&
            (
                Strictness == other.Strictness ||
                Strictness != null &&
                Strictness.Equals(other.Strictness)
            ) &&
            (
                Programs == other.Programs ||
                Programs != null &&
                Programs.SequenceEqual(other.Programs)
            ) &&
            (
                Tags == other.Tags ||
                Tags != null &&
                Tags.SequenceEqual(other.Tags)
            ) &&
            (
                Dialect == other.Dialect ||
                Dialect != null &&
                Dialect.Equals(other.Dialect)
            ) &&
            (
                Participants == other.Participants ||
                Participants != null &&
                Participants.Equals(other.Participants)
            ) &&
            (
                Phrases == other.Phrases ||
                Phrases != null &&
                Phrases.SequenceEqual(other.Phrases)
            ) &&
            (
                ModifiedBy == other.ModifiedBy ||
                ModifiedBy != null &&
                ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                PublishedBy == other.PublishedBy ||
                PublishedBy != null &&
                PublishedBy.Equals(other.PublishedBy)
            ) &&
            (
                DatePublished == other.DatePublished ||
                DatePublished != null &&
                DatePublished.Equals(other.DatePublished)
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

            if (Published != null)
            {
                hash = hash * 59 + Published.GetHashCode();
            }

            if (Strictness != null)
            {
                hash = hash * 59 + Strictness.GetHashCode();
            }

            if (Programs != null)
            {
                hash = hash * 59 + Programs.GetHashCode();
            }

            if (Tags != null)
            {
                hash = hash * 59 + Tags.GetHashCode();
            }

            if (Dialect != null)
            {
                hash = hash * 59 + Dialect.GetHashCode();
            }

            if (Participants != null)
            {
                hash = hash * 59 + Participants.GetHashCode();
            }

            if (Phrases != null)
            {
                hash = hash * 59 + Phrases.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (PublishedBy != null)
            {
                hash = hash * 59 + PublishedBy.GetHashCode();
            }

            if (DatePublished != null)
            {
                hash = hash * 59 + DatePublished.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
