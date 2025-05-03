using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Contains information about the text associated with a response.
/// </summary>

public partial class ResponseText : IEquatable<ResponseText>
{
    /// <summary>
    /// Response text content type.
    /// </summary>
    /// <value>Response text content type.</value>
    
    public enum ContentTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Plain for "text/plain"
        /// </summary>
        [EnumMember(Value = "text/plain")]
        Plain,

        /// <summary>
        /// Enum Html for "text/html"
        /// </summary>
        [EnumMember(Value = "text/html")]
        Html
    }
    /// <summary>
    /// Response text type.
    /// </summary>
    /// <value>Response text type.</value>
    
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
        /// Enum Body for "body"
        /// </summary>
        [EnumMember(Value = "body")]
        Body,

        /// <summary>
        /// Enum Subject for "subject"
        /// </summary>
        [EnumMember(Value = "subject")]
        Subject
    }
    /// <summary>
    /// Response text content type.
    /// </summary>
    /// <value>Response text content type.</value>
    [JsonPropertyName("contentType")]
    public ContentTypeEnum? ContentType { get; set; }
    /// <summary>
    /// Response text type.
    /// </summary>
    /// <value>Response text type.</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="ResponseText" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ResponseText() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ResponseText" /> class.
    /// </summary>
    /// <param name="Content">Response text content. (required).</param>
    /// <param name="ContentType">Response text content type..</param>
    /// <param name="Type">Response text type..</param>
    public ResponseText(string Content = null, ContentTypeEnum? ContentType = null, TypeEnum? Type = null)
    {
        this.Content = Content;
        this.ContentType = ContentType;
        this.Type = Type;

    }



    /// <summary>
    /// Response text content.
    /// </summary>
    /// <value>Response text content.</value>
    [JsonPropertyName("content")]
    public string Content { get; set; }






    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ResponseText {\n");

        sb.Append("  Content: ").Append(Content).Append("\n");
        sb.Append("  ContentType: ").Append(ContentType).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
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
        return Equals(obj as ResponseText);
    }

    /// <summary>
    /// Returns true if ResponseText instances are equal
    /// </summary>
    /// <param name="other">Instance of ResponseText to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ResponseText other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Content == other.Content ||
                Content != null &&
                Content.Equals(other.Content)
            ) &&
            (
                ContentType == other.ContentType ||
                ContentType != null &&
                ContentType.Equals(other.ContentType)
            ) &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
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
            if (Content != null)
            {
                hash = hash * 59 + Content.GetHashCode();
            }

            if (ContentType != null)
            {
                hash = hash * 59 + ContentType.GetHashCode();
            }

            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            return hash;
        }
    }
}
