using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

public sealed class SystemPromptAsset
{
    /// <summary>
    /// Gets or Sets UploadStatus
    /// </summary>
    public SystemPromptAssetUploadStatusEnum? UploadStatus { get; set; }

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
    /// Gets or Sets PromptId
    /// </summary>
    public string PromptId { get; set; }

    /// <summary>
    /// The asset resource language
    /// </summary>
    /// <value>The asset resource language</value>
    public string Language { get; set; }

    /// <summary>
    /// Gets or Sets DurationSeconds
    /// </summary>
    public double? DurationSeconds { get; set; }

    /// <summary>
    /// Gets or Sets MediaUri
    /// </summary>
    public string MediaUri { get; set; }

    /// <summary>
    /// Gets or Sets TtsString
    /// </summary>
    public string TtsString { get; set; }

    /// <summary>
    /// Gets or Sets Text
    /// </summary>
    public string Text { get; set; }

    /// <summary>
    /// Gets or Sets UploadUri
    /// </summary>
    public string UploadUri { get; set; }

    /// <summary>
    /// Gets or Sets HasDefault
    /// </summary>
    public bool? HasDefault { get; set; }

    /// <summary>
    /// Gets or Sets LanguageDefault
    /// </summary>
    public bool? LanguageDefault { get; set; }

    /// <summary>
    /// Gets or Sets Tags
    /// </summary>
    public Dictionary<string, List<string>> Tags { get; set; }

    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    public string SelfUri { get; set; }
}
