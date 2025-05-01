using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Pattern
/// </summary>
[DataContract]
public partial class Pattern : IEquatable<Pattern>
{
    /// <summary>
    /// Pattern type (Daily/Weekly)
    /// </summary>
    /// <value>Pattern type (Daily/Weekly)</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Daily for "Daily"
        /// </summary>
        [EnumMember(Value = "Daily")]
        Daily,

        /// <summary>
        /// Enum Weekly for "Weekly"
        /// </summary>
        [EnumMember(Value = "Weekly")]
        Weekly
    }
    /// <summary>
    /// Gets or Sets DaysOfWeek
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum DaysOfWeekEnum
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
    /// Pattern type (Daily/Weekly)
    /// </summary>
    /// <value>Pattern type (Daily/Weekly)</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Pattern" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Pattern() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Pattern" /> class.
    /// </summary>
    /// <param name="Type">Pattern type (Daily/Weekly) (required).</param>
    /// <param name="Interval">The interval of days between the occurrences for Daily pattern type, and weeks between the occurrences for Weekly (required).</param>
    /// <param name="DaysOfWeek">The day(s) of week the occurrence should be repeated. Required to set for Weekly pattern type. E.g. [\&quot;Monday\&quot;, \&quot;Wednesday\&quot;].</param>
    public Pattern(TypeEnum? Type = null, int? Interval = null, List<DaysOfWeekEnum> DaysOfWeek = null)
    {
        this.Type = Type;
        this.Interval = Interval;
        this.DaysOfWeek = DaysOfWeek;

    }





    /// <summary>
    /// The interval of days between the occurrences for Daily pattern type, and weeks between the occurrences for Weekly
    /// </summary>
    /// <value>The interval of days between the occurrences for Daily pattern type, and weeks between the occurrences for Weekly</value>
    [DataMember(Name = "interval", EmitDefaultValue = false)]
    public int? Interval { get; set; }



    /// <summary>
    /// The day(s) of week the occurrence should be repeated. Required to set for Weekly pattern type. E.g. [\&quot;Monday\&quot;, \&quot;Wednesday\&quot;]
    /// </summary>
    /// <value>The day(s) of week the occurrence should be repeated. Required to set for Weekly pattern type. E.g. [\&quot;Monday\&quot;, \&quot;Wednesday\&quot;]</value>
    [DataMember(Name = "daysOfWeek", EmitDefaultValue = false)]
    public List<DaysOfWeekEnum> DaysOfWeek { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Pattern {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Interval: ").Append(Interval).Append("\n");
        sb.Append("  DaysOfWeek: ").Append(DaysOfWeek).Append("\n");
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
        return Equals(obj as Pattern);
    }

    /// <summary>
    /// Returns true if Pattern instances are equal
    /// </summary>
    /// <param name="other">Instance of Pattern to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Pattern other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Interval == other.Interval ||
                Interval != null &&
                Interval.Equals(other.Interval)
            ) &&
            (
                DaysOfWeek == other.DaysOfWeek ||
                DaysOfWeek != null &&
                DaysOfWeek.SequenceEqual(other.DaysOfWeek)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Interval != null)
            {
                hash = hash * 59 + Interval.GetHashCode();
            }

            if (DaysOfWeek != null)
            {
                hash = hash * 59 + DaysOfWeek.GetHashCode();
            }

            return hash;
        }
    }
}
