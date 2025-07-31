using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluQualityReportSummary
/// </summary>

public sealed class NluQualityReportSummary 
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluQualityReportSummary" /> class.
    /// </summary>
    /// Initializes a new instance of the <see cref="NluQualityReportSummary" /> class.
    /// </summary>
    /// <param name="Metrics">The list of metrics in the summary (required).</param>

    /// <summary>
    /// The list of metrics in the summary
    /// </summary>
    /// <value>The list of metrics in the summary</value>
    public IEnumerable<NluQualityReportSummaryMetric> Metrics { get; set; }

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
    /// Returns true if NluQualityReportSummary instances are equal
    /// </summary>
    /// <param name="other">Instance of NluQualityReportSummary to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
