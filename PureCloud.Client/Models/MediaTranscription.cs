using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// MediaTranscription
/// </summary>
[DataContract]
public partial class MediaTranscription : IEquatable<MediaTranscription>
{
    /// <summary>
    /// Gets or Sets TranscriptionProvider
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TranscriptionProviderEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Voci for "VOCI"
        /// </summary>
        [EnumMember(Value = "VOCI")]
        Voci,

        /// <summary>
        /// Enum Calljourney for "CALLJOURNEY"
        /// </summary>
        [EnumMember(Value = "CALLJOURNEY")]
        Calljourney
    }
    /// <summary>
    /// Gets or Sets TranscriptionProvider
    /// </summary>
    [DataMember(Name = "transcriptionProvider", EmitDefaultValue = false)]
    public TranscriptionProviderEnum? TranscriptionProvider { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="MediaTranscription" /> class.
    /// </summary>
    /// <param name="DisplayName">DisplayName.</param>
    /// <param name="TranscriptionProvider">TranscriptionProvider.</param>
    /// <param name="IntegrationId">IntegrationId.</param>
    public MediaTranscription(string DisplayName = null, TranscriptionProviderEnum? TranscriptionProvider = null, string IntegrationId = null)
    {
        this.DisplayName = DisplayName;
        this.TranscriptionProvider = TranscriptionProvider;
        this.IntegrationId = IntegrationId;

    }



    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name = "displayName", EmitDefaultValue = false)]
    public string DisplayName { get; set; }





    /// <summary>
    /// Gets or Sets IntegrationId
    /// </summary>
    [DataMember(Name = "integrationId", EmitDefaultValue = false)]
    public string IntegrationId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MediaTranscription {\n");

        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
        sb.Append("  TranscriptionProvider: ").Append(TranscriptionProvider).Append("\n");
        sb.Append("  IntegrationId: ").Append(IntegrationId).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object obj)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        return Equals(obj as MediaTranscription);
    }

    /// <summary>
    /// Returns true if MediaTranscription instances are equal
    /// </summary>
    /// <param name="other">Instance of MediaTranscription to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MediaTranscription other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                DisplayName == other.DisplayName ||
                DisplayName != null &&
                DisplayName.Equals(other.DisplayName)
            ) &&
            (
                TranscriptionProvider == other.TranscriptionProvider ||
                TranscriptionProvider != null &&
                TranscriptionProvider.Equals(other.TranscriptionProvider)
            ) &&
            (
                IntegrationId == other.IntegrationId ||
                IntegrationId != null &&
                IntegrationId.Equals(other.IntegrationId)
            );
    }

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        // credit: http://stackoverflow.com/a/263416/677735
        unchecked // Overflow is fine, just wrap
        {
            int hash = 41;
            // Suitable nullity checks etc, of course :)
            if (DisplayName != null)
            {
                hash = hash * 59 + DisplayName.GetHashCode();
            }

            if (TranscriptionProvider != null)
            {
                hash = hash * 59 + TranscriptionProvider.GetHashCode();
            }

            if (IntegrationId != null)
            {
                hash = hash * 59 + IntegrationId.GetHashCode();
            }

            return hash;
        }
    }
}
