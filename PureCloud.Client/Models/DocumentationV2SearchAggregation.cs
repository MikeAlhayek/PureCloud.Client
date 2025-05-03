using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentationV2SearchAggregation
/// </summary>

public partial class DocumentationV2SearchAggregation : IEquatable<DocumentationV2SearchAggregation>
{
    /// <summary>
    /// The type of aggregation to perform
    /// </summary>
    /// <value>The type of aggregation to perform</value>
    
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
        /// Enum Term for "TERM"
        /// </summary>
        [EnumMember(Value = "TERM")]
        Term,

        /// <summary>
        /// Enum Count for "COUNT"
        /// </summary>
        [EnumMember(Value = "COUNT")]
        Count
    }
    /// <summary>
    /// Gets or Sets Order
    /// </summary>
    
    public enum OrderEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum ValueDesc for "VALUE_DESC"
        /// </summary>
        [EnumMember(Value = "VALUE_DESC")]
        ValueDesc,

        /// <summary>
        /// Enum ValueAsc for "VALUE_ASC"
        /// </summary>
        [EnumMember(Value = "VALUE_ASC")]
        ValueAsc,

        /// <summary>
        /// Enum CountDesc for "COUNT_DESC"
        /// </summary>
        [EnumMember(Value = "COUNT_DESC")]
        CountDesc,

        /// <summary>
        /// Enum CountAsc for "COUNT_ASC"
        /// </summary>
        [EnumMember(Value = "COUNT_ASC")]
        CountAsc
    }
    /// <summary>
    /// The type of aggregation to perform
    /// </summary>
    /// <value>The type of aggregation to perform</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentationV2SearchAggregation" /> class.
    /// </summary>
    /// <param name="Field">The field used for aggregation.</param>
    /// <param name="Name">The name of the aggregation. The response aggregation uses this name..</param>
    /// <param name="Type">The type of aggregation to perform.</param>
    /// <param name="Value">A value to use for aggregation.</param>
    /// <param name="Size">The number aggregations results to return out of the entire result set.</param>
    /// <param name="Order">The order in which aggregation results are sorted.</param>
    public DocumentationV2SearchAggregation(string Field = null, string Name = null, TypeEnum? Type = null, string Value = null, int? Size = null, List<OrderEnum> Order = null)
    {
        this.Field = Field;
        this.Name = Name;
        this.Type = Type;
        this.Value = Value;
        this.Size = Size;
        this.Order = Order;

    }



    /// <summary>
    /// The field used for aggregation
    /// </summary>
    /// <value>The field used for aggregation</value>
    [JsonPropertyName("field")]
    public string Field { get; set; }



    /// <summary>
    /// The name of the aggregation. The response aggregation uses this name.
    /// </summary>
    /// <value>The name of the aggregation. The response aggregation uses this name.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }





    /// <summary>
    /// A value to use for aggregation
    /// </summary>
    /// <value>A value to use for aggregation</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }



    /// <summary>
    /// The number aggregations results to return out of the entire result set
    /// </summary>
    /// <value>The number aggregations results to return out of the entire result set</value>
    [JsonPropertyName("size")]
    public int? Size { get; set; }



    /// <summary>
    /// The order in which aggregation results are sorted
    /// </summary>
    /// <value>The order in which aggregation results are sorted</value>
    [JsonPropertyName("order")]
    public List<OrderEnum> Order { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentationV2SearchAggregation {\n");

        sb.Append("  Field: ").Append(Field).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
        sb.Append("  Size: ").Append(Size).Append("\n");
        sb.Append("  Order: ").Append(Order).Append("\n");
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
        return Equals(obj as DocumentationV2SearchAggregation);
    }

    /// <summary>
    /// Returns true if DocumentationV2SearchAggregation instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentationV2SearchAggregation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentationV2SearchAggregation other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Field == other.Field ||
                Field != null &&
                Field.Equals(other.Field)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
            ) &&
            (
                Size == other.Size ||
                Size != null &&
                Size.Equals(other.Size)
            ) &&
            (
                Order == other.Order ||
                Order != null &&
                Order.SequenceEqual(other.Order)
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
            if (Field != null)
            {
                hash = hash * 59 + Field.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            if (Size != null)
            {
                hash = hash * 59 + Size.GetHashCode();
            }

            if (Order != null)
            {
                hash = hash * 59 + Order.GetHashCode();
            }

            return hash;
        }
    }
}
