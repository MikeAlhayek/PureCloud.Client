using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// SuggestSearchCriteria
/// </summary>
[DataContract]
public partial class SuggestSearchCriteria : IEquatable<SuggestSearchCriteria>
{
    /// <summary>
    /// How to apply this search criteria against other criteria
    /// </summary>
    /// <value>How to apply this search criteria against other criteria</value>
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
        /// Enum And for "AND"
        /// </summary>
        [EnumMember(Value = "AND")]
        And,

        /// <summary>
        /// Enum Or for "OR"
        /// </summary>
        [EnumMember(Value = "OR")]
        Or,

        /// <summary>
        /// Enum Not for "NOT"
        /// </summary>
        [EnumMember(Value = "NOT")]
        Not
    }
    /// <summary>
    /// How to apply this search criteria against other criteria
    /// </summary>
    /// <value>How to apply this search criteria against other criteria</value>
    [DataMember(Name = "operator", EmitDefaultValue = false)]
    public OperatorEnum? Operator { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="SuggestSearchCriteria" /> class.
    /// </summary>
    /// <param name="EndValue">The end value of the range. This field is used for range search types..</param>
    /// <param name="Values">A list of values for the search to match against.</param>
    /// <param name="StartValue">The start value of the range. This field is used for range search types..</param>
    /// <param name="Value">A value for the search to match against.</param>
    /// <param name="Operator">How to apply this search criteria against other criteria.</param>
    /// <param name="Group">Groups multiple conditions.</param>
    /// <param name="DateFormat">Set date format for criteria values when using date range search type.  Supports Java date format syntax, example yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSX..</param>
    /// <param name="Fields">Field names to search against.</param>
    public SuggestSearchCriteria(string EndValue = null, List<string> Values = null, string StartValue = null, string Value = null, OperatorEnum? Operator = null, List<SuggestSearchCriteria> Group = null, string DateFormat = null, List<string> Fields = null)
    {
        this.EndValue = EndValue;
        this.Values = Values;
        this.StartValue = StartValue;
        this.Value = Value;
        this.Operator = Operator;
        this.Group = Group;
        this.DateFormat = DateFormat;
        this.Fields = Fields;

    }



    /// <summary>
    /// The end value of the range. This field is used for range search types.
    /// </summary>
    /// <value>The end value of the range. This field is used for range search types.</value>
    [DataMember(Name = "endValue", EmitDefaultValue = false)]
    public string EndValue { get; set; }



    /// <summary>
    /// A list of values for the search to match against
    /// </summary>
    /// <value>A list of values for the search to match against</value>
    [DataMember(Name = "values", EmitDefaultValue = false)]
    public List<string> Values { get; set; }



    /// <summary>
    /// The start value of the range. This field is used for range search types.
    /// </summary>
    /// <value>The start value of the range. This field is used for range search types.</value>
    [DataMember(Name = "startValue", EmitDefaultValue = false)]
    public string StartValue { get; set; }



    /// <summary>
    /// A value for the search to match against
    /// </summary>
    /// <value>A value for the search to match against</value>
    [DataMember(Name = "value", EmitDefaultValue = false)]
    public string Value { get; set; }





    /// <summary>
    /// Groups multiple conditions
    /// </summary>
    /// <value>Groups multiple conditions</value>
    [DataMember(Name = "group", EmitDefaultValue = false)]
    public List<SuggestSearchCriteria> Group { get; set; }



    /// <summary>
    /// Set date format for criteria values when using date range search type.  Supports Java date format syntax, example yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSX.
    /// </summary>
    /// <value>Set date format for criteria values when using date range search type.  Supports Java date format syntax, example yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSX.</value>
    [DataMember(Name = "dateFormat", EmitDefaultValue = false)]
    public string DateFormat { get; set; }



    /// <summary>
    /// Field names to search against
    /// </summary>
    /// <value>Field names to search against</value>
    [DataMember(Name = "fields", EmitDefaultValue = false)]
    public List<string> Fields { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SuggestSearchCriteria {\n");

        sb.Append("  EndValue: ").Append(EndValue).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
        sb.Append("  StartValue: ").Append(StartValue).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  Group: ").Append(Group).Append("\n");
        sb.Append("  DateFormat: ").Append(DateFormat).Append("\n");
        sb.Append("  Fields: ").Append(Fields).Append("\n");
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
        return Equals(obj as SuggestSearchCriteria);
    }

    /// <summary>
    /// Returns true if SuggestSearchCriteria instances are equal
    /// </summary>
    /// <param name="other">Instance of SuggestSearchCriteria to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SuggestSearchCriteria other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                EndValue == other.EndValue ||
                EndValue != null &&
                EndValue.Equals(other.EndValue)
            ) &&
            (
                Values == other.Values ||
                Values != null &&
                Values.SequenceEqual(other.Values)
            ) &&
            (
                StartValue == other.StartValue ||
                StartValue != null &&
                StartValue.Equals(other.StartValue)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                Operator == other.Operator ||
                Operator != null &&
                Operator.Equals(other.Operator)
            ) &&
            (
                Group == other.Group ||
                Group != null &&
                Group.SequenceEqual(other.Group)
            ) &&
            (
                DateFormat == other.DateFormat ||
                DateFormat != null &&
                DateFormat.Equals(other.DateFormat)
            ) &&
            (
                Fields == other.Fields ||
                Fields != null &&
                Fields.SequenceEqual(other.Fields)
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
            if (EndValue != null)
            {
                hash = hash * 59 + EndValue.GetHashCode();
            }

            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            if (StartValue != null)
            {
                hash = hash * 59 + StartValue.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Operator != null)
            {
                hash = hash * 59 + Operator.GetHashCode();
            }

            if (Group != null)
            {
                hash = hash * 59 + Group.GetHashCode();
            }

            if (DateFormat != null)
            {
                hash = hash * 59 + DateFormat.GetHashCode();
            }

            if (Fields != null)
            {
                hash = hash * 59 + Fields.GetHashCode();
            }

            return hash;
        }
    }
}
