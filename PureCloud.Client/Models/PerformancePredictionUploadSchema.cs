using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PerformancePredictionUploadSchema
/// </summary>
[DataContract]
public partial class PerformancePredictionUploadSchema : IEquatable<PerformancePredictionUploadSchema>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="PerformancePredictionUploadSchema" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PerformancePredictionUploadSchema() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="PerformancePredictionUploadSchema" /> class.
    /// </summary>
    /// <param name="CalculationStartDate">Date as an ISO-8601 string, corresponding to the beginning of the performance prediction results (required).</param>
    /// <param name="OnQueueTimes">List of agent on queue times by management unit (required).</param>
    public PerformancePredictionUploadSchema(DateTime? CalculationStartDate = null, List<MuAgentQueueTimeRequest> OnQueueTimes = null)
    {
        this.CalculationStartDate = CalculationStartDate;
        this.OnQueueTimes = OnQueueTimes;

    }



    /// <summary>
    /// Date as an ISO-8601 string, corresponding to the beginning of the performance prediction results
    /// </summary>
    /// <value>Date as an ISO-8601 string, corresponding to the beginning of the performance prediction results</value>
    [DataMember(Name = "calculationStartDate", EmitDefaultValue = false)]
    public DateTime? CalculationStartDate { get; set; }



    /// <summary>
    /// List of agent on queue times by management unit
    /// </summary>
    /// <value>List of agent on queue times by management unit</value>
    [DataMember(Name = "onQueueTimes", EmitDefaultValue = false)]
    public List<MuAgentQueueTimeRequest> OnQueueTimes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PerformancePredictionUploadSchema {\n");

        sb.Append("  CalculationStartDate: ").Append(CalculationStartDate).Append("\n");
        sb.Append("  OnQueueTimes: ").Append(OnQueueTimes).Append("\n");
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
        return Equals(obj as PerformancePredictionUploadSchema);
    }

    /// <summary>
    /// Returns true if PerformancePredictionUploadSchema instances are equal
    /// </summary>
    /// <param name="other">Instance of PerformancePredictionUploadSchema to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PerformancePredictionUploadSchema other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                CalculationStartDate == other.CalculationStartDate ||
                CalculationStartDate != null &&
                CalculationStartDate.Equals(other.CalculationStartDate)
            ) &&
            (
                OnQueueTimes == other.OnQueueTimes ||
                OnQueueTimes != null &&
                OnQueueTimes.SequenceEqual(other.OnQueueTimes)
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
            if (CalculationStartDate != null)
            {
                hash = hash * 59 + CalculationStartDate.GetHashCode();
            }

            if (OnQueueTimes != null)
            {
                hash = hash * 59 + OnQueueTimes.GetHashCode();
            }

            return hash;
        }
    }
}
