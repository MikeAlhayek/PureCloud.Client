using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CurrentUserTimeOffIntegrationStatusRequest
/// </summary>

public partial class CurrentUserTimeOffIntegrationStatusRequest : IEquatable<CurrentUserTimeOffIntegrationStatusRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="CurrentUserTimeOffIntegrationStatusRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CurrentUserTimeOffIntegrationStatusRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CurrentUserTimeOffIntegrationStatusRequest" /> class.
    /// </summary>
    /// <param name="TimeOffRequestIds">A list of time off request IDs (required).</param>
    public CurrentUserTimeOffIntegrationStatusRequest(List<string> TimeOffRequestIds = null)
    {
        this.TimeOffRequestIds = TimeOffRequestIds;

    }



    /// <summary>
    /// A list of time off request IDs
    /// </summary>
    /// <value>A list of time off request IDs</value>
    [JsonPropertyName("timeOffRequestIds")]
    public List<string> TimeOffRequestIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CurrentUserTimeOffIntegrationStatusRequest {\n");

        sb.Append("  TimeOffRequestIds: ").Append(TimeOffRequestIds).Append("\n");
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
        return Equals(obj as CurrentUserTimeOffIntegrationStatusRequest);
    }

    /// <summary>
    /// Returns true if CurrentUserTimeOffIntegrationStatusRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CurrentUserTimeOffIntegrationStatusRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CurrentUserTimeOffIntegrationStatusRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TimeOffRequestIds == other.TimeOffRequestIds ||
                TimeOffRequestIds != null &&
                TimeOffRequestIds.SequenceEqual(other.TimeOffRequestIds)
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
            if (TimeOffRequestIds != null)
            {
                hash = hash * 59 + TimeOffRequestIds.GetHashCode();
            }

            return hash;
        }
    }
}
