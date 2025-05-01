using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CommonAlertBulkUpdateRequest
/// </summary>
[DataContract]
public partial class CommonAlertBulkUpdateRequest : IEquatable<CommonAlertBulkUpdateRequest>
{
    /// <summary>
    /// The action to take
    /// </summary>
    /// <value>The action to take</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Mute for "Mute"
        /// </summary>
        [EnumMember(Value = "Mute")]
        Mute,

        /// <summary>
        /// Enum Snooze for "Snooze"
        /// </summary>
        [EnumMember(Value = "Snooze")]
        Snooze,

        /// <summary>
        /// Enum Unread for "Unread"
        /// </summary>
        [EnumMember(Value = "Unread")]
        Unread
    }
    /// <summary>
    /// The action to take
    /// </summary>
    /// <value>The action to take</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="CommonAlertBulkUpdateRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CommonAlertBulkUpdateRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="CommonAlertBulkUpdateRequest" /> class.
    /// </summary>
    /// <param name="Type">The action to take (required).</param>
    /// <param name="AlertIds">The user supplied alert ids to be muted (required).</param>
    /// <param name="MuteSnooze">The fields need for a mute or snooze requests.</param>
    /// <param name="Unread">The fields need for an unread update requests.</param>
    public CommonAlertBulkUpdateRequest(TypeEnum? Type = null, List<string> AlertIds = null, MuteSnoozeFields MuteSnooze = null, UnreadFields Unread = null)
    {
        this.Type = Type;
        this.AlertIds = AlertIds;
        this.MuteSnooze = MuteSnooze;
        this.Unread = Unread;

    }





    /// <summary>
    /// The user supplied alert ids to be muted
    /// </summary>
    /// <value>The user supplied alert ids to be muted</value>
    [DataMember(Name = "alertIds", EmitDefaultValue = false)]
    public List<string> AlertIds { get; set; }



    /// <summary>
    /// The fields need for a mute or snooze requests
    /// </summary>
    /// <value>The fields need for a mute or snooze requests</value>
    [DataMember(Name = "muteSnooze", EmitDefaultValue = false)]
    public MuteSnoozeFields MuteSnooze { get; set; }



    /// <summary>
    /// The fields need for an unread update requests
    /// </summary>
    /// <value>The fields need for an unread update requests</value>
    [DataMember(Name = "unread", EmitDefaultValue = false)]
    public UnreadFields Unread { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CommonAlertBulkUpdateRequest {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  AlertIds: ").Append(AlertIds).Append("\n");
        sb.Append("  MuteSnooze: ").Append(MuteSnooze).Append("\n");
        sb.Append("  Unread: ").Append(Unread).Append("\n");
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
        return Equals(obj as CommonAlertBulkUpdateRequest);
    }

    /// <summary>
    /// Returns true if CommonAlertBulkUpdateRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of CommonAlertBulkUpdateRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CommonAlertBulkUpdateRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                AlertIds == other.AlertIds ||
                AlertIds != null &&
                AlertIds.SequenceEqual(other.AlertIds)
            ) &&
            (
                MuteSnooze == other.MuteSnooze ||
                MuteSnooze != null &&
                MuteSnooze.Equals(other.MuteSnooze)
            ) &&
            (
                Unread == other.Unread ||
                Unread != null &&
                Unread.Equals(other.Unread)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (AlertIds != null)
            {
                hash = hash * 59 + AlertIds.GetHashCode();
            }

            if (MuteSnooze != null)
            {
                hash = hash * 59 + MuteSnooze.GetHashCode();
            }

            if (Unread != null)
            {
                hash = hash * 59 + Unread.GetHashCode();
            }

            return hash;
        }
    }
}
