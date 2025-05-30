using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PropertyIndexRequest
/// </summary>

public partial class PropertyIndexRequest : IEquatable<PropertyIndexRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PropertyIndexRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PropertyIndexRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PropertyIndexRequest" /> class.
    /// </summary>
    /// <param name="SessionId">Attach properties to a segment in the indicated session (required).</param>
    /// <param name="TargetDate">Attach properties to a segment covering a specific point in time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    /// <param name="Properties">The list of properties to index (required).</param>
    public PropertyIndexRequest(string SessionId = null, DateTime? TargetDate = null, List<AnalyticsProperty> Properties = null)
    {
        this.SessionId = SessionId;
        this.TargetDate = TargetDate;
        this.Properties = Properties;

    }



    /// <summary>
    /// Attach properties to a segment in the indicated session
    /// </summary>
    /// <value>Attach properties to a segment in the indicated session</value>
    [JsonPropertyName("sessionId")]
    public string SessionId { get; set; }



    /// <summary>
    /// Attach properties to a segment covering a specific point in time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Attach properties to a segment covering a specific point in time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("targetDate")]
    public DateTime? TargetDate { get; set; }



    /// <summary>
    /// The list of properties to index
    /// </summary>
    /// <value>The list of properties to index</value>
    [JsonPropertyName("properties")]
    public List<AnalyticsProperty> Properties { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PropertyIndexRequest {\n");

        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  TargetDate: ").Append(TargetDate).Append("\n");
        sb.Append("  Properties: ").Append(Properties).Append("\n");
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
        return Equals(obj as PropertyIndexRequest);
    }

    /// <summary>
    /// Returns true if PropertyIndexRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of PropertyIndexRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PropertyIndexRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                TargetDate == other.TargetDate ||
                TargetDate != null &&
                TargetDate.Equals(other.TargetDate)
            ) &&
            (
                Properties == other.Properties ||
                Properties != null &&
                Properties.SequenceEqual(other.Properties)
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
            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (TargetDate != null)
            {
                hash = hash * 59 + TargetDate.GetHashCode();
            }

            if (Properties != null)
            {
                hash = hash * 59 + Properties.GetHashCode();
            }

            return hash;
        }
    }
}
