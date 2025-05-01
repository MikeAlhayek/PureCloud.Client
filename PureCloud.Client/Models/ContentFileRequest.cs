using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ContentFileRequest
/// </summary>
[DataContract]
public partial class ContentFileRequest : IEquatable<ContentFileRequest>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContentFileRequest" /> class.
    /// </summary>
    /// <param name="UploadKey">Key that identifies the file in the storage including the file name.</param>
    /// <param name="Name">The name of the file.</param>
    public ContentFileRequest(string UploadKey = null, string Name = null)
    {
        this.UploadKey = UploadKey;
        this.Name = Name;

    }



    /// <summary>
    /// Key that identifies the file in the storage including the file name
    /// </summary>
    /// <value>Key that identifies the file in the storage including the file name</value>
    [DataMember(Name = "uploadKey", EmitDefaultValue = false)]
    public string UploadKey { get; set; }



    /// <summary>
    /// The name of the file
    /// </summary>
    /// <value>The name of the file</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContentFileRequest {\n");

        sb.Append("  UploadKey: ").Append(UploadKey).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return Equals(obj as ContentFileRequest);
    }

    /// <summary>
    /// Returns true if ContentFileRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of ContentFileRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContentFileRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                UploadKey == other.UploadKey ||
                UploadKey != null &&
                UploadKey.Equals(other.UploadKey)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
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
            if (UploadKey != null)
            {
                hash = hash * 59 + UploadKey.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            return hash;
        }
    }
}
