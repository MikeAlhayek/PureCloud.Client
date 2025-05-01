using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Messaging Setting for messaging platform integrations
/// </summary>
[DataContract]
public partial class MessagingSettingReference : IEquatable<MessagingSettingReference>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingSettingReference" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected MessagingSettingReference() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="MessagingSettingReference" /> class.
    /// </summary>
    /// <param name="Id">The messaging Setting unique identifier associated with this integration (required).</param>
    /// <param name="Version">Version number.</param>
    /// <param name="Content">Settings relating to message contents.</param>
    /// <param name="Event">Settings relating to events which may occur.</param>
    public MessagingSettingReference(string Id = null, string Version = null, ContentSetting Content = null, EventSetting Event = null)
    {
        this.Id = Id;
        this.Version = Version;
        this.Content = Content;
        this.Event = Event;

    }



    /// <summary>
    /// The messaging Setting unique identifier associated with this integration
    /// </summary>
    /// <value>The messaging Setting unique identifier associated with this integration</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// The messaging Setting profile name
    /// </summary>
    /// <value>The messaging Setting profile name</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; private set; }



    /// <summary>
    /// The messaging Setting profile URI
    /// </summary>
    /// <value>The messaging Setting profile URI</value>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; private set; }



    /// <summary>
    /// Date this messaging Setting was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this messaging Setting was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public DateTime? DateCreated { get; private set; }



    /// <summary>
    /// Date this messaging Setting was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date this messaging Setting was modified. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateModified", EmitDefaultValue = false)]
    public DateTime? DateModified { get; private set; }



    /// <summary>
    /// Version number
    /// </summary>
    /// <value>Version number</value>
    [DataMember(Name = "version", EmitDefaultValue = false)]
    public string Version { get; set; }



    /// <summary>
    /// User reference that created this Setting
    /// </summary>
    /// <value>User reference that created this Setting</value>
    [DataMember(Name = "createdBy", EmitDefaultValue = false)]
    public DomainEntityRef CreatedBy { get; private set; }



    /// <summary>
    /// User reference that modified this Setting
    /// </summary>
    /// <value>User reference that modified this Setting</value>
    [DataMember(Name = "updatedBy", EmitDefaultValue = false)]
    public DomainEntityRef UpdatedBy { get; private set; }



    /// <summary>
    /// Settings relating to message contents
    /// </summary>
    /// <value>Settings relating to message contents</value>
    [DataMember(Name = "content", EmitDefaultValue = false)]
    public ContentSetting Content { get; set; }



    /// <summary>
    /// Settings relating to events which may occur
    /// </summary>
    /// <value>Settings relating to events which may occur</value>
    [DataMember(Name = "event", EmitDefaultValue = false)]
    public EventSetting Event { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class MessagingSettingReference {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  DateModified: ").Append(DateModified).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  UpdatedBy: ").Append(UpdatedBy).Append("\n");
        sb.Append("  Content: ").Append(Content).Append("\n");
        sb.Append("  Event: ").Append(Event).Append("\n");
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
        return Equals(obj as MessagingSettingReference);
    }

    /// <summary>
    /// Returns true if MessagingSettingReference instances are equal
    /// </summary>
    /// <param name="other">Instance of MessagingSettingReference to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(MessagingSettingReference other)
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
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                UpdatedBy == other.UpdatedBy ||
                UpdatedBy != null &&
                UpdatedBy.Equals(other.UpdatedBy)
            ) &&
            (
                Content == other.Content ||
                Content != null &&
                Content.Equals(other.Content)
            ) &&
            (
                Event == other.Event ||
                Event != null &&
                Event.Equals(other.Event)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
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

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (UpdatedBy != null)
            {
                hash = hash * 59 + UpdatedBy.GetHashCode();
            }

            if (Content != null)
            {
                hash = hash * 59 + Content.GetHashCode();
            }

            if (Event != null)
            {
                hash = hash * 59 + Event.GetHashCode();
            }

            return hash;
        }
    }
}
