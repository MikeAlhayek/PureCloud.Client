using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// List content object.
/// </summary>

public partial class ContentList : IEquatable<ContentList>
{
    /// <summary>
    /// The type of list this instance represents.
    /// </summary>
    /// <value>The type of list this instance represents.</value>
    
    public enum ListTypeEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Selection for "Selection"
        /// </summary>
        [EnumMember(Value = "Selection")]
        Selection,

        /// <summary>
        /// Enum Vertical for "Vertical"
        /// </summary>
        [EnumMember(Value = "Vertical")]
        Vertical
    }
    /// <summary>
    /// The type of list this instance represents.
    /// </summary>
    /// <value>The type of list this instance represents.</value>
    [JsonPropertyName("listType")]
    public ListTypeEnum? ListType { get; set; }
    /// <summary>
    /// Initializes a new instance of the <see cref="ContentList" /> class.
    /// </summary>
    /// <param name="Id">A unique ID assigned to this rich message content..</param>
    /// <param name="ListType">The type of list this instance represents..</param>
    /// <param name="Title">Text to show in the title..</param>
    /// <param name="Description">Text to show in the description..</param>
    /// <param name="SubmitLabel">Label for Submit button..</param>
    /// <param name="Actions">The list actions (Deprecated)..</param>
    /// <param name="Components">An array of component objects..</param>
    public ContentList(string Id = null, ListTypeEnum? ListType = null, string Title = null, string Description = null, string SubmitLabel = null, ContentActions Actions = null, List<ListItemComponent> Components = null)
    {
        this.Id = Id;
        this.ListType = ListType;
        this.Title = Title;
        this.Description = Description;
        this.SubmitLabel = SubmitLabel;
        this.Actions = Actions;
        this.Components = Components;

    }



    /// <summary>
    /// A unique ID assigned to this rich message content.
    /// </summary>
    /// <value>A unique ID assigned to this rich message content.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }





    /// <summary>
    /// Text to show in the title.
    /// </summary>
    /// <value>Text to show in the title.</value>
    [JsonPropertyName("title")]
    public string Title { get; set; }



    /// <summary>
    /// Text to show in the description.
    /// </summary>
    /// <value>Text to show in the description.</value>
    [JsonPropertyName("description")]
    public string Description { get; set; }



    /// <summary>
    /// Label for Submit button.
    /// </summary>
    /// <value>Label for Submit button.</value>
    [JsonPropertyName("submitLabel")]
    public string SubmitLabel { get; set; }



    /// <summary>
    /// The list actions (Deprecated).
    /// </summary>
    /// <value>The list actions (Deprecated).</value>
    [JsonPropertyName("actions")]
    public ContentActions Actions { get; set; }



    /// <summary>
    /// An array of component objects.
    /// </summary>
    /// <value>An array of component objects.</value>
    [JsonPropertyName("components")]
    public List<ListItemComponent> Components { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ContentList {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  ListType: ").Append(ListType).Append("\n");
        sb.Append("  Title: ").Append(Title).Append("\n");
        sb.Append("  Description: ").Append(Description).Append("\n");
        sb.Append("  SubmitLabel: ").Append(SubmitLabel).Append("\n");
        sb.Append("  Actions: ").Append(Actions).Append("\n");
        sb.Append("  Components: ").Append(Components).Append("\n");
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
        return Equals(obj as ContentList);
    }

    /// <summary>
    /// Returns true if ContentList instances are equal
    /// </summary>
    /// <param name="other">Instance of ContentList to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ContentList other)
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
                ListType == other.ListType ||
                ListType != null &&
                ListType.Equals(other.ListType)
            ) &&
            (
                Title == other.Title ||
                Title != null &&
                Title.Equals(other.Title)
            ) &&
            (
                Description == other.Description ||
                Description != null &&
                Description.Equals(other.Description)
            ) &&
            (
                SubmitLabel == other.SubmitLabel ||
                SubmitLabel != null &&
                SubmitLabel.Equals(other.SubmitLabel)
            ) &&
            (
                Actions == other.Actions ||
                Actions != null &&
                Actions.Equals(other.Actions)
            ) &&
            (
                Components == other.Components ||
                Components != null &&
                Components.SequenceEqual(other.Components)
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

            if (ListType != null)
            {
                hash = hash * 59 + ListType.GetHashCode();
            }

            if (Title != null)
            {
                hash = hash * 59 + Title.GetHashCode();
            }

            if (Description != null)
            {
                hash = hash * 59 + Description.GetHashCode();
            }

            if (SubmitLabel != null)
            {
                hash = hash * 59 + SubmitLabel.GetHashCode();
            }

            if (Actions != null)
            {
                hash = hash * 59 + Actions.GetHashCode();
            }

            if (Components != null)
            {
                hash = hash * 59 + Components.GetHashCode();
            }

            return hash;
        }
    }
}
