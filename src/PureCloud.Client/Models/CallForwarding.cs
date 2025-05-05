using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// CallForwarding
/// </summary>

public partial class CallForwarding : IEquatable<CallForwarding>
{
    /// <summary>
    /// The type of voicemail to use with the callForwarding configuration
    /// </summary>
    /// <value>The type of voicemail to use with the callForwarding configuration</value>
    
    public enum VoicemailEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum PureCloudEnvironment for "PURECLOUD"
        /// </summary>
        [EnumMember(Value = "PURECLOUD")]
        Purecloud,

        /// <summary>
        /// Enum Lastcall for "LASTCALL"
        /// </summary>
        [EnumMember(Value = "LASTCALL")]
        Lastcall,

        /// <summary>
        /// Enum None for "NONE"
        /// </summary>
        [EnumMember(Value = "NONE")]
        None
    }
    /// <summary>
    /// The type of voicemail to use with the callForwarding configuration
    /// </summary>
    /// <value>The type of voicemail to use with the callForwarding configuration</value>
    [JsonPropertyName("voicemail")]
    public VoicemailEnum? Voicemail { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="CallForwarding" /> class.
    /// </summary>
    /// <param name="Name">Name.</param>
    /// <param name="User">User.</param>
    /// <param name="Enabled">Whether or not CallForwarding is enabled.</param>
    /// <param name="PhoneNumber">This property is deprecated. Please use the calls property.</param>
    /// <param name="Calls">An ordered list of CallRoutes to be executed when CallForwarding is enabled.</param>
    /// <param name="Voicemail">The type of voicemail to use with the callForwarding configuration.</param>
    /// <param name="ModifiedDate">Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z.</param>
    public CallForwarding(string Name = null, User User = null, bool? Enabled = null, string PhoneNumber = null, List<CallRoute> Calls = null, VoicemailEnum? Voicemail = null, DateTime? ModifiedDate = null)
    {
        this.Name = Name;
        this.User = User;
        this.Enabled = Enabled;
        this.PhoneNumber = PhoneNumber;
        this.Calls = Calls;
        this.Voicemail = Voicemail;
        this.ModifiedDate = ModifiedDate;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; private set; }



    /// <summary>
    /// Gets or Sets Name
    /// </summary>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets User
    /// </summary>
    [JsonPropertyName("user")]
    public User User { get; set; }



    /// <summary>
    /// Whether or not CallForwarding is enabled
    /// </summary>
    /// <value>Whether or not CallForwarding is enabled</value>
    [JsonPropertyName("enabled")]
    public bool? Enabled { get; set; }



    /// <summary>
    /// This property is deprecated. Please use the calls property
    /// </summary>
    /// <value>This property is deprecated. Please use the calls property</value>
    [JsonPropertyName("phoneNumber")]
    public string PhoneNumber { get; set; }



    /// <summary>
    /// An ordered list of CallRoutes to be executed when CallForwarding is enabled
    /// </summary>
    /// <value>An ordered list of CallRoutes to be executed when CallForwarding is enabled</value>
    [JsonPropertyName("calls")]
    public List<CallRoute> Calls { get; set; }





    /// <summary>
    /// Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("modifiedDate")]
    public DateTime? ModifiedDate { get; set; }



    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CallForwarding {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  User: ").Append(User).Append("\n");
        sb.Append("  Enabled: ").Append(Enabled).Append("\n");
        sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
        sb.Append("  Calls: ").Append(Calls).Append("\n");
        sb.Append("  Voicemail: ").Append(Voicemail).Append("\n");
        sb.Append("  ModifiedDate: ").Append(ModifiedDate).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
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
        return Equals(obj as CallForwarding);
    }

    /// <summary>
    /// Returns true if CallForwarding instances are equal
    /// </summary>
    /// <param name="other">Instance of CallForwarding to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CallForwarding other)
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
                User == other.User ||
                User != null &&
                User.Equals(other.User)
            ) &&
            (
                Enabled == other.Enabled ||
                Enabled != null &&
                Enabled.Equals(other.Enabled)
            ) &&
            (
                PhoneNumber == other.PhoneNumber ||
                PhoneNumber != null &&
                PhoneNumber.Equals(other.PhoneNumber)
            ) &&
            (
                Calls == other.Calls ||
                Calls != null &&
                Calls.SequenceEqual(other.Calls)
            ) &&
            (
                Voicemail == other.Voicemail ||
                Voicemail != null &&
                Voicemail.Equals(other.Voicemail)
            ) &&
            (
                ModifiedDate == other.ModifiedDate ||
                ModifiedDate != null &&
                ModifiedDate.Equals(other.ModifiedDate)
            ) &&
            (
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
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

            if (User != null)
            {
                hash = hash * 59 + User.GetHashCode();
            }

            if (Enabled != null)
            {
                hash = hash * 59 + Enabled.GetHashCode();
            }

            if (PhoneNumber != null)
            {
                hash = hash * 59 + PhoneNumber.GetHashCode();
            }

            if (Calls != null)
            {
                hash = hash * 59 + Calls.GetHashCode();
            }

            if (Voicemail != null)
            {
                hash = hash * 59 + Voicemail.GetHashCode();
            }

            if (ModifiedDate != null)
            {
                hash = hash * 59 + ModifiedDate.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
