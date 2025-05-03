using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ListedTopic
/// </summary>

public partial class ListedTopic : IEquatable<ListedTopic>
{
    /// <summary>
    /// Gets or Sets Strictness
    /// </summary>
    
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
    [JsonPropertyName("strictness")]
    public StrictnessEnum? Strictness { get; set; }
    /// <summary>
    /// Gets or Sets Participants
    /// </summary>
    [JsonPropertyName("participants")]
    public ParticipantsEnum? Participants { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ListedTopic" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Description">Description.</param>
    /// <param name="Published">Published.</param>
    /// <param name="Strictness">Strictness.</param>
    /// <param name="ProgramsCount">ProgramsCount.</param>
    /// <param name="Tags">Tags.</param>
    /// <param name="Dialect">Dialect.</param>
    /// <param name="Participants">Participants.</param>
    /// <param name="PhrasesCount">PhrasesCount.</param>
    /// <param name="ModifiedBy">ModifiedBy.</param>
    /// <param name="DateModified">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public ListedTopic(string Name = null, string Description = null, bool? Published = null, StrictnessEnum? Strictness = null, int? ProgramsCount = null, List<string> Tags = null, string Dialect = null, ParticipantsEnum? Participants = null, int? PhrasesCount = null, AddressableEntityRef ModifiedBy = null, DateTime? DateModified = null)
    {
        this.Name = Name;
        this.Description = Description;
        this.Published = Published;
        this.Strictness = Strictness;
        this.ProgramsCount = ProgramsCount;
        this.Tags = Tags;
        this.Dialect = Dialect;
        this.Participants = Participants;
        this.PhrasesCount = PhrasesCount;
        this.ModifiedBy = ModifiedBy;
        this.DateModified = DateModified;

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
    /// Gets or Sets Description
    /// </summary>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Gets or Sets Published
    /// </summary>
    [JsonPropertyName("published")]
    public bool? Published { get; set; }





    /// <summary>
    /// Gets or Sets ProgramsCount
    /// </summary>
    [JsonPropertyName("programsCount")]
    public int? ProgramsCount { get; set; }



    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    [JsonPropertyName("tags")]
    public List<string> Tags { get; set; }



    /// <summary>
    /// Gets or Sets Dialect
    /// </summary>
    [JsonPropertyName("dialect")]
    public string Dialect { get; set; }





    /// <summary>
    /// Gets or Sets PhrasesCount
    /// </summary>
    [JsonPropertyName("phrasesCount")]
    public int? PhrasesCount { get; set; }



    /// <summary>
    /// Gets or Sets ModifiedBy
    /// </summary>
    [JsonPropertyName("modifiedBy")]
    public AddressableEntityRef ModifiedBy { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



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
        sb.Append("class ListedTopic {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Published: ").Append(Published).Append("\n");
        sb.Append("  Strictness: ").Append(Strictness).Append("\n");
        sb.Append("  ProgramsCount: ").Append(ProgramsCount).Append("\n");
        sb.Append("  Tags: ").Append(Tags).Append("\n");
        sb.Append("  Dialect: ").Append(Dialect).Append("\n");
        sb.Append("  Participants: ").Append(Participants).Append("\n");
        sb.Append("  PhrasesCount: ").Append(PhrasesCount).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
        return Equals(obj as ListedTopic);
    }

    /// <summary>
    /// Returns true if ListedTopic instances are equal
    /// </summary>
    /// <param name="other">Instance of ListedTopic to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ListedTopic other)
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
                ProgramsCount == other.ProgramsCount ||
                ProgramsCount != null &&
                ProgramsCount.Equals(other.ProgramsCount)
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
                PhrasesCount == other.PhrasesCount ||
                PhrasesCount != null &&
                PhrasesCount.Equals(other.PhrasesCount)
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

            if (ProgramsCount != null)
            {
                hash = hash * 59 + ProgramsCount.GetHashCode();
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

            if (PhrasesCount != null)
            {
                hash = hash * 59 + PhrasesCount.GetHashCode();
            }

            if (ModifiedBy != null)
            {
                hash = hash * 59 + ModifiedBy.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
