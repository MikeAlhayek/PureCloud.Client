using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// DocumentUpdate
/// </summary>

public partial class DocumentUpdate : IEquatable<DocumentUpdate>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentUpdate" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DocumentUpdate() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="DocumentUpdate" /> class.
    /// </summary>
    /// <param name="ChangeNumber">ChangeNumber.</param>
    /// <param name="Name">The name of the document (required).</param>
    /// <param name="Read">Read.</param>
    /// <param name="AddTags">AddTags.</param>
    /// <param name="RemoveTags">RemoveTags.</param>
    /// <param name="AddTagIds">AddTagIds.</param>
    /// <param name="RemoveTagIds">RemoveTagIds.</param>
    /// <param name="UpdateAttributes">UpdateAttributes.</param>
    /// <param name="RemoveAttributes">RemoveAttributes.</param>
    public DocumentUpdate(int? ChangeNumber = null, string Name = null, bool? Read = null, List<string> AddTags = null, List<string> RemoveTags = null, List<string> AddTagIds = null, List<string> RemoveTagIds = null, List<DocumentAttribute> UpdateAttributes = null, List<string> RemoveAttributes = null)
    {
        this.ChangeNumber = ChangeNumber;
        this.Name = Name;
        this.Read = Read;
        this.AddTags = AddTags;
        this.RemoveTags = RemoveTags;
        this.AddTagIds = AddTagIds;
        this.RemoveTagIds = RemoveTagIds;
        this.UpdateAttributes = UpdateAttributes;
        this.RemoveAttributes = RemoveAttributes;

    }



    /// <summary>
    /// Gets or Sets ChangeNumber
    /// </summary>
    [JsonPropertyName("changeNumber")]
    public int? ChangeNumber { get; set; }



    /// <summary>
    /// The name of the document
    /// </summary>
    /// <value>The name of the document</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Gets or Sets Read
    /// </summary>
    [JsonPropertyName("read")]
    public bool? Read { get; set; }



    /// <summary>
    /// Gets or Sets AddTags
    /// </summary>
    [JsonPropertyName("addTags")]
    public List<string> AddTags { get; set; }



    /// <summary>
    /// Gets or Sets RemoveTags
    /// </summary>
    [JsonPropertyName("removeTags")]
    public List<string> RemoveTags { get; set; }



    /// <summary>
    /// Gets or Sets AddTagIds
    /// </summary>
    [JsonPropertyName("addTagIds")]
    public List<string> AddTagIds { get; set; }



    /// <summary>
    /// Gets or Sets RemoveTagIds
    /// </summary>
    [JsonPropertyName("removeTagIds")]
    public List<string> RemoveTagIds { get; set; }



    /// <summary>
    /// Gets or Sets UpdateAttributes
    /// </summary>
    [JsonPropertyName("updateAttributes")]
    public List<DocumentAttribute> UpdateAttributes { get; set; }



    /// <summary>
    /// Gets or Sets RemoveAttributes
    /// </summary>
    [JsonPropertyName("removeAttributes")]
    public List<string> RemoveAttributes { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DocumentUpdate {\n");

        sb.Append("  ChangeNumber: ").Append(ChangeNumber).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Read: ").Append(Read).Append("\n");
        sb.Append("  AddTags: ").Append(AddTags).Append("\n");
        sb.Append("  RemoveTags: ").Append(RemoveTags).Append("\n");
        sb.Append("  AddTagIds: ").Append(AddTagIds).Append("\n");
        sb.Append("  RemoveTagIds: ").Append(RemoveTagIds).Append("\n");
        sb.Append("  UpdateAttributes: ").Append(UpdateAttributes).Append("\n");
        sb.Append("  RemoveAttributes: ").Append(RemoveAttributes).Append("\n");
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
        return Equals(obj as DocumentUpdate);
    }

    /// <summary>
    /// Returns true if DocumentUpdate instances are equal
    /// </summary>
    /// <param name="other">Instance of DocumentUpdate to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DocumentUpdate other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                ChangeNumber == other.ChangeNumber ||
                ChangeNumber != null &&
                ChangeNumber.Equals(other.ChangeNumber)
            ) &&
            (
                Name == other.Name ||
                Name != null &&
                Name.Equals(other.Name)
            ) &&
            (
                Read == other.Read ||
                Read != null &&
                Read.Equals(other.Read)
            ) &&
            (
                AddTags == other.AddTags ||
                AddTags != null &&
                AddTags.SequenceEqual(other.AddTags)
            ) &&
            (
                RemoveTags == other.RemoveTags ||
                RemoveTags != null &&
                RemoveTags.SequenceEqual(other.RemoveTags)
            ) &&
            (
                AddTagIds == other.AddTagIds ||
                AddTagIds != null &&
                AddTagIds.SequenceEqual(other.AddTagIds)
            ) &&
            (
                RemoveTagIds == other.RemoveTagIds ||
                RemoveTagIds != null &&
                RemoveTagIds.SequenceEqual(other.RemoveTagIds)
            ) &&
            (
                UpdateAttributes == other.UpdateAttributes ||
                UpdateAttributes != null &&
                UpdateAttributes.SequenceEqual(other.UpdateAttributes)
            ) &&
            (
                RemoveAttributes == other.RemoveAttributes ||
                RemoveAttributes != null &&
                RemoveAttributes.SequenceEqual(other.RemoveAttributes)
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
            if (ChangeNumber != null)
            {
                hash = hash * 59 + ChangeNumber.GetHashCode();
            }

            if (Name != null)
            {
                hash = hash * 59 + Name.GetHashCode();
            }

            if (Read != null)
            {
                hash = hash * 59 + Read.GetHashCode();
            }

            if (AddTags != null)
            {
                hash = hash * 59 + AddTags.GetHashCode();
            }

            if (RemoveTags != null)
            {
                hash = hash * 59 + RemoveTags.GetHashCode();
            }

            if (AddTagIds != null)
            {
                hash = hash * 59 + AddTagIds.GetHashCode();
            }

            if (RemoveTagIds != null)
            {
                hash = hash * 59 + RemoveTagIds.GetHashCode();
            }

            if (UpdateAttributes != null)
            {
                hash = hash * 59 + UpdateAttributes.GetHashCode();
            }

            if (RemoveAttributes != null)
            {
                hash = hash * 59 + RemoveAttributes.GetHashCode();
            }

            return hash;
        }
    }
}
