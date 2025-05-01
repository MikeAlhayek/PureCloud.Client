using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloudPlatform.Client.V2.Model;

/// <summary>
/// Defines a response for a list of SCIM resource types.
/// </summary>
[DataContract]
public partial class ScimConfigResourceTypesListResponse : IEquatable<ScimConfigResourceTypesListResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimConfigResourceTypesListResponse" /> class.
    /// </summary>
    /// <param name="Schemas">The list of supported schemas..</param>
    public ScimConfigResourceTypesListResponse(List<string> Schemas = null)
    {
        this.Schemas = Schemas;

    }



    /// <summary>
    /// The list of supported schemas.
    /// </summary>
    /// <value>The list of supported schemas.</value>
    [DataMember(Name = "schemas", EmitDefaultValue = false)]
    public List<string> Schemas { get; set; }



    /// <summary>
    /// The total number of results.
    /// </summary>
    /// <value>The total number of results.</value>
    [DataMember(Name = "totalResults", EmitDefaultValue = false)]
    public long? TotalResults { get; private set; }



    /// <summary>
    /// The 1-based index of the first result returned by this request. Add this to \&quot;itemsPerPage\&quot; when requesting the next page of results.
    /// </summary>
    /// <value>The 1-based index of the first result returned by this request. Add this to \&quot;itemsPerPage\&quot; when requesting the next page of results.</value>
    [DataMember(Name = "startIndex", EmitDefaultValue = false)]
    public long? StartIndex { get; private set; }



    /// <summary>
    /// The number of resources returned per page.
    /// </summary>
    /// <value>The number of resources returned per page.</value>
    [DataMember(Name = "itemsPerPage", EmitDefaultValue = false)]
    public long? ItemsPerPage { get; private set; }



    /// <summary>
    /// The list of requested resources.
    /// </summary>
    /// <value>The list of requested resources.</value>
    [DataMember(Name = "Resources", EmitDefaultValue = false)]
    public List<ScimConfigResourceType> Resources { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimConfigResourceTypesListResponse {\n");

        sb.Append("  Schemas: ").Append(Schemas).Append("\n");
        sb.Append("  TotalResults: ").Append(TotalResults).Append("\n");
        sb.Append("  StartIndex: ").Append(StartIndex).Append("\n");
        sb.Append("  ItemsPerPage: ").Append(ItemsPerPage).Append("\n");
        sb.Append("  Resources: ").Append(Resources).Append("\n");
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
        return this.Equals(obj as ScimConfigResourceTypesListResponse);
    }

    /// <summary>
    /// Returns true if ScimConfigResourceTypesListResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimConfigResourceTypesListResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimConfigResourceTypesListResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                this.Schemas == other.Schemas ||
                this.Schemas != null &&
                this.Schemas.SequenceEqual(other.Schemas)
            ) &&
            (
                this.TotalResults == other.TotalResults ||
                this.TotalResults != null &&
                this.TotalResults.Equals(other.TotalResults)
            ) &&
            (
                this.StartIndex == other.StartIndex ||
                this.StartIndex != null &&
                this.StartIndex.Equals(other.StartIndex)
            ) &&
            (
                this.ItemsPerPage == other.ItemsPerPage ||
                this.ItemsPerPage != null &&
                this.ItemsPerPage.Equals(other.ItemsPerPage)
            ) &&
            (
                this.Resources == other.Resources ||
                this.Resources != null &&
                this.Resources.SequenceEqual(other.Resources)
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
            if (this.Schemas != null)
            {
                hash = hash * 59 + this.Schemas.GetHashCode();
            }

            if (this.TotalResults != null)
            {
                hash = hash * 59 + this.TotalResults.GetHashCode();
            }

            if (this.StartIndex != null)
            {
                hash = hash * 59 + this.StartIndex.GetHashCode();
            }

            if (this.ItemsPerPage != null)
            {
                hash = hash * 59 + this.ItemsPerPage.GetHashCode();
            }

            if (this.Resources != null)
            {
                hash = hash * 59 + this.Resources.GetHashCode();
            }

            return hash;
        }
    }
}
