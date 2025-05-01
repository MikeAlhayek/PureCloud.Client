using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// FilterRange is one of the attributes of a FilterPredicate
/// </summary>
[DataContract]
public partial class DialerContactlistfilterConfigChangeRange : IEquatable<DialerContactlistfilterConfigChangeRange>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerContactlistfilterConfigChangeRange" /> class.
    /// </summary>
    /// <param name="Min">Minimum end of the range.</param>
    /// <param name="Max">Maximum end of the range.</param>
    /// <param name="MinInclusive">Whether or not to include the minimum in the range.</param>
    /// <param name="MaxInclusive">Whether or not to include the maximum in the range.</param>
    /// <param name="InSet">Elements that apply to the IN operator.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    public DialerContactlistfilterConfigChangeRange(string Min = null, string Max = null, bool? MinInclusive = null, bool? MaxInclusive = null, List<string> InSet = null, Dictionary<string, object> AdditionalProperties = null)
    {
        this.Min = Min;
        this.Max = Max;
        this.MinInclusive = MinInclusive;
        this.MaxInclusive = MaxInclusive;
        this.InSet = InSet;
        this.AdditionalProperties = AdditionalProperties;

    }



    /// <summary>
    /// Minimum end of the range
    /// </summary>
    /// <value>Minimum end of the range</value>
    [DataMember(Name = "min", EmitDefaultValue = false)]
    public string Min { get; set; }



    /// <summary>
    /// Maximum end of the range
    /// </summary>
    /// <value>Maximum end of the range</value>
    [DataMember(Name = "max", EmitDefaultValue = false)]
    public string Max { get; set; }



    /// <summary>
    /// Whether or not to include the minimum in the range
    /// </summary>
    /// <value>Whether or not to include the minimum in the range</value>
    [DataMember(Name = "minInclusive", EmitDefaultValue = false)]
    public bool? MinInclusive { get; set; }



    /// <summary>
    /// Whether or not to include the maximum in the range
    /// </summary>
    /// <value>Whether or not to include the maximum in the range</value>
    [DataMember(Name = "maxInclusive", EmitDefaultValue = false)]
    public bool? MaxInclusive { get; set; }



    /// <summary>
    /// Elements that apply to the IN operator
    /// </summary>
    /// <value>Elements that apply to the IN operator</value>
    [DataMember(Name = "inSet", EmitDefaultValue = false)]
    public List<string> InSet { get; set; }



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
        sb.Append("class DialerContactlistfilterConfigChangeRange {\n");

        sb.Append("  Min: ").Append(Min).Append("\n");
        sb.Append("  Max: ").Append(Max).Append("\n");
        sb.Append("  MinInclusive: ").Append(MinInclusive).Append("\n");
        sb.Append("  MaxInclusive: ").Append(MaxInclusive).Append("\n");
        sb.Append("  InSet: ").Append(InSet).Append("\n");
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
        return Equals(obj as DialerContactlistfilterConfigChangeRange);
    }

    /// <summary>
    /// Returns true if DialerContactlistfilterConfigChangeRange instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerContactlistfilterConfigChangeRange to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerContactlistfilterConfigChangeRange other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Min == other.Min ||
                Min != null &&
                Min.Equals(other.Min)
            ) &&
            (
                Max == other.Max ||
                Max != null &&
                Max.Equals(other.Max)
            ) &&
            (
                MinInclusive == other.MinInclusive ||
                MinInclusive != null &&
                MinInclusive.Equals(other.MinInclusive)
            ) &&
            (
                MaxInclusive == other.MaxInclusive ||
                MaxInclusive != null &&
                MaxInclusive.Equals(other.MaxInclusive)
            ) &&
            (
                InSet == other.InSet ||
                InSet != null &&
                InSet.SequenceEqual(other.InSet)
            ) &&
            (
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
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
            if (Min != null)
            {
                hash = hash * 59 + Min.GetHashCode();
            }

            if (Max != null)
            {
                hash = hash * 59 + Max.GetHashCode();
            }

            if (MinInclusive != null)
            {
                hash = hash * 59 + MinInclusive.GetHashCode();
            }

            if (MaxInclusive != null)
            {
                hash = hash * 59 + MaxInclusive.GetHashCode();
            }

            if (InSet != null)
            {
                hash = hash * 59 + InSet.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

            return hash;
        }
    }
}
