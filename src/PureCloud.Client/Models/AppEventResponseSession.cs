using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// AppEventResponseSession
/// </summary>

public partial class AppEventResponseSession : IEquatable<AppEventResponseSession>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="AppEventResponseSession" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AppEventResponseSession() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="AppEventResponseSession" /> class.
    /// </summary>
    /// <param name="Id">ID of the app session. (required).</param>
    /// <param name="DurationInSeconds">Indicates how long the customer has been in the app within this session. (required).</param>
    /// <param name="EventCount">The count of all events recorded during this session. (required).</param>
    /// <param name="ScreenviewCount">The count of all screen views recorded during this session. (required).</param>
    /// <param name="Referrer">The referrer of the first event in the app session..</param>
    /// <param name="CreatedDate">UTC timestamp of the session&#39;s first event, that is when the session starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z (required).</param>
    public AppEventResponseSession(string Id = null, int? DurationInSeconds = null, int? EventCount = null, int? ScreenviewCount = null, Referrer Referrer = null, DateTime? CreatedDate = null)
    {
        this.Id = Id;
        this.DurationInSeconds = DurationInSeconds;
        this.EventCount = EventCount;
        this.ScreenviewCount = ScreenviewCount;
        this.Referrer = Referrer;
        this.CreatedDate = CreatedDate;

    }



    /// <summary>
    /// ID of the app session.
    /// </summary>
    /// <value>ID of the app session.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Indicates how long the customer has been in the app within this session.
    /// </summary>
    /// <value>Indicates how long the customer has been in the app within this session.</value>
    [JsonPropertyName("durationInSeconds")]
    public int? DurationInSeconds { get; set; }



    /// <summary>
    /// The count of all events recorded during this session.
    /// </summary>
    /// <value>The count of all events recorded during this session.</value>
    [JsonPropertyName("eventCount")]
    public int? EventCount { get; set; }



    /// <summary>
    /// The count of all screen views recorded during this session.
    /// </summary>
    /// <value>The count of all screen views recorded during this session.</value>
    [JsonPropertyName("screenviewCount")]
    public int? ScreenviewCount { get; set; }



    /// <summary>
    /// The referrer of the first event in the app session.
    /// </summary>
    /// <value>The referrer of the first event in the app session.</value>
    [JsonPropertyName("referrer")]
    public Referrer Referrer { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }



    /// <summary>
    /// UTC timestamp of the session&#39;s first event, that is when the session starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>UTC timestamp of the session&#39;s first event, that is when the session starts. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("createdDate")]
    public DateTime? CreatedDate { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AppEventResponseSession {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  DurationInSeconds: ").Append(DurationInSeconds).Append("\n");
        sb.Append("  EventCount: ").Append(EventCount).Append("\n");
        sb.Append("  ScreenviewCount: ").Append(ScreenviewCount).Append("\n");
        sb.Append("  Referrer: ").Append(Referrer).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  CreatedDate: ").Append(CreatedDate).Append("\n");
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
        return Equals(obj as AppEventResponseSession);
    }

    /// <summary>
    /// Returns true if AppEventResponseSession instances are equal
    /// </summary>
    /// <param name="other">Instance of AppEventResponseSession to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AppEventResponseSession other)
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
                DurationInSeconds == other.DurationInSeconds ||
                DurationInSeconds != null &&
                DurationInSeconds.Equals(other.DurationInSeconds)
            ) &&
            (
                EventCount == other.EventCount ||
                EventCount != null &&
                EventCount.Equals(other.EventCount)
            ) &&
            (
                ScreenviewCount == other.ScreenviewCount ||
                ScreenviewCount != null &&
                ScreenviewCount.Equals(other.ScreenviewCount)
            ) &&
            (
                Referrer == other.Referrer ||
                Referrer != null &&
                Referrer.Equals(other.Referrer)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                CreatedDate == other.CreatedDate ||
                CreatedDate != null &&
                CreatedDate.Equals(other.CreatedDate)
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

            if (DurationInSeconds != null)
            {
                hash = hash * 59 + DurationInSeconds.GetHashCode();
            }

            if (EventCount != null)
            {
                hash = hash * 59 + EventCount.GetHashCode();
            }

            if (ScreenviewCount != null)
            {
                hash = hash * 59 + ScreenviewCount.GetHashCode();
            }

            if (Referrer != null)
            {
                hash = hash * 59 + Referrer.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (CreatedDate != null)
            {
                hash = hash * 59 + CreatedDate.GetHashCode();
            }

            return hash;
        }
    }
}
