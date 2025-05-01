using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// JourneyWebEventsNotificationOutcome
/// </summary>
[DataContract]
public partial class JourneyWebEventsNotificationOutcome : IEquatable<JourneyWebEventsNotificationOutcome>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyWebEventsNotificationOutcome" /> class.
    /// </summary>
    /// <param name="Id">Id.</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="DisplayName">DisplayName.</param>
    /// <param name="Version">Version.</param>
    public JourneyWebEventsNotificationOutcome(Guid? Id = null, string SelfUri = null, string DisplayName = null, string Version = null)
    {
        this.Id = Id;
        this.SelfUri = SelfUri;
        this.DisplayName = DisplayName;
        this.Version = Version;

    }



    /// <summary>
    /// Gets or Sets Id
    /// </summary>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public Guid? Id { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; set; }



    /// <summary>
    /// Gets or Sets DisplayName
    /// </summary>
    [DataMember(Name = "displayName", EmitDefaultValue = false)]
    public string DisplayName { get; set; }



    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public string Version { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyWebEventsNotificationOutcome {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
        return this.Equals(obj as JourneyWebEventsNotificationOutcome);
    }

    /// <summary>
    /// Returns true if JourneyWebEventsNotificationOutcome instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyWebEventsNotificationOutcome to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyWebEventsNotificationOutcome other)
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
                this.SelfUri == other.SelfUri ||
                this.SelfUri != null &&
                this.SelfUri.Equals(other.SelfUri)
            ) &&
            (
                this.DisplayName == other.DisplayName ||
                this.DisplayName != null &&
                this.DisplayName.Equals(other.DisplayName)
            ) &&
            (
                this.Version == other.Version ||
                this.Version != null &&
                this.Version.Equals(other.Version)
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

            if (this.SelfUri != null)
            {
                hash = hash * 59 + this.SelfUri.GetHashCode();
            }

            if (this.DisplayName != null)
            {
                hash = hash * 59 + this.DisplayName.GetHashCode();
            }

            if (this.Version != null)
            {
                hash = hash * 59 + this.Version.GetHashCode();
            }

            return hash;
        }
    }
}
