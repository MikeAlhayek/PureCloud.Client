using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Results of a matching expression
/// </summary>
[DataContract]
public partial class MatchCriteriaTestResult : IEquatable<MatchCriteriaTestResult>
{
    /// <summary>
    /// The type of operation to perform for matching check
    /// </summary>
    /// <value>The type of operation to perform for matching check</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
        /// Enum Greaterthanorequal for "GreaterThanOrEqual"
        /// </summary>
        [EnumMember(Value = "GreaterThanOrEqual")]
        Greaterthanorequal,

        /// <summary>
        /// Enum Lessthanorequal for "LessThanOrEqual"
        /// </summary>
        [EnumMember(Value = "LessThanOrEqual")]
        Lessthanorequal,

        /// <summary>
        /// Enum Equal for "Equal"
        /// </summary>
        [EnumMember(Value = "Equal")]
        Equal,

        /// <summary>
        /// Enum Notequal for "NotEqual"
        /// </summary>
        [EnumMember(Value = "NotEqual")]
        Notequal,

        /// <summary>
        /// Enum Lessthan for "LessThan"
        /// </summary>
        [EnumMember(Value = "LessThan")]
        Lessthan,

        /// <summary>
        /// Enum Greaterthan for "GreaterThan"
        /// </summary>
        [EnumMember(Value = "GreaterThan")]
        Greaterthan,

        /// <summary>
        /// Enum Notin for "NotIn"
        /// </summary>
        [EnumMember(Value = "NotIn")]
        Notin,

        /// <summary>
        /// Enum In for "In"
        /// </summary>
        [EnumMember(Value = "In")]
        In,

        /// <summary>
        /// Enum Contains for "Contains"
        /// </summary>
        [EnumMember(Value = "Contains")]
        Contains,

        /// <summary>
        /// Enum All for "All"
        /// </summary>
        [EnumMember(Value = "All")]
        All,

        /// <summary>
        /// Enum Exists for "Exists"
        /// </summary>
        [EnumMember(Value = "Exists")]
        Exists,

        /// <summary>
        /// Enum Size for "Size"
        /// </summary>
        [EnumMember(Value = "Size")]
        Size
    }
    /// <summary>
    /// The type of operation to perform for matching check
    /// </summary>
    /// <value>The type of operation to perform for matching check</value>
    [DataMember(Name = "operator", EmitDefaultValue = false)]
    public OperatorEnum? Operator { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="MatchCriteriaTestResult" /> class.
    /// </summary>
    /// <param name="JsonPath">The Goessner json path of the field to match.</param>
    /// <param name="Operator">The type of operation to perform for matching check.</param>
    /// <param name="Value">The value to match on. Only one of value and values can be included.</param>
    /// <param name="Values">The list of values to match on. Only one of value and values can be included.</param>
    /// <param name="GeneratedJsonPathCondition">The generated json path condition.</param>
    /// <param name="Match">Did the generated json path condition match.</param>
    /// <param name="JsonPathExtraction">The json paths and their values that were compared.</param>
    public MatchCriteriaTestResult(string JsonPath = null, OperatorEnum? Operator = null, object Value = null, List<object> Values = null, string GeneratedJsonPathCondition = null, bool? Match = null, List<MatchTestResult> JsonPathExtraction = null)
    {
        this.JsonPath = JsonPath;
        this.Operator = Operator;
        this.Value = Value;
        this.Values = Values;
        this.GeneratedJsonPathCondition = GeneratedJsonPathCondition;
        this.Match = Match;
        this.JsonPathExtraction = JsonPathExtraction;

    }



    /// <summary>
    /// The Goessner json path of the field to match
    /// </summary>
    /// <value>The Goessner json path of the field to match</value>
    [DataMember(Name = "jsonPath", EmitDefaultValue = false)]
    public string JsonPath { get; set; }





    /// <summary>
    /// The value to match on. Only one of value and values can be included
    /// </summary>
    /// <value>The value to match on. Only one of value and values can be included</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public object Value { get; set; }



    /// <summary>
    /// The list of values to match on. Only one of value and values can be included
    /// </summary>
    /// <value>The list of values to match on. Only one of value and values can be included</value>
    [DataMember(Name = "values", EmitDefaultValue = false)]
    public List<object> Values { get; set; }



    /// <summary>
    /// The generated json path condition
    /// </summary>
    /// <value>The generated json path condition</value>
    [DataMember(Name = "generatedJsonPathCondition", EmitDefaultValue = false)]
    public string GeneratedJsonPathCondition { get; set; }



    /// <summary>
    /// Did the generated json path condition match
    /// </summary>
    /// <value>Did the generated json path condition match</value>
    [DataMember(Name = "match", EmitDefaultValue = false)]
    public bool? Match { get; set; }



    /// <summary>
    /// The json paths and their values that were compared
    /// </summary>
    /// <value>The json paths and their values that were compared</value>
    [DataMember(Name = "jsonPathExtraction", EmitDefaultValue = false)]
    public List<MatchTestResult> JsonPathExtraction { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MatchCriteriaTestResult {\n");

        sb.Append("  JsonPath: ").Append(JsonPath).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
        sb.Append("  GeneratedJsonPathCondition: ").Append(GeneratedJsonPathCondition).Append("\n");
        sb.Append("  Match: ").Append(Match).Append("\n");
        sb.Append("  JsonPathExtraction: ").Append(JsonPathExtraction).Append("\n");
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
        return Equals(obj as MatchCriteriaTestResult);
    }

    /// <summary>
    /// Returns true if MatchCriteriaTestResult instances are equal
    /// </summary>
    /// <param name="other">Instance of MatchCriteriaTestResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MatchCriteriaTestResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                JsonPath == other.JsonPath ||
                JsonPath != null &&
                JsonPath.Equals(other.JsonPath)
            ) &&
            (
                Operator == other.Operator ||
                Operator != null &&
                Operator.Equals(other.Operator)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                Values == other.Values ||
                Values != null &&
                Values.SequenceEqual(other.Values)
            ) &&
            (
                GeneratedJsonPathCondition == other.GeneratedJsonPathCondition ||
                GeneratedJsonPathCondition != null &&
                GeneratedJsonPathCondition.Equals(other.GeneratedJsonPathCondition)
            ) &&
            (
                Match == other.Match ||
                Match != null &&
                Match.Equals(other.Match)
            ) &&
            (
                JsonPathExtraction == other.JsonPathExtraction ||
                JsonPathExtraction != null &&
                JsonPathExtraction.SequenceEqual(other.JsonPathExtraction)
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
            if (JsonPath != null)
            {
                hash = hash * 59 + JsonPath.GetHashCode();
            }

            if (Operator != null)
            {
                hash = hash * 59 + Operator.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            if (GeneratedJsonPathCondition != null)
            {
                hash = hash * 59 + GeneratedJsonPathCondition.GetHashCode();
            }

            if (Match != null)
            {
                hash = hash * 59 + Match.GetHashCode();
            }

            if (JsonPathExtraction != null)
            {
                hash = hash * 59 + JsonPathExtraction.GetHashCode();
            }

            return hash;
        }
    }
}
