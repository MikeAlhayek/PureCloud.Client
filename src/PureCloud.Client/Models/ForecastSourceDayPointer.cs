using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ForecastSourceDayPointer
/// </summary>

public partial class ForecastSourceDayPointer : IEquatable<ForecastSourceDayPointer>
{
    /// <summary>
    /// The forecast day of week for this source data
    /// </summary>
    /// <value>The forecast day of week for this source data</value>
    
    public enum DayOfWeekEnum
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
        Saturday,

        /// <summary>
        /// Enum Eighthday for "EighthDay"
        /// </summary>
        [EnumMember(Value = "EighthDay")]
        Eighthday
    }
    /// <summary>
    /// The forecast day of week for this source data
    /// </summary>
    /// <value>The forecast day of week for this source data</value>
    [JsonPropertyName("dayOfWeek")]
    public DayOfWeekEnum? DayOfWeek { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ForecastSourceDayPointer" /> class.
    /// </summary>
    /// <param name="DayOfWeek">The forecast day of week for this source data.</param>
    /// <param name="Weight">The relative weight to apply to this source data item for weighted averages.</param>
    /// <param name="Date">The date this source data represents, in yyyy-MM-dd format.</param>
    /// <param name="FileName">The name of the source file this data came from if it originated from a data import.</param>
    /// <param name="DataKey">The key to look up the forecast source data for this source day.</param>
    public ForecastSourceDayPointer(DayOfWeekEnum? DayOfWeek = null, int? Weight = null, string Date = null, string FileName = null, string DataKey = null)
    {
        this.DayOfWeek = DayOfWeek;
        this.Weight = Weight;
        this.Date = Date;
        this.FileName = FileName;
        this.DataKey = DataKey;

    }





    /// <summary>
    /// The relative weight to apply to this source data item for weighted averages
    /// </summary>
    /// <value>The relative weight to apply to this source data item for weighted averages</value>
    [JsonPropertyName("weight")]
    public int? Weight { get; set; }



    /// <summary>
    /// The date this source data represents, in yyyy-MM-dd format
    /// </summary>
    /// <value>The date this source data represents, in yyyy-MM-dd format</value>
    [JsonPropertyName("date")]
    public string Date { get; set; }



    /// <summary>
    /// The name of the source file this data came from if it originated from a data import
    /// </summary>
    /// <value>The name of the source file this data came from if it originated from a data import</value>
    [JsonPropertyName("fileName")]
    public string FileName { get; set; }



    /// <summary>
    /// The key to look up the forecast source data for this source day
    /// </summary>
    /// <value>The key to look up the forecast source data for this source day</value>
    [JsonPropertyName("dataKey")]
    public string DataKey { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ForecastSourceDayPointer {\n");

        sb.Append("  DayOfWeek: ").Append(DayOfWeek).Append("\n");
        sb.Append("  Weight: ").Append(Weight).Append("\n");
        sb.Append("  Date: ").Append(Date).Append("\n");
        sb.Append("  FileName: ").Append(FileName).Append("\n");
        sb.Append("  DataKey: ").Append(DataKey).Append("\n");
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
        return Equals(obj as ForecastSourceDayPointer);
    }

    /// <summary>
    /// Returns true if ForecastSourceDayPointer instances are equal
    /// </summary>
    /// <param name="other">Instance of ForecastSourceDayPointer to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ForecastSourceDayPointer other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DayOfWeek == other.DayOfWeek ||
                DayOfWeek != null &&
                DayOfWeek.Equals(other.DayOfWeek)
            ) &&
            (
                Weight == other.Weight ||
                Weight != null &&
                Weight.Equals(other.Weight)
            ) &&
            (
                Date == other.Date ||
                Date != null &&
                Date.Equals(other.Date)
            ) &&
            (
                FileName == other.FileName ||
                FileName != null &&
                FileName.Equals(other.FileName)
            ) &&
            (
                DataKey == other.DataKey ||
                DataKey != null &&
                DataKey.Equals(other.DataKey)
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
            if (DayOfWeek != null)
            {
                hash = hash * 59 + DayOfWeek.GetHashCode();
            }

            if (Weight != null)
            {
                hash = hash * 59 + Weight.GetHashCode();
            }

            if (Date != null)
            {
                hash = hash * 59 + Date.GetHashCode();
            }

            if (FileName != null)
            {
                hash = hash * 59 + FileName.GetHashCode();
            }

            if (DataKey != null)
            {
                hash = hash * 59 + DataKey.GetHashCode();
            }

            return hash;
        }
    }
}
