using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ChatItem
/// </summary>

public partial class ChatItem : IEquatable<ChatItem>
{
    /// <summary>
    /// The type of chat
    /// </summary>
    /// <value>The type of chat</value>
    
    public enum ChatTypeEnum
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
    /// The type of chat
    /// </summary>
    /// <value>The type of chat</value>
    [JsonPropertyName("chatType")]
    public ChatTypeEnum? ChatType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ChatItem" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ChatItem() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ChatItem" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Open">If the chat is open (required).</param>
    /// <param name="Favorite">The favorite entity for the chat, only appears if the chat is favorited.</param>
    /// <param name="Images">Avatar images for the chat.</param>
    /// <param name="DateLastMessage">The date of the last message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateClosed">The date the chat was closed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="User">The other 1on1 user.</param>
    /// <param name="Room">The room of the chat.</param>
    /// <param name="ChatType">The type of chat (required).</param>
    public ChatItem(string Name = null, bool? Open = null, ChatFavorite Favorite = null, List<Image> Images = null, DateTime? DateLastMessage = null, DateTime? DateClosed = null, ChatUserRef User = null, Room Room = null, ChatTypeEnum? ChatType = null)
    {
        this.Name = Name;
        this.Open = Open;
        this.Favorite = Favorite;
        this.Images = Images;
        this.DateLastMessage = DateLastMessage;
        this.DateClosed = DateClosed;
        this.User = User;
        this.Room = Room;
        this.ChatType = ChatType;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// If the chat is open
    /// </summary>
    /// <value>If the chat is open</value>
    [JsonPropertyName("open")]
    public bool? Open { get; set; }



    /// <summary>
    /// The favorite entity for the chat, only appears if the chat is favorited
    /// </summary>
    /// <value>The favorite entity for the chat, only appears if the chat is favorited</value>
    [JsonPropertyName("favorite")]
    public ChatFavorite Favorite { get; set; }



    /// <summary>
    /// Avatar images for the chat
    /// </summary>
    /// <value>Avatar images for the chat</value>
    [JsonPropertyName("images")]
    public List<Image> Images { get; set; }



    /// <summary>
    /// The date of the last message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date of the last message. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateLastMessage")]
    public DateTime? DateLastMessage { get; set; }



    /// <summary>
    /// The date the chat was closed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date the chat was closed. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateClosed")]
    public DateTime? DateClosed { get; set; }



    /// <summary>
    /// The other 1on1 user
    /// </summary>
    /// <value>The other 1on1 user</value>
    [JsonPropertyName("user")]
    public ChatUserRef User { get; set; }



    /// <summary>
    /// The room of the chat
    /// </summary>
    /// <value>The room of the chat</value>
    [JsonPropertyName("room")]
    public Room Room { get; set; }





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
        sb.Append("class ChatItem {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Open: ").Append(Open).Append("\n");
        sb.Append("  Favorite: ").Append(Favorite).Append("\n");
        sb.Append("  Images: ").Append(Images).Append("\n");
        sb.Append("  DateLastMessage: ").Append(DateLastMessage).Append("\n");
        sb.Append("  DateClosed: ").Append(DateClosed).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Room: ").Append(Room).Append("\n");
        sb.Append("  ChatType: ").Append(ChatType).Append("\n");
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
        return Equals(obj as ChatItem);
    }

    /// <summary>
    /// Returns true if ChatItem instances are equal
    /// </summary>
    /// <param name="other">Instance of ChatItem to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ChatItem other)
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
                Open == other.Open ||
                Open != null &&
                Open.Equals(other.Open)
            ) &&
            (
                Favorite == other.Favorite ||
                Favorite != null &&
                Favorite.Equals(other.Favorite)
            ) &&
            (
                Images == other.Images ||
                Images != null &&
                Images.SequenceEqual(other.Images)
            ) &&
            (
                DateLastMessage == other.DateLastMessage ||
                DateLastMessage != null &&
                DateLastMessage.Equals(other.DateLastMessage)
            ) &&
            (
                DateClosed == other.DateClosed ||
                DateClosed != null &&
                DateClosed.Equals(other.DateClosed)
            ) &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Room == other.Room ||
                Room != null &&
                Room.Equals(other.Room)
            ) &&
            (
                ChatType == other.ChatType ||
                ChatType != null &&
                ChatType.Equals(other.ChatType)
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

            if (Open != null)
            {
                hash = hash * 59 + Open.GetHashCode();
            }

            if (Favorite != null)
            {
                hash = hash * 59 + Favorite.GetHashCode();
            }

            if (Images != null)
            {
                hash = hash * 59 + Images.GetHashCode();
            }

            if (DateLastMessage != null)
            {
                hash = hash * 59 + DateLastMessage.GetHashCode();
            }

            if (DateClosed != null)
            {
                hash = hash * 59 + DateClosed.GetHashCode();
            }

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Room != null)
            {
                hash = hash * 59 + Room.GetHashCode();
            }

            if (ChatType != null)
            {
                hash = hash * 59 + ChatType.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
