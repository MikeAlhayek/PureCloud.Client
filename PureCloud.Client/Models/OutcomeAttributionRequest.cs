using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// OutcomeAttributionRequest
/// </summary>
[DataContract]
public partial class OutcomeAttributionRequest : IEquatable<OutcomeAttributionRequest>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="OutcomeAttributionRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OutcomeAttributionRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="OutcomeAttributionRequest" /> class.
    /// </summary>
    /// <param name="OutcomeId">ID of Outcome. (required).</param>
    /// <param name="ExternalContactId">The external contact ID of the customer who achieved the outcome..</param>
    /// <param name="AssociatedValue">The total value associated with the customer&#39;s outcome. (required).</param>
    /// <param name="Touchpoints">List of interactions that led to this outcome being achieved. (required).</param>
    /// <param name="CreatedDate">Date outcome was achieved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    public OutcomeAttributionRequest(string OutcomeId = null, string ExternalContactId = null, double? AssociatedValue = null, List<Touchpoint> Touchpoints = null, DateTime? CreatedDate = null)
    {
        this.OutcomeId = OutcomeId;
        this.ExternalContactId = ExternalContactId;
        this.AssociatedValue = AssociatedValue;
        this.Touchpoints = Touchpoints;
        this.CreatedDate = CreatedDate;

    }



    /// <summary>
    /// ID of Outcome.
    /// </summary>
    /// <value>ID of Outcome.</value>
    [DataMember(Name = "outcomeId", EmitDefaultValue = false)]
    public string OutcomeId { get; set; }



    /// <summary>
    /// The external contact ID of the customer who achieved the outcome.
    /// </summary>
    /// <value>The external contact ID of the customer who achieved the outcome.</value>
    [DataMember(Name = "externalContactId", EmitDefaultValue = false)]
    public string ExternalContactId { get; set; }



    /// <summary>
    /// The total value associated with the customer&#39;s outcome.
    /// </summary>
    /// <value>The total value associated with the customer&#39;s outcome.</value>
    [DataMember(Name = "associatedValue", EmitDefaultValue = false)]
    public double? AssociatedValue { get; set; }



    /// <summary>
    /// List of interactions that led to this outcome being achieved.
    /// </summary>
    /// <value>List of interactions that led to this outcome being achieved.</value>
    [DataMember(Name = "touchpoints", EmitDefaultValue = false)]
    public List<Touchpoint> Touchpoints { get; set; }



    /// <summary>
    /// Date outcome was achieved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date outcome was achieved. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "createdDate", EmitDefaultValue = false)]
    public DateTime? CreatedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OutcomeAttributionRequest {\n");

        sb.Append("  OutcomeId: ").Append(OutcomeId).Append("\n");
        sb.Append("  ExternalContactId: ").Append(ExternalContactId).Append("\n");
        sb.Append("  AssociatedValue: ").Append(AssociatedValue).Append("\n");
        sb.Append("  Touchpoints: ").Append(Touchpoints).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
        return Equals(obj as OutcomeAttributionRequest);
    }

    /// <summary>
    /// Returns true if OutcomeAttributionRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of OutcomeAttributionRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OutcomeAttributionRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                OutcomeId == other.OutcomeId ||
                OutcomeId != null &&
                OutcomeId.Equals(other.OutcomeId)
            ) &&
            (
                ExternalContactId == other.ExternalContactId ||
                ExternalContactId != null &&
                ExternalContactId.Equals(other.ExternalContactId)
            ) &&
            (
                AssociatedValue == other.AssociatedValue ||
                AssociatedValue != null &&
                AssociatedValue.Equals(other.AssociatedValue)
            ) &&
            (
                Touchpoints == other.Touchpoints ||
                Touchpoints != null &&
                Touchpoints.SequenceEqual(other.Touchpoints)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
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
            if (OutcomeId != null)
            {
                hash = hash * 59 + OutcomeId.GetHashCode();
            }

            if (ExternalContactId != null)
            {
                hash = hash * 59 + ExternalContactId.GetHashCode();
            }

            if (AssociatedValue != null)
            {
                hash = hash * 59 + AssociatedValue.GetHashCode();
            }

            if (Touchpoints != null)
            {
                hash = hash * 59 + Touchpoints.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            return hash;
        }
    }
}
