using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerSequenceScheduleConfigChangeAlteration
/// </summary>
[DataContract]
public partial class DialerSequenceScheduleConfigChangeAlteration : IEquatable<DialerSequenceScheduleConfigChangeAlteration>
{
    /// <summary>
    /// Gets or Sets Type
    /// </summary>
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
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerSequenceScheduleConfigChangeAlteration" /> class.
    /// </summary>
    /// <param name="Type">Type.</param>
    /// <param name="Start">the end date of an alteration range as an ISO-8601 string.</param>
    /// <param name="End">the end date of an alteration range as an ISO-8601 string.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public DialerSequenceScheduleConfigChangeAlteration(TypeEnum? Type = null, string Start = null, string End = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.Type = Type;
        this.Start = Start;
        this.End = End;
        this.AdditionalProperties = AdditionalProperties;

    }





    /// <summary>
    /// the end date of an alteration range as an ISO-8601 string
    /// </summary>
    /// <value>the end date of an alteration range as an ISO-8601 string</value>
    [DataMember(Name = "start", EmitDefaultValue = false)]
    public string Start { get; set; }



    /// <summary>
    /// the end date of an alteration range as an ISO-8601 string
    /// </summary>
    /// <value>the end date of an alteration range as an ISO-8601 string</value>
    [DataMember(Name = "end", EmitDefaultValue = false)]
    public string End { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [DataMember(Name = "additionalProperties", EmitDefaultValue = false)]
    public Dictionary<string, object> AdditionalProperties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerSequenceScheduleConfigChangeAlteration {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Start: ").Append(Start).Append("\n");
        sb.Append("  End: ").Append(End).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
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
        return this.Equals(obj as DialerSequenceScheduleConfigChangeAlteration);
    }

    /// <summary>
    /// Returns true if DialerSequenceScheduleConfigChangeAlteration instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerSequenceScheduleConfigChangeAlteration to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerSequenceScheduleConfigChangeAlteration other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Type == other.Type ||
                this.Type != null &&
                this.Type.Equals(other.Type)
            ) &&
            (
                this.Start == other.Start ||
                this.Start != null &&
                this.Start.Equals(other.Start)
            ) &&
            (
                this.End == other.End ||
                this.End != null &&
                this.End.Equals(other.End)
            ) &&
            (
                this.AdditionalProperties == other.AdditionalProperties ||
                this.AdditionalProperties != null &&
                this.AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
            if (this.Type != null)
            {
                hash = hash * 59 + this.Type.GetHashCode();
            }

            if (this.Start != null)
            {
                hash = hash * 59 + this.Start.GetHashCode();
            }

            if (this.End != null)
            {
                hash = hash * 59 + this.End.GetHashCode();
            }

            if (this.AdditionalProperties != null)
            {
                hash = hash * 59 + this.AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
