using System.Runtime.Serialization;
using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// UserTokensTopicTokenNotification
/// </summary>
[DataContract]
public partial class UserTokensTopicTokenNotification : IEquatable<UserTokensTopicTokenNotification>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="UserTokensTopicTokenNotification" /> class.
    /// </summary>
    /// <param name="User">User.</param>
    /// <param name="IpAddress">IpAddress.</param>
    /// <param name="DateCreated">DateCreated.</param>
    /// <param name="TokenExpirationDate">TokenExpirationDate.</param>
    /// <param name="SessionId">SessionId.</param>
    /// <param name="ClientId">ClientId.</param>
    /// <param name="TokenHash">TokenHash.</param>
    public UserTokensTopicTokenNotification(UserTokensTopicUriReference User = null, string IpAddress = null, string DateCreated = null, string TokenExpirationDate = null, string SessionId = null, string ClientId = null, string TokenHash = null)
    {
        this.User = User;
        this.IpAddress = IpAddress;
        this.DateCreated = DateCreated;
        this.TokenExpirationDate = TokenExpirationDate;
        this.SessionId = SessionId;
        this.ClientId = ClientId;
        this.TokenHash = TokenHash;

    }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [DataMember(Name = "user", EmitDefaultValue = false)]
    public UserTokensTopicUriReference User { get; set; }



    /// <summary>
    /// Gets or Sets IpAddress
    /// </summary>
    [DataMember(Name = "ipAddress", EmitDefaultValue = false)]
    public string IpAddress { get; set; }



    /// <summary>
    /// Gets or Sets DateCreated
    /// </summary>
    [DataMember(Name = "dateCreated", EmitDefaultValue = false)]
    public string DateCreated { get; set; }



    /// <summary>
    /// Gets or Sets TokenExpirationDate
    /// </summary>
    [DataMember(Name = "tokenExpirationDate", EmitDefaultValue = false)]
    public string TokenExpirationDate { get; set; }



    /// <summary>
    /// Gets or Sets SessionId
    /// </summary>
    [DataMember(Name = "sessionId", EmitDefaultValue = false)]
    public string SessionId { get; set; }



    /// <summary>
    /// Gets or Sets ClientId
    /// </summary>
    [DataMember(Name = "clientId", EmitDefaultValue = false)]
    public string ClientId { get; set; }



    /// <summary>
    /// Gets or Sets TokenHash
    /// </summary>
    [DataMember(Name = "tokenHash", EmitDefaultValue = false)]
    public string TokenHash { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class UserTokensTopicTokenNotification {\n");

        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  IpAddress: ").Append(IpAddress).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  TokenExpirationDate: ").Append(TokenExpirationDate).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
        sb.Append("  ClientId: ").Append(ClientId).Append("\n");
        sb.Append("  TokenHash: ").Append(TokenHash).Append("\n");
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
        return Equals(obj as UserTokensTopicTokenNotification);
    }

    /// <summary>
    /// Returns true if UserTokensTopicTokenNotification instances are equal
    /// </summary>
    /// <param name="other">Instance of UserTokensTopicTokenNotification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(UserTokensTopicTokenNotification other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                IpAddress == other.IpAddress ||
                IpAddress != null &&
                IpAddress.Equals(other.IpAddress)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                TokenExpirationDate == other.TokenExpirationDate ||
                TokenExpirationDate != null &&
                TokenExpirationDate.Equals(other.TokenExpirationDate)
            ) &&
            (
                SessionId == other.SessionId ||
                SessionId != null &&
                SessionId.Equals(other.SessionId)
            ) &&
            (
                ClientId == other.ClientId ||
                ClientId != null &&
                ClientId.Equals(other.ClientId)
            ) &&
            (
                TokenHash == other.TokenHash ||
                TokenHash != null &&
                TokenHash.Equals(other.TokenHash)
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
            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (IpAddress != null)
            {
                hash = hash * 59 + IpAddress.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (TokenExpirationDate != null)
            {
                hash = hash * 59 + TokenExpirationDate.GetHashCode();
            }

            if (SessionId != null)
            {
                hash = hash * 59 + SessionId.GetHashCode();
            }

            if (ClientId != null)
            {
                hash = hash * 59 + ClientId.GetHashCode();
            }

            if (TokenHash != null)
            {
                hash = hash * 59 + TokenHash.GetHashCode();
            }

            return hash;
        }
    }
}
