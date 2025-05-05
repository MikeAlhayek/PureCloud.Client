using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// KnowledgeGuestSession
/// </summary>

public partial class KnowledgeGuestSession : IEquatable<KnowledgeGuestSession>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeGuestSession" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected KnowledgeGuestSession() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="KnowledgeGuestSession" /> class.
    /// </summary>
    /// <param name="App">The app where the session is started. (required).</param>
    /// <param name="CustomerId">An arbitrary ID for the customer starting the session. Used to track multiple sessions started by the same customer. (required).</param>
    /// <param name="PageUrl">URL of the page where the session is started..</param>
    /// <param name="Contexts">The session contexts..</param>
    /// <param name="JourneySessionId">Journey session ID. Used to get the segments of the customer to filter search results..</param>
    public KnowledgeGuestSession(KnowledgeGuestSessionApp App = null, string CustomerId = null, string PageUrl = null, List<KnowledgeGuestSessionContext> Contexts = null, string JourneySessionId = null)
    {
        this.App = App;
        this.CustomerId = CustomerId;
        this.PageUrl = PageUrl;
        this.Contexts = Contexts;
        this.JourneySessionId = JourneySessionId;

    }



    /// <summary>
    /// Session ID.
    /// </summary>
    /// <value>Session ID.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// The app where the session is started.
    /// </summary>
    /// <value>The app where the session is started.</value>
    [JsonPropertyName("app")]
    public KnowledgeGuestSessionApp App { get; set; }



    /// <summary>
    /// An arbitrary ID for the customer starting the session. Used to track multiple sessions started by the same customer.
    /// </summary>
    /// <value>An arbitrary ID for the customer starting the session. Used to track multiple sessions started by the same customer.</value>
    [JsonPropertyName("customerId")]
    public string CustomerId { get; set; }



    /// <summary>
    /// URL of the page where the session is started.
    /// </summary>
    /// <value>URL of the page where the session is started.</value>
    [JsonPropertyName("pageUrl")]
    public string PageUrl { get; set; }



    /// <summary>
    /// The session contexts.
    /// </summary>
    /// <value>The session contexts.</value>
    [JsonPropertyName("contexts")]
    public List<KnowledgeGuestSessionContext> Contexts { get; set; }



    /// <summary>
    /// Journey session ID. Used to get the segments of the customer to filter search results.
    /// </summary>
    /// <value>Journey session ID. Used to get the segments of the customer to filter search results.</value>
    [JsonPropertyName("journeySessionId")]
    public string JourneySessionId { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class KnowledgeGuestSession {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  App: ").Append(App).Append("\n");
        sb.Append("  CustomerId: ").Append(CustomerId).Append("\n");
        sb.Append("  PageUrl: ").Append(PageUrl).Append("\n");
        sb.Append("  Contexts: ").Append(Contexts).Append("\n");
        sb.Append("  JourneySessionId: ").Append(JourneySessionId).Append("\n");
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
        return Equals(obj as KnowledgeGuestSession);
    }

    /// <summary>
    /// Returns true if KnowledgeGuestSession instances are equal
    /// </summary>
    /// <param name="other">Instance of KnowledgeGuestSession to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(KnowledgeGuestSession other)
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
                App == other.App ||
                App != null &&
                App.Equals(other.App)
            ) &&
            (
                CustomerId == other.CustomerId ||
                CustomerId != null &&
                CustomerId.Equals(other.CustomerId)
            ) &&
            (
                PageUrl == other.PageUrl ||
                PageUrl != null &&
                PageUrl.Equals(other.PageUrl)
            ) &&
            (
                Contexts == other.Contexts ||
                Contexts != null &&
                Contexts.SequenceEqual(other.Contexts)
            ) &&
            (
                JourneySessionId == other.JourneySessionId ||
                JourneySessionId != null &&
                JourneySessionId.Equals(other.JourneySessionId)
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

            if (App != null)
            {
                hash = hash * 59 + App.GetHashCode();
            }

            if (CustomerId != null)
            {
                hash = hash * 59 + CustomerId.GetHashCode();
            }

            if (PageUrl != null)
            {
                hash = hash * 59 + PageUrl.GetHashCode();
            }

            if (Contexts != null)
            {
                hash = hash * 59 + Contexts.GetHashCode();
            }

            if (JourneySessionId != null)
            {
                hash = hash * 59 + JourneySessionId.GetHashCode();
            }

            return hash;
        }
    }
}
