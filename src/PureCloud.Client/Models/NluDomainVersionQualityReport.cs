using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluDomainVersionQualityReport
/// </summary>

public sealed class NluDomainVersionQualityReport 
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluDomainVersionQualityReport" /> class.
    /// </summary>
    /// Initializes a new instance of the <see cref="NluDomainVersionQualityReport" /> class.
    /// </summary>
    /// <param name="Version">The domain and version details of the quality report (required).</param>
    /// <param name="ConfusionMatrix">The confusion matrix for the Domain Version (required).</param>
    /// <param name="Summary">The quality report summary for the Domain Version (required).</param>

    /// <summary>
    /// The domain and version details of the quality report
    /// </summary>
    /// <value>The domain and version details of the quality report</value>
    public NluDomainVersion Version { get; set; }

    /// <summary>
    /// The confusion matrix for the Domain Version
    /// </summary>
    /// <value>The confusion matrix for the Domain Version</value>
    public IEnumerable<NluConfusionMatrixRow> ConfusionMatrix { get; set; }

    /// <summary>
    /// The quality report summary for the Domain Version
    /// </summary>
    /// <value>The quality report summary for the Domain Version</value>
    public NluQualityReportSummary Summary { get; set; }

    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>

    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Returns true if NluDomainVersionQualityReport instances are equal
    /// </summary>
    /// <param name="other">Instance of NluDomainVersionQualityReport to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
