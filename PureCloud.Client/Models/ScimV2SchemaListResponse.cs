using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines the list response for SCIM resource types.
/// </summary>
[DataContract]
public partial class ScimV2SchemaListResponse : IEquatable<ScimV2SchemaListResponse>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimV2SchemaListResponse" /> class.
    /// </summary>
    /// <param name="Schemas">The list of supported schemas..</param>
    public ScimV2SchemaListResponse(List<string> Schemas = null)
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
    public List<ScimV2SchemaDefinition> Resources { get; private set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ScimV2SchemaListResponse {\n");

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
        return Equals(obj as ScimV2SchemaListResponse);
    }

    /// <summary>
    /// Returns true if ScimV2SchemaListResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimV2SchemaListResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ScimV2SchemaListResponse other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                Schemas == other.Schemas ||
                Schemas != null &&
                Schemas.SequenceEqual(other.Schemas)
            ) &&
            (
                TotalResults == other.TotalResults ||
                TotalResults != null &&
                TotalResults.Equals(other.TotalResults)
            ) &&
            (
                StartIndex == other.StartIndex ||
                StartIndex != null &&
                StartIndex.Equals(other.StartIndex)
            ) &&
            (
                ItemsPerPage == other.ItemsPerPage ||
                ItemsPerPage != null &&
                ItemsPerPage.Equals(other.ItemsPerPage)
            ) &&
            (
                Resources == other.Resources ||
                Resources != null &&
                Resources.SequenceEqual(other.Resources)
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
            if (Schemas != null)
            {
                hash = hash * 59 + Schemas.GetHashCode();
            }

            if (TotalResults != null)
            {
                hash = hash * 59 + TotalResults.GetHashCode();
            }

            if (StartIndex != null)
            {
                hash = hash * 59 + StartIndex.GetHashCode();
            }

            if (ItemsPerPage != null)
            {
                hash = hash * 59 + ItemsPerPage.GetHashCode();
            }

            if (Resources != null)
            {
                hash = hash * 59 + Resources.GetHashCode();
            }

            return hash;
        }
    }
}
