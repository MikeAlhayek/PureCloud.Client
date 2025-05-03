using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ApiUsageQueryResult
/// </summary>

public partial class ApiUsageQueryResult : IEquatable<ApiUsageQueryResult>
{
    /// <summary>
    /// Query status
    /// </summary>
    /// <value>Query status</value>
    
    public enum QueryStatusEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Complete for "Complete"
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed,

        /// <summary>
        /// Enum Running for "Running"
        /// </summary>
        [EnumMember(Value = "Running")]
        Running
    }
    /// <summary>
    /// Query status
    /// </summary>
    /// <value>Query status</value>
    [JsonPropertyName("queryStatus")]
    public QueryStatusEnum? QueryStatus { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ApiUsageQueryResult" /> class.
    /// </summary>
    /// <param name="Results">Query results.</param>
    /// <param name="QueryStatus">Query status.</param>
    /// <param name="Cursors">Cursor tokens to be used for navigating paginated results.</param>
    public ApiUsageQueryResult(List<ApiUsageRow> Results = null, QueryStatusEnum? QueryStatus = null, Cursors Cursors = null)
    {
        this.Results = Results;
        this.QueryStatus = QueryStatus;
        this.Cursors = Cursors;

    }



    /// <summary>
    /// Query results
    /// </summary>
    /// <value>Query results</value>
    [JsonPropertyName("results")]
    public List<ApiUsageRow> Results { get; set; }





    /// <summary>
    /// Cursor tokens to be used for navigating paginated results
    /// </summary>
    /// <value>Cursor tokens to be used for navigating paginated results</value>
    [JsonPropertyName("cursors")]
    public Cursors Cursors { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ApiUsageQueryResult {\n");

        sb.Append("  Results: ").Append(Results).Append("\n");
        sb.Append("  QueryStatus: ").Append(QueryStatus).Append("\n");
        sb.Append("  Cursors: ").Append(Cursors).Append("\n");
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
        return Equals(obj as ApiUsageQueryResult);
    }

    /// <summary>
    /// Returns true if ApiUsageQueryResult instances are equal
    /// </summary>
    /// <param name="other">Instance of ApiUsageQueryResult to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ApiUsageQueryResult other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Results == other.Results ||
                Results != null &&
                Results.SequenceEqual(other.Results)
            ) &&
            (
                QueryStatus == other.QueryStatus ||
                QueryStatus != null &&
                QueryStatus.Equals(other.QueryStatus)
            ) &&
            (
                Cursors == other.Cursors ||
                Cursors != null &&
                Cursors.Equals(other.Cursors)
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
            if (Results != null)
            {
                hash = hash * 59 + Results.GetHashCode();
            }

            if (QueryStatus != null)
            {
                hash = hash * 59 + QueryStatus.GetHashCode();
            }

            if (Cursors != null)
            {
                hash = hash * 59 + Cursors.GetHashCode();
            }

            return hash;
        }
    }
}
