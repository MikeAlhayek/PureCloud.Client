using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DialerResponsesetConfigChangeResponseSet
/// </summary>

public partial class DialerResponsesetConfigChangeResponseSet : IEquatable<DialerResponsesetConfigChangeResponseSet>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="DialerResponsesetConfigChangeResponseSet" /> class.
    /// </summary>
    /// <param name="Responses">Map of disposition identifiers to reactions. For example: {\&quot;disposition.classification.callable.person\&quot;: {\&quot;reactionType\&quot;: \&quot;transfer\&quot;}}.</param>
    /// <param name="BeepDetectionEnabled">When beep detection is enabled, answering machine detection will wait for the beep before transferring the call.</param>
    /// <param name="AdditionalProperties">AdditionalProperties.</param>
    /// <param name="Id">The globally unique identifier for the object..</param>
    /// <param name="Name">The UI-visible name of the object.</param>
    /// <param name="DateCreated">Creation time of the entity.</param>
    /// <param name="DateModified">Last modified time of the entity.</param>
    /// <param name="Version">Required for updates, must match the version number of the most recent update.</param>
    public DialerResponsesetConfigChangeResponseSet(Dictionary<string, DialerResponsesetConfigChangeReaction> Responses = null, bool? BeepDetectionEnabled = null, Dictionary<string, object> AdditionalProperties = null, string Id = null, string Name = null, DateTime? DateCreated = null, DateTime? DateModified = null, long? Version = null)
    {
        this.Responses = Responses;
        this.BeepDetectionEnabled = BeepDetectionEnabled;
        this.AdditionalProperties = AdditionalProperties;
        this.Id = Id;
        this.Name = Name;
        this.DateCreated = DateCreated;
        this.DateModified = DateModified;
        this.Version = Version;

    }



    /// <summary>
    /// Map of disposition identifiers to reactions. For example: {\&quot;disposition.classification.callable.person\&quot;: {\&quot;reactionType\&quot;: \&quot;transfer\&quot;}}
    /// </summary>
    /// <value>Map of disposition identifiers to reactions. For example: {\&quot;disposition.classification.callable.person\&quot;: {\&quot;reactionType\&quot;: \&quot;transfer\&quot;}}</value>
    [JsonPropertyName("responses")]
    public Dictionary<string, DialerResponsesetConfigChangeReaction> Responses { get; set; }



    /// <summary>
    /// When beep detection is enabled, answering machine detection will wait for the beep before transferring the call
    /// </summary>
    /// <value>When beep detection is enabled, answering machine detection will wait for the beep before transferring the call</value>
    [JsonPropertyName("beepDetectionEnabled")]
    public bool? BeepDetectionEnabled { get; set; }



    /// <summary>
    /// Gets or Sets AdditionalProperties
    /// </summary>
    [JsonPropertyName("additionalProperties")]
    public Dictionary<string, object> AdditionalProperties { get; set; }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The UI-visible name of the object
    /// </summary>
    /// <value>The UI-visible name of the object</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Creation time of the entity
    /// </summary>
    /// <value>Creation time of the entity</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }



    /// <summary>
    /// Last modified time of the entity
    /// </summary>
    /// <value>Last modified time of the entity</value>
    [JsonPropertyName("dateModified")]
    public DateTime? DateModified { get; set; }



    /// <summary>
    /// Required for updates, must match the version number of the most recent update
    /// </summary>
    /// <value>Required for updates, must match the version number of the most recent update</value>
    [JsonPropertyName("version")]
    public long? Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DialerResponsesetConfigChangeResponseSet {\n");

        sb.Append("  Responses: ").Append(Responses).Append("\n");
        sb.Append("  BeepDetectionEnabled: ").Append(BeepDetectionEnabled).Append("\n");
        sb.Append("  AdditionalProperties: ").Append(AdditionalProperties).Append("\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
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
        return Equals(obj as DialerResponsesetConfigChangeResponseSet);
    }

    /// <summary>
    /// Returns true if DialerResponsesetConfigChangeResponseSet instances are equal
    /// </summary>
    /// <param name="other">Instance of DialerResponsesetConfigChangeResponseSet to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DialerResponsesetConfigChangeResponseSet other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
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
                AdditionalProperties == other.AdditionalProperties ||
                AdditionalProperties != null &&
                AdditionalProperties.SequenceEqual(other.AdditionalProperties)
            ) &&
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
            if (Responses != null)
            {
                hash = hash * 59 + Responses.GetHashCode();
            }

            if (BeepDetectionEnabled != null)
            {
                hash = hash * 59 + BeepDetectionEnabled.GetHashCode();
            }

            if (AdditionalProperties != null)
            {
                hash = hash * 59 + AdditionalProperties.GetHashCode();
            }

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

            return hash;
        }
    }
}
