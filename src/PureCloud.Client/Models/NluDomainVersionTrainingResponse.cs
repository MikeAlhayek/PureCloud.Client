using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluDomainVersionTrainingResponse
/// </summary>

public sealed class NluDomainVersionTrainingResponse 
{
    /// <summary>
    /// Initializes a new instance of the <see cref="NluDomainVersionTrainingResponse" /> class.
    /// </summary>
    /// <param name="Version">Version.</param>

    /// <summary>
    /// A message indicating result of the action.
    /// </summary>
    /// <value>A message indicating result of the action.</value>
    public string Message { get; set; }

    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    public NluDomainVersion Version { get; set; }

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
    /// Returns true if NluDomainVersionTrainingResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of NluDomainVersionTrainingResponse to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
