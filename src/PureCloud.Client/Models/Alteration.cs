using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Alteration
/// </summary>

public partial class Alteration : IEquatable<Alteration>
{
    /// <summary>
    /// Range type (Exclusion: used to exclude a specific time within the recurrence. Inclusion: used to include a specific time within the recurrence which will execute in addition to the normal recurrence. If both an exclusion and inclusion are specified, the inclusion will take precedence over the exclusion.)
    /// </summary>
    /// <value>Range type (Exclusion: used to exclude a specific time within the recurrence. Inclusion: used to include a specific time within the recurrence which will execute in addition to the normal recurrence. If both an exclusion and inclusion are specified, the inclusion will take precedence over the exclusion.)</value>
    
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
        /// Enum Exclusion for "Exclusion"
        /// </summary>
        [EnumMember(Value = "Exclusion")]
        Exclusion,

        /// <summary>
        /// Enum Inclusion for "Inclusion"
        /// </summary>
        [EnumMember(Value = "Inclusion")]
        Inclusion
    }
    /// <summary>
    /// Range type (Exclusion: used to exclude a specific time within the recurrence. Inclusion: used to include a specific time within the recurrence which will execute in addition to the normal recurrence. If both an exclusion and inclusion are specified, the inclusion will take precedence over the exclusion.)
    /// </summary>
    /// <value>Range type (Exclusion: used to exclude a specific time within the recurrence. Inclusion: used to include a specific time within the recurrence which will execute in addition to the normal recurrence. If both an exclusion and inclusion are specified, the inclusion will take precedence over the exclusion.)</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Alteration" /> class.
    /// </summary>
    /// <param name="Type">Range type (Exclusion: used to exclude a specific time within the recurrence. Inclusion: used to include a specific time within the recurrence which will execute in addition to the normal recurrence. If both an exclusion and inclusion are specified, the inclusion will take precedence over the exclusion.).</param>
    /// <param name="Start">The start date of an alteration range as an ISO-8601 string.</param>
    /// <param name="End">The end date of an alteration range as an ISO-8601 string.</param>
    public Alteration(TypeEnum? Type = null, string Start = null, string End = null)
    {
        this.Type = Type;
        this.Start = Start;
        this.End = End;

    }





    /// <summary>
    /// The start date of an alteration range as an ISO-8601 string
    /// </summary>
    /// <value>The start date of an alteration range as an ISO-8601 string</value>
    [JsonPropertyName("start")]
    public string Start { get; set; }



    /// <summary>
    /// The end date of an alteration range as an ISO-8601 string
    /// </summary>
    /// <value>The end date of an alteration range as an ISO-8601 string</value>
    [JsonPropertyName("end")]
    public string End { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Alteration {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Start: ").Append(Start).Append("\n");
        sb.Append("  End: ").Append(End).Append("\n");
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
        return Equals(obj as Alteration);
    }

    /// <summary>
    /// Returns true if Alteration instances are equal
    /// </summary>
    /// <param name="other">Instance of Alteration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Alteration other)
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
                Start == other.Start ||
                Start != null &&
                Start.Equals(other.Start)
            ) &&
            (
                End == other.End ||
                End != null &&
                End.Equals(other.End)
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

            if (Start != null)
            {
                hash = hash * 59 + Start.GetHashCode();
            }

            if (End != null)
            {
                hash = hash * 59 + End.GetHashCode();
            }

            return hash;
        }
    }
}
