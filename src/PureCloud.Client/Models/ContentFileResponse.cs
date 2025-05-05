using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContentFileResponse
/// </summary>

public partial class ContentFileResponse : IEquatable<ContentFileResponse>
{
    /// <summary>
    /// The file format
    /// </summary>
    /// <value>The file format</value>
    
    public enum TypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Pdf for "Pdf"
        /// </summary>
        [EnumMember(Value = "Pdf")]
        Pdf,

        /// <summary>
        /// Enum Docx for "Docx"
        /// </summary>
        [EnumMember(Value = "Docx")]
        Docx,

        /// <summary>
        /// Enum Doc for "Doc"
        /// </summary>
        [EnumMember(Value = "Doc")]
        Doc
    }
    /// <summary>
    /// The file format
    /// </summary>
    /// <value>The file format</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ContentFileResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ContentFileResponse() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContentFileResponse" /> class.
    /// </summary>
    /// <param name="Name">The name of the file (required).</param>
    /// <param name="Type">The file format (required).</param>
    /// <param name="Checksum">The checksum of the file (required).</param>
    /// <param name="Size">The size of the file in bytes (required).</param>
    /// <param name="ContentUrl">Public download url for content. Needs to be expanded (required).</param>
    public ContentFileResponse(string Name = null, TypeEnum? Type = null, string Checksum = null, long? Size = null, string ContentUrl = null)
    {
        this.Name = Name;
        this.Type = Type;
        this.Checksum = Checksum;
        this.Size = Size;
        this.ContentUrl = ContentUrl;

    }



    /// <summary>
    /// The name of the file
    /// </summary>
    /// <value>The name of the file</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }





    /// <summary>
    /// The checksum of the file
    /// </summary>
    /// <value>The checksum of the file</value>
    [JsonPropertyName("checksum")]
    public string Checksum { get; set; }



    /// <summary>
    /// The size of the file in bytes
    /// </summary>
    /// <value>The size of the file in bytes</value>
    [JsonPropertyName("size")]
    public long? Size { get; set; }



    /// <summary>
    /// Public download url for content. Needs to be expanded
    /// </summary>
    /// <value>Public download url for content. Needs to be expanded</value>
    [JsonPropertyName("contentUrl")]
    public string ContentUrl { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContentFileResponse {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Checksum: ").Append(Checksum).Append("\n");
        sb.Append("  Size: ").Append(Size).Append("\n");
        sb.Append("  ContentUrl: ").Append(ContentUrl).Append("\n");
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
        return Equals(obj as ContentFileResponse);
    }

    /// <summary>
    /// Returns true if ContentFileResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ContentFileResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContentFileResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Checksum == other.Checksum ||
                Checksum != null &&
                Checksum.Equals(other.Checksum)
            ) &&
            (
                Size == other.Size ||
                Size != null &&
                Size.Equals(other.Size)
            ) &&
            (
                ContentUrl == other.ContentUrl ||
                ContentUrl != null &&
                ContentUrl.Equals(other.ContentUrl)
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
            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Checksum != null)
            {
                hash = hash * 59 + Checksum.GetHashCode();
            }

            if (Size != null)
            {
                hash = hash * 59 + Size.GetHashCode();
            }

            if (ContentUrl != null)
            {
                hash = hash * 59 + ContentUrl.GetHashCode();
            }

            return hash;
        }
    }
}
