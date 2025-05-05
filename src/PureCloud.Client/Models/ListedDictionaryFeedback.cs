using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ListedDictionaryFeedback
/// </summary>

public partial class ListedDictionaryFeedback : IEquatable<ListedDictionaryFeedback>
{
    /// <summary>
    /// The source of the given dictionary feedback
    /// </summary>
    /// <value>The source of the given dictionary feedback</value>
    
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
    [JsonPropertyName("source")]
    public SourceEnum? Source { get; private set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ListedDictionaryFeedback" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ListedDictionaryFeedback() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ListedDictionaryFeedback" /> class.
    /// </summary>
    /// <param name="Term">The dictionary term which needs to be added to dictionary feedback system (required).</param>
    /// <param name="Dialect">The dialect for the given term, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard (required).</param>
    /// <param name="BoostValue">A weighted value assigned to a phrase. The higher the value, the higher the likelihood that the system will choose the word or phrase from the possible alternatives. Boost range is from 1.0 to 10.0. Default is 2.0.</param>
    public ListedDictionaryFeedback(string Term = null, string Dialect = null, float? BoostValue = null)
    {
        this.Term = Term;
        this.Dialect = Dialect;
        this.BoostValue = BoostValue;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The dictionary term which needs to be added to dictionary feedback system
    /// </summary>
    /// <value>The dictionary term which needs to be added to dictionary feedback system</value>
    [JsonPropertyName("term")]
    public string Term { get; set; }



    /// <summary>
    /// The dialect for the given term, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard
    /// </summary>
    /// <value>The dialect for the given term, dialect format is {language}-{country} where language follows ISO 639-1 standard and country follows ISO 3166-1 alpha 2 standard</value>
    [JsonPropertyName("dialect")]
    public string Dialect { get; set; }



    /// <summary>
    /// A weighted value assigned to a phrase. The higher the value, the higher the likelihood that the system will choose the word or phrase from the possible alternatives. Boost range is from 1.0 to 10.0. Default is 2.0
    /// </summary>
    /// <value>A weighted value assigned to a phrase. The higher the value, the higher the likelihood that the system will choose the word or phrase from the possible alternatives. Boost range is from 1.0 to 10.0. Default is 2.0</value>
    [JsonPropertyName("boostValue")]
    public float? BoostValue { get; set; }





    /// <summary>
    /// The Timestamp when dictionary feedback created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The Timestamp when dictionary feedback created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// The Id of the user who created the dictionary feedback
    /// </summary>
    /// <value>The Id of the user who created the dictionary feedback</value>
    [JsonPropertyName("createdBy")]
    public UserReference CreatedBy { get; private set; }



    /// <summary>
    /// The Timestamp when dictionary feedback modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The Timestamp when dictionary feedback modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// The Id of the user who modified the dictionary feedback
    /// </summary>
    /// <value>The Id of the user who modified the dictionary feedback</value>
    [JsonPropertyName("modifiedBy")]
    public UserReference ModifiedBy { get; private set; }



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
        sb.Append("class ListedDictionaryFeedback {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Term: ").Append(Term).Append("\n");
        sb.Append("  Dialect: ").Append(Dialect).Append("\n");
        sb.Append("  BoostValue: ").Append(BoostValue).Append("\n");
        sb.Append("  Source: ").Append(Source).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
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
        return Equals(obj as ListedDictionaryFeedback);
    }

    /// <summary>
    /// Returns true if ListedDictionaryFeedback instances are equal
    /// </summary>
    /// <param name="other">Instance of ListedDictionaryFeedback to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ListedDictionaryFeedback other)
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
                Term == other.Term ||
                Term != null &&
                Term.Equals(other.Term)
            ) &&
            (
                Dialect == other.Dialect ||
                Dialect != null &&
                Dialect.Equals(other.Dialect)
            ) &&
            (
                BoostValue == other.BoostValue ||
                BoostValue != null &&
                BoostValue.Equals(other.BoostValue)
            ) &&
            (
                Source == other.Source ||
                Source != null &&
                Source.Equals(other.Source)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
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

            if (Term != null)
            {
                hash = hash * 59 + Term.GetHashCode();
            }

            if (Dialect != null)
            {
                hash = hash * 59 + Dialect.GetHashCode();
            }

            if (BoostValue != null)
            {
                hash = hash * 59 + BoostValue.GetHashCode();
            }

            if (Source != null)
            {
                hash = hash * 59 + Source.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
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
