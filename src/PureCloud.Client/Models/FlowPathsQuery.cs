using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowPathsQuery
/// </summary>

public partial class FlowPathsQuery : IEquatable<FlowPathsQuery>
{
    /// <summary>
    /// Category (use case) of the paths within a given domain.
    /// </summary>
    /// <value>Category (use case) of the paths within a given domain.</value>
    
    public enum CategoryEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum All for "All"
        /// </summary>
        [EnumMember(Value = "All")]
        All,

        /// <summary>
        /// Enum Abandoned for "Abandoned"
        /// </summary>
        [EnumMember(Value = "Abandoned")]
        Abandoned,

        /// <summary>
        /// Enum Agentescalation for "AgentEscalation"
        /// </summary>
        [EnumMember(Value = "AgentEscalation")]
        Agentescalation,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Disconnect for "Disconnect"
        /// </summary>
        [EnumMember(Value = "Disconnect")]
        Disconnect,

        /// <summary>
        /// Enum Error for "Error"
        /// </summary>
        [EnumMember(Value = "Error")]
        Error,

        /// <summary>
        /// Enum Recognitionfailure for "RecognitionFailure"
        /// </summary>
        [EnumMember(Value = "RecognitionFailure")]
        Recognitionfailure,

        /// <summary>
        /// Enum Transfer for "Transfer"
        /// </summary>
        [EnumMember(Value = "Transfer")]
        Transfer
    }
    /// <summary>
    /// Category (use case) of the paths within a given domain.
    /// </summary>
    /// <value>Category (use case) of the paths within a given domain.</value>
    [JsonPropertyName("category")]
    public CategoryEnum? Category { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="FlowPathsQuery" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected FlowPathsQuery() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowPathsQuery" /> class.
    /// </summary>
    /// <param name="Category">Category (use case) of the paths within a given domain. (required).</param>
    /// <param name="Flows">List of flows to query the paths result. (required).</param>
    public FlowPathsQuery(CategoryEnum? Category = null, List<FlowPathsFlowFilter> Flows = null)
    {
        this.Category = Category;
        this.Flows = Flows;

    }





    /// <summary>
    /// List of flows to query the paths result.
    /// </summary>
    /// <value>List of flows to query the paths result.</value>
    [JsonPropertyName("flows")]
    public List<FlowPathsFlowFilter> Flows { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowPathsQuery {\n");

        sb.Append("  Category: ").Append(Category).Append("\n");
        sb.Append("  Flows: ").Append(Flows).Append("\n");
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
        return Equals(obj as FlowPathsQuery);
    }

    /// <summary>
    /// Returns true if FlowPathsQuery instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowPathsQuery to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowPathsQuery other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Category == other.Category ||
                Category != null &&
                Category.Equals(other.Category)
            ) &&
            (
                Flows == other.Flows ||
                Flows != null &&
                Flows.SequenceEqual(other.Flows)
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
            if (Category != null)
            {
                hash = hash * 59 + Category.GetHashCode();
            }

            if (Flows != null)
            {
                hash = hash * 59 + Flows.GetHashCode();
            }

            return hash;
        }
    }
}
