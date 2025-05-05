using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneySessionEventsNotificationPage
/// </summary>

public partial class JourneySessionEventsNotificationPage : IEquatable<JourneySessionEventsNotificationPage>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneySessionEventsNotificationPage" /> class.
    /// </summary>
    /// <param name="Url">Url.</param>
    /// <param name="Title">Title.</param>
    /// <param name="Domain">Domain.</param>
    /// <param name="Fragment">Fragment.</param>
    /// <param name="Hostname">Hostname.</param>
    /// <param name="Keywords">Keywords.</param>
    /// <param name="Lang">Lang.</param>
    /// <param name="Pathname">Pathname.</param>
    /// <param name="QueryString">QueryString.</param>
    /// <param name="Breadcrumb">Breadcrumb.</param>
    public JourneySessionEventsNotificationPage(string Url = null, string Title = null, string Domain = null, string Fragment = null, string Hostname = null, string Keywords = null, string Lang = null, string Pathname = null, string QueryString = null, List<string> Breadcrumb = null)
    {
        this.Url = Url;
        this.Title = Title;
        this.Domain = Domain;
        this.Fragment = Fragment;
        this.Hostname = Hostname;
        this.Keywords = Keywords;
        this.Lang = Lang;
        this.Pathname = Pathname;
        this.QueryString = QueryString;
        this.Breadcrumb = Breadcrumb;

    }



    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }



    /// <summary>
    /// Gets or Sets Title
    /// </summary>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// Gets or Sets Domain
    /// </summary>
    [JsonPropertyName("domain")]
    public string Domain { get; set; }



    /// <summary>
    /// Gets or Sets Fragment
    /// </summary>
    [JsonPropertyName("fragment")]
    public string Fragment { get; set; }



    /// <summary>
    /// Gets or Sets Hostname
    /// </summary>
    [JsonPropertyName("hostname")]
    public string Hostname { get; set; }



    /// <summary>
    /// Gets or Sets Keywords
    /// </summary>
    [JsonPropertyName("keywords")]
    public string Keywords { get; set; }



    /// <summary>
    /// Gets or Sets Lang
    /// </summary>
    [JsonPropertyName("lang")]
    public string Lang { get; set; }



    /// <summary>
    /// Gets or Sets Pathname
    /// </summary>
    [JsonPropertyName("pathname")]
    public string Pathname { get; set; }



    /// <summary>
    /// Gets or Sets QueryString
    /// </summary>
    [JsonPropertyName("queryString")]
    public string QueryString { get; set; }



    /// <summary>
    /// Gets or Sets Breadcrumb
    /// </summary>
    [JsonPropertyName("breadcrumb")]
    public List<string> Breadcrumb { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneySessionEventsNotificationPage {\n");

        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Domain: ").Append(Domain).Append("\n");
        sb.Append("  Fragment: ").Append(Fragment).Append("\n");
        sb.Append("  Hostname: ").Append(Hostname).Append("\n");
        sb.Append("  Keywords: ").Append(Keywords).Append("\n");
        sb.Append("  Lang: ").Append(Lang).Append("\n");
        sb.Append("  Pathname: ").Append(Pathname).Append("\n");
        sb.Append("  QueryString: ").Append(QueryString).Append("\n");
        sb.Append("  Breadcrumb: ").Append(Breadcrumb).Append("\n");
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
        return Equals(obj as JourneySessionEventsNotificationPage);
    }

    /// <summary>
    /// Returns true if JourneySessionEventsNotificationPage instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneySessionEventsNotificationPage to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneySessionEventsNotificationPage other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Url == other.Url ||
                Url != null &&
                Url.Equals(other.Url)
            ) &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Domain == other.Domain ||
                Domain != null &&
                Domain.Equals(other.Domain)
            ) &&
            (
                Fragment == other.Fragment ||
                Fragment != null &&
                Fragment.Equals(other.Fragment)
            ) &&
            (
                Hostname == other.Hostname ||
                Hostname != null &&
                Hostname.Equals(other.Hostname)
            ) &&
            (
                Keywords == other.Keywords ||
                Keywords != null &&
                Keywords.Equals(other.Keywords)
            ) &&
            (
                Lang == other.Lang ||
                Lang != null &&
                Lang.Equals(other.Lang)
            ) &&
            (
                Pathname == other.Pathname ||
                Pathname != null &&
                Pathname.Equals(other.Pathname)
            ) &&
            (
                QueryString == other.QueryString ||
                QueryString != null &&
                QueryString.Equals(other.QueryString)
            ) &&
            (
                Breadcrumb == other.Breadcrumb ||
                Breadcrumb != null &&
                Breadcrumb.SequenceEqual(other.Breadcrumb)
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
            if (Url != null)
            {
                hash = hash * 59 + Url.GetHashCode();
            }

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Domain != null)
            {
                hash = hash * 59 + Domain.GetHashCode();
            }

            if (Fragment != null)
            {
                hash = hash * 59 + Fragment.GetHashCode();
            }

            if (Hostname != null)
            {
                hash = hash * 59 + Hostname.GetHashCode();
            }

            if (Keywords != null)
            {
                hash = hash * 59 + Keywords.GetHashCode();
            }

            if (Lang != null)
            {
                hash = hash * 59 + Lang.GetHashCode();
            }

            if (Pathname != null)
            {
                hash = hash * 59 + Pathname.GetHashCode();
            }

            if (QueryString != null)
            {
                hash = hash * 59 + QueryString.GetHashCode();
            }

            if (Breadcrumb != null)
            {
                hash = hash * 59 + Breadcrumb.GetHashCode();
            }

            return hash;
        }
    }
}
