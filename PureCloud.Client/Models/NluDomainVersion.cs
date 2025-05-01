using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluDomainVersion
/// </summary>
[DataContract]
public partial class NluDomainVersion : IEquatable<NluDomainVersion>
{
    /// <summary>
    /// The training status of the NLU domain version.
    /// </summary>
    /// <value>The training status of the NLU domain version.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TrainingStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Untrained for "Untrained"
        /// </summary>
        [EnumMember(Value = "Untrained")]
        Untrained,

        /// <summary>
        /// Enum Training for "Training"
        /// </summary>
        [EnumMember(Value = "Training")]
        Training,

        /// <summary>
        /// Enum Trained for "Trained"
        /// </summary>
        [EnumMember(Value = "Trained")]
        Trained,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Unknown for "Unknown"
        /// </summary>
        [EnumMember(Value = "Unknown")]
        Unknown
    }
    /// <summary>
    /// The evaluation status of the NLU domain version.
    /// </summary>
    /// <value>The evaluation status of the NLU domain version.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EvaluationStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Unevaluated for "Unevaluated"
        /// </summary>
        [EnumMember(Value = "Unevaluated")]
        Unevaluated,

        /// <summary>
        /// Enum Evaluating for "Evaluating"
        /// </summary>
        [EnumMember(Value = "Evaluating")]
        Evaluating,

        /// <summary>
        /// Enum Evaluated for "Evaluated"
        /// </summary>
        [EnumMember(Value = "Evaluated")]
        Evaluated,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error
    }
    /// <summary>
    /// The training status of the NLU domain version.
    /// </summary>
    /// <value>The training status of the NLU domain version.</value>
    [DataMember(Name = "trainingStatus", EmitDefaultValue = false)]
    public TrainingStatusEnum? TrainingStatus { get; private set; }
    /// <summary>
    /// The evaluation status of the NLU domain version.
    /// </summary>
    /// <value>The evaluation status of the NLU domain version.</value>
    [DataMember(Name = "evaluationStatus", EmitDefaultValue = false)]
    public EvaluationStatusEnum? EvaluationStatus { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="NluDomainVersion" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NluDomainVersion() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NluDomainVersion" /> class.
    /// </summary>
    /// <param name="Description">The description of the NLU domain version..</param>
    /// <param name="Language">The language that the NLU domain version supports. (required).</param>
    /// <param name="Intents">The intents defined for this NLU domain version..</param>
    /// <param name="EntityTypes">The entity types defined for this NLU domain version..</param>
    /// <param name="Entities">The entities defined for this NLU domain version.This field is mutually exclusive with entityTypeBindings.</param>
    public NluDomainVersion(string Description = null, string Language = null, List<IntentDefinition> Intents = null, List<NamedEntityTypeDefinition> EntityTypes = null, List<NamedEntityDefinition> Entities = null)
    {
        this.Description = Description;
        this.Language = Language;
        this.Intents = Intents;
        this.EntityTypes = EntityTypes;
        this.Entities = Entities;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The NLU domain of the version.
    /// </summary>
    /// <value>The NLU domain of the version.</value>
    [DataMember(Name = "domain", EmitDefaultValue = false)]
    public NluDomain Domain { get; private set; }



    /// <summary>
    /// The description of the NLU domain version.
    /// </summary>
    /// <value>The description of the NLU domain version.</value>
    [DataMember(Name = "description", EmitDefaultValue = false)]
    public string Description { get; set; }



    /// <summary>
    /// The language that the NLU domain version supports.
    /// </summary>
    /// <value>The language that the NLU domain version supports.</value>
    [DataMember(Name = "language", EmitDefaultValue = false)]
    public string Language { get; set; }



    /// <summary>
    /// Whether this NLU domain version has been published.
    /// </summary>
    /// <value>Whether this NLU domain version has been published.</value>
    [DataMember(Name = "published", EmitDefaultValue = false)]
    public bool? Published { get; private set; }



    /// <summary>
    /// The date when the NLU domain version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the NLU domain version was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// The date when the NLU domain version was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the NLU domain version was updated. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// The date when the NLU domain version was trained. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the NLU domain version was trained. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateTrained", EmitDefaultValue = false)]
    public DateTime? DateTrained { get; private set; }



    /// <summary>
    /// The date when the NLU domain version was published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date when the NLU domain version was published. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "datePublished", EmitDefaultValue = false)]
    public DateTime? DatePublished { get; private set; }







    /// <summary>
    /// The intents defined for this NLU domain version.
    /// </summary>
    /// <value>The intents defined for this NLU domain version.</value>
    [DataMember(Name = "intents", EmitDefaultValue = false)]
    public List<IntentDefinition> Intents { get; set; }



    /// <summary>
    /// The entity types defined for this NLU domain version.
    /// </summary>
    /// <value>The entity types defined for this NLU domain version.</value>
    [DataMember(Name = "entityTypes", EmitDefaultValue = false)]
    public List<NamedEntityTypeDefinition> EntityTypes { get; set; }



    /// <summary>
    /// The entities defined for this NLU domain version.This field is mutually exclusive with entityTypeBindings
    /// </summary>
    /// <value>The entities defined for this NLU domain version.This field is mutually exclusive with entityTypeBindings</value>
    [DataMember(Name = "entities", EmitDefaultValue = false)]
    public List<NamedEntityDefinition> Entities { get; set; }



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
        sb.Append("class NluDomainVersion {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Domain: ").Append(Domain).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Language: ").Append(Language).Append("\n");
        sb.Append("  Published: ").Append(Published).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  DateTrained: ").Append(DateTrained).Append("\n");
        sb.Append("  DatePublished: ").Append(DatePublished).Append("\n");
        sb.Append("  TrainingStatus: ").Append(TrainingStatus).Append("\n");
        sb.Append("  EvaluationStatus: ").Append(EvaluationStatus).Append("\n");
        sb.Append("  Intents: ").Append(Intents).Append("\n");
        sb.Append("  EntityTypes: ").Append(EntityTypes).Append("\n");
        sb.Append("  Entities: ").Append(Entities).Append("\n");
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
        return Equals(obj as NluDomainVersion);
    }

    /// <summary>
    /// Returns true if NluDomainVersion instances are equal
    /// </summary>
    /// <param name="other">Instance of NluDomainVersion to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NluDomainVersion other)
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
                Domain == other.Domain ||
                Domain != null &&
                Domain.Equals(other.Domain)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Language == other.Language ||
                Language != null &&
                Language.Equals(other.Language)
            ) &&
            (
                Published == other.Published ||
                Published != null &&
                Published.Equals(other.Published)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                DateTrained == other.DateTrained ||
                DateTrained != null &&
                DateTrained.Equals(other.DateTrained)
            ) &&
            (
                DatePublished == other.DatePublished ||
                DatePublished != null &&
                DatePublished.Equals(other.DatePublished)
            ) &&
            (
                TrainingStatus == other.TrainingStatus ||
                TrainingStatus != null &&
                TrainingStatus.Equals(other.TrainingStatus)
            ) &&
            (
                EvaluationStatus == other.EvaluationStatus ||
                EvaluationStatus != null &&
                EvaluationStatus.Equals(other.EvaluationStatus)
            ) &&
            (
                Intents == other.Intents ||
                Intents != null &&
                Intents.SequenceEqual(other.Intents)
            ) &&
            (
                EntityTypes == other.EntityTypes ||
                EntityTypes != null &&
                EntityTypes.SequenceEqual(other.EntityTypes)
            ) &&
            (
                Entities == other.Entities ||
                Entities != null &&
                Entities.SequenceEqual(other.Entities)
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

            if (Domain != null)
            {
                hash = hash * 59 + Domain.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Language != null)
            {
                hash = hash * 59 + Language.GetHashCode();
            }

            if (Published != null)
            {
                hash = hash * 59 + Published.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (DateTrained != null)
            {
                hash = hash * 59 + DateTrained.GetHashCode();
            }

            if (DatePublished != null)
            {
                hash = hash * 59 + DatePublished.GetHashCode();
            }

            if (TrainingStatus != null)
            {
                hash = hash * 59 + TrainingStatus.GetHashCode();
            }

            if (EvaluationStatus != null)
            {
                hash = hash * 59 + EvaluationStatus.GetHashCode();
            }

            if (Intents != null)
            {
                hash = hash * 59 + Intents.GetHashCode();
            }

            if (EntityTypes != null)
            {
                hash = hash * 59 + EntityTypes.GetHashCode();
            }

            if (Entities != null)
            {
                hash = hash * 59 + Entities.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
