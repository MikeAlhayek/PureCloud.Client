using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// EventSession
/// </summary>
[DataContract]
public partial class EventSession : IEquatable<EventSession>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="EventSession" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected EventSession() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="EventSession" /> class.
    /// </summary>
    /// <param name="Id">The ID of the session. (required).</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="Type">Session types indicate the type or category of sessions (e.g. web, app). (required).</param>
    public EventSession(string Id = null, string SelfUri = null, string Type = null)
    {
        this.Id = Id;
        this.SelfUri = SelfUri;
        this.Type = Type;

    }



    /// <summary>
    /// The ID of the session.
    /// </summary>
    /// <value>The ID of the session.</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [DataMember(Name = "selfUri", EmitDefaultValue = false)]
    public string SelfUri { get; set; }



    /// <summary>
    /// Session types indicate the type or category of sessions (e.g. web, app).
    /// </summary>
    /// <value>Session types indicate the type or category of sessions (e.g. web, app).</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class EventSession {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return this.Equals(obj as EventSession);
    }

    /// <summary>
    /// Returns true if EventSession instances are equal
    /// </summary>
    /// <param name="other">Instance of EventSession to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(EventSession other)
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
                this.Type == other.Type ||
                this.Type != null &&
                this.Type.Equals(other.Type)
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

            if (this.Type != null)
            {
                hash = hash * 59 + this.Type.GetHashCode();
            }

            return hash;
        }
    }
}
