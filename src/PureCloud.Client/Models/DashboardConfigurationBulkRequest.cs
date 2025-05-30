using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DashboardConfigurationBulkRequest
/// </summary>

public partial class DashboardConfigurationBulkRequest : IEquatable<DashboardConfigurationBulkRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DashboardConfigurationBulkRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DashboardConfigurationBulkRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DashboardConfigurationBulkRequest" /> class.
    /// </summary>
    /// <param name="DashboardConfigurationIds">The user supplied dashboard configuration ids (required).</param>
    public DashboardConfigurationBulkRequest(List<string> DashboardConfigurationIds = null)
    {
        this.DashboardConfigurationIds = DashboardConfigurationIds;

    }



    /// <summary>
    /// The user supplied dashboard configuration ids
    /// </summary>
    /// <value>The user supplied dashboard configuration ids</value>
    [JsonPropertyName("dashboardConfigurationIds")]
    public List<string> DashboardConfigurationIds { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DashboardConfigurationBulkRequest {\n");

        sb.Append("  DashboardConfigurationIds: ").Append(DashboardConfigurationIds).Append("\n");
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
        return Equals(obj as DashboardConfigurationBulkRequest);
    }

    /// <summary>
    /// Returns true if DashboardConfigurationBulkRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of DashboardConfigurationBulkRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DashboardConfigurationBulkRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DashboardConfigurationIds == other.DashboardConfigurationIds ||
                DashboardConfigurationIds != null &&
                DashboardConfigurationIds.SequenceEqual(other.DashboardConfigurationIds)
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
            if (DashboardConfigurationIds != null)
            {
                hash = hash * 59 + DashboardConfigurationIds.GetHashCode();
            }

            return hash;
        }
    }
}
