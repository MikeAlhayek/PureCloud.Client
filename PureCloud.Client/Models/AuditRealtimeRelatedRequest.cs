using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AuditRealtimeRelatedRequest
/// </summary>
[DataContract]
public partial class AuditRealtimeRelatedRequest : IEquatable<AuditRealtimeRelatedRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AuditRealtimeRelatedRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AuditRealtimeRelatedRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AuditRealtimeRelatedRequest" /> class.
    /// </summary>
    /// <param name="AuditId">The id of the audit of which related audits will be retrieved. (required).</param>
    /// <param name="TrustorOrgId">The id of the trustor org to which the audit belongs. Used when searching for audits performed by a trustee user within a trustor org..</param>
    /// <param name="Sort">Sort parameter for the query..</param>
    public AuditRealtimeRelatedRequest(string AuditId = null, string TrustorOrgId = null, List<AuditQuerySort> Sort = null)
    {
        this.AuditId = AuditId;
        this.TrustorOrgId = TrustorOrgId;
        this.Sort = Sort;

    }



    /// <summary>
    /// The id of the audit of which related audits will be retrieved.
    /// </summary>
    /// <value>The id of the audit of which related audits will be retrieved.</value>
    [DataMember(Name = "auditId", EmitDefaultValue = false)]
    public string AuditId { get; set; }



    /// <summary>
    /// The id of the trustor org to which the audit belongs. Used when searching for audits performed by a trustee user within a trustor org.
    /// </summary>
    /// <value>The id of the trustor org to which the audit belongs. Used when searching for audits performed by a trustee user within a trustor org.</value>
    [DataMember(Name = "trustorOrgId", EmitDefaultValue = false)]
    public string TrustorOrgId { get; set; }



    /// <summary>
    /// Sort parameter for the query.
    /// </summary>
    /// <value>Sort parameter for the query.</value>
    [DataMember(Name = "sort", EmitDefaultValue = false)]
    public List<AuditQuerySort> Sort { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AuditRealtimeRelatedRequest {\n");

        sb.Append("  AuditId: ").Append(AuditId).Append("\n");
        sb.Append("  TrustorOrgId: ").Append(TrustorOrgId).Append("\n");
        sb.Append("  Sort: ").Append(Sort).Append("\n");
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
        return Equals(obj as AuditRealtimeRelatedRequest);
    }

    /// <summary>
    /// Returns true if AuditRealtimeRelatedRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AuditRealtimeRelatedRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AuditRealtimeRelatedRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                AuditId == other.AuditId ||
                AuditId != null &&
                AuditId.Equals(other.AuditId)
            ) &&
            (
                TrustorOrgId == other.TrustorOrgId ||
                TrustorOrgId != null &&
                TrustorOrgId.Equals(other.TrustorOrgId)
            ) &&
            (
                Sort == other.Sort ||
                Sort != null &&
                Sort.SequenceEqual(other.Sort)
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
            if (AuditId != null)
            {
                hash = hash * 59 + AuditId.GetHashCode();
            }

            if (TrustorOrgId != null)
            {
                hash = hash * 59 + TrustorOrgId.GetHashCode();
            }

            if (Sort != null)
            {
                hash = hash * 59 + Sort.GetHashCode();
            }

            return hash;
        }
    }
}
