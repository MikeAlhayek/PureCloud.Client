using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluDetectionOutput
/// </summary>

public sealed class NluDetectionOutput 
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NluDetectionOutput" /> class.
    /// </summary>

    /// <summary>
    /// The detected intents.
    /// </summary>
    /// <value>The detected intents.</value>
    public IEnumerable<DetectedIntent> Intents { get; set; }

    /// <summary>
    /// The detected dialog acts.
    /// </summary>
    /// <value>The detected dialog acts.</value>
    public IEnumerable<DetectedDialogAct> DialogActs { get; set; }

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
    /// Returns true if NluDetectionOutput instances are equal
    /// </summary>
    /// <param name="other">Instance of NluDetectionOutput to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
