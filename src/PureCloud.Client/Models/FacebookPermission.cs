using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Facebook Permissions Model
/// </summary>

public partial class FacebookPermission : IEquatable<FacebookPermission>
{
    /// <summary>
    /// Facebook permission type
    /// </summary>
    /// <value>Facebook permission type</value>
    
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
        /// Enum Facebookprivate for "FacebookPrivate"
        /// </summary>
        [EnumMember(Value = "FacebookPrivate")]
        Facebookprivate,

        /// <summary>
        /// Enum Facebookpublic for "FacebookPublic"
        /// </summary>
        [EnumMember(Value = "FacebookPublic")]
        Facebookpublic,

        /// <summary>
        /// Enum Instagramprivate for "InstagramPrivate"
        /// </summary>
        [EnumMember(Value = "InstagramPrivate")]
        Instagramprivate,

        /// <summary>
        /// Enum Instagrampublic for "InstagramPublic"
        /// </summary>
        [EnumMember(Value = "InstagramPublic")]
        Instagrampublic,

        /// <summary>
        /// Enum Whatsappprivate for "WhatsAppPrivate"
        /// </summary>
        [EnumMember(Value = "WhatsAppPrivate")]
        Whatsappprivate
    }
    /// <summary>
    /// Facebook permission type
    /// </summary>
    /// <value>Facebook permission type</value>
    [JsonPropertyName("type")]
    public TypeEnum? Type { get; private set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="FacebookPermission" /> class.
    /// </summary>
    public FacebookPermission()
    {

    }



    /// <summary>
    /// Facebook permission name
    /// </summary>
    /// <value>Facebook permission name</value>
    [JsonPropertyName("name")]
    public string Name { get; private set; }




    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class FacebookPermission {\n");

        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return Equals(obj as FacebookPermission);
    }

    /// <summary>
    /// Returns true if FacebookPermission instances are equal
    /// </summary>
    /// <param name="other">Instance of FacebookPermission to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(FacebookPermission other)
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

            return hash;
        }
    }
}
