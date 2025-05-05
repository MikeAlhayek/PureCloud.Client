using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContactColumnTimeZone
/// </summary>

public partial class ContactColumnTimeZone : IEquatable<ContactColumnTimeZone>
{
    /// <summary>
    /// Column Type will be either PHONE or ZIP
    /// </summary>
    /// <value>Column Type will be either PHONE or ZIP</value>
    
    public enum ColumnTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Phone for "PHONE"
        /// </summary>
        [EnumMember(Value = "PHONE")]
        Phone,

        /// <summary>
        /// Enum Zip for "ZIP"
        /// </summary>
        [EnumMember(Value = "ZIP")]
        Zip
    }
    /// <summary>
    /// Column Type will be either PHONE or ZIP
    /// </summary>
    /// <value>Column Type will be either PHONE or ZIP</value>
    [JsonPropertyName("columnType")]
    public ColumnTypeEnum? ColumnType { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContactColumnTimeZone" /> class.
    /// </summary>
    /// <param name="TimeZone">Time zone that the column matched to. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London.</param>
    public ContactColumnTimeZone(string TimeZone = null)
    {
        this.TimeZone = TimeZone;

    }



    /// <summary>
    /// Time zone that the column matched to. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London
    /// </summary>
    /// <value>Time zone that the column matched to. Time zones are represented as a string of the zone name as found in the IANA time zone database. For example: UTC, Etc/UTC, or Europe/London</value>
    [JsonPropertyName("timeZone")]
    public string TimeZone { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContactColumnTimeZone {\n");

        sb.Append("  TimeZone: ").Append(TimeZone).Append("\n");
        sb.Append("  ColumnType: ").Append(ColumnType).Append("\n");
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
        return Equals(obj as ContactColumnTimeZone);
    }

    /// <summary>
    /// Returns true if ContactColumnTimeZone instances are equal
    /// </summary>
    /// <param name="other">Instance of ContactColumnTimeZone to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContactColumnTimeZone other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TimeZone == other.TimeZone ||
                TimeZone != null &&
                TimeZone.Equals(other.TimeZone)
            ) &&
            (
                ColumnType == other.ColumnType ||
                ColumnType != null &&
                ColumnType.Equals(other.ColumnType)
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
            if (TimeZone != null)
            {
                hash = hash * 59 + TimeZone.GetHashCode();
            }

            if (ColumnType != null)
            {
                hash = hash * 59 + ColumnType.GetHashCode();
            }

            return hash;
        }
    }
}
