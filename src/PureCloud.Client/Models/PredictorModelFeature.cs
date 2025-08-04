namespace PureCloud.Client.Models;

public sealed class PredictorModelFeature
{
    /// <summary>
    /// The type of feature.
    /// </summary>
    /// <value>The type of feature.</value>
    
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
        /// Enum User for "User"
        /// </summary>
        [EnumMember(Value = "User")]
        User,

        /// <summary>
        /// Enum Customer for "Customer"
        /// </summary>
        [EnumMember(Value = "Customer")]
        Customer,

        /// <summary>
        /// Enum Other for "Other"
        /// </summary>
        [EnumMember(Value = "Other")]
        Other
    }
    /// <summary>
    /// The type of feature.
    /// </summary>
    /// <value>The type of feature.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PredictorModelFeature" /> class.
    /// </summary>
    public PredictorModelFeature()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// The percentage of how important a feature is in the model.
    /// </summary>
    /// <value>The percentage of how important a feature is in the model.</value>
    [JsonPropertyName("percentageImportance")]
    public double? PercentageImportance { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PredictorModelFeature {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  PercentageImportance: ").Append(PercentageImportance).Append("\n");
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
        return Equals(obj as PredictorModelFeature);
    }

    /// <summary>
    /// Returns true if PredictorModelFeature instances are equal
    /// </summary>
    /// <param name="other">Instance of PredictorModelFeature to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PredictorModelFeature other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                PercentageImportance == other.PercentageImportance ||
                PercentageImportance != null &&
                PercentageImportance.Equals(other.PercentageImportance)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (PercentageImportance != null)
            {
                hash = hash * 59 + PercentageImportance.GetHashCode();
            }

            return hash;
        }
    }
}
