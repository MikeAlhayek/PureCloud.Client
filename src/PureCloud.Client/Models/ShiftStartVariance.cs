using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ShiftStartVariance
/// </summary>

public partial class ShiftStartVariance : IEquatable<ShiftStartVariance>
{
    /// <summary>
    /// Gets or Sets ApplicableDays
    /// </summary>
    
    public enum ApplicableDaysEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Sunday for "Sunday"
        /// </summary>
        [EnumMember(Value = "Sunday")]
        Sunday,

        /// <summary>
        /// Enum Monday for "Monday"
        /// </summary>
        [EnumMember(Value = "Monday")]
        Monday,

        /// <summary>
        /// Enum Tuesday for "Tuesday"
        /// </summary>
        [EnumMember(Value = "Tuesday")]
        Tuesday,

        /// <summary>
        /// Enum Wednesday for "Wednesday"
        /// </summary>
        [EnumMember(Value = "Wednesday")]
        Wednesday,

        /// <summary>
        /// Enum Thursday for "Thursday"
        /// </summary>
        [EnumMember(Value = "Thursday")]
        Thursday,

        /// <summary>
        /// Enum Friday for "Friday"
        /// </summary>
        [EnumMember(Value = "Friday")]
        Friday,

        /// <summary>
        /// Enum Saturday for "Saturday"
        /// </summary>
        [EnumMember(Value = "Saturday")]
        Saturday
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ShiftStartVariance" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ShiftStartVariance() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ShiftStartVariance" /> class.
    /// </summary>
    /// <param name="ApplicableDays">Days for which shift start variance is configured (required).</param>
    /// <param name="MaxShiftStartVarianceMinutes">Maximum variance in minutes across shift starts (required).</param>
    public ShiftStartVariance(List<ApplicableDaysEnum> ApplicableDays = null, int? MaxShiftStartVarianceMinutes = null)
    {
        this.ApplicableDays = ApplicableDays;
        this.MaxShiftStartVarianceMinutes = MaxShiftStartVarianceMinutes;

    }



    /// <summary>
    /// Days for which shift start variance is configured
    /// </summary>
    /// <value>Days for which shift start variance is configured</value>
    [JsonPropertyName("applicableDays")]
    public List<ApplicableDaysEnum> ApplicableDays { get; set; }



    /// <summary>
    /// Maximum variance in minutes across shift starts
    /// </summary>
    /// <value>Maximum variance in minutes across shift starts</value>
    [JsonPropertyName("maxShiftStartVarianceMinutes")]
    public int? MaxShiftStartVarianceMinutes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ShiftStartVariance {\n");

        sb.Append("  ApplicableDays: ").Append(ApplicableDays).Append("\n");
        sb.Append("  MaxShiftStartVarianceMinutes: ").Append(MaxShiftStartVarianceMinutes).Append("\n");
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
        return Equals(obj as ShiftStartVariance);
    }

    /// <summary>
    /// Returns true if ShiftStartVariance instances are equal
    /// </summary>
    /// <param name="other">Instance of ShiftStartVariance to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ShiftStartVariance other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ApplicableDays == other.ApplicableDays ||
                ApplicableDays != null &&
                ApplicableDays.SequenceEqual(other.ApplicableDays)
            ) &&
            (
                MaxShiftStartVarianceMinutes == other.MaxShiftStartVarianceMinutes ||
                MaxShiftStartVarianceMinutes != null &&
                MaxShiftStartVarianceMinutes.Equals(other.MaxShiftStartVarianceMinutes)
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
            if (ApplicableDays != null)
            {
                hash = hash * 59 + ApplicableDays.GetHashCode();
            }

            if (MaxShiftStartVarianceMinutes != null)
            {
                hash = hash * 59 + MaxShiftStartVarianceMinutes.GetHashCode();
            }

            return hash;
        }
    }
}
