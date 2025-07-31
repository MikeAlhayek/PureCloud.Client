using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluDetectionContext
/// </summary>

public sealed class NluDetectionContext 
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NluDetectionContext" /> class.
    /// </summary>
    /// <param name="Intent">Restrict detection to this intent..</param>
    /// <param name="Entity">Use this entity to restrict detection..</param>

    /// <summary>
    /// Restrict detection to this intent.
    /// </summary>
    /// <value>Restrict detection to this intent.</value>
    public ContextIntent Intent { get; set; }

    /// <summary>
    /// Use this entity to restrict detection.
    /// </summary>
    /// <value>Use this entity to restrict detection.</value>
    public ContextEntity Entity { get; set; }

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
    /// Returns true if NluDetectionContext instances are equal
    /// </summary>
    /// <param name="other">Instance of NluDetectionContext to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
