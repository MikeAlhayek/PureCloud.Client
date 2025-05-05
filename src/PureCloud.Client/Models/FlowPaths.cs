using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// FlowPaths
/// </summary>

public partial class FlowPaths : IEquatable<FlowPaths>
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
    /// Initializes a new instance of the <see cref="FlowPaths" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected FlowPaths() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="FlowPaths" /> class.
    /// </summary>
    /// <param name="Category">Category (use case) of the paths within a given domain. (required).</param>
    /// <param name="DateStart">Start date of the date range included in the flow paths data. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateEnd">End date of the date range included in the flow paths data. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Elements">Unique element identifiers and their corresponding elements in the trie data structure representing the paths. (required).</param>
    public FlowPaths(CategoryEnum? Category = null, DateTime? DateStart = null, DateTime? DateEnd = null, Dictionary<string, FlowPathsElement> Elements = null)
    {
        this.Category = Category;
        this.DateStart = DateStart;
        this.DateEnd = DateEnd;
        this.Elements = Elements;

    }





    /// <summary>
    /// Start date of the date range included in the flow paths data. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Start date of the date range included in the flow paths data. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateStart")]
    public DateTime? DateStart { get; set; }



    /// <summary>
    /// End date of the date range included in the flow paths data. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>End date of the date range included in the flow paths data. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateEnd")]
    public DateTime? DateEnd { get; set; }



    /// <summary>
    /// Unique element identifiers and their corresponding elements in the trie data structure representing the paths.
    /// </summary>
    /// <value>Unique element identifiers and their corresponding elements in the trie data structure representing the paths.</value>
    [JsonPropertyName("elements")]
    public Dictionary<string, FlowPathsElement> Elements { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FlowPaths {\n");

        sb.Append("  Category: ").Append(Category).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
        sb.Append("  Elements: ").Append(Elements).Append("\n");
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
        return Equals(obj as FlowPaths);
    }

    /// <summary>
    /// Returns true if FlowPaths instances are equal
    /// </summary>
    /// <param name="other">Instance of FlowPaths to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FlowPaths other)
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
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                DateEnd == other.DateEnd ||
                DateEnd != null &&
                DateEnd.Equals(other.DateEnd)
            ) &&
            (
                Elements == other.Elements ||
                Elements != null &&
                Elements.SequenceEqual(other.Elements)
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

            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (DateEnd != null)
            {
                hash = hash * 59 + DateEnd.GetHashCode();
            }

            if (Elements != null)
            {
                hash = hash * 59 + Elements.GetHashCode();
            }

            return hash;
        }
    }
}
