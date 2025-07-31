using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluQualityReportSummaryMetric
/// </summary>

public sealed class NluQualityReportSummaryMetric 
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluQualityReportSummaryMetric" /> class.
    /// </summary>
    /// Initializes a new instance of the <see cref="NluQualityReportSummaryMetric" /> class.
    /// </summary>
    /// <param name="Name">The name of the metric. e.g. recall, f1_score (required).</param>
    /// <param name="Value">The value of the metric (required).</param>

    /// <summary>
    /// The name of the metric. e.g. recall, f1_score
    /// </summary>
    /// <value>The name of the metric. e.g. recall, f1_score</value>
    public string Name { get; set; }

    /// <summary>
    /// The value of the metric
    /// </summary>
    /// <value>The value of the metric</value>
    public float? Value { get; set; }

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
    /// Returns true if NluQualityReportSummaryMetric instances are equal
    /// </summary>
    /// <param name="other">Instance of NluQualityReportSummaryMetric to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
