using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// JourneyOutcomeEventsNotificationReferrer
/// </summary>

public partial class JourneyOutcomeEventsNotificationReferrer : IEquatable<JourneyOutcomeEventsNotificationReferrer>
{
    /// <summary>
    /// Gets or Sets Medium
    /// </summary>
    
    public enum MediumEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Internal for "internal"
        /// </summary>
        [EnumMember(Value = "internal")]
        Internal,

        /// <summary>
        /// Enum Search for "search"
        /// </summary>
        [EnumMember(Value = "search")]
        Search,

        /// <summary>
        /// Enum Social for "social"
        /// </summary>
        [EnumMember(Value = "social")]
        Social,

        /// <summary>
        /// Enum Email for "email"
        /// </summary>
        [EnumMember(Value = "email")]
        Email,

        /// <summary>
        /// Enum Unknown for "unknown"
        /// </summary>
        [EnumMember(Value = "unknown")]
        Unknown,

        /// <summary>
        /// Enum Paid for "paid"
        /// </summary>
        [EnumMember(Value = "paid")]
        Paid
    }
    /// <summary>
    /// Gets or Sets Medium
    /// </summary>
    [JsonPropertyName("medium")]
    public MediumEnum? Medium { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyOutcomeEventsNotificationReferrer" /> class.
    /// </summary>
    /// <param name="Url">Url.</param>
    /// <param name="Domain">Domain.</param>
    /// <param name="Hostname">Hostname.</param>
    /// <param name="Keywords">Keywords.</param>
    /// <param name="Pathname">Pathname.</param>
    /// <param name="QueryString">QueryString.</param>
    /// <param name="Fragment">Fragment.</param>
    /// <param name="Name">Name.</param>
    /// <param name="Medium">Medium.</param>
    public JourneyOutcomeEventsNotificationReferrer(string Url = null, string Domain = null, string Hostname = null, string Keywords = null, string Pathname = null, string QueryString = null, string Fragment = null, string Name = null, MediumEnum? Medium = null)
    {
        this.Url = Url;
        this.Domain = Domain;
        this.Hostname = Hostname;
        this.Keywords = Keywords;
        this.Pathname = Pathname;
        this.QueryString = QueryString;
        this.Fragment = Fragment;
        this.Name = Name;
        this.Medium = Medium;

    }



    /// <summary>
    /// Gets or Sets Url
    /// </summary>
    [JsonPropertyName("url")]
    public string Url { get; set; }



    /// <summary>
    /// Gets or Sets Domain
    /// </summary>
    [JsonPropertyName("domain")]
    public string Domain { get; set; }



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
    /// Gets or Sets Fragment
    /// </summary>
    [JsonPropertyName("fragment")]
    public string Fragment { get; set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyOutcomeEventsNotificationReferrer {\n");

        sb.Append("  Url: ").Append(Url).Append("\n");
        sb.Append("  Domain: ").Append(Domain).Append("\n");
        sb.Append("  Hostname: ").Append(Hostname).Append("\n");
        sb.Append("  Keywords: ").Append(Keywords).Append("\n");
        sb.Append("  Pathname: ").Append(Pathname).Append("\n");
        sb.Append("  QueryString: ").Append(QueryString).Append("\n");
        sb.Append("  Fragment: ").Append(Fragment).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Medium: ").Append(Medium).Append("\n");
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
        return Equals(obj as JourneyOutcomeEventsNotificationReferrer);
    }

    /// <summary>
    /// Returns true if JourneyOutcomeEventsNotificationReferrer instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyOutcomeEventsNotificationReferrer to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyOutcomeEventsNotificationReferrer other)
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
                Domain == other.Domain ||
                Domain != null &&
                Domain.Equals(other.Domain)
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
                Fragment == other.Fragment ||
                Fragment != null &&
                Fragment.Equals(other.Fragment)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Medium == other.Medium ||
                Medium != null &&
                Medium.Equals(other.Medium)
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

            if (Domain != null)
            {
                hash = hash * 59 + Domain.GetHashCode();
            }

            if (Hostname != null)
            {
                hash = hash * 59 + Hostname.GetHashCode();
            }

            if (Keywords != null)
            {
                hash = hash * 59 + Keywords.GetHashCode();
            }

            if (Pathname != null)
            {
                hash = hash * 59 + Pathname.GetHashCode();
            }

            if (QueryString != null)
            {
                hash = hash * 59 + QueryString.GetHashCode();
            }

            if (Fragment != null)
            {
                hash = hash * 59 + Fragment.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Medium != null)
            {
                hash = hash * 59 + Medium.GetHashCode();
            }

            return hash;
        }
    }
}
