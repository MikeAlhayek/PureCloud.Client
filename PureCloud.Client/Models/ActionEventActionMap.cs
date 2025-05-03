using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// ActionEventActionMap
/// </summary>

public partial class ActionEventActionMap : IEquatable<ActionEventActionMap>
{

    /// <summary>
    /// Initializes a new instance of the <see cref="ActionEventActionMap" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ActionEventActionMap() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="ActionEventActionMap" /> class.
    /// </summary>
    /// <param name="Id">The ID of the action map. (required).</param>
    /// <param name="SelfUri">SelfUri.</param>
    /// <param name="Version">The version of the action map. (required).</param>
    /// <param name="DisplayName">Display name of the action map. (required).</param>
    public ActionEventActionMap(string Id = null, string SelfUri = null, int? Version = null, string DisplayName = null)
    {
        this.Id = Id;
        this.SelfUri = SelfUri;
        this.Version = Version;
        this.DisplayName = DisplayName;

    }



    /// <summary>
    /// The ID of the action map.
    /// </summary>
    /// <value>The ID of the action map.</value>
    [JsonPropertyName("id")]
    public string Id { get; set; }



    /// <summary>
    /// Gets or Sets SelfUri
    /// </summary>
    [JsonPropertyName("selfUri")]
    public string SelfUri { get; set; }



    /// <summary>
    /// The version of the action map.
    /// </summary>
    /// <value>The version of the action map.</value>
    [JsonPropertyName("version")]
    public int? Version { get; set; }



    /// <summary>
    /// Display name of the action map.
    /// </summary>
    /// <value>Display name of the action map.</value>
    [JsonPropertyName("displayName")]
    public string DisplayName { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ActionEventActionMap {\n");

        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  SelfUri: ").Append(SelfUri).Append("\n");
        sb.Append("  Version: ").Append(Version).Append("\n");
        sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
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
        return Equals(obj as ActionEventActionMap);
    }

    /// <summary>
    /// Returns true if ActionEventActionMap instances are equal
    /// </summary>
    /// <param name="other">Instance of ActionEventActionMap to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ActionEventActionMap other)
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
                SelfUri == other.SelfUri ||
                SelfUri != null &&
                SelfUri.Equals(other.SelfUri)
            ) &&
            (
                Version == other.Version ||
                Version != null &&
                Version.Equals(other.Version)
            ) &&
            (
                DisplayName == other.DisplayName ||
                DisplayName != null &&
                DisplayName.Equals(other.DisplayName)
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

            if (SelfUri != null)
            {
                hash = hash * 59 + SelfUri.GetHashCode();
            }

            if (Version != null)
            {
                hash = hash * 59 + Version.GetHashCode();
            }

            if (DisplayName != null)
            {
                hash = hash * 59 + DisplayName.GetHashCode();
            }

            return hash;
        }
    }
}
