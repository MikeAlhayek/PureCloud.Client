using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Room
/// </summary>

public partial class Room : IEquatable<Room>
{
    /// <summary>
    /// The type of room
    /// </summary>
    /// <value>The type of room</value>
    
    public enum RoomTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Adhoc for "adhoc"
        /// </summary>
        [EnumMember(Value = "adhoc")]
        Adhoc,

        /// <summary>
        /// Enum Acd for "acd"
        /// </summary>
        [EnumMember(Value = "acd")]
        Acd,

        /// <summary>
        /// Enum Group for "group"
        /// </summary>
        [EnumMember(Value = "group")]
        Group,

        /// <summary>
        /// Enum Oneonone for "oneOnOne"
        /// </summary>
        [EnumMember(Value = "oneOnOne")]
        Oneonone,

        /// <summary>
        /// Enum Supervisorassistance for "supervisorAssistance"
        /// </summary>
        [EnumMember(Value = "supervisorAssistance")]
        Supervisorassistance
    }
    /// <summary>
    /// The type of room
    /// </summary>
    /// <value>The type of room</value>
    [JsonPropertyName("roomType")]
    public RoomTypeEnum? RoomType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Room" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="DateCreated">Room&#39;s created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="RoomType">The type of room.</param>
    /// <param name="Description">Room&#39;s description.</param>
    /// <param name="Subject">Room&#39;s subject.</param>
    /// <param name="ParticipantLimit">Room&#39;s size limit.</param>
    /// <param name="Owners">Room&#39;s owners.</param>
    /// <param name="PinnedMessages">Room&#39;s pinned messages.</param>
    /// <param name="Jid">The jid of the room.</param>
    public Room(string Name = null, DateTime? DateCreated = null, RoomTypeEnum? RoomType = null, string Description = null, string Subject = null, int? ParticipantLimit = null, List<UserReference> Owners = null, List<AddressableEntityRef> PinnedMessages = null, string Jid = null)
    {
        this.Name = Name;
        this.DateCreated = DateCreated;
        this.RoomType = RoomType;
        this.Description = Description;
        this.Subject = Subject;
        this.ParticipantLimit = ParticipantLimit;
        this.Owners = Owners;
        this.PinnedMessages = PinnedMessages;
        this.Jid = Jid;

    }



    /// <summary>
    /// The jid of the room if adhoc, the id of the group for group rooms
    /// </summary>
    /// <value>The jid of the room if adhoc, the id of the group for group rooms</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Room&#39;s created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Room&#39;s created time. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }





    /// <summary>
    /// Room&#39;s description
    /// </summary>
    /// <value>Room&#39;s description</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Room&#39;s subject
    /// </summary>
    /// <value>Room&#39;s subject</value>
    [JsonPropertyName("subject")]
    public string Subject { get; set; }



    /// <summary>
    /// Room&#39;s size limit
    /// </summary>
    /// <value>Room&#39;s size limit</value>
    [JsonPropertyName("participantLimit")]
    public int? ParticipantLimit { get; set; }



    /// <summary>
    /// Room&#39;s owners
    /// </summary>
    /// <value>Room&#39;s owners</value>
    [JsonPropertyName("owners")]
    public List<UserReference> Owners { get; set; }



    /// <summary>
    /// Room&#39;s pinned messages
    /// </summary>
    /// <value>Room&#39;s pinned messages</value>
    [JsonPropertyName("pinnedMessages")]
    public List<AddressableEntityRef> PinnedMessages { get; set; }



    /// <summary>
    /// The jid of the room
    /// </summary>
    /// <value>The jid of the room</value>
    [JsonPropertyName("jid")]
    public string Jid { get; set; }



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
        sb.Append("class Room {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  RoomType: ").Append(RoomType).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  Subject: ").Append(Subject).Append("\n");
        sb.Append("  ParticipantLimit: ").Append(ParticipantLimit).Append("\n");
        sb.Append("  Owners: ").Append(Owners).Append("\n");
        sb.Append("  PinnedMessages: ").Append(PinnedMessages).Append("\n");
        sb.Append("  Jid: ").Append(Jid).Append("\n");
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
        return Equals(obj as Room);
    }

    /// <summary>
    /// Returns true if Room instances are equal
    /// </summary>
    /// <param name="other">Instance of Room to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Room other)
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
                RoomType == other.RoomType ||
                RoomType != null &&
                RoomType.Equals(other.RoomType)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                Subject == other.Subject ||
                Subject != null &&
                Subject.Equals(other.Subject)
            ) &&
            (
                ParticipantLimit == other.ParticipantLimit ||
                ParticipantLimit != null &&
                ParticipantLimit.Equals(other.ParticipantLimit)
            ) &&
            (
                Owners == other.Owners ||
                Owners != null &&
                Owners.SequenceEqual(other.Owners)
            ) &&
            (
                PinnedMessages == other.PinnedMessages ||
                PinnedMessages != null &&
                PinnedMessages.SequenceEqual(other.PinnedMessages)
            ) &&
            (
                Jid == other.Jid ||
                Jid != null &&
                Jid.Equals(other.Jid)
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

            if (RoomType != null)
            {
                hash = hash * 59 + RoomType.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (Subject != null)
            {
                hash = hash * 59 + Subject.GetHashCode();
            }

            if (ParticipantLimit != null)
            {
                hash = hash * 59 + ParticipantLimit.GetHashCode();
            }

            if (Owners != null)
            {
                hash = hash * 59 + Owners.GetHashCode();
            }

            if (PinnedMessages != null)
            {
                hash = hash * 59 + PinnedMessages.GetHashCode();
            }

            if (Jid != null)
            {
                hash = hash * 59 + Jid.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
