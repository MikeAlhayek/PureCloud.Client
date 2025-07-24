using System.Text;

namespace PureCloud.Client.Models;

/// <summary>
/// Defines a response for a list of SCIM resource types.
/// </summary>

public sealed class ScimConfigResourceTypesListResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ScimConfigResourceTypesListResponse" /> class.
    /// </summary>
    /// <param name="Schemas">The list of supported schemas..</param>



    /// <summary>
    /// The list of supported schemas.
    /// </summary>
    /// <value>The list of supported schemas.</value>
    public IEnumerable<string> Schemas { get; set; }



    /// <summary>
    /// The total number of results.
    /// </summary>
    /// <value>The total number of results.</value>
    public long? TotalResults { get; set; }



    /// <summary>
    /// The 1-based index of the first result returned by this request. Add this to \&quot;itemsPerPage\&quot; when requesting the next page of results.
    /// </summary>
    /// <value>The 1-based index of the first result returned by this request. Add this to \&quot;itemsPerPage\&quot; when requesting the next page of results.</value>
    public long? StartIndex { get; set; }



    /// <summary>
    /// The number of resources returned per page.
    /// </summary>
    /// <value>The number of resources returned per page.</value>
    public long? ItemsPerPage { get; set; }



    /// <summary>
    /// The list of requested resources.
    /// </summary>
    /// <value>The list of requested resources.</value>
    public IEnumerable<ScimConfigResourceType> Resources { get; set; }


    /// <summary>
    /// Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>


    /// <summary>
    /// Returns true if objects are equal
    /// </summary>
    /// <param name="obj">Object to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Returns true if ScimConfigResourceTypesListResponse instances are equal
    /// </summary>
    /// <param name="other">Instance of ScimConfigResourceTypesListResponse to be compared</param>
    /// <returns>Boolean</returns>

    /// <summary>
    /// Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
}
