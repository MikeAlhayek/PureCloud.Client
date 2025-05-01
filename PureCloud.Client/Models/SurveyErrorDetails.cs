using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// SurveyErrorDetails
/// </summary>
[DataContract]
public partial class SurveyErrorDetails : IEquatable<SurveyErrorDetails>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="SurveyErrorDetails" /> class.
    /// </summary>
    /// <param name="FlowDiagnosticInfo">Additional information about any errors that occurred in the survey invite flow..</param>
    /// <param name="SurveyErrorReason">An error code indicating the reason for the survey failure..</param>
    public SurveyErrorDetails(FlowDiagnosticInfo FlowDiagnosticInfo = null, string SurveyErrorReason = null)
    {
        this.FlowDiagnosticInfo = FlowDiagnosticInfo;
        this.SurveyErrorReason = SurveyErrorReason;

    }



    /// <summary>
    /// Additional information about any errors that occurred in the survey invite flow.
    /// </summary>
    /// <value>Additional information about any errors that occurred in the survey invite flow.</value>
    [DataMember(Name = "flowDiagnosticInfo", EmitDefaultValue = false)]
    public FlowDiagnosticInfo FlowDiagnosticInfo { get; set; }



    /// <summary>
    /// An error code indicating the reason for the survey failure.
    /// </summary>
    /// <value>An error code indicating the reason for the survey failure.</value>
    [DataMember(Name = "surveyErrorReason", EmitDefaultValue = false)]
    public string SurveyErrorReason { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class SurveyErrorDetails {\n");

        sb.Append("  FlowDiagnosticInfo: ").Append(FlowDiagnosticInfo).Append("\n");
        sb.Append("  SurveyErrorReason: ").Append(SurveyErrorReason).Append("\n");
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
        return Equals(obj as SurveyErrorDetails);
    }

    /// <summary>
    /// Returns true if SurveyErrorDetails instances are equal
    /// </summary>
    /// <param name="other">Instance of SurveyErrorDetails to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(SurveyErrorDetails other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                FlowDiagnosticInfo == other.FlowDiagnosticInfo ||
                FlowDiagnosticInfo != null &&
                FlowDiagnosticInfo.Equals(other.FlowDiagnosticInfo)
            ) &&
            (
                SurveyErrorReason == other.SurveyErrorReason ||
                SurveyErrorReason != null &&
                SurveyErrorReason.Equals(other.SurveyErrorReason)
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
            if (FlowDiagnosticInfo != null)
            {
                hash = hash * 59 + FlowDiagnosticInfo.GetHashCode();
            }

            if (SurveyErrorReason != null)
            {
                hash = hash * 59 + SurveyErrorReason.GetHashCode();
            }

            return hash;
        }
    }
}
