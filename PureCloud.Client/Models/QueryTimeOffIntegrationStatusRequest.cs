using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// QueryTimeOffIntegrationStatusRequest
/// </summary>
[DataContract]
public partial class QueryTimeOffIntegrationStatusRequest : IEquatable<QueryTimeOffIntegrationStatusRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="QueryTimeOffIntegrationStatusRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected QueryTimeOffIntegrationStatusRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="QueryTimeOffIntegrationStatusRequest" /> class.
    /// </summary>
    /// <param name="TimeOffRequestLookups">A list of time off request lookups (required).</param>
    public QueryTimeOffIntegrationStatusRequest(List<TimeOffRequestLookup> TimeOffRequestLookups = null)
    {
        this.TimeOffRequestLookups = TimeOffRequestLookups;

    }



    /// <summary>
    /// A list of time off request lookups
    /// </summary>
    /// <value>A list of time off request lookups</value>
    [DataMember(Name = "timeOffRequestLookups", EmitDefaultValue = false)]
    public List<TimeOffRequestLookup> TimeOffRequestLookups { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class QueryTimeOffIntegrationStatusRequest {\n");

        sb.Append("  TimeOffRequestLookups: ").Append(TimeOffRequestLookups).Append("\n");
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
        return Equals(obj as QueryTimeOffIntegrationStatusRequest);
    }

    /// <summary>
    /// Returns true if QueryTimeOffIntegrationStatusRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of QueryTimeOffIntegrationStatusRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(QueryTimeOffIntegrationStatusRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                TimeOffRequestLookups == other.TimeOffRequestLookups ||
                TimeOffRequestLookups != null &&
                TimeOffRequestLookups.SequenceEqual(other.TimeOffRequestLookups)
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
            if (TimeOffRequestLookups != null)
            {
                hash = hash * 59 + TimeOffRequestLookups.GetHashCode();
            }

            return hash;
        }
    }
}
