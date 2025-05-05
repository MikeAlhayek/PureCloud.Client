using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Referrer
/// </summary>

public partial class Referrer : IEquatable<Referrer>
{
    /// <summary>
    /// Type of referrer (e.g. search, social).
    /// </summary>
    /// <value>Type of referrer (e.g. search, social).</value>
    
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
    /// Type of referrer (e.g. search, social).
    /// </summary>
    /// <value>Type of referrer (e.g. search, social).</value>
    [JsonPropertyName("medium")]
    public MediumEnum? Medium { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Referrer" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Referrer() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Referrer" /> class.
    /// </summary>
    /// <param name="Url">Referrer URL. (required).</param>
    /// <param name="Domain">Referrer URL domain. (required).</param>
    /// <param name="Hostname">Referrer URL hostname. (required).</param>
    /// <param name="Keywords">Referrer keywords..</param>
    /// <param name="Pathname">Referrer URL pathname. (required).</param>
    /// <param name="QueryString">Referrer URL querystring..</param>
    /// <param name="Fragment">Referrer URL fragment..</param>
    /// <param name="Name">Name of referrer (e.g. Yahoo!, Google, InfoSpace)..</param>
    /// <param name="Medium">Type of referrer (e.g. search, social). (required).</param>
    public Referrer(string Url = null, string Domain = null, string Hostname = null, string Keywords = null, string Pathname = null, string QueryString = null, string Fragment = null, string Name = null, MediumEnum? Medium = null)
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
    /// Referrer URL.
    /// </summary>
    /// <value>Referrer URL.</value>
    [JsonPropertyName("url")]
    public string Url { get; set; }



    /// <summary>
    /// Referrer URL domain.
    /// </summary>
    /// <value>Referrer URL domain.</value>
    [JsonPropertyName("domain")]
    public string Domain { get; set; }



    /// <summary>
    /// Referrer URL hostname.
    /// </summary>
    /// <value>Referrer URL hostname.</value>
    [JsonPropertyName("hostname")]
    public string Hostname { get; set; }



    /// <summary>
    /// Referrer keywords.
    /// </summary>
    /// <value>Referrer keywords.</value>
    [JsonPropertyName("keywords")]
    public string Keywords { get; set; }



    /// <summary>
    /// Referrer URL pathname.
    /// </summary>
    /// <value>Referrer URL pathname.</value>
    [JsonPropertyName("pathname")]
    public string Pathname { get; set; }



    /// <summary>
    /// Referrer URL querystring.
    /// </summary>
    /// <value>Referrer URL querystring.</value>
    [JsonPropertyName("queryString")]
    public string QueryString { get; set; }



    /// <summary>
    /// Referrer URL fragment.
    /// </summary>
    /// <value>Referrer URL fragment.</value>
    [JsonPropertyName("fragment")]
    public string Fragment { get; set; }



    /// <summary>
    /// Name of referrer (e.g. Yahoo!, Google, InfoSpace).
    /// </summary>
    /// <value>Name of referrer (e.g. Yahoo!, Google, InfoSpace).</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Referrer {\n");

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
        return Equals(obj as Referrer);
    }

    /// <summary>
    /// Returns true if Referrer instances are equal
    /// </summary>
    /// <param name="other">Instance of Referrer to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Referrer other)
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
