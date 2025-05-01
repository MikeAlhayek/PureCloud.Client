using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Used to filter response queries
/// </summary>
[DataContract]
public partial class ResponseFilter : IEquatable<ResponseFilter>
{
    /// <summary>
    /// Filter operation: IN, EQUALS, NOTEQUALS.
    /// </summary>
    /// <value>Filter operation: IN, EQUALS, NOTEQUALS.</value>
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
        /// Enum In for "IN"
        /// </summary>
        [EnumMember(Value = "IN")]
        In,

        /// <summary>
        /// Enum Equals for "EQUALS"
        /// </summary>
        [EnumMember(Value = "EQUALS")]
        Equals,

        /// <summary>
        /// Enum Notequals for "NOTEQUALS"
        /// </summary>
        [EnumMember(Value = "NOTEQUALS")]
        Notequals
    }
    /// <summary>
    /// Filter operation: IN, EQUALS, NOTEQUALS.
    /// </summary>
    /// <value>Filter operation: IN, EQUALS, NOTEQUALS.</value>
    [DataMember(Name = "operator", EmitDefaultValue = false)]
    public OperatorEnum? Operator { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ResponseFilter" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ResponseFilter() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ResponseFilter" /> class.
    /// </summary>
    /// <param name="Name">Field to filter on. Allowed values are &#39;name&#39;, &#39;libraryId&#39;, &#39;text.contentType&#39;, &#39;messagingTemplate&#39; and &#39;responseType&#39; (required).</param>
    /// <param name="Operator">Filter operation: IN, EQUALS, NOTEQUALS. (required).</param>
    /// <param name="Values">Values to filter on. If name is &#39;responseType&#39; then allowed values are &#39;CampaignSmsTemplate&#39;, &#39;CampaignEmailTemplate&#39;, &#39;Footer&#39; and &#39;Signature&#39; (required).</param>
    public ResponseFilter(string Name = null, OperatorEnum? Operator = null, List<string> Values = null)
    {
        this.Name = Name;
        this.Operator = Operator;
        this.Values = Values;

    }



    /// <summary>
    /// Field to filter on. Allowed values are &#39;name&#39;, &#39;libraryId&#39;, &#39;text.contentType&#39;, &#39;messagingTemplate&#39; and &#39;responseType&#39;
    /// </summary>
    /// <value>Field to filter on. Allowed values are &#39;name&#39;, &#39;libraryId&#39;, &#39;text.contentType&#39;, &#39;messagingTemplate&#39; and &#39;responseType&#39;</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }





    /// <summary>
    /// Values to filter on. If name is &#39;responseType&#39; then allowed values are &#39;CampaignSmsTemplate&#39;, &#39;CampaignEmailTemplate&#39;, &#39;Footer&#39; and &#39;Signature&#39;
    /// </summary>
    /// <value>Values to filter on. If name is &#39;responseType&#39; then allowed values are &#39;CampaignSmsTemplate&#39;, &#39;CampaignEmailTemplate&#39;, &#39;Footer&#39; and &#39;Signature&#39;</value>
    [DataMember(Name = "values", EmitDefaultValue = false)]
    public List<string> Values { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ResponseFilter {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Operator: ").Append(Operator).Append("\n");
        sb.Append("  Values: ").Append(Values).Append("\n");
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
        return Equals(obj as ResponseFilter);
    }

    /// <summary>
    /// Returns true if ResponseFilter instances are equal
    /// </summary>
    /// <param name="other">Instance of ResponseFilter to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ResponseFilter other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Operator == other.Operator ||
                Operator != null &&
                Operator.Equals(other.Operator)
            ) &&
            (
                Values == other.Values ||
                Values != null &&
                Values.SequenceEqual(other.Values)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Operator != null)
            {
                hash = hash * 59 + Operator.GetHashCode();
            }

            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            return hash;
        }
    }
}
