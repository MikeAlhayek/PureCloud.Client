using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// A filter on an element within a journey view
/// </summary>

public partial class JourneyViewElementFilterPredicate : IEquatable<JourneyViewElementFilterPredicate>
{
    /// <summary>
    /// Optional operator, default is Matches. Valid values: Matches
    /// </summary>
    /// <value>Optional operator, default is Matches. Valid values: Matches</value>
    
    public enum OperatorEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Matches for "Matches"
        /// </summary>
        [EnumMember(Value = "Matches")]
        Matches,

        /// <summary>
        /// Enum Notmatches for "NotMatches"
        /// </summary>
        [EnumMember(Value = "NotMatches")]
        Notmatches
    }
    /// <summary>
    /// Optional operator, default is Matches. Valid values: Matches
    /// </summary>
    /// <value>Optional operator, default is Matches. Valid values: Matches</value>
    [JsonPropertyName("operator")]
    public OperatorEnum? Operator { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewElementFilterPredicate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JourneyViewElementFilterPredicate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewElementFilterPredicate" /> class.
    /// </summary>
    /// <param name="Dimension">the element&#39;s attribute being filtered on (required).</param>
    /// <param name="Values">the values of the attribute to filter on (required).</param>
    /// <param name="Operator">Optional operator, default is Matches. Valid values: Matches.</param>
    /// <param name="NoValue">set this to true if no specific value to be considered.</param>
    public JourneyViewElementFilterPredicate(string Dimension = null, List<string> Values = null, OperatorEnum? Operator = null, bool? NoValue = null)
    {
        this.Dimension = Dimension;
        this.Values = Values;
        this.Operator = Operator;
        this.NoValue = NoValue;

    }



    /// <summary>
    /// the element&#39;s attribute being filtered on
    /// </summary>
    /// <value>the element&#39;s attribute being filtered on</value>
    [JsonPropertyName("dimension")]
    public string Dimension { get; set; }



    /// <summary>
    /// the values of the attribute to filter on
    /// </summary>
    /// <value>the values of the attribute to filter on</value>
    [JsonPropertyName("values")]
    public List<string> Values { get; set; }





    /// <summary>
    /// set this to true if no specific value to be considered
    /// </summary>
    /// <value>set this to true if no specific value to be considered</value>
    [JsonPropertyName("noValue")]
    public bool? NoValue { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyViewElementFilterPredicate {\n");

        sb.Append("  Dimension: ").Append(Dimension).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  NoValue: ").Append(NoValue).Append("\n");
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
        return Equals(obj as JourneyViewElementFilterPredicate);
    }

    /// <summary>
    /// Returns true if JourneyViewElementFilterPredicate instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyViewElementFilterPredicate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyViewElementFilterPredicate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Dimension == other.Dimension ||
                Dimension != null &&
                Dimension.Equals(other.Dimension)
            ) &&
            (
                Values == other.Values ||
                Values != null &&
                Values.SequenceEqual(other.Values)
            ) &&
            (
                Operator == other.Operator ||
                Operator != null &&
                Operator.Equals(other.Operator)
            ) &&
            (
                NoValue == other.NoValue ||
                NoValue != null &&
                NoValue.Equals(other.NoValue)
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
            if (Dimension != null)
            {
                hash = hash * 59 + Dimension.GetHashCode();
            }

            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            if (Operator != null)
            {
                hash = hash * 59 + Operator.GetHashCode();
            }

            if (NoValue != null)
            {
                hash = hash * 59 + NoValue.GetHashCode();
            }

            return hash;
        }
    }
}
