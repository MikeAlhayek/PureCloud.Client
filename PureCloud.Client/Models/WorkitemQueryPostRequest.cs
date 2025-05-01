using System.Runtime.Serialization;
using System.Text;
using System.Text.Json.Serialization;

namespace PureCloud.Client.Models;

/// <summary>
/// WorkitemQueryPostRequest
/// </summary>
[DataContract]
public partial class WorkitemQueryPostRequest : IEquatable<WorkitemQueryPostRequest>
{
    /// <summary>
    /// Specify the value 'Count' for this parameter in order to return only the record count.
    /// </summary>
    /// <value>Specify the value 'Count' for this parameter in order to return only the record count.</value>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum SelectEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Count for "Count"
        /// </summary>
        [EnumMember(Value = "Count")]
        Count
    }
    /// <summary>
    /// Gets or Sets Expands
    /// </summary>
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum ExpandsEnum
    {
        /// <summary>
        /// Your SDK version is out of date and an unknown enum value was encountered. 
        /// Please upgrade the SDK using the command "Upgrade-Package PureCloudApiSdk" 
        /// in the Package Manager Console
        /// </summary>
        [EnumMember(Value = "OUTDATED_SDK_VERSION")]
        OutdatedSdkVersion,

        /// <summary>
        /// Enum Type for "type"
        /// </summary>
        [EnumMember(Value = "type")]
        Type,

        /// <summary>
        /// Enum Workbin for "workbin"
        /// </summary>
        [EnumMember(Value = "workbin")]
        Workbin,

        /// <summary>
        /// Enum Status for "status"
        /// </summary>
        [EnumMember(Value = "status")]
        Status,

        /// <summary>
        /// Enum Assignee for "assignee"
        /// </summary>
        [EnumMember(Value = "assignee")]
        Assignee,

        /// <summary>
        /// Enum Reporter for "reporter"
        /// </summary>
        [EnumMember(Value = "reporter")]
        Reporter,

        /// <summary>
        /// Enum Queue for "queue"
        /// </summary>
        [EnumMember(Value = "queue")]
        Queue
    }
    /// <summary>
    /// Specify the value 'Count' for this parameter in order to return only the record count.
    /// </summary>
    /// <value>Specify the value 'Count' for this parameter in order to return only the record count.</value>
    [DataMember(Name = "select", EmitDefaultValue = false)]
    public SelectEnum? Select { get; set; }

    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemQueryPostRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected WorkitemQueryPostRequest() { }
    /// <summary>
    /// Initializes a new instance of the <see cref="WorkitemQueryPostRequest" /> class.
    /// </summary>
    /// <param name="PageSize">Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200..</param>
    /// <param name="Select">Specify the value &#39;Count&#39; for this parameter in order to return only the record count..</param>
    /// <param name="Filters">List of filter objects to be used in the search. (required).</param>
    /// <param name="Attributes">List of entity attributes to be retrieved in the result..</param>
    /// <param name="After">The cursor that points to the end of the set of entities that has been returned..</param>
    /// <param name="Sort">Sort.</param>
    /// <param name="Expands">List of entity attributes to be expanded in the result..</param>
    public WorkitemQueryPostRequest(int? PageSize = null, SelectEnum? Select = null, List<WorkitemFilter> Filters = null, List<string> Attributes = null, string After = null, WorkitemQuerySort Sort = null, List<ExpandsEnum> Expands = null)
    {
        this.PageSize = PageSize;
        this.Select = Select;
        this.Filters = Filters;
        this.Attributes = Attributes;
        this.After = After;
        this.Sort = Sort;
        this.Expands = Expands;

    }



    /// <summary>
    /// Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200.
    /// </summary>
    /// <value>Limit the number of entities to return. It is not guaranteed that the requested number of entities will be filled in a single request. If an &#x60;after&#x60; key is returned as part of the response it is possible that more entities that match the filter criteria exist. Maximum of 200.</value>
    [DataMember(Name = "pageSize", EmitDefaultValue = false)]
    public int? PageSize { get; set; }





    /// <summary>
    /// List of filter objects to be used in the search.
    /// </summary>
    /// <value>List of filter objects to be used in the search.</value>
    [DataMember(Name = "filters", EmitDefaultValue = false)]
    public List<WorkitemFilter> Filters { get; set; }



    /// <summary>
    /// List of entity attributes to be retrieved in the result.
    /// </summary>
    /// <value>List of entity attributes to be retrieved in the result.</value>
    [DataMember(Name = "attributes", EmitDefaultValue = false)]
    public List<string> Attributes { get; set; }



    /// <summary>
    /// The cursor that points to the end of the set of entities that has been returned.
    /// </summary>
    /// <value>The cursor that points to the end of the set of entities that has been returned.</value>
    [DataMember(Name = "after", EmitDefaultValue = false)]
    public string After { get; set; }



    /// <summary>
    /// Sort
    /// </summary>
    /// <value>Sort</value>
    [DataMember(Name = "sort", EmitDefaultValue = false)]
    public WorkitemQuerySort Sort { get; set; }



    /// <summary>
    /// List of entity attributes to be expanded in the result.
    /// </summary>
    /// <value>List of entity attributes to be expanded in the result.</value>
    [DataMember(Name = "expands", EmitDefaultValue = false)]
    public List<ExpandsEnum> Expands { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class WorkitemQueryPostRequest {\n");

        sb.Append("  PageSize: ").Append(PageSize).Append("\n");
        sb.Append("  Select: ").Append(Select).Append("\n");
        sb.Append("  Filters: ").Append(Filters).Append("\n");
        sb.Append("  Attributes: ").Append(Attributes).Append("\n");
        sb.Append("  After: ").Append(After).Append("\n");
        sb.Append("  Sort: ").Append(Sort).Append("\n");
        sb.Append("  Expands: ").Append(Expands).Append("\n");
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
        return Equals(obj as WorkitemQueryPostRequest);
    }

    /// <summary>
    /// Returns true if WorkitemQueryPostRequest instances are equal
    /// </summary>
    /// <param name="other">Instance of WorkitemQueryPostRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(WorkitemQueryPostRequest other)
    {
        // credit: http://stackoverflow.com/a/10454552/677735
        if (other == null)
        {
            return false;
        }

        return true &&
            (
                PageSize == other.PageSize ||
                PageSize != null &&
                PageSize.Equals(other.PageSize)
            ) &&
            (
                Select == other.Select ||
                Select != null &&
                Select.Equals(other.Select)
            ) &&
            (
                Filters == other.Filters ||
                Filters != null &&
                Filters.SequenceEqual(other.Filters)
            ) &&
            (
                Attributes == other.Attributes ||
                Attributes != null &&
                Attributes.SequenceEqual(other.Attributes)
            ) &&
            (
                After == other.After ||
                After != null &&
                After.Equals(other.After)
            ) &&
            (
                Sort == other.Sort ||
                Sort != null &&
                Sort.Equals(other.Sort)
            ) &&
            (
                Expands == other.Expands ||
                Expands != null &&
                Expands.SequenceEqual(other.Expands)
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
            if (PageSize != null)
            {
                hash = hash * 59 + PageSize.GetHashCode();
            }

            if (Select != null)
            {
                hash = hash * 59 + Select.GetHashCode();
            }

            if (Filters != null)
            {
                hash = hash * 59 + Filters.GetHashCode();
            }

            if (Attributes != null)
            {
                hash = hash * 59 + Attributes.GetHashCode();
            }

            if (After != null)
            {
                hash = hash * 59 + After.GetHashCode();
            }

            if (Sort != null)
            {
                hash = hash * 59 + Sort.GetHashCode();
            }

            if (Expands != null)
            {
                hash = hash * 59 + Expands.GetHashCode();
            }

            return hash;
        }
    }
}
