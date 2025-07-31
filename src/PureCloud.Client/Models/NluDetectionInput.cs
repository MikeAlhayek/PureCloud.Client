using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// NluDetectionInput
/// </summary>

public sealed class NluDetectionInput 
{

    /// <summary>
    /// Initializes a new instance of the <see cref="NluDetectionInput" /> class.
    /// </summary>
    /// Initializes a new instance of the <see cref="NluDetectionInput" /> class.
    /// </summary>
    /// <param name="Text">The text to perform NLU detection on. (required).</param>
    /// <param name="Language">Language of the version for multilingual detection, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;.</param>

    /// <summary>
    /// The text to perform NLU detection on.
    /// </summary>
    /// <value>The text to perform NLU detection on.</value>
    public string Text { get; set; }

    /// <summary>
    /// Language of the version for multilingual detection, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;
    /// </summary>
    /// <value>Language of the version for multilingual detection, e.g. &#x60;en-us&#x60;, &#x60;de-de&#x60;</value>
    public string Language { get; set; }

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
    /// Returns true if NluDetectionInput instances are equal
    /// </summary>
    /// <param name="other">Instance of NluDetectionInput to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
