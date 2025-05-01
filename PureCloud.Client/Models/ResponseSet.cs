using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// ResponseSet
/// </summary>
[DataContract]
public partial class ResponseSet : IEquatable<ResponseSet>
{
    /// <summary>
    /// Setting level of live speaker detection based on ringbacks
    /// </summary>
    /// <value>Setting level of live speaker detection based on ringbacks</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
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
    [DataMember(Name = "liveSpeakerDetectionMode", EmitDefaultValue = false)]
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
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// The name of the ResponseSet.
    /// </summary>
    /// <value>The name of the ResponseSet.</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Creation time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Last modified time of the entity. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public int? Version { get; set; }



    /// <summary>
    /// Map of disposition identifiers to reactions. For example: {\&quot;disposition.classification.callable.person\&quot;: {\&quot;reactionType\&quot;: \&quot;transfer\&quot;}}.
    /// </summary>
    /// <value>Map of disposition identifiers to reactions. For example: {\&quot;disposition.classification.callable.person\&quot;: {\&quot;reactionType\&quot;: \&quot;transfer\&quot;}}.</value>
    [DataMember(Name = "responses", EmitDefaultValue = false)]
    public Dictionary<string, Reaction> Responses { get; set; }



    /// <summary>
    /// Whether to enable answering machine beep detection
    /// </summary>
    /// <value>Whether to enable answering machine beep detection</value>
    [DataMember(Name = "beepDetectionEnabled", EmitDefaultValue = false)]
    public bool? BeepDetectionEnabled { get; set; }



    /// <summary>
    /// Whether to enable answering machine detection
    /// </summary>
    /// <value>Whether to enable answering machine detection</value>
    [DataMember(Name = "amdSpeechDistinguishEnabled", EmitDefaultValue = false)]
    public bool? AmdSpeechDistinguishEnabled { get; set; }





    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }


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
        return this.Equals(obj as ResponseSet);
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
                this.Id == other.Id ||
                this.Id != null &&
                this.Id.Equals(other.Id)
            ) &&
            (
                this.Name == other.Name ||
                this.Name != null &&
                this.Name.Equals(other.Name)
            ) &&
            (
                this.DateCreated == other.DateCreated ||
                this.DateCreated != null &&
                this.DateCreated.Equals(other.DateCreated)
            ) &&
            (
                this.DateModified == other.DateModified ||
                this.DateModified != null &&
                this.DateModified.Equals(other.DateModified)
            ) &&
            (
                this.Version == other.Version ||
                this.Version != null &&
                this.Version.Equals(other.Version)
            ) &&
            (
                this.Responses == other.Responses ||
                this.Responses != null &&
                this.Responses.SequenceEqual(other.Responses)
            ) &&
            (
                this.BeepDetectionEnabled == other.BeepDetectionEnabled ||
                this.BeepDetectionEnabled != null &&
                this.BeepDetectionEnabled.Equals(other.BeepDetectionEnabled)
            ) &&
            (
                this.AmdSpeechDistinguishEnabled == other.AmdSpeechDistinguishEnabled ||
                this.AmdSpeechDistinguishEnabled != null &&
                this.AmdSpeechDistinguishEnabled.Equals(other.AmdSpeechDistinguishEnabled)
            ) &&
            (
                this.LiveSpeakerDetectionMode == other.LiveSpeakerDetectionMode ||
                this.LiveSpeakerDetectionMode != null &&
                this.LiveSpeakerDetectionMode.Equals(other.LiveSpeakerDetectionMode)
            ) &&
            (
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
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
            if (this.Id != null)
            {
                hash = hash * 59 + this.Id.GetHashCode();
            }

            if (this.Name != null)
            {
                hash = hash * 59 + this.Name.GetHashCode();
            }

            if (this.DateCreated != null)
            {
                hash = hash * 59 + this.DateCreated.GetHashCode();
            }

            if (this.DateModified != null)
            {
                hash = hash * 59 + this.DateModified.GetHashCode();
            }

            if (this.Version != null)
            {
                hash = hash * 59 + this.Version.GetHashCode();
            }

            if (this.Responses != null)
            {
                hash = hash * 59 + this.Responses.GetHashCode();
            }

            if (this.BeepDetectionEnabled != null)
            {
                hash = hash * 59 + this.BeepDetectionEnabled.GetHashCode();
            }

            if (this.AmdSpeechDistinguishEnabled != null)
            {
                hash = hash * 59 + this.AmdSpeechDistinguishEnabled.GetHashCode();
            }

            if (this.LiveSpeakerDetectionMode != null)
            {
                hash = hash * 59 + this.LiveSpeakerDetectionMode.GetHashCode();
            }

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
