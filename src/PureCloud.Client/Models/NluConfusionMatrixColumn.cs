using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluConfusionMatrixColumn
/// </summary>

public sealed class NluConfusionMatrixColumn 
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluConfusionMatrixColumn" /> class.
    /// </summary>
    /// Initializes a new instance of the <see cref="NluConfusionMatrixColumn" /> class.
    /// </summary>
    /// <param name="Name">The name of the intent for the column. (required).</param>
    /// <param name="Value">The confusion value between the intents (required).</param>

    /// <summary>
    /// The name of the intent for the column.
    /// </summary>
    /// <value>The name of the intent for the column.</value>
    public string Name { get; set; }

    /// <summary>
    /// The confusion value between the intents
    /// </summary>
    /// <value>The confusion value between the intents</value>
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
    /// Returns true if NluConfusionMatrixColumn instances are equal
    /// </summary>
    /// <param name="other">Instance of NluConfusionMatrixColumn to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
