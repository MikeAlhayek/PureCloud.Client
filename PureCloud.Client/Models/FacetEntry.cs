using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FacetEntry
/// </summary>
[DataContract]
public partial class FacetEntry : IEquatable<FacetEntry>
{
    /// <summary>
    /// Gets or Sets TermType
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TermTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Term for "TERM"
        /// </summary>
        [EnumMember(Value = "TERM")]
        Term,

        /// <summary>
        /// Enum Numberrange for "NUMBERRANGE"
        /// </summary>
        [EnumMember(Value = "NUMBERRANGE")]
        Numberrange,

        /// <summary>
        /// Enum Numberhistogram for "NUMBERHISTOGRAM"
        /// </summary>
        [EnumMember(Value = "NUMBERHISTOGRAM")]
        Numberhistogram,

        /// <summary>
        /// Enum Daterange for "DATERANGE"
        /// </summary>
        [EnumMember(Value = "DATERANGE")]
        Daterange,

        /// <summary>
        /// Enum Datehistogram for "DATEHISTOGRAM"
        /// </summary>
        [EnumMember(Value = "DATEHISTOGRAM")]
        Datehistogram,

        /// <summary>
        /// Enum Id for "ID"
        /// </summary>
        [EnumMember(Value = "ID")]
        Id
    }
    /// <summary>
    /// Gets or Sets TermType
    /// </summary>
    [DataMember(Name = "termType", EmitDefaultValue = false)]
    public TermTypeEnum? TermType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="FacetEntry" /> class.
    /// </summary>
    /// <param name="Attribute">Attribute.</param>
    /// <param name="Statistics">Statistics.</param>
    /// <param name="Other">Other.</param>
    /// <param name="Total">Total.</param>
    /// <param name="Missing">Missing.</param>
    /// <param name="TermCount">TermCount.</param>
    /// <param name="TermType">TermType.</param>
    /// <param name="Terms">Terms.</param>
    public FacetEntry(TermAttribute Attribute = null, FacetStatistics Statistics = null, long? Other = null, long? Total = null, long? Missing = null, int? TermCount = null, TermTypeEnum? TermType = null, List<FacetTerm> Terms = null)
    {
        this.Attribute = Attribute;
        this.Statistics = Statistics;
        this.Other = Other;
        this.Total = Total;
        this.Missing = Missing;
        this.TermCount = TermCount;
        this.TermType = TermType;
        this.Terms = Terms;

    }



    /// <summary>
    /// Gets or Sets Attribute
    /// </summary>
    [DataMember(Name = "attribute", EmitDefaultValue = false)]
    public TermAttribute Attribute { get; set; }



    /// <summary>
    /// Gets or Sets Statistics
    /// </summary>
    [DataMember(Name = "statistics", EmitDefaultValue = false)]
    public FacetStatistics Statistics { get; set; }



    /// <summary>
    /// Gets or Sets Other
    /// </summary>
    [DataMember(Name = "other", EmitDefaultValue = false)]
    public long? Other { get; set; }



    /// <summary>
    /// Gets or Sets Total
    /// </summary>
    [DataMember(Name = "total", EmitDefaultValue = false)]
    public long? Total { get; set; }



    /// <summary>
    /// Gets or Sets Missing
    /// </summary>
    [DataMember(Name = "missing", EmitDefaultValue = false)]
    public long? Missing { get; set; }



    /// <summary>
    /// Gets or Sets TermCount
    /// </summary>
    [DataMember(Name = "termCount", EmitDefaultValue = false)]
    public int? TermCount { get; set; }





    /// <summary>
    /// Gets or Sets Terms
    /// </summary>
    [DataMember(Name = "terms", EmitDefaultValue = false)]
    public List<FacetTerm> Terms { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FacetEntry {\n");

        sb.Append("  Attribute: ").Append(Attribute).Append("\n");
        sb.Append("  Statistics: ").Append(Statistics).Append("\n");
        sb.Append("  Other: ").Append(Other).Append("\n");
        sb.Append("  Total: ").Append(Total).Append("\n");
        sb.Append("  Missing: ").Append(Missing).Append("\n");
        sb.Append("  TermCount: ").Append(TermCount).Append("\n");
        sb.Append("  TermType: ").Append(TermType).Append("\n");
        sb.Append("  Terms: ").Append(Terms).Append("\n");
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
        return Equals(obj as FacetEntry);
    }

    /// <summary>
    /// Returns true if FacetEntry instances are equal
    /// </summary>
    /// <param name="other">Instance of FacetEntry to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FacetEntry other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Attribute == other.Attribute ||
                Attribute != null &&
                Attribute.Equals(other.Attribute)
            ) &&
            (
                Statistics == other.Statistics ||
                Statistics != null &&
                Statistics.Equals(other.Statistics)
            ) &&
            (
                Other == other.Other ||
                Other != null &&
                Other.Equals(other.Other)
            ) &&
            (
                Total == other.Total ||
                Total != null &&
                Total.Equals(other.Total)
            ) &&
            (
                Missing == other.Missing ||
                Missing != null &&
                Missing.Equals(other.Missing)
            ) &&
            (
                TermCount == other.TermCount ||
                TermCount != null &&
                TermCount.Equals(other.TermCount)
            ) &&
            (
                TermType == other.TermType ||
                TermType != null &&
                TermType.Equals(other.TermType)
            ) &&
            (
                Terms == other.Terms ||
                Terms != null &&
                Terms.SequenceEqual(other.Terms)
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
            if (Attribute != null)
            {
                hash = hash * 59 + Attribute.GetHashCode();
            }

            if (Statistics != null)
            {
                hash = hash * 59 + Statistics.GetHashCode();
            }

            if (Other != null)
            {
                hash = hash * 59 + Other.GetHashCode();
            }

            if (Total != null)
            {
                hash = hash * 59 + Total.GetHashCode();
            }

            if (Missing != null)
            {
                hash = hash * 59 + Missing.GetHashCode();
            }

            if (TermCount != null)
            {
                hash = hash * 59 + TermCount.GetHashCode();
            }

            if (TermType != null)
            {
                hash = hash * 59 + TermType.GetHashCode();
            }

            if (Terms != null)
            {
                hash = hash * 59 + Terms.GetHashCode();
            }

            return hash;
        }
    }
}
