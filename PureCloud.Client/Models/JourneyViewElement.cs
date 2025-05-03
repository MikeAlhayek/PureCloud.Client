using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// An element within a journey view
/// </summary>

public partial class JourneyViewElement : IEquatable<JourneyViewElement>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewElement" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected JourneyViewElement() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="JourneyViewElement" /> class.
    /// </summary>
    /// <param name="Id">The unique identifier of the element within the elements list (required).</param>
    /// <param name="Name">The unique name of the element within the view (required).</param>
    /// <param name="Attributes">Required attributes of the element (required).</param>
    /// <param name="DisplayAttributes">Attributes that defines the visualization of the element in the journey view.</param>
    /// <param name="Filter">Any filters applied to this element.</param>
    /// <param name="FollowedBy">A list of JourneyViewLink objects, listing the elements downstream of this element.</param>
    public JourneyViewElement(string Id = null, string Name = null, JourneyViewElementAttributes Attributes = null, JourneyViewElementDisplayAttributes DisplayAttributes = null, JourneyViewElementFilter Filter = null, List<JourneyViewLink> FollowedBy = null)
    {
        this.Id = Id;
        this.Name = Name;
        this.Attributes = Attributes;
        this.DisplayAttributes = DisplayAttributes;
        this.Filter = Filter;
        this.FollowedBy = FollowedBy;

    }



    /// <summary>
    /// The unique identifier of the element within the elements list
    /// </summary>
    /// <value>The unique identifier of the element within the elements list</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// The unique name of the element within the view
    /// </summary>
    /// <value>The unique name of the element within the view</value>
    [JsonPropertyName("name")]
    public string Name { get; set; }



    /// <summary>
    /// Required attributes of the element
    /// </summary>
    /// <value>Required attributes of the element</value>
    [JsonPropertyName("attributes")]
    public JourneyViewElementAttributes Attributes { get; set; }



    /// <summary>
    /// Attributes that defines the visualization of the element in the journey view
    /// </summary>
    /// <value>Attributes that defines the visualization of the element in the journey view</value>
    [JsonPropertyName("displayAttributes")]
    public JourneyViewElementDisplayAttributes DisplayAttributes { get; set; }



    /// <summary>
    /// Any filters applied to this element
    /// </summary>
    /// <value>Any filters applied to this element</value>
    [JsonPropertyName("filter")]
    public JourneyViewElementFilter Filter { get; set; }



    /// <summary>
    /// A list of JourneyViewLink objects, listing the elements downstream of this element
    /// </summary>
    /// <value>A list of JourneyViewLink objects, listing the elements downstream of this element</value>
    [JsonPropertyName("followedBy")]
    public List<JourneyViewLink> FollowedBy { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class JourneyViewElement {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  DisplayAttributes: ").Append(DisplayAttributes).Append("\n");
        sb.Append("  Filter: ").Append(Filter).Append("\n");
        sb.Append("  FollowedBy: ").Append(FollowedBy).Append("\n");
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
        return Equals(obj as JourneyViewElement);
    }

    /// <summary>
    /// Returns true if JourneyViewElement instances are equal
    /// </summary>
    /// <param name="other">Instance of JourneyViewElement to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(JourneyViewElement other)
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
                Attributes == other.Attributes ||
                Attributes != null &&
                Attributes.Equals(other.Attributes)
            ) &&
            (
                DisplayAttributes == other.DisplayAttributes ||
                DisplayAttributes != null &&
                DisplayAttributes.Equals(other.DisplayAttributes)
            ) &&
            (
                Filter == other.Filter ||
                Filter != null &&
                Filter.Equals(other.Filter)
            ) &&
            (
                FollowedBy == other.FollowedBy ||
                FollowedBy != null &&
                FollowedBy.SequenceEqual(other.FollowedBy)
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

            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            if (DisplayAttributes != null)
            {
                hash = hash * 59 + DisplayAttributes.GetHashCode();
            }

            if (Filter != null)
            {
                hash = hash * 59 + Filter.GetHashCode();
            }

            if (FollowedBy != null)
            {
                hash = hash * 59 + FollowedBy.GetHashCode();
            }

            return hash;
        }
    }
}
