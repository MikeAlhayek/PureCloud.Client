using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// PresenceSettings
/// </summary>

public partial class PresenceSettings : IEquatable<PresenceSettings>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="PresenceSettings" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="RestorePresenceSettings">The settings for the restore presence feature.</param>
    public PresenceSettings(string Name = null, RestorePresenceSettings RestorePresenceSettings = null)
    {
        this.Name = Name;
        this.RestorePresenceSettings = RestorePresenceSettings;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// The settings for the restore presence feature
    /// </summary>
    /// <value>The settings for the restore presence feature</value>
    [JsonPropertyName("restorePresenceSettings")]
    public RestorePresenceSettings RestorePresenceSettings { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PresenceSettings {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  RestorePresenceSettings: ").Append(RestorePresenceSettings).Append("\n");
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
        return Equals(obj as PresenceSettings);
    }

    /// <summary>
    /// Returns true if PresenceSettings instances are equal
    /// </summary>
    /// <param name="other">Instance of PresenceSettings to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PresenceSettings other)
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
                RestorePresenceSettings == other.RestorePresenceSettings ||
                RestorePresenceSettings != null &&
                RestorePresenceSettings.Equals(other.RestorePresenceSettings)
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

            if (RestorePresenceSettings != null)
            {
                hash = hash * 59 + RestorePresenceSettings.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
