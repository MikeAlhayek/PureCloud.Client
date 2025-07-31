using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluDetectionResponse
/// </summary>

public sealed class NluDetectionResponse 
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NluDetectionResponse" /> class.
    /// </summary>
    /// <param name="Output">Output.</param>
    /// <param name="Input">Input.</param>

    /// <summary>
    /// The NLU domain version which performed the detection.
    /// </summary>
    /// <value>The NLU domain version which performed the detection.</value>
    public NluDomainVersion Version { get; set; }

    /// <summary>
    /// Gets or Sets Output
    /// </summary>
    public NluDetectionOutput Output { get; set; }

    /// <summary>
    /// Gets or Sets Input
    /// </summary>
    public NluDetectionInput Input { get; set; }

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
    /// Returns true if NluDetectionResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of NluDetectionResponse to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
