using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluConfusionMatrixRow
/// </summary>

public sealed class NluConfusionMatrixRow 
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluConfusionMatrixRow" /> class.
    /// </summary>
    /// Initializes a new instance of the <see cref="NluConfusionMatrixRow" /> class.
    /// </summary>
    /// <param name="Name">The name of the intent for the row. (required).</param>
    /// <param name="Columns">The columns of confusion matrix for the intent (required).</param>

    /// <summary>
    /// The name of the intent for the row.
    /// </summary>
    /// <value>The name of the intent for the row.</value>
    public string Name { get; set; }

    /// <summary>
    /// The columns of confusion matrix for the intent
    /// </summary>
    /// <value>The columns of confusion matrix for the intent</value>
    public IEnumerable<NluConfusionMatrixColumn> Columns { get; set; }

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
    /// Returns true if NluConfusionMatrixRow instances are equal
    /// </summary>
    /// <param name="other">Instance of NluConfusionMatrixRow to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
