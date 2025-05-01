using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ListWrapperAgentWorkPlanField
/// </summary>
[DataContract]
public partial class ListWrapperAgentWorkPlanField : IEquatable<ListWrapperAgentWorkPlanField>
{
    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ValuesEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Name for "Name"
        /// </summary>
        [EnumMember(Value = "Name")]
        Name,

        /// <summary>
        /// Enum Paidhours for "PaidHours"
        /// </summary>
        [EnumMember(Value = "PaidHours")]
        Paidhours
    }
    /// <summary>
    /// Initializes a new instance of the <see cref="ListWrapperAgentWorkPlanField" /> class.
    /// </summary>
    /// <param name="Values">Values.</param>
    public ListWrapperAgentWorkPlanField(List<ValuesEnum> Values = null)
    {
        this.Values = Values;

    }



    /// <summary>
    /// Gets or Sets Values
    /// </summary>
    [DataMember(Name = "values", EmitDefaultValue = false)]
    public List<ValuesEnum> Values { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ListWrapperAgentWorkPlanField {\n");

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
        return Equals(obj as ListWrapperAgentWorkPlanField);
    }

    /// <summary>
    /// Returns true if ListWrapperAgentWorkPlanField instances are equal
    /// </summary>
    /// <param name="other">Instance of ListWrapperAgentWorkPlanField to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ListWrapperAgentWorkPlanField other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
            if (Values != null)
            {
                hash = hash * 59 + Values.GetHashCode();
            }

            return hash;
        }
    }
}
