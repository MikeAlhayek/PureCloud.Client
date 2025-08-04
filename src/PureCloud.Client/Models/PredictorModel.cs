namespace PureCloud.Client.Models;

public sealed class PredictorModel
{
    /// <summary>
    /// The media type of the model.
    /// </summary>
    /// <value>The media type of the model.</value>
    
    public enum MediaTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Voice for "voice"
        /// </summary>
        [EnumMember(Value = "voice")]
        Voice,

        /// <summary>
        /// Enum Email for "email"
        /// </summary>
        [EnumMember(Value = "email")]
        Email,

        /// <summary>
        /// Enum Message for "message"
        /// </summary>
        [EnumMember(Value = "message")]
        Message
    }
    /// <summary>
    /// The media type of the model.
    /// </summary>
    /// <value>The media type of the model.</value>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PredictorModel" /> class.
    /// </summary>
    /// <param name="Features">Features.</param>
    public PredictorModel(List<PredictorModelFeature> Features = null)
    {
        this.Features = Features;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The key performance indicator used in the model.
    /// </summary>
    /// <value>The key performance indicator used in the model.</value>
    [JsonPropertyName("kpi")]
    public string Kpi { get; set; }



    /// <summary>
    /// The List of Queues that are assessed for Predictive Routing.
    /// </summary>
    /// <value>The List of Queues that are assessed for Predictive Routing.</value>
    [JsonPropertyName("queues")]
    public List<AddressableEntityRef> Queues { get; set; }



    /// <summary>
    /// DateTime indicating when the model was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>DateTime indicating when the model was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// DateTime indicating when the model was last trained. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>DateTime indicating when the model was last trained. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateTrained")]
    public DateTime? DateTrained { get; set; }





    /// <summary>
    /// Gets or Sets Features
    /// </summary>
    [JsonPropertyName("features")]
    public List<PredictorModelFeature> Features { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PredictorModel {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Kpi: ").Append(Kpi).Append("\n");
        sb.Append("  Queues: ").Append(Queues).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateTrained: ").Append(DateTrained).Append("\n");
        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  Features: ").Append(Features).Append("\n");
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
        return Equals(obj as PredictorModel);
    }

    /// <summary>
    /// Returns true if PredictorModel instances are equal
    /// </summary>
    /// <param name="other">Instance of PredictorModel to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PredictorModel other)
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
                Kpi == other.Kpi ||
                Kpi != null &&
                Kpi.Equals(other.Kpi)
            ) &&
            (
                Queues == other.Queues ||
                Queues != null &&
                Queues.SequenceEqual(other.Queues)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateTrained == other.DateTrained ||
                DateTrained != null &&
                DateTrained.Equals(other.DateTrained)
            ) &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                Features == other.Features ||
                Features != null &&
                Features.SequenceEqual(other.Features)
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

            if (Kpi != null)
            {
                hash = hash * 59 + Kpi.GetHashCode();
            }

            if (Queues != null)
            {
                hash = hash * 59 + Queues.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateTrained != null)
            {
                hash = hash * 59 + DateTrained.GetHashCode();
            }

            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (Features != null)
            {
                hash = hash * 59 + Features.GetHashCode();
            }

            return hash;
        }
    }
}
