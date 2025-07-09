using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class PromptAsset
{
    /// <summary>
    /// Audio upload status
    /// </summary>
    /// <value>Audio upload status</value>
    public PromptAssetUploadStatusEnum? UploadStatus { get; set; }

    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    public string Id { get; set; }

    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    public string Name { get; set; }

    /// <summary>
    /// Associated prompt ID
    /// </summary>
    /// <value>Associated prompt ID</value>
    public string PromptId { get; set; }

    /// <summary>
    /// Prompt resource language
    /// </summary>
    /// <value>Prompt resource language</value>
    public string Language { get; set; }

    /// <summary>
    /// URI of the resource audio
    /// </summary>
    /// <value>URI of the resource audio</value>
    public string MediaUri { get; set; }

    /// <summary>
    /// Text to speech of the resource
    /// </summary>
    /// <value>Text to speech of the resource</value>
    public string TtsString { get; set; }

    /// <summary>
    /// Text of the resource
    /// </summary>
    /// <value>Text of the resource</value>
    public string Text { get; set; }

    /// <summary>
    /// Upload URI for the resource audio
    /// </summary>
    /// <value>Upload URI for the resource audio</value>
    public string UploadUri { get; set; }

    /// <summary>
    /// Whether or not this resource locale is the default for the language
    /// </summary>
    /// <value>Whether or not this resource locale is the default for the language</value>
    public bool? LanguageDefault { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    public Dictionary<string, List<string>> Tags { get; set; }

    /// <summary>
    /// Gets or Sets DurationSeconds
    /// </summary>
    public double? DurationSeconds { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
