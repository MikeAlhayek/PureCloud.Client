using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CampaignRuleExecutionSettings
/// </summary>
[DataContract]
public partial class CampaignRuleExecutionSettings : IEquatable<CampaignRuleExecutionSettings>
{
    /// <summary>
    /// Execution control frequency
    /// </summary>
    /// <value>Execution control frequency</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Oneachtrigger for "onEachTrigger"
        /// </summary>
        [EnumMember(Value = "onEachTrigger")]
        Oneachtrigger,

        /// <summary>
        /// Enum Onceperday for "oncePerDay"
        /// </summary>
        [EnumMember(Value = "oncePerDay")]
        Onceperday
    }
    /// <summary>
    /// Execution control frequency
    /// </summary>
    /// <value>Execution control frequency</value>
    [DataMember(Name = "frequency", EmitDefaultValue = false)]
    public FrequencyEnum? Frequency { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignRuleExecutionSettings" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CampaignRuleExecutionSettings() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CampaignRuleExecutionSettings" /> class.
    /// </summary>
    /// <param name="Frequency">Execution control frequency (required).</param>
    /// <param name="TimeZoneId">The time zone for the execution control frequency&#x3D;\&quot;oncePerDay\&quot;; for example, Africa/Abidjan. This property is ignored when frequency is not \&quot;oncePerDay\&quot;.</param>
    public CampaignRuleExecutionSettings(FrequencyEnum? Frequency = null, string TimeZoneId = null)
    {
        this.Frequency = Frequency;
        this.TimeZoneId = TimeZoneId;

    }





    /// <summary>
    /// The time zone for the execution control frequency&#x3D;\&quot;oncePerDay\&quot;; for example, Africa/Abidjan. This property is ignored when frequency is not \&quot;oncePerDay\&quot;
    /// </summary>
    /// <value>The time zone for the execution control frequency&#x3D;\&quot;oncePerDay\&quot;; for example, Africa/Abidjan. This property is ignored when frequency is not \&quot;oncePerDay\&quot;</value>
    [DataMember(Name = "timeZoneId", EmitDefaultValue = false)]
    public string TimeZoneId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CampaignRuleExecutionSettings {\n");

        sb.Append("  Frequency: ").Append(Frequency).Append("\n");
        sb.Append("  TimeZoneId: ").Append(TimeZoneId).Append("\n");
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
        return Equals(obj as CampaignRuleExecutionSettings);
    }

    /// <summary>
    /// Returns true if CampaignRuleExecutionSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of CampaignRuleExecutionSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CampaignRuleExecutionSettings other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Frequency == other.Frequency ||
                Frequency != null &&
                Frequency.Equals(other.Frequency)
            ) &&
            (
                TimeZoneId == other.TimeZoneId ||
                TimeZoneId != null &&
                TimeZoneId.Equals(other.TimeZoneId)
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
            if (Frequency != null)
            {
                hash = hash * 59 + Frequency.GetHashCode();
            }

            if (TimeZoneId != null)
            {
                hash = hash * 59 + TimeZoneId.GetHashCode();
            }

            return hash;
        }
    }
}
