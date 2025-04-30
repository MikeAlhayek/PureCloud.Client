using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// Referrer
    /// </summary>
    [DataContract]
    public partial class Referrer :  IEquatable<Referrer>
    {
        /// <summary>
        /// Type of referrer (e.g. search, social).
        /// </summary>
        /// <value>Type of referrer (e.g. search, social).</value>
        [JsonConverter(typeof(JsonStringEnumConverter))]
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
        [DataMember(Name="medium", EmitDefaultValue=false)]
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
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }



        /// <summary>
        /// Referrer URL domain.
        /// </summary>
        /// <value>Referrer URL domain.</value>
        [DataMember(Name="domain", EmitDefaultValue=false)]
        public string Domain { get; set; }



        /// <summary>
        /// Referrer URL hostname.
        /// </summary>
        /// <value>Referrer URL hostname.</value>
        [DataMember(Name="hostname", EmitDefaultValue=false)]
        public string Hostname { get; set; }



        /// <summary>
        /// Referrer keywords.
        /// </summary>
        /// <value>Referrer keywords.</value>
        [DataMember(Name="keywords", EmitDefaultValue=false)]
        public string Keywords { get; set; }



        /// <summary>
        /// Referrer URL pathname.
        /// </summary>
        /// <value>Referrer URL pathname.</value>
        [DataMember(Name="pathname", EmitDefaultValue=false)]
        public string Pathname { get; set; }



        /// <summary>
        /// Referrer URL querystring.
        /// </summary>
        /// <value>Referrer URL querystring.</value>
        [DataMember(Name="queryString", EmitDefaultValue=false)]
        public string QueryString { get; set; }



        /// <summary>
        /// Referrer URL fragment.
        /// </summary>
        /// <value>Referrer URL fragment.</value>
        [DataMember(Name="fragment", EmitDefaultValue=false)]
        public string Fragment { get; set; }



        /// <summary>
        /// Name of referrer (e.g. Yahoo!, Google, InfoSpace).
        /// </summary>
        /// <value>Name of referrer (e.g. Yahoo!, Google, InfoSpace).</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
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
            return this.Equals(obj as Referrer);
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
                return false;

            return true &&
                (
                    this.Url == other.Url ||
                    this.Url != null &&
                    this.Url.Equals(other.Url)
                ) &&
                (
                    this.Domain == other.Domain ||
                    this.Domain != null &&
                    this.Domain.Equals(other.Domain)
                ) &&
                (
                    this.Hostname == other.Hostname ||
                    this.Hostname != null &&
                    this.Hostname.Equals(other.Hostname)
                ) &&
                (
                    this.Keywords == other.Keywords ||
                    this.Keywords != null &&
                    this.Keywords.Equals(other.Keywords)
                ) &&
                (
                    this.Pathname == other.Pathname ||
                    this.Pathname != null &&
                    this.Pathname.Equals(other.Pathname)
                ) &&
                (
                    this.QueryString == other.QueryString ||
                    this.QueryString != null &&
                    this.QueryString.Equals(other.QueryString)
                ) &&
                (
                    this.Fragment == other.Fragment ||
                    this.Fragment != null &&
                    this.Fragment.Equals(other.Fragment)
                ) &&
                (
                    this.Name == other.Name ||
                    this.Name != null &&
                    this.Name.Equals(other.Name)
                ) &&
                (
                    this.Medium == other.Medium ||
                    this.Medium != null &&
                    this.Medium.Equals(other.Medium)
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
                if (this.Url != null)
                    hash = hash * 59 + this.Url.GetHashCode();

                if (this.Domain != null)
                    hash = hash * 59 + this.Domain.GetHashCode();

                if (this.Hostname != null)
                    hash = hash * 59 + this.Hostname.GetHashCode();

                if (this.Keywords != null)
                    hash = hash * 59 + this.Keywords.GetHashCode();

                if (this.Pathname != null)
                    hash = hash * 59 + this.Pathname.GetHashCode();

                if (this.QueryString != null)
                    hash = hash * 59 + this.QueryString.GetHashCode();

                if (this.Fragment != null)
                    hash = hash * 59 + this.Fragment.GetHashCode();

                if (this.Name != null)
                    hash = hash * 59 + this.Name.GetHashCode();

                if (this.Medium != null)
                    hash = hash * 59 + this.Medium.GetHashCode();

                return hash;
            }
        }
    }

}
