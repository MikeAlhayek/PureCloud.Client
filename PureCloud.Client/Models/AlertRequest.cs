using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AlertRequest
/// </summary>
[DataContract]
public partial class AlertRequest : IEquatable<AlertRequest>
{
    /// <summary>
    /// The action being taken on the alert.
    /// </summary>
    /// <value>The action being taken on the alert.</value>
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
    /// The action being taken on the alert.
    /// </summary>
    /// <value>The action being taken on the alert.</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="AlertRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AlertRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AlertRequest" /> class.
    /// </summary>
    /// <param name="Type">The action being taken on the alert. (required).</param>
    /// <param name="DateStart">The start date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="DateEnd">The end date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    /// <param name="Unread">The fields need for an unread update requests.</param>
    /// <param name="ValidRequest">ValidRequest.</param>
    public AlertRequest(TypeEnum? Type = null, DateTime? DateStart = null, DateTime? DateEnd = null, UnreadFields Unread = null, bool? ValidRequest = null)
    {
        this.Type = Type;
        this.DateStart = DateStart;
        this.DateEnd = DateEnd;
        this.Unread = Unread;
        this.ValidRequest = ValidRequest;

    }





    /// <summary>
    /// The start date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The start date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateStart", EmitDefaultValue = false)]
    public DateTime? DateStart { get; set; }



    /// <summary>
    /// The end date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The end date of the mute/snooze period. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [DataMember(Name = "dateEnd", EmitDefaultValue = false)]
    public DateTime? DateEnd { get; set; }



    /// <summary>
    /// The fields need for an unread update requests
    /// </summary>
    /// <value>The fields need for an unread update requests</value>
    [DataMember(Name = "unread", EmitDefaultValue = false)]
    public UnreadFields Unread { get; set; }



    /// <summary>
    /// Gets or Sets ValidRequest
    /// </summary>
    [DataMember(Name = "validRequest", EmitDefaultValue = false)]
    public bool? ValidRequest { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AlertRequest {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  DateStart: ").Append(DateStart).Append("\n");
        sb.Append("  DateEnd: ").Append(DateEnd).Append("\n");
        sb.Append("  Unread: ").Append(Unread).Append("\n");
        sb.Append("  ValidRequest: ").Append(ValidRequest).Append("\n");
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
        return Equals(obj as AlertRequest);
    }

    /// <summary>
    /// Returns true if AlertRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of AlertRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AlertRequest other)
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
                DateStart == other.DateStart ||
                DateStart != null &&
                DateStart.Equals(other.DateStart)
            ) &&
            (
                DateEnd == other.DateEnd ||
                DateEnd != null &&
                DateEnd.Equals(other.DateEnd)
            ) &&
            (
                Unread == other.Unread ||
                Unread != null &&
                Unread.Equals(other.Unread)
            ) &&
            (
                ValidRequest == other.ValidRequest ||
                ValidRequest != null &&
                ValidRequest.Equals(other.ValidRequest)
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

            if (DateStart != null)
            {
                hash = hash * 59 + DateStart.GetHashCode();
            }

            if (DateEnd != null)
            {
                hash = hash * 59 + DateEnd.GetHashCode();
            }

            if (Unread != null)
            {
                hash = hash * 59 + Unread.GetHashCode();
            }

            if (ValidRequest != null)
            {
                hash = hash * 59 + ValidRequest.GetHashCode();
            }

            return hash;
        }
    }
}
