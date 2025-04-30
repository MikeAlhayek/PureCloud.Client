using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model
{
    /// <summary>
    /// TokenInfo
    /// </summary>
    [DataContract]
    public partial class TokenInfo :  IEquatable<TokenInfo>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TokenInfo" /> class.
        /// </summary>
        /// <param name="OAuthClient">OAuthClient.</param>
        public TokenInfo(OrgOAuthClient OAuthClient = null)
        {
            this.OAuthClient = OAuthClient;
            
        }
        


        /// <summary>
        /// The current organization
        /// </summary>
        /// <value>The current organization</value>
        [DataMember(Name="organization", EmitDefaultValue=false)]
        public NamedEntity Organization { get; private set; }



        /// <summary>
        /// The token&#39;s home organization
        /// </summary>
        /// <value>The token&#39;s home organization</value>
        [DataMember(Name="homeOrganization", EmitDefaultValue=false)]
        public NamedEntity HomeOrganization { get; private set; }



        /// <summary>
        /// The list of scopes authorized for the OAuth client
        /// </summary>
        /// <value>The list of scopes authorized for the OAuth client</value>
        [DataMember(Name="authorizedScope", EmitDefaultValue=false)]
        public List<string> AuthorizedScope { get; private set; }



        /// <summary>
        /// Only present when a user is a clone of trustee user in the trustor org.
        /// </summary>
        /// <value>Only present when a user is a clone of trustee user in the trustor org.</value>
        [DataMember(Name="clonedUser", EmitDefaultValue=false)]
        public TokenInfoClonedUser ClonedUser { get; private set; }



        /// <summary>
        /// Gets or Sets OAuthClient
        /// </summary>
        [DataMember(Name="OAuthClient", EmitDefaultValue=false)]
        public OrgOAuthClient OAuthClient { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TokenInfo {\n");

            sb.Append("  Organization: ").Append(Organization).Append("\n");
            sb.Append("  HomeOrganization: ").Append(HomeOrganization).Append("\n");
            sb.Append("  AuthorizedScope: ").Append(AuthorizedScope).Append("\n");
            sb.Append("  ClonedUser: ").Append(ClonedUser).Append("\n");
            sb.Append("  OAuthClient: ").Append(OAuthClient).Append("\n");
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
            return this.Equals(obj as TokenInfo);
        }

        /// <summary>
        /// Returns true if TokenInfo instances are equal
        /// </summary>
        /// <param name="other">Instance of TokenInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TokenInfo other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return true &&
                (
                    this.Organization == other.Organization ||
                    this.Organization != null &&
                    this.Organization.Equals(other.Organization)
                ) &&
                (
                    this.HomeOrganization == other.HomeOrganization ||
                    this.HomeOrganization != null &&
                    this.HomeOrganization.Equals(other.HomeOrganization)
                ) &&
                (
                    this.AuthorizedScope == other.AuthorizedScope ||
                    this.AuthorizedScope != null &&
                    this.AuthorizedScope.SequenceEqual(other.AuthorizedScope)
                ) &&
                (
                    this.ClonedUser == other.ClonedUser ||
                    this.ClonedUser != null &&
                    this.ClonedUser.Equals(other.ClonedUser)
                ) &&
                (
                    this.OAuthClient == other.OAuthClient ||
                    this.OAuthClient != null &&
                    this.OAuthClient.Equals(other.OAuthClient)
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
                if (this.Organization != null)
                    hash = hash * 59 + this.Organization.GetHashCode();

                if (this.HomeOrganization != null)
                    hash = hash * 59 + this.HomeOrganization.GetHashCode();

                if (this.AuthorizedScope != null)
                    hash = hash * 59 + this.AuthorizedScope.GetHashCode();

                if (this.ClonedUser != null)
                    hash = hash * 59 + this.ClonedUser.GetHashCode();

                if (this.OAuthClient != null)
                    hash = hash * 59 + this.OAuthClient.GetHashCode();

                return hash;
            }
        }
    }

}
