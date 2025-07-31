using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluDetectionRequest
/// </summary>

public sealed class NluDetectionRequest 
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluDetectionRequest" /> class.
    /// </summary>
    /// Initializes a new instance of the <see cref="NluDetectionRequest" /> class.
    /// </summary>
    /// <param name="Input">The input subject to NLU detection. (required).</param>
    /// <param name="Context">The context for the input to NLU detection..</param>

    /// <summary>
    /// The input subject to NLU detection.
    /// </summary>
    /// <value>The input subject to NLU detection.</value>
    public NluDetectionInput Input { get; set; }

    /// <summary>
    /// The context for the input to NLU detection.
    /// </summary>
    /// <value>The context for the input to NLU detection.</value>
    public NluDetectionContext Context { get; set; }

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
    /// Returns true if NluDetectionRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of NluDetectionRequest to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
