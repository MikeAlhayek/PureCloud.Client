using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ResponseSet
/// </summary>

public partial class ResponseSet : IEquatable<ResponseSet>
{
    /// <summary>
    /// Setting level of live speaker detection based on ringbacks
    /// </summary>
    /// <value>Setting level of live speaker detection based on ringbacks</value>
    
    public enum LiveSpeakerDetectionModeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Disabled for "Disabled"
        /// </summary>
        [EnumMember(Value = "Disabled")]
        Disabled,

        /// <summary>
        /// Enum Low for "Low"
        /// </summary>
        [EnumMember(Value = "Low")]
        Low,

        /// <summary>
        /// Enum Medium for "Medium"
        /// </summary>
        [EnumMember(Value = "Medium")]
        Medium,

        /// <summary>
        /// Enum High for "High"
        /// </summary>
        [EnumMember(Value = "High")]
        High
    }
    /// <summary>
    /// Setting level of live speaker detection based on ringbacks
    /// </summary>
    /// <value>Setting level of live speaker detection based on ringbacks</value>
    [JsonPropertyName("liveSpeakerDetectionMode")]
    public LiveSpeakerDetectionModeEnum? LiveSpeakerDetectionMode { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ResponseSet" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ResponseSet() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ResponseSet" /> class.
    /// </summary>
    /// <param name="Name">The name of the ResponseSet. (required).</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    /// <param name="Responses">Map of disposition identifiers to reactions. For example: {\&quot;disposition.classification.callable.person\&quot;: {\&quot;reactionType\&quot;: \&quot;transfer\&quot;}}. (required).</param>
    /// <param name="BeepDetectionEnabled">Whether to enable answering machine beep detection.</param>
    /// <param name="AmdSpeechDistinguishEnabled">Whether to enable answering machine detection.</param>
    /// <param name="LiveSpeakerDetectionMode">Setting level of live speaker detection based on ringbacks.</param>
    public ResponseSet(string Name = null, int? Version = null, Dictionary<string, Reaction> Responses = null, bool? BeepDetectionEnabled = null, bool? AmdSpeechDistinguishEnabled = null, LiveSpeakerDetectionModeEnum? LiveSpeakerDetectionMode = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.Responses = Responses;
        this.BeepDetectionEnabled = BeepDetectionEnabled;
        this.AmdSpeechDistinguishEnabled = AmdSpeechDistinguishEnabled;
        this.LiveSpeakerDetectionMode = LiveSpeakerDetectionMode;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The name of the ResponseSet.
    /// </summary>
    /// <value>The name of the ResponseSet.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// Map of disposition identifiers to reactions. For example: {\&quot;disposition.classification.callable.person\&quot;: {\&quot;reactionType\&quot;: \&quot;transfer\&quot;}}.
    /// </summary>
    /// <value>Map of disposition identifiers to reactions. For example: {\&quot;disposition.classification.callable.person\&quot;: {\&quot;reactionType\&quot;: \&quot;transfer\&quot;}}.</value>
    [JsonPropertyName("responses")]
    public Dictionary<string, Reaction> Responses { get; set; }



    /// <summary>
    /// Whether to enable answering machine beep detection
    /// </summary>
    /// <value>Whether to enable answering machine beep detection</value>
    [JsonPropertyName("beepDetectionEnabled")]
    public bool? BeepDetectionEnabled { get; set; }



    /// <summary>
    /// Whether to enable answering machine detection
    /// </summary>
    /// <value>Whether to enable answering machine detection</value>
    [JsonPropertyName("amdSpeechDistinguishEnabled")]
    public bool? AmdSpeechDistinguishEnabled { get; set; }





    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ResponseSet {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Responses: ").Append(Responses).Append("\n");
        sb.Append("  BeepDetectionEnabled: ").Append(BeepDetectionEnabled).Append("\n");
        sb.Append("  AmdSpeechDistinguishEnabled: ").Append(AmdSpeechDistinguishEnabled).Append("\n");
        sb.Append("  LiveSpeakerDetectionMode: ").Append(LiveSpeakerDetectionMode).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as ResponseSet);
    }

    /// <summary>
    /// Returns true if ResponseSet instances are equal
    /// </summary>
    /// <param name="other">Instance of ResponseSet to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ResponseSet other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Id == other.Id ||
                Id != null &&
                Id.Equals(other.Id)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                DateModified == other.DateModified ||
                DateModified != null &&
                DateModified.Equals(other.DateModified)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Responses == other.Responses ||
                Responses != null &&
                Responses.SequenceEqual(other.Responses)
            ) &&
            (
                BeepDetectionEnabled == other.BeepDetectionEnabled ||
                BeepDetectionEnabled != null &&
                BeepDetectionEnabled.Equals(other.BeepDetectionEnabled)
            ) &&
            (
                AmdSpeechDistinguishEnabled == other.AmdSpeechDistinguishEnabled ||
                AmdSpeechDistinguishEnabled != null &&
                AmdSpeechDistinguishEnabled.Equals(other.AmdSpeechDistinguishEnabled)
            ) &&
            (
                LiveSpeakerDetectionMode == other.LiveSpeakerDetectionMode ||
                LiveSpeakerDetectionMode != null &&
                LiveSpeakerDetectionMode.Equals(other.LiveSpeakerDetectionMode)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
            if (Id != null)
            {
                hash = hash * 59 + Id.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (DateModified != null)
            {
                hash = hash * 59 + DateModified.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Responses != null)
            {
                hash = hash * 59 + Responses.GetHashCode();
            }

            if (BeepDetectionEnabled != null)
            {
                hash = hash * 59 + BeepDetectionEnabled.GetHashCode();
            }

            if (AmdSpeechDistinguishEnabled != null)
            {
                hash = hash * 59 + AmdSpeechDistinguishEnabled.GetHashCode();
            }

            if (LiveSpeakerDetectionMode != null)
            {
                hash = hash * 59 + LiveSpeakerDetectionMode.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
