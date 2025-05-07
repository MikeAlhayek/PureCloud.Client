using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyViewSchedule
/// </summary>

public partial class JourneyViewSchedule : IEquatable<JourneyViewSchedule>
{
    /// <summary>
    /// Frequency of execution
    /// </summary>
    /// <value>Frequency of execution</value>
    
    public enum FrequencyEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Daily for "Daily"
        /// </summary>
        [EnumMember(Value = "Daily")]
        Daily,

        /// <summary>
        /// Enum Weekly for "Weekly"
        /// </summary>
        [EnumMember(Value = "Weekly")]
        Weekly,

        /// <summary>
        /// Enum Monthly for "Monthly"
        /// </summary>
        [EnumMember(Value = "Monthly")]
        Monthly
    }
    /// <summary>
    /// Frequency of execution
    /// </summary>
    /// <value>Frequency of execution</value>
    [JsonPropertyName("frequency")]
    public FrequencyEnum? Frequency { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewSchedule" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JourneyViewSchedule() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewSchedule" /> class.
    /// </summary>
    /// <param name="Frequency">Frequency of execution (required).</param>
    public JourneyViewSchedule(FrequencyEnum? Frequency = null)
    {
        this.Frequency = Frequency;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// Timestamp of last update. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Timestamp of last update. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Last modified user
    /// </summary>
    /// <value>Last modified user</value>
    [JsonPropertyName("user")]
    public AddressableEntityRef User { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyViewSchedule {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Frequency: ").Append(Frequency).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
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
        return Equals(obj as JourneyViewSchedule);
    }

    /// <summary>
    /// Returns true if JourneyViewSchedule instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyViewSchedule to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyViewSchedule other)
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
                Frequency == other.Frequency ||
                Frequency != null &&
                Frequency.Equals(other.Frequency)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
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

            if (Frequency != null)
            {
                hash = hash * 59 + Frequency.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
