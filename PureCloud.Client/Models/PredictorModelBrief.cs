using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PredictorModelBrief
/// </summary>

public partial class PredictorModelBrief : IEquatable<PredictorModelBrief>
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
    /// The state of the model
    /// </summary>
    /// <value>The state of the model</value>
    
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

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
        /// Enum Invaliddataset for "InvalidDataset"
        /// </summary>
        [EnumMember(Value = "InvalidDataset")]
        Invaliddataset,

        /// <summary>
        /// Enum Inactive for "Inactive"
        /// </summary>
        [EnumMember(Value = "Inactive")]
        Inactive
    }
    /// <summary>
    /// The media type of the model.
    /// </summary>
    /// <value>The media type of the model.</value>
    [JsonPropertyName("mediaType")]
    public MediaTypeEnum? MediaType { get; private set; }
    /// <summary>
    /// The state of the model
    /// </summary>
    /// <value>The state of the model</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="PredictorModelBrief" /> class.
    /// </summary>
    public PredictorModelBrief()
    {

    }





    /// <summary>
    /// The date the model was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the model was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// The model&#39;s retraining errors.
    /// </summary>
    /// <value>The model&#39;s retraining errors.</value>
    [JsonPropertyName("retrainingErrors")]
    public List<PredictorModelRetrainingError> RetrainingErrors { get; private set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PredictorModelBrief {\n");

        sb.Append("  MediaType: ").Append(MediaType).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  RetrainingErrors: ").Append(RetrainingErrors).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
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
        return Equals(obj as PredictorModelBrief);
    }

    /// <summary>
    /// Returns true if PredictorModelBrief instances are equal
    /// </summary>
    /// <param name="other">Instance of PredictorModelBrief to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PredictorModelBrief other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                MediaType == other.MediaType ||
                MediaType != null &&
                MediaType.Equals(other.MediaType)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                RetrainingErrors == other.RetrainingErrors ||
                RetrainingErrors != null &&
                RetrainingErrors.SequenceEqual(other.RetrainingErrors)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
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
            if (MediaType != null)
            {
                hash = hash * 59 + MediaType.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (RetrainingErrors != null)
            {
                hash = hash * 59 + RetrainingErrors.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            return hash;
        }
    }
}
