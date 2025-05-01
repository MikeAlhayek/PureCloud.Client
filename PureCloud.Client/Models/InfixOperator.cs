using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// InfixOperator
/// </summary>
[DataContract]
public partial class InfixOperator : IEquatable<InfixOperator>
{
    /// <summary>
    /// The logical operation that is applied on the operand against the following operand
    /// </summary>
    /// <value>The logical operation that is applied on the operand against the following operand</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum OperatorTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Or for "Or"
        /// </summary>
        [EnumMember(Value = "Or")]
        Or,

        /// <summary>
        /// Enum And for "And"
        /// </summary>
        [EnumMember(Value = "And")]
        And,

        /// <summary>
        /// Enum Near for "Near"
        /// </summary>
        [EnumMember(Value = "Near")]
        Near
    }
    /// <summary>
    /// The logical operation that is applied on the operand against the following operand
    /// </summary>
    /// <value>The logical operation that is applied on the operand against the following operand</value>
    [DataMember(Name = "operatorType", EmitDefaultValue = false)]
    public OperatorTypeEnum? OperatorType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="InfixOperator" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected InfixOperator() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="InfixOperator" /> class.
    /// </summary>
    /// <param name="OperatorType">The logical operation that is applied on the operand against the following operand (required).</param>
    /// <param name="OperatorPosition">Dictates when the following operand should occur relative to current operand.</param>
    public InfixOperator(OperatorTypeEnum? OperatorType = null, OperatorPosition OperatorPosition = null)
    {
        this.OperatorType = OperatorType;
        this.OperatorPosition = OperatorPosition;

    }





    /// <summary>
    /// Dictates when the following operand should occur relative to current operand
    /// </summary>
    /// <value>Dictates when the following operand should occur relative to current operand</value>
    [DataMember(Name = "operatorPosition", EmitDefaultValue = false)]
    public OperatorPosition OperatorPosition { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InfixOperator {\n");

        sb.Append("  OperatorType: ").Append(OperatorType).Append("\n");
        sb.Append("  OperatorPosition: ").Append(OperatorPosition).Append("\n");
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
        return Equals(obj as InfixOperator);
    }

    /// <summary>
    /// Returns true if InfixOperator instances are equal
    /// </summary>
    /// <param name="other">Instance of InfixOperator to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InfixOperator other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OperatorType == other.OperatorType ||
                OperatorType != null &&
                OperatorType.Equals(other.OperatorType)
            ) &&
            (
                OperatorPosition == other.OperatorPosition ||
                OperatorPosition != null &&
                OperatorPosition.Equals(other.OperatorPosition)
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
            if (OperatorType != null)
            {
                hash = hash * 59 + OperatorType.GetHashCode();
            }

            if (OperatorPosition != null)
            {
                hash = hash * 59 + OperatorPosition.GetHashCode();
            }

            return hash;
        }
    }
}
