using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueryRequestPredicate
/// </summary>

public partial class QueryRequestPredicate : IEquatable<QueryRequestPredicate>
{
    /// <summary>
    /// The dimension to be filtered
    /// </summary>
    /// <value>The dimension to be filtered</value>
    
    public enum DimensionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Attendeeid for "attendeeId"
        /// </summary>
        [EnumMember(Value = "attendeeId")]
        Attendeeid,

        /// <summary>
        /// Enum Facilitatorid for "facilitatorId"
        /// </summary>
        [EnumMember(Value = "facilitatorId")]
        Facilitatorid,

        /// <summary>
        /// Enum Status for "status"
        /// </summary>
        [EnumMember(Value = "status")]
        Status
    }
    /// <summary>
    /// The dimension to be filtered
    /// </summary>
    /// <value>The dimension to be filtered</value>
    [JsonPropertyName("dimension")]
    public DimensionEnum? Dimension { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="QueryRequestPredicate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected QueryRequestPredicate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueryRequestPredicate" /> class.
    /// </summary>
    /// <param name="Dimension">The dimension to be filtered (required).</param>
    /// <param name="Value">The value to filter by (required).</param>
    public QueryRequestPredicate(DimensionEnum? Dimension = null, string Value = null)
    {
        this.Dimension = Dimension;
        this.Value = Value;

    }





    /// <summary>
    /// The value to filter by
    /// </summary>
    /// <value>The value to filter by</value>
    [JsonPropertyName("value")]
    public string Value { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueryRequestPredicate {\n");

        sb.Append("  Dimension: ").Append(Dimension).Append("\n");
        sb.Append("  Value: ").Append(Value).Append("\n");
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
        return Equals(obj as QueryRequestPredicate);
    }

    /// <summary>
    /// Returns true if QueryRequestPredicate instances are equal
    /// </summary>
    /// <param name="other">Instance of QueryRequestPredicate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueryRequestPredicate other)
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
                Value == other.Value ||
                Value != null &&
                Value.Equals(other.Value)
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

            if (Value != null)
            {
                hash = hash * 59 + Value.GetHashCode();
            }

            return hash;
        }
    }
}
