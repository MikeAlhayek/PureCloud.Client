using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// BenefitAssessment
/// </summary>

public partial class BenefitAssessment : IEquatable<BenefitAssessment>
{
    /// <summary>
    /// State of the benefit assessment.
    /// </summary>
    /// <value>State of the benefit assessment.</value>
    
    public enum StateEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Created for "Created"
        /// </summary>
        [EnumMember(Value = "Created")]
        Created,

        /// <summary>
        /// Enum Finished for "Finished"
        /// </summary>
        [EnumMember(Value = "Finished")]
        Finished,

        /// <summary>
        /// Enum Failed for "Failed"
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed
    }
    /// <summary>
    /// State of the benefit assessment.
    /// </summary>
    /// <value>State of the benefit assessment.</value>
    [JsonPropertyName("state")]
    public StateEnum? State { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="BenefitAssessment" /> class.
    /// </summary>
    public BenefitAssessment()
    {

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The list of queues that are assessed for Predictive Routing benefit.
    /// </summary>
    /// <value>The list of queues that are assessed for Predictive Routing benefit.</value>
    [JsonPropertyName("queues")]
    public List<AddressableEntityRef> Queues { get; private set; }



    /// <summary>
    /// A set of key performance indicators applied on the queue to determine suitability of Predictive Routing.
    /// </summary>
    /// <value>A set of key performance indicators applied on the queue to determine suitability of Predictive Routing.</value>
    [JsonPropertyName("kpiAssessments")]
    public List<KeyPerformanceIndicatorAssessment> KpiAssessments { get; private set; }





    /// <summary>
    /// The unique identifier of job that created this benefit assessment.
    /// </summary>
    /// <value>The unique identifier of job that created this benefit assessment.</value>
    [JsonPropertyName("jobId")]
    public string JobId { get; private set; }



    /// <summary>
    /// Creation Date of the benefit assessment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation Date of the benefit assessment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// Modified Date of the benefit assessment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Modified Date of the benefit assessment. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class BenefitAssessment {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Queues: ").Append(Queues).Append("\n");
        sb.Append("  KpiAssessments: ").Append(KpiAssessments).Append("\n");
        sb.Append("  State: ").Append(State).Append("\n");
        sb.Append("  JobId: ").Append(JobId).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as BenefitAssessment);
    }

    /// <summary>
    /// Returns true if BenefitAssessment instances are equal
    /// </summary>
    /// <param name="other">Instance of BenefitAssessment to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BenefitAssessment other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Queues == other.Queues ||
                Queues != null &&
                Queues.SequenceEqual(other.Queues)
            ) &&
            (
                KpiAssessments == other.KpiAssessments ||
                KpiAssessments != null &&
                KpiAssessments.SequenceEqual(other.KpiAssessments)
            ) &&
            (
                State == other.State ||
                State != null &&
                State.Equals(other.State)
            ) &&
            (
                JobId == other.JobId ||
                JobId != null &&
                JobId.Equals(other.JobId)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Queues != null)
            {
                hash = hash * 59 + Queues.GetHashCode();
            }

            if (KpiAssessments != null)
            {
                hash = hash * 59 + KpiAssessments.GetHashCode();
            }

            if (State != null)
            {
                hash = hash * 59 + State.GetHashCode();
            }

            if (JobId != null)
            {
                hash = hash * 59 + JobId.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
