using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluDomainVersionQualityReport
/// </summary>
[DataContract]
public partial class NluDomainVersionQualityReport : IEquatable<NluDomainVersionQualityReport>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluDomainVersionQualityReport" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected NluDomainVersionQualityReport() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="NluDomainVersionQualityReport" /> class.
    /// </summary>
    /// <param name="Version">The domain and version details of the quality report (required).</param>
    /// <param name="ConfusionMatrix">The confusion matrix for the Domain Version (required).</param>
    /// <param name="Summary">The quality report summary for the Domain Version (required).</param>
    public NluDomainVersionQualityReport(NluDomainVersion Version = null, List<NluConfusionMatrixRow> ConfusionMatrix = null, NluQualityReportSummary Summary = null)
    {
        this.Version = Version;
        this.ConfusionMatrix = ConfusionMatrix;
        this.Summary = Summary;

    }



    /// <summary>
    /// The domain and version details of the quality report
    /// </summary>
    /// <value>The domain and version details of the quality report</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public NluDomainVersion Version { get; set; }



    /// <summary>
    /// The confusion matrix for the Domain Version
    /// </summary>
    /// <value>The confusion matrix for the Domain Version</value>
    [DataMember(Name = "confusionMatrix", EmitDefaultValue = false)]
    public List<NluConfusionMatrixRow> ConfusionMatrix { get; set; }



    /// <summary>
    /// The quality report summary for the Domain Version
    /// </summary>
    /// <value>The quality report summary for the Domain Version</value>
    [DataMember(Name = "summary", EmitDefaultValue = false)]
    public NluQualityReportSummary Summary { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class NluDomainVersionQualityReport {\n");

        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  ConfusionMatrix: ").Append(ConfusionMatrix).Append("\n");
        sb.Append("  Summary: ").Append(Summary).Append("\n");
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
        return Equals(obj as NluDomainVersionQualityReport);
    }

    /// <summary>
    /// Returns true if NluDomainVersionQualityReport instances are equal
    /// </summary>
    /// <param name="other">Instance of NluDomainVersionQualityReport to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(NluDomainVersionQualityReport other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                ConfusionMatrix == other.ConfusionMatrix ||
                ConfusionMatrix != null &&
                ConfusionMatrix.SequenceEqual(other.ConfusionMatrix)
            ) &&
            (
                Summary == other.Summary ||
                Summary != null &&
                Summary.Equals(other.Summary)
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
            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (ConfusionMatrix != null)
            {
                hash = hash * 59 + ConfusionMatrix.GetHashCode();
            }

            if (Summary != null)
            {
                hash = hash * 59 + Summary.GetHashCode();
            }

            return hash;
        }
    }
}
