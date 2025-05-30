using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Library
/// </summary>

public partial class Library : IEquatable<Library>
{
    /// <summary>
    /// This value is deprecated. Responses representing message templates may be added to any library.
    /// </summary>
    /// <value>This value is deprecated. Responses representing message templates may be added to any library.</value>
    
    public enum ResponseTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Messagingtemplate for "MessagingTemplate"
        /// </summary>
        [EnumMember(Value = "MessagingTemplate")]
        Messagingtemplate,

        /// <summary>
        /// Enum Campaignsmstemplate for "CampaignSmsTemplate"
        /// </summary>
        [EnumMember(Value = "CampaignSmsTemplate")]
        Campaignsmstemplate,

        /// <summary>
        /// Enum Campaignemailtemplate for "CampaignEmailTemplate"
        /// </summary>
        [EnumMember(Value = "CampaignEmailTemplate")]
        Campaignemailtemplate,

        /// <summary>
        /// Enum Footer for "Footer"
        /// </summary>
        [EnumMember(Value = "Footer")]
        Footer
    }
    /// <summary>
    /// This value is deprecated. Responses representing message templates may be added to any library.
    /// </summary>
    /// <value>This value is deprecated. Responses representing message templates may be added to any library.</value>
    [JsonPropertyName("responseType")]
    public ResponseTypeEnum? ResponseType { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="Library" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Library() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="Library" /> class.
    /// </summary>
    /// <param name="Name">The library name. (required).</param>
    /// <param name="Version">Current version for this resource..</param>
    /// <param name="ResponseType">This value is deprecated. Responses representing message templates may be added to any library..</param>
    public Library(string Name = null, int? Version = null, ResponseTypeEnum? ResponseType = null)
    {
        this.Name = Name;
        this.Version = Version;
        this.ResponseType = ResponseType;

    }



    /// <summary>
    /// The globally unique identifier for the object.
    /// </summary>
    /// <value>The globally unique identifier for the object.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The library name.
    /// </summary>
    /// <value>The library name.</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Current version for this resource.
    /// </summary>
    /// <value>Current version for this resource.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// User that created the library.
    /// </summary>
    /// <value>User that created the library.</value>
    [JsonPropertyName("createdBy")]
    public User CreatedBy { get; set; }



    /// <summary>
    /// The date and time the response was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z
    /// </summary>
    /// <value>The date and time the response was created. Date time is represented as an ISO-8601 string. For example: yyyy-MM-ddTHH:mm:ss[.mmm]Z</value>
    [JsonPropertyName("dateCreated")]
    public DateTime? DateCreated { get; set; }





    /// <summary>
    /// The URI for this object
    /// </summary>
    /// <value>The URI for this object</value>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Library {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  CreatedBy: ").Append(CreatedBy).Append("\n");
        sb.Append("  DateCreated: ").Append(DateCreated).Append("\n");
        sb.Append("  ResponseType: ").Append(ResponseType).Append("\n");
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
        return Equals(obj as Library);
    }

    /// <summary>
    /// Returns true if Library instances are equal
    /// </summary>
    /// <param name="other">Instance of Library to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Library other)
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
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                CreatedBy == other.CreatedBy ||
                CreatedBy != null &&
                CreatedBy.Equals(other.CreatedBy)
            ) &&
            (
                DateCreated == other.DateCreated ||
                DateCreated != null &&
                DateCreated.Equals(other.DateCreated)
            ) &&
            (
                ResponseType == other.ResponseType ||
                ResponseType != null &&
                ResponseType.Equals(other.ResponseType)
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

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (CreatedBy != null)
            {
                hash = hash * 59 + CreatedBy.GetHashCode();
            }

            if (DateCreated != null)
            {
                hash = hash * 59 + DateCreated.GetHashCode();
            }

            if (ResponseType != null)
            {
                hash = hash * 59 + ResponseType.GetHashCode();
            }

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            return hash;
        }
    }
}
