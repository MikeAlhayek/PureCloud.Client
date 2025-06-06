using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// HistoryEntry
/// </summary>

public partial class HistoryEntry : IEquatable<HistoryEntry>
{
    /// <summary>
    /// The action performed
    /// </summary>
    /// <value>The action performed</value>
    
    public enum ActionEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Checkin for "CHECKIN"
        /// </summary>
        [EnumMember(Value = "CHECKIN")]
        Checkin,

        /// <summary>
        /// Enum Checkout for "CHECKOUT"
        /// </summary>
        [EnumMember(Value = "CHECKOUT")]
        Checkout,

        /// <summary>
        /// Enum Create for "CREATE"
        /// </summary>
        [EnumMember(Value = "CREATE")]
        Create,

        /// <summary>
        /// Enum Deactivate for "DEACTIVATE"
        /// </summary>
        [EnumMember(Value = "DEACTIVATE")]
        Deactivate,

        /// <summary>
        /// Enum Debug for "DEBUG"
        /// </summary>
        [EnumMember(Value = "DEBUG")]
        Debug,

        /// <summary>
        /// Enum Delete for "DELETE"
        /// </summary>
        [EnumMember(Value = "DELETE")]
        Delete,

        /// <summary>
        /// Enum Publish for "PUBLISH"
        /// </summary>
        [EnumMember(Value = "PUBLISH")]
        Publish,

        /// <summary>
        /// Enum Revert for "REVERT"
        /// </summary>
        [EnumMember(Value = "REVERT")]
        Revert,

        /// <summary>
        /// Enum Save for "SAVE"
        /// </summary>
        [EnumMember(Value = "SAVE")]
        Save,

        /// <summary>
        /// Enum Transcode for "TRANSCODE"
        /// </summary>
        [EnumMember(Value = "TRANSCODE")]
        Transcode,

        /// <summary>
        /// Enum Update for "UPDATE"
        /// </summary>
        [EnumMember(Value = "UPDATE")]
        Update,

        /// <summary>
        /// Enum Upload for "UPLOAD"
        /// </summary>
        [EnumMember(Value = "UPLOAD")]
        Upload
    }
    /// <summary>
    /// The action performed
    /// </summary>
    /// <value>The action performed</value>
    [JsonPropertyName("action")]
    public ActionEnum? Action { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="HistoryEntry" /> class.
    /// </summary>
    /// <param name="Action">The action performed.</param>
    /// <param name="Resource">For actions performed not on the item itself, but on a sub-item, this field identifies the sub-item by name.  For example, for actions performed on prompt resources, this will be the prompt resource name..</param>
    /// <param name="Timestamp">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="User">User associated with this entry..</param>
    /// <param name="Client">OAuth client associated with this entry..</param>
    /// <param name="Version">Version.</param>
    /// <param name="Secure">Secure.</param>
    /// <param name="VirtualAgentEnabled">VirtualAgentEnabled.</param>
    public HistoryEntry(ActionEnum? Action = null, string Resource = null, DateTime? Timestamp = null, User User = null, DomainEntityRef Client = null, string Version = null, bool? Secure = null, bool? VirtualAgentEnabled = null)
    {
        this.Action = Action;
        this.Resource = Resource;
        this.Timestamp = Timestamp;
        this.User = User;
        this.Client = Client;
        this.Version = Version;
        this.Secure = Secure;
        this.VirtualAgentEnabled = VirtualAgentEnabled;

    }





    /// <summary>
    /// For actions performed not on the item itself, but on a sub-item, this field identifies the sub-item by name.  For example, for actions performed on prompt resources, this will be the prompt resource name.
    /// </summary>
    /// <value>For actions performed not on the item itself, but on a sub-item, this field identifies the sub-item by name.  For example, for actions performed on prompt resources, this will be the prompt resource name.</value>
    [JsonPropertyName("resource")]
    public string Resource { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("timestamp")]
    public DateTime? Timestamp { get; set; }



    /// <summary>
    /// User associated with this entry.
    /// </summary>
    /// <value>User associated with this entry.</value>
    [JsonPropertyName("user")]
    public User User { get; set; }



    /// <summary>
    /// OAuth client associated with this entry.
    /// </summary>
    /// <value>OAuth client associated with this entry.</value>
    [JsonPropertyName("client")]
    public DomainEntityRef Client { get; set; }



    /// <summary>
    /// Gets or Sets Version
    /// </summary>
    [JsonPropertyName("version")]
    public string Version { get; set; }



    /// <summary>
    /// Gets or Sets Secure
    /// </summary>
    [JsonPropertyName("secure")]
    public bool? Secure { get; set; }



    /// <summary>
    /// Gets or Sets VirtualAgentEnabled
    /// </summary>
    [JsonPropertyName("virtualAgentEnabled")]
    public bool? VirtualAgentEnabled { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class HistoryEntry {\n");

        sb.Append("  Action: ").Append(Action).Append("\n");
        sb.Append("  Resource: ").Append(Resource).Append("\n");
        sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Client: ").Append(Client).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  Secure: ").Append(Secure).Append("\n");
        sb.Append("  VirtualAgentEnabled: ").Append(VirtualAgentEnabled).Append("\n");
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
        return Equals(obj as HistoryEntry);
    }

    /// <summary>
    /// Returns true if HistoryEntry instances are equal
    /// </summary>
    /// <param name="other">Instance of HistoryEntry to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(HistoryEntry other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Action == other.Action ||
                Action != null &&
                Action.Equals(other.Action)
            ) &&
            (
                Resource == other.Resource ||
                Resource != null &&
                Resource.Equals(other.Resource)
            ) &&
            (
                Timestamp == other.Timestamp ||
                Timestamp != null &&
                Timestamp.Equals(other.Timestamp)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Client == other.Client ||
                Client != null &&
                Client.Equals(other.Client)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                Secure == other.Secure ||
                Secure != null &&
                Secure.Equals(other.Secure)
            ) &&
            (
                VirtualAgentEnabled == other.VirtualAgentEnabled ||
                VirtualAgentEnabled != null &&
                VirtualAgentEnabled.Equals(other.VirtualAgentEnabled)
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
            if (Action != null)
            {
                hash = hash * 59 + Action.GetHashCode();
            }

            if (Resource != null)
            {
                hash = hash * 59 + Resource.GetHashCode();
            }

            if (Timestamp != null)
            {
                hash = hash * 59 + Timestamp.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Client != null)
            {
                hash = hash * 59 + Client.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (Secure != null)
            {
                hash = hash * 59 + Secure.GetHashCode();
            }

            if (VirtualAgentEnabled != null)
            {
                hash = hash * 59 + VirtualAgentEnabled.GetHashCode();
            }

            return hash;
        }
    }
}
