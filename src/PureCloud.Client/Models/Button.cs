using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Button
/// </summary>

public partial class Button : IEquatable<Button>
{
    /// <summary>
    /// Type of button to include in whatsApp template
    /// </summary>
    /// <value>Type of button to include in whatsApp template</value>
    
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
        /// Enum Quickreply for "QuickReply"
        /// </summary>
        [EnumMember(Value = "QuickReply")]
        Quickreply,

        /// <summary>
        /// Enum Phonenumber for "PhoneNumber"
        /// </summary>
        [EnumMember(Value = "PhoneNumber")]
        Phonenumber,

        /// <summary>
        /// Enum Url for "Url"
        /// </summary>
        [EnumMember(Value = "Url")]
        Url
    }
    /// <summary>
    /// Type of button to include in whatsApp template
    /// </summary>
    /// <value>Type of button to include in whatsApp template</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="Button" /> class.
    /// </summary>
    /// <param name="Type">Type of button to include in whatsApp template.</param>
    /// <param name="Content">Content of the button. Use for &#39;Url&#39; or &#39;PhoneNumber&#39; button type.</param>
    /// <param name="ContentText">The text label that will be displayed on the button.</param>
    public Button(TypeEnum? Type = null, string Content = null, string ContentText = null)
    {
        this.Type = Type;
        this.Content = Content;
        this.ContentText = ContentText;

    }





    /// <summary>
    /// Content of the button. Use for &#39;Url&#39; or &#39;PhoneNumber&#39; button type
    /// </summary>
    /// <value>Content of the button. Use for &#39;Url&#39; or &#39;PhoneNumber&#39; button type</value>
    [JsonPropertyName("content")]
    public string Content { get; set; }



    /// <summary>
    /// The text label that will be displayed on the button
    /// </summary>
    /// <value>The text label that will be displayed on the button</value>
    [JsonPropertyName("contentText")]
    public string ContentText { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class Button {\n");

        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Content: ").Append(Content).Append("\n");
        sb.Append("  ContentText: ").Append(ContentText).Append("\n");
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
        return Equals(obj as Button);
    }

    /// <summary>
    /// Returns true if Button instances are equal
    /// </summary>
    /// <param name="other">Instance of Button to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Button other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Type == other.Type ||
                Type != null &&
                Type.Equals(other.Type)
            ) &&
            (
                Content == other.Content ||
                Content != null &&
                Content.Equals(other.Content)
            ) &&
            (
                ContentText == other.ContentText ||
                ContentText != null &&
                ContentText.Equals(other.ContentText)
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
            if (Type != null)
            {
                hash = hash * 59 + Type.GetHashCode();
            }

            if (Content != null)
            {
                hash = hash * 59 + Content.GetHashCode();
            }

            if (ContentText != null)
            {
                hash = hash * 59 + ContentText.GetHashCode();
            }

            return hash;
        }
    }
}
