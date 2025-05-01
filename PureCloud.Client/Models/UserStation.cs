using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// UserStation
/// </summary>
[DataContract]
public partial class UserStation : IEquatable<UserStation>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserStation" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="Type">Type.</param>
    /// <param name="AssociatedUser">AssociatedUser.</param>
    /// <param name="AssociatedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DefaultUser">DefaultUser.</param>
    /// <param name="ProviderInfo">Provider-specific info for this station, e.g. { \&quot;edgeGroupId\&quot;: \&quot;ffe7b15c-a9cc-4f4c-88f5-781327819a49\&quot; }.</param>
    public UserStation(string Name = null, string Type = null, User AssociatedUser = null, DateTime? AssociatedDate = null, User DefaultUser = null, Dictionary<string, string> ProviderInfo = null)
    {
        this.Name = Name;
        this.Type = Type;
        this.AssociatedUser = AssociatedUser;
        this.AssociatedDate = AssociatedDate;
        this.DefaultUser = DefaultUser;
        this.ProviderInfo = ProviderInfo;

    }



    /// <summary>
    /// A globally unique identifier for this station
    /// </summary>
    /// <value>A globally unique identifier for this station</value>
    [DataMember(Name = "id", EmitDefaultValue = false)]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public string Type { get; set; }



    /// <summary>
    /// Gets or Sets AssociatedUser
    /// </summary>
    [DataMember(Name = "associatedUser", EmitDefaultValue = false)]
    public User AssociatedUser { get; set; }



    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "associatedDate", EmitDefaultValue = false)]
    public DateTime? AssociatedDate { get; set; }



    /// <summary>
    /// Gets or Sets DefaultUser
    /// </summary>
    [DataMember(Name = "defaultUser", EmitDefaultValue = false)]
    public User DefaultUser { get; set; }



    /// <summary>
    /// Provider-specific info for this station, e.g. { \&quot;edgeGroupId\&quot;: \&quot;ffe7b15c-a9cc-4f4c-88f5-781327819a49\&quot; }
    /// </summary>
    /// <value>Provider-specific info for this station, e.g. { \&quot;edgeGroupId\&quot;: \&quot;ffe7b15c-a9cc-4f4c-88f5-781327819a49\&quot; }</value>
    [DataMember(Name = "providerInfo", EmitDefaultValue = false)]
    public Dictionary<string, string> ProviderInfo { get; set; }



    /// <summary>
    /// The number of call appearances on the station.
    /// </summary>
    /// <value>The number of call appearances on the station.</value>
    [DataMember(Name = "webRtcCallAppearances", EmitDefaultValue = false)]
    public int? WebRtcCallAppearances { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserStation {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  AssociatedUser: ").Append(AssociatedUser).Append("\n");
        sb.Append("  AssociatedDate: ").Append(AssociatedDate).Append("\n");
        sb.Append("  DefaultUser: ").Append(DefaultUser).Append("\n");
        sb.Append("  ProviderInfo: ").Append(ProviderInfo).Append("\n");
        sb.Append("  WebRtcCallAppearances: ").Append(WebRtcCallAppearances).Append("\n");
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
        return Equals(obj as UserStation);
    }

    /// <summary>
    /// Returns true if UserStation instances are equal
    /// </summary>
    /// <param name="other">Instance of UserStation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserStation other)
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
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                AssociatedUser == other.AssociatedUser ||
                AssociatedUser != null &&
                AssociatedUser.Equals(other.AssociatedUser)
            ) &&
            (
                AssociatedDate == other.AssociatedDate ||
                AssociatedDate != null &&
                AssociatedDate.Equals(other.AssociatedDate)
            ) &&
            (
                DefaultUser == other.DefaultUser ||
                DefaultUser != null &&
                DefaultUser.Equals(other.DefaultUser)
            ) &&
            (
                ProviderInfo == other.ProviderInfo ||
                ProviderInfo != null &&
                ProviderInfo.SequenceEqual(other.ProviderInfo)
            ) &&
            (
                WebRtcCallAppearances == other.WebRtcCallAppearances ||
                WebRtcCallAppearances != null &&
                WebRtcCallAppearances.Equals(other.WebRtcCallAppearances)
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

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (AssociatedUser != null)
            {
                hash = hash * 59 + AssociatedUser.GetHashCode();
            }

            if (AssociatedDate != null)
            {
                hash = hash * 59 + AssociatedDate.GetHashCode();
            }

            if (DefaultUser != null)
            {
                hash = hash * 59 + DefaultUser.GetHashCode();
            }

            if (ProviderInfo != null)
            {
                hash = hash * 59 + ProviderInfo.GetHashCode();
            }

            if (WebRtcCallAppearances != null)
            {
                hash = hash * 59 + WebRtcCallAppearances.GetHashCode();
            }

            return hash;
        }
    }
}
