using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DictionaryFeedback
/// </summary>
[DataContract]
public partial class DictionaryFeedback : IEquatable<DictionaryFeedback>
{
    /// <summary>
    /// The source of the given dictionary feedback
    /// </summary>
    /// <value>The source of the given dictionary feedback</value>
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
        /// Enum Manual for "Manual"
        /// </summary>
        [EnumMember(Value = "Manual")]
        Manual
    }
    /// <summary>
    /// The source of the given dictionary feedback
    /// </summary>
    /// <value>The source of the given dictionary feedback</value>
    [DataMember(Name = "source", EmitDefaultValue = false)]
    public SourceEnum? Source { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="DictionaryFeedback" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DictionaryFeedback() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DictionaryFeedback" /> class.
    /// </summary>
    /// <param name="Term">The dictionary term which needs to be added to dictionary feedback system (required).</param>
    /// <param name="Dialect">The dialect for the given term, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (required).</param>
    /// <param name="BoostValue">A weighted value assigned to a phrase. The higher the value, the higher the likelihood that the system will choose the word or phrase from the possible alternatives. Boost range is from 1.0 to 10.0. Default is 2.0.</param>
    /// <param name="ExamplePhrases">A list of at least 3 and up to 20 unique phrases that are example usage of the term (required).</param>
    /// <param name="SoundsLike">A list of up to 10 terms that give examples of how the term sounds.</param>
    public DictionaryFeedback(string Term = null, string Dialect = null, float? BoostValue = null, List<DictionaryFeedbackExamplePhrase> ExamplePhrases = null, List<string> SoundsLike = null)
    {
        this.Term = Term;
        this.Dialect = Dialect;
        this.BoostValue = BoostValue;
        this.ExamplePhrases = ExamplePhrases;
        this.SoundsLike = SoundsLike;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The dictionary term which needs to be added to dictionary feedback system
    /// </summary>
    /// <value>The dictionary term which needs to be added to dictionary feedback system</value>
    [DataMember(Name = "term", EmitDefaultValue = false)]
    public string Term { get; set; }



    /// <summary>
    /// The dialect for the given term, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard
    /// </summary>
    /// <value>The dialect for the given term, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard</value>
    [DataMember(Name = "dialect", EmitDefaultValue = false)]
    public string Dialect { get; set; }



    /// <summary>
    /// A weighted value assigned to a phrase. The higher the value, the higher the likelihood that the system will choose the word or phrase from the possible alternatives. Boost range is from 1.0 to 10.0. Default is 2.0
    /// </summary>
    /// <value>A weighted value assigned to a phrase. The higher the value, the higher the likelihood that the system will choose the word or phrase from the possible alternatives. Boost range is from 1.0 to 10.0. Default is 2.0</value>
    [DataMember(Name = "boostValue", EmitDefaultValue = false)]
    public float? BoostValue { get; set; }





    /// <summary>
    /// The Timestamp when dictionary feedback created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The Timestamp when dictionary feedback created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// The Id of the user who created the dictionary feedback
    /// </summary>
    /// <value>The Id of the user who created the dictionary feedback</value>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public UserReference CreatedBy { get; private set; }



    /// <summary>
    /// The Timestamp when dictionary feedback modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The Timestamp when dictionary feedback modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// The Id of the user who modified the dictionary feedback
    /// </summary>
    /// <value>The Id of the user who modified the dictionary feedback</value>
    [DataMember(Name = "modifiedBy", EmitDefaultValue = false)]
    public UserReference ModifiedBy { get; private set; }



    /// <summary>
    /// A list of at least 3 and up to 20 unique phrases that are example usage of the term
    /// </summary>
    /// <value>A list of at least 3 and up to 20 unique phrases that are example usage of the term</value>
    [DataMember(Name = "examplePhrases", EmitDefaultValue = false)]
    public List<DictionaryFeedbackExamplePhrase> ExamplePhrases { get; set; }



    /// <summary>
    /// A list of up to 10 terms that give examples of how the term sounds
    /// </summary>
    /// <value>A list of up to 10 terms that give examples of how the term sounds</value>
    [DataMember(Name = "soundsLike", EmitDefaultValue = false)]
    public List<string> SoundsLike { get; set; }



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
        sb.Append("class DictionaryFeedback {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Term: ").Append(Term).Append("\n");
        sb.Append("  Dialect: ").Append(Dialect).Append("\n");
        sb.Append("  BoostValue: ").Append(BoostValue).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  ModifiedBy: ").Append(ModifiedBy).Append("\n");
        sb.Append("  ExamplePhrases: ").Append(ExamplePhrases).Append("\n");
        sb.Append("  SoundsLike: ").Append(SoundsLike).Append("\n");
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
        return this.Equals(obj as DictionaryFeedback);
    }

    /// <summary>
    /// Returns true if DictionaryFeedback instances are equal
    /// </summary>
    /// <param name="other">Instance of DictionaryFeedback to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DictionaryFeedback other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Term == other.Term ||
                this.Term != null &&
                this.Term.Equals(other.Term)
            ) &&
            (
                this.Dialect == other.Dialect ||
                this.Dialect != null &&
                this.Dialect.Equals(other.Dialect)
            ) &&
            (
                this.BoostValue == other.BoostValue ||
                this.BoostValue != null &&
                this.BoostValue.Equals(other.BoostValue)
            ) &&
            (
                this.Source == other.Source ||
                this.Source != null &&
                this.Source.Equals(other.Source)
            ) &&
            (
                this.DateCreated == other.DateCreated ||
                this.DateCreated != null &&
                this.DateCreated.Equals(other.DateCreated)
            ) &&
            (
                this.CreatedBy == other.CreatedBy ||
                this.CreatedBy != null &&
                this.CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                this.DateModified == other.DateModified ||
                this.DateModified != null &&
                this.DateModified.Equals(other.DateModified)
            ) &&
            (
                this.ModifiedBy == other.ModifiedBy ||
                this.ModifiedBy != null &&
                this.ModifiedBy.Equals(other.ModifiedBy)
            ) &&
            (
                this.ExamplePhrases == other.ExamplePhrases ||
                this.ExamplePhrases != null &&
                this.ExamplePhrases.SequenceEqual(other.ExamplePhrases)
            ) &&
            (
                this.SoundsLike == other.SoundsLike ||
                this.SoundsLike != null &&
                this.SoundsLike.SequenceEqual(other.SoundsLike)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Term != null)
            {
                hash = hash * 59 + this.Term.GetHashCode();
            }

            if (this.Dialect != null)
            {
                hash = hash * 59 + this.Dialect.GetHashCode();
            }

            if (this.BoostValue != null)
            {
                hash = hash * 59 + this.BoostValue.GetHashCode();
            }

            if (this.Source != null)
            {
                hash = hash * 59 + this.Source.GetHashCode();
            }

            if (this.DateCreated != null)
            {
                hash = hash * 59 + this.DateCreated.GetHashCode();
            }

            if (this.CreatedBy != null)
            {
                hash = hash * 59 + this.CreatedBy.GetHashCode();
            }

            if (this.DateModified != null)
            {
                hash = hash * 59 + this.DateModified.GetHashCode();
            }

            if (this.ModifiedBy != null)
            {
                hash = hash * 59 + this.ModifiedBy.GetHashCode();
            }

            if (this.ExamplePhrases != null)
            {
                hash = hash * 59 + this.ExamplePhrases.GetHashCode();
            }

            if (this.SoundsLike != null)
            {
                hash = hash * 59 + this.SoundsLike.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
